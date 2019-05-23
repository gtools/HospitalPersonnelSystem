using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 职称级别
    /// </summary>
    public class ComProfessionTitleLevel
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
        /// 职称
        /// </summary>
        public List<ComProfessionTitle> ComProfessionTitles { get; set; }
        /// <summary>
        /// 人员
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
        /// <summary>
        /// 职称评定
        /// </summary>
        public List<SysProfessionInfo> SysProfessionInfos { get; set; }
        
        public ComProfessionTitleLevel(string code, string name, int sort, string spell)
        {
            Code = new Guid(code);
            this.name = name;
            Sort = sort;
            Spell = spell;
        }

        public ComProfessionTitleLevel() { }
    }
}