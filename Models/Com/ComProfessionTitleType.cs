using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 职称系类
    /// </summary>
    public class ComProfessionTitleType
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
        /// 职称
        /// </summary>
        public List<ComProfessionTitle> ComProfessionTitles { get; set; }
        /// <summary>
        /// 人员
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
    }
}