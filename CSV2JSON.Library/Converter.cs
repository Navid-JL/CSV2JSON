using Aspose.Cells;

namespace CSV2JSON.Library;

public static class Converter
{
    public static void CSV2JSON(string csvFilePath, string jsonFileName)
    {
        Workbook book = new(csvFilePath);

        book.Save($"{jsonFileName}.json", SaveFormat.Json);
    }
}
