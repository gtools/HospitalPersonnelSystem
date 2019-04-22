using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 职称
    /// </summary>
    public class ComProfessionTitle
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
        public int Sort { get; set; }
        /// <summary>
        /// 职称系列
        /// </summary>
        [Display(Name = "职称系列")]
        public Guid TypeCode { get; set; }
        /// <summary>
        /// 职称系列
        /// </summary>
        [Display(Name = "职称系列")]
        public ComProfessionTitleType ComProfessionTitleType { get; set; }
        /// <summary>
        /// 职称级别
        /// </summary>
        [Display(Name = "职称级别")]
        public Guid LevelCode { get; set; }
        /// <summary>
        /// 职称级别
        /// </summary>
        [Display(Name = "职称级别")]
        public ComProfessionTitleLevel ComProfessionTitleLevel { get; set; }

        /// <summary>
        /// 人员
        /// </summary>
        public List<SysEmp> SysEmps { get; set; }
    }
}