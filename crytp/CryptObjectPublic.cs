using System;
// init with in the folder/console dotnet new console -o someapp
namespace crytp
{
    class CrytpObjectPublic
    {
        public String container;
        public String key;

        public CrytpObjectPublic(String container)
        {
            this.container = container;
        }
        public String encrypt(String s)
        {
            return "";
        }
        public String decrypt(String s)
        {
            // need to use the private key
            // send to the CryptObject to be decoded
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