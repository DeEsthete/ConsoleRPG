using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public static class GameDataManager
    {
        private static string path = (Directory.GetCurrentDirectory() + "data.data");

        public static Character GetCharacter(int characterId)
        {
            string serialized;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                serialized = sr.ReadToEnd();
            }
            List<Character> characters = JsonConvert.DeserializeObject<List<Character>>(serialized);
            
            Character character = null;
            foreach(var i in characters)
            {
                if (i.Id == characterId)
                {
                    character = i;
                    break;
                }
            }
            return character;
        }

        public static Item GetItem(int itemId)
        {
            string serialized;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                serialized = sr.ReadToEnd();
            }
            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(serialized);

            Item item = null;
            foreach(var i in items)
            {
                if(i.Id == itemId)
                {
                    item = i;
                    break;
                }
            }
            return item;
        }

        public static Location GetLocation(int locationId)
        {
            string serialized;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                serialized = sr.ReadToEnd();
            }
            List<Location> locations = JsonConvert.DeserializeObject<List<Location>>(serialized);

            Location location = null;
            foreach (var i in locations)
            {
                if (i.Id == locationId)
                {
                    location = i;
                    break;
                }
            }
            return location;
        }

        public static Effect GetEffect(int effectId)
        {
            string serialized;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                serialized = sr.ReadToEnd();
            }
            List<Effect> effects = JsonConvert.DeserializeObject<List<Effect>>(serialized);

            Effect effect = null;
            foreach (var i in effects)
            {
                if (i.Id == effectId)
                {
                    effect = i;
                    break;
                }
            }
            return effect;
        }

        public static Skill GetSkill(int skillId)
        {
            string serialized;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                serialized = sr.ReadToEnd();
            }
            List<Skill> skills = JsonConvert.DeserializeObject<List<Skill>>(serialized);

            Skill skill = null;
            foreach (var i in skills)
            {
                if (i.Id == skillId)
                {
                    skill = i;
                    break;
                }
            }
            return skill;
        }
    }
}
