namespace Logic.Criptographys
{
    public class Assimetricas
    {
        public class Encript
        {
            public static string Mikcipher(string text, string publicKey)
            {
                using (var mikcipher = new Mikcipher.Mikcipher(text))
                    return mikcipher.Encript(publicKey);
            }
        }

        public class Decript
        {
            public static string Mikcipher(string text, string privateKey)
            {
                using (var mikcipher = new Mikcipher.Mikcipher(text))
                    return mikcipher.Decript(privateKey);
            }
        }

        public class Generate
        {
            public static string PublicKey(string publicKey, string privateKey)
            {
                using (var mikcipher = new Mikcipher.Mikcipher(string.Empty))
                    return mikcipher.GetPublickey(publicKey, privateKey);
            }
        }
    }
}
