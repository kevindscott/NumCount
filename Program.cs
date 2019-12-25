using System;
using System.Collections.Generic;

namespace NumCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInput = "";
            int interate = 3;
            if(args.Length > 0){
                numberInput = args[0];

                if(args[1] != null){
                    interate = int.Parse(args[1]); 
                }

                string comdinedNum = "";

                Console.WriteLine(numberInput);

                for(int i=0; i < interate; i++){

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
