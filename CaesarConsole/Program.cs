using CaesarLibrary;
using System;

namespace CaesarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            
            Console.WriteLine("Welcome to Caesar encryption/decryption program.");

            while (repeat)
            {
                bool askAgain = false;
                bool encrypt = false;
                int offset = 0;
                do
                {
                    Console.Write("You want to (E)ncrypt or (D)ecrypt: ");
                    string option = Console.ReadLine();
                    switch (Char.ToLower(option[0]))
                    {
                        case 'e':
                            encrypt = true;
                            askAgain = false;
                            break;
                        case 'd':
                            encrypt = false;
                            askAgain = false;
                            break;
                        default:
                            askAgain = true;
                            break;
                    }
                } while (askAgain);

                do
                {
                    Console.Write("Enter offset (number): ");
                    string number = Console.ReadLine();

                    askAgain = !int.TryParse(number, out offset);
                } while (askAgain);


                Console.Write("Enter message you want to "+ (encrypt? "encrpyt" : "decrpyt") + ": ");
                string message = Console.ReadLine();

                if (encrypt) Console.WriteLine("Your encrypted message is: " + CaesarCypher.Encrypt(message, offset));
                else Console.WriteLine("Your decrypted message is: " + CaesarCypher.Decrypt(message, offset));
                Console.WriteLine();
                do
                {
                    Console.Write("You want to try again? ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Y");
                    Console.ResetColor();
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("N");
                    Console.ResetColor();
                    Console.WriteLine();
                    string idk = Console.ReadLine();

                    switch (idk.ToLower())
                    {
                        case "n":
                            repeat = false;
                            askAgain = false;
                            break;
                        case "y":
                            askAgain = false;
                            break;
                        default:
                            askAgain = true;
                            break;
                    }
                }while (askAgain);
                Console.Clear();
            }
            

            Console.WriteLine("Thanks for trying out my program :)");

        }
    }
}
