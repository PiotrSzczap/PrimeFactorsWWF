using System;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorsWWF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a positive integral number");
            var data = Console.ReadLine();
            if (int.TryParse(data, out int number))
            {
                var workflow = new FactorWorkflow();
                var result = WorkflowInvoker.Invoke(workflow, new Dictionary<string, object>()
                {
                    { "number", number }
                });
                var list = (List<int>)result["result"];
                Console.WriteLine(string.Join(", ", list));
            }
            else
            {
                Console.WriteLine("This is NOT a number");
            }

            Console.ReadKey();
        }
    }
}
