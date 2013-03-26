using System;
using ServiceStack.ServiceHost;

namespace TryMDRazor
{
    public class ExampleService : IService
    {
        public Example Get(ExampleRequest request)
        {
            return new Example { Greeting = "Hello, MD!" };
        }
    }
}
