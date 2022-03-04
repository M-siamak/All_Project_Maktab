//Console.WriteLine("enter the operaion :( + -  *  ) ");
//var operation = Console.ReadLine();

//Console.WriteLine("how many numbers do you want enter  ? ");
//int circle = Convert.ToInt32(Console.ReadLine());

//int[] numbers = new int[circle];

//for (int i = 0; i < numbers.Length ; i++)
//{
//    Console.WriteLine($"pls enter {i+1} number : ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    numbers[i] = num;

//}

//int result = 0;
//int mresult = 1;
//int printOperator = 1;
//switch (operation)
//{
//    case "+":
//        foreach (int item in numbers)
//        {
//            result += item;
//            Console.Write($"{item} ");

//            if (printOperator < circle)
//            {
//                Console.Write("+ ");
//                printOperator += 1;
//            }
//        }
//        Console.Write($"= {result}");

//        break;

//    case "-":

//        foreach (int item in numbers)
//        {
//            result -= item;
//            Console.Write($"{item} ");

//            if (printOperator < circle)
//            {
//                Console.Write("- ");
//                printOperator += 1;
//            }
//        }
//        Console.Write($"= {result}");

//        break;


//    case "*":
//        foreach (int item in numbers)
//        {
//            mresult *= item;
//            Console.Write($"{item} ");

//            if (printOperator < circle)
//            {
//                Console.Write("* ");
//                printOperator += 1;
//            }
//        }
//        Console.Write($"= {mresult}");



//        break;

//}

//int[] items = { 2, 3, 5, 3, 7, 5 };
//int n = items.Length;

//Console.WriteLine("Unique array elements: ");

//for (int i = 0; i < n; i++)
//{
//    bool isDuplicate = false;
//    for (int j = 0; j < i; j++)
//    {
//        if (items[i] == items[j])
//        {
//            isDuplicate = true;
//            break;
//        }
//    }

//    if (!isDuplicate)
//    {
//        Console.WriteLine(items[i]);

//    }
//}

//Console.ReadLine();

//var sampleFilePath = "c:\\Users\\Alireza\\Desktop\\maktab\\SampleFile.csv";
//var sampleFilePath = "c:\\Users\\Alireza\\Desktop\\maktab\\SampleFile.csv";
//var sampleFilePath = "c:\\Users\\Alireza\\Desktop\\maktab\\SampleFile.csv";

//var sampleFile = File.Create("c:\\Users\\Alireza\\Desktop\\maktab\\SampleFile.txt");

//sampleFile.Close();
//var sampleFilePath = "c:\\Users\\Alireza\\Desktop\\maktab\\SampleFile.csv";

//string[] Names = new string[3];

//for (int i = 0; i < 3; i++)
//{

//    Console.WriteLine("pls enter your name and family name and age  :");
//    var name = Console.ReadLine();
//    Names[i] = name;
//}

//File.AppendAllLines(sampleFilePath, Names);



//Console.WriteLine("pls enter your new file name :");
//var nameNewFile = Console.ReadLine();
//string sampleFilePath1 = $"c:\\Users\\Alireza\\Desktop\\maktab\\{nameNewFile}.csv";

//Console.WriteLine("pls enter your new file name :");
//var nameBackFile = Console.ReadLine();
//string sampleFilePath2 = $"c:\\Users\\Alireza\\Desktop\\maktab\\{nameBackFile}.csv";

////CopyFile(sampleFilePath,sampleFilePath1);

//MyReplaceFile(sampleFilePath,sampleFilePath1,sampleFilePath2);

//void CopyFile(string addressFile , string nameNewFile)
//{
//    var fileReader = File.ReadAllLines(addressFile);
//    File.WriteAllLines(nameNewFile, fileReader);
//}

//void MyReplaceFile(string sourceFile , string replaceFile , string backFile)
//{
//    CopyFile(replaceFile, backFile);
//    CopyFile(sourceFile, replaceFile);
//    File.Delete(sourceFile);

//}

//var result = "c:\\Users\\Alireza\\Desktop\\maktab\\SampleFile.csv";
//var path = "c:\\Users\\Alireza\\Desktop";

//var dirs = Convert.ToString( Directory.GetDirectories(path));
//var files = Convert.ToString( Directory.GetFiles(path)); 

//foreach(var dir in dirs)
//{
//    DirectoryInfo.dir();
//    File.AppendAllLines(result, dir.);
//    foreach (var file in files)
//    {
//        File.AppendAllLines(result,file.name );
//    }
//}


var result = "c:\\Users\\Alireza\\Desktop\\maktab";
var files = Directory.GetFiles(result);
string[] wrongNames = { "mactab", "mactaab", "maactab", "maktaab", "maaktab" };
foreach (var item in files)
{
    var infoFile = new FileInfo(item);
    foreach (var name in wrongNames)
    {
        if (infoFile.Name.StartsWith(name))
        {
            File.Move(item, item.Replace(name, "maktab"));
        }
    }
}


//if ()
//{

//}







