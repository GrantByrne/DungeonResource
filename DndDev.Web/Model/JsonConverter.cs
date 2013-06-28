using System.IO;
using Newtonsoft.Json;
using DndDev.Domain.Spell;

namespace DndDev.Web.Model
{
    public static class ObjectExtensions
    {
        public static string ToJson(this Spell obj)
        {
            JsonSerializer js = JsonSerializer.Create(new JsonSerializerSettings());
            var jw = new StringWriter();
            js.Serialize(jw, obj);
            return jw.ToString();
        }
    }
}