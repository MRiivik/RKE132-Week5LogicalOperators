// Math >= 90 OR Chemistry >= 90 OR Biology >= 90

// Math && Chem || Math && Biology || Chem && Biology 

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90)) // (false || true || true) --> true
{
    Console.WriteLine("Congratulations! You have been accepted!"); // Kui 2/3 ainetest on >= 90
}
else
{
    Console.WriteLine("Your application has been rejected."); // Kui 2/3 ainetest on < 90
}