var numbers = new int[4];
var count = 0;
while (true)
{
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    var index = count;
    numbers[index] = number;
    count++;

    Console.WriteLine($"Count={count} Numbers={string.Join(',', numbers)}");
}