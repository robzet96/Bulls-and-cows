using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_cows
{
    public class Menu
    {
        public Validator _val;
        public Engine _eng;
        public DicService _dic;
        public Menu()
        {
            _val = new Validator();
            _eng = new Engine();
            _dic = new DicService();
        }
        public string Options()
        {
            string choice = string.Empty;
            Console.WriteLine("1. New game");
            Console.WriteLine("2. Rules");
            Console.WriteLine("3. Exit");
            choice = Console.ReadLine();
            return choice;
        }
        public void Run(string choice)
        {           
            switch (choice)
            {
                case "1":
                    string word = _dic.randomword(_dic.getwords());
                    while (true)
                    {
                        string playerword = _eng.PlayerWord();
                        if (_val.izogram(playerword))
                        {
                            if (!_eng.playerattempt(word, playerword))
                            {
                                Console.WriteLine(_eng.WordCheck(word, playerword));
                            }
                            else
                            {
                                Console.WriteLine(_eng.WordCheck(word, playerword));
                                _eng.attemptsreset();
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("It is not isogram.");
                        }
                    }
                    Run(Options());
                    break;
                case "2":
                    Console.WriteLine("Computer will draw the word and you have to guess it.\n" +
                        "You got 10 attempts to do it\n" +
                        "Number of cows it is a number of letters\n" +
                        "that appear in secret word but not in same position like in your word\n" +
                        "Number of bulls it is a number of letters\n" +
                        "that appear in secret word in same place like in your word.\n");
                    Thread.Sleep(15000);
                    Console.Clear();
                        Run(Options());
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("No option like this. Sorry");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Run(Options());
                    break;
            }
        }
    }
}