using System;

namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Tday = 14;
            int kursor = 1;
            DateTime date1 = new DateTime(2022, 11, 14);

            string T = "1";
            string text1 = "1.Пойти на лекцию";
            string text2 = "2.Сходить на каток";

            string text3 = "1.Купить подарок";
            string text4 = "2.Сходить в магазин";

            string text5 = "1.Поехать на дачу";

            Console.WriteLine("Выбрана дата " + date1 + "");

            while (true)
            {

                

                ConsoleKeyInfo key = Console.ReadKey();

               // Обработка клавиш в цикле
                
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Tday = Tday + 1;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Tday = Tday - 1;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    kursor = kursor - 1;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    kursor = kursor + 1;
                }

              
                
                if (key.Key == ConsoleKey.Escape)
                {
                    date1 = new DateTime(2022, 11, 14);
                }



                // Позиционирование курсора

                if (kursor < 1)
                {
                    kursor = 1;
                }

                if (kursor > 2) 
                {
                    kursor = 1;
                }

                
                //Вывод меню
                date1 =  new DateTime(2022, 11, Tday);

                if (date1 == new DateTime(2022, 11, 15))
            
                {
                    Console.Clear();
                    Console.WriteLine("Выбрана дата " + date1 + "");
                    Console.WriteLine(text1);
                    Console.WriteLine(text2);
                    Console.SetCursorPosition(0, kursor);
                    Console.WriteLine("->");

                    if (kursor == 1)
                    {
                        T = text1;

                    }
                    else if  (kursor == 2)
                    {
                        T = text2;

                    }

                }
                else if (date1 == new DateTime(2022, 11, 16))
                {
                    Console.Clear();
                    Console.WriteLine("Выбрана дата " + date1 + "");
                    Console.WriteLine(text3);
                    Console.WriteLine(text4);
                    Console.SetCursorPosition(0, kursor);
                    Console.WriteLine("->");
                        if (kursor == 1)
                        {
                            T = text3;

                        }
                        else if (kursor == 2)
                        {
                            T = text4;

                        }

                    }

                else if (date1 == new DateTime(2022, 11, 20))
                {
                    Console.Clear();
                    Console.WriteLine("Выбрана дата " + date1 + "");
                    Console.WriteLine(text5);
                    Console.SetCursorPosition(0, kursor);
                    Console.WriteLine("->");
                     T = text5;

                      
                    }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Выбрана дата " + date1 + "");

                }

                    if (key.Key == ConsoleKey.Enter)
                    {

                        if (T == text1)
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата " + date1 + "");
                            Console.WriteLine(T);
                            Console.WriteLine("----------------------------------------------------------------------------------");
                            Console.WriteLine("Лекция информатика");
                            Console.WriteLine("Лекция программирование");
                        }
                        if (T == text2)
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата " + date1 + "");
                            Console.WriteLine(T);
                            Console.WriteLine("----------------------------------------------------------------------------------");
                            Console.WriteLine("С 20:00 До 22:00");
                            
                        }
                        if (T == text3)
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата " + date1 + "");
                            Console.WriteLine(T);
                            Console.WriteLine("----------------------------------------------------------------------------------");
                            Console.WriteLine("Диск с игрой для друга");
                            
                        }
                        if (T == text4)
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата " + date1 + "");
                            Console.WriteLine(T);
                            Console.WriteLine("----------------------------------------------------------------------------------");
                            Console.WriteLine("Купить продукты");

                        }

                    }

                }

        }



    }
}
