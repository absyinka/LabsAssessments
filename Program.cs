using LabsAssessments;

// Console.Write("How many student there are? ");
// int noOfStudent = int.Parse(Console.ReadLine()!);
// int[] scores = new int[noOfStudent];

// var scoreChecker = new StudentScoreChecker();
// scoreChecker.ScoreProcessor(scores);
// scoreChecker.PrintResult(scores);

// Console.Write("Enter a sentence: ");
// string sentence = Console.ReadLine() ?? "";

// var wordCounter = new WordCounter();
// var words = wordCounter.WordCountEngine(sentence);

// foreach (var item in words)
// {
//     Console.WriteLine($"{item.Key} - {item.Value}");
// }

//Simple shopping cart instance
SimpleShoppingCart simpleShoppingCart = new();

simpleShoppingCart.ShoppingBasket();
simpleShoppingCart.ShoppingCartSummary();