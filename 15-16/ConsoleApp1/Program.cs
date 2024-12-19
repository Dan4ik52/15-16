using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:

                    string example = "xabcxyzabcxabc";
                    string pattern = "x(?=abc)";
                    string result = Regex.Replace(example, pattern, "");

                    Console.WriteLine(result); 
                    break;

                case 2:
                    string input = "Hello World! This is a Test, 123456";

                    // Разделяем строку на слова
                    string[] words = input.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

                    // Перебираем все слова
                    foreach (var word in words)
                    {
                        // Заменяем большие буквы на маленькие и удаляем все символы, не являющиеся буквами или цифрами
                        string cleanedWord = Regex.Replace(word.ToLower(), @"[^a-zA-Z0-9]", "");

                        // Извлекаем гласные буквы
                        var vowels = cleanedWord.Where(c => "aeiouy".Contains(c)).OrderBy(c => c).Distinct();

                        // Выводим слово
                        Console.WriteLine($"Слово: {cleanedWord}");

                        // Выводим гласные буквы, отсортированные в алфавитном порядке
                        Console.WriteLine("Гласные: " + string.Join(", ", vowels));
                    }
                        break;
            }
            Console.ReadKey();

        }
        }
}
