    using System;

    namespace Rage_Expenses
    {
        class Program
        {
            static void Main(string[] args)
            {
                int lostGamesCount = int.Parse(Console.ReadLine());
                double headsetPrice = double.Parse(Console.ReadLine());
                double mousePrice = double.Parse(Console.ReadLine());
                double keyboardPrice = double.Parse(Console.ReadLine());
                double displayPrice = double.Parse(Console.ReadLine());

                double sumExpHeadster = 0;
                double sumExpMouse = 0;
                double sumExpKeyboard = 0;
                double sumExpDisplay = 0;

                int countTrashKeyboard = 0;


                for (int i = 1; i <= lostGamesCount; i++)
                {
                    int countTrashHeadste = 0;
                    int countTrashMouse = 0;
                    if (i % 2 == 0)
                    {
                        countTrashHeadste++;
                        sumExpHeadster += headsetPrice;
                    }
                    if (i % 3 == 0)
                    {
                        countTrashMouse++;
                        sumExpMouse += mousePrice;
                    }
                    if (countTrashHeadste == 1 && countTrashMouse == 1)
                    {
                        countTrashKeyboard++;
                        sumExpKeyboard += keyboardPrice;
                    }
                    if (countTrashKeyboard % 2 == 0 && countTrashKeyboard != 0)
                    {
                        countTrashKeyboard = 0;
                        sumExpDisplay += displayPrice;
                    }

                }


                Console.WriteLine($"Rage expenses: {sumExpDisplay + sumExpHeadster + sumExpKeyboard + sumExpMouse:F2} lv.");

            }
        }
    }
