using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace UML_OO
{
    class ClassMode : Mode
    {
        public ClassMode()  // 建構子
        {
        }
        public override void Mouse_Click(object sender, MouseEventArgs e)  // 點擊事件
        {
            Set_Add_ClassOrCase(CLASS, e);
            Console.WriteLine("class ID : " + classlist[classlist.Count - 1].Get_MyId());
        }
    }
}
