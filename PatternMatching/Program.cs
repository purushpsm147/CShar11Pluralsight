// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var ints = new int[] { 1, 2, 3, 4, 5 };
if(ints is [1,2, 3, 4, 5])
{
    Console.WriteLine("match");
}

if (ints is [ 3, 4, 5])
{
    Console.WriteLine("no match");
}

//Discard pattern, match any 5 value
if (ints is [_,_,_,_,_])
{
    Console.WriteLine("match");
}

//Slice pattern, We need first 3 values to match and rest does not matter.
//also match if list has only two elements

if (ints is [_, _, _, ..])
{
    var firstInd = ints[0]; // confirm access to first element without exeception
    Console.WriteLine("match");
}
//specify length of slice pattern
if (ints is [_, _, _, .. { Length: 3}])
{
    //Rest of the values are not important
    Console.WriteLine("match");
}

//var pattern
if (ints is [ var first, _, _, .. { Length: 3 }])
{
    Console.WriteLine(first);
}

//var pattern
if (ints is [var first1, _, .. var rest])
{
    //rest is array
    Console.WriteLine(rest);
}

//logical pattern: first should be less than 5, second can be anything, third should be greater than 5, rest does not matter
if ( ints is [<5, _, >5,..])
{
    //output is not matched
}

//Subpattern : first should be 1 or 2, second can be anything, third should be less than 5, rest does not matter
if(ints is [1 or 2, _, <5, ..])
{
    Console.WriteLine("match");
}
