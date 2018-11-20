using System;
// init with in the folder/console dotnet new console -o someapp
namespace crytp
{
    class CrytpObject
    {
        public String container;
        public String key;
        private String keyPrivate;

        public CrytpObject(String container)
        {
            this.container = container;
            importKey(this.container);
        }
        public String encrypt(String s)
        {
            //encrypt
            //base 64 encoding
            return "";
        }
        public String decrypt(String s)
        {
            // base 64 decoding
            // need to use the private key
            return "";
        }
        public void importKey(String s)
        {
        }
        public String exportKey(String s)
        {
            return "";
        }
    }
}