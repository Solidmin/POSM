/*******************************************************************************
 * Copyright © 2017 Mudita.Framework 版权所有
 * Author: Mudita
 * Description: POSM
 * Website：
*********************************************************************************/
using NFine.Code;
using NFine.Data;
using NFine.Domain.Entity.SystemManage;
using NFine.Domain.IRepository.SystemManage;
using NFine.Repository.SystemManage;

namespace NFine.Repository.SystemManage
{
    public class WorkflowRepository : RepositoryBase<WorkflowEntity>, IWorkflowRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<UserEntity>(t => t.F_Id == keyValue);
                db.Delete<UserLogOnEntity>(t => t.F_UserId == keyValue);
                db.Commit();
            }
        }

        public void SubmitForm(WorkflowEntity workflowrEntity, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(workflowrEntity);
                }
                else
                {
                    //TODOlist
                    workflowrEntity.F_WorkflowName = keyValue;
                    db.Insert(workflowrEntity);
                   
                }
                db.Commit();
            }
        }

    }
}
