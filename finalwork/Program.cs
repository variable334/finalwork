// string []str = {"1234","1567","-2","computer science"};

// string[] str = { "Russia", "Denmark", "Kazan" };


string[] str = { "Hello", "2", "world", ":-)" };







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