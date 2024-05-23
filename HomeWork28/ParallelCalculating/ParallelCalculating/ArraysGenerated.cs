
namespace ParallelCalculating
{
    public static class ArraysGenerated
    {
        public static long[] GenerateIntArray(int length)
        {
            long[] array = new long[length];
            var rnd = new Random();
            for (int i = 0; i < length; i++)
                array[i] = (int)rnd.NextInt64(1000);
            return array;
        }
    }
}
