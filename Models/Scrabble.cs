//input to be array
//split array
//loop through array
using System;

namespace Scrabble.Models
{
    public class Scrabbles
    {
        // public int Point {get; set;}
        // public string Input{get;set;}

        // public Scrabble ( int point, string input)
        // {
        //     Point = point;
        //     Input = input;
        // }


        public int GetPoints(string input)
        {      
                char[] array = input.ToCharArray();
                int point = 0;
                for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == 'a' ||array[i] == 'e' ||array[i] == 'i' || array[i] =='o' || array[i] =='u' ||array[i] == 'l' || array[i] =='n' || array[i] =='r' ||array[i] == 's' || array[i] =='t')
                {
                     point ++;
                }
                else if( array[i] == 'd' ||array[i] == 'g')
                {
                     point +=2;
                }
                else if(array[i] == 'b' ||array[i] == 'c' ||array[i] == 'm' ||array[i] == 'p')
                {
                     point +=3;
                }
                else if(array[i] == 'f' || array[i] =='h' || array[i] =='v' ||array[i] == 'w' ||array[i] == 'y')
                {
                     point +=4;

                }
                else if(array[i] == 'k')
                {
                     point +=5;
                }
                else if(array[i] == 'j' || array[i] =='x')
                {
                     point +=8;
                }
                else if(array[i] == 'q' || array[i] =='z')
                {
                    point +=10;
                }
                else
                {
                     point +=0;
                     break;
                }
                
                
            }
            return point;
        }
        // public int GetScore()
        //         {
        //             return Point;
        //         }
    }
}