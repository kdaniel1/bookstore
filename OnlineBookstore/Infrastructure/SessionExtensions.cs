using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace OnlineBookstore.Infrastructure
{
    //this is a tool to convert our Cart object to a Json file then back. This is to solve the problem that we can't store Cart objects in a session.
    public static class SessionExtensions
    {
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
