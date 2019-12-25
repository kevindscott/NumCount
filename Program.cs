using System;
using System.Collections.Generic;

namespace NumCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInput = "";
            if(args.Length > 0){
                numberInput = args[0];
                string comdinedNum = "";

                Console.WriteLine(numberInput);

                for(int i=0; i < 3; i++){

                    if(comdinedNum != ""){
                        numberInput = comdinedNum;
                    }

                    List<string> chars = new List<string>();
                    comdinedNum = "";
                    foreach(char ch in numberInput.ToCharArray()){
                        int charCount = 0;

                        charCount = numberInput.Length - numberInput.Replace(ch.ToString(),"").Length;
                        if(!chars.Contains(ch + charCount.ToString())){
                            chars.Add(ch + charCount.ToString());
                            comdinedNum += ch + charCount.ToString();
                        }

                    }

                    Console.WriteLine(comdinedNum);
                }
            }

        }
    }
}
