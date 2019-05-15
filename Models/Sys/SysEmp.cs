using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        [Remote(action: "VerifyEmpCode", controller: "SysEmp")]//验证
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        [Display(Name = "工号")]
        public string EmpCode { get; set; }
        private string name;
        /// <summary>
        /// 姓名
        /// </summary>
        [Display(Name = "姓名　")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public string EmpName
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
        /// 科室
        /// </summary>
        [Display(Name = "科室")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
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
        /// 性别，f1384219-82c1-47d8-8689-0be7c7f41129
        /// </summary>
        [Display(Name = "性别")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public Guid GenderCode { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Display(Name = "性别")]
        public ComGender ComGender { get; set; }
        /// <summary>
        /// 民族，ce17f92b-ee53-4aa6-8f3d-c3b13d865e2d
        /// </summary>
        [Display(Name = "民族")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public Guid NationCode { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        [Display(Name = "民族")]
        public ComNation ComNation { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [Display(Name = "年龄")]
        public int Age { get; set; }
        /// <summary>
        /// 政治面貌，8e871348-b291-44e3-9aff-534cfe8eb4cf
        /// </summary>
        [Display(Name = "政治面貌")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public Guid PoliticalCode { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        [Display(Name = "政治面貌")]
        public ComPolitical ComPolitical { get; set; }
        /// <summary>
        /// 入党时间
        /// </summary>
        [Display(Name = "入党时间")]
        [DataType(DataType.Date)]
        public DateTime? PoliticalDate { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        [Display(Name = "身份证号")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public string IdentityCard { get; set; }
        /// <summary>
        /// 职称系列
        /// </summary>
        [Display(Name = "职称系列")]
        public Guid? ProfessionTitleTypeCode { get; set; }
        /// <summary>
        /// 职称系列
        /// </summary>
        [Display(Name = "职称系列")]
        public ComProfessionTitleType ComProfessionTitleType { get; set; }
        /// <summary>
        /// 职称级别
        /// </summary>
        [Display(Name = "职称级别")]
        public Guid? ProfessionTitleLevelCode { get; set; }
        /// <summary>
        /// 职称级别
        /// </summary>
        [Display(Name = "职称级别")]
        public ComProfessionTitleLevel ComProfessionTitleLevel { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        [Display(Name = "职称")]
        public Guid? ProfessionTitleCode { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        [Display(Name = "职称")]
        public ComProfessionTitle ComProfessionTitle { get; set; }
        /// <summary>
        /// 行政职务，40574e21-beb0-47fd-a754-143abb0a85dd
        /// </summary>
        [Display(Name = "行政职务")]
        public Guid? AdminDutyCode { get; set; }
        /// <summary>
        /// 行政职务
        /// </summary>
        [Display(Name = "行政职务")]
        public ComAdminDuty ComAdminDuty { get; set; }
        /// <summary>
        /// 是否在岗
        /// </summary>
        [Display(Name = "是否在岗")]
        public bool IsPost { get; set; }
        /// <summary>
        /// 人员类别，440ad1b9-4aa1-4c4f-a42b-00fd4b072323
        /// </summary>
        [Display(Name = "人员类别")]
        public Guid? TypeCode { get; set; }
        /// <summary>
        /// 人员类别
        /// </summary>
        [Display(Name = "人员类别")]
        public SysEmpType SysEmpType { get; set; }
        ///// <summary>
        ///// 人员分类
        ///// </summary>
        //[Display(Name = "人员分类")]
        //public Guid ClassCode { get; set; }
        ///// <summary>
        ///// 人员分类
        ///// </summary>
        //[Display(Name = "人员分类")]
        //public SysEmpClass SysEmpClass { get; set; }
        ///// <summary>
        ///// 人员属性
        ///// </summary>
        //[Display(Name = "人员属性")]
        //public Guid AttributeCode { get; set; }
        ///// <summary>
        ///// 人员属性
        ///// </summary>
        //[Display(Name = "人员属性")]
        //public SysEmpAttribute SysEmpAttribute { get; set; }
        /// <summary>
        /// 工作日期
        /// </summary>
        [Display(Name = "工作日期")]
        [DataType(DataType.Date)]
        public DateTime? WorkDate { get; set; }
        /// <summary>
        /// 来院日期
        /// </summary>
        [Display(Name = "来院日期")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public DateTime HospitalDate { get; set; }
        /// <summary>
        /// 档案号
        /// </summary>
        [Display(Name = "档案号")]
        public string ArchivesNo { get; set; }
        /// <summary>
        /// 公积金号
        /// </summary>
        [Display(Name = "公积金号")]
        public string PublicMoneyNo { get; set; }
        /// <summary>
        /// 社保号
        /// </summary>
        [Display(Name = "社保号")]
        public string SocialInsuranceNo { get; set; }
        //public money
        //social insurance
        /// <summary>
        /// 岗位
        /// </summary>
        [Display(Name = "岗位")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public Guid PostCode { get; set; }
        /// <summary>
        /// 岗位
        /// </summary>
        [Display(Name = "岗位")]
        public ComPost ComPost { get; set; }
        ///// <summary>
        ///// 岗位类别
        ///// </summary>
        //[Display(Name = "岗位类别")]
        //public Guid? PostTypeCode { get; set; }
        ///// <summary>
        ///// 岗位类别
        ///// </summary>
        //[Display(Name = "岗位类别")]
        //public ComPostType ComPostType { get; set; }
        ///// <summary>
        ///// 岗位级别
        ///// </summary>
        //[Display(Name = "岗位级别")]
        //public Guid? PostLevelCode { get; set; }
        ///// <summary>
        ///// 岗位级别
        ///// </summary>
        //[Display(Name = "岗位级别")]
        //public ComPostLevel ComPostLevel { get; set; }
        /// <summary>
        /// 工龄
        /// </summary>
        [Display(Name = "工龄")]
        public int WorkAge { get; set; }
        /// <summary>
        /// 院龄
        /// </summary>
        [Display(Name = "院龄")]
        public int HospitalAge { get; set; }
        /// <summary>
        /// 执业资格证
        /// </summary>
        [Display(Name = "执业资格证")]
        public string Practice { get; set; }
        /// <summary>
        /// 执业资格证日期
        /// </summary>
        [Display(Name = "执业资格证日期")]
        [DataType(DataType.Date)]
        public DateTime? PracticeDate { get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        [Display(Name = "开户行")]
        public string OpenBank { get; set; }
        /// <summary>
        /// 银行卡号
        /// </summary>
        [Display(Name = "银行卡号")]
        public string BankCard { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        [Display(Name = "学历")]
        public Guid? EducationCode { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        [Display(Name = "学历")]
        public ComEducation ComEducation { get; set; }
        /// <summary>
        /// 取得学历日期
        /// </summary>
        [Display(Name = "取得学历日期")]
        [DataType(DataType.Date)]
        public DateTime? EducationDate { get; set; }
        /// <summary>
        /// 学位
        /// </summary>
        [Display(Name = "学位")]
        public Guid? DegreeCode { get; set; }
        /// <summary>
        /// 学位
        /// </summary>
        [Display(Name = "学位")]
        public ComDegree ComDegree { get; set; }
        /// <summary>
        /// 毕业院校
        /// </summary>
        [Display(Name = "毕业院校")]
        public string School { get; set; }
        /// <summary>
        /// 所学专业
        /// </summary>
        [Display(Name = "所学专业")]
        public string SchoolMajor { get; set; }
        /// <summary>
        /// 毕业时间
        /// </summary>
        [Display(Name = "毕业时间")]
        [DataType(DataType.Date)]
        public DateTime? GraduationDate { get; set; }
        /// <summary>
        /// 联系方式
        /// </summary>
        [Display(Name = "手机")]
        public string Telephone { get; set; }
        /// <summary>
        /// 婚姻状况，6cca4dd0-8fa7-46be-90ab-f6ac0379adde
        /// </summary>
        [Display(Name = "婚姻状况")]
        public Guid? MarriageCode { get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        [Display(Name = "婚姻状况")]
        public ComMarriage ComMarriage { get; set; }
        ///// <summary>
        ///// 出生地
        ///// </summary>
        //[Display(Name = "出生地")]
        //public string BirthAdd { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        [Display(Name = "家庭住址")]
        public string HomeAdd { get; set; }
        /// <summary>
        /// 户口所在地址
        /// </summary>
        [Display(Name = "户口所在地址")]
        public string IdentityAdd { get; set; }
        /// <summary>
        /// 籍贯
        /// </summary>
        [Display(Name = "籍贯")]
        public string NativePlace { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        [Display(Name = "照片")]
        public string Photo { get; set; }
        /// <summary>
        /// 是否停用
        /// </summary>
        [Display(Name = "是否停用")]
        public bool IsStop { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        public string CreateEmp { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Display(Name = "创建日期")]
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 职称评定
        /// </summary>
        public List<SysProfessionInfo> SysProfessionInfos { get; set; }
        /// <summary>
        /// 学历评定
        /// </summary>
        public List<SysEducation> SysEducations { get; set; }
    }
}