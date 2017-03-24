using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace HttpExceptionLibrary
{
    internal static class MesageBuilder
    {
        /// <summary>
        /// Builds the string with specified format.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="format">The format.</param>
        /// <returns>The Specified string.</returns>
        public static string Build(object obj, string format)
        {
            var jObject = JObject.FromObject(obj);

            return FormatMessage(jObject, format);
        }

        private static string FormatMessage(JObject jObj, string format)
        {
            var keys = new Regex(@"{[a-zA-Z\d-_]+}", RegexOptions.Multiline).Matches(format);
            var parameters = keys.Cast<Match>().Select(param => new KeyValuePair<string, object>(param.ToString(), jObj[param.ToString().Trim("{}".ToCharArray())])).ToList();

            return parameters.Aggregate(format, (current, parameter) => current.Replace(parameter.Key, parameter.Value?.ToString() ?? parameter.Key));
        }
    }
}
