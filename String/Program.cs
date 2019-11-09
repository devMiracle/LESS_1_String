using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ППС 31-18
//Леша Бутко
//10.10.2019

///генерируем случайное число в диапазоне от -1999 до 1999.
///1. Перевернуть число. (без цикла)
///2. Найти самую маленькую цифру.
///3. Поменять в местами соседние цифры в числе.На выходе должна получится ОДНА переменная


///4. Проверить является ли строка палиндромом. (Палиндром - это выражение, которое читается одинакова слева направо и справа налево).
///5. Напечатать самое длинное и самое короткое слово в этой строке.
///6. После каждого предложения добавьте смайлик ( :) ) в строке:

//Я очень гордился тем, что попал в команду для полета на Марс – кто бы отказался прогуляться по чужой планете!
//Но...меня забыли.Бросили, раненого и растерянного, и корабль улетел.В лучшем случае я смогу протянуть в спасательном модуле 400 суток.
//    Что же делать – разыскать в безбрежных красных песках поврежденную бурей антенну, попытаться починить ее, чтобы связаться с базовым кораблем и напомнить о своем существовании? 
//    Или дожидаться прибытия следующей экспедиции, которая прилетит только через ЧЕТЫРЕ ГОДА?Где брать еду? Воду? Воздух? Как не сойти с ума от одиночества?
//    Робинзону было легче...у него хотя бы был Пятница.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Перевернуть число. (без цикла)
            Random random = new Random();
            int number = random.Next(-1999, 2000);///генерируем случайное число в диапазоне от -1999 до 1999.
            Console.WriteLine("Изначальное число: " + number);
            if (number < 0)
                number *= -1;
            char[] array = number.ToString().ToCharArray();
            Array.Reverse(array);
            Console.Write("Перевернутое число: ");
            foreach (var item in array)
                Console.Write(item);
            Console.WriteLine();

            //2 Найти самую маленькую цифру.
            char[] array2 = new char[array.Length];
            array.CopyTo(array2, 0);
            Array.Sort(array2);
            Console.WriteLine("Минимальная цифра в числе: " + array2[0]);

            //3 Поменять в местами соседние цифры в числе.На выходе должна получится ОДНА переменная
            Console.WriteLine("Переворачиваем соседние цифры: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]);
            char temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            Console.WriteLine("\nОтвет: ");
            try
            {
                string answer = string.Concat(array);
                int result = int.Parse(answer);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            //4 Проверить является ли строка палиндромом. (Палиндром - это выражение, которое читается одинакова слева направо и справа налево).
            string text = "А роза упала на лапу Азора";
            Console.WriteLine(text);
            text = text.ToLower();
            char[] seporator = { ' ', ',', '.', '!', '?' };
            string[] text2 = text.Split(seporator);
            text = string.Join("", text2);
            Console.WriteLine(text);
            bool answer2 = false;
            for (int i = 0, j = text.Length - 1; i < text.Length / 2 - 1; i++, j--)
            {
                if (text[i] == text[j])
                    answer2 = true;
                else
                {
                    answer2 = false;
                    break;
                }
            }
            Console.WriteLine($"Палиндром: {answer2}");

            //5. Напечатать самое длинное и самое короткое слово в этой строке.
            string textStr = "Напечатать самое длинное и самое короткое слово в этой строке.";
            string[] massiveStr = textStr.Split(seporator, StringSplitOptions.RemoveEmptyEntries);
            string minWord = massiveStr[0];
            string maxWord = massiveStr[0];
            foreach (var item in massiveStr)
            {
                if (item.Length == 1)//если слово состоит из одного символа - пропуслаем
                    continue;
                if (maxWord.Length < item.Length)
                    maxWord = item;
                if (minWord.Length > item.Length)
                    minWord = item;
            }
            Console.WriteLine($"Максимальное слово: {maxWord}");
            Console.WriteLine($"Минимальное слово: {minWord}");

            //6. После каждого предложения добавьте смайлик ( :) ) в строке:

            string textstr2 = "Я очень гордился тем, что попал в команду для полета на Марс – кто бы отказался прогуляться по чужой планете! Но...меня забыли.Бросили, раненого и растерянного, и корабль улетел.В лучшем случае я смогу протянуть в спасательном модуле 400 суток. Что же делать – разыскать в безбрежных красных песках поврежденную бурей антенну, попытаться починить ее, чтобы связаться с базовым кораблем и напомнить о своем существовании? Или дожидаться прибытия следующей экспедиции, которая прилетит только через ЧЕТЫРЕ ГОДА?Где брать еду? Воду? Воздух? Как не сойти с ума от одиночества? Робинзону было легче...у него хотя бы был Пятница.";
            textstr2 = textstr2.Replace(". ", "& ");//временно меняем точку на другой символ, чтоб она не мешала нам.
            textstr2 = textstr2.Replace("! ", "! :) ");
            textstr2 = textstr2.Replace("? ", "? :) ");
            textstr2 = textstr2.Replace("...", "@@@");//временно меняем троеточие на другой символ, чтоб оно не мешало нам.
            textstr2 = textstr2.Replace(".", ". :) ");
            textstr2 = textstr2.Replace("@@@", "...");//вовращяем
            textstr2 = textstr2.Replace("& ", ". :) ");//возвращаем
            Console.WriteLine(textstr2);






        }
    }
}
