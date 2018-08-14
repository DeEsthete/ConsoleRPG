using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// дополнительная информация по игре находится в Excel файле(RPG)
// начальный сюжет и история мира находится в word документе(Сюжет)

//работа над игрой будет продолжатся, будет дописано следующие
/*
 * 1)Редактор персонажа
 * 2)Будут реализованы способности персонажжа
 * 3)Создано еще больше объектов оружия, брони, локация и персонажей
 * 4)Будут реализованы NPC
 * 5)Будет написана инстуркция по управлению
 */

namespace Patern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> startImage = new List<string>();
            //
            startImage.Add("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");//1
            startImage.Add("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");//2
            startImage.Add("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");//3
            startImage.Add("░█░█░█░█▀▀▀░█░░░░█▀▀▀░█▀▀█░█▀█▀█░█▀▀▀░░░░░░░░░░░░░");//4
            startImage.Add("░█░█░█░█▀▀▀░█░░░░█░░░░█░░█░█░█░█░█▀▀▀░░░░░░░░░░░░░");//5
            startImage.Add("░▀▀▀▀▀░▀▀▀▀░▀▀▀▀░▀▀▀▀░▀▀▀▀░▀░▀░▀░▀▀▀▀░░░░░░░░░░░░░");//6
            startImage.Add("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");//7
            startImage.Add("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");//8
            startImage.Add("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");//9
            startImage.Add("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");//10
            Message.DrawImage(startImage);

            Character player = new Character(3000, "Степан", "Степан всемогущий", 100, 1, 100, 100, 100, 100, 10, 10, CharacterTypeEnum.Player, new Inventar());
            player.Inventar.AddItem(new Spear(2019, "Копье для охоты", Rarity.Common, 210, "Копье используемое в основном людьми для охоты на разную живность леса", 15));
            Game game = Game.getInstance();
            game.Player = player;
            game.GameWork();
            FileWrite(game);
            Console.ReadLine();
        }

        #region FileWork
        //Json
        private static string path = (Directory.GetCurrentDirectory() + "data.data");

        private static void FileWrite(Game game)
        {
            string serializedCharacters = JsonConvert.SerializeObject(game);
            string serializedItems = JsonConvert.SerializeObject(game);
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(serializedCharacters);
            }
        }

        private static Game FileRead()
        {
            string serialized;

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                serialized = sr.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<Game>(serialized);
        }
        #endregion
    }
}
