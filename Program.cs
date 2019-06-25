using System;


namespace SecondAssignment
{
    public class solutions{ /* A class where the solutions are kept */
        public int sum(int[]arr,int length){
            if(length<=0) return 0; /* Base case */
            return (sum(arr,length-1)+arr[length-1]); /* get the sum by starting from the 
                                                        last element and then recurse  */
        }
        public int countSpaces(string str){ /* takes a string as an input */
            if(str.Length<= 0) return 0; /* base case */
            return (str[0] == ' ' ? 1 : 0) + countSpaces(str.Substring(1)); /* check for spaces starting from first 
                                                                         character and then recurse until the base case is hit*/
        }

        public int checkNearest(int num_one, int num_two){ /* takes two integer parameters and 
                                                            returns the number which is nearest to 100 */
          const int referenceValue = 100;  /* Reference value which is to be checked */
            if( num_one == num_two )  /* check if both the numbers are equal, if both are equal then return 0 */
                return 0;
            int difference_one = referenceValue - num_one; /* store the difference in difference_one  */
            int difference_two = referenceValue - num_two; /* store the difference in difference_two */
            int minimumOne = Math.Min(difference_one,difference_two); /* Get the minimum difference*/

             return (referenceValue - minimumOne);
        }

        public void convertLastThreeCharecters(string str){ /* takes an input string */
            if(str.Length == 0) return; /* check if it is an empty string  */
            string lastThree = str.Substring(str.Length-3); /* gets the last 3 string */
            string first = str.Substring(0,str.Length-3); /*gets the first string excluding the last three characters */
            Console.WriteLine(first+lastThree.ToUpper()); /* join the two strings and convert the last 3 to uppercase */
        }
        
        public int largestOfThree(int a , int b , int c){ /* Calculates Largest of three numbers */
            int res = (a>b)? a:b;     /* is a greater than b? if it is then store the largest of then inside res  */
            return ((res>c) ? res: c); /* checks if c is greater than res */
        }

        public string returnHeightsOfPersons(int height){ /* takes height as input  */
            if( height == 0) /* if height is 0  */
                return "Height Cannot Be 0";
            if(height > 190) /* if height is greater than 190cms */
                return "Tall";
            if(height>= 130 && height <=190) /* if height is greater than 130 and is less than or equal to 190 */
                return "Normal";


            return "Short"; /* if none of the conditions satisfy  */
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = {10,10,10,10}; /* Test array */
            solutions s = new solutions(); /* creating an instance of solutions class */
            string testString = "hello world jsjj jjj     "; /* test string */
            Console.WriteLine(s.sum(testArray,testArray.Length));
            Console.WriteLine(s.countSpaces(testString));
            Console.WriteLine(s.checkNearest(60,100));
            s.convertLastThreeCharecters("akash");
            Console.WriteLine(s.largestOfThree(7,2,9));
            Console.WriteLine(s.returnHeightsOfPersons(150));
        }
    }
}
