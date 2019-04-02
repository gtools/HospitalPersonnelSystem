using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 人员信息
    /// </summary>
    public class HR_SYS_EMP
    {
        /// <summary>
        /// 工号
        /// </summary>
        //[Remote(action: "VerifyEmp_Code", controller: "SYS_Emp")]//验证
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "工号")]
        public string EMP_CODE { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "姓名")]
        public string EMP_NAME { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "性别")]
        public string GENDER { get; set; }
    }
}