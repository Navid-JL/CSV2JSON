using Aspose.Cells;

namespace CSV2JSON.Library;

public static class Converter
{
    public static void CSV2JSON(string csvFilePath, string jsonFileName = "")
    {
        Workbook book = new(csvFilePath);

        if (string.IsNullOrEmpty(jsonFileName))
        {
            string[] directories = csvFilePath.Split('/');
            // Extract the filename from the path and cut off the file extension
            jsonFileName = directories[^1].Split('.')[0];
        }
        if (Directory.Exists(@"../Output"))
            Directory.Delete(@"../Output", true);

        Directory.CreateDirectory("../Output");
        book.Save($@"../Output/{jsonFileName}.json", SaveFormat.Json);
    }
}
