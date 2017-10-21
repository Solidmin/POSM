/*******************************************************************************
 * Copyright © 2017 Mudita.Framework 版权所有
 * Author: Mudita
 * Description: POSM
 * Website：
*********************************************************************************/
using System;

namespace NFine.Domain
{
    public interface IModificationAudited
    {
        string F_Id { get; set; }
        string F_LastModifyUserId { get; set; }
        DateTime? F_LastModifyTime { get; set; }
    }
}