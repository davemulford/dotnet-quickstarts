using System;

namespace HelloDotNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // This just prints some info about the framework and .NET runtime. You can ignore the details of it
            Console.WriteLine($"Framework: {Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.RuntimeFramework}");
            Console.WriteLine($"Runtime: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}, {System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}, {Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.RuntimeFramework.Version}");
            Console.WriteLine($"OS: {System.Runtime.InteropServices.RuntimeInformation.OSDescription} {System.Runtime.InteropServices.RuntimeInformation.OSArchitecture}");
        }
    }
}
