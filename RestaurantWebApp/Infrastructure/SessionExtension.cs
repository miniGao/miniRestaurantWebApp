using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp.Infrastructure
{
    public static class SessionExtension
    {
        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return (sessionData == null) ? default(T) : JsonConvert.DeserializeObject<T>(sessionData);
        }
        public static void SetJson(this ISession session, string key, object data)
        {
            session.SetString(key, JsonConvert.SerializeObject(data));
        }
    }
}
