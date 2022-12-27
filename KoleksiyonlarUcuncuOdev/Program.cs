using System;

namespace KoleksiyonlarUcuncuOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
            ve dizinin elemanlarını sıralayan programı yazınız.*/
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string text = Console.ReadLine();
       
            int countA =0;
            int countE =0;
            int countI =0;
            int countO =0;
            int countU =0;
            for(int i=0; i<text.Length; i++)
            {
                if(text[i]=='a')
                {
                    countA++;
                }
                else if(text[i]=='e')
                {
                    countE++;
                }
                else if(text[i]=='i')
                {
                    countI++;
                }
                else if(text[i]=='o')
                {
                    countO++;
                }
                else if(text[i]=='u')
                {
                    countU++;
                }
                
            }

            Console.WriteLine($"Cümle içerisinde {countA} tane A, {countE} tane E, {countI} tane I, {countO} tane O ve {countU} tane U harfi vardir.");
            int sumOfCounts=countA+countE+countI+countO+countU;
            Console.WriteLine($"Cümle içerisindeki toplam sesli harf {sumOfCounts}");

            int[] indexOfA = new int[sumOfCounts];
            int[] indexOfE = new int[sumOfCounts];
            int[] indexOfI = new int[sumOfCounts];
            int[] indexOfO = new int[sumOfCounts];
            int[] indexOfU = new int[sumOfCounts];

            for (int i=0; i<sumOfCounts; i++)
            {
                indexOfA [i] = text.IndexOf('a');
                indexOfE [i] = text.IndexOf('e');
                indexOfI [i] = text.IndexOf('i');
                indexOfO [i] = text.IndexOf('o');
                indexOfU [i] = text.IndexOf('u');
            }

            char[] array = new char[sumOfCounts];
            Console.WriteLine("Cümle içerisindeki sesli harflerin siralanmiş hali:");
            for(int i=0; i<countA; i++)
            {
               
                array[i] = text[indexOfA[i]];
         
            }
            for(int i=0; i<countE; i++)
            {
               
                array[i=countA] = text[indexOfE[i]];
         
            }
            for(int i=0; i<countI; i++)
            {
               
                array[i=countA+countE] = text[indexOfI[i]];
         
            }
            for(int i=0; i<countO; i++)
            {
               
                array[i=countA+countE+countI] = text[indexOfO[i]];
         
            }
            for(int i=0; i<countU; i++)
            {
               
                array[i=sumOfCounts-countU]=  text[indexOfU[i]];
         
            }
            
            Console.WriteLine(string.Join(",", array));
            
            //Console.WriteLine(countA*'a'+countE*'e'+countI*'i'+countO*'o'+countU*'u');

        }
    }
}