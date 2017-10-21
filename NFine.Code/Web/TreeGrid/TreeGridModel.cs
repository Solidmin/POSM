/*******************************************************************************
 * Copyright © 2017 Mudita.Framework 版权所有
 * Author: Mudita
 * Description: POSM
 * Website：
*********************************************************************************/

namespace NFine.Code
{
    public class TreeGridModel
    {
        public string id { get; set; }
        public string parentId { get; set; }
        public string text { get; set; }
        public bool isLeaf { get; set; }
        public bool expanded { get; set; }
        public bool loaded { get; set; }
        public string entityJson { get; set; }
    }
}
