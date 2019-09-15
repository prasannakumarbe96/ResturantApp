using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant.Standard
{
    interface ISeatManage<T> where T: class
    {
        void Show(T obj);
        void Hide(T obj);
    }
}
