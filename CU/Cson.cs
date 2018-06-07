using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

class Cson<T>
{
    public static string Parse(T t)
    {
        return JsonConvert.SerializeObject(t);
    }

    public static T DeParse(string strData)
    {
        return JsonConvert.DeserializeObject<T>(strData);
    }

    public static List<T> ArrParse(string mainData)
    {
        var resultArr = new List<T>();
        var jarr = JArray.Parse(mainData);
        foreach (var jstr in jarr)
        {
            resultArr.Add(DeParse(jstr.ToString()));
        }

        return resultArr;
    }
}