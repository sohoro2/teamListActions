using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins":
                        //TODO
                        break;
                    case "del":
                        //TODO
                        break;
                    case "contains":
                        int numberToCheck = int.Parse(cmd[1]);
                        if (nums.Contains(numberToCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                            break;
                    case "remove": 
                        //TODO
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;

                    case "sum":
                        Console.WriteLine(nums.Sum());
                        break;
                        int index = int.Parse(cmd[1]);
                        if (index >=0 && index<nums.Count)

                        {
                            int removedNumber = nums[index];
                            nums.RemoveAt(index);
                            Console.WriteLine($"Removed number {removedNumber} at index {index}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Index");
                        }
                            break;
                    //TODO

                    default:
                        Console.WriteLine("Unknown command");
                        break;

                    
                       
                }
            }
        }
    }
}
