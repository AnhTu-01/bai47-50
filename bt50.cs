using System;

class Program
{
    static void Main()
    {
        // Khai báo 1 biến kiểu dynamic là min_value
        dynamic min_value;

        // Mảng số nguyên 4 byte
        int[] intArray = { 3, 1, 4, 1, 5, 9 };
        min_value = FindMin(intArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng số nguyên 4 byte: " + min_value.ToString());

        // Mảng số nguyên không dấu 4 byte
        uint[] uintArray = { 3u, 1u, 4u, 1u, 5u, 9u };
        min_value = FindMin(uintArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng số nguyên không dấu 4 byte: " + min_value.ToString());

        // Mảng số thực 4 byte
        float[] floatArray = { 3.1f, 1.4f, 1.1f, 5.9f };
        min_value = FindMin(floatArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng số thực 4 byte: " + min_value.ToString());

        // Mảng số thực 8 byte
        double[] doubleArray = { 3.1, 1.4, 1.1, 5.9 };
        min_value = FindMin(doubleArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng số thực 8 byte: " + min_value.ToString());
    }

    // Hàm static generic để tìm giá trị nhỏ nhất trong mảng
    static T FindMin<T>(T[] array) where T : IComparable<T>
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
/* có thể thay thế: min_value = FindMin<int>(intArray); bằng min_value = FindMin(intArray); và min_value = FindMin<double>(doubleArray); bằng min_value = FindMin(doubleArray); */
/* ác dụng của việc khai báo biến dynamic min_value Động thời gian chạy: Biến dynamic cho phép bạn gán bất kỳ kiểu dữ liệu nào cho nó tại thời gian chạy. Trình biên dịch sẽ không kiểm tra kiểu dữ liệu của biến dynamic tại thời gian biên dịch, điều này giúp bạn linh hoạt hơn khi làm việc với các kiểu dữ liệu không xác định trước.
Bỏ qua kiểm tra kiểu tĩnh: Khi bạn sử dụng dynamic, trình biên dịch sẽ bỏ qua kiểm tra kiểu tĩnh trên các thao tác với biến này. Điều này có nghĩa là trình biên dịch sẽ không báo lỗi ngay cả khi bạn gọi các phương thức hoặc truy cập các thuộc tính không tồn tại trên biến dynamic. Tuy nhiên, nếu các thao tác này không hợp lệ, lỗi sẽ xảy ra tại thời gian chạy.
Dễ dàng sử dụng với các phương thức generic: Biến dynamic rất hữu ích khi làm việc với các phương thức generic mà kiểu trả về của chúng có thể khác nhau và bạn không muốn khai báo trước kiểu cụ thể. Điều này giúp đơn giản hóa mã và làm cho nó linh hoạt hơn. */