using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace UML_OO
{
    class Btn_Ass_Line : BaseBtn
    {
        public Btn_Ass_Line(List<Button> btn)  // 建構子
        {
            btnlist = btn;
        }
        public override void Click()  // 點擊發生的事情
        {
            Set_Mode(ASS_LINE);
            Initial_Background();
            btnlist[ASS_LINE].BackColor = Color.Black;  // SELECT BTN 設定成黑的
        }
    }
}
