using System;

namespace HomeWork_7._1
{
    class BCoder : Acoder
    {
        public override string Decode(string str, int key)
        {
            return base.Decode(str, -key);
        }

        public override string Encode(string str, int key)
        {
            return base.Encode(str, key);
        }
    }
    class Acoder : ICoder
    {
        private string _alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private int _key = 1;
        private string _encryptedText;
        public virtual string Encode(string str, int key =1)
        {

            string retVal = "";
            _encryptedText = str.ToLower();
            _key = key;
            for (int i = 0; i < _encryptedText.Length; i++)
            {
                char c = _encryptedText[i];
                var index = _alphabet.IndexOf(c);

                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }

                else
                {
                    var codeIndex = (_alphabet.Length + index + _key) % _alphabet.Length;
                    retVal += _alphabet[codeIndex];
                }
            }
            return retVal;
        }
        public virtual string Decode(string str, int key = -1)
        {
            return Encode(str, key);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "Шифр цезаря";
            string cipherText = string.Empty;
            string decryptionText = string.Empty;

            Acoder acoder = new Acoder();
            cipherText = acoder.Encode(Text);
            Console.WriteLine(cipherText);
            decryptionText = acoder.Decode(cipherText);
            Console.WriteLine(decryptionText);

            BCoder bCoder = new BCoder();
            cipherText =  bCoder.Encode(Text, 7);
            Console.WriteLine(cipherText);
            decryptionText = bCoder.Decode(cipherText, 7);
            Console.WriteLine(decryptionText);
      
            
   

        }
    }
}
