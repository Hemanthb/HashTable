
/*  ----------------------- USE CASE -1 --------------------------  */
HashTable.MyMapNode<string, string> hash = new HashTable.MyMapNode<string, string>(6);
hash.Add("0", "to");
hash.Add("1", "be");
hash.Add("2", "or");
hash.Add("3", "not");
hash.Add("4", "to");
hash.Add("5", "be");

Console.WriteLine("Frequency of word \'to\' is  : " + hash.GetFrequencyOfWords("to"));
Console.WriteLine("Frequency of word \'be\' is  : " + hash.GetFrequencyOfWords("be"));
Console.WriteLine("Frequency of word \'or\' is  : " + hash.GetFrequencyOfWords("or"));
Console.WriteLine("Frequency of word \'not\' is : " + hash.GetFrequencyOfWords("not"));

/*  ----------------------- USE CASE -2 --------------------------  */
/*          Counts frequency of words in a large phrase             */

string phrase = "Paranoids are not paranoid because they are paranoid but because they" +
    " keep putting themselves deliberately into paranoid avoidable situations";

string[] words = phrase.ToLower().Split(" ");
int frequencyCount = 0;
string[] uniqueWords = words.Distinct().ToArray();
HashTable.MyMapNode<string,int> myMapNode = new HashTable.MyMapNode<string,int>(uniqueWords.Length);
for(int i = 0; i < words.Length; i++)
{
    if (!myMapNode.CheckKey(words[i]))
    {
        myMapNode.Add(words[i], 1);
    }
    else
    {
        frequencyCount = myMapNode.FindValue(words[i]) + 1;
        myMapNode.Remove(words[i]);
        myMapNode.Add(words[i],frequencyCount);
    }
}
Display(myMapNode);

/*  ----------------------- USE CASE -3 --------------------------  */
/*  Removes the Key value pair node with key-avoidable              */

myMapNode.Remove("avoidable");
Display(myMapNode);

// To display a table of Words and frequency
void Display(HashTable.MyMapNode<String,int> obj) {
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($"{"Frequency",-20} || {"Count",10}");
    Console.WriteLine("-----------------------------------");
    foreach (string key in uniqueWords)
    {
        Console.WriteLine($"{key,-20} || {obj.FindValue(key),10}");
    }
}

