using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 项目
    /// </summary>
    public class SysItemInfo
    {
        public Guid ItemKey { get; set; }
        /// <summary>
        /// VALUE
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "值")]
        public string ItemValue { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "拼音码")]
        public string Spell { get; set; }
        /// <summary>
        /// CODE
        /// </summary>
        [Display(Name = "类别")]
        public Guid ItemCode { get; set; }
        /// <summary>
        /// 项目
        /// </summary>
        [Display(Name = "类别")]
        public SysItem SysItem { get; set; }
    }
}