using System;

class Program
{
    static void Main()
    {
        // Khai báo 1 biến kiểu dynamic là min_value
        dynamic min_value;

        // Mảng số nguyên 4 byte
        int[] intArray = { 3, 1, 4, 1, 5, 9 };
        min_value = FindMinValue(intArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng số nguyên 4 byte: " + min_value.ToString());

        // Mảng số nguyên không dấu 4 byte
        uint[] uintArray = { 3u, 1u, 4u, 1u, 5u, 9u };
        min_value = FindMinValue(uintArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng số nguyên không dấu 4 byte: " + min_value.ToString());

        // Mảng số thực 4 byte
        float[] floatArray = { 3.1f, 1.4f, 1.1f, 5.9f };
        min_value = FindMinValue(floatArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng số thực 4 byte: " + min_value.ToString());

        // Mảng số thực 8 byte
        double[] doubleArray = { 3.1, 1.4, 1.1, 5.9 };
        min_value = FindMinValue(doubleArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng số thực 8 byte: " + min_value.ToString());
    }

    // Hàm static generic để tìm giá trị nhỏ nhất trong mảng
    static T FindMinValue<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Mảng không được rỗng hoặc null.");
        }

        T minValue = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(minValue) < 0)
            {
                minValue = item;
            }
        }
        return minValue;
    }
}