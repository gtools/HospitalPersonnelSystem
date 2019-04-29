using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 性别
    /// </summary>
    public class ComGender
    {
        /// <summary>
        /// 代码
        /// </summary>
        [Display(Name = "代码")]
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
        /// 人员列表
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
    }
}