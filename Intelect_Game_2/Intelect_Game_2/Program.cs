using System;
using System.Threading;
namespace Intelect_game
{
    class Program
    {

        static void Main()
        {
            string answer_3 = " "; /* для записи ответа на третий вопрос*/
            string cont = " ";
            int answer_2 = 0; /* для записи ответа на второй вопрос*/
            int answer_1 = 0; /*для записи ответа на первую задачу*/
            int choose = 0; /* для выбора задач*/
            int max_points = 5; /*максимальное кол-во очков*/
            int level = 0; /* пользователь выбирает уровень сложности */
            int points = 0; /* для записи очков*/
            string word1, word2, word3, word4, word5; /* для записи слов*/
            Console.Title = "Анаграммы и логические задачи";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("С чего начать? Анаграммы - 1, логические задачи - 2");
            Console.ForegroundColor = ConsoleColor.White;
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Задания на развитие мышления");
                Thread.Sleep(1000);
                Console.WriteLine("Анаграмма - приём, состоящий в перестановке букв, что в результате даёт другое слово.");
                Console.WriteLine("Для того, чтобы начать нажмите пробел");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Выберите уровень сложности(цифра+enter): ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1-ый уровень");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2-ой уровень");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("3-ий уровень");
                Console.ForegroundColor = ConsoleColor.White;
                level = Convert.ToInt32(Console.ReadLine());
                if (level == 1)
                {
                    Console.WriteLine("Переставьте буквы в словах так, чтобы получилось другое слово (писать везде с большой буквы)");
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Первое слово: Ромашка.");
                        word1 = Convert.ToString(Console.ReadLine());
                        if (word1 == "Мошкара")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас отсалось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Мошкара");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Второе слово: Атлас.");
                        word2 = Convert.ToString(Console.ReadLine());
                        if (word2 == "Салат")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Салат");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Третье слово: Шнурок.");
                        word3 = Convert.ToString(Console.ReadLine());
                        if (word3 == "Коршун")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Коршун");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Четвертое слово: Ракета.");
                        word4 = Convert.ToString(Console.ReadLine());
                        if (word4 == "Карета")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Карета");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Пятое слово: Банка.");
                        word5 = Convert.ToString(Console.ReadLine());
                        if (word5 == "Кабан")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Кабан");
                            Console.WriteLine("-------------");
                        }
                    }
                    Console.WriteLine("Всего вы зарабоатли " + points + " из " + max_points + " возможных");
                    if (points == 5 || points == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Отличный результат!");
                        Console.ForegroundColor = ConsoleColor.White;
                        
                    }
                    if (points == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вам стоит больше развивать логику!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (points == 2 || points == 1 || points == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Срочно займитесь своим словарным запасом и логикой!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    for (; ; )
                    {
                        Console.WriteLine("Хотите выполнить логические задачи? Y - да, N - нет");
                        cont = Convert.ToString(Console.ReadLine());
                        if (cont != "N" && cont != "n")
                        {
                            Logic_Tasks(answer_1, answer_2, answer_3);
                            Console.WriteLine();
                        }
                        else
                        {
                            break;                            
                        }
                    }
                }
                if (level == 3)
                {
                    Console.WriteLine("В этих парах слов нужно переставить буквы так, чтобы получились названия овощей и фруктов (писать везде с большой буквы)");
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Первое слово: Стан + Осип.");
                        word1 = Convert.ToString(Console.ReadLine());
                        if (word1 == "Патиссон")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попыток(ки)!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Патиссон");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Второе слово: Сук + Барин.");
                        word2 = Convert.ToString(Console.ReadLine());
                        if (word2 == "Брусника")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Брусника");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Третье слово: Родина + Сом.");
                        word3 = Convert.ToString(Console.ReadLine());
                        if (word3 == "Смородина")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Смородина");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Четвертое слово: Пень + Сила.");
                        word4 = Convert.ToString(Console.ReadLine());
                        if (word4 == "Апельсин")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Апельсин");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Пятое слово: Соки + Бра.");
                        word5 = Convert.ToString(Console.ReadLine());
                        if (word5 == "Абрикос")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Абрикос");
                            Console.WriteLine("-------------");
                        }
                    }
                    Console.WriteLine("Всего вы зарабоатли " + points + " из " + max_points + " возможных");
                    if (points == 5 || points == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Отличный резульат");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (points == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вам стоит больше развивать логику!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (points == 2 || points == 1 || points == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Срочно займитесь своим словарным запасом и логикой!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    for (; ; )
                    {
                        Console.WriteLine("Хотите выполнить логические задачи? Y - да, N - нет");
                        cont = Convert.ToString(Console.ReadLine());
                        if (cont != "N" && cont != "n")
                        {
                            Logic_Tasks(answer_1, answer_2, answer_3);
                            Console.WriteLine();
                        }
                        else
                        {
                            break;

                        }
                    }
                }
                if (level == 2)
                {
                    Console.WriteLine("Необходимо из букв сформировать слова (Писать все с большой буквы).");
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Первое слово: Покметьрю");
                        word1 = Convert.ToString(Console.ReadLine());
                        if (word1 == "Компьютер")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Вы ничего не заработали!");
                            Console.WriteLine("Правильный ответ: Компьютер");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Второе слово: Томирон");
                        word2 = Convert.ToString(Console.ReadLine());
                        if (word2 == "Монитор")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Попытки закончились!");
                            Console.WriteLine("Правильный ответ: Монитор");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Третье слово: Терринп");
                        word2 = Convert.ToString(Console.ReadLine());
                        if (word2 == "Принтер")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Попытки закончились!");
                            Console.WriteLine("Правильный ответ: Принтер");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Четвертое слово: Ковдодси");
                        word2 = Convert.ToString(Console.ReadLine());
                        if (word2 == "Дисковод")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Попытки закончились!");
                            Console.WriteLine("Правильный ответ: Дисковод");
                            Console.WriteLine("-------------");
                        }
                    }
                    for (int tryes = 3; tryes >= 0; tryes--)
                    {
                        Console.WriteLine("Пятое слово: Рампагром");
                        word2 = Convert.ToString(Console.ReadLine());
                        if (word2 == "Программа")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Верно!");
                            Console.WriteLine("Вы заработали один балл!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("-------------");
                            points += 1;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ответ неверный!");
                            Console.WriteLine("У вас осталось " + tryes + " попытки");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (tryes == 0)
                        {
                            Console.WriteLine("Попытки закончились!");
                            Console.WriteLine("Правильный ответ: Программа");
                            Console.WriteLine("-------------");
                        }
                    }
                    Console.WriteLine("Всего вы зарабоатли " + points + " из " + max_points + " возможных");
                    if (points == 5 || points == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Отличный резульат");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (points == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Вам стоит больше развивать логику!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (points == 2 || points == 1 || points == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Срочно займитесь своим словарным запасом и логикой!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    for (; ; )
                    {
                        Console.WriteLine("Хотите выполнить логические задачи? Y - да, N - нет");
                        cont = Convert.ToString(Console.ReadLine());
                        if (cont != "N" && cont != "n")
                        {
                            Logic_Tasks(answer_1, answer_2, answer_3);
                            Console.WriteLine();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            if (choose == 2)
            {
                Logic_Tasks(answer_1, answer_2, answer_3, points, max_points);
            }
            static void Logic_Tasks(int answer_1 = 0, int answer_2 = 0,  string answer_3 = " ", int points = 0, int max_points = 3)
            {                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Логические задачи");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("№1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Сколько граней имеет не отточенный шестигранный карандаш? Ответ запишите цифрой.");
                for (int tryes = 3; tryes >= 0; tryes--)
                {
                    Console.Write("Ответ: ");
                    answer_1 = Convert.ToInt32(Console.ReadLine());
                    if (answer_1 == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Верно!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Вы заработали одно очко!");
                        points += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверно!");
                        Console.WriteLine("У вас осталось " + tryes + " попытки");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (tryes == 0)
                    {
                        Console.WriteLine("Вы ничего не заработали!");
                        Console.WriteLine("Правильный ответ: 6 боковых граней и 2 грани с торцов.");
                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("№2");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Поставьте правильное число вместо вопросительного знака: ");
                Console.Write("4  5  6  7  8  9");
                Console.WriteLine();
                Console.Write("61 52 63 94 46 ?");
                Console.WriteLine("");
                for (int tryes = 3; tryes >= 0; tryes--)
                {
                    Console.Write("Ответ: ");
                    answer_2 = Convert.ToInt32(Console.ReadLine());
                    if (answer_2 == 18)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Верно!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Вы заработали одно очко!");
                        points += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверно!");
                        Console.WriteLine("У тебя осталось " + tryes + " попытки");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (tryes == 0)
                    {
                        Console.WriteLine("Вы ничего не заработали!");
                        Console.WriteLine("Правильный ответ: 18. Числа нижнего ряда - квадраты чисел верхнего ряда с перестановкой цифр.");
                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("№3");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Имеются цифры 1, 2, 3, 4, 5 и пять знаков плюс. Нужно уравнять: 1 2 3 4 5 = 5 4 3 2 1. Порядок цифр изменять нельзя(ответ записать без пробелов).");
                for (int tryes = 3; tryes >= 0; tryes--)
                {
                    Console.Write("Ответ: ");
                    answer_3 = Convert.ToString(Console.ReadLine());
                    if (answer_3 == "12+3+45=54+3+2+1")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Верно!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Вы заработали одно очко!");
                        points += 1;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверно!");
                        Console.WriteLine("У тебя осталось " + tryes + " попытки");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (tryes == 0)
                    {
                        Console.WriteLine("Вы ничего не заработали!");
                        Console.WriteLine("Правильный ответ: 12+3+45=54+3+2+1");
                        break;
                    }
                    break;
                }                                
            }
        }
    }
}

