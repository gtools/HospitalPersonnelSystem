using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 菜单类别
    /// </summary>
    public class SysNavbarType
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
        public int Sort { get; set; }
        /// <summary>
        /// 菜单列表
        /// </summary>
        public List<SysNavbar> SysNavbars { get; set; }
    }
}
