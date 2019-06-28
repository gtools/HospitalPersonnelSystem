using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 学历
    /// </summary>
    public class SysEducation
    {
        /// <summary>
        /// 工号
        /// </summary>
        [Display(Name = "工号")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        [Remote(action: "VerifyEmpCode", controller: "SysEducation")]
        public string EmpCode { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [Display(Name = "工号")]
        public SysEmp SysEmp { get; set; }
        /// <summary>
        /// 学历(最高)
        /// </summary>
        [Display(Name = "最高学历")]
        public string MaxEducation { get; set; }
        /// <summary>
        /// 学制(最高)
        /// </summary>
        [Display(Name = "学制")]
        public int? MaxSys { get; set; }
        /// <summary>
        /// 方式(最高)
        /// </summary>
        [Display(Name = "方式")]
        public string MaxForm { get; set; }
        /// <summary>
        /// 所学专业(最高)
        /// </summary>
        [Display(Name = "所学专业")]
        public string MaxSubject { get; set; }
        /// <summary>
        /// 毕业时间(最高)
        /// </summary>
        [Display(Name = "毕业时间")]
        public DateTime? MaxDate { get; set; }
        /// <summary>
        /// 毕业院校(最高)
        /// </summary>
        [Display(Name = "毕业院校")]
        public string MaxSchool { get; set; }
        /// <summary>
        /// 学历(第一)
        /// </summary>
        [Display(Name = "第一学历")]
        public string FirstEducation { get; set; }
        /// <summary>
        /// 学制(第一)
        /// </summary>
        [Display(Name = "学制")]
        public int? FirstSys { get; set; }
        /// <summary>
        /// 方式(第一)
        /// </summary>
        [Display(Name = "方式")]
        public string FirstForm { get; set; }
        /// <summary>
        /// 所学专业(第一)
        /// </summary>
        [Display(Name = "所学专业")]
        public string FirstSubject { get; set; }
        /// <summary>
        /// 毕业时间(第一)
        /// </summary>
        [Display(Name = "毕业时间")]
        public DateTime? FirstDate { get; set; }
        /// <summary>
        /// 毕业院校(第一)
        /// </summary>
        [Display(Name = "毕业院校")]
        public string FirstSchool { get; set; }
        /// <summary>
        /// 学历(第二)
        /// </summary>
        [Display(Name = "第二学历")]
        public string SecondEducation { get; set; }
        /// <summary>
        /// 学制(第二)
        /// </summary>
        [Display(Name = "学制")]
        public int? SecondSys { get; set; }
        /// <summary>
        /// 方式(第二)
        /// </summary>
        [Display(Name = "方式")]
        public string SecondForm { get; set; }
        /// <summary>
        /// 所学专业(第二)
        /// </summary>
        [Display(Name = "所学专业")]
        public string SecondSubject { get; set; }
        /// <summary>
        /// 毕业时间(第二)
        /// </summary>
        [Display(Name = "毕业时间")]
        public DateTime? SecondDate { get; set; }
        /// <summary>
        /// 毕业院校(第二)
        /// </summary>
        [Display(Name = "毕业院校")]
        public string SecondSchool { get; set; }
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