using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace UML_OO
{
    class Btn_Case : BaseBtn
    {
        public Btn_Case(List<Button> btn)  // 建構子
        {
            btnlist = btn;
        }
        public override void Click()  // 點擊發生的事情
        {
            Set_Mode(CASE);
            Initial_Background();
            btnlist[CASE].BackColor = Color.Black;  // SELECT BTN 設定成黑的
        }
    }
}
