using System;

namespace FirstLesson.Classes
{
    public static  class Extension
    {
        public static string Description(this Rectangle rectangle)
        {
            return $"Прямоугольник со сторонами: длинна {rectangle["length"]} и ширина {rectangle["height"]}";
        }

        public static bool IsPalindrome(this String text)
        {
            for (int i = 0; i < text.Length / 2; i++)
                if (text[i] != text[text.Length - (i+1)]) //не сработала text[^ (i+1)]
                    return false;

            return true;
        }
    }
}
