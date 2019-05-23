using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 向标识数据库中添加自定义用户数据
    /// </summary>
    public class HPSUser : IdentityUser<Guid>
    {
        /// <summary>
        /// 工号
        /// </summary>
        [PersonalData]
        [Display(Name = "工号")]
        public string EmpCode { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [PersonalData]
        [Display(Name = "工号")]
        public SysEmp SysEmp { get; set; }
    }
}