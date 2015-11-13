using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AutoGetClassInfo
{
    public partial class Form1 : Form
    {
        #region [  成员变量  ]

        #endregion

        #region [  私有方法  ]
        /// <summary>
        /// 根据传入的对象获取信息
        /// </summary>
        private void GetClassInfo(Student stuObj)
        {
            Type t = stuObj.GetType();

            Type t2 = stuObj.GetType();

            PropertyInfo[] pInfo = t.GetProperties();
            foreach (var item in pInfo)
            {
                string currentName = item.Name;
                object obj = item.GetValue(stuObj, null);
                t2.GetProperty(currentName).SetValue(2,obj,null);
            }
        }
        #endregion

        #region [  成员方法  ]
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student stuObj = new Student()
            {
                Student_ID = 1,
                Student_Name = "WD",
                Student_Sex="N"
            };
            //ceshi 
            GetClassInfo(stuObj);
        }
        #endregion
    }
}
