using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalPersonnelSystem.Models
{
    /// <summary>
    /// 职称评定
    /// </summary>
    public class SysProfessionInfo
    {
        /// <summary>
        /// 代码
        /// </summary>
        public Guid Code { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [Display(Name = "工号")]
        [Required(ErrorMessage = GTSharp.Validate.Required)]
        public string EmpCode { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [Display(Name = "工号")]
        public SysEmp SysEmp { get; set; }
        /// <summary>
        /// 执业资格
        /// </summary>
        [Display(Name = "执业资格")]
        public Guid? ProfessionRegisterCode { get; set; }
        /// <summary>
        /// 执业资格
        /// </summary>
        [Display(Name = "执业资格")]
        public ComProfessionRegister ComProfessionRegister { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        [Display(Name = "类别")]
        public string TypeCode { get; set; }
        /// <summary>
        /// 执业范围
        /// </summary>
        [Display(Name = "执业范围")]
        public Guid? ProfessionExtentCode { get; set; }
        /// <summary>
        /// 执业范围
        /// </summary>
        [Display(Name = "执业范围")]
        public ComProfessionExtent ComProfessionExtent { get; set; }
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
        [Display(Name = "职称　　")]
        public Guid? ProfessionTitleCode { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        [Display(Name = "职称")]
        public ComProfessionTitle ComProfessionTitle { get; set; }
        /// <summary>
        /// 是否聘任
        /// </summary>
        [Display(Name = "是否聘任")]
        [Remote(action: "VerifyEngage", controller: "SysProfessionInfo", AdditionalFields = nameof(IsEngage))]
        public bool IsEngage { get; set; }
        /// <summary>
        /// 聘任日期
        /// </summary>
        [Display(Name = "聘任日期")]
        [Remote(action: "VerifyEngage", controller: "SysProfessionInfo", AdditionalFields = nameof(EngageDate))]
        [DataType(DataType.Date)]
        public DateTime? EngageDate { get; set; }
        /// <summary>
        /// 执业类别
        /// </summary>
        [Display(Name = "执业类别")]
        public Guid? ProfessionTypeCode { get; set; }
        /// <summary>
        /// 执业类别
        /// </summary>
        [Display(Name = "执业类别")]
        public ComProfessionType ComProfessionType { get; set; }
        /// <summary>
        /// 专业名称
        /// </summary>
        [Display(Name = "专业名称")]
        public string ProfessionalName { get; set; }
        /// <summary>
        /// 晋升时间
        /// </summary>
        [Display(Name = "晋升时间")]
        [DataType(DataType.Date)]
        public DateTime UpDate { get; set; }
        /// <summary>
        /// 专业技术资格证书编号
        /// </summary>
        [Display(Name = "专业技术资格证书编号")]
        public string No1 { get; set; }
        /// <summary>
        /// 医师资格证书编号
        /// </summary>
        [Display(Name = "医师资格证书编号")]
        public string No2 { get; set; }
        /// <summary>
        /// 医师执业证书编号
        /// </summary>
        [Display(Name = "医师执业证书编号")]
        public string No3 { get; set; }
        /// <summary>
        /// 护士执业证书编号
        /// </summary>
        [Display(Name = "护士执业证书编号")]
        public string No4 { get; set; }
        /// <summary>
        /// 其它证书编号
        /// </summary>
        [Display(Name = "其它证书编号")]
        public string No5 { get; set; }
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
        public DateTime CreateDate { get; set; }
    }
}