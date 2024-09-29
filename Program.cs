namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай сыграем в игу угадай число от 1 до 5.\n у тебя 3 попытки");
            
            
            int mynumber;
            for (int i = 0; i < 3; i++)
            { Random rand = new Random();
                int numb = rand.Next(6);
                mynumber = int.Parse(Console.ReadLine());

                if (numb == mynumber)
                {
                    Console.WriteLine($"Компьютер загадал:{numb}\n Ты выиграл");
                    break;
                }
                else
                {
                    Console.WriteLine($"Компьютер загадал:{numb}\n Ты проиграл!");
                }



                
            


            }
            




        }
    }
}
