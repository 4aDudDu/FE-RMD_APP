using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = @"{""data"":[{""ticketNo"":""TCK"",""dateIn"":""2026-08-20T11:18:31.373"",""weightNetto"":100.5}]}";
        var obj = JObject.Parse(json);
        var listData = obj["data"].ToObject<List<Dictionary<string, object>>>();
        foreach (var item in listData)
        {
            Console.WriteLine(item.ContainsKey("ticketNo"));
            Console.WriteLine(item["dateIn"].GetType().Name);
            Console.WriteLine(item["weightNetto"].GetType().Name);
        }
    }
}