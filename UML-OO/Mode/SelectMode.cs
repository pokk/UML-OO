using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace UML_OO
{
    class SelectMode : Mode
    {
        private Point group;
        Group g;

        public SelectMode()  // 建構子
        {
        }
        public override void Mouse_Click(object sender, System.Windows.Forms.MouseEventArgs e)  // 滑鼠點擊所發生之事件
        {
            BaseClass temp_base;  // 存放被選取到之物件
            for (int i = classlist.Count - 1; i >= 0; i--)  // 全部清空
                classlist[i].Set_IsChoice(false);
            for (int i = classlist.Count - 1; i >= 0; i--)  // 比對誰被選取到
            {
                if ((e.X >= classlist[i].Get_coordinate().X && e.X <= (classlist[i].Get_coordinate().X + classlist[i].Get_size().Width))  // 先比對 x 座標
                 && (e.Y >= classlist[i].Get_coordinate().Y && e.Y <= (classlist[i].Get_coordinate().Y + classlist[i].Get_size().Height)))  // 再比對 y 座標
                {
                    classlist[i].Set_IsMove(true);  // 被點選並且可以移動
                    classlist[i].Set_IsChoice(true);  // 被選取到了
                    // 把選取到的放到 List 最後面
                    temp_base = classlist[i];
                    classlist.RemoveAt(i);
                    classlist.Add(temp_base);
                    break;
                }
                classlist[i].Set_IsMove(false);  // 其他都為不可移動
            }

            int level = classlist[classlist.Count - 1].Get_group();  // 被選取到的為 group 多少
            for (int i = 0; i < classlist.Count; i++)  // 選取與他同 group 者
                if (classlist[i].Get_group() != 0 && classlist[i].Get_group() == level)
                    classlist[i].Set_IsChoice(true);
        }
        public override void Mouse_Move(object sender, System.Windows.Forms.MouseEventArgs e)  // 滑鼠移動所發生之事件
        {
            int dx, dy;  // offset
            if (classlist.Count != 0 && classlist[classlist.Count - 1].Get_IsMove())
            {
                dx = e.X - classlist[classlist.Count - 1].Get_x();  // 取得 x offset
                dy = e.Y - classlist[classlist.Count - 1].Get_y();  // 取得 y offset
                classlist[classlist.Count - 1].Update_coordinate(new Point(e.X, e.Y));
                int level = classlist[classlist.Count - 1].Get_group();  // 被選取到的為 group 多少
                for (int i = 0; i < classlist.Count - 1; i++)  // 選取與他同 group 者
                    if (classlist[i].Get_group() != 0 && classlist[i].Get_group() == level)
                        classlist[i].Update_coordinate(new Point(classlist[i].Get_x() + dx, classlist[i].Get_y() + dy));  // 更新其他的 group 成員
                Console.WriteLine(e.X + " " + e.Y);
                panel.Refresh();
            }
        }
        public override void Mouse_Down(object sender, System.Windows.Forms.MouseEventArgs e)  // 滑鼠擊下所發生之事件
        {
            Point mou = new Point(e.X, e.Y);
            for (int i = classlist.Count - 1; i >= 0; i--)  // 全部清空
                classlist[i].Set_IsChoice(false);
            panel.Refresh();
            if (classlist.Count != 0)  // 判斷是否可以移動
                if ((e.X >= classlist[classlist.Count - 1].Get_coordinate().X && e.X <= (classlist[classlist.Count - 1].Get_coordinate().X + classlist[classlist.Count - 1].Get_size().Width))  // 先比對 x 座標
                 && (e.Y >= classlist[classlist.Count - 1].Get_coordinate().Y && e.Y <= (classlist[classlist.Count - 1].Get_coordinate().Y + classlist[classlist.Count - 1].Get_size().Height)))  // 再比對 y 座標
                    classlist[classlist.Count - 1].Set_IsMove(true);  // 若點選到最上層物件才可以移動
            if (Compare_Choice(e) == -1)  // 若沒有選取到物件
            {
                choice = true;
                group = mou;  // 記錄點選到的座標
            }
        }
        public override void Mouse_Up(object sender, System.Windows.Forms.MouseEventArgs e)  // 滑鼠放開所發生之事件
        {
            Point mou = new Point(e.X, e.Y);
            if (choice && group != mou)  // 做 gorup 
                Choice_Group(group, mou);
        }
        public override void Set_GroupList(List<Group> list)  // 取得 list 資料
        {
            grouplist = list;
        }
        public void Choice_Group(Point x1, Point x2)  // 選取多重物件
        {
            Point temp1 = new Point();
            Point temp2 = new Point();
            // 把點都設為 左上 及 右下
            temp1.X = Math.Min(x1.X, x2.X);
            temp1.Y = Math.Min(x1.Y, x2.Y);
            temp2.X = Math.Max(x1.X, x2.X);
            temp2.Y = Math.Max(x1.Y, x2.Y);

            for (int i = 0; i < classlist.Count; i++)  // 判斷所有物件
            {
                Point[] v_point = classlist[i].Get_vertex();
                for (int j = 0; j < 4; j++)  // 看此 物件 是否有四個頂點其中之一被選取到
                    if ((v_point[j].X >= temp1.X && temp2.X >= v_point[j].X) && (v_point[j].Y >= temp1.Y && temp2.Y >= v_point[j].Y))  // 有頂點被選取到 
                    {
                        classlist[i].Set_IsChoice(true);
                        break;
                    }
            }
        }
    }
}
