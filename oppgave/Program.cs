using System.Collections;

 


 

namespace oppgave;
 


 

class Program
 

{
 

    static void Main(string[] args)
 

    {
 

        bool loopRunning = true;
 

        Console.WriteLine("Hello, whats the temperutre!");
 

       while (loopRunning)
 

       {
 

        
 

        string input = Console.ReadLine();
 

       
 

        if (input != null && int.TryParse(input, out int Temp))
 

        {
 


 


 


 

            switch (Temp)
 

            {
 

                case > 30:
 

                    {
 

                        Console.WriteLine("its too hot");
 

                        loopRunning = false;
 

                        break;
 

                    }
 

                case > 20:
 

                    {
 

                        Console.WriteLine("its perfect for fishing");
 

                            loopRunning = false;
 

                            break;
 

                    }
 


 

                case > 10:
 

                    {
 

                        Console.WriteLine("its kinda cold");
 

                            loopRunning = false;
 

                            break;
 

                    }
 

                case > 0:
 

                    {
 

                        Console.WriteLine("feeling cold");
 

                            loopRunning = false;
 

                            break;
 

                    }
 

                case < 0:
 

                    { Console.WriteLine("its freezing");
 

                            loopRunning = false;
 

                        }
 

                    break;
 

                default:
 

                    {
 

                        Console.WriteLine("not a perfect temperture");
 

                            loopRunning = false;
 

                            break;
 

                    }
 

            }
 

        }
 

        else
 

        {Console.WriteLine("enter a valid number");
 

            }
 

  
 


 


 


 

    }}
 

}
