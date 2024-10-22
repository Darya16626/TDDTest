using System.Linq;
using System;

public class TestClass
{
    public string FindShortestWord(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) // проверка на пустоту
            return string.Empty;

        return input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .OrderBy(word => word.Length)
                    .FirstOrDefault(); // Разделение строки на слова, сортировка по длине и возврат первого слова
    }

    public int CountWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        return input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length; // Разделение строки на слова и возврат их количества
    }

    public int CountCharacters(string input)
    {
        return string.IsNullOrEmpty(input) ? 0 : input.Length; // Возвращает 0 если строка пустая
    }

    public char? FindNinthCharacter(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 9)
            return null;

        return input[8]; // 9-ый символ (индекс 8)
    }

    public int CountDigits(string input)
    {
        return string.IsNullOrEmpty(input) ? 0 : input.Count(char.IsDigit);
    }

    public int CountConsecutiveDigits(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int maxCount = 0; // Переменная цифр
        int currentCount = 0; //Переменная для подсчета текущего количества подряд идущих цифр

        foreach (char c in input) // Перебор каждого символа в строке
        {
            if (char.IsDigit(c))
            {
                currentCount++;
                if (currentCount > maxCount)
                    maxCount = currentCount; // обновление максимального значения
            }
            else
            {
                currentCount = 0; //сброс
            }
        }

        return maxCount;
    }

    public int CountOccurrencesOfAm(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        return (input.Length - input.Replace("ам", "").Length) / "ам".Length;
    }
}
