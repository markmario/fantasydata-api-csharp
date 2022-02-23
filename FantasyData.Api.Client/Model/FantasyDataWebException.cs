using System;
using System.Net;

namespace FantasyData.Api.Client.Model;

public sealed class FantasyDataWebException : Exception
{
    public FantasyDataWebException(string responseReasonPhrase, string headerText, string responseData, HttpStatusCode responseStatusCode): base(responseReasonPhrase)
    {
        this.ResponseReasonPhrase = responseReasonPhrase;
        this.HeaderText = headerText;
        this.ResponseData = responseData;
        this.ResponseStatusCode = responseStatusCode;
    }

    public HttpStatusCode ResponseStatusCode { get; set; }

    public string HeaderText { get; set; }

    public string ResponseData { get; set; }

    public string ResponseReasonPhrase { get; set; }

    public override string ToString()
    {
        return
            $"HTTP Response: {this.ResponseStatusCode} - {this.ResponseReasonPhrase}  \n\n Headers:\n {this.HeaderText} \n\n ResponseData:\n {this.ResponseData}  \n\n{base.ToString()}";
    }
}