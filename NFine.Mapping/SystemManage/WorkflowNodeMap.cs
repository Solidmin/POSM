/*******************************************************************************
 * Copyright © 2017 Mudita.Framework 版权所有
 * Author: Mudita
 * Description: POSM
 * Website：
*********************************************************************************/
using NFine.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace NFine.Mapping.SystemManage
{
    public class WorkflowNodeMap : EntityTypeConfiguration<WorkflowNodeEntity>
    {
        public WorkflowNodeMap()
        {
            this.ToTable("Sys_WorkflowNode");
            this.HasKey(t => t.F_Id);
        }
    }
}
