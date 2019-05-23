using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 合同
    /// </summary>
    public class SysContract
    {
        /// <summary>
        /// 代码
        /// </summary>
        public Guid Code { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [Display(Name = "工号")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public string EmpCode { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [Display(Name = "工号")]
        public SysEmp SysEmp { get; set; }
        /// <summary>
        /// 年限
        /// </summary>
        [Display(Name = "合同期限")]
        public int YearLimit { get; set; }
        /// <summary>
        /// 劳动合同终止时间
        /// </summary>
        [Display(Name = "劳动合同终止时间")]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 合同编号
        /// </summary>
        [Display(Name = "合同编号")]
        public string SN { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        public string CreateEmp { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
    }
}