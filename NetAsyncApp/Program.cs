//var task1 = HelloAsync();
//var task2 = HelloAsync();
//var task3 = HelloAsync();



Func<string, Task> task4 = async (name) =>
{
    await Task.Delay(3000);
    Console.WriteLine($"Hello {name}");
};
//await task1;
//await task2;
//await task3;

//task4("Tom");
//task4("Sam");

var r1 = task4("Bob");
var r2 = task4("Joe");
var r3 = SumAsync(100);
await r1;
await r2;
int s = await r3;
Console.WriteLine(s);

void Hello()
{
    Thread.Sleep(3000);
    Console.WriteLine("Hello World");
}

async Task HelloAsync()
{
    Console.WriteLine("start");
    await Task.Run(() => Hello());
    Console.WriteLine("finish");
}

async Task<int> SumAsync(int n)
{
    await Task.Delay(2000);
    int sum = 0;
    for(int i = 1; i <= n; i++)
        sum += i;
    return sum;
}