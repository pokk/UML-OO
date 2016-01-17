using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UML_OO
{
    public partial class Form1 : Form
    {
        // 常數
        private const int SELECT = 0;
        private const int ASS_LINE = 1;
        private const int GEN_LINE = 2;
        private const int COM_LINE = 3;
        private const int CLASS = 4;
        private const int CASE = 5;

        private int group_level;
        private List<BaseBtn> btnlist;
        private List<Button> btn;
        private List<Mode> modelist;
        private List<BaseClass> baselist;
        private List<BaseLine> linelist;
        private List<Group> grouplist;

        public Form1()
        {
            InitializeComponent();
            group_level = 0;
            // 把 Form 裡的 Button 放到 list 中
            btn = new List<Button> { Btn_Sel, Btn_Ass_Line, Btn_Gen_Line, Btn_Com_Line, Btn_Class, Btn_Case };  // 存放 btn 屬性狀態
            // 把所有 Button 該做的事類別放到 list 中
            btnlist = new List<BaseBtn> { new Btn_Sel(btn), new Btn_Ass_Line(btn), new Btn_Gen_Line(btn), new Btn_Com_Line(btn), new Btn_Class(btn), new Btn_Case(btn) };
            // 把所有 Mode 該做的事類別都放到 list 中 
            modelist = new List<Mode>() { new SelectMode(), new AssLineMode(), new GenLineMode(), new ComLineMode(), new ClassMode(), new CaseMode() };
            baselist = Mode.Get_class();  // 一開始就指向 Mode 中的 List
            linelist = Mode.Get_line();  // 一開始就指向 Mode 中的 list
            grouplist = new List<Group>();  // 新增一個 group list
        }

        private void Btn_Click(object sender, EventArgs e)  // Btn 被點擊之 event 
        {
            if (sender.Equals(Btn_Sel))  // 選擇到 SELECT BUTTON
                btnlist[SELECT].Click();
            if (sender.Equals(Btn_Ass_Line))  // 選擇到 ASS LINE BUTTON
                btnlist[ASS_LINE].Click();
            if (sender.Equals(Btn_Gen_Line))  // 選擇到 GEN LINE BUTTON
                btnlist[GEN_LINE].Click();
            if (sender.Equals(Btn_Com_Line))  // 選擇到 COM LINE BUTTON
                btnlist[COM_LINE].Click();
            if (sender.Equals(Btn_Class))  // 選擇 CLASS BUTTON
                btnlist[CLASS].Click();
            if (sender.Equals(Btn_Case))  // 選擇到 CASE BUTTON
                btnlist[CASE].Click();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)  // 重畫 Panel
        {
            for (int i = 0; i < linelist.Count; i++)
            {
                linelist[i].Update();  // 更新線段
                linelist[i].Draw_line(panel);
            }
            for (int i = 0; i < baselist.Count; i++)  // 圖層重畫
            {
                baselist[i].Draw(panel);  // 畫出
                if (baselist[i].Get_IsChoice())  // 是否被選取中
                    baselist[i].Choice(panel);
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)  // Panel 被點擊之 event
        {
            if (BaseBtn.Get_Mode() == SELECT)
                modelist[BaseBtn.Get_Mode()].Set_GroupList(grouplist);
            modelist[BaseBtn.Get_Mode()].Mouse_Click(sender, e);
            panel.Refresh();
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)  // 滑鼠在 Panel 移動之 event
        {
            modelist[BaseBtn.Get_Mode()].Set_Panel(panel);
            modelist[BaseBtn.Get_Mode()].Mouse_Move(sender, e);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)  // 滑鼠在 Panel 擊下之 event
        {
            modelist[BaseBtn.Get_Mode()].Mouse_Down(sender, e);
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)  // 滑鼠在 Panel 放開之 evnet
        {
            modelist[BaseBtn.Get_Mode()].Mouse_Up(sender, e);
            for (int i = 0; i < baselist.Count; i++)  // 使全部物件都不能移動
                baselist[i].Set_IsMove(false);
            panel.Refresh();
        }

        private void Group_Click(object sender, EventArgs e)  // 滑鼠按下 Group 下會做的事
        {
            group_level++;  // 設定group level
            for (int i = 0; i < baselist.Count; i++)
                if (baselist[i].Get_IsChoice())
                    baselist[i].Push_group(group_level);
        }

        private void Ungroup_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < baselist.Count; i++)
                if (baselist[i].Get_IsChoice())
                    baselist[i].Pop_group();
        }

        private void Rename(object sender, EventArgs e)  // 改物件名稱
        {
            Form2 myForm = new Form2();
            myForm.ShowDialog(this);
            for (int i = 0; i < baselist.Count; i++)
                if (baselist[i].Get_IsChoice())
                    baselist[i].Set_name(myForm.Get_myName());
            panel.Refresh();
        }
    }
}
