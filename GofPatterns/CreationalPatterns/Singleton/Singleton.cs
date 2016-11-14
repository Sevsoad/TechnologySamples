using System.Diagnostics.Eventing.Reader;

namespace GofPatterns.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static object _lock = new object();
        public string InternalValue;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            lock (_lock)
            {
                _instance = _instance ?? new Singleton();
            }

            return _instance;
        }
    }
}
