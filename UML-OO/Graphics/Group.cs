using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML_OO
{
    class Group : Shape
    {
        private List<BaseClass> group;  // 被 group 之 list

        public Group()  // 建構子
        {
            group = new List<BaseClass>();
        }
        public void Add_Class(BaseClass ClassOrCase)  // 增加 class 或 case 到 group list 裡面
        {
            group.Add(ClassOrCase);
        }
        public List<BaseClass> Get_Group()  // 取得 group list
        {
            return group;
        }
    }
}
