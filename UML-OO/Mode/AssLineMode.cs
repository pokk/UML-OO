using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML_OO
{
    class AssLineMode : Mode
    {
        public AssLineMode()  // 建構子
        {
        }
        public override void Mouse_Down(object sender, System.Windows.Forms.MouseEventArgs e)  // 滑鼠擊下所產生的事件
        {
            if (Compare_Choice(e) >= 0)
            {
                Set_Add_Line(ASS_LINE);
                linelist[linelist.Count - 1].Set_head_obj(classlist[Compare_Choice(e)]);  // 設定頭的 class 物件給 line
            }
        }
        public override void Mouse_Up(object sender, System.Windows.Forms.MouseEventArgs e)  // 滑鼠放開所產生的事件
        {
            if (Compare_Choice(e) >= 0)
            {
                linelist[linelist.Count - 1].Set_tail_obj(classlist[Compare_Choice(e)]);  // 設定尾的 class 物件給 line
                linelist[linelist.Count - 1].Update();
            }
        }
    }
}
