using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoGetClassInfo
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        private int student_ID;

        /// <summary>
        /// 获取或者设置一个值 学生编号
        /// </summary>
        public int Student_ID
        {
            get { return student_ID; }
            set { student_ID = value; }
        }

        private string student_Name;

        /// <summary>
        /// 获取或者设置一个值  学生姓名
        /// </summary>
        public string Student_Name
        {
            get { return student_Name; }
            set { student_Name = value; }
        }

        private string student_Sex;

        /// <summary>
        /// 获取或者设置一个值  学生性别
        /// </summary>
        public string Student_Sex
        {
            get { return student_Sex; }
            set { student_Sex = value; }
        }
    }
}
