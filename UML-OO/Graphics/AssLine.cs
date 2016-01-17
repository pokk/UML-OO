using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UML_OO
{
    class AssLine : BaseLine
    {
        public AssLine()  // 建構子
        {

        }
        public override void Draw_line(Panel panel)
        {
            Pen myPen = new Pen(Color.Black, 2);
            panel.CreateGraphics().DrawLine(myPen, Start, End);
            myPen.Dispose();
        }
    }
}
