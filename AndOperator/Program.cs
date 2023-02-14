// Tegemist range ülikooliga, range kord (kõik eksamid peavad olema kõrge tulemusega)
// Math >=90 ; Biology >=90 ; Chemistry >=90;

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology= Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry= Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations! You have been accepted!"); // Kui kõik ülaltoodud nõuded = true
}
else
{
    Console.WriteLine("Your application has been rejected."); // Kui üks või mitu nõuetest = false
}

