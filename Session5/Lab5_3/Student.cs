﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    //Lớp sinh viên
    internal class Student
    {
        //Khai báo mảng tên
        string[] names;
        //khai báo mảng 2 chiều điểm
        double[,] marks;
        //phương thức khởi tạo
        public Student (int n, int m)
        {
            names = new string[n];
            marks = new double[n,m];
        }
        //chỉ mục đơn
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
        //chỉ mục kép
        public double this[int i, int j]
        {
            get { return marks[i, j]; }
            set { marks[i, j] = value; }
        }
    }
}
