using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Api.Client;

public abstract class BaseClient
{

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

    private readonly HttpClient client;

    public BaseClient(string apiKey)
    {
        this.Host = "api.sportsdata.io";
        this.ApiKey = apiKey.Replace("-", "").ToLower();
        this.Https = true;
        this.Encoding = new UTF8Encoding();
        this.client = new HttpClient();
        this.client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", this.ApiKey);
        //this.client.DefaultRequestHeaders.
    }

    public BaseClient(Guid apiKey) : this(apiKey.ToString()) { }

    protected  Task<T> GetAsync<T>(string apiCall) =>  this.GetAsync<T>(apiCall, null);

    protected async Task<T> GetAsync<T>(string apiCall, IList<KeyValuePair<string, string>> parameters)
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
        var json = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(response.ReasonPhrase);
        }

        //return JsonConvert.DeserializeObject<T>(json);
       //// var x = new System.Text.Json.Serialization.JsonConverter<T>()
        //var json = await response.Content.ReadAsStringAsync();
        //JsonSerializer.Deserialize<Note>(jsonString)
       return System.Text.Json.JsonSerializer.Deserialize<T>(json);
    }
}