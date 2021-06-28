using HashingAlgorihtm.Library;

namespace HashingAlgorithm.Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "Hello World";

            /*
             * In this example, I believe it is a straightforward call or invoke of the method. 
             * First, you just needed to pass the arguments such as plainText, the raw data in this case, ‘Hello World.’ 
             * Second, you can choose from the different algorithms available: MD5, SHA1, SHA256, SHA384, and SHA512.
             */

            string hashResult = HashingHelper.ComputeHashInLowerCase(plainText, HashingClassAlgorithms.MD5);

            System.Console.WriteLine(hashResult);
            System.Console.ReadLine();
        }
    }
}
