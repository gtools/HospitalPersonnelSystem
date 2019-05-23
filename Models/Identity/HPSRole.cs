using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 权限
    /// </summary>
    public class HPSRole : IdentityRole<Guid>
    {
    }
}