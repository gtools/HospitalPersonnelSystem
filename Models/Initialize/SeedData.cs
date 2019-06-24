using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using HospitalPersonnelSystem.Data;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 数据种子
    /// </summary>
    public class SeedData
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="context">EF</param>
        public static void Initialize(ApplicationDbContext context)
        {
            #region 菜单类别
            // 判断是否有数据
            if (!context.SysNavbarTypes.Any())
            {
                //不存在
                context.SysNavbarTypes.AddRange(
                    new SysNavbarType("49b247e4-33bb-4793-a23f-ef86ebc5f654", 1, "系统设置", "JTSZ"),
                    new SysNavbarType("f356c105-78d1-4d16-bb8d-a48fc1072993", 2, "人事档案", "RSDA"),
                    new SysNavbarType("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e", 3, "机构管理", "JGGL"),
                    new SysNavbarType("4d3c3953-fd9e-4df1-aa18-3285e020d4bc", 4, "基础数据维护", "JCSJWH"));
            }
            #endregion

            #region 菜单
            if (!context.SysNavbars.Any())
            {
                context.SysNavbars.AddRange(
                    new SysNavbar("43155cdf-69c5-4610-9578-711a8830e39c", "49b247e4-33bb-4793-a23f-ef86ebc5f654", 1, "账号&权限管理", "Admin", "UserIndex", "ZHQXGL"),
                    new SysNavbar("84694a3e-bd02-4c7b-809a-13b03179ec47", "49b247e4-33bb-4793-a23f-ef86ebc5f654", 2, "菜单管理", "SysNavbar", "Index", "CDGL"));
            }
            #endregion





            context.SaveChanges();
        }
    }
}