using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mang1Chieu
            Console.OutputEncoding = Encoding.UTF8;

            //VD1
            //string[] HoTenSinhVien = new string[5];
            //for(int i = 0; i < HoTenSinhVien.Length; i++ )
            //{
            //    Console.Write("Nhập tên sinh viên vào trong mảng: ");
            //    HoTenSinhVien[i] = Console.ReadLine();
            //}
            //Console.WriteLine();

            //for (int i = 0; i < HoTenSinhVien.Length; i++)
            //{
            //    Console.WriteLine("Tên các sinh viên là: {0}", HoTenSinhVien[i]);
            //}

            //VD2
            //int[] a = new int[100];
            //int i, n, sum = 0;

            //Console.Write("Nhập số phần tử cần lưu trữ trong mảng: ");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Nhập {0} phần tử vào trong mảng ", n);
            //for(i = 0; i < n; i++)
            //{
            //    Console.Write("Phần tử {0} là: ", i);
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for(i = 0; i < n; i++)
            //{
            //    sum = sum + a[i];
            //}

            //Console.WriteLine("Tổng các phần tử trong mảng là: {0}", sum);

            //Console.ReadKey();

            #endregion

            #region Mang2Chieu

            //VD1
            //{
            //    int[,] IntArray =
            //                        {
            //                        {1, 2, 3},
            //                        {4, 5, 6},
            //                        {7, 8, 9}
            //                    };

            //    for (int i = 0; i < IntArray.GetLength(0); i++) //GetLength(0): lấy ra độ dài số lượng phần tử của chiều thứ nhất
            //    {
            //        for (int j = 0; j < IntArray.GetLength(1); j++) //GetLength(1): lấy ra độ dài số lượng phần tử của chiều thứ hai
            //        {
            //            Console.Write("{0, 5}", IntArray[i, j]); //{0, 5} là khoảng cách khi in ra
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //VD2
            //Console.Write("Nhập số dòng của mảng: ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("Nhập số cột của mảng: ");
            //int n = int.Parse(Console.ReadLine());

            ////Tạo mảng
            //int [,] IntArray = new int[m, n];

            ////Nhập phần tử vào mảng
            //for(int i = 0; i < IntArray.GetLength(0); i++)
            //{
            //    for(int j = 0; j < IntArray.GetLength(1); j++)
            //    {
            //        Console.Write("Mời nhập phần tử IntArray[{0}, {1}] = ", i, j);
            //        IntArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////In mảng
            //int sum = 0;

            //Console.WriteLine("\nMảng vừa nhập là: ");
            //for (int i = 0; i < IntArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < IntArray.GetLength(1); j++)
            //    {
            //        Console.Write(IntArray[i, j] + " ");
            //        sum += IntArray[i, j];
            //    }
            //    // Sau khi in xong mỗi dòng thực hiện xuống dòng rồi mới in tiếp
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\nTổng các giá trị trong mảng là: " + sum);

            Console.ReadKey();
            #endregion
        }
    }
}

//Khái niệm:
/* Mảng 1 chiều
 * - Mảng là tập hợp các đối tượng cùng kiểu dữ liệu
 * - Mỗi đối tượng trong mảng là tập hợp một phần tử
 * - Các phần tử phân biệt với nhau bằng chỉ số phần tử
 * - Dùng chung 1 tên và được truy xuất thông qua chỉ số phần tử
 * - Một mảng cần giới hạn số phần tử mà mảng có thể chứa
 * - Phải cấp phát vùng nhớ mới có thể sử dụng mảng
 * - Vị trí ô nhớ của các phần tử trong mảng được cấp phát liền kề nhau
 * Tại sao phải sử dụng mảng?
 * - Gom nhóm các đối tượng có chung tính chất, giúp code gọn hơn
 * - Dễ thao tác, quản lý, nâng cấp và sửa chữa
 * - Dễ dàng áp dụng các cấu trúc lặp để quản lý dữ liệu
 * Cú pháp khai báo, khởi tạo:
 * Kiểu dữ liệu[] tên mảng = new Kiểu dữ liệu[số lượng mảng];
 * - VD: string ArrayA = new string[10];
 */

/* Mảng 2 chiều
 * Mảng 2 chiều gồm các phần tử có m dòng và n cột
 * Cú pháp khai báo, khởi tạo:
 *  Kiểu dữ liệu [,] tên mảng = new Kiểu dữ liệu [m, n];
 */