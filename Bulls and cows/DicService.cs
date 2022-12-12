using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_cows
{
    public class DicService
    {
        public List<string> words;
        public DicService() 
        {
            words = new List<string>();
        }
        public List<string> getwords()
        {
            string text = (System.IO.File.ReadAllText(@"C:\Users\pjace\source\repos\Bulls and cows\Bulls and cows\dictionary.txt"));
            string[] arr = text.Split(' ');
            foreach (var item in arr)
            {
                words.Add(item);
            }
            return words;
        }
        public string randomword(List<string> words)
        {
            int wordcount = words.Count();
            Random rnd = new Random();
            string word = words[rnd.Next(0, wordcount)];
            return word;
        }
    }
}
