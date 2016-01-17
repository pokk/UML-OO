using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace UML_OO
{
    class Shape
    {
        public Shape()  // 建構子
        {
        }
        ~Shape()  // 解構子
        {
        }
        public virtual void Draw(Panel panel)  // 給子物件實作 畫出圖形
        {
        }
    }
}
