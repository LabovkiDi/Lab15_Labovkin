using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия:");
            //создание  экземпляра класса арифметической прогрессии
            ArithProgression arith = new ArithProgression();
            arith.setStart(5); /* устанавливаем стартовое значение*/
            arith.setStep(20); /*устанавливаем шаг прогрессии*/
            Console.WriteLine(arith.getNext()); /*выводим 1 значение*/
            Console.WriteLine(arith.getNext()); /*выводим 2 значение*/
            Console.WriteLine(arith.getNext()); /*выводим 3 значение*/
            Console.WriteLine(arith.getNext()); /*выводим 4 значние*/
            arith.reset(); /*выполняем сброс*/
            Console.WriteLine(arith.getNext()); /*вывод значение 1*=1*/
            Console.WriteLine(arith.getNext()); /*вывод значения 2*=2*/
            Console.WriteLine(arith.getNext()); /*вывод значения 3*=3*/
            Console.WriteLine();
            Console.WriteLine("Геометрическая прогрессия:");
            //создание конструктора класса арифметической прогрессии
            GeompProgression geom = new GeompProgression();
            geom.setStart(4);/* устанавливаем стартовое значение*/
            geom.setStep(5);/*устанавливаем шаг прогрессии*/
            Console.WriteLine(geom.getNext());/*выводим 1 значение*/
            Console.WriteLine(geom.getNext()); /*выводим 2 значение */
            Console.WriteLine(geom.getNext());/*выводим 3 значение*/
            geom.reset();/*выполняем сброс*/
            Console.WriteLine(geom.getNext());/*вывод значение 1*=1*/
            Console.WriteLine(geom.getNext());/*вывод значения 2*=2*/
            Console.ReadKey();
        }
    }
    interface ISeries /*интерфейс*/
    {
        void setStart(int x); /*метод-устанавливает начальное значение*/
        int getNext(); /*метод-возвращает следующее число ряда*/
        void reset(); /*метод-выполняет сброс к начальному значению, х*/
    }
    //класс арифметической прогрессии реализзует интерфейс ISeries
    class ArithProgression : ISeries
    {
        protected int step; /*шаг*/
        int startValue; /*стартовое число*/
        protected int currentValue; /*изменяемое значение стартового числа*/
        public virtual int getNext()
        {
            currentValue += step;
            return currentValue;
        }
        public void reset()
        {
            currentValue = startValue;
        }
        public void setStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void setStep(int s) /*шаг арифметической прогрессии*/
        {
            step = s;
        }
    }
    //класс геометрической прогрессии наследуется от класса арифметической прогрессии
    class GeompProgression : ArithProgression 
    {

        public override int getNext()
        {
            currentValue *= step;
            return currentValue;
        }

    }
}
