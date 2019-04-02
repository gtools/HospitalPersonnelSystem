using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 项目
    /// </summary>
    public class SysItem
    {
        /// <summary>
        /// 项目代码
        /// </summary>
        public Guid ItemCode { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "类别")]
        public string ItemName { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "拼音码")]
        public string Spell { get; set; }
        /// <summary>
        /// 集合导航属性
        /// </summary>
        public List<SysItemInfo> SysItemInfos { get; set; }
    }
}