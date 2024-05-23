
namespace DelegateAndEvents
{
    public static class ExtensionFunction
    {
        public static T? GetMaxElement<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber)
            where T : class
        {
            T result = collection.FirstOrDefault();
            if(result == null)
                return null;

            var max = convertToNumber(result);
            foreach (var item in collection)
            {
                var currMaxNum = convertToNumber(item);
                if (max < currMaxNum)
                {
                    max = currMaxNum;
                    result = item;
                }
            }

            return result;
        }           
            
    }    

}
