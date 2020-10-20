using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //пошук позиції (індекса),що містить максимальне значення 
            float B[30];
            float max;//змінна,що містить максимум
            int index;//позиція елемента,що містить максимальне значення 
            int i;//додаткова змінна

            // Ведення масиву
            // ...

            // пошук максимуму
            index = 0;
            max = B[0];
            for (i = 1; i < 30; i++)
                if (max < B[i])
                {
                    max = B[i];//  максимум
                    index = i;// позиція максимального елемента 
                }

        }
    }
}
