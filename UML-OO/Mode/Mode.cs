using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UML_OO
{
    class Mode
    {
        protected const int CLASS = 1;
        protected const int CASE = 2;
        protected const int ASS_LINE = 3;
        protected const int GEN_LINE = 4;
        protected const int COM_LINE = 5;

        protected static List<BaseClass> classlist = new List<BaseClass>();
        protected static List<BaseLine> linelist = new List<BaseLine>();
        protected List<Group> grouplist;
        protected bool choice = false;
        protected Panel panel;

        public Mode()  // 建構子
        {
        }
        public virtual void Mouse_Click(object sender, MouseEventArgs e)  // 滑鼠點擊所發生的事
        {
        }
        public virtual void Mouse_Move(object sender, MouseEventArgs e)  // 滑鼠移動時所發生的事
        {
        }
        public virtual void Mouse_Down(object sender, MouseEventArgs e)  // 滑鼠擊下所發生的事
        {
        }
        public virtual void Mouse_Up(object sender, MouseEventArgs e)  // 滑鼠放開所發生的事
        {
        }
        public virtual void Set_GroupList(List<Group> list)  // 取得 group list 資料
        {
        }
        public static void Set_Add_ClassOrCase(int Class_Or_Case, MouseEventArgs e)  // 新增一個 Class 或 Case
        {
            if (Class_Or_Case == CLASS)  // 表選到 Class
                classlist.Add(new ClassClass(e.X, e.Y));
            else if (Class_Or_Case == CASE)  // 表選到 Case
                classlist.Add(new CaseClass(e.X, e.Y));
            BaseClass.Count_Id();  // 新增一個 Class or Case 就要 ID 增加
        }
        public static void Set_Add_Line(int line)  // 新增一條 AssLine 或 GenLine 或 ComLine
        {
            if (line == ASS_LINE)
                linelist.Add(new AssLine());
            else if (line == GEN_LINE)
                linelist.Add(new GenLine());
            else if (line == COM_LINE)
                linelist.Add(new ComLine());
        }
        public static List<BaseClass> Get_class()  // 回傳 classlist
        {
            return classlist;
        }
        public static List<BaseLine> Get_line()  // 回傳 linelist
        {
            return linelist;
        }
        public int Compare_Choice(MouseEventArgs e)  // 比對為在 list 中之第幾個
        {
            for (int i = classlist.Count - 1; i >= 0; i--)  // 比對誰被選取到
                if ((e.X >= classlist[i].Get_coordinate().X && e.X <= (classlist[i].Get_coordinate().X + classlist[i].Get_size().Width))  // 先比對 x 座標
                 && (e.Y >= classlist[i].Get_coordinate().Y && e.Y <= (classlist[i].Get_coordinate().Y + classlist[i].Get_size().Height)))  // 再比對 y 座標
                    return i;
            return -1;
        }
        public void Set_Panel(Panel p)  // 取得 Form 中之 panel 之物件
        {
            panel = p;
        }
    }
}