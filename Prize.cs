using System;

namespace Quest
{
    public class Prize
    {
        private string _text { get; set; }

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer You)
        {
            if (You.Awesomeness > 0)
            {
                Console.WriteLine("You're prize is:");
                for (int x = You.Awesomeness; x > 0; x--)
                {
                    Console.WriteLine(_text);
                }
            }
            else
            {
                Console.WriteLine("You are unworthy of a prize.");
            }
        }
    }
}