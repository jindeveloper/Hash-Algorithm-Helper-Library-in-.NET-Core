using HashingAlgorihtm.Library;
using NUnit.Framework;
using System.Linq;
using System.Text;

namespace HashingAlgorithm.Test
{
    /*
     *
     */ 
    public class Tests
    {
        private string plainText = "Stay hungry and stay foolish";

        /*
         * MD5 yields hexadecimal digits (0-15 / 0-F), so they are four bits each. 128 / 4 = 32 characters.
         */
        [Test]
        public void Hashing_Use_MD5_Test()
        {
         
            var result1 = HashingHelper.ComputeHashInLowerCase(plainText, HashingClassAlgorithms.MD5);

            var result2 = HashingHelper.ComputeHashInUpperCase(plainText, HashingClassAlgorithms.MD5);

            TestContext.WriteLine($"{plainText} using MD5 in lowercase: {result1} and in uppercase: {result2}");

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result1) == 32);

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result2) == 32);

            Assert.IsTrue(result1.ToCharArray().All(c => char.IsLower(c) || char.IsDigit(c)));

            Assert.IsTrue(result2.ToCharArray().All( c=> char.IsUpper(c) || char.IsDigit(c)));
        }

        /**
         * SHA-1 yields hexadecimal digits too (0-15 / 0-F), so 160 / 4 = 40 characters.
         */
        [Test]
        public void Hashing_Use_SHA1_Test()
        {

            var result1 = HashingHelper.ComputeHashInLowerCase(plainText, HashingClassAlgorithms.SHA1);

            var result2 = HashingHelper.ComputeHashInUpperCase(plainText, HashingClassAlgorithms.SHA1);

            TestContext.WriteLine($"{plainText} using MD5 in lowercase: {result1} and in uppercase: {result2}");

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result1) == 40);

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result2) == 40);

            Assert.IsTrue(result1.ToCharArray().All(c => char.IsLower(c) || char.IsDigit(c)));

            Assert.IsTrue(result2.ToCharArray().All(c => char.IsUpper(c) || char.IsDigit(c)));
        }

        /**
         * SHA-2 (256 variant) yields hexadecimal digits too (0-15 / 0-F), so 256 / 4 = 64 characters.
         */
        [Test]
        public void Hashing_Use_SHA256_Test()
        {

            var result1 = HashingHelper.ComputeHashInLowerCase(plainText, HashingClassAlgorithms.SHA256);

            var result2 = HashingHelper.ComputeHashInUpperCase(plainText, HashingClassAlgorithms.SHA256);

            TestContext.WriteLine($"{plainText} using MD5 in lowercase: {result1} and in uppercase: {result2}");

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result1) == 64);

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result2) == 64);

            Assert.IsTrue(result1.ToCharArray().All(c => char.IsLower(c) || char.IsDigit(c)));

            Assert.IsTrue(result2.ToCharArray().All(c => char.IsUpper(c) || char.IsDigit(c)));
        }


        /**
         * SHA-2 (384 variant) yields hexadecimal digits too (0-15 / 0-F), so 384 / 4 = 96 characters.
         */
        [Test]
        public void Hashing_Use_SHA384_Test()
        {

            var result1 = HashingHelper.ComputeHashInLowerCase(plainText, HashingClassAlgorithms.SHA384);

            var result2 = HashingHelper.ComputeHashInUpperCase(plainText, HashingClassAlgorithms.SHA384);

            TestContext.WriteLine($"{plainText} using MD5 in lowercase: {result1} and in uppercase: {result2}");

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result1) == 96);

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result2) == 96);

            Assert.IsTrue(result1.ToCharArray().All(c => char.IsLower(c) || char.IsDigit(c)));

            Assert.IsTrue(result2.ToCharArray().All(c => char.IsUpper(c) || char.IsDigit(c)));
        }

        /**
       * SHA-2 (512 variant) yields hexadecimal digits too (0-15 / 0-F), so 512 / 4 = 128 characters.
       */
        [Test]
        public void Hashing_Use_SHA512_Test()
        {

            var result1 = HashingHelper.ComputeHashInLowerCase(plainText, HashingClassAlgorithms.SHA512);

            var result2 = HashingHelper.ComputeHashInUpperCase(plainText, HashingClassAlgorithms.SHA512);

            TestContext.WriteLine($"{plainText} using MD5 in lowercase: {result1} and in uppercase: {result2}");

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result1) == 128);

            Assert.IsTrue(UTF8Encoding.UTF8.GetByteCount(result2) == 128);

            Assert.IsTrue(result1.ToCharArray().All(c => char.IsLower(c) || char.IsDigit(c)));

            Assert.IsTrue(result2.ToCharArray().All(c => char.IsUpper(c) || char.IsDigit(c)));
        }
    }
}