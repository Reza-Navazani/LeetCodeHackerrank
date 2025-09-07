using LeetCodeHackerrank.Solutions;

Console.WriteLine("LeetCode Solutions Runner");
        Console.WriteLine("Enter the solution number to run (e.g., 1 for Solution1, 4 for Solution4):");

        string input = Console.ReadLine();
        
        switch (input)
        {
            case "1":
                var solution1 = new Solution1();
                solution1.Main1();
                break;
            case "3":
                Solution3.Main();
                break;
            case "4":
                Solution4.Main();
                break;
            case "5":
                IsMatch.Main();
                break;
            default:
                Console.WriteLine("Invalid solution number. Please enter a valid solution.");
                break;
        }