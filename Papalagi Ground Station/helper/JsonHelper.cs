using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Papalagi_Ground_Station.helper
{
    public static class JsonHelper
    {
        public static string AsJsonList<T>(List<T> json)
        {
            return JsonSerializer.Serialize(json);
        }
        public static string AsJson<T>(T json)
        {
            return JsonSerializer.Serialize(json);
        }
        public static List<T> AsObjectList<T>(string json)
        {
            var jsonBody = json.Substring(1, json.Length - 2);
            jsonBody = jsonBody.Replace('}', '{');
            string[] dataWithBracesList = jsonBody.Split('{');
            List<T> dataList = new List<T>();

            for (int i = 0; i < dataWithBracesList.Length; i++)
            {
                if (i % 2 != 0)
                {
                    var data = "{" + dataWithBracesList[i] + "}";
                    dataList.Add(JsonSerializer.Deserialize<T>(data));
                }
            }
            return dataList;
        }
        public static T AsObject<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
