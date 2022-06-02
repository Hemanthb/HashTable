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

