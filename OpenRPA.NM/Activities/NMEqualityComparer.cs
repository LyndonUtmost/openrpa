﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRPA.NM.Activities
{
    public class NMEqualityComparer : IEqualityComparer<NMElement>
    {
        public bool Equals(NMElement element1, NMElement element2)
        {
            if (element2 == null && element1 == null)
                return true;
            else if (element1 == null || element2 == null)
                return false;
            if (!string.IsNullOrEmpty(element1.xpath) && !string.IsNullOrEmpty(element2.xpath))
            {
                if (element1.xpath != element2.xpath) return false;
            }
            if (!string.IsNullOrEmpty(element1.id) && !string.IsNullOrEmpty(element2.id))
            {
                if (element1.id != element2.id) return false;
            }
            if (!string.IsNullOrEmpty(element1.cssselector) && !string.IsNullOrEmpty(element2.cssselector))
            {
                if (element1.cssselector != element2.cssselector) return false;
            }
            if (!string.IsNullOrEmpty(element1.classname) && !string.IsNullOrEmpty(element2.classname))
            {
                if (element1.cssselector != element2.cssselector) return false;
            }
            if (!string.IsNullOrEmpty(element1.id) && !string.IsNullOrEmpty(element2.id))
            {
                if (element1.cssselector != element2.cssselector) return false;
            }
            if (element1.zn_id > 0 && element2.zn_id > 0)
            {
                if (element1.zn_id != element2.zn_id) return false;
            }
            return true;
            // return (GetHashCode(element1) == GetHashCode(element2));
        }
        public int GetHashCode(NMElement element)
        {
            return element.GetHashCode();
        }
    }
}
