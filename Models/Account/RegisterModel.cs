using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 用户注册视图
    /// </summary>
    public class RegisterModel
    {
        [Display(Name = "用户账号")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        [StringLength(6, ErrorMessage = GTSharp.Validate.StringLength, MinimumLength = 3)]
        [Remote(action: "VerifyUserName", controller: "Account")]//验证
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Display(Name = "密码")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        [StringLength(10, ErrorMessage = GTSharp.Validate.StringLength, MinimumLength = 1)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = GTSharp.Validate.EqualTo)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "人员工号")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public string EmpCode { get; set; }

        public SysEmp SysEmp { get; set; }
    }
}
