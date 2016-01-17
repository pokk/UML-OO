using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UML_OO
{
    class CaseMode : Mode
    {
        public CaseMode()  // 建構子
        {
        }
        public override void Mouse_Click(object sender, MouseEventArgs e)
        {
            Set_Add_ClassOrCase(CASE, e);
            Console.WriteLine("case ID : " + classlist[classlist.Count - 1].Get_MyId());
        } 
    }
}
