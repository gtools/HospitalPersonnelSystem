using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 密码重置视图
    /// </summary>
    public class ResetPasswordModel
    {
        public Guid Id { get; set; }

        [Display(Name = "用户账号")]
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
        
        public string Code { get; set; }
    }
}
