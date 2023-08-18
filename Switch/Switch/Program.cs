using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    { 

        enum Priority
    {
            One = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven


    }
    
        static void Main(string[] args)
        {

            var priority = Priority.Three;

            // Komentarz: Kod bedzie dzialac, ale nie wyglada to dobrze, poniżej jest switchowanie.
            if (priority == Priority.One)
            {
                //cos tam robimy1
            }
            if (priority == Priority.Two)
            {
                //cos tam robimy2
            }
            if (priority == Priority.Three)
            {
                //cos tam robimy3
            }
            if (priority == Priority.Four)
            {
                //cos tam robimy4
            }
            if (priority == Priority.Five || priority == Priority.Six || priority == Priority.Seven)
            {
                //cos tam robimy5
            }

            switch (priority)
            {
                case Priority.One:
                    {

                    }break;
                case Priority.Two:
                    {

                    }
                    break;
                case Priority.Three:
                    {

                    }
                    break;
                case Priority.Four:
                    {

                    }       
                    break;
                case Priority.Five:
                case Priority.Six:
                case Priority.Seven:
                    {

                    }
                    break;
            


            }

            var number = 5;
            switch (number)
            {
                case 3:
                    {

                    }break;
                case 4:
                    {

                    }break;
                default:
                    {

                    }break;
            }



            Console.WriteLine(priority.ToString());
        }
    }
}
