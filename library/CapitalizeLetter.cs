using System;

namespace lab4.library
{
    public class CapitalizeLetter : MyString
    {
        private char[] value;

        public CapitalizeLetter(char[] value)
        {
            int size = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsUpper(value[i]))
                    size++;
            }

            this.value = new char[size];
            size = 0;
            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];
                if (Char.IsUpper(c))
                {
                    this.value[size] = c;
                    size++;
                }
            }
        }

        public override int CountSymbols()
        {
            int count = 0;

            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];
                if (c == 'B')
                    count++;
            }

            return count;
        }

        public override int GetLength()
        {
            return value.Length;
        }

        public override char[] GetValue()
        {
            return value;
        }
    }
}
