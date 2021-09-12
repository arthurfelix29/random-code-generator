using System;
using System.Text;

namespace StnXCodeGenerator.Domain.Models
{
    public readonly struct Key
    {
        private static readonly Random _random = new();

        public int Size { get; init; }

        public string GenerateDistinctKey()
        {
            StringBuilder builder = new(Size);

            for (int i = 0; i < Size; i++)
            {
                ReadOnlySpan<char> character;

                do
                {
                    int index = _random.Next(0, Constants.AllowedChars.Length);
                    character = Constants.AllowedChars.ToCharArray()[index].ToString().AsSpan();
                }
                while (builder.ToString().AsSpan().IndexOf(character) != -1);

                builder.Append(character);
            }

            return builder.ToString();
        }
    }
}