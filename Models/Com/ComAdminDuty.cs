using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 行政职务
    /// </summary>
    public class ComAdminDuty
    {
        /// <summary>
        /// 代码
        /// </summary>
        public Guid Code { get; set; }
        private string name;
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public string Name
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
        /// 序号
        /// </summary>
        [Display(Name = "排序")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public int Sort { get; set; }
        /// <summary>
        /// 人员列表
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
    }
}