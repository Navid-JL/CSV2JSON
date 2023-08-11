using CSV2JSON.Library;

Console.WriteLine($"CSV2JSON app {DateTime.Now.Year}");
while (true)
{
    Console.WriteLine(
        "Enter the absolute path to your CSV file or exit to terminate the programme"
    );

    string userInput = Console.ReadLine() ?? string.Empty;

    if (userInput.Trim().ToLower() == "exit")
        Environment.Exit(0);

    if (userInput.Contains(@"\"))
        userInput = userInput.Replace(@"\", @"/");

    if (string.IsNullOrEmpty(userInput))
    {
        Console.WriteLine("Null or empty absolute path");
        break;
    }

    Console.WriteLine(
        "Would you like the json file to have the same name as your CSV file? (yes/no)"
    );
    string hasTheSameName = Console.ReadLine() ?? "no";

    if (hasTheSameName.Trim().ToLower() == "no")
    {
        Console.WriteLine("Enter new file name: ");
        string fileName = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrEmpty(fileName))
            throw new ArgumentException("Empty file name");

        Converter.CSV2JSON(userInput, fileName);
    }
    else
    {
        Converter.CSV2JSON(csvFilePath: userInput, jsonFileName: "");
    }
}
