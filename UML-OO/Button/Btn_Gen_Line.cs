using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace UML_OO
{
    class Btn_Gen_Line : BaseBtn
    {
        public Btn_Gen_Line(List<Button> btn)  // 建構子
        {
            btnlist = btn;
        }
        public override void Click()  // 點擊發生的事情
        {
            Set_Mode(GEN_LINE);
            Initial_Background();
            btnlist[GEN_LINE].BackColor = Color.Black;  // SELECT BTN 設定成黑的
        }
    }
}
