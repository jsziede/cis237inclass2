using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factorial
    {
        public Factorial()
        {
            //prompt the user for a number to compute
            Console.WriteLine("Input a number to calculate the factorial of: ");
            try
            {
                //get the number to perform a factorial on from the user
                int factorialInt = Convert.ToInt32(Console.ReadLine());

                //output what the problem to solve is
                Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");

                //solve the problem and put it in an answerInt
                int answerInt = Calculate(factorialInt);

                Console.WriteLine(Environment.NewLine + "The answer is " + answerInt + Environment.NewLine);
            }
            catch
            {
                Console.WriteLine("You did not enter a valid integer.");
            }
        }

        private int Calculate(int number)
        {
            //if the number is one, we have reached the base case. wer want our execution
            //to change and styart returning from the method calls.
            //if we did not have this base casem we would continue to put calls on the call stack until a stack overflow were to happen.
            if (number == 1)
            {
                return 1;
                //return number; also works!
            }
            //since we are not at the base case of number equaling 1, we want to call this method that we are in another time and send in the number - 1.
            //this is called a recursive call.
            return number * Calculate(number - 1);
        }
    }
}
