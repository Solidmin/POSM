/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using NFine.Code;
using NFine.Domain.Entity.SystemManage;
using NFine.Domain.IRepository.SystemManage;
using NFine.Repository.SystemManage;
using System;
using System.Collections.Generic;

namespace NFine.Application.SystemManage
{
    public class WorkflowApp
    {
        private IWorkflowRepository service = new WorkflowRepository();
        

        public List<WorkflowEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<WorkflowEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_WorkflowName.Contains(keyword));
                expression = expression.Or(t => t.F_WorkflowType.Contains(keyword));
            }
            
            return service.FindList(expression, pagination);
        }
        public WorkflowEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.DeleteForm(keyValue);
        }
        public void SubmitForm(WorkflowEntity workEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                workEntity.Modify(keyValue);
            }
            else
            {
                workEntity.Create();
            }
            service.SubmitForm(workEntity,keyValue);
        }
        public void UpdateForm(WorkflowEntity workEntity)
        {
            service.Update(workEntity);
        }
       
        
    }
}
