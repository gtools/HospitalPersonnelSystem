using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 用户注册视图
    /// </summary>
    public class RoleCreateModel
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// 菜单类别列表
        /// </summary>
        public List<SysNavbarType> SysNavbarTypes { get; set; }

        /// <summary>
        /// 选择全选
        /// </summary>
        public List<string> Claims { get; set; }
    }
}
