using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4. Подсчитать, сколько раз каждое слово встречается в заданном тексте.
Результат записать в коллекцию Dictionary<TKey, TValue>.*/
namespace C_sharp_DZ_8_4
{


    class Program
    {


        static void Main(string[] args)
        {
            Title = "C_sharp_DZ_8_4";
            string testText = "Карл у Клары украл кораллы а Клара у Карла украла кларнет. Если бы Карл у Клары не украл кораллы, то Клара у Карла не украла б кларнет";
            string[] testTextString = testText.Split(' ');
            Dictionary<string, int> myColl = new Dictionary<string, int>();
            myColl.Add(testTextString[0], 1);
            foreach (string word in testTextString)
            {

                myColl.Add(word, 1);

            }



            ReadKey();
        }
    }
}
