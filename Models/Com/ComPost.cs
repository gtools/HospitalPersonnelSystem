using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 岗位
    /// </summary>
    public class ComPost
    {
        /// <summary>
        /// 代码
        /// </summary>
        public Guid Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "名称")]
        public string Name { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        [Display(Name = "拼音码")]
        public string Spell { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        public int Sort { get; set; }
        /// <summary>
        /// 岗位类别
        /// </summary>
        [Display(Name = "岗位类别")]
        public Guid TypeCode { get; set; }
        /// <summary>
        /// 岗位类别
        /// </summary>
        [Display(Name = "岗位类别")]
        public ComPostType ComPostType { get; set; }

        /// <summary>
        /// 人员
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
    }
}