﻿// string []str = {"1234","1567","-2","computer science"};

// string[] str = { "Russia", "Denmark", "Kazan" };


string[] str = { "Hello", "2", "world", ":-)" };


string[] CreatNewArray(string[]str)
{
 
   int count = Position(str);
   string[] strnew = new string[count];
   int i = 0;
   foreach (string s in str)
   {
      if(s.Count()<=3)
      {
      strnew[i]= s;
      i++;
      }
   }

   return strnew;
}




int Position (string[]str)
{
   int count = 0;
   for (int i = 0; i < str.Length; i++)
   {
      if(str[i].Count()<=3)
      {
         count ++;
      }
   }

   return count;
   
}