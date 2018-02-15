namespace Auxiliary.CryptoTools
{
    using System;
    using System.Text;
    using System.Security.Cryptography;

    public static class SHA1Hasher
    {
        private static String GetUsefulSalt()
        {
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[32];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private static String EncodePassword(String password, String salt)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] src = Encoding.Unicode.GetBytes(salt);
            byte[] dst = new byte[src.Length + bytes.Length];
            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inarray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inarray);
        }

        public static void CalculatePasswordHash(String password, out String passwordSalt, out String passwordHash)
        {
            passwordSalt = SHA1Hasher.GetUsefulSalt();
            passwordHash = SHA1Hasher.EncodePassword(password, passwordSalt);
        }

        public static Boolean CheckIsPasswordHashCorrect(String salt, String password, String checkingPasswordHash)
        {
            String calculatedPasswordHash = SHA1Hasher.EncodePassword(password, salt);
            Boolean result = String.Equals(calculatedPasswordHash, checkingPasswordHash);
            return result;
        }
    }
}
