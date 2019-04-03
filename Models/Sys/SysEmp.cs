﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 人员信息
    /// </summary>
    public class SysEmp
    {
        /// <summary>
        /// 工号
        /// </summary>
        //[Remote(action: "VerifyEmp_Code", controller: "SYS_Emp")]//验证
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "工号")]
        public string EmpCode { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "姓名")]
        public string EmpName { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        [Display(Name = "拼音码")]
        public string Spell { get; set; }
        /// <summary>
        /// 科室代码
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "科室")]
        public string DeptCode { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        [Display(Name = "科室")]
        public SysDept SysDept { get; set; }
        /// <summary>
        /// 曾用名
        /// </summary>
        [Display(Name = "曾用名")]
        public string OldName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name = "性别")]
        public Guid GenderCode { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        [Display(Name = "性别")]
        public ComGender Gender { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        [Display(Name = "民族")]
        public Guid NationCode { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        [Display(Name = "民族")]
        public ComNation Nation { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        [Display(Name = "出生日期")]
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [Display(Name = "年龄")]
        public int Age { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        [Display(Name = "政治面貌")]
        public Guid PoliticalCode { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        [Display(Name = "政治面貌")]
        public ComPolitical Political { get; set; }
        /// <summary>
        /// 入党时间
        /// </summary>
        [Display(Name = "入党时间")]
        public DateTime PoliticalDate { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "身份证号")]
        public string IdentityCard { get; set; }
        /// <summary>
        /// 职称系类
        /// </summary>
        [Display(Name = "职称系类")]
        public Guid ProfessionTitleTypeCode { get; set; }
        /// <summary>
        /// 职称系类
        /// </summary>
        [Display(Name = "职称系类")]
        public ComProfessionTitleType ProfessionTitleType { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        [Display(Name = "职称")]
        public Guid ProfessionTitleCode { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        [Display(Name = "职称")]
        public ComProfessionTitle ProfessionTitle { get; set; }
        /// <summary>
        /// 职称级别
        /// </summary>
        [Display(Name = "职称级别")]
        public Guid ProfessionTitleLevelCode { get; set; }
        /// <summary>
        /// 职称级别
        /// </summary>
        [Display(Name = "职称级别")]
        public ComProfessionTitleLevel ProfessionTitleLevel { get; set; }
        /// <summary>
        /// 行政职务
        /// </summary>
        [Display(Name = "行政职务")]
        public Guid AdminDutyCode { get; set; }
        /// <summary>
        /// 行政职务
        /// </summary>
        [Display(Name = "行政职务")]
        public ComAdminDuty AdminDuty { get; set; }
        /// <summary>
        /// 人员类别
        /// </summary>
        [Display(Name = "人员类别")]
        public Guid TypeCode { get; set; }
        /// <summary>
        /// 人员类别
        /// </summary>
        [Display(Name = "人员类别")]
        public SysEmpType Type { get; set; }
        /// <summary>
        /// 人员分类
        /// </summary>
        [Display(Name = "人员分类")]
        public Guid ClassCode { get; set; }
        /// <summary>
        /// 人员分类
        /// </summary>
        [Display(Name = "人员分类")]
        public SysEmpClass Class { get; set; }
        




        /// <summary>
        /// 家庭住址
        /// </summary>
        [Display(Name = "家庭住址")]
        public string HomeAdd { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        [Display(Name = "照片")]
        public string Photo { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        [Display(Name = "籍贯")]
        public string NativePlace { get; set; }
        





    }
}