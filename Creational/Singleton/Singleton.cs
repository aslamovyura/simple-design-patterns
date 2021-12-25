namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        private static readonly object _lock = new();

        public static Singleton GetInstance(string value)
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        public string Value { get; set; }
    }
}