using System;
using System.Security.Cryptography;
using System.Text;

namespace HashingAlgorith.SHA256.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string rawData = "I love C#";
            string result = string.Empty;

            /*1. Create the hash algorithm instance. You can choose from MD5, SHA1, SHA256, SHA384, and SHA512.*/
            using (var myHash = SHA256Managed.Create())
            {
                /*
                 * 2. Invoke the ComputeHash method by passing a byte array. 
                 *    Just remember, you can pass any raw data, and you need to convert that raw data into a byte array.
                 */
                var byteArrayResultOfRawData = Encoding.UTF8.GetBytes(rawData);

                /*
                 * 3. The ComputeHash method, after a successful execution it will return a byte array, 
                 *    and you should store that in a variable. 
                 */

                var byteArrayResult = myHash.ComputeHash(byteArrayResultOfRawData);

                /*
                 * 4. After the successful execution of ComputeHash, you can then convert the byte array into a string. 
                 */

                result = string.Concat(Array.ConvertAll(byteArrayResult, h => h.ToString("X2")));
            }

            Console.WriteLine($"The {rawData} will be converted into this: {Environment.NewLine}{result}");
            Console.ReadLine();
        }
    }
}
