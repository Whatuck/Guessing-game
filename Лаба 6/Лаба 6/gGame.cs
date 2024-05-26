using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Лаба_6
{
    public class gGame
    {
        private string? x, bottomDiap, highDiap, pattern = @"^\-?[0-9]";
        private int xInt, bottomDiapInt, highDiapInt, randx, k = 0;
        private void restart()
        {
            Console.WriteLine("\nСыграть ещё раз? \n1 - да \nВсё остальное - нет.\n");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
                start();
            else
                Console.WriteLine("\nАривидерчи.");
        }
        private void def()
        {
            k++;
            Console.WriteLine("\nВведите число от " + bottomDiapInt + " до " + highDiapInt + ":\n");
            x = Convert.ToString(Console.ReadLine());
            if (!Regex.IsMatch(x, pattern))
            {
                Console.Write("\nВы ввели неверное значение.\n");
                def();
            }
            xInt = Convert.ToInt32(x);
        }

        private void sravn()
        {
            if (xInt < bottomDiapInt || xInt > highDiapInt)
            {
                def();
            }
            if (xInt > randx)
                Console.WriteLine("\nВаше число больше загаданного.\n");
            if (xInt < randx)
                Console.WriteLine("\nВаше число меньше загаданного.\n");
        }


        private void diapazon()
        {
            Console.WriteLine("\nВведите нижний диапазон:");
            bottomDiap = Convert.ToString(Console.ReadLine());
            while (!Regex.IsMatch(bottomDiap, pattern))
            {
                Console.WriteLine("\nНеверно. Введите нижний диапазон заново:\n");
                bottomDiap = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("\nВведите верхний диапазон:");
            highDiap = Convert.ToString(Console.ReadLine());
            while (!Regex.IsMatch(highDiap, pattern))
            {
                Console.WriteLine("\nНеверно. Введите верхний диапазон заново:\n");
                highDiap = Convert.ToString(Console.ReadLine());
            }
            bottomDiapInt = Convert.ToInt32(bottomDiap);
            highDiapInt = Convert.ToInt32(highDiap);
            if (bottomDiapInt > highDiapInt)
            {
                Console.WriteLine("\nНеверно. Верхний диапазон меньше нижнего. Введите диапазоны заново:\n");
                diapazon();
            }
        }
        public void start()
        {
            diapazon();
            def();
            Random rnd = new Random();
            randx = rnd.Next(bottomDiapInt, highDiapInt);
            while (xInt != randx)
            {
                sravn();
                def();
            }
            Console.WriteLine("\nПоздравляем! \nВы угадали за " + k + " попыток!");
            restart();
        }
    }

}
