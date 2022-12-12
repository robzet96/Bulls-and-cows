using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_cows
{
    public class Engine
    {
        Stats _stat;
        public Engine()
        {
            _stat = new Stats();
        }
        public string WordCheck(string word, string playerword)
        {
            _stat.bulls = 0;
            _stat.cows = 0;           
            for (int i = 0; i < playerword.Length; i++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (playerword[i] == word[j] && i == j)
                    {
                        _stat.bulls++;
                    }
                    else if (playerword[i] == word[j])
                    {
                        _stat.cows++;
                    }
                }
            }
            _stat.attempt--;
            string result = gameresult(playerword, word, _stat.bulls, _stat.cows);
            return result;
        }
        public string PlayerWord()
        {
            Console.WriteLine("Enter your guess: ");
            string word = Console.ReadLine();
            return word;
        }
        public bool playerattempt(string word, string playerword)
        {
            bool isbull = false;
            if (word == playerword)
            {
                isbull = true;
            }
            else if (_stat.attempt == 1)
            {
                Console.WriteLine("You lost all your attempts.");
                isbull = true;
            }
            return isbull;
        }
        private string gameresult(string playerword, string word, int bulls, int cows)
        {
            string result;
            if (word == playerword)
            {
                result = $"The word is {playerword} you got it with {_stat.attempt} attempts left";
        }
            else
            {
                result = $"Bulls: {_stat.bulls} Cows: {_stat.cows} Attempts left: {_stat.attempt}";
            }
            return result;
        }
        public void attemptsreset()
        {
            _stat.attempt = 10;
        }
    }
}
