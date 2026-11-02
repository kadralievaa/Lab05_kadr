string menuChoice;

do
{
    Console.WriteLine("1 - Проанализировать предложение");
    Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    Console.WriteLine("0 - Выход");
    Console.Write("Выбери пункт: ");
    menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            Console.Write("Введи предложение: ");
            string text = Console.ReadLine();

            int vowels = 0;
            int consonants = 0;
            int spaces = 0;
            string vowelsList = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

            foreach (char letter in text)
            {
                if (vowelsList.Contains(letter))
                {
                    vowels++;
                }
                else if (letter == ' ')
                {
                    spaces++;
                }
                else if (char.IsLetter(letter))
                {
                    consonants++;
                }
            }

            Console.WriteLine($"Всего символов: {text.Length}");
            Console.WriteLine($"Гласных: {vowels}");
            Console.WriteLine($"Согласных: {consonants}");
            Console.WriteLine($"Пробелов: {spaces}");
            break;

        case "2":
            Console.Write("Введи предложение: ");
            string text2 = Console.ReadLine();
            bool foundUpper = false;

            for (int i = 0; i < text2.Length; i++)
            {
                if (char.IsUpper(text2[i]))
                {
                    Console.WriteLine($"Первая заглавная буква на позиции {i}");
                    foundUpper = true;
                    break;
                }
            }

            if (!foundUpper)
            {
                Console.WriteLine("Заглавных букв нет");
            }
            break;

        case "0":
            Console.WriteLine("До свидания!");
            break;

        default:
            Console.WriteLine("Такого пункта нет.");
            break;
    }

} while (menuChoice != "0");