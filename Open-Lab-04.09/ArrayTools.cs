using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {

            List<string> q = new List<string>();
            
            for (int i = 0; i < strings.Length; i++)
            {
                
                if (!q.Contains(strings[i]))
                {

                    q.Add(strings[i]);

                }
                    


                

                

            }
                return q.ToArray();

            








        }
         
    }
}
