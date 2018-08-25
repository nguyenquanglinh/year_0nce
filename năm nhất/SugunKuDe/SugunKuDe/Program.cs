using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SugunKuDe
{
    class Program
    {
     public static  int[,] DocFile(string tenFile)
        {
             string path = "D:\\01.txt";
             var s = File.ReadAllText(path).ToCharArray();
             var arr = new int[9, 9];
            int k=0;
             for (int i = 0; i < 9; i++)
             {
                 for (int j = 0; j < 9; j++)
                 {
                     arr[i, j] = int.Parse(s[k].ToString());
                     k++;
                 }
             }
             
         return arr; 
        }
        static void Main(string[] args)
        {
            int[,] arrGoc = new int[9, 9] { { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 0, 0, 0, 1, 1, 1, 2, 2, 2 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 3, 3, 3, 4, 4, 4, 5, 5, 5 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 }, { 6, 6, 6, 7, 7, 7, 8, 8, 8 } };
       
            
            var de = new DeQuySugunku(arrGoc);


            de.GiaiSugunku();
            Console.ReadLine();
        }
    }
}
