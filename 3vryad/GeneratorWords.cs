using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3vryad
{
    internal class GeneratorWords
    {
        public static Tuple<string, string> Create()
        {
            Dictionary<string, string> dictinory = new Dictionary<string, string>(); 
            using (StreamReader reader = new StreamReader("1.txt"))
            {
                while (!reader.EndOfStream)
                {
                string task1= reader.ReadLine();
                string task2= reader.ReadLine();
                if (!dictinory.ContainsKey(task1))
                {
                    dictinory.Add(task1, task2);
                }

                }
                reader.Close();
            }
            int size = dictinory.Count;
            Random random = new Random();
            int value = random.Next(size);
            foreach(var item in dictinory)
            {
                if (value==0)
                {
                return new Tuple<string, string>(item.Key, item.Value);

                }
                value--;
            }
            throw new ArgumentException("Вопросов нет");
                
        }
    }
}
