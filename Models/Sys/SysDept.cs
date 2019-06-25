using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

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
        [Remote(action: "VerifyDeptCode", controller: "SysDept")]//验证
        [Display(Name = "科室代码")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public string DeptCode { get; set; }
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

        public SysDept(string code, int sort, string name, string spell)
        {
            DeptCode = code;
            Sort = sort;
            this.name = name;
            Spell = spell;
        }

        public SysDept() { }
    }
}