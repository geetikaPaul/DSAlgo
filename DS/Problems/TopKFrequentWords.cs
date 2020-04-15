using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    class TopKFrequentWords
    {
        /*public class Solution {
    public class WordCount{
        public string word;
        public int count;
        
        public WordCount(string w, int c)
        {
            word = w;
            count = c;
        }
    }
    public class Heap{
        private int Left(int i)
        {
            return 2 * i + 1;
        }
        
        private int Right(int i)
        {
            return 2 * i + 2;
        }
        
        private int Parent(int i)
        {
            return i/2;
        }
        
        
        public void MaxHeapify( ref IList<WordCount> wordCounts, int i)
        {
            int left = Left(i);
            int right = Right(i);
             
            int heapSize = wordCounts.Count;
            int largest = i;
            
            if(left<heapSize){
                if(wordCounts[left].count > wordCounts[largest].count)
                    largest = left;
                else if(wordCounts[left].count == wordCounts[largest].count)
                {
                    if(string.Compare(wordCounts[left].word, wordCounts[largest].word) == -1)
                        largest = left;
                }
            }
            
            if(right<heapSize){
                if(wordCounts[right].count > wordCounts[largest].count)
                    largest = right;
                else if(wordCounts[right].count == wordCounts[largest].count)
                {
                     if(string.Compare(wordCounts[right].word, wordCounts[largest].word) == -1)
                        largest = right;
                }
            }
            
            if(i!=largest)
            {
                WordCount w = wordCounts[i];
                wordCounts[i] = wordCounts[largest];
                wordCounts[largest] = w;
                MaxHeapify(ref wordCounts, largest);
            }
            
            
           
        }
        
        public void MaxHeapifyFromLeaf( ref IList<WordCount> wordCounts, int i)
        {
            int parent = Parent(i);
            
            int heapSize = wordCounts.Count;
            int largest = parent;
            
                if(wordCounts[largest].count < wordCounts[i].count)
                    largest = i;
                else if(wordCounts[parent].count == wordCounts[i].count)
                {
                    if(string.Compare(wordCounts[parent].word, wordCounts[i].word) == 1)
                        largest = i;
                }
            
            
            if(parent!=largest)
            {
                WordCount w = wordCounts[parent];
                wordCounts[parent] = wordCounts[i];
                wordCounts[i] = w;
                MaxHeapifyFromLeaf(ref wordCounts, parent);
            }
            
            
           
        }
            
            public WordCount ExtractMax(ref IList<WordCount> arr)
            {
                int len = arr.Count;
                WordCount maxValue = arr[0];
                arr[0] = arr[len - 1];
                arr.RemoveAt(len - 1);
                MaxHeapify(ref arr, 0);
                return maxValue;
            }
        }
        
    
    public IList<string> TopKFrequent(string[] words, int k) {
        int len = words.Length;
        IList<WordCount> wordCounts = new List<WordCount>();
        Dictionary<string, int> dict = new Dictionary<string, int>();
         
        Heap h = new Heap();
        
        for(int i=0;i<len;i++)
        {
            if(dict.ContainsKey(words[i]))
                dict[words[i]]++;
            else
                dict.Add(words[i], 1);
        }
        
        int j = 0;
        foreach(var d in dict)
        {            
            wordCounts.Add(new WordCount(d.Key, d.Value));
            h.MaxHeapifyFromLeaf(ref wordCounts, j++);
        }
        
     for(int i=0;i<wordCounts.Count;i++)
            Console.WriteLine(wordCounts[i].word+ " "+wordCounts[i].count);
        
       // h.MaxHeapify(ref wordCounts, 0);
        IList<string> result = new List<string>();
        //h.MaxHeapify(ref wordCounts, 0);
        for(int i=0;i<k;i++){
            result.Add(h.ExtractMax(ref wordCounts).word);
        }       
      
        return result;
        
        
    }
}*/
    }
}
