using Newtonsoft.Json;


namespace OnCall.Web.Code.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson(this object obj)
        {
            if (obj != null)
                return JsonConvert.SerializeObject(obj);
            else
                return null;
        }

        public static T ToObject<T>(this string jsonStr)
        {
            if (!string.IsNullOrEmpty(jsonStr))
                return JsonConvert.DeserializeObject<T>(jsonStr);
            else
                return default(T);
        }

    }
}
