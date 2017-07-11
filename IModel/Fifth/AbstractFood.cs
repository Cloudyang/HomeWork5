using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace IModel.Fifth
{
    public abstract class AbstractFood
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 做菜加工流程列表
        /// </summary>
        public List<string> EventList { get; set; }
        public ConsoleColor OutColor { get; set; }

        /// <summary>
        /// 做菜
        /// </summary>
        public abstract void Cook();

        /// <summary>
        /// 品尝
        /// </summary>
        public virtual void Taste()
        {
            LogHelper.WriteLog($"开始品尝{Name}--{Specification}");
        }

        /// <summary>
        /// 点评 满分10，0-10随机评分
        /// </summary>
        public virtual int Remark()
        {
            int iScore = RandomHelper.GetRandomNumber();
            LogHelper.WriteLog($"这道菜{Name}--{Specification}--售价{Amount}  得分：{iScore}");
            return iScore;
        }

        /// <summary>
        /// 做菜、品尝、点评
        /// </summary>
        public void Show()
        {
            this.Cook();
            this.Taste();
            this.Remark();
        }
    }
}
