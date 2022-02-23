using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model;

namespace FantasyData.Api.Client;

public abstract class BaseClient
{
    private readonly HttpClient client;

    /// <summary>
    /// The host name for making API calls.
    /// </summary>
    /// <value>Default value is fly.sportsdata.io</value>
    private string Host { get; set; }

    /// <summary>
    /// The client license key used to make API calls.
    /// </summary>
    private string ApiKey { get; set; }

    /// <summary>
    /// Indicates whether API calls will be made over secure https connection.
    /// </summary>
    /// <value>Default value is true</value>
    private bool Https { get; set; }

    /// <summary>
    /// The encoding type to be used in the WebClient for data pulled
    /// </summary>
    /// <value>Default is UTF8</value>
    private Encoding Encoding { get; set; }

    private string Scheme => this.Https ? "https" : "http";


    public BaseClient(string apiKey, HttpClient client)
    {
        this.Host = "api.sportsdata.io";
        this.ApiKey = apiKey.Replace("-", "").ToLower();
        this.Https = true;
        this.Encoding = new UTF8Encoding();
        this.client = client;
        if (!this.client.DefaultRequestHeaders.Contains("Ocp-Apim-Subscription-Key"))
        {
            this.client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", this.ApiKey);
        }

    }

    protected  Task<T> GetAsync<T>(string apiCall) =>  this.GetAsync<T>(apiCall, null);

    protected async Task<T> GetAsync<T>(string apiCall, IList<KeyValuePair<string, string>> parameters)
    {
        return (await this.GetRawAsync<T>(apiCall, parameters)).Item1;
    }
    protected async Task<(T, string)> GetRawAsync<T>(string apiCall, IList<KeyValuePair<string, string>> parameters)
    {
        //client.Encoding = Encoding;

        // Construct url
        var uri = new UriBuilder(this.Scheme, this.Host)
        {
            Path = apiCall
        };
        var url = uri.Uri.ToString().ToLower().Trim();

        // Make sure parameters exist and add format=json
        parameters ??= new List<KeyValuePair<string, string>>();

        parameters.Add(new KeyValuePair<string, string>("format", "json"));

        // Add parameters
        url = parameters.Aggregate(url,
            (current, parameter) =>
                current.Replace("{" + parameter.Key.ToLower() + "}", parameter.Value.ToLower().Trim()));

        // get string from http client get
        var response = await this.client.GetAsync(url);

        if (!response.IsSuccessStatusCode)
        {
            var headers = response.Headers.ToDictionary(h => h.Key, h => h.Value);
            foreach (var item in response.Content.Headers)
            {
                headers[item.Key] = item.Value;
            }
            var responseData = await response.Content.ReadAsStringAsync();
            var headerText = headers.Select(s => s.Key + ":\n" + s.Value.Join("\n")).Join("\n");
            throw new FantasyDataWebException(response.ReasonPhrase, headerText, responseData, response.StatusCode);
        }

        var json = await response.Content.ReadAsStringAsync();
        return (System.Text.Json.JsonSerializer.Deserialize<T>(json), json);
    }
}

internal static class StringExtensions
{
    internal static string Join(this IEnumerable<string> items, string separator)
    {
        if (separator == null)
        {
            throw new ArgumentNullException(nameof(separator));
        }

        if (items == null)
        {
            return null;
        }

        var first = true;
        var sb = new StringBuilder();
        foreach (var item in items)
        {
            if (item != null)
            {
                if (!first)
                {
                    sb.Append(separator);
                }
                else
                {
                    first = false;
                }

                sb.Append(item);
            }
        }

        return sb.ToString();
    }

}