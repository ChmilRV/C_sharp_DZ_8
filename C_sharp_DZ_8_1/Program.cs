using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Создать примитивный англо-русский и русско-английский словарь,
содержащий пары слов — названий стран на русском и английском языках.
Пользователь должен иметь возможность выбирать направление перевода и запрашивать перевод*/
namespace C_sharp_DZ_8_1
{
 
    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>()
            {
                ["Австралия"] = "Australia",
                ["Австрия"] = "Austria",
                ["Азербайджан"] = "Azerbaijan",
                ["Албания"] = "Albania",
                ["Алжир"] = "Algeria",
                ["Ангола"] = "Angola",
                ["Андорра"] = "Andorra",
                ["Антигуа и Барбуда"] = "Antigua and Barbuda",
                ["Аргентина"] = "Argentina",
                ["Армения"] = "Armenia",
                ["Афганистан"] = "Afghanistan",
            };
            WriteLine("Содержимое словаря:");
            foreach (KeyValuePair<string, string> word in myDict)
            {
                WriteLine($"{word.Key}\t\t{word.Value}");
            }
            WriteLine("Выбор направления перевода\n" +
                "1 - Рус - Англ\n" +
                "2 - Англ - Рус");
            switch (ReadLine())
            {
                case "1":
                    WriteLine("Введите слово для перевода:");
                    string key;
                    if (myDict.TryGetValue(ReadLine(), out key))
                    {
                        WriteLine(key);
                    }
                    else
                    {
                        WriteLine("Нет в словаре.");
                    }
                    break;
                case "2":
                    WriteLine("Введите слово для перевода:");
                    string _Value = ReadLine();
                    if (myDict.ContainsValue(_Value))
                    {
                        WriteLine(myDict[_Value]);
                    }
                    else
                    {
                        WriteLine("Нет в словаре.");
                    }
                    break;


            }




            






            ReadKey();
        }
    }
}
