using System;
using System.Collections.Generic;

namespace WebCoreMVC.NET.Models
{
    public class ContainerForListAndId<T>
    {
        public IEnumerable<T> accessList {get; set;}
        public int id { get; set; }

        public ContainerForListAndId()
        {
        }

        public ContainerForListAndId(IEnumerable<T> accessList, int id)
        {
            this.accessList = accessList;
            this.id = id;
        }
    }
}