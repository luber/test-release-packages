namespace test_release_packages;

public static class Class1
{
    public static string GetString(string input) 
    {
        return "Test" + input;
    }

    public static string GetString2(string input2) 
    {
        var a = 1;
        return $"Test2-{a}" + input2;
    }
}
