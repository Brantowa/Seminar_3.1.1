// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine ("Чтобы узнать название дня недели, введите любое число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) System.Console.WriteLine ($"{number} соответсвует дню недели - Понедельник");
else if (number == 2) System.Console.WriteLine ($"{number} соответсвует дню недели - Вторник");
else if (number == 3) System.Console.WriteLine ($"{number} соответсвует дню недели - Среда");
else if (number == 4) System.Console.WriteLine ($"{number} соответсвует дню недели - Четверг");
else if (number == 5) System.Console.WriteLine ($"{number} соответсвует дню недели - Пятница");
else if (number == 6) System.Console.WriteLine ($"{number} соответсвует дню недели - Суббота");
else if (number == 7) System.Console.WriteLine ($"{number} соответсвует дню недели - Воскресенье");
else if (number > 7 | number < 1) System.Console.WriteLine ($"{number} не соответсвует никакому дню недели");