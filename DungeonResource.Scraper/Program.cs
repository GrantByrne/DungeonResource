using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using DungeonResource.Components.Domain.Domain;
using System.Collections.Specialized;
using DungeonResource.Components.Repository;
using DungeonResource.Components.Domain.Skill;

namespace DungeonResource.Scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var conn = new SQLiteConnection(@"Data Source=dnd35.db"))
            {
                //conn.Open();
                //string query = @"SELECT * FROM skill;";

                //var command = conn.CreateCommand();
                //command.CommandText = query;
                //command.Connection = conn;

                //var reader = command.ExecuteReader();

                //var domains = new List<Skill>();

                //while (reader.Read())
                //{
                //    var values = reader.GetValues();
                //    domains.Add(Map(values));
                //}

                //var domainRepository = new DomainRepository();
                //foreach(var domain in domains)
                //{
                //    domainRepository.Create(domain);
                //}
                
            }
        }

        //private static Skill Map(NameValueCollection nameValueCollection)
        //{
        //    return new Skill
        //    {
        //        Name = nameValueCollection["name"],
        //        SubType = nameValueCollection["subtype"],
        //        KeyAbility = nameValueCollection["key_ability"],
        //        Psionic = nameValueCollection["psionic"] == "Yes" ? true : false,
        //        Trained = nameValueCollection["trained"] == "Yes" ? true : false,
        //        ArmorCheck = nameValueCollection["armor_check"] == "Yes" ? true : false,
        //        Description = nameValueCollection["description"],
        //        SkillCheck = nameValueCollection["skill_check"],
        //        Action = nameValueCollection["action"],
        //        TryAgain = nameValueCollection["try_again"],
        //        Special = nameValueCollection["special"],
        //        Restriction = nameValueCollection["restriction"],
        //        Synergy = nameValueCollection["synergy"],
        //        EpicUse = nameValueCollection["epic_use"],
        //        Untrained = nameValueCollection["untrained"],
        //        FullText = nameValueCollection["full_text"],
        //        Reference = nameValueCollection["reference"]
        //    };
        //}
    }
}
