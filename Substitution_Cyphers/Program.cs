using Substitution_Cyphers;

Console.WriteLine("Cezar Cypher:");
CezarCypher cezar=new CezarCypher();
Console.WriteLine(cezar.Encrypt("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
Console.WriteLine(cezar.Decrypt("QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD"));

Console.WriteLine("\nROT13:");
ROT13 rot13= new ROT13();
Console.WriteLine(rot13.Encrypt("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"));
Console.WriteLine(rot13.Encrypt("NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"));

Console.WriteLine("\nShift by N:");
Console.Write("Enter N : ");
int N = int.Parse(Console.ReadLine());
ShiftByN shiftByN = new ShiftByN(N);
Console.WriteLine(shiftByN.Encrypt("text"));
Console.WriteLine(shiftByN.Decrypt("whaw"));// for N=3 => text

Console.WriteLine("\nMonoalphabetic Cypher");
MonoalphabeticCipher mono=new MonoalphabeticCipher();
Console.WriteLine(mono.Encrypt("text"));
Console.WriteLine(mono.Decrypt(mono.Encrypt("text")));
