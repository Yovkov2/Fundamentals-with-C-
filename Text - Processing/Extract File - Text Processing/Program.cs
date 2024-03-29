string[] files = Console.ReadLine()
    .Split("\\", StringSplitOptions.RemoveEmptyEntries );
string file = files[files.Length - 1];
string[] tokens = file.Split( '.' );
string fileName = tokens[0];
string fileExtension = tokens[1];
Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");
