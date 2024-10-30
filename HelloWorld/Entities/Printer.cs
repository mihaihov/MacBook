using HelloWorld.Interfaces;

namespace HelloWorld.Entities {
    public class Printer : IWrite
    {
        public void GetPrinterIP(){
            Console.WriteLine("The IP of the printer is this");
        }

        public void Write()
        {
            Console.WriteLine("Writing to printer");
        }
    }
}