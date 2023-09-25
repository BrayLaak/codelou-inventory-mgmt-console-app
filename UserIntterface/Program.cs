using IMTest.BL;

namespace IMTest.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create an instance of ProductLogic (you can replace this with your preferred method of creating the logic instance)
            var productLogic = new ProductLogic();

            // Pass the productLogic instance to the UserInterface constructor
            var userInterface = new UserInterface(productLogic);

            userInterface.Run();
        }
    }
}
