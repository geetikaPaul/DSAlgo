using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    class ReorderLogs
    {
        /*
         * public class Solution {
    class Letters : IComparable<Letters>
{
    public string id { get; set; }
    public string log { get; set; }
        
        public Letters(string i, string l)
        {
            id = i;
            log = l;
        }

    public int CompareTo(Letters other)
    {
        if (this.log == other.log)
        {
            return this.id.CompareTo(other.id);
        }
        
        return this.log.CompareTo(other.log);
    }
}
    public string[] ReorderLogFiles(string[] logs) {
        int len = logs.Length;
        List<string> digitLogs = new List<string>();
        List<string> letterLogs = new List<string>();
        
        List<Letters> letterDict = new List<Letters>();
        
        
        
        for(int i=0;i<len;i++)
        {
            string[] split = logs[i].Split(" ", 2);
            
            if(Char.IsDigit(split[1][0]))
                digitLogs.Add(logs[i]);
            else
                letterDict.Add(new Letters(split[0], split[1]));
        }
        
        letterDict.Sort();
        
        foreach(var l in letterDict)
        {
            letterLogs.Add(string.Concat(l.id," ", l.log));
        }
        
        return letterLogs.Concat(digitLogs).ToArray();
    }
}*/
    }
}
