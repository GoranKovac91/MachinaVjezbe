using System;
//zadatak 1:korisnik unosi neki broj n koji je veci od 0 te mu ispisuje zbroj svih brojeva do n,provjeriti jeli unesen int tip 
//zadatak 2:korisnik unosi proizvoljni string ,program ispisuje koliko puta se svaki element u stringu ponavlja
//zadatak 3:program generira rand broj a korisnik mora pogoditi broj , petlja se izvrsava dokle god korisnik ne pogodi broj 
//program govori jeli korisnikov broj manji ili veci od rand broja

namespace OKP1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInt;
            int userInput;
            int sum = 0;
            Console.WriteLine(" Please enter positive integer ");
            string userString = Console.ReadLine();

            while (!int.TryParse(userString, out userInput))
            {
                Console.WriteLine("Please enter a positive integer");
                userString = Console.ReadLine();
                isInt = int.TryParse(userString, out userInput);
                if (isInt == true)
                {
                    break;
                }

            }
            for (int i = 0; i <= userInput; i++)
            {
                sum += i;
            }
            Console.WriteLine(" Sum of numbers = " + sum);


            //zadatak 2

            string userString2;
            Console.WriteLine(" Please enter a string to be tested ");
            userString2 = Console.ReadLine();
            while (userString2.Length > 0)
            {
                int counter = 0;
                for (int j = 0; j < userString2.Length; j++)
                {
                    if (userString2[0] == userString2[j])
                    {
                        counter++;
                    }
                }
                Console.WriteLine(userString2[0] + " = " + counter);
                userString2 = userString2.Replace(userString2[0].ToString(), string.Empty);
            }
            //zadatak 3
            Random r = new Random();
            int genRand = r.Next(1, 31);
            Console.WriteLine("generirani broj " + genRand);
            int userInput3;
            bool isInt3;
            do
            {
                Console.WriteLine("Enter lucky number beetwen 1-30 ,only numbers accepted");
                string str = Console.ReadLine();
                isInt3 = int.TryParse(str, out userInput3);

                if (userInput3 == genRand)
                {
                    Console.WriteLine(" You won ");
                    break;
                }
                else if (userInput3 <= 0 || userInput3 > 30 && isInt3)
                {
                    Console.WriteLine("Only positive numbers between 1-30");

                }
                else if (userInput3 < genRand && isInt3)
                {
                    Console.WriteLine("Number is smaller ,try again");

                }
                else if (userInput3 > genRand && isInt3)
                {
                    Console.WriteLine("Number is greater ,try again");

                }




            } while (!isInt3 || userInput3 != genRand);

