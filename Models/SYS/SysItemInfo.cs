using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 项目
    /// </summary>
    public class SysItemInfo
    {
        /// <summary>
        /// 代码
        /// </summary>
        [Display(Name = "代码")]
        public Guid ItemKey { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "名称")]
        public string ItemValue { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        [Display(Name = "拼音码")]
        public string Spell { get; set; }
        /// <summary>
        /// 类别编码
        /// </summary>
        [Display(Name = "类别编码")]
        public Guid? TypeCode { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        [Display(Name = "类别名称")]
        public string TypeName { get; set; }
        /// <summary>
        /// 项目
        /// </summary>
        [Display(Name = "项目")]
        public Guid ItemCode { get; set; }
        /// <summary>
        /// 项目
        /// </summary>
        [Display(Name = "项目")]
        public SysItem SysItem { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [InverseProperty("Gender")]
        public List<SysEmp> GenderSysEmps { get; set; }
        
        /// <summary>
        /// 民族
        /// </summary>
        [InverseProperty("Nation")]
        public List<SysEmp> NationSysEmps { get; set; }

        /// <summary>
        /// 政治面貌
        /// </summary>
        [InverseProperty("Political")]
        public List<SysEmp> PoliticalSysEmps { get; set; }

    }
}