using Newtonsoft.Json;


namespace OnCall.Web.Code.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson(this object obj)
        {
            if (obj != null)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                return JsonConvert.SerializeObject(obj, settings);
            }
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
