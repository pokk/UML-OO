using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace UML_OO
{
    class ClassClass : BaseClass
    {
        public ClassClass(int x, int y)  // 建構子 初始化
        {
            myID = "Class" + id.ToString();
            coordinate = new Point(x, y);
            size = new Size(100, 120);
            this.x = x;
            this.y = y;
            coordinate.Offset(-(size.Width / 2), -(size.Height / 2));  // 橋好 圖片置中之後的 左上角座標

            Connect[0] = new Point(x - 3, y - (size.Height / 2) - 3);  // 上面點的位置
            Connect[1] = new Point(x - 3, y + (size.Height / 2) - 3);  // 下面點的位置
            Connect[2] = new Point(x - (size.Width / 2) - 3, y - 3);  // 左邊點的位置
            Connect[3] = new Point(x + (size.Width / 2) - 3, y - 3);  // 右邊點的位置

            Set_MyId(id);
            Set_Vertex();
        }
        public override void Draw(Panel panel)  // 畫出矩形
        {
            Pen myPen = new Pen(Color.Black, 1);
            Brush myBrush = new SolidBrush(Color.LightGray);
            Rectangle[] rect = new Rectangle[3];
            StringFormat drawFormat = new StringFormat();  // 設定字形的位置
            drawFormat.Alignment = StringAlignment.Center;  // 水平置中
            drawFormat.LineAlignment = StringAlignment.Center;  // 垂直置中
            for (int i = 0; i < 3; i++)
            {
                rect[i] = new Rectangle(coordinate.X, coordinate.Y + (size.Height / 3) * i, size.Width, size.Height / 3);
                panel.CreateGraphics().FillRectangle(myBrush, rect[i]);
                panel.CreateGraphics().DrawRectangle(myPen, rect[i]);
            }
            panel.CreateGraphics().DrawString(myID, new Font("Arial", 16), new SolidBrush(Color.Black), rect[0], drawFormat);
            myPen.Dispose();
            myBrush.Dispose(); 
            base.Draw(panel);
        }
    }
}
