using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace FirstLesson.Classes
{
    /// <summary>
    /// Класс описывает Прямоугольник
    /// </summary>
    class Rectangle
    {
        private int Length { get; set; }
        private int Height { get; set; }

        public Rectangle(int length, int height)
        {
            Length = length;
            Height = height;
        }

        /// <summary>
        /// Подсчет площади
        /// </summary>
        /// <returns>Площадь</returns>
        public int Area()
        {
            return Length * Height;
        }

        /// <summary>
        /// Подсчет периметра
        /// </summary>
        /// <returns>Периметр</returns>
        public int Perimeter()
        {
            return Length * 2 + Height * 2;
        }

        /// <summary>
        /// Прибавляет к текущему прямоугольнику другой прямоугольник
        /// </summary>
        /// <param name="rectangle">Прямоугольник который будем прибавлять</param>
        public void Add(Rectangle rectangle)
        {
            Length += rectangle.Length;
            Height += rectangle.Height;
        }

        /// <summary>
        /// Прибавляет к текущемму прямоугольнику длину и высоту
        /// </summary>
        /// <param name="length">Длина</param>
        /// <param name="height">Высота</param>
        public void Add(int length, int height)
        {
            Length += length;
            Height += height;
        }

        public int this[string side]
        {
            get
            {
                switch (side.ToLower())
                {
                    case "length":
                        return Length;
                        break;
                    case "height":
                        return Height;
                        break;
                    default: 
                         throw new IndexOutOfRangeException();
                }
            }
        }

        public static Rectangle operator +(Rectangle rectangle1, Rectangle rectangle2)
        {
            return new Rectangle(rectangle1.Length + rectangle2.Length, rectangle1.Height + rectangle2.Height);
        }
       
        /// <summary>
        /// Увеличивает прямогольник на заданную величику
        /// </summary>
        /// <param name="rectangle"> Прямоугольник который будет увеличен</param>
        /// <param name="val">Значение на сколько будет увеличен прямоугольник</param>
        /// <returns></returns>
        public static Rectangle operator +(Rectangle rectangle, int val)
        {
            return new Rectangle(rectangle.Length + val, rectangle.Height + val);
        }

        public static bool operator ==(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1?.Length == rectangle2?.Length && rectangle1?.Height == rectangle2?.Height;
        }

        public static bool operator !=(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1?.Length != rectangle2?.Length && rectangle1?.Height != rectangle2?.Height;
        }


        public override string ToString()
        {
            return $"Прямоугольник со сторонами: длинна {Length} и ширина {Height}";
        }
    }
}
