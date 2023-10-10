namespace BadCode;

public class BadCode
{
    // This method is missing a return statement.
    public void DoSomething()
    {
        // This code is unreachable.
        if (false)
        {
            return;
        }

        // This code is redundant.
        int x = 1;
        int y = x;

        // This code is potentially dangerous.
        string input = Console.ReadLine();
        int number = int.Parse(input);

        var list = new List<Person>
        {
            new("Bob", 30),
            new("Fred", 45)
        };

        // This code is not maintainable.
        // The LINQ query is too long and complex.
        var results = (from item in list
            where item.Name.Contains("foo")
                  && item.Age > 18
            select new { item.Name, item.Age }).ToList();
    }

    // This method has a magic number.
    public int Add(int a, int b)
    {
        return a + b + 1;
    }

    // This method is not documented.
    private void DoSomethingElse()
    {
        // ...
    }
}