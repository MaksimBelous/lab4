using System;

namespace lab4.library
{
    public class Symbols : MyString
    {
        private char[] value;

        public Symbols(char[] value)
        {
            int size = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsSymbol(value[i]) || Char.IsPunctuation(value[i]))
                    size++;
            }

            this.value = new char[size];
            size = 0;
            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];
                if (Char.IsSymbol(c) || Char.IsPunctuation(c))
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
                if (c == '*')
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
