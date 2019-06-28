using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HospitalPersonnelSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace HospitalPersonnelSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<HPSUser, HPSRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //newsequentialid()
        //newid()
        //Add-Migration//
        //Remove-Migration//删除以进行初始迁移
        //Update-Database//更新数据库
        //Drop-Database//删除数据库


        //岗位（岗位类别），出生地不要，
        //职业资格：执业医师，执业护士，无
        //类别：临床、口腔、公卫、中医
        //专业技术资格（职称）
        //
        #region 集合
        /// <summary>
        /// 菜单类别
        /// </summary>
        public DbSet<SysNavbarType> SysNavbarTypes { get; set; }
        /// <summary>
        /// 菜单
        /// </summary>
        public DbSet<SysNavbar> SysNavbars { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public DbSet<ComGender> ComGenders { get; set; }
        /// <summary>
        /// 民族
        /// </summary>
        public DbSet<ComNation> ComNations { get; set; }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public DbSet<ComPolitical> ComPoliticals { get; set; }
        /// <summary>
        /// 职称系列
        /// </summary>
        public DbSet<ComProfessionTitleType> ComProfessionTitleTypes { get; set; }
        /// <summary>
        /// 职称级别
        /// </summary>
        public DbSet<ComProfessionTitleLevel> ComProfessionTitleLevels { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        public DbSet<ComProfessionTitle> ComProfessionTitles { get; set; }
        /// <summary>
        /// 行政职务
        /// </summary>
        public DbSet<ComAdminDuty> ComAdminDutys { get; set; }
        /// <summary>
        /// 人员类别
        /// </summary>
        public DbSet<SysEmpType> SysEmpTypes { get; set; }
        ///// <summary>
        ///// 人员分类
        ///// </summary>
        //public DbSet<SysEmpClass> SysEmpClasss { get; set; }
        ///// <summary>
        ///// 岗位类别
        ///// </summary>
        //public DbSet<ComPostType> ComPostTypes { get; set; }
        /// <summary>
        /// 岗位
        /// </summary>
        public DbSet<ComPost> ComPosts { get; set; }
        ///// <summary>
        ///// 岗位级别
        ///// </summary>
        //public DbSet<ComPostLevel> ComPostLevels { get; set; }
        /// <summary>
        /// 学历
        /// </summary>
        public DbSet<ComEducation> ComEducations { get; set; }
        /// <summary>
        /// 学位
        /// </summary>
        public DbSet<ComDegree> ComDegrees { get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public DbSet<ComMarriage> ComMarriages { get; set; }
        ///// <summary>
        ///// 人员属性
        ///// </summary>
        //public DbSet<SysEmpAttribute> SysEmpAttributes { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public DbSet<SysDept> SysDepts { get; set; }
        /// <summary>
        /// 人员
        /// </summary>
        public DbSet<SysEmp> SysEmps { get; set; }
        /// <summary>
        /// 执业资格
        /// </summary>
        public DbSet<ComProfessionRegister> ComProfessionRegisters { get; set; }
        /// <summary>
        /// 执业类别
        /// </summary>
        public DbSet<ComProfessionType> ComProfessionTypes { get; set; }
        /// <summary>
        /// 执业范围
        /// </summary>
        public DbSet<ComProfessionExtent> ComProfessionExtents { get; set; }
        /// <summary>
        /// 职称评定
        /// </summary>
        public DbSet<SysProfessionInfo> SysProfessionInfos { get; set; }
        /// <summary>
        /// 学历评定
        /// </summary>
        public DbSet<SysEducation> SysEducations { get; set; }
        /// <summary>
        /// 合同
        /// </summary>
        public DbSet<SysContract> SysContracts { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //int sort = 1;

            #region 菜单类别
            modelBuilder.Entity<SysNavbarType>(b =>
            {
                b.ToTable("SysNavbarType");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 菜单
            modelBuilder.Entity<SysNavbar>(b =>
            {
                b.ToTable("SysNavbar");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
                b.HasOne(t => t.SysNavbarType)
                .WithMany(t => t.SysNavbars)
                .HasForeignKey(t => t.TypeCode)
                .HasConstraintName("FK_TypeCode_SysNavbarType_SysNavbar");
            });
            #endregion

            #region 性别
            modelBuilder.Entity<ComGender>(b =>
            {
                b.ToTable("ComGender");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 岗位
            modelBuilder.Entity<ComPost>(b =>
            {
                b.ToTable("ComPost");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            //https://baike.baidu.com/item/%E4%B8%AD%E5%8D%8E%E6%B0%91%E6%97%8F/1186?fr=aladdin
            #region 民族
            modelBuilder.Entity<ComNation>(b =>
            {
                b.ToTable("ComNation");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            //https://baike.baidu.com/item/%E6%94%BF%E6%B2%BB%E9%9D%A2%E8%B2%8C/9734380?fr=aladdin#1
            #region 政治面貌
            modelBuilder.Entity<ComPolitical>(b =>
            {
                b.ToTable("ComPolitical");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            //https://baike.baidu.com/item/%E8%81%8C%E7%A7%B0/1035081?fr=aladdin#2
            //http://ms.nvq.net.cn/nvqdbApp/htm/fenlei/index.html
            #region 职称系列
            modelBuilder.Entity<ComProfessionTitleType>(b =>
            {
                b.ToTable("ComProfessionTitleType");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 职称级别
            modelBuilder.Entity<ComProfessionTitleLevel>(b =>
            {
                b.ToTable("ComProfessionTitleLevel");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 职称
            modelBuilder.Entity<ComProfessionTitle>(b =>
            {
                b.ToTable("ComProfessionTitle");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
                b.HasOne(x => x.ComProfessionTitleType)
                .WithMany(y => y.ComProfessionTitles)
                .HasForeignKey(x => x.TypeCode)
                .HasConstraintName("FK_TypeCode_ComProfessionTitle")
                .OnDelete(DeleteBehavior.Cascade);
                b.HasOne(x => x.ComProfessionTitleLevel)
                .WithMany(y => y.ComProfessionTitles)
                .HasForeignKey(x => x.LevelCode)
                .HasConstraintName("FK_LevelCode_ComProfessionTitle")
                .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion

            #region 行政职务
            modelBuilder.Entity<ComAdminDuty>(b =>
            {
                b.ToTable("ComAdminDuty");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 人员类别
            modelBuilder.Entity<SysEmpType>(b =>
            {
                b.ToTable("SysEmpType");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 学历
            modelBuilder.Entity<ComEducation>(b =>
            {
                b.ToTable("ComEducation");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 学位
            modelBuilder.Entity<ComDegree>(b =>
            {
                b.ToTable("ComDegree");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 婚姻状况
            modelBuilder.Entity<ComMarriage>(b =>
            {
                b.ToTable("ComMarriage");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 科室
            modelBuilder.Entity<SysDept>(b =>
            {
                b.ToTable("SysDept");
                b.HasKey(t => t.DeptCode);
                b.Property(t => t.DeptCode)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 人员
            modelBuilder.Entity<SysEmp>(b =>
            {
                b.ToTable("SysEmp");
                b.HasKey(t => t.EmpCode);
                b.Property(t => t.IsPost)//是否在岗
                .HasDefaultValue(true);
                b.Property(t => t.IsStop)//是否停用
                .HasDefaultValue(false);
                b.Property(t => t.BirthDate)//出生日期
                .HasDefaultValueSql("getdate()");
                b.Property(t => t.HospitalDate)//来院日期
                .HasDefaultValueSql("getdate()");
                b.Property(t => t.CreateDate)//创建日期
                .HasDefaultValueSql("getdate()");
                b.HasOne(t => t.ComGender)//性别
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.GenderCode)
                .HasConstraintName("FK_GenderCode_ComGender_SysEmp");
                b.HasOne(t => t.ComNation)//民族
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.NationCode)
                .HasConstraintName("FK_NationCode_ComNation_SysEmp");
                b.HasOne(t => t.ComPolitical)//政治面貌
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.PoliticalCode)
                .HasConstraintName("FK_PoliticalCode_ComPolitical_SysEmp");
                b.HasOne(t => t.ComProfessionTitleType)//职称系列
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.ProfessionTitleTypeCode)
                .HasConstraintName("FK_PTTCode_ComProfessionTitleType_SysEmp");
                b.HasOne(t => t.ComProfessionTitleLevel)//职称级别
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.ProfessionTitleLevelCode)
                .HasConstraintName("FK_PTLCode_ComProfessionTitleLevel_SysEmp");
                b.HasOne(t => t.ComProfessionTitle)//职称
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.ProfessionTitleCode)
                .HasConstraintName("FK_PTCode_ComProfessionTitle_SysEmp");
                b.HasOne(t => t.ComAdminDuty)//行政职务
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.AdminDutyCode)
                .HasConstraintName("FK_AdminDutyCode_ComAdminDuty_SysEmp");
                b.HasOne(t => t.SysEmpType)//人员类别
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.TypeCode)
                .HasConstraintName("FK_TypeCode_SysEmpType_SysEmp");
                //b.HasOne(t => t.SysEmpClass)//人员分类
                //.WithMany(t => t.SysEmps)
                //.HasForeignKey(t => t.ClassCode)
                //.HasConstraintName("FK_ClassCode_SysEmpClass_SysEmp");
                //b.HasOne(t => t.SysEmpAttribute)//人员属性
                //.WithMany(t => t.SysEmps)
                //.HasForeignKey(t => t.AttributeCode)
                //.HasConstraintName("FK_AttributeCode_SysEmpAttribute_SysEmp");
                //b.HasOne(t => t.ComPost)//岗位
                //.WithMany(t => t.SysEmps)
                //.HasForeignKey(t => t.PostCode)
                //.HasConstraintName("FK_PostCode_ComPost_SysEmp");
                //b.HasOne(t => t.ComPostType)//岗位类别
                //.WithMany(t => t.SysEmps)
                //.HasForeignKey(t => t.PostTypeCode)
                //.HasConstraintName("FK_PostTypeCode_ComPostType_SysEmp");
                //b.HasOne(t => t.ComPostLevel)//岗位级别
                //.WithMany(t => t.SysEmps)
                //.HasForeignKey(t => t.PostLevelCode)
                //.HasConstraintName("FK_PostLevelCode_ComPostLevel_SysEmp");
                b.HasOne(t => t.ComEducation)//学历
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.EducationCode)
                .HasConstraintName("FK_EducationCode_ComEducation_SysEmp");
                b.HasOne(t => t.ComDegree)//学位
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.DegreeCode)
                .HasConstraintName("FK_DegreeCode_ComDegree_SysEmp");
                b.HasOne(t => t.ComMarriage)//婚姻状况
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.MarriageCode)
                .HasConstraintName("FK_MarriageCode_ComMarriage_SysEmp");
                b.HasOne(t => t.SysDept)//科室
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.DeptCode)
                .HasConstraintName("FK_DeptCode_SysDept_SysEmp");
            });
            #endregion
            
            #region 执业资格
            modelBuilder.Entity<ComProfessionRegister>(b =>
            {
                b.ToTable("ComProfessionRegister");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 执业类别
            modelBuilder.Entity<ComProfessionType>(b =>
            {
                b.ToTable("ComProfessionType");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 执业范围
            modelBuilder.Entity<ComProfessionExtent>(b =>
            {
                b.ToTable("ComProfessionExtent");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            #endregion

            #region 职称评定
            modelBuilder.Entity<SysProfessionInfo>(b =>
            {
                b.ToTable("SysProfessionInfo");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newsequentialid()");
                b.Property(t => t.IsEngage)//是否聘用
                .HasDefaultValue(false);
                //b.Property(t => t.UpDate)//来晋升日期
                //.HasDefaultValueSql("getdate()");
                b.Property(t => t.CreateDate)//创建日期
                .HasDefaultValueSql("getdate()");
                b.HasOne(t => t.ComProfessionExtent)//职业范围
                 .WithMany(t => t.SysProfessionInfos)
                 .HasForeignKey(t => t.ProfessionExtentCode)
                 .HasConstraintName("FK_ExtentCode_Extent_SysProfessionInfo");
                b.HasOne(t => t.ComProfessionRegister)//职业资格
                 .WithMany(t => t.SysProfessionInfos)
                 .HasForeignKey(t => t.ProfessionRegisterCode)
                 .HasConstraintName("FK_RegisterCode_Register_SysProfessionInfo");
                b.HasOne(t => t.ComProfessionTitle)//职称
                 .WithMany(t => t.SysProfessionInfos)
                 .HasForeignKey(t => t.ProfessionTitleCode)
                 .HasConstraintName("FK_TitleCode_Title_SysProfessionInfo");
                b.HasOne(t => t.ComProfessionTitleLevel)//职称级别
                 .WithMany(t => t.SysProfessionInfos)
                 .HasForeignKey(t => t.ProfessionTitleLevelCode)
                 .HasConstraintName("FK_LevelCode_TitleLevel_SysProfessionInfo");
                b.HasOne(t => t.ComProfessionTitleType)//职称系列
                 .WithMany(t => t.SysProfessionInfos)
                 .HasForeignKey(t => t.ProfessionTitleTypeCode)
                 .HasConstraintName("FK_TypeCode_TitleType_SysProfessionInfo");
                b.HasOne(t => t.ComProfessionType)//执业类别
                 .WithMany(t => t.SysProfessionInfos)
                 .HasForeignKey(t => t.ProfessionTypeCode)
                 .HasConstraintName("FK_TypeCode_Type_SysProfessionInfo");
                b.HasOne(t => t.SysEmp)//人员
                 .WithMany(t => t.SysProfessionInfos)
                 .HasForeignKey(t => t.EmpCode)
                 .HasConstraintName("FK_EmpCode_SysEmp_SysProfessionInfo");
            });
            #endregion

            #region 学历评定
            modelBuilder.Entity<SysEducation>(b =>
            {
                b.ToTable("SysEducation");
                b.HasKey(t => t.EmpCode);
                b.HasOne(t => t.SysEmp)//人员
                 .WithMany(t => t.SysEducations)
                 .HasForeignKey(t => t.EmpCode)
                 .HasConstraintName("FK_EmpCode_SysEmp_SysEducation");
                b.Property(t => t.CreateDate)//创建日期
                .HasDefaultValueSql("getdate()");
            });
            #endregion

            #region 合同
            modelBuilder.Entity<SysContract>(b =>
            {
                b.ToTable("SysContract");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newsequentialid()");
                b.HasOne(t => t.SysEmp)//人员
                 .WithMany(t => t.SysContracts)
                 .HasForeignKey(t => t.EmpCode)
                 .HasConstraintName("FK_EmpCode_SysEmp_SysContract");
                b.Property(t => t.CreateDate)//创建日期
                .HasDefaultValueSql("getdate()");
            });
            #endregion
            
        }

    }
}
