using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    //先引入包，在实现接口
    class Sale : IEnumerable, IEnumerator
    {
        //Current取得是当前数组的下标，当前走到什么位置
        int position = -1;
        private Item[] item;
        public object Current
        {
            get{
                //让他是初始位置
                return item[position];
            }
        }

        //返回类型IEnumerator
        public IEnumerator GetEnumerator()
        {
            //需要强制类型转换
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            position++;
            return (position <item.Length);
        }

        public void Reset()
        {
            position = -1;

        }

        //私有类进行初始化，调用构造函数
        //类数组
        public Sale(Item[] itemArr)
        {
            item = new Item[3];
            for(int i = 0; i < itemArr.Length; i++)
            {
                item[i] = itemArr[i];
            }
        }
    }
}
