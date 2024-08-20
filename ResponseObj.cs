using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("text")]
    public string text { get; set; }

    [JsonProperty("confidence")]
    public int confidence { get; set; }

    [JsonProperty("words")]
    public int words { get; set; }

    [JsonProperty("characters")]
    public int characters { get; set; }

    [JsonProperty("lines")]
    public int lines { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
