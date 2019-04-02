using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 科室
    /// </summary>
    public class SysDept
    {
        /// <summary>
        /// 科室代码
        /// </summary>
        [Display(Name = "科室代码")]
        public string DeptCode { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        [Display(Name = "科室名称")]
        public string DeptName { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        [Display(Name = "拼音码")]
        public string Spell { get; set; }
        /// <summary>
        /// 集合导航属性，人员
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
    }
}