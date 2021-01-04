using System;
using System.Security.Cryptography;
using System.Text;

namespace OlshopPrintApps.Method
{
    public class Encryptor
    {
        public static String Encrypt(String plainText, Byte[] saltBytes)
        {
            if (saltBytes == null)
            {
                int minSaltSize = 4;
                int maxSaltSize = 8;

                Random random = new Random();

                int saltSize = random.Next(minSaltSize, maxSaltSize);
                saltBytes = new Byte[(saltSize)];

                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(saltBytes);
            }

            Byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            Byte[] plainTextWithSaltBytes = new Byte[(plainTextBytes.Length + saltBytes.Length)];

            for (int I = 0; I <= plainTextBytes.Length - 1; I++)
            {
                plainTextWithSaltBytes[I] = plainTextBytes[I];
            }

            for (int I = 0; I <= saltBytes.Length - 1; I++)
            {
                plainTextWithSaltBytes[plainTextBytes.Length + I] = saltBytes[I];
            }

            HashAlgorithm hash = new SHA1Managed();

            Byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            Byte[] hashWithSaltBytes = new Byte[(hashBytes.Length + saltBytes.Length)];

            for (int I = 0; I <= hashBytes.Length - 1; I++)
            {
                hashWithSaltBytes[I] = hashBytes[I];
            }

            for (int I = 0; I <= saltBytes.Length - 1; I++)
            {
                hashWithSaltBytes[hashBytes.Length + I] = saltBytes[I];
            }

            String hashValue = Convert.ToBase64String(hashWithSaltBytes);

            return hashValue;
        }

        public static Boolean VerifyHash(String plainText, String hashValue)
        {
            Boolean result = false;
            Byte[] hashWithSaltBytes = Convert.FromBase64String(hashValue);

            int hashSizeInBits = 160;
            int hashSizeInBytes = hashSizeInBits / 8;

            if (hashWithSaltBytes.Length < hashSizeInBytes)
            {
                result = false;
            }

            Byte[] saltBytes = new Byte[(hashWithSaltBytes.Length - hashSizeInBytes)];

            for (int I = 0; I <= saltBytes.Length - 1; I++)
            {
                saltBytes[I] = hashWithSaltBytes[hashSizeInBytes + I];
            }

            String expectedHashString = Encrypt(plainText, saltBytes);

            result = (hashValue == expectedHashString);

            return result;
        }
    }
}
