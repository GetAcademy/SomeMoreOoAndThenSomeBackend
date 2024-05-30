using FlexibleList;

//var list = new HomemadeList<string>();
////var list2 = new HomemadeList<float>();
//while (true)
//{
//    var text = Console.ReadLine();
//    list.Add(text);
//    list.Show();
//}

var list = new List<string>();
//var list2 = new HomemadeList<float>();
while (true)
{
    var text = Console.ReadLine();
    list.Add(text);
    Console.WriteLine($"Count={list.Count} Numbers={string.Join(',', list)}");
}

/*
   var numbers = new int[4];
   var count = 0;
   while (true)
   {
   var numberStr = Console.ReadLine();
   var number = Convert.ToInt32(numberStr);
   var index = count;
   if (index >= numbers.Length)
   {
   var newNumbers = new int[numbers.Length * 2];
   Array.Copy(numbers, newNumbers, numbers.Length);
   numbers = newNumbers;
   }
   numbers[index] = number;
   
   count++;
   
   Console.WriteLine($"Count={count} Numbers={string.Join(',', numbers)}");
   } 
 */