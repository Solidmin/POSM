/*******************************************************************************
 * Copyright © 2017 Mudita.Framework 版权所有
 * Author: Mudita
 * Description: POSM
 * Website：
*********************************************************************************/
using System;

namespace NFine.Domain.Entity.SystemManage
{
    public class WorkflowExampleEntity : IEntity<WorkflowExampleEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        /// <summary>
        /// 实例ID
        /// </summary>
        public string F_Eid { get; set; }

        /// <summary>
        /// 当前运行到节点ID
        /// </summary>
        public string F_Curnodeid { get; set; }
        /// <summary>
        /// 操作者
        /// </summary>
        public string F_Uid { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? F_Handtime { get; set; }
        
       
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
