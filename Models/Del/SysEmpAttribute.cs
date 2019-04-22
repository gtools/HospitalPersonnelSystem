//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

//namespace HospitalPersonnelSystem.Models
//{
//    /// <summary>
//    /// 人员属性
//    /// </summary>
//    public class SysEmpAttribute
//    {
//        /// <summary>
//        /// 代码
//        /// </summary>
//        public Guid Code { get; set; }
//        /// <summary>
//        /// 名称
//        /// </summary>
//        [Required(ErrorMessage = Validate.Required)]
//        [Display(Name = "名称")]
//        public string Name { get; set; }
//        /// <summary>
//        /// 拼音码
//        /// </summary>
//        [Display(Name = "拼音码")]
//        public string Spell { get; set; }
//        /// <summary>
//        /// 序号
//        /// </summary>
//        [Display(Name = "序号")]
//        public int Sort { get; set; }
//        /// <summary>
//        /// 人员列表
//        /// </summary>
//        public List<SysEmp> SysEmps { get; set; }
//    }
//}