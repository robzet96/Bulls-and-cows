using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulls_and_cows
{
    public class Validator
    {
        public bool izogram(string playerword)
        {
            bool isizogram = true;
            char[] arr = playerword.ToCharArray();
            for (int i = 0; i < playerword.Length; i++)
            {
                for (int j = i + 1; j < playerword.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isizogram = false;
                        break;
                    }
                }
            }
            return isizogram;
        }        
    }
}
