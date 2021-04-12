using System;

namespace homework3_task2
{
    class Program
    {
        static void spaceRemover (string text)
        {
            //Console.WriteLine(text);

            char[] charArray = text.ToCharArray();
            char [] newer = new char [0];

            for (int i = 0; i< charArray.Length; i++)
            {
                //if (Char.IsWhiteSpace(charArray[i]))
                if (charArray[i] != ' ')
                {
                    Array.Resize(ref newer, (newer.Length + 1));
                    newer[newer.Length - 1] = charArray[i];
                }
            }

            Console.WriteLine(new string(newer));
        }

        // alternate, but nonversatile way is by copying the text and substratcing the space every time it comes up. This can be inconvenient if there is a large string so i just kept it this way. 
        static void Main(string[] args)
        {
            string text = "The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            spaceRemover(text);
        }
    }
}
