namespace LINQ_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = LINQ_methods.Where(numbers, n => n % 2 == 0);
            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Numbers at even indices:");
            var evenIndexedNumbers = LINQ_methods.WhereIndex(numbers, (n, index) => index % 2 == 0);
            foreach (var num in evenIndexedNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Squared numbers:");
            var squaredNumbers = LINQ_methods.Select(numbers, n => n * n);
            foreach (var num in squaredNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Numbers with their indices:");
            var numbersWithIndices = LINQ_methods.SelectIndex(numbers, (n, index) => $"Index {index}: {n}");
            foreach (var str in numbersWithIndices)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Numbers after skipping first 5:");
            var skippedNumbers = LINQ_methods.Skip(numbers, 5);
            foreach (var num in skippedNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Numbers after taking first 3:");
            var takenNumbers = LINQ_methods.Take(numbers, 3);
            foreach (var num in takenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Numbers before number 7");
            var numbersBeforeSeven = LINQ_methods.TakeWhile(numbers, n => n < 7);
            foreach (var num in numbersBeforeSeven)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Numbers Skipping before 5");
            var numbersSkippingBeforeFive = LINQ_methods.SkipWhile(numbers, n => n < 5);
            foreach (var num in numbersSkippingBeforeFive)
            {
                Console.WriteLine(num);
            }
        }
    }
}
