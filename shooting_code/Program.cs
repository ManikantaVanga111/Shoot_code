Console.WriteLine("Enter No of robbers");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the robber with whon sam will start shooting");
int initial = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the gap between robbers ");
int gap = Convert.ToInt32(Console.ReadLine());
int[] Robbers = new int[r];
int currentindex = initial- 1;
int count = 0;
for (int i = 0; i < r; i++)
{
    Robbers[i] = i + 1;

}
while (r != 0)
{
    if (currentindex >= r)
    {
        currentindex = currentindex % r;
    }
    count++;
    Console.WriteLine($"Target = {Robbers[currentindex]},{count} shots completed");

 for (int i = currentindex; i < r - 1; i++)
    {
        Robbers[i] = Robbers[i + 1];
    }
    r--;
    currentindex =currentindex+ gap;
}
Console.WriteLine($"{count} shots taken");