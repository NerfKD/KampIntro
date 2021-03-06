﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        //Constructor - yapıcı metotlar
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

        //eleman sayısını dönmek için
        public int Length
        {
            get { return items.Length; }
        }
        //elamanları listelemek için
        public T[] Items
        { 
            get { return items; }
        }

    }
}
