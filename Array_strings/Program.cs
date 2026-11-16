//Task 1

//Console.Write("Enter size: ");
//int size = int.Parse(Console.ReadLine());
//int[] arr = new int[size];

//for (int i = 0; i < size; i++)
//{
//    arr[i] = new Random().Next(-100, 100);
//}

//int number, count = 0;
//Console.Write("Enter number: ");
//number = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < size; i++)
//{
//    if (arr[i] == number)
//    {
//        count++;
//    }
//}

//Console.Write("Count of this number in array is: ");
//Console.Write(count);


//Task 2

//int rows = 7, cols = 8;

//int[,] arr = new int[rows, cols];

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr[i, j] = new Random().Next(-100, 100);
//    }
//}

//Console.WriteLine(arr.Cast<int>().Min());


//Task 3

//using System.Text;

//string str;
//Console.Write("Enter string: ");
//str = Console.ReadLine();


//do
//{
//    int choice;
//    Console.WriteLine("1 - Show text: ");
//    Console.WriteLine("2 - Count symbols in text: ");
//    Console.WriteLine("3 - Count of word in text: ");
//    Console.WriteLine("4 - Swap word on another word: : ");
//    Console.WriteLine("5 - Delete world: ");
//    Console.Write("Enter choice: ");
//    choice = Convert.ToInt32(Console.ReadLine());

//    string asked_word, old_word, new_word;
//    int[] pos = new int[] { };
//    int count = 0;
//    string[] words;
//    StringBuilder new_str = new StringBuilder();

//    switch (choice)
//    {
//        case 1:
//            Console.WriteLine(str);
//            break;
//        case 2:
//            Console.WriteLine(str.Length);
//            break;
//        case 3:
//            Console.WriteLine("Enter asked word");
//            asked_word = Console.ReadLine();

//            words = str.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' });

//            for (int i = 0; i < words.Length; i++)
//            {
//                if (asked_word == words[i])
//                {
//                    pos = pos.Append(i).ToArray();
//                    count++;
//                }
//            }

//            Console.WriteLine("Positions: ");
//            for (int i = 0; i < pos.Length; i++)
//            {
//                Console.Write($"{pos[i]} + {" "}");
//            }
//            Console.WriteLine();
//            Console.WriteLine($"Count: {count}");

//            break;
//        case 4:
//            Console.WriteLine("Enter word which you want to switch: ");
//            old_word = Console.ReadLine();
//            Console.WriteLine("Enter word on which you want to switch old word: ");
//            new_word = Console.ReadLine();
//            str = str.Replace(old_word, new_word);
//            Console.WriteLine(str);
//            break;
//        case 5:
//            Console.WriteLine("Enter word which you want to del: ");
//            asked_word = Console.ReadLine();

//            words = str.Split(' ');

//            for (int i = 0; i < words.Length; i++)
//            {
//                if (asked_word != words[i])
//                {
//                    new_str.Append(words[i]);
//                    new_str.Append(" ");
//                }
//            }
//            str = new_str.ToString();
//            Console.WriteLine(str);
//            break;
//    }
//} while (true);
