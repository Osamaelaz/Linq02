using static Linq02.ListGenerator;
namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators 
            //// 1. Get first product out of stock
            //var productOutOfStock = ProductsList
            //    .Where(x => x.UnitsInStock == 0)
            //    .FirstOrDefault();

            //if (productOutOfStock != null)
            //    Console.WriteLine(productOutOfStock.ProductName + "\n");
            //else
            //    Console.WriteLine("No products out of stock.\n");

            //Console.WriteLine("=================================");

            //// 2. First product whose price > 1000, or null if none
            //var firstProductCostMore1000 = ProductsList
            //    .FirstOrDefault(x => x.UnitPrice > 1000);

            //if (firstProductCostMore1000 != null)
            //    Console.WriteLine(firstProductCostMore1000.ProductName + "\n");
            //else
            //    Console.WriteLine("No product found with price > 1000.\n");

            //Console.WriteLine("=================================");

            //// 3. Retrieve the second number greater than 5
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secondGreaterThan5 = arr
            //    .Where(x => x > 5)
            //    .Skip(1)
            //    .FirstOrDefault();

            //if (secondGreaterThan5 != 0)
            //    Console.WriteLine(secondGreaterThan5);
            //else
            //    Console.WriteLine("There is no second number greater than 5.");

            #endregion
            #region LINQ - Aggregate Operators
            ////1.Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var CountOdd = Arr.Count((x) => x % 2 != 0);
            //Console.WriteLine(CountOdd);
            ////2. Return a list of customers and how many orders each has.
            //var customersAndThierOrders = CustomersList.Select(x => new { x.CustomerName, count = x.Orders.Count() });
            //foreach (var item in customersAndThierOrders)
            //{
            //    Console.WriteLine(item + "\n");
            //}
            ////3. Return a list of categories and how many products each has
            //var categoryProductCounts = ProductsList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    ProductCount = g.Count()
            //});

            //foreach (var item in categoryProductCounts)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductCount} products\n");
            //}
            ////4. Get the total of the numbers in an array.
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int total = arr.Sum();

            //Console.WriteLine($"Total = {total}\n");

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //// 5. Total number of characters of all words
            //int totalChars = words.Sum(w => w.Length);
            //Console.WriteLine($"Total characters = {totalChars} \n");

            //// 6. Length of the shortest word
            //int shortestLength = words.Min(w => w.Length);
            //Console.WriteLine($"Shortest word length = {shortestLength} \n");

            //// 7. Length of the longest word
            //int longestLength = words.Max(w => w.Length);
            //Console.WriteLine($"Longest word length = {longestLength} \n");

            //// 8. Average length of the words
            //double averageLength = words.Average(w => w.Length);
            //Console.WriteLine($"Average word length = {averageLength:F2}\n");
            #endregion
            #region LINQ - Ordering Operators
            ////1. Sort a list of products by name
            //var sortedByName = ProductsList.OrderBy(p => p.ProductName);

            //foreach (var p in sortedByName)
            //    Console.WriteLine(p.ProductName);


            ////2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] arr1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var caseInsensitiveSort = arr1.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var w in caseInsensitiveSort)
            //    Console.WriteLine(w);

            //3. Sort a list of products by units in stock from highest to lowest.
            //var sortedByStockDesc = ProductsList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var p in sortedByStockDesc)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");


            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] arr2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortByLengthThenAlpha = arr2.OrderBy(w => w.Length).ThenBy(w => w);

            //foreach (var w in sortByLengthThenAlpha)
            //    Console.WriteLine(w);

            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortLengthThenCaseInsensitive = arr3.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var w in sortLengthThenCaseInsensitive)
            //    Console.WriteLine(w);

            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var sortCategoryThenPrice = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var p in sortCategoryThenPrice)
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");

            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortLengthThenCaseInsensitiveDesc = arr4
            //    .OrderBy(w => w.Length)
            //    .ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var w in sortLengthThenCaseInsensitiveDesc)
            //    Console.WriteLine(w);

            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var secondLetterIReversed = arr5.Where(w => w.Length > 1 && w[1] == 'i').Reverse();

            //foreach (var w in secondLetterIReversed)
            //    Console.WriteLine(w);

            #endregion
            #region LINQ – Transformation Operators
            ////1. Return a sequence of just the names of a list of products.
            //var productNames = ProductsList
            //    .Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            //// 2.Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH" };

            //var upperLowerWords = words
            //    .Select(w => new
            //    {
            //        Upper = w.ToUpper(),
            //        Lower = w.ToLower()
            //    });

            //foreach (var item in upperLowerWords)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //}

            //// 3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var productInfo = ProductsList.Select(p => new
            //{
            //    p.ProductName,
            //    p.Category,
            //    Price = p.UnitPrice 
            //});

            //foreach (var item in productInfo)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.Category} - {item.Price}");
            //}

            ////4. Determine if the value of int in an array matches their position in the array.

            //int[] arr = { 0, 2, 2, 3, 4, 5, 6, 10 };

            //var matches = arr
            //    .Select((value, index) => new { value, index })
            //    .Where(x => x.value == x.index);

            //foreach (var match in matches)
            //{
            //    Console.WriteLine($"Value {match.value} matches its position {match.index}");
            //}

            //// 5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { A = a, B = b }).Where(pair => pair.A < pair.B);

            //Console.WriteLine($"Pairs where a < b:");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");
            //}

            ////6. Select all orders where the order total is less than 500.00.

            //       var smallOrders = CustomersList
            //.SelectMany(c => c.Orders)
            //.Where(o => o.Total < 500.00m);

            //       foreach (var order in smallOrders)
            //       {
            //           Console.WriteLine($"OrderID: {order.OrderID}, Total: {order.Total}");
            //       }

            ////7. Select all orders where the order was made in 1998 or later.

            //var ordersFrom1998Onwards = CustomersList
            //    .SelectMany(c => c.Orders)
            //    .Where(o => o.OrderDate.Year >= 1998);

            //foreach (var order in ordersFrom1998Onwards)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, Date: {order.OrderDate:d}");
            //}



            #endregion
        }
    }
}
