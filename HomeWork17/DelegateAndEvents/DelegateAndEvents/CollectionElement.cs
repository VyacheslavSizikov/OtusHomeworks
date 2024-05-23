
namespace DelegateAndEvents
{
    public class CollectionElement
    {
        protected readonly float _value;
        public CollectionElement(float value) => _value = value;
        public float GetValue() => _value;
        public static float GetParameter(CollectionElement c) => c.GetValue();
        public override string ToString()        {
            return GetValue().ToString();
        }
    }
}
