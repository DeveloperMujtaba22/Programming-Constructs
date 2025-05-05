// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//string name = "ABC";
//float num = 5;
//float num1 = 12.5f;
//Console.WriteLine(name);
//Console.WriteLine(num);
//Console.WriteLine(num1);

//const float pi = 3.14f;
//float radius = 5;
//float area = pi * radius * radius;
//Console.WriteLine("Area of circle is:" + area);


//Console.Write("Enter your name: ");
//name = Console.ReadLine();
//Console.WriteLine(name);


const double totalMarks = 500;
Console.Write("Enter Obtained Marks:");
double obtMarks = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("obtained Marks: " + obtMarks);
Console.WriteLine("Total Marks: " + totalMarks);
double percent = (obtMarks / totalMarks) * 100;
Console.WriteLine("Percentage: " + percent);


if (percent >= 80)
{
  Console.WriteLine("A");
}
else if(percent >= 70 && percent < 80 )
{
  Console.WriteLine("B");
}
else if (percent >= 60 && percent < 70)
{
  Console.WriteLine("C");
}
else if (percent >= 50 && percent < 60)
{
  Console.WriteLine("D");
}
else
{
  Console.WriteLine("F");
}









