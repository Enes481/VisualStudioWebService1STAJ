using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace EDMTAPIAuthentication3.utils
{
    /*
     * FUNCTION TO CREATE RANDOM SALT STRING
     * 
     */
    public class Common
    {
        public static byte[] GetRandomSalt(int length)
        {
            var random = new RNGCryptoServiceProvider();
            byte[] salt = new byte[length];
            random.GetNonZeroBytes(salt);
            return salt;
        } 

        /*
         * FUNCTION TO CREATE PASSWORD WITH SALT 
         * 
         */
        public static byte[] SaltHashPassword(byte[] password , byte[] salt)
        {
            HashAlgorithm alghoritm = new SHA256Managed();
            byte[] plainTextWithSaltBytes = new byte[password.Length + salt.Length];
            for(int i = 0; i < password.Length; i++)
            {
                plainTextWithSaltBytes[i] = password[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[password.Length + i] = salt[i];

            }
            return alghoritm.ComputeHash(plainTextWithSaltBytes);


        }
    }
}
