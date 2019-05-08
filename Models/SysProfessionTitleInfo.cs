using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 职称评定
    /// </summary>
    public class SysProfessionTitleInfo
    {
        /// <summary>
        /// 代码
        /// </summary>
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public Guid Code { get; set; }
        private string name;
        /// <summary>
        /// 科室名称
        /// </summary>
        [Remote(action: "VerifyDeptName", controller: "SysDept")]//验证
        [Display(Name = "科室名称")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public string DeptName
        {
            get { return name; }
            set
            {
                name = value;
                Spell = GTSharp.Core.PinYinHelper.GetFirstPinyin(name);
            }
        }
        /// <summary>
        /// 拼音码
        /// </summary>
        [Display(Name = "拼音码")]
        public string Spell { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name = "排序")]
        public int Sort { get; set; }
        /// <summary>
        /// 集合导航属性，人员
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
    }
}