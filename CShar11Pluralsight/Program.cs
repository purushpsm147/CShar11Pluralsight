// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
var somString = @"abc\d";

//Raw String Litterals
var htmlTag = """<html lang="en"/>""";
Console.WriteLine(htmlTag);

var language = "en";
htmlTag = $""""<html lang="""{language}"""/>"""";
Console.WriteLine(htmlTag);

// small json example
/*
 * {  
    "employee": {  
        "name":       "sonoo",   
        "salary":      56000,   
        "married":    true  
    }  
}  
*/
var json = @"
    {  
        ""employee"": {  
            ""name"":       ""sonoo"",   
            ""salary"":      56000,   
            ""married"":    true  
        }  
    }  
";

Console.WriteLine(json);

//using string literal for better indentation

var json1 = """
        {  
        "employee": {  
            "name":       "sonoo",   
            "salary":      56000,   
            "married":    true  
        }  
    }  
    """;
Console.WriteLine(json1);

//using interpolation
var name = "Devin AI";
json1 = $$"""
        {  
            "employee": {  
                "name":       {{name}},   
                "salary":      56000,   
                "married":    true  
            }  
        }  
    """;

Console.WriteLine(json1);

var temp = 44;
var opinion = temp switch
{
    > 35 => "Hot",
    > 22 => "Mild",
    < 22 => "Cold"
};

var message = $"The temperatue is {opinion}";

var message1 = $"The Temperature is {
    temp switch
    {
        > 35 => "Hot",
        > 22 => "Mild",
        < 22 => "Cold"
    }
    }";

var utf8 = Encoding.UTF8.GetBytes("header: "); //byte array
var anotherWayutf8 = "header: "u8; // ReadOnlySpan Byte