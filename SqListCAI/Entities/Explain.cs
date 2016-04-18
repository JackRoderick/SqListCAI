﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqListCAI.Entities
{
    public partial class Explain
    {
        public static string OrderInsExplain = 
            "在线性表的顺序存储结构中，由于逻辑上相邻的数据元素在物理位置上\n" +
            "也相邻，因此，除非插入位置i的值等于表长加1（即插入在表尾之后），\n"+
            "佛足额都必须移动元素才能反映这个逻辑关系的变化。一般情况下，在第\n"+
            "i（1<i<(n+1)）个元素之前插入一个元素时，需将第n个至第i个，共"+
            "n-i+1个元素依次向后移动一个位置。";
        public static string OrderDelExplain =
            "和顺序表插入相反，从顺序表中删除第i（1<i<n）个\n"+
            "元素时，需将从第i+1至第n个，共n-1个元素依次向后移动一个位置";

        public static string LinkedCreExplain =
            "这是一个从表尾到表头逆行建立线性表的算法（头插法）。每生成\n" +
            "一个新的结点，都插入在第一个结点之前，也即表头结点之后，因此，\n" +
            "只需要修改表头结点中的指针域的值，但在这之前，必须先将其值赋给\n" +
            "新结点的指针域";
        public static string LinkedInsExplain = 
            "算法中的参数i表示插入的位置，其合理值的范围为1至表长+1,。插入\n"+
            "时，首先需要查找插入位置，由于表头也是链表元素，因此在第i个元素\n"+
            "之前插入也就是在头结点的第i-2个之后，注意：在查找的过程中，始终\n"+
            "保持活动指针指向链表中的第j个结点，则j=0时，p应该指向头结点。"+
            "本算法约定新结点插入在第i个结点之前，则需要修改第i-1个结点中的指针\n"+
            "域的值。注意查找时循环结束的条件";
        public static string LinkedDelExplain =
            "算法中的参数i表示删除额位置，其合理值的范围为1至表长。首先需要\n" +
            "查找被删除结点所在的位置，由于表头也是链表元素，因此删除第i个\n"+
            "元素也就是删除头结点后的第i-1个，需要找到它的前驱，也就是头结点\n"+
            "之后的第i-2个位置,同时在找到第i-2个位置时，需要判断其后是否为空，\n"+
            "为空或者没有找到都表示删除位置错。在查找的过程中，活动指针始终保持指向\n" +
            "头结点，则j=0时，p应该指向头结点。从链表中删除第i个结点，则需\n" +
            "要修改第i-1个结点的指针域的值。注意，查找删除位置时的循环条件\n" +
            "同插入算法的不同处。";

    }
}
