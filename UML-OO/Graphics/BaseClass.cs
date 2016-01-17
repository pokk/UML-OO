using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace UML_OO
{
    class BaseClass : Shape
    {
        // 中心座標 x y
        protected int x;
        protected int y;
        // 長及寬
        protected Size size;
        // 小點 長及寬
        protected Size choice_size;
        // 四點座標 point  0:top 1:bottom 2:left 3:right
        protected Point[] Connect;
        // 物件四點座標 point  0:左上 1:右上 2:右下 3:左下
        protected Point[] Vertex;
        // 畫圖座標 point
        protected Point coordinate;
        // 矩形
        protected Rectangle rect;
        // 可否移動
        protected bool IsMove;
        // 是否被選中
        protected bool choice_flag;
        // 設定 id
        protected static int id = 0;
        // case id
        protected string myID;
        // 設定每個物件本身的 id
        protected int nameID;
        // 被 group
        protected Stack<int> group;

        public BaseClass()  // 建構子
        {
            nameID = 0;
            IsMove = false;
            choice_size = new Size(6, 6);
            Connect = new Point[4];
            Vertex = new Point[4]; 
            group = new Stack<int>();
            group.Push(0);
            choice_flag = false;
            for (int i = 0; i < 4; i++)
                Connect[i] = new Point();
        }
        public void Set_MyId(int id)
        {
            nameID = id;
        }
        public void Set_name(String name)  // 設定物件名稱
        {
            myID = name;
        }
        public void Set_Vertex()  // 設定物件四點座標
        {
            Vertex[0] = Vertex[1] = Connect[0];
            Vertex[2] = Vertex[3] = Connect[1];
            Vertex[0].Offset(-(size.Width / 2) + 3, 3);
            Vertex[1].Offset((size.Width / 2) + 3, 3);
            Vertex[2].Offset(-(size.Width / 2) + 3, 3);
            Vertex[3].Offset((size.Width / 2) + 3, 3);
        }
        public void Set_IsChoice(bool choice)  // 設定是否被選中
        {
            choice_flag = choice;
        }
        public void Set_IsMove(bool Move)  // 設定是否可以移動
        {
            IsMove = Move;
        }
        public virtual void Draw_Polygon(Panel panel)  // 給子物件實作 畫出圖形
        { }
        public void Update_coordinate(Point point)  // 重新設定位置
        {
            // 改變中心座標
            this.x = point.X;
            this.y = point.Y;
            // 改變圖左上角之座標
            coordinate.X = this.x - (size.Width / 2);
            coordinate.Y = this.y - (size.Height / 2);
            // 改變四個角的座標
            for (int i = 0; i < 4; i++)
                Connect[i] = point;
            Connect[0].Offset(-3, -(size.Height / 2) - 3);  // 上
            Connect[1].Offset(-3, (size.Height / 2) - 3);  // 下
            Connect[2].Offset(-(size.Width / 2) - 3, -3);  // 左
            Connect[3].Offset((size.Width / 2) - 3, -3);  // 右
            Set_Vertex();  // 更新四個點
        }
        public void Choice(Panel panel)  // 被選擇之後顯示四個點
        {
            Brush myBrush = new SolidBrush(Color.Red);
            for (int i = 0; i < 4; i++)  // 畫出四個點
                panel.CreateGraphics().FillRectangle(myBrush, new Rectangle(Connect[i], choice_size));
            myBrush.Dispose();
        }
        public static void Count_Id()  // 增加 id
        {
            id++;
        }
        public int Get_x()  // 取得最初點擊之 x 座標
        {
            return x;
        }
        public int Get_y()  // 取得最初點擊之 y 座標
        {
            return y;
        }
        public bool Get_IsChoice()  // 取得是否被選中
        {
            return choice_flag;
        }
        public bool Get_IsMove()  // 取得是否可以移動
        {
            return IsMove;
        }
        public Size Get_size()  // 回傳寬及高
        {
            return size;
        }
        public Point Get_coordinate()  // 取得畫圖之 x y 座標
        {
            return coordinate;
        }
        public Rectangle Get_rect()  // 取得矩形
        {
            return rect;
        }
        public Point[] Get_connect()
        {
            return Connect;
        }
        public Point[] Get_vertex()
        {
            return Vertex;
        }
        public String Get_name()
        {
            return myID;
        }
        public int Get_MyId()
        {
            return nameID;
        }
        
        public void Push_group(int group)  // 丟 group 層進去
        {
            this.group.Push(group);
        }
        public void Pop_group()
        {
            group.Pop();
        }
        public int Get_group()
        {
            return group.Peek();
        }
    }
}
