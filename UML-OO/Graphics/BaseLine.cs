using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace UML_OO
{
    class BaseLine
    {
        // 線的頭及尾 座標
        protected Point Start;
        protected Point End;
        // 線的頭及尾 物件
        protected BaseClass head;
        protected BaseClass tail;

        public BaseLine()  // 建構子
        {
            Start = new Point();
            End = new Point();
            head = new BaseClass();
            tail = new BaseClass();
        }
        public virtual void Draw_line(Panel panel)  // 畫線
        {
        }
        public void Set_head_obj(BaseClass obj)  // 設定起始的物件
        {
            head = obj;
        }
        public void Set_tail_obj(BaseClass obj)  // 設定終點的物件
        {
            tail = obj;
        }
        public void Set_start(Point coordinate)  // 設定起始座標
        {
            Start = coordinate;
        }
        public void Set_end(Point coordinate)  // 設定終點座標
        {
            End = coordinate;
        }
        public void Update()  // 更新位置
        {
            Point[] temp_head = head.Get_connect();
            Point[] temp_tail = tail.Get_connect();
            double min = 99999999;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    double a = temp_head[i].X - temp_tail[j].X, b = temp_head[i].Y - temp_tail[j].Y;
                    double c = Math.Pow(a, 2.0) + Math.Pow(b, 2.0);
                    if (c <= min)
                    {
                        min = c;
                        Start = temp_head[i];
                        End = temp_tail[j];
                    }
                }
        }
        public Point Get_start()  // 取得起始座標
        {
            return Start;
        }
        public Point Get_end()  // 取得終點座標
        {
            return End;
        }
    }
}
