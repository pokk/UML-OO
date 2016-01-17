using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace UML_OO
{
    class BaseBtn
    {
        protected const int SELECT = 0;
        protected const int ASS_LINE = 1;
        protected const int GEN_LINE = 2;
        protected const int COM_LINE = 3;
        protected const int CLASS = 4;
        protected const int CASE = 5;

        // 0:select  1:assline  2:genline  3:comline  4:class  5:case
        protected List<Button> btnlist;  // From 中的所有 BTN 屬性 
        protected static int mode = 0;  // 選擇的模式

        public BaseBtn()  // 建構子
        {
        }
        ~BaseBtn()  // 解構子
        {
            btnlist = null;
        }
        public void Initial_Background()  // 初始全部之 BTN 的背景都設成白
        {
            for (int i = 0; i < btnlist.Count; i++)  // 全部 BTN 的背景都設成白的
                btnlist[i].BackColor = Color.White;
        }
        public static void Set_Mode(int m)  // 設定模式
        {
            mode = m;
        }
        public virtual void Click()  // Button 被點擊
        {
        }
        public static int Get_Mode()  // 取得模式
        {
            return mode;
        }
    }
}
