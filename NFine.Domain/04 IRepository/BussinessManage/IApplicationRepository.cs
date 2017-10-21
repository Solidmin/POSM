/*******************************************************************************
 * Copyright © 2017 Mudita.Framework 版权所有
 * Author: Mudita
 * Description: POSM
 * Website：
*********************************************************************************/
using NFine.Data;
using NFine.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace NFine.Domain.IRepository.BussinessManage
{
    public interface IApplicationRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}
