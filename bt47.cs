using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Khởi tạo một Dictionary mới
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Thêm các phần tử vào Dictionary
        myDictionary.Add("Apple", 1);
        myDictionary.Add("Banana", 2);
        myDictionary.Add("Cherry", 3);

        // In ra các phần tử trong Dictionary
        foreach(KeyValuePair<string, int> kvp in myDictionary)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }
}
//Dictionary<string, int> được sử dụng để tạo một từ điển với các khóa là kiểu string và các giá trị là kiểu int.
/*Key (Khóa): Các khóa trong từ điển này là các chuỗi (string). Trong đoạn mã của bạn, các khóa là "Apple", "Banana", và "Cherry".
Value (Giá trị): Các giá trị trong từ điển này là các số nguyên (int). Trong đoạn mã của bạn, các giá trị tương ứng là 1, 2, và 3.*/
//Trong đoạn mã trên, khóa là trường string và các giá trị cụ thể trong từ điển là "Apple", "Banana", và "Cherry".