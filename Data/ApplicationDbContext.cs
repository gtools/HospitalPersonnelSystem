using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HospitalPersonnelSystem.Models;

namespace HospitalPersonnelSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

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
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //newsequentialid()
            //newid()
            //Add-Migration 
            //Remove-Migration
            //Update-Database
            base.OnModelCreating(modelBuilder);
            int sort = 1;

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
            modelBuilder.Entity<SysNavbarType>()
                .HasData(new SysNavbarType
                {
                    Code = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Name = "基础数据维护",
                    Sort = sort++
                }, new SysNavbarType
                {
                    Code = new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e"),
                    Name = "机构管理",
                    Sort = sort++
                }, new SysNavbarType
                {
                    Code = new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993"),
                    Name = "人事档案",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<SysNavbar>()
                .HasData(new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "菜单类别",
                    Controller = "SysNavbarType",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "菜单",
                    Controller = "SysNavbar",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "性别",
                    Controller = "ComGender",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "岗位",
                    Controller = "ComPost",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "民族",
                    Controller = "ComNation",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "政治面貌",
                    Controller = "ComPolitical",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "职称",
                    Controller = "ComProfessionTitle",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "职称级别",
                    Controller = "ComProfessionTitleLevel",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "职称系列",
                    Controller = "ComProfessionTitleType",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "执业资格",
                    Controller = "ComProfessionRegister",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "执业范围",
                    Controller = "ComProfessionExtent",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "执业类别",
                    Controller = "ComProfessionType",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "行政职务",
                    Controller = "ComAdminDuty",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "人员类别",
                    Controller = "SysEmpType",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "学历",
                    Controller = "ComEducation",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    Code = Guid.NewGuid(),
                    Name = "学位",
                    Controller = "ComDegree",
                    Sort = sort++
                    //}, new SysNavbar
                    //{
                    //    TypeCode = new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
                    //    Code = Guid.NewGuid(),
                    //    Name = "婚姻状况",
                    //    Controller = "ComMarriage",
                    //    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e"),
                    Code = Guid.NewGuid(),
                    Name = "科室信息",
                    Controller = "SysDept",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993"),
                    Code = Guid.NewGuid(),
                    Name = "人员管理",
                    Controller = "SysEmp",
                    Sort = sort++
                }, new SysNavbar
                {
                    TypeCode = new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993"),
                    Code = Guid.NewGuid(),
                    Name = "职称评定",
                    Controller = "SysProfessionInfo",
                    Sort = sort++
                });
            //
            sort = 1;
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
            modelBuilder.Entity<ComGender>()
                .HasData(new ComGender
                {
                    Code = Guid.NewGuid(),
                    Name = "男",
                    Sort = sort++
                }, new ComGender
                {
                    Code = Guid.NewGuid(),
                    Name = "女",
                    Sort = sort++
                }, new ComGender
                {
                    Code = new Guid("f1384219-82c1-47d8-8689-0be7c7f41129"),
                    Name = "未知",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComPost>()
                .HasData(new ComPost
                {
                    Code = Guid.NewGuid(),
                    Name = "卫",
                    Sort = sort++
                }, new ComPost
                {
                    Code = Guid.NewGuid(),
                    Name = "工",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComNation>()
                .HasData(new ComNation
                {
                    Code = new Guid("ce17f92b-ee53-4aa6-8f3d-c3b13d865e2d"),
                    Name = "汉族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "蒙古族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "回族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "藏族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "维吾尔族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "苗族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "彝族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "壮族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "布依族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "朝鲜族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "满族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "侗族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "瑶族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "白族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "土家族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "哈尼族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "哈萨克族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "傣族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "黎族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "傈僳族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "佤族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "畲族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "高山族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "拉祜族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "水族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "东乡族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "纳西族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "景颇族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "柯尔克孜族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "土族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "达斡尔族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "仫佬族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "羌族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "布朗族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "撒拉族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "毛难族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "仡佬族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "锡伯族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "阿昌族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "普米族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "塔吉克族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "怒族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "乌孜别克族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "俄罗斯族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "鄂温克族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "崩龙族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "保安族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "裕固族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "京族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "塔塔尔族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "独龙族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "鄂伦春族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "赫哲族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "门巴族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "珞巴族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "基诺族",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "其他",
                    Sort = sort++
                }, new ComNation
                {
                    Code = Guid.NewGuid(),
                    Name = "外国血统中国人士",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComPolitical>()
                .HasData(new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "中共党员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "中共预备党员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "共青团员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "民革党员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "民盟盟员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "民建会员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "民进会员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "农工党党员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "致公党党员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "九三学社社员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "台盟盟员",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = Guid.NewGuid(),
                    Name = "无党派人士",
                    Sort = sort++
                }, new ComPolitical
                {
                    Code = new Guid("8e871348-b291-44e3-9aff-534cfe8eb4cf"),
                    Name = "群众",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComProfessionTitleType>()
                .HasData(new ComProfessionTitleType
                {
                    Code = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    Name = "卫生技术人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "高等学校教师",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "中等专业学校教师",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "技工学校教师",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "中学教师",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "小学（幼儿园）教师",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "自然科学研究人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "社会科学研究人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "工程技术人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "实验技术人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "农业技术人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "经济专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "会计专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "审计专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "统计专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "新闻专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "出版专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "图书资料专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "文物博物专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "档案专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "广播电视播音人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "翻译人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "律师",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "公证员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "海关人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "船舶技术人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "民用航空飞行技术人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "艺术专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "工艺美术专业人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "体育教练员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = Guid.NewGuid(),
                    Name = "思想政治工作人员",
                    Sort = sort++
                }, new ComProfessionTitleType
                {
                    Code = new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c"),
                    Name = "无",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComProfessionTitleLevel>()
                .HasData(new ComProfessionTitleLevel
                {
                    Code = new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"),
                    Name = "正高级",
                    Sort = sort++
                }, new ComProfessionTitleLevel
                {
                    Code = new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"),
                    Name = "副高级",
                    Sort = sort++
                }, new ComProfessionTitleLevel
                {
                    Code = new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"),
                    Name = "中级",
                    Sort = sort++
                }, new ComProfessionTitleLevel
                {
                    Code = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Name = "初级",
                    Sort = sort++
                }, new ComProfessionTitleLevel
                {
                    Code = new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"),
                    Name = "无",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComProfessionTitle>()
                .HasData(new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"),
                    Code = Guid.NewGuid(),
                    Name = "主任医师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"),
                    Code = Guid.NewGuid(),
                    Name = "主任药师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"),
                    Code = Guid.NewGuid(),
                    Name = "主任护师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"),
                    Code = Guid.NewGuid(),
                    Name = "主任技师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"),
                    Code = Guid.NewGuid(),
                    Name = "副主任医师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"),
                    Code = Guid.NewGuid(),
                    Name = "副主任药师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"),
                    Code = Guid.NewGuid(),
                    Name = "副主任护师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"),
                    Code = Guid.NewGuid(),
                    Name = "副主任技师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"),
                    Code = Guid.NewGuid(),
                    Name = "主治医师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"),
                    Code = Guid.NewGuid(),
                    Name = "主管药师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"),
                    Code = Guid.NewGuid(),
                    Name = "主管护师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"),
                    Code = Guid.NewGuid(),
                    Name = "主管技师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Code = Guid.NewGuid(),
                    Name = "医师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Code = Guid.NewGuid(),
                    Name = "医士",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Code = Guid.NewGuid(),
                    Name = "药师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Code = Guid.NewGuid(),
                    Name = "药士",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Code = Guid.NewGuid(),
                    Name = "护师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Code = Guid.NewGuid(),
                    Name = "护士",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Code = Guid.NewGuid(),
                    Name = "技师",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
                    LevelCode = new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"),
                    Code = Guid.NewGuid(),
                    Name = "技士",
                    Sort = sort++
                }, new ComProfessionTitle
                {
                    TypeCode = new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c"),
                    LevelCode = new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"),
                    Code = Guid.NewGuid(),
                    Name = "无职称",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComAdminDuty>()
                .HasData(new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "院长",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "副院长",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "书记",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "副书记",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "团委书记",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "团委副书记",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "大科主任",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "科主任",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "副主任",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "护士长",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "副护士长",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "科员",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "干事",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = Guid.NewGuid(),
                    Name = "返聘",
                    Sort = sort++
                }, new ComAdminDuty
                {
                    Code = new Guid("40574e21-beb0-47fd-a754-143abb0a85dd"),
                    Name = "无",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<SysEmpType>()
                .HasData(new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "在编人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "人事代理",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "临时人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "离退人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "辞职人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "返聘人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "调出人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "除名人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "实习进修",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "借出人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "长期出国人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "自动离职人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "停薪留职人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "编外离岗人员",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = Guid.NewGuid(),
                    Name = "内部退养",
                    Sort = sort++
                }, new SysEmpType
                {
                    Code = new Guid("440ad1b9-4aa1-4c4f-a42b-00fd4b072323"),
                    Name = "试用人员",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComEducation>()
                .HasData(new ComEducation
                {
                    Code = Guid.NewGuid(),
                    Name = "博士研究生",
                    Sort = sort++
                }, new ComEducation
                {
                    Code = Guid.NewGuid(),
                    Name = "硕士研究生",
                    Sort = sort++
                }, new ComEducation
                {
                    Code = Guid.NewGuid(),
                    Name = "本科",
                    Sort = sort++
                }, new ComEducation
                {
                    Code = Guid.NewGuid(),
                    Name = "专科",
                    Sort = sort++
                }, new ComEducation
                {
                    Code = Guid.NewGuid(),
                    Name = "中专",
                    Sort = sort++
                }, new ComEducation
                {
                    Code = Guid.NewGuid(),
                    Name = "高中及以下",
                    Sort = sort++
                }, new ComEducation
                {
                    Code = Guid.NewGuid(),
                    Name = "技校",
                    Sort = sort++
                }, new ComEducation
                {
                    Code = Guid.NewGuid(),
                    Name = "其他",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComDegree>()
                .HasData(new ComDegree
                {
                    Code = Guid.NewGuid(),
                    Name = "博士后",
                    Sort = sort++
                }, new ComDegree
                {
                    Code = Guid.NewGuid(),
                    Name = "博士",
                    Sort = sort++
                }, new ComDegree
                {
                    Code = Guid.NewGuid(),
                    Name = "硕士",
                    Sort = sort++
                }, new ComDegree
                {
                    Code = Guid.NewGuid(),
                    Name = "学士",
                    Sort = sort++
                }, new ComDegree
                {
                    Code = Guid.NewGuid(),
                    Name = "无",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComMarriage>()
                .HasData(new ComMarriage
                {
                    Code = Guid.NewGuid(),
                    Name = "未婚",
                    Sort = sort++
                }, new ComMarriage
                {
                    Code = Guid.NewGuid(),
                    Name = "已婚",
                    Sort = sort++
                }, new ComMarriage
                {
                    Code = Guid.NewGuid(),
                    Name = "丧偶",
                    Sort = sort++
                }, new ComMarriage
                {
                    Code = Guid.NewGuid(),
                    Name = "离婚",
                    Sort = sort++
                }, new ComMarriage
                {
                    Code = new Guid("6cca4dd0-8fa7-46be-90ab-f6ac0379adde"),
                    Name = "未说明的婚姻状况",
                    Sort = sort++
                });
            sort = 1;
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
            sort = 1;
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
            modelBuilder.Entity<ComProfessionRegister>()
                .HasData(new ComProfessionRegister
                {
                    Code = Guid.NewGuid(),
                    Name = "执业护士",
                    Sort = sort++
                }, new ComProfessionRegister
                {
                    Code = Guid.NewGuid(),
                    Name = "执业医师",
                    Sort = sort++
                }, new ComProfessionRegister
                {
                    Code = new Guid("77aa99bd-d60b-4294-b8ad-fae4ff12c4d8"),
                    Name = "无",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComProfessionType>()
                .HasData(new ComProfessionType
                {
                    Code = Guid.NewGuid(),
                    Name = "临床",
                    Sort = sort++
                }, new ComProfessionType
                {
                    Code = Guid.NewGuid(),
                    Name = "口腔",
                    Sort = sort++
                }, new ComProfessionType
                {
                    Code = Guid.NewGuid(),
                    Name = "公卫",
                    Sort = sort++
                }, new ComProfessionType
                {
                    Code = Guid.NewGuid(),
                    Name = "中医",
                    Sort = sort++
                });
            sort = 1;
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
            modelBuilder.Entity<ComProfessionExtent>()
                .HasData(new ComProfessionExtent
                {
                    Code = Guid.NewGuid(),
                    Name = "护理专业",
                    Sort = sort++
                }, new ComProfessionExtent
                {
                    Code = Guid.NewGuid(),
                    Name = "外科专业",
                    Sort = sort++
                });
            sort = 1;
            #endregion

            #region 职称评定
            modelBuilder.Entity<SysProfessionInfo>(b =>
            {
                b.ToTable("SysProfessionInfo");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
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
            sort = 1;
            #endregion
            


            #region 注释

            //#region 人员分类
            //modelBuilder.Entity<SysEmpClass>(b =>
            //{
            //    b.ToTable("SysEmpClass");
            //    b.HasKey(t => t.Code);
            //    b.Property(t => t.Code)
            //    .HasDefaultValueSql("newid()");
            //    b.Property(t => t.Sort)
            //    .HasDefaultValue(0);
            //});
            //modelBuilder.Entity<SysEmpClass>()
            //    .HasData(new SysEmpClass
            //    {
            //        Code = Guid.Parse("{d5108379-4bc2-42c6-96ea-f4f84eb728da}"),
            //        Name = "医疗",
            //        Spell = "YL",
            //        Sort = 0
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{2c5f6589-4c07-41ad-8e62-3e28ce106e41}"),
            //        Name = "护理",
            //        Spell = "HL",
            //        Sort = 1
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{c4fcd57c-126d-4b48-9ae8-ad5227b8385b}"),
            //        Name = "医技",
            //        Spell = "YJ",
            //        Sort = 2
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{57e99a9f-7bb9-4cd2-8b3d-54d040d626fe}"),
            //        Name = "门诊",
            //        Spell = "MZ",
            //        Sort = 3
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{c8d0bebe-6d93-45e6-8a78-6c9f56f9ab4e}"),
            //        Name = "下乡",
            //        Spell = "XX",
            //        Sort = 4
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{0dbc8541-087b-456d-9ee8-ff57d5d6895f}"),
            //        Name = "行政",
            //        Spell = "XZ",
            //        Sort = 5
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{9192472f-76d5-456a-8d78-727905c81227}"),
            //        Name = "财务",
            //        Spell = "CW",
            //        Sort = 6
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{3eeb9567-670f-43d4-99f0-51ec51f99e87}"),
            //        Name = "管理",
            //        Spell = "GL",
            //        Sort = 7
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{3ba23c03-ccd0-4ad6-afcf-ee04de4affb1}"),
            //        Name = "计算机",
            //        Spell = "JSJ",
            //        Sort = 8
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{6a5aa9d2-25d7-41d2-8598-0abf6d468c74}"),
            //        Name = "后勤",
            //        Spell = "HQ",
            //        Sort = 9
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{9acc51e4-0e74-4cfc-ba4c-513731c51fbd}"),
            //        Name = "借调",
            //        Spell = "JD",
            //        Sort = 10
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{58f2eb1c-5976-4a7e-9fdf-e6a3a3689534}"),
            //        Name = "内退",
            //        Spell = "NT",
            //        Sort = 11
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{a642f8cd-b5a6-4fe4-b483-e14c5a4fe5b1}"),
            //        Name = "停薪留职",
            //        Spell = "TXLZ",
            //        Sort = 12
            //    }, new SysEmpClass
            //    {
            //        Code = Guid.Parse("{a4e9fcae-ac9d-4fbd-8a04-a330176c3bf4}"),
            //        Name = "不在岗",
            //        Spell = "BZG",
            //        Sort = 13
            //    });
            //#endregion
            //岗位 
            //#region 岗位类别
            //modelBuilder.Entity<ComPostType>(b =>
            //{
            //    b.ToTable("ComPostType");
            //    b.HasKey(t => t.Code);
            //    b.Property(t => t.Code)
            //    .HasDefaultValueSql("newid()");
            //    b.Property(t => t.Sort)
            //    .HasDefaultValue(0);
            //});
            //modelBuilder.Entity<ComPostType>()
            //    .HasData(new ComPostType
            //    {
            //        Code = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Name = "管理人员",
            //        Spell = "GLRY",
            //        Sort = 0
            //    }, new ComPostType
            //    {
            //        Code = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Name = "专业技术人员",
            //        Spell = "ZYJSRY",
            //        Sort = 1
            //    }, new ComPostType
            //    {
            //        Code = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Name = "工勤技能人员",
            //        Spell = "GQJNRY",
            //        Sort = 2
            //    }, new ComPostType
            //    {
            //        Code = Guid.Parse("{3bacb485-2037-4835-8268-7cec05a8f02f}"),
            //        Name = "其他从业人员",
            //        Spell = "QTCYRY",
            //        Sort = 3
            //    });
            //#endregion

            //#region 岗位
            //modelBuilder.Entity<ComPost>(b =>
            //{
            //    b.ToTable("ComPost");
            //    b.HasKey(t => t.Code);
            //    b.Property(t => t.Code)
            //    .HasDefaultValueSql("newid()");
            //    b.Property(t => t.Sort)
            //    .HasDefaultValue(0);
            //});
            //modelBuilder.Entity<ComPost>()
            //    .HasData(new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{03ab2e38-ad6d-4ded-b81d-f30188c3ce99}"),
            //        Name = "主任医师",
            //        Spell = "ZRYS",
            //        Sort = 0
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{849957b2-896b-469d-8c6f-fceda4e8d0bf}"),
            //        Name = "副主任医师",
            //        Spell = "FZRYS",
            //        Sort = 1
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{3ed375b5-8384-473d-a4f2-7b0af0a2fb83}"),
            //        Name = "副主任中医师",
            //        Spell = "FZRZYS",
            //        Sort = 2
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{3196870a-8c69-469d-b9f9-0f2cf30ed725}"),
            //        Name = "副主任药师",
            //        Spell = "FZRYS",
            //        Sort = 3
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{eb5aada7-b36a-4481-8913-3cdb0d6c58b1}"),
            //        Name = "副主任护师",
            //        Spell = "FZRHS",
            //        Sort = 4
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{7a877fb5-e5c2-4e7f-98b3-90a8971fa4f2}"),
            //        Name = "副主任技师",
            //        Spell = "FZRJS",
            //        Sort = 5
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{d7ffb990-8f9d-4b22-b3cb-7f5f7866052b}"),
            //        Name = "主治医师",
            //        Spell = "ZYYS",
            //        Sort = 6
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{3a8968ef-8fab-4e13-9d8f-87f8dc6310c3}"),
            //        Name = "主管药师",
            //        Spell = "ZHYS",
            //        Sort = 7
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{81c18332-d2fd-46b1-90d8-da4af2413b8f}"),
            //        Name = "主管护师",
            //        Spell = "ZGHS",
            //        Sort = 8
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{1f04b110-c7ef-46f1-bf64-64dc1d99fa01}"),
            //        Name = "主管技师",
            //        Spell = "ZHJS",
            //        Sort = 9
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{5e1f9469-8024-4e73-bad8-1c4a6960f1e3}"),
            //        Name = "主管检验师",
            //        Spell = "ZGJYS",
            //        Sort = 10
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{5c8d1d42-7f7f-4310-aa81-6506a363afe5}"),
            //        Name = "医师",
            //        Spell = "YS",
            //        Sort = 11
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{0ddc1f8a-5230-4d90-9b5b-46de37de4d94}"),
            //        Name = "药师",
            //        Spell = "YS",
            //        Sort = 12
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{54a4aaea-d563-44cd-9f2d-df074ff29f21}"),
            //        Name = "护师",
            //        Spell = "HS",
            //        Sort = 13
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{525fc200-ceba-4fb8-9428-d0af3e56c0dc}"),
            //        Name = "技师",
            //        Spell = "JS",
            //        Sort = 14
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{dc49d800-e709-4168-a5ae-6bf699a7e457}"),
            //        Name = "康复技师",
            //        Spell = "KFJS",
            //        Sort = 15
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{d7c1ff7a-2a5b-4c03-a89f-2f751668e1ec}"),
            //        Name = "工人技师",
            //        Spell = "GRJS",
            //        Sort = 16
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{622a47d3-6f08-4ed6-b203-bb6f9c35c869}"),
            //        Name = "工程师",
            //        Spell = "GCS",
            //        Sort = 17
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{0ae60efc-8725-430e-b661-df29e489b302}"),
            //        Name = "会计师",
            //        Spell = "KJS",
            //        Sort = 18
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{6833c8ba-7959-4d1f-96f3-b5e6e12f460b}"),
            //        Name = "经济师",
            //        Spell = "JJS",
            //        Sort = 19
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{21ac04c5-7dbd-4cb5-b8eb-099c1938c33b}"),
            //        Name = "统计师",
            //        Spell = "TJS",
            //        Sort = 20
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{fe525ac1-13ac-4dde-a737-73d26f163a16}"),
            //        Name = "政工师",
            //        Spell = "ZGS",
            //        Sort = 21
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{c33dac54-066e-46ca-aa53-f5412e89bb35}"),
            //        Name = "检验师",
            //        Spell = "JYS",
            //        Sort = 22
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{82d40cb9-8e2e-4068-bb1e-2d2f767e0a6c}"),
            //        Name = "助理工程师",
            //        Spell = "ZLGCS",
            //        Sort = 23
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{9f39059c-4402-4812-9b0e-0a6e21707a83}"),
            //        Name = "助理会计师",
            //        Spell = "ZLHJS",
            //        Sort = 24
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{4a289a58-cb42-487a-9664-d3af37591c77}"),
            //        Name = "助理政工师",
            //        Spell = "ZLZGS",
            //        Sort = 25
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{d4d15612-c315-4dff-9df1-ba4da903e175}"),
            //        Name = "医士",
            //        Spell = "YS",
            //        Sort = 26
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{9df8d9a4-8bce-422a-b0ad-45d6624cb8a4}"),
            //        Name = "药士",
            //        Spell = "YS",
            //        Sort = 27
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{0a3333a9-7253-4d62-b6eb-d70af16542b6}"),
            //        Name = "护士",
            //        Spell = "HS",
            //        Sort = 28
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{fe147b9a-afd1-46b9-98bc-293932cbba7f}"),
            //        Name = "技士",
            //        Spell = "JS",
            //        Sort = 29
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{44fd7880-c1bb-411b-94c5-a83b39fe1d70}"),
            //        Name = "检验士",
            //        Spell = "JYS",
            //        Sort = 30
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{ec959e6f-9af0-42d6-b035-65c301b6fc14}"),
            //        Name = "会计员",
            //        Spell = "KJY",
            //        Sort = 31
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{c95e56b0-ca72-46d6-af2e-a61a2396c3db}"),
            //        Name = "经济员",
            //        Spell = "JJY",
            //        Sort = 32
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{5ed553e9-f45c-469f-a5c7-0635f62f6f8c}"),
            //        Name = "馆员",
            //        Spell = "GY",
            //        Sort = 33
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{75e2ed27-a4f7-4292-997d-b0b9459c4e5c}"),
            //        Name = "高级技师",
            //        Spell = "GJJS",
            //        Sort = 0
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{f57fab19-f03e-4720-ba03-20b25af72f56}"),
            //        Name = "技师",
            //        Spell = "JS",
            //        Sort = 1
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{ac0566d1-263a-46a7-8624-9e227963cd82}"),
            //        Name = "高级工",
            //        Spell = "GJG",
            //        Sort = 2
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{0de14529-b648-4747-80ac-0ff90955c852}"),
            //        Name = "中级工",
            //        Spell = "ZJG",
            //        Sort = 3
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{dc92af6b-17b7-4589-9fa5-2cd40a557e3f}"),
            //        Name = "初级工",
            //        Spell = "CJG",
            //        Sort = 4
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{0583a494-3fdf-4c99-a96c-c220ce71c266}"),
            //        Name = "普通工",
            //        Spell = "PTG",
            //        Sort = 5
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{90e68bcd-7867-4558-be8e-6c9dea4c4f1a}"),
            //        Name = "一级职员(正部)",
            //        Spell = "YJZYZB",
            //        Sort = 0
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{fb9c4306-081c-41f9-8c4c-983e416c1940}"),
            //        Name = "二级职员(副部)",
            //        Spell = "EJZYFB",
            //        Sort = 1
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{5d74a866-7316-4251-9d9b-e9dfae651d2e}"),
            //        Name = "三级职员(正厅)",
            //        Spell = "SJZYZT",
            //        Sort = 2
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{b94f43c1-c614-4097-9d62-70969078f250}"),
            //        Name = "四级职员(副厅)",
            //        Spell = "SJZYFT",
            //        Sort = 3
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{b6cd168e-3bee-4073-a94f-013f61cc9a98}"),
            //        Name = "五级职员(正处)",
            //        Spell = "WJZYZC",
            //        Sort = 4
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{0507dfdc-18a6-48e2-8907-55a18bbd9666}"),
            //        Name = "六级职员(副处)",
            //        Spell = "LJZYFC",
            //        Sort = 5
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{030f0e56-1b35-4be7-a057-abd6b82999f5}"),
            //        Name = "七级职员(正科)",
            //        Spell = "QJZYZK",
            //        Sort = 6
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{f0bdb9b9-c798-49f1-9e4d-cc2786c7ce46}"),
            //        Name = "八级职员(副科)",
            //        Spell = "BJZYFK",
            //        Sort = 7
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{7f200f23-fd24-4806-a593-b3fdcfc02aa4}"),
            //        Name = "九级职员(科员)",
            //        Spell = "JZZYKY",
            //        Sort = 8
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{22c4a3d6-a13a-412c-b91e-ea9e16e2c85e}"),
            //        Name = "十级职员(办事员)",
            //        Spell = "SJZYBSY",
            //        Sort = 9
            //    }, new ComPost
            //    {
            //        TypeCode = Guid.Parse("{3bacb485-2037-4835-8268-7cec05a8f02f}"),
            //        Code = Guid.Parse("{ec7ce259-7002-473b-aaf2-23e3f9628710}"),
            //        Name = "未明确职务",
            //        Spell = "WMQZW",
            //        Sort = 0
            //    });
            //#endregion

            //#region 岗位级别
            //modelBuilder.Entity<ComPostLevel>(b =>
            //{
            //    b.ToTable("ComPostLevel");
            //    b.HasKey(t => t.Code);
            //    b.Property(t => t.Code)
            //    .HasDefaultValueSql("newid()");
            //    b.Property(t => t.Sort)
            //    .HasDefaultValue(0);
            //});
            //modelBuilder.Entity<ComPostLevel>()
            //    .HasData(new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{ab66bc18-a2a8-4c72-a2e2-75e10f9a1c07}"),
            //        Name = "一级职员（部级正职）",
            //        Spell = "YJZYBJZZ",
            //        Sort = 0
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{7b173701-fd60-49e0-b1bf-155dd8edf287}"),
            //        Name = "二级职员（部级副职）",
            //        Spell = "EJZYBJFZ",
            //        Sort = 1
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{b9424c72-2c8a-41ef-a120-7995fac42c08}"),
            //        Name = "三级职员（厅级正职）",
            //        Spell = "SJZYTZYTJZZ",
            //        Sort = 2
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{dff6728c-67da-4d2b-a54a-c0477c96d9c5}"),
            //        Name = "四级职员（厅级副职）",
            //        Spell = "SJZYTJFZ",
            //        Sort = 3
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{e3d937c0-93e0-43d3-9f8e-6124c6e6a5fc}"),
            //        Name = "五级职员（处级正职）",
            //        Spell = "WJZYCJZZ",
            //        Sort = 4
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{3b0e735a-83b9-4331-9133-ec330a696f3c}"),
            //        Name = "六级职员（处级副职）",
            //        Spell = "LJZYCJFZ",
            //        Sort = 5
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{ff871fdf-315b-41f8-bbfd-68a1f1cd84e0}"),
            //        Name = "七级职员（科级正职）",
            //        Spell = "QJZYKJZZ",
            //        Sort = 6
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{4668379d-3e73-469e-b731-dcd99e1768ac}"),
            //        Name = "八级职员（科级副职）",
            //        Spell = "BJZYKJFZ",
            //        Sort = 7
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{22ea8fa3-a3e1-4c06-a04a-174b5efbe1c8}"),
            //        Name = "九级职员（科员）",
            //        Spell = "JJZYKY",
            //        Sort = 8
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
            //        Code = Guid.Parse("{efe18ba3-9604-4544-865f-4d3474480149}"),
            //        Name = "十级职员（办事员）",
            //        Spell = "SJZYBSY",
            //        Sort = 9
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{8b75edbe-8b3f-413c-b92b-2f308084f3dc}"),
            //        Name = "一级",
            //        Spell = "YJ",
            //        Sort = 0
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{b9824136-b797-456b-a429-565f157f98f6}"),
            //        Name = "二级",
            //        Spell = "EJ",
            //        Sort = 1
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{0eaec349-c3fc-4cd8-bd0b-a5cfa53861ea}"),
            //        Name = "三级",
            //        Spell = "SJ",
            //        Sort = 2
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{9c5282ca-c12a-4779-b3e3-3a931bcd1fb9}"),
            //        Name = "四级",
            //        Spell = "SJ",
            //        Sort = 3
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{beb3b0c1-56d2-4135-b36c-33151b4769f1}"),
            //        Name = "五级",
            //        Spell = "WJ",
            //        Sort = 4
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{20f8d17b-88e8-4cb5-bd81-4ca77f0a4bb7}"),
            //        Name = "六级",
            //        Spell = "LJ",
            //        Sort = 5
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{12028e5b-4ebe-4069-8595-9d526d0b9f78}"),
            //        Name = "七级",
            //        Spell = "QJ",
            //        Sort = 6
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{975ebb9e-5d1e-4139-b806-db62aa8f9ef5}"),
            //        Name = "八级",
            //        Spell = "BJ",
            //        Sort = 7
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{92a854b0-dd0d-4f62-bb0d-e059d626cc8a}"),
            //        Name = "九级",
            //        Spell = "JJ",
            //        Sort = 8
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{88bd532a-a76a-4a14-aad7-edc199ac15c2}"),
            //        Name = "十级",
            //        Spell = "SJ",
            //        Sort = 9
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{904425eb-ddbc-4892-a0f2-28530a13cc6f}"),
            //        Name = "十一级",
            //        Spell = "SYJ",
            //        Sort = 10
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{cd71e1cb-020d-4dad-b528-49cfa73d7262}"),
            //        Name = "十二级",
            //        Spell = "SEJ",
            //        Sort = 11
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
            //        Code = Guid.Parse("{2186f63c-9f6c-40c2-81fb-53dc0341a736}"),
            //        Name = "十三级",
            //        Spell = "SSJ",
            //        Sort = 12
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{e289d673-b2a3-4856-a29d-ceef8a5e26b2}"),
            //        Name = "一级岗位（高级技师）",
            //        Spell = "YJGWGJJS",
            //        Sort = 0
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{3cf258fd-e6f3-43f2-9789-ded0a0256ee5}"),
            //        Name = "二级岗位（技师）",
            //        Spell = "EJGWJS",
            //        Sort = 1
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{36d4d0b7-7fef-46bc-9b17-e094f7629040}"),
            //        Name = "三级岗位（高级工）",
            //        Spell = "SJGWGJG",
            //        Sort = 2
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{19c9a75c-79bf-4552-8cc4-8b56e4882385}"),
            //        Name = "四级岗位（中级工）",
            //        Spell = "SJGWZJG",
            //        Sort = 3
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{d44d5a34-78de-44eb-a26e-9930086f793b}"),
            //        Name = "五级岗位（初级工）",
            //        Spell = "WJGWCJG",
            //        Sort = 4
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
            //        Code = Guid.Parse("{dd765fd9-879f-4fe9-9d41-7b8b6b6ba061}"),
            //        Name = "普通工",
            //        Spell = "PTG",
            //        Sort = 5
            //    }, new ComPostLevel
            //    {
            //        TypeCode = Guid.Parse("{3bacb485-2037-4835-8268-7cec05a8f02f}"),
            //        Code = Guid.Parse("{6c9c57c3-9cd6-4eba-8b55-3027babbc070}"),
            //        Name = "其他等级人员",
            //        Spell = "QTDJRY",
            //        Sort = 0
            //    });
            //#endregion






            //#region 人员属性
            //modelBuilder.Entity<SysEmpAttribute>(b =>
            //{
            //    b.ToTable("SysEmpAttribute");
            //    b.HasKey(t => t.Code);
            //    b.Property(t => t.Code)
            //    .HasDefaultValueSql("newid()");
            //    b.Property(t => t.Sort)
            //    .HasDefaultValue(0);
            //});
            //#endregion
            #endregion



        }
    }
}
