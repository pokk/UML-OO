using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UML_OO
{
    class ComLine : BaseLine
    {
        public ComLine()
        {

        }
        public override void Draw_line(Panel panel)
        {
            Pen myPen = new Pen(Color.Black, 2);

            GraphicsPath hPath = new GraphicsPath();
            hPath.AddLine(new Point(5, -5), new Point(0, -10));
            hPath.AddLine(new Point(5, -5), new Point(0, 0));
            hPath.AddLine(new Point(-5, -5), new Point(0, 0));
            hPath.AddLine(new Point(-5, -5), new Point(0, -10));
            CustomLineCap myNewArrow = new CustomLineCap(null, hPath);
            myNewArrow.SetStrokeCaps(LineCap.Round, LineCap.Round);
            myPen.StartCap = LineCap.Flat;
            myPen.CustomEndCap = myNewArrow;
            panel.CreateGraphics().DrawLine(myPen, Start, End);

            myPen.Dispose();
        }
    }
}
