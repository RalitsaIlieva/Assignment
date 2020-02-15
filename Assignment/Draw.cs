using System;

namespace Assignment
{
    public class Draw
    {
        private int N { get; set; }

        /// <summary>
        /// Принтира се първата половина.
        /// </summary>
        private void FirstHalf()
        {
            string dash = "";
            string star = "";
            string dashInLetter = "";
            for (int i = 0; i < N; i++)
            {
                dash += "-";
                star += "*";
                dashInLetter += "-";
            }
            for (int k = 0; k <= N / 2; k++)
            {
                if (k != 0)
                {
                    dashInLetter = dashInLetter.Substring(0, dashInLetter.Length - 2);
                    dash = dash.Substring(0, dash.Length - 1);
                    star = star + "**";
                }
                for (int i = 0; i < N * 10; i++)
                {
                    Console.Write(dash + star + dashInLetter + star + dash);
                    i += N * 5;
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Принтира се втората половина.
        /// </summary>
        private void SecondHalf()
        {
            string dash = "";
            string dashInLetter = "";
            for (int i = 0; i < N; i++)
            {
                dash += "-";
                dashInLetter += "-";
            }
            for (int k = 0; k < N / 2; k++)
            {
                dashInLetter = dashInLetter.Substring(0, dashInLetter.Length - 2);
                dash = dash.Substring(0, dash.Length - 1);
            }

            string star = "";
            string starInTheMiddleOfTheLetter = "";
            for (int i = 0; i < N; i++)
            {
                star += "*";
            }

            dash = dash.Substring(0, dash.Length - 1);
            for (int i = 0; i < N + (N - 1); i++)
            {
                starInTheMiddleOfTheLetter += "*";
            }

            for (int k = 0; k <= N / 2; k++)
            {
                for (int i = 0; i < N * 10; i++)
                {
                    Console.Write(dash + star + dashInLetter + starInTheMiddleOfTheLetter + dashInLetter + star + dash);
                    i += N * 5;
                }
                Console.WriteLine();
                if (k != N / 2)
                {
                    dashInLetter = dashInLetter + "--";
                    dash = dash.Substring(0, dash.Length - 1);
                    starInTheMiddleOfTheLetter = starInTheMiddleOfTheLetter.Substring(0, starInTheMiddleOfTheLetter.Length - 2);
                }
            }
        }

        /// <summary>
        /// Метод, който съдържа предните методи в себе си, 
        /// и който се извиква на обекта, инстанциализиран в основния метод. 
        /// </summary>
        public void Print()
        {
            N = Int32.Parse(Console.ReadLine());
            Check();
            FirstHalf();
            SecondHalf();
        }

        /// <summary>
        /// Прави се проверка подаденото число да не излиза от желаните рамки.
        /// </summary>
        private void Check()
        {
            if (N < 2 || N > 10000)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (N % 2 == 0)
            {
                throw new ArgumentException();
            }
        }
    }
}


