Console.WriteLine("Hello, World!");
string num="12";
var val=Convert.ToInt32(num);
// 'typeof' expects a compile-time type; use GetType() to get the runtime type of the variable
Console.WriteLine(val.GetType() + ": " + val);