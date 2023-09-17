Console.WriteLine("Input user name");
string userName = Console.ReadLine();

if(userName.ToLower() == "masha") {
    Console.WriteLine("OMG, this is Masha!");
}
else {
    Console.Write("Hello, ");
    Console.WriteLine(userName);
}