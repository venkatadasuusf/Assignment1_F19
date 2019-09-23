/*
    Author: Venkata Dasu
    Date: 9/22/2019
    Assignment: ISM 6225 Distributed Information systems F19 Assignment 1
    Comments: This script provides the below methods for Assignment 1. 

              1. Method to print all the self-dividing numbers between integers x and y
              2. Method that prints the following series till n terms:
                 * 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6 …. n terms
              3. Method that prints an inverted triangle using *
              4. You're given an array J representing the types of stones that are jewels, and S representing
                 the stones you have.  Each element in S is a type of stone you have.
                 You want to know how many of the stones you have are also jewels.
                 The elements in J are guaranteed distinct. The function should return an integer.
              5. This method finds the largest common contiguous subarray from two 
                 sorted arrays. The given arrays are sorted in ascending order. If there are multiple 
                 arrays with the same length, then return the last array having the maximum length.
                The function should return the array.
              6. Solve puzzle

*/

using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error.
            */
            try
            {
                // START printSelfDividingNumbers
                
                Console.WriteLine("********** Print Self Dividing Numbers **********");
                Console.WriteLine("");

                Console.Write("Please enter starting range to find the self-dividing numbers: ");

                // This variable will gather data from user input
                string input_starting_range = Console.ReadLine();
                // This variable will be used as a starting range and is parsed as an integer
                int value_of_starting_range = int.Parse(input_starting_range);

                Console.WriteLine("");
                Console.Write("Please enter ending range to find the self-dividing numbers: ");

                // This variable will gather data from user input
                string input_ending_range = Console.ReadLine();
                // This variable will be used as a ending range and is parsed as an integer
                int value_of_ending_range = int.Parse(input_ending_range);
                
                /*
                Execute the printSelfDividingNumbers method and pass the starting and ending range.
                This is a void method. The method computes and prints the self dividing numbers
                with nothing returned. 
                */

                printSelfDividingNumbers(value_of_starting_range, value_of_ending_range);

                Console.WriteLine("");
                Console.WriteLine("********** END Print Self Dividing Numbers **********");
                
                // END printSelfDividingNumbers

                // START printSeries
                
                Console.WriteLine("");
                Console.WriteLine("********** Print Series **********");
                Console.WriteLine("");
                
                Console.Write("Please enter the number of terms of the series: ");
                
                // This variable will gather data from user input
                string input_series_terms = Console.ReadLine();
                // This variable will be used as number of terms of the series and is parsed as an integer
                int value_of_series_terms = int.Parse(input_series_terms);
                
                Console.WriteLine("");
                
                /*
                Execute the printSeries method and pass the number of terms of the series.
                This is a void method. The method prints the series till n terms
                with nothing returned. 
                */

                printSeries(value_of_series_terms);

                Console.WriteLine("");
                Console.WriteLine("********** END Print Series **********");

                // END printSelfDividingNumbers

                // START printTriangle

                Console.WriteLine("");
                Console.WriteLine("********** Print Inverted Triangle **********");
                Console.WriteLine("");

                Console.Write("Please enter the number of lines for the inverted triangle pattern: ");
                // This variable will gather data from user input
                string input_pattern_lines = Console.ReadLine();
                // This variable will be used as number of lines for the pattern and is parsed as an integer
                int value_of_pattern_lines = int.Parse(input_pattern_lines);

                Console.WriteLine("");

                /*
                Execute the printTriangle method and pass the number of lines for the pattern.
                This is a void method. The method prints the inverted triangle for the given number
                of lines with nothing returned. 
                */

                printTriangle(value_of_pattern_lines);

                Console.WriteLine("");
                Console.WriteLine("********** END Print Inverted Triangle **********");

                // END printTriangle

                // START numJewelsInStones

                Console.WriteLine("");
                Console.WriteLine("********** How many of the stones you have are also jewels **********");
                Console.WriteLine("");

                Console.Write("Please enter a positive integer to define the size of the jewels array: ");

                // This variable will gather data from user input
                string jewels_array_size_input = Console.ReadLine();
                // This variable will be used as the size of Jewels array and is parsed as an integer
                int jewels_array_size = int.Parse(jewels_array_size_input);
                // New jewels array of integer data type
                int[] jewels_array = new int[jewels_array_size];

                Console.WriteLine("");
                Console.Write("Please enter the values in jewels array with comma separated: ");

                // Populate the jewels array with user input in a comma separated string
                string[] jewels_array_values_input = Console.ReadLine().Split(",");

                // Populate the jewels integer array from the jewels string array
                Console.WriteLine("");
                Console.WriteLine("The jewels array you have entered is: ");
                Console.Write("[");
                for (int i = 0; i < jewels_array_size; i++)
                {
                    jewels_array[i] = int.Parse(jewels_array_values_input[i]);
                    if (i == 0)
                    {
                        Console.Write(jewels_array[i]);
                    }
                    else
                    {
                        Console.Write(", " + jewels_array[i]);
                    }
                }
                Console.Write("]");                               

                // Making sure the elements in jewels array are distinct
                int[] jewels_array_distinct = jewels_array.Distinct().ToArray();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Please enter a positive integer to define the size of the stones array: ");
                // This variable will gather data from user input
                string stones_array_size_input = Console.ReadLine();
                // This variable will be used as the size of stones array and is parsed as an integer
                int stones_array_size = int.Parse(stones_array_size_input);
                // New stones array of integer data type
                int[] stones_array = new int[stones_array_size];

                Console.WriteLine("");
                Console.Write("Please enter the values in stones array with comma separated: ");

                // Populate the stones array with user input in a comma separated string
                string[] stones_array_values_input = Console.ReadLine().Split(",");

                // Populate the stones integer array from the jewels string array
                Console.WriteLine("");
                Console.WriteLine("The stones array you have entered is: ");
                Console.Write("[");
                for (int i = 0; i < stones_array_size; i++)
                {
                    stones_array[i] = int.Parse(stones_array_values_input[i]);
                    if (i == 0)
                    {
                        Console.Write(stones_array[i]);
                    }
                    else
                    {
                        Console.Write(", " + stones_array[i]);
                    }
                }
                Console.Write("]");

                /*
                Execute the numJewelsInStones method and pass the jewels array and stones array as inputs.
                This is a static value return method. The method searches for the elements of stones array in the 
                jewels array and return the number of matched searches
                The method returns an integer. 
                */

                int jewels_stones_matching_count = numJewelsInStones(jewels_array_distinct, stones_array);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("The number of stones you have that are jewels are: " + jewels_stones_matching_count);
                
                Console.WriteLine("");
                Console.WriteLine("********** END How many of the stones you have are also jewels **********");

                // END numJewelsInStones

                // START getLargestCommonSubArray

                Console.WriteLine("");
                Console.WriteLine("********** Largest common contiguous subarray  **********");
                Console.WriteLine("");

                Console.Write("Please enter a positive integer to define the size of the array a: ");

                // This variable will gather data from user input
                string a_array_size_input = Console.ReadLine();
                // This variable will be used as the size of array a and is parsed as an integer
                int a_array_size = int.Parse(a_array_size_input);
                // New array a of integer data type
                int[] a_array = new int[a_array_size];

                Console.WriteLine("");
                Console.Write("Please enter the values in array a with comma separated: ");

                // Populate the array a with user input in a comma separated string
                string[] a_array_values_input = Console.ReadLine().Split(",");

                // Populate the a integer array from the a string array
                Console.WriteLine("");
                Console.WriteLine("The array a you have entered is: ");
                Console.Write("[");
                for (int i = 0; i < a_array_size; i++)
                {
                    a_array[i] = int.Parse(a_array_values_input[i]);
                    if (i == 0)
                    {
                        Console.Write(a_array[i]);
                    }
                    else
                    {
                        Console.Write(", " + a_array[i]);
                    }
                }
                Console.Write("]");

                // Making sure the elements in jewels array are distinct
                //int[] jewels_array_distinct = jewels_array.Distinct().ToArray();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Please enter a positive integer to define the size of the array b: ");
                // This variable will gather data from user input
                string b_array_size_input = Console.ReadLine();
                // This variable will be used as the size of array b and is parsed as an integer
                int b_array_size = int.Parse(b_array_size_input);
                // New array b of integer data type
                int[] b_array = new int[b_array_size];

                Console.WriteLine("");
                Console.Write("Please enter the values in array b with comma separated: ");

                // Populate the array b with user input in a comma separated string
                string[] b_array_values_input = Console.ReadLine().Split(",");

                // Populate the b integer array from the b string array
                Console.WriteLine("");
                Console.WriteLine("The array b you have entered is: ");
                Console.Write("[");
                for (int i = 0; i < b_array_size; i++)
                {
                    b_array[i] = int.Parse(b_array_values_input[i]);
                    if (i == 0)
                    {
                        Console.Write(b_array[i]);
                    }
                    else
                    {
                        Console.Write(", " + b_array[i]);
                    }
                }
                Console.Write("]");

                /*
                Execute the getLargestCommonSubArray method that expects two arrays a and as inputs 
                This method finds the largest common contiguous subarray from two sorted arrays.
                The method returns an array of integers.
                */

                int[] LargestCommonSubArray = getLargestCommonSubArray(a_array, b_array);

                /*
                Execute the displayArray method that expects an integer array as an input
                This method prints the elements of the array to the console.
                The method does not return anything.
                */
                displayArray(LargestCommonSubArray);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("********** END Largest common contiguous subarray **********");

                // END getLargestCommonSubArray

                //solvePuzzle();

            }

            catch
            {
                Console.WriteLine("Exception occured while running the Assignment 1 methods");
                Console.ReadKey(true);
            }   // End of catch

        }   // End of Main

        /*
            This is a static void method to print the self dividing numbers between a given range. 
        */
        public static void printSelfDividingNumbers(int starting_range, int ending_range)
        {
            /*
               Use the try catch block to handle the exceptions.
            */
            try
            {
                int self_divide_indicator = 1;
                int for_display = 0;

                Console.WriteLine("");
                Console.WriteLine("The self-dividing numbers between " + starting_range + " and " + ending_range + " are: ");
                Console.WriteLine("");

                // call isSelfDividing method for each number in the range 
                 
                for (int i = starting_range; i <= ending_range; i++)
                {
                    self_divide_indicator = isSelfDividing(i);

                    /* Print the self-dividing numbers to the console if the self_divide_indicator 
                    returned from isSelfDividing is 1 for that number
                    */
                    if (self_divide_indicator == 1 && i != 0)
                    {
                        if (for_display == 0)
                        {
                            Console.Write(i);
                            for_display = 1;
                        }
                        else
                        {
                            Console.Write(", " + i);
                        }
                        
                    }

                } // End of for
                Console.WriteLine("");

            }   // End of try
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
                Console.ReadKey(true);
            }   // End of catch

        }   // End of printSelfDividingNumbers()

        /*
            This is a static value return method computes if a number is self-dividing or not.
            The method returns an integer indicator (1 = self-dividing ; 0 = not).
        */
        public static int isSelfDividing(int current_number)
        {

            // Variable to track if the number is self-dividing. This will be returned to the calling method
            int self_divide = 1;
            /*
               Use the try catch block to handle the exceptions.
            */
            try
            {
                // Variable to track the individual digits of the number
                int current_digit = 0;
                int current_number_value = current_number;

                while (current_number_value > 0 && self_divide == 1)
                {
                    //Checking if the current number is double digit. If yes, will divide it by 10 to get the remainder
                    if (current_number_value > 9)
                    {
                        current_digit = current_number_value % 10;
                    }
                    else
                    {
                        current_digit = current_number_value;
                    }

                    //Checking if the current digit from remainder is >0
                    if (current_digit > 0)
                    {
                        //if the current number is divisible by the current digit
                        if (current_number % current_digit == 0)
                        {
                            self_divide = 1;
                        }
                        else
                        {
                            self_divide = 0;

                        }
                    }
                    else
                    {
                        self_divide = 0;

                    }


                    current_number_value = current_number_value / 10;

                } // End of while loop

            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
                Console.ReadKey(true);
            }   // End of catch

            //return self-divide indiciator (1 or 0) back to printSelfDividingNumbers method. 
            return self_divide;

        }   // End isSelfDividing()

        
        /*
            This is static void method to print the following series till n terms
            1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6 …. n terms
        */
        public static void printSeries(int series_terms)
        {
            /*
               Use the try catch block to handle the exceptions.
            */
            try
            {
                int starting_print = 0;
                int print_value = 1;
                int count = 0;

                Console.WriteLine("The print series till " + series_terms + " terms is: ");
                Console.WriteLine("");

                // While the series terms input is atleast greater than 0
                while (starting_print < series_terms)
                {
                    //To start the printing of series from 1
                    print_value = starting_print + 1;
                    while (print_value > 0)
                    {
                        if (starting_print == 0)
                        {
                            Console.Write(starting_print + 1);
                        }
                        else
                        {
                            Console.Write(", " + (starting_print + 1) );                       
                        }
                        
                        print_value--;
                        count++;
                        if (count == series_terms)
                        {
                            break;
                        }
                    }

                    starting_print++;

                    if (count == series_terms)
                    {
                        break;
                    }

                }   // End of while loop

                Console.WriteLine("");
            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
                Console.ReadKey(true);
            }   // End of catch

        }   // End of printSeries()

        /*
            This is static void method to print the inverted triangle pattern
            for the given number of lines
        */
        public static void printTriangle(int no_of_lines_pattern)
        {
            /*
               Use the try catch block to handle the exceptions.
            */
            try
            {
                int print_line = 0;
                int line_count = 0;

                Console.WriteLine("The inverted triangle pattern for " + no_of_lines_pattern + " lines is: ");
                Console.WriteLine("");

                print_line = no_of_lines_pattern + (no_of_lines_pattern - 1);

                while (no_of_lines_pattern > 0)
                {
                    //Starting the first line of the print with the below formula
                    print_line = no_of_lines_pattern + (no_of_lines_pattern - 1);

                    while (print_line > 0)
                    {
                        Console.Write("*");
                        print_line--;

                    }

                    no_of_lines_pattern--;
                    Console.WriteLine("");
                    line_count++;

                    for (int i = 0; i < line_count; i++)
                    {
                        Console.Write(" ");
                    }

                }   // End of while

            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
                Console.ReadKey(true);
            }   // End of catch

        }   // End of printTriangle()

        /*
            This is a static value return method that expects two arrays (jewels, stones) as inputs 
            The method searches (binary search algorithm) for the elements of stones array in the 
            jewels array and returns the number of matched searches
            The method returns an integer. 
        */
        public static int numJewelsInStones(int[] jewels_arr, int[] stones_arr)
        {        
            // This variable is used to keep a count of the matching stones in jewels array
            int matching_count = 0;
            /*
               Use the try catch block to handle the exceptions.
            */
            try
            {
                /*  sort the jewels array as binary search algorithm is being used to search stones array elements
                    in jewels array
                */
                Array.Sort(jewels_arr);

                // Binary search algoritm

                // This is the lower element of the jewels array. Initialize to 0 for now.
                int low = 0;
                // This is the upper element of the jewels array
                int high = (jewels_arr.Length) - 1;
                // This is the middle of the array. mid is rounded down automatically if (low + high) is not an even number
                int mid = (low + high) / 2;
                int middle_value = 0;
                int track_middle_high = 0;
                
                // Iterate all the elements in stones array to search against jewels array
                for (int i = 0; i < stones_arr.Length; i++)
                {
                    low = 0;
                    high = (jewels_arr.Length) - 1;
                    mid = (low + high) / 2;
                    middle_value = 0;
                    track_middle_high = 0;

                    // Binary search algorithm
                    while (low <= high)
                    {
                        mid = (low + high) / 2;
                        middle_value = jewels_arr[mid];

                        if (middle_value == stones_arr[i])
                        {
                            //Increment the matching count variable, after a match is found
                            matching_count++;
                            // Break out of the loop once the match for the search is found
                            break;
                        }

                        else if (middle_value > stones_arr[i] && track_middle_high != middle_value)
                        {
                            high = mid - 1;
                            track_middle_high = middle_value;
                        }

                        else
                        {
                            low = mid + 1;
                        }

                    }   // End of while loop 

                    if (low > high)
                    {
                    }
                }

                return matching_count;
            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
                Console.ReadKey(true);
                
            }   // End of catch

            return matching_count;

        }   // End of numJewelsInStones()

        /*
            This is a static value return method that expects two arrays a and as inputs 
            This method finds the largest common contiguous subarray from two sorted arrays.
            The given arrays are sorted in ascending order.
            The method returns an array of integers. 
        */
        public static int[] getLargestCommonSubArray(int[] a_arr, int[] b_arr)
        {
            /*
               Use the try catch block to handle the exceptions.
            */
            try
            {
                
                // Sort the input arrays
                Array.Sort(a_arr);
                Array.Sort(b_arr);

                int a_arr_length = a_arr.Length;
                int b_arr_length = b_arr.Length;

                var list_common_sub_array = new List<int>();

                //for each element in array a
                for (int i = 1; i <= a_arr.Length - 1; i++)
                {
                    //checking for contiguous subarray by comparing with previous element
                    bool search = false;
                    
                    if (a_arr[i] == a_arr[i - 1] + 1)
                    {
                        if (i == 1)
                        {
                            //search for a_arr[i-1];
                            search = SearchInArray(a_arr[i - 1], b_arr);
                            if (search == true)
                            {
                                list_common_sub_array.Add(a_arr[i - 1]);
                            }

                        }

                        //search for a_arr[i] using Binary search algorithm
                        search = SearchInArray(a_arr[i], b_arr);
                        if (search == true)
                        {
                            list_common_sub_array.Add(a_arr[i]);
                        }
                    }

                    else if (i != a_arr.Length - 1)
                    {
                        if (a_arr[i] == a_arr[i + 1] - 1)
                        {
                            //search for a_arr[i] using Binary search algorithm
                            search = SearchInArray(a_arr[i], b_arr);
                            if (search == true)
                            {
                                list_common_sub_array.Add(a_arr[i]);
                            }
                        }

                    }

                }

                int[] CommonSubArray = findCommonSubArray(list_common_sub_array);

                return CommonSubArray;

            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
                Console.ReadKey(true);
            }   // End of catch

            return null; 

        }   // End of getLargestCommonSubArray()

        /*
            This is a static value return method that expects an array and an integer as inputs 
            This method searches for input integer in the input array (binary search)
            The method returns boolean value true or false. 
        */
        public static bool SearchInArray(int match_val, int[] b_array)
        {
            int low = 0;
            int high = (b_array.Length) - 1;
            int mid = (low + high) / 2;
            int middle_value = 0;
            int track_middle_high = 0;

            /*
               Use the try catch block to handle the exceptions.
            */

            try
            {
                //Binary search algorithm
                while (low <= high)
                {
                    mid = (low + high) / 2;
                    middle_value = b_array[mid];

                    if (middle_value == match_val)
                    {
                        return true;
                    }

                    else if (middle_value > match_val && track_middle_high != middle_value)
                    {
                        high = mid - 1;
                        track_middle_high = middle_value;
                    }

                    else
                    {
                        low = mid + 1;
                    }
                 }

                if (low > high)
                {
                    return false;
                }
            }

            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
                Console.ReadKey(true);
            }   // End of catch
            
            return false;

        }   // End of SearchInArray()

        /*
            This is a static value return method that expects a list of integer as input 
            This method finds the largest common contiguous subarray from the list.
            The method returns an array of integers. 
        */

        public static int[] findCommonSubArray(List<int> common_sub_array)
        {
            List<int> temp1 = new List<int>();
            List<int> temp2 = new List<int>();
            bool temp1_available = true;
            bool temp2_available = true;

            /*
               Use the try catch block to handle the exceptions.
            */
            try
            {
                for (int i = 0; i < common_sub_array.Count - 1; i++)
                {
                    //comparing sub-arrays

                    if (temp1_available == false && temp2_available == false)
                    {
                        if (temp1.Count == temp2.Count)
                        {

                            if (temp1[0] > temp2[0])
                            {
                                temp2.Clear();
                            }
                            
                            else
                            {
                                temp1.Clear();
                            }
                        }

                        else if (temp1.Count > temp2.Count)
                        {
                            temp2.Clear();
                        }
                        else
                        {
                            temp1.Clear();
                        }
  
                    }

                    if (common_sub_array[i] == (common_sub_array[i + 1] - 1))
                    {
                        if (temp1_available == true || temp1.Count == 0)
                        {
                            if (temp1.Count == 0)
                            {
                                temp1.Add(common_sub_array[i]);
                                temp1.Add(common_sub_array[i + 1]);

                            }
                            else
                            {
                                temp1.Add(common_sub_array[i + 1]);

                            }
                        }

                        else
                        {
                            if (temp1.Count != 0)
                            {
                                temp1_available = false;
                            }
                            else { }

                            if (temp2.Count == 0)
                            {
                                temp2.Add(common_sub_array[i]);
                                temp2.Add(common_sub_array[i + 1]);

                            }
                            else if (temp2_available == true)
                            {
                                temp2.Add(common_sub_array[i + 1]);
                            }
                        }
                        if (i == common_sub_array.Count - 2)
                        {
                            temp1_available = false;
                            temp2_available = false;
                        }
                    }
                    else
                    {

                        if (temp1.Count != 0)
                        {
                            temp1_available = false;
                        }
                        else { }

                        if ((common_sub_array[i] == (common_sub_array[i + 1] - 1)) && temp2.Count == 0)
                        {
                            temp2.Add(common_sub_array[i]);
                            temp2.Add(common_sub_array[i + 1]);
                        }
                        else if (common_sub_array[i] == (common_sub_array[i + 1] - 1) && temp2_available == true)
                        {
                            temp2.Add(common_sub_array[i + 1]);
                        }
                        else if (temp2.Count != 0)
                        {
                            temp2_available = false;
                        }

                        if (i == common_sub_array.Count - 2)
                        {
                            temp1_available = false;
                            temp2_available = false;
                        }
                    }

                    if (i == common_sub_array.Count - 2)
                    {
                        temp1_available = false;
                        temp2_available = false;
                    }
                }
                                    
                if (temp1_available == false && temp2_available == false)
                {
                    if (temp1.Count == temp2.Count)
                    {

                        if (temp1[0] > temp2[0])
                        {
                            temp2.Clear();
                        }
                        
                        else
                        {
                            temp1.Clear();
                        }
                    }

                    else if (temp1.Count > temp2.Count)
                    {
                        temp2.Clear();
                    }
                    else
                    {
                        temp1.Clear();
                    }

                 }
                                
                if (temp1.Count > temp2.Count)
                {
                    
                    int[] final_common_sub_array = temp1.ToArray();
                    return final_common_sub_array;
                }
                else
                {
                    int[] final_common_sub_array = temp2.ToArray();
                    return final_common_sub_array;

                }

                
            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
                Console.ReadKey(true);
            }   // End of catch

            return null;

        }   // End of findCommonSubArray()
               

        /*
            This is a static void method that expects an integer array as an input
            This method prints the elements of the array to the console.
            The method does not return anything. 
        */
        public static void displayArray(int[] largest_common_subarr)
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("The largest common contiguous subarray between arrays a and b is: ");
                Console.Write("[");
                for (int i = 0; i < largest_common_subarr.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(largest_common_subarr[i]);
                    }
                    else
                    {
                        Console.Write("," + largest_common_subarr[i]);
                    }

                }

                Console.Write("]");

            }   // End of try

            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
                Console.ReadKey(true);
            }   // End of catch

        }   // End of displayArray()


        public static void solvePuzzle()
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
                Console.ReadKey(true);
            }
        }   // End of solvePuzzle()

    }   // End of class
}   // End of namespace

