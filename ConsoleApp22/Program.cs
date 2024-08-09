using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите уменьшаемое и вычитаемое число (между числами должен быть один пробел)");
        int x, y;

        int[] inputValues = ReadInput();
        x = inputValues[0];
        y = inputValues[1];

        int result = x - y;

        Console.WriteLine(result);
    }

    public static int[] ReadInput()
    {
        int[] result = new int[2];

        try
        {
            string inputLine = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(inputLine))
            {
                throw new InvalidOperationException("Значение является Null или пробелы");
            }

            string[] values = inputLine.Split(' ');

            if(values.Length != 2 ) 
            {
                throw new FormatException("Введёное значение не в правильном формате");
            }
         
         result[0] = int.Parse(values[0]);
         result[1] = int.Parse(values[1]);

        }
        catch(FormatException ex)
        {
            Console.WriteLine($"Input format error: {ex.Message}");
            result[0] = 0;
            result[1] = 0;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Invalid format error: {ex.Message}");
            result[0] = 0;
            result[1] = 0;
        }
        catch(Exception ex) 
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            result[0] = 0;
            result[1] = 0;
        }

        return result;
    }
}