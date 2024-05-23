using System.Diagnostics;

namespace ParallelCalculating
{    
    public static class Calculation
    {
        /// <sumary>
        /// Обычное суммирование
        /// </sumary>
        public static long RegularSum(long[] elements)
        {
            long sum = 0;
            Stopwatch sw = Stopwatch.StartNew();
            for(int i=0;i<elements.Length; i++) { sum += elements[i]; }
            sw.Stop();
            Console.WriteLine($"Вычисление: Обычное, Элементов: {elements.Length}, Сумма: {sum}, Время: {sw.Elapsed.TotalMilliseconds} ms;");
            return sum;

        }

        /// <summary>
        /// Суммирование с помощью потоков
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="threadsCount"></param>
        /// <returns></returns>
        public static long ThreadSum(long[] elements, int threadsCount)
        {
            long sum = 0;
            int range = elements.Length / threadsCount;
            int elementsLeft = elements.Length - threadsCount * range;
            int threadsToRun = threadsCount + (elementsLeft > 0 ? 1 : 0);
            Thread[] threads = new Thread[threadsToRun];
            long[] results = new long[threadsToRun];

            // Делегат для потока
            void Calculate(object so)
            {
                int sp = (so as ThreadCalculationParams)?.StartPosition ?? 0;
                int ep = (so as ThreadCalculationParams)?.EndPosition ?? 0;
                int resIdx = (so as ThreadCalculationParams)?.Index ?? 0;
                for (int i = sp; i < ep; i++) results[resIdx] += elements[i];
            }

            // Вычисление
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            for (int i = 0; i < threadsCount; i++)
            {
                var calculateParams = new ThreadCalculationParams() { Index = i, StartPosition = i * range, EndPosition = i * range + range };
                threads[i] = new Thread(() => Calculate(calculateParams));
                threads[i].Start();
            }
            if (elementsLeft > 0)
            {
                var calculateParams = new ThreadCalculationParams() { Index = threadsCount, StartPosition = threadsCount * range, EndPosition = threadsCount * range + elementsLeft };
                threads[threadsCount] = new Thread(() => Calculate(calculateParams));
                threads[threadsCount].Start();
            }
            for (int i = 0; i < threads.Length; i++) threads[i].Join();
            for (int i = 0; i < threads.Length; i++) sum += results[i];
            sw.Stop();
            Console.WriteLine($"Вычисление: Thread, Элементов: {elements.Length}, Сумма: {sum}, Время: {sw.Elapsed.TotalMilliseconds} ms;");
            
            return sum;
        }

        /// <summary>
        /// Параллельное Linq вычисление
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static long ParallelSum(long[] elements)
        {
            long sum = 0;
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            sum = elements.AsParallel().Sum(x => x);
            sw.Stop();
            Console.WriteLine($"Вычисление: Параллельное Linq, Элементов: {elements.Length}, Сумма: {sum}, Время: {sw.Elapsed.TotalMilliseconds} ms;");
            
            return sum;
        }

    }

    



}
