using System;

namespace AbstractFactory
{
    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with Redis!");
        }
    }
}
