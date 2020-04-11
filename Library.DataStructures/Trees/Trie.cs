using System.Collections.Generic;

namespace Library.DataStructures.Trees
{
    public class Trie
    {
        public TrieNode Root { get; set; }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; }

        public bool isCompleteWord { get; set; }
    }
}
