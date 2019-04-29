using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 婚姻状况
    /// </summary>
    public class ComMarriage
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
        /// 排序
        /// </summary>
        [Display(Name = "排序")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public int Sort { get; set; }
        /// <summary>
        /// 人员
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
    }
}