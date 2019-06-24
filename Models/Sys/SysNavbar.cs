using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class SysNavbar
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
        /// 菜单类别
        /// </summary>
        [Display(Name = "菜单类别")]
        public Guid TypeCode { get; set; }
        /// <summary>
        /// 菜单类别
        /// </summary>
        [Display(Name = "菜单类别")]
        public SysNavbarType SysNavbarType { get; set; }
        private string controller;
        /// <summary>
        /// 控制器
        /// </summary>
        [Display(Name = "控制器")]
        public string Controller
        {
            get { return controller; }
            set
            {
                controller = value;
                Action = "Index";
            }
        }
        /// <summary>
        /// 动作
        /// </summary>
        [Display(Name = "动作")]
        public string Action { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [Display(Name = "区域")]
        public string Area { get; set; }
        
        /// <summary>
        /// 是否选择，排除属性
        /// </summary>
        [NotMapped]
        public bool Checked { get; set; }

        public SysNavbar(string code, string typecode, int sort, string name, string controller, string action, string spell)
        {
            Code = new Guid(code);
            TypeCode = new Guid(typecode);
            Sort = sort;
            this.name = name;
            Controller = controller;
            Action = action;
            Spell = spell;
        }
        public SysNavbar() { }
    }
}
