using System;

namespace Section3HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To HashTables Section 3 !");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            //uc1
            hash.Add("0", "To be or not to be");
            hash.frequencyOfWords("0");
            //uc2
            hash.Add("1", "Paranoids are not Paranoids because they are Paranoids but " +
                "because they keep putting themselves deliberatly into paranoids avoidable situations");
            hash.frequencyOfWords("1");
            //uc3
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            MyMapNode<int, string> hash1 = new MyMapNode<int, string>(para.Length);
            int key = 0;
            foreach (string word in para)
            {
                hash1.Add(key, word);
                key++;
            }

            hash.Remove(hash1, "avoidable");
        }
    }
}
