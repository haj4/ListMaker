using System.IO;
using System;
Random r=new Random();
Console.Write("How much users: ");
int s = int.Parse(Console.ReadLine());
Console.Write("Len: ");
int l=int.Parse(Console.ReadLine());
char[] vs = "qwertyuiopasdfghjklzxcvbnm1234567890_.".ToCharArray();
string newLine = Environment.NewLine;
for (int i=0; i<s; i++)
{
    string user = "";
    for (int j = 0; j < l; j++)
        user += vs[r.Next(0, 37)];
    user+= Environment.NewLine;
    File.AppendAllText(@"your path",user);
}
