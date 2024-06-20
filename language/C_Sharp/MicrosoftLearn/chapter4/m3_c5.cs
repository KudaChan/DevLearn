string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');

string[] newPangram = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    char[] wordChar = words[i].ToCharArray();
    Array.Reverse(wordChar);
    newPangram[i] = new string(wordChar);
}

string reversedPangram = string.Join(" ", newPangram);
Console.WriteLine(reversedPangram);