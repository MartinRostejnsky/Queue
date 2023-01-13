using System;
using Queue;

CustomerQueue q = new CustomerQueue();
try
{
    for (int i = 0; i < 1001; i++)
    {
    Console.WriteLine("New customer (no."+q.Arrive()+")");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

try
{
    for (int i = 0; i < 1001; i++)
    {
        Console.WriteLine("New customer no." + q.Serve());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}