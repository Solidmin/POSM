/*******************************************************************************
 * Copyright © 2017 Mudita.Framework 版权所有
 * Author: Mudita
 * Description: POSM
 * Website：
*********************************************************************************/
using System;

namespace NFine.Domain.Entity.SystemManage
{
    public class WorkflowProcessEntity : IEntity<WorkflowProcessEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string F_Wid { get; set; }
        public int? F_NodeType { get; set; }
        public string F_Condition { get; set; }

        public string F_Prevnode { get; set; }
        public string F_Nextnode { get; set; }
        public string F_HandlersType { get; set; }
        public string F_Handlers { get; set; }
        public int? F_SortCode { get; set; }
        public bool? F_DeleteMark { get; set; }
        public bool? F_EnabledMark { get; set; }
        public string F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }
    }
}
