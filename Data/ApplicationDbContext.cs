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
        /// 职称系类
        /// </summary>
        public DbSet<ComProfessionTitleType> ComProfessionTitleTypes { get; set; }
        /// <summary>
        /// 职称
        /// </summary>
        public DbSet<ComProfessionTitle> ComProfessionTitles { get; set; }
        /// <summary>
        /// 职称级别
        /// </summary>
        public DbSet<ComProfessionTitleLevel> ComProfessionTitleLevels { get; set; }
        /// <summary>
        /// 行政职务
        /// </summary>
        public DbSet<ComAdminDuty> ComAdminDutys { get; set; }
        /// <summary>
        /// 人员类别
        /// </summary>
        public DbSet<SysEmpType> SysEmpTypes { get; set; }
        /// <summary>
        /// 人员分类
        /// </summary>
        public DbSet<SysEmpClass> SysEmpClasss { get; set; }
        /// <summary>
        /// 岗位类别
        /// </summary>
        public DbSet<ComPostType> ComPostTypes { get; set; }
        /// <summary>
        /// 岗位
        /// </summary>
        public DbSet<ComPost> ComPosts { get; set; }
        /// <summary>
        /// 岗位级别
        /// </summary>
        public DbSet<ComPostLevel> ComPostLevels { get; set; }
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
        /// <summary>
        /// 人员
        /// </summary>
        public DbSet<SysEmp> SysEmps { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //newsequentialid()
            //newid()
            base.OnModelCreating(modelBuilder);

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
                    Code = Guid.Parse("{4ed17c51-f905-497c-bc71-b3ede7439508}"),
                    Name = "男",
                    Spell = "N",
                    Sort = 0
                }, new ComGender
                {
                    Code = Guid.Parse("{1239d139-2932-442d-890a-e39c2d08e42e}"),
                    Name = "女",
                    Spell = "N",
                    Sort = 1
                }, new ComGender
                {
                    Code = Guid.Parse("{6965de18-f744-48f2-8fda-74b0550e5b61}"),
                    Name = "未知",
                    Spell = "WZ",
                    Sort = 2
                });
            #endregion

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
                    Code = Guid.Parse("{fa73020a-34c7-4184-b97a-299475a3acf2}"),
                    Name = "汉族",
                    Spell = "HZ",
                    Sort = 1
                }, new ComNation
                {
                    Code = Guid.Parse("{39f35af7-ca69-4f4a-ae3e-9320d739a269}"),
                    Name = "蒙古族",
                    Spell = "MGZ",
                    Sort = 2
                }, new ComNation
                {
                    Code = Guid.Parse("{440aae92-1100-4904-ba28-b8f4db7841b7}"),
                    Name = "回族",
                    Spell = "HZ",
                    Sort = 3
                }, new ComNation
                {
                    Code = Guid.Parse("{8b4498a6-9fce-405b-ac87-7d8542d731a2}"),
                    Name = "藏族",
                    Spell = "ZZ",
                    Sort = 4
                }, new ComNation
                {
                    Code = Guid.Parse("{a5fb5f27-ead2-4836-8a5a-a10c6cde8614}"),
                    Name = "维吾尔族",
                    Spell = "WWEZ",
                    Sort = 5
                }, new ComNation
                {
                    Code = Guid.Parse("{e898c2f5-c635-47be-a92e-aadb1caca42c}"),
                    Name = "苗族",
                    Spell = "MZ",
                    Sort = 6
                }, new ComNation
                {
                    Code = Guid.Parse("{fcc9f534-38c3-485e-a583-655118a7a1c6}"),
                    Name = "彝族",
                    Spell = "YZ",
                    Sort = 7
                }, new ComNation
                {
                    Code = Guid.Parse("{da2ddbad-4c2b-4d51-a5f4-a13828a194d0}"),
                    Name = "壮族",
                    Spell = "ZZ",
                    Sort = 8
                }, new ComNation
                {
                    Code = Guid.Parse("{6bb28819-5a18-4c8c-9795-940f3a43a4e6}"),
                    Name = "布依族",
                    Spell = "BYZ",
                    Sort = 9
                }, new ComNation
                {
                    Code = Guid.Parse("{69838d81-3b74-4edc-a74a-275f7331b778}"),
                    Name = "朝鲜族",
                    Spell = "CXZ",
                    Sort = 10
                }, new ComNation
                {
                    Code = Guid.Parse("{7c9d4913-0db4-49cc-a14f-36d1824b880d}"),
                    Name = "满族",
                    Spell = "MZ",
                    Sort = 11
                }, new ComNation
                {
                    Code = Guid.Parse("{e22e25e1-f2b9-4fe7-b6ed-ca7e4e2c7cce}"),
                    Name = "侗族",
                    Spell = "DZ",
                    Sort = 12
                }, new ComNation
                {
                    Code = Guid.Parse("{1784e543-a987-48ab-9302-a55dffbb3091}"),
                    Name = "瑶族",
                    Spell = "YZ",
                    Sort = 13
                }, new ComNation
                {
                    Code = Guid.Parse("{a207bc05-470a-402d-bef4-81d28fe8591a}"),
                    Name = "白族",
                    Spell = "BZ",
                    Sort = 14
                }, new ComNation
                {
                    Code = Guid.Parse("{3cefe580-e5a7-4acf-b323-960a389f9d09}"),
                    Name = "土家族",
                    Spell = "TJZ",
                    Sort = 15
                }, new ComNation
                {
                    Code = Guid.Parse("{739ce296-929e-49f5-b524-534b93d63093}"),
                    Name = "哈尼族",
                    Spell = "HNZ",
                    Sort = 16
                }, new ComNation
                {
                    Code = Guid.Parse("{93b12c68-1854-429e-bf60-e3a97598f94f}"),
                    Name = "哈萨克族",
                    Spell = "HSKZ",
                    Sort = 17
                }, new ComNation
                {
                    Code = Guid.Parse("{18377f3a-fa11-4cf2-b24e-3d3693d801f2}"),
                    Name = "傣族",
                    Spell = "TZ",
                    Sort = 18
                }, new ComNation
                {
                    Code = Guid.Parse("{44b28c8d-fdab-4e8e-a80c-4d6186930657}"),
                    Name = "黎族",
                    Spell = "LZ",
                    Sort = 19
                }, new ComNation
                {
                    Code = Guid.Parse("{99c80990-e7ef-4c27-b7b6-5a79535a7a30}"),
                    Name = "傈僳族",
                    Spell = "LSZ",
                    Sort = 20
                }, new ComNation
                {
                    Code = Guid.Parse("{8849311a-4dfa-470a-bf1e-f1ffc0dcf58d}"),
                    Name = "佤族",
                    Spell = "WZ",
                    Sort = 21
                }, new ComNation
                {
                    Code = Guid.Parse("{148980da-2f38-4bc6-82d8-9c5dc5f3e707}"),
                    Name = "畲族",
                    Spell = "SZ",
                    Sort = 22
                }, new ComNation
                {
                    Code = Guid.Parse("{029888c3-98b1-425c-982b-af0b6a6a01f0}"),
                    Name = "高山族",
                    Spell = "GSZ",
                    Sort = 23
                }, new ComNation
                {
                    Code = Guid.Parse("{c9e0b370-fdaf-4dad-b77d-2fcc374875be}"),
                    Name = "拉祜族",
                    Spell = "LGZ",
                    Sort = 24
                }, new ComNation
                {
                    Code = Guid.Parse("{699cff92-189c-4a8e-8578-a8c98af39079}"),
                    Name = "水族",
                    Spell = "SZ",
                    Sort = 25
                }, new ComNation
                {
                    Code = Guid.Parse("{1da39760-019e-4a84-adad-f6e3f77b84dd}"),
                    Name = "东乡族",
                    Spell = "DXZ",
                    Sort = 26
                }, new ComNation
                {
                    Code = Guid.Parse("{8dbeeee8-5261-425d-acef-aebf23fb8b7d}"),
                    Name = "纳西族",
                    Spell = "NXZ",
                    Sort = 27
                }, new ComNation
                {
                    Code = Guid.Parse("{b31c4a21-4aaa-44a7-bf12-d73ab2e6dd76}"),
                    Name = "景颇族",
                    Spell = "JPZ",
                    Sort = 28
                }, new ComNation
                {
                    Code = Guid.Parse("{60997bba-f2c3-4710-a0a9-140601b435e5}"),
                    Name = "柯尔克孜族",
                    Spell = "HEKZZ",
                    Sort = 29
                }, new ComNation
                {
                    Code = Guid.Parse("{afd2a2cd-8029-4f03-b071-a12822d7d3ac}"),
                    Name = "土族",
                    Spell = "TZ",
                    Sort = 30
                }, new ComNation
                {
                    Code = Guid.Parse("{472adc6e-0f4f-4221-8e21-2a46566320ee}"),
                    Name = "达斡尔族",
                    Spell = "DWEZ",
                    Sort = 31
                }, new ComNation
                {
                    Code = Guid.Parse("{85442118-dc9f-40b1-bdd9-eb08424533bb}"),
                    Name = "仫佬族",
                    Spell = "MLZ",
                    Sort = 32
                }, new ComNation
                {
                    Code = Guid.Parse("{bb06e5ab-7a9f-4db7-b3ae-ce20e016b1c9}"),
                    Name = "羌族",
                    Spell = "QZ",
                    Sort = 33
                }, new ComNation
                {
                    Code = Guid.Parse("{8bb0135c-a498-4dc3-9851-22c17f05bbbc}"),
                    Name = "布朗族",
                    Spell = "BLZ",
                    Sort = 34
                }, new ComNation
                {
                    Code = Guid.Parse("{ab6c2109-4b1f-4207-acff-fa805acef4b8}"),
                    Name = "撒拉族",
                    Spell = "LSZ",
                    Sort = 35
                }, new ComNation
                {
                    Code = Guid.Parse("{6610beb1-5511-49b8-9153-edc99c0b71ef}"),
                    Name = "毛难族",
                    Spell = "MNZ",
                    Sort = 36
                }, new ComNation
                {
                    Code = Guid.Parse("{70cc70fd-ceb4-43ba-aa3f-152f17f6f122}"),
                    Name = "仡佬族",
                    Spell = "QLZ",
                    Sort = 37
                }, new ComNation
                {
                    Code = Guid.Parse("{dabe2845-a3d2-49cb-a79d-23c8d3706799}"),
                    Name = "锡伯族",
                    Spell = "XBZ",
                    Sort = 38
                }, new ComNation
                {
                    Code = Guid.Parse("{ff298f9e-8e06-45c1-92b0-cbb9b2bb927e}"),
                    Name = "阿昌族",
                    Spell = "ACZ",
                    Sort = 39
                }, new ComNation
                {
                    Code = Guid.Parse("{ae5dc612-6391-4e1e-b130-ef20550fbd59}"),
                    Name = "普米族",
                    Spell = "PMZ",
                    Sort = 40
                }, new ComNation
                {
                    Code = Guid.Parse("{6d411a8c-1718-4b7a-be0b-55556b769c47}"),
                    Name = "塔吉克族",
                    Spell = "TJKZ",
                    Sort = 41
                }, new ComNation
                {
                    Code = Guid.Parse("{04bb0315-d083-45fc-a0f4-698ddf1b9434}"),
                    Name = "怒族",
                    Spell = "NZ",
                    Sort = 42
                }, new ComNation
                {
                    Code = Guid.Parse("{36f82694-3116-4ba2-8622-001d20696482}"),
                    Name = "乌孜别克族",
                    Spell = "WZBKZ",
                    Sort = 43
                }, new ComNation
                {
                    Code = Guid.Parse("{1c60173f-fdc1-4c03-976e-097dae1988c2}"),
                    Name = "俄罗斯族",
                    Spell = "ELSZ",
                    Sort = 44
                }, new ComNation
                {
                    Code = Guid.Parse("{df2646b2-d58b-41b5-b394-5346eac5be30}"),
                    Name = "鄂温克族",
                    Spell = "EWKZ",
                    Sort = 45
                }, new ComNation
                {
                    Code = Guid.Parse("{95307031-a2db-4db4-ba25-8486aa168884}"),
                    Name = "崩龙族",
                    Spell = "BLZ",
                    Sort = 46
                }, new ComNation
                {
                    Code = Guid.Parse("{73fc699c-9ba1-45bb-856f-7bc83c9882a8}"),
                    Name = "保安族",
                    Spell = "BAZ",
                    Sort = 47
                }, new ComNation
                {
                    Code = Guid.Parse("{9b799028-8cea-407c-abf6-bb48eab1a1be}"),
                    Name = "裕固族",
                    Spell = "YGZ",
                    Sort = 48
                }, new ComNation
                {
                    Code = Guid.Parse("{37c3894e-fd12-4c9f-b710-1d2ebf2b04fb}"),
                    Name = "京族",
                    Spell = "JZ",
                    Sort = 49
                }, new ComNation
                {
                    Code = Guid.Parse("{3be52581-5867-43be-9485-a5f4ea58c01c}"),
                    Name = "塔塔尔族",
                    Spell = "TTEZ",
                    Sort = 50
                }, new ComNation
                {
                    Code = Guid.Parse("{91ad8b74-c8bf-4559-9f97-cbdbdc62a9fa}"),
                    Name = "独龙族",
                    Spell = "DLZ",
                    Sort = 51
                }, new ComNation
                {
                    Code = Guid.Parse("{2ec1293a-8faf-4ef6-b953-50ebfa40946f}"),
                    Name = "鄂伦春族",
                    Spell = "ELCZ",
                    Sort = 52
                }, new ComNation
                {
                    Code = Guid.Parse("{42e82614-c05c-4d4b-9e61-86a6d4814a69}"),
                    Name = "赫哲族",
                    Spell = "HZZ",
                    Sort = 53
                }, new ComNation
                {
                    Code = Guid.Parse("{c254c578-a208-4f03-8e05-333231483be0}"),
                    Name = "门巴族",
                    Spell = "MBZ",
                    Sort = 54
                }, new ComNation
                {
                    Code = Guid.Parse("{012098a9-b959-4b85-9b46-7a2989de5220}"),
                    Name = "珞巴族",
                    Spell = "LBZ",
                    Sort = 55
                }, new ComNation
                {
                    Code = Guid.Parse("{4bb6d9d1-9c69-418a-b43f-d4c086c83b6e}"),
                    Name = "基诺族",
                    Spell = "JNZ",
                    Sort = 56
                }, new ComNation
                {
                    Code = Guid.Parse("{a4fde996-5323-42e1-b6ac-f78f327e1956}"),
                    Name = "其他",
                    Spell = "QT",
                    Sort = 57
                }, new ComNation
                {
                    Code = Guid.Parse("{fc1da09e-6f80-4026-bf30-0253d6f478d2}"),
                    Name = "外国血统中国人士",
                    Spell = "WGXTZGRS",
                    Sort = 58
                });
            #endregion

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
                    Code = Guid.Parse("{bfb813cc-d206-4194-b5ec-3f77d5375afd}"),
                    Name = "中共党员",
                    Spell = "ZGDY",
                    Sort = 0
                }, new ComPolitical
                {
                    Code = Guid.Parse("{0946c126-d488-4912-87f0-55465b25f25a}"),
                    Name = "中共预备党员",
                    Spell = "ZGYBDY",
                    Sort = 1
                }, new ComPolitical
                {
                    Code = Guid.Parse("{0a3bcdbd-eaf3-4be0-8588-3a27932e1a02}"),
                    Name = "共青团员",
                    Spell = "GQTY",
                    Sort = 2
                }, new ComPolitical
                {
                    Code = Guid.Parse("{b51e1624-700e-4c40-8ead-5982e13b5c41}"),
                    Name = "民革党员",
                    Spell = "MGDY",
                    Sort = 3
                }, new ComPolitical
                {
                    Code = Guid.Parse("{3a8150ce-7d92-49ee-8baa-c4a97a52f4ab}"),
                    Name = "民盟盟员",
                    Spell = "MMMY",
                    Sort = 4
                }, new ComPolitical
                {
                    Code = Guid.Parse("{2cf2bc45-5f9d-4933-bf17-e958edf7baf2}"),
                    Name = "民建会员",
                    Spell = "MJHY",
                    Sort = 5
                }, new ComPolitical
                {
                    Code = Guid.Parse("{6f8bc9e5-9922-4d6d-8b1c-de37ed99095d}"),
                    Name = "民进会员",
                    Spell = "MJHY",
                    Sort = 6
                }, new ComPolitical
                {
                    Code = Guid.Parse("{fc85bcb0-c7e9-4a5a-bb3e-fd615bbe445a}"),
                    Name = "农工党党员",
                    Spell = "NGDDY",
                    Sort = 7
                }, new ComPolitical
                {
                    Code = Guid.Parse("{0797e976-5395-40da-b26b-904ac7ee727e}"),
                    Name = "致公党党员",
                    Spell = "ZGDDY",
                    Sort = 8
                }, new ComPolitical
                {
                    Code = Guid.Parse("{e8f2d009-dfa0-4da3-b21a-221f01ae505f}"),
                    Name = "九三学社社员",
                    Spell = "JSXSSY",
                    Sort = 9
                }, new ComPolitical
                {
                    Code = Guid.Parse("{d383e7b1-acd0-449e-90f0-9ca5d14a1e2f}"),
                    Name = "台盟盟员",
                    Spell = "WMMY",
                    Sort = 10
                }, new ComPolitical
                {
                    Code = Guid.Parse("{f39fe8b3-bb55-4b58-a0d9-f97b1ab08e7c}"),
                    Name = "无党派人士",
                    Spell = "WDPRS",
                    Sort = 11
                }, new ComPolitical
                {
                    Code = Guid.Parse("{8e871348-b291-44e3-9aff-534cfe8eb4cf}"),
                    Name = "群众",
                    Spell = "QZ",
                    Sort = 12
                });
            #endregion

            #region 职称系类
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
                    Code = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Name = "卫生系类",
                    Spell = "WSXL",
                    Sort = 0
                }, new ComGender
                {
                    Code = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Name = "教育系类",
                    Spell = "JYXL",
                    Sort = 1
                }, new ComGender
                {
                    Code = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Name = "科研系类",
                    Spell = "KYXL",
                    Sort = 2
                }, new ComGender
                {
                    Code = Guid.Parse("{c42a2431-f494-4d4a-8630-aa0aadfed732}"),
                    Name = "经济系类",
                    Spell = "JJXL",
                    Sort = 3
                }, new ComGender
                {
                    Code = Guid.Parse("{75e47af6-29cf-4ae4-8196-911421d9bcd7}"),
                    Name = "会计系类",
                    Spell = "KJXL",
                    Sort = 4
                }, new ComGender
                {
                    Code = Guid.Parse("{d0008f26-cb2c-4358-b453-a2db0f6f98eb}"),
                    Name = "统计系类",
                    Spell = "TJXL",
                    Sort = 5
                }, new ComGender
                {
                    Code = Guid.Parse("{926c3d44-be36-40f1-ad89-708b99019be1}"),
                    Name = "图书资料、档案系类",
                    Spell = "TSZLDAXL",
                    Sort = 6
                }, new ComGender
                {
                    Code = Guid.Parse("{c16f3f64-f81d-41b3-b61f-08a23bd6aa73}"),
                    Name = "政工系类",
                    Spell = "ZGXL",
                    Sort = 7
                }, new ComGender
                {
                    Code = Guid.Parse("{7e5750ba-2e20-4725-9681-6ff94d8fdd6a}"),
                    Name = "其他系类",
                    Spell = "QTXL",
                    Sort = 8
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
            });
            modelBuilder.Entity<ComProfessionTitle>()
                .HasData(new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{33dc189d-14ba-4620-8e22-6a4fff134ec5}"),
                    Name = "主任医师",
                    Spell = "ZRYS",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{460ae8b4-339d-473d-af06-f6dcc11e1682}"),
                    Name = "主任中医师",
                    Spell = "ZRZYS",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{98e5d73d-32a6-4fab-b24f-2955faf40c68}"),
                    Name = "主任技师",
                    Spell = "ZRJS",
                    Sort = 2
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{950f633b-1485-4ad3-8e11-cde412f7a930}"),
                    Name = "主任药师",
                    Spell = "ZRYS",
                    Sort = 3
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{f4957e1a-f0f7-49f1-845c-85133310e887}"),
                    Name = "主任护师",
                    Spell = "ZRHS",
                    Sort = 4
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{75080753-7c7f-4342-b4e5-a71de5343b43}"),
                    Name = "副主任医师",
                    Spell = "FZRYS",
                    Sort = 5
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{9c744d23-50ef-4824-beba-3a27fab3b057}"),
                    Name = "副主任中医师",
                    Spell = "FZRZYS",
                    Sort = 6
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{3bca3114-26fd-41a8-a744-32c251a4bb9f}"),
                    Name = "副主任技师",
                    Spell = "FZFJS",
                    Sort = 7
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{1c8cccdc-d6ce-4eb6-a8c9-d97a14fd5e81}"),
                    Name = "副主任药师",
                    Spell = "FZRYS",
                    Sort = 8
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{0e12dd40-52d7-4a4e-ae5b-a9d9b744ccc3}"),
                    Name = "副主任护师",
                    Spell = "FZRHS",
                    Sort = 9
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{5f15d90b-0823-4f15-b421-0101f8a9fe74}"),
                    Name = "主治医师",
                    Spell = "ZZYS",
                    Sort = 10
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{cb08629f-533d-4c02-9045-5d24d1711141}"),
                    Name = "主治中医师",
                    Spell = "ZZZYS",
                    Sort = 11
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{19fbcab1-165c-4062-9a95-40399986b9b1}"),
                    Name = "主管医师",
                    Spell = "ZGYS",
                    Sort = 12
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{439dfe16-4631-4975-9bdc-e5f50bffe388}"),
                    Name = "主管技师",
                    Spell = "ZGJS",
                    Sort = 13
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{a09a94f2-0df4-48e1-a83d-c8aa80120483}"),
                    Name = "主管药师",
                    Spell = "ZGYS",
                    Sort = 14
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{bafd2df1-7958-4155-b612-021cd42f8df5}"),
                    Name = "主管护师",
                    Spell = "ZHHS",
                    Sort = 15
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{aeb2c2df-5326-4da4-b7ad-27ade67bae1c}"),
                    Name = "主管检验师",
                    Spell = "ZHJYS",
                    Sort = 16
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{5e72264f-6219-407c-839e-a8f49df6bd68}"),
                    Name = "医师",
                    Spell = "YS",
                    Sort = 17
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{e9012270-bfe3-4599-abac-18b4bc954096}"),
                    Name = "中医师",
                    Spell = "ZYS",
                    Sort = 18
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{2ca803a7-4bf2-4c48-9167-e55674369f11}"),
                    Name = "技师",
                    Spell = "JS",
                    Sort = 19
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{7ac7a6a2-c06e-420e-86df-ecada3e709b5}"),
                    Name = "药师",
                    Spell = "YS",
                    Sort = 20
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{7e619b31-9ee8-47d1-b99f-190c74ee415b}"),
                    Name = "护师",
                    Spell = "HS",
                    Sort = 21
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{33e6530c-463d-434e-906e-fbeb1571d4e2}"),
                    Name = "检验师",
                    Spell = "JYS",
                    Sort = 22
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{237878a4-8806-46e4-bba8-6d27b295ad04}"),
                    Name = "医士",
                    Spell = "YS",
                    Sort = 23
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{63f3ad97-4573-449b-a597-3a3ce59410d4}"),
                    Name = "中医士",
                    Spell = "ZYS",
                    Sort = 24
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{b691b596-2ce0-41a0-9ff4-e6bda7b1bf3b}"),
                    Name = "技士",
                    Spell = "JS",
                    Sort = 25
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{6153ad42-5259-417f-98e5-6ef422794783}"),
                    Name = "药士",
                    Spell = "YS",
                    Sort = 26
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{c6b5aee3-2a08-4464-bf87-1dc1d4c7c918}"),
                    Name = "护士",
                    Spell = "HS",
                    Sort = 27
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{aac08e05-729f-4302-9422-8c02de47b1ce}"),
                    Name = "检验士",
                    Spell = "JYS",
                    Sort = 28
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{b9bbcf12-f2c7-48e1-9ece-12068ac58768}"),
                    Code = Guid.Parse("{c6ceb754-ef08-4fb8-a400-7d62be2b7bfa}"),
                    Name = "康复技师",
                    Spell = "KFJS",
                    Sort = 29
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{086596cb-7d75-4f4f-bd6f-3d0cb76dc187}"),
                    Name = "教授",
                    Spell = "JS",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{ddbd015d-157f-4e4f-9599-6ca8ecceeb1a}"),
                    Name = "副教授",
                    Spell = "FJS",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{9cd16a0f-e822-4759-92cd-2e4ff3dc0409}"),
                    Name = "高校",
                    Spell = "HX",
                    Sort = 2
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{3cffe618-a011-407c-a365-090a8ab4f3b3}"),
                    Name = "高校讲师",
                    Spell = "GXJS",
                    Sort = 3
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{d620100d-4ab9-49ea-be27-be3fe5e13b6d}"),
                    Name = "助教师",
                    Spell = "ZJS",
                    Sort = 4
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{6d0c0f7e-d7c2-43d0-a8e8-adfa70269b06}"),
                    Name = "高级实验师",
                    Spell = "GJSYS",
                    Sort = 5
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{ef37a716-912c-40c2-9d38-492dc9f7fbe9}"),
                    Name = "实验师",
                    Spell = "SYS",
                    Sort = 6
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{1bb904d7-0bdd-407a-83f8-5c1097bd691d}"),
                    Name = "助理实验师",
                    Spell = "ZYSYS",
                    Sort = 7
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{ce0a4935-64a3-4cf7-a69f-d1625320df62}"),
                    Name = "实验员",
                    Spell = "SYY",
                    Sort = 8
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{96bad221-fb35-4aef-aa03-ace7c4330bbc}"),
                    Name = "高级讲师",
                    Spell = "GJJS",
                    Sort = 9
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{94f248f6-688b-4166-bd11-e6b604fd2c63}"),
                    Name = "中专",
                    Spell = "ZZ",
                    Sort = 10
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{3765a4a0-b4d4-4071-a479-922be78b1e11}"),
                    Name = "中专讲师",
                    Spell = "ZZJS",
                    Sort = 11
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{838ba990-64f9-48c4-b76f-655f9c36b659}"),
                    Name = "中专助理讲师",
                    Spell = "ZZZLJS",
                    Sort = 12
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{8c4bd57d-f82a-4146-9690-b48e59344ca7}"),
                    Name = "教员",
                    Spell = "JY",
                    Sort = 13
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{6dd3009f-2b73-4bc5-a2cf-d9ea18433164}"),
                    Code = Guid.Parse("{099e5ab4-490b-4515-84bf-b62083cef245}"),
                    Name = "高级实习指导教师",
                    Spell = "GJSXZDJS",
                    Sort = 14
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Code = Guid.Parse("{22c909c5-90c9-4b3f-9a5a-d3c3cf8867ea}"),
                    Name = "研究员",
                    Spell = "YJY",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Code = Guid.Parse("{3c0b06e1-7b9d-4d3c-ba0d-5b2cc119cffb}"),
                    Name = "副研究员",
                    Spell = "FYJY",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Code = Guid.Parse("{e103f06e-0490-4b20-8d13-c4334b60064b}"),
                    Name = "助理研究员",
                    Spell = "ZLYJY",
                    Sort = 2
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Code = Guid.Parse("{790d860f-1e65-4ee2-98da-32a566c9c62a}"),
                    Name = "研究实习员",
                    Spell = "YJSXY",
                    Sort = 3
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Code = Guid.Parse("{219ca71e-a002-4d03-835e-863924d19c02}"),
                    Name = "高级实验师",
                    Spell = "GJSYS",
                    Sort = 4
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Code = Guid.Parse("{b28f28e4-847a-4415-8dac-e90b85fdc10b}"),
                    Name = "实验师",
                    Spell = "SYS",
                    Sort = 5
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Code = Guid.Parse("{dba904de-f9ab-485d-8dea-f62f7bcedcc6}"),
                    Name = "助理实验师",
                    Spell = "ZLSYS",
                    Sort = 6
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{115dd3eb-2a72-42e3-8159-39f1faf17383}"),
                    Code = Guid.Parse("{68d4be22-bef4-45f0-b856-fb75b73dcaee}"),
                    Name = "实验员",
                    Spell = "SYY",
                    Sort = 7
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{c42a2431-f494-4d4a-8630-aa0aadfed732}"),
                    Code = Guid.Parse("{6f870edf-1b2d-4d30-b57d-ee92de3777a3}"),
                    Name = "高级经济师",
                    Spell = "GJJJS",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{c42a2431-f494-4d4a-8630-aa0aadfed732}"),
                    Code = Guid.Parse("{ce930318-166a-4f4e-960b-d5930fdb4355}"),
                    Name = "经济师",
                    Spell = "JJS",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{c42a2431-f494-4d4a-8630-aa0aadfed732}"),
                    Code = Guid.Parse("{dbf55f3b-783d-48eb-a8c1-66a5c10c6a50}"),
                    Name = "助理经济师",
                    Spell = "ZLJJS",
                    Sort = 2
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{c42a2431-f494-4d4a-8630-aa0aadfed732}"),
                    Code = Guid.Parse("{8d55d48b-717a-477d-afd3-aba3f2f6d1c7}"),
                    Name = "经济员",
                    Spell = "JJY",
                    Sort = 3
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{75e47af6-29cf-4ae4-8196-911421d9bcd7}"),
                    Code = Guid.Parse("{d88f93a7-f3ed-4f5c-bf09-22f9e4a241b7}"),
                    Name = "高级会计师",
                    Spell = "GJKJS",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{75e47af6-29cf-4ae4-8196-911421d9bcd7}"),
                    Code = Guid.Parse("{99c7857e-4f60-4ff1-8fbf-861c02e23215}"),
                    Name = "会计师",
                    Spell = "KJS",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{75e47af6-29cf-4ae4-8196-911421d9bcd7}"),
                    Code = Guid.Parse("{cd5327f8-34d1-40ee-a5bc-2735d2f538a4}"),
                    Name = "助理会计师",
                    Spell = "ZLKJS",
                    Sort = 2
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{75e47af6-29cf-4ae4-8196-911421d9bcd7}"),
                    Code = Guid.Parse("{1371bd32-0166-48f4-a51b-948a67615b33}"),
                    Name = "会计员",
                    Spell = "KJY",
                    Sort = 3
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{d0008f26-cb2c-4358-b453-a2db0f6f98eb}"),
                    Code = Guid.Parse("{fece040b-e1bb-4879-954c-77cedefa95d9}"),
                    Name = "高级统计师",
                    Spell = "GJTJS",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{d0008f26-cb2c-4358-b453-a2db0f6f98eb}"),
                    Code = Guid.Parse("{ac78b34c-58a6-4ce9-be4a-2372954a26c9}"),
                    Name = "统计师",
                    Spell = "TJS",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{d0008f26-cb2c-4358-b453-a2db0f6f98eb}"),
                    Code = Guid.Parse("{4f17cede-3bf8-452d-b4d4-5df4d33f7761}"),
                    Name = "助理统计师",
                    Spell = "ZLTJS",
                    Sort = 2
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{d0008f26-cb2c-4358-b453-a2db0f6f98eb}"),
                    Code = Guid.Parse("{e02a9038-f34c-4689-a974-2e2d6ddf24af}"),
                    Name = "统计员",
                    Spell = "TJY",
                    Sort = 3
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{926c3d44-be36-40f1-ad89-708b99019be1}"),
                    Code = Guid.Parse("{dd1d83ed-1ad9-4a16-ab01-1f7be621bc33}"),
                    Name = "研究馆员",
                    Spell = "YJGY",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{926c3d44-be36-40f1-ad89-708b99019be1}"),
                    Code = Guid.Parse("{0d6e7ea7-7acf-4cce-b69c-8fe80e535e0b}"),
                    Name = "副研究馆员",
                    Spell = "FYJGY",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{926c3d44-be36-40f1-ad89-708b99019be1}"),
                    Code = Guid.Parse("{ce49e7b2-836c-4dba-91fd-95407b1bb5fa}"),
                    Name = "馆员",
                    Spell = "GY",
                    Sort = 2
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{926c3d44-be36-40f1-ad89-708b99019be1}"),
                    Code = Guid.Parse("{1f902e95-df06-4f28-93ed-d455a33f7285}"),
                    Name = "助理馆员",
                    Spell = "ZLGY",
                    Sort = 3
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{926c3d44-be36-40f1-ad89-708b99019be1}"),
                    Code = Guid.Parse("{aa7113d7-cdcd-40ae-ad64-0cd5f3ef5f87}"),
                    Name = "管理员",
                    Spell = "GLY",
                    Sort = 4
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{c16f3f64-f81d-41b3-b61f-08a23bd6aa73}"),
                    Code = Guid.Parse("{0ba1d0b8-8a31-470f-be37-d837898764b3}"),
                    Name = "政工师",
                    Spell = "ZGS",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{c16f3f64-f81d-41b3-b61f-08a23bd6aa73}"),
                    Code = Guid.Parse("{405f20a8-923b-435a-9472-de2a5a8c3d67}"),
                    Name = "助理政工师",
                    Spell = "ZLZGS",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{7e5750ba-2e20-4725-9681-6ff94d8fdd6a}"),
                    Code = Guid.Parse("{cdb2590f-63e0-4b5c-984b-3ce04f8503b0}"),
                    Name = "正高级",
                    Spell = "ZGJ",
                    Sort = 0
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{7e5750ba-2e20-4725-9681-6ff94d8fdd6a}"),
                    Code = Guid.Parse("{d6af50a0-b8c9-444e-96d0-64a18ca72f6f}"),
                    Name = "副高级",
                    Spell = "FGJ",
                    Sort = 1
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{7e5750ba-2e20-4725-9681-6ff94d8fdd6a}"),
                    Code = Guid.Parse("{3a5b1b36-afc1-4785-8407-9033b9917bf8}"),
                    Name = "中级",
                    Spell = "ZJ",
                    Sort = 2
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{7e5750ba-2e20-4725-9681-6ff94d8fdd6a}"),
                    Code = Guid.Parse("{523fc67a-2ee8-47a9-ba63-06568a8438e7}"),
                    Name = "初级师",
                    Spell = "CJS",
                    Sort = 3
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{7e5750ba-2e20-4725-9681-6ff94d8fdd6a}"),
                    Code = Guid.Parse("{e3c937f9-ab25-48cc-aa68-9c65ba0773cc}"),
                    Name = "初级士",
                    Spell = "CJS",
                    Sort = 4
                }, new ComProfessionTitle
                {
                    TypeCode = Guid.Parse("{7e5750ba-2e20-4725-9681-6ff94d8fdd6a}"),
                    Code = Guid.Parse("{da6e8b06-5357-4624-bc58-7418e5698a61}"),
                    Name = "无职称",
                    Spell = "WZC",
                    Sort = 5
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
            modelBuilder.Entity<ComProfessionTitleLevel>()
                .HasData(new ComProfessionTitleLevel
                {
                    Code = Guid.Parse("{edd3fb2f-72d0-49d3-913c-7bd84ffbac8a}"),
                    Name = "正高",
                    Spell = "ZG",
                    Sort = 0
                }, new ComProfessionTitleLevel
                {
                    Code = Guid.Parse("{015d99f7-4047-4e61-aa07-f3a82bcb28d0}"),
                    Name = "副高",
                    Spell = "FG",
                    Sort = 1
                }, new ComProfessionTitleLevel
                {
                    Code = Guid.Parse("{ec5255e3-c9f9-4344-998f-c580bcc50396}"),
                    Name = "中级",
                    Spell = "ZJ",
                    Sort = 2
                }, new ComProfessionTitleLevel
                {
                    Code = Guid.Parse("{ce195af7-81e0-4da6-8830-5bcbc6df2565}"),
                    Name = "初级(师)",
                    Spell = "CJS",
                    Sort = 3
                }, new ComProfessionTitleLevel
                {
                    Code = Guid.Parse("{eb15f2bc-c230-4b34-8af1-c91155f6191d}"),
                    Name = "初级(士)",
                    Spell = "CJS",
                    Sort = 4
                }, new ComProfessionTitleLevel
                {
                    Code = Guid.Parse("{de31986e-ce59-41df-9241-d9e7e2b95b65}"),
                    Name = "正科",
                    Spell = "ZK",
                    Sort = 5
                }, new ComProfessionTitleLevel
                {
                    Code = Guid.Parse("{a45a8438-8d9f-4914-bd03-f76067605ed2}"),
                    Name = "副科",
                    Spell = "FK",
                    Sort = 6
                }, new ComProfessionTitleLevel
                {
                    Code = Guid.Parse("{52fbd086-2406-44d1-a754-15d3c3d77311}"),
                    Name = "无",
                    Spell = "W",
                    Sort = 7
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
            modelBuilder.Entity<ComGender>()
                .HasData(new ComGender
                {
                    Code = Guid.Parse("{d4d91cd2-c266-40b5-9954-667775688c0c}"),
                    Name = "院长",
                    Spell = "YZ",
                    Sort = 0
                }, new ComGender
                {
                    Code = Guid.Parse("{b014c913-c1aa-4fa3-a605-29f9bf2f0b2a}"),
                    Name = "副院长",
                    Spell = "FYZ",
                    Sort = 1
                }, new ComGender
                {
                    Code = Guid.Parse("{63696193-1183-43ca-b928-76829cefea8f}"),
                    Name = "书记",
                    Spell = "SJ",
                    Sort = 2
                }, new ComGender
                {
                    Code = Guid.Parse("{88cc33ab-d2e0-4394-aeca-7518cf0fe271}"),
                    Name = "副书记",
                    Spell = "FSJ",
                    Sort = 3
                }, new ComGender
                {
                    Code = Guid.Parse("{3255f4c2-d19e-42be-abb9-d94487028c4a}"),
                    Name = "大科主任",
                    Spell = "DKZR",
                    Sort = 4
                }, new ComGender
                {
                    Code = Guid.Parse("{64af3319-bb44-4e37-babd-14b1f5fc77e2}"),
                    Name = "科主任",
                    Spell = "KZR",
                    Sort = 5
                }, new ComGender
                {
                    Code = Guid.Parse("{6eda1aa1-6357-4d47-a206-db27bdcc6c9c}"),
                    Name = "副主任",
                    Spell = "FZR",
                    Sort = 6
                }, new ComGender
                {
                    Code = Guid.Parse("{c96d3c49-52fc-485c-b26d-d6bcbb94a498}"),
                    Name = "护士长",
                    Spell = "HSZ",
                    Sort = 7
                }, new ComGender
                {
                    Code = Guid.Parse("{d2d44ea1-ed45-4752-888f-7c5160606d7e}"),
                    Name = "副护士长",
                    Spell = "FHSZ",
                    Sort = 8
                }, new ComGender
                {
                    Code = Guid.Parse("{8a79102f-fc47-4b1f-86a2-b3cdd1390c43}"),
                    Name = "科员",
                    Spell = "KY",
                    Sort = 9
                }, new ComGender
                {
                    Code = Guid.Parse("{d9336f78-0a8f-4d4c-bbd6-4ad7fa5faf05}"),
                    Name = "书记",
                    Spell = "SJ",
                    Sort = 10
                }, new ComGender
                {
                    Code = Guid.Parse("{e850c859-13c2-46c0-9099-ce1ec1a5ad8d}"),
                    Name = "科长",
                    Spell = "KZ",
                    Sort = 11
                }, new ComGender
                {
                    Code = Guid.Parse("{5ce1b9cd-4097-411d-b210-a1199754952f}"),
                    Name = "干事",
                    Spell = "GS",
                    Sort = 12
                }, new ComGender
                {
                    Code = Guid.Parse("{bcc3c10e-b26f-4896-8994-2b6f5147d99e}"),
                    Name = "团委书记",
                    Spell = "TWSJ",
                    Sort = 13
                }, new ComGender
                {
                    Code = Guid.Parse("{f6b0611f-a790-4ecd-b525-9d2934f24dad}"),
                    Name = "团委副书记",
                    Spell = "TWFSJ",
                    Sort = 14
                }, new ComGender
                {
                    Code = Guid.Parse("{7c90c44f-d16c-4325-b650-fac1597e764e}"),
                    Name = "返聘",
                    Spell = "FP",
                    Sort = 15
                }, new ComGender
                {
                    Code = Guid.Parse("{dc4a63b1-5153-4cac-852c-78f14e06c080}"),
                    Name = "无",
                    Spell = "W",
                    Sort = 16
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
            modelBuilder.Entity<SysEmpType>()
                .HasData(new SysEmpType
                {
                    Code = Guid.Parse("{15133f9d-5ae0-46ca-9642-1237af79b639}"),
                    Name = "在编人员",
                    Spell = "ZBRY",
                    Sort = 0
                }, new SysEmpType
                {
                    Code = Guid.Parse("{e1a088eb-5114-45db-b767-db449ceb3345}"),
                    Name = "人事代理",
                    Spell = "RSDL",
                    Sort = 1
                }, new SysEmpType
                {
                    Code = Guid.Parse("{25d20c69-1540-4702-88a9-394c4a56cd95}"),
                    Name = "临时人员",
                    Spell = "LSRY",
                    Sort = 2
                }, new SysEmpType
                {
                    Code = Guid.Parse("{5032367a-9e64-4708-bb0d-060995c22c40}"),
                    Name = "离退人员",
                    Spell = "LTRY",
                    Sort = 3
                }, new SysEmpType
                {
                    Code = Guid.Parse("{b9a55ef6-b99d-44ab-af92-e863c0371048}"),
                    Name = "辞职人员",
                    Spell = "CZRY",
                    Sort = 4
                }, new SysEmpType
                {
                    Code = Guid.Parse("{f0e25561-d0c8-4c1b-8baf-ce0d329906ae}"),
                    Name = "返聘人员",
                    Spell = "FPRY",
                    Sort = 5
                }, new SysEmpType
                {
                    Code = Guid.Parse("{e9432168-1daa-4911-807a-2b148f748398}"),
                    Name = "调出人员",
                    Spell = "DCRY",
                    Sort = 6
                }, new SysEmpType
                {
                    Code = Guid.Parse("{9ee8faa1-5bee-4377-b6ab-1694f40ad36b}"),
                    Name = "除名人员",
                    Spell = "CMRY",
                    Sort = 7
                }, new SysEmpType
                {
                    Code = Guid.Parse("{463e6a2f-aa93-40e0-91ce-bca6029a81de}"),
                    Name = "实习进修",
                    Spell = "SXJX",
                    Sort = 8
                }, new SysEmpType
                {
                    Code = Guid.Parse("{1c57a981-0d22-4752-9d14-c4d634f76deb}"),
                    Name = "借出人员",
                    Spell = "JCRY",
                    Sort = 9
                }, new SysEmpType
                {
                    Code = Guid.Parse("{55dbe649-2b06-4aa8-8b76-5cd9e16f32e6}"),
                    Name = "长期出国人员",
                    Spell = "CQCGRY",
                    Sort = 10
                }, new SysEmpType
                {
                    Code = Guid.Parse("{9388085e-1475-4e06-af82-21e4a76b9966}"),
                    Name = "自动离职人员",
                    Spell = "ZDLZRY",
                    Sort = 11
                }, new SysEmpType
                {
                    Code = Guid.Parse("{bfbd9ff8-07e3-4135-a0b8-7b40b7202ce5}"),
                    Name = "停薪留职人员",
                    Spell = "TXLZRY",
                    Sort = 12
                }, new SysEmpType
                {
                    Code = Guid.Parse("{81790395-43b8-40f4-b305-c738b367c413}"),
                    Name = "编外离岗人员",
                    Spell = "BWLGRY",
                    Sort = 13
                }, new SysEmpType
                {
                    Code = Guid.Parse("{dfbd42d6-8df5-4ede-9b0d-b6574e657a10}"),
                    Name = "内部退养",
                    Spell = "NBTX",
                    Sort = 14
                }, new SysEmpType
                {
                    Code = Guid.Parse("{1c20fa65-dcfc-4f72-9d3d-e7f3a749ab6b}"),
                    Name = "试用人员",
                    Spell = "SYRY",
                    Sort = 15
                });
            #endregion

            #region 人员分类
            modelBuilder.Entity<SysEmpClass>(b =>
            {
                b.ToTable("SysEmpClass");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            modelBuilder.Entity<SysEmpClass>()
                .HasData(new SysEmpClass
                {
                    Code = Guid.Parse("{d5108379-4bc2-42c6-96ea-f4f84eb728da}"),
                    Name = "医疗",
                    Spell = "YL",
                    Sort = 0
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{2c5f6589-4c07-41ad-8e62-3e28ce106e41}"),
                    Name = "护理",
                    Spell = "HL",
                    Sort = 1
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{c4fcd57c-126d-4b48-9ae8-ad5227b8385b}"),
                    Name = "医技",
                    Spell = "YJ",
                    Sort = 2
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{57e99a9f-7bb9-4cd2-8b3d-54d040d626fe}"),
                    Name = "门诊",
                    Spell = "MZ",
                    Sort = 3
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{c8d0bebe-6d93-45e6-8a78-6c9f56f9ab4e}"),
                    Name = "下乡",
                    Spell = "XX",
                    Sort = 4
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{0dbc8541-087b-456d-9ee8-ff57d5d6895f}"),
                    Name = "行政",
                    Spell = "XZ",
                    Sort = 5
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{9192472f-76d5-456a-8d78-727905c81227}"),
                    Name = "财务",
                    Spell = "CW",
                    Sort = 6
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{3eeb9567-670f-43d4-99f0-51ec51f99e87}"),
                    Name = "管理",
                    Spell = "GL",
                    Sort = 7
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{3ba23c03-ccd0-4ad6-afcf-ee04de4affb1}"),
                    Name = "计算机",
                    Spell = "JSJ",
                    Sort = 8
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{6a5aa9d2-25d7-41d2-8598-0abf6d468c74}"),
                    Name = "后勤",
                    Spell = "HQ",
                    Sort = 9
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{9acc51e4-0e74-4cfc-ba4c-513731c51fbd}"),
                    Name = "借调",
                    Spell = "JD",
                    Sort = 10
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{58f2eb1c-5976-4a7e-9fdf-e6a3a3689534}"),
                    Name = "内退",
                    Spell = "NT",
                    Sort = 11
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{a642f8cd-b5a6-4fe4-b483-e14c5a4fe5b1}"),
                    Name = "停薪留职",
                    Spell = "TXLZ",
                    Sort = 12
                }, new SysEmpClass
                {
                    Code = Guid.Parse("{a4e9fcae-ac9d-4fbd-8a04-a330176c3bf4}"),
                    Name = "不在岗",
                    Spell = "BZG",
                    Sort = 13
                });
            #endregion

            #region 岗位类别
            modelBuilder.Entity<ComPostType>(b =>
            {
                b.ToTable("ComPostType");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            modelBuilder.Entity<ComPostType>()
                .HasData(new ComPostType
                {
                    Code = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Name = "管理人员",
                    Spell = "GLRY",
                    Sort = 0
                }, new ComPostType
                {
                    Code = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Name = "专业技术人员",
                    Spell = "ZYJSRY",
                    Sort = 1
                }, new ComPostType
                {
                    Code = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Name = "工勤技能人员",
                    Spell = "GQJNRY",
                    Sort = 2
                }, new ComPostType
                {
                    Code = Guid.Parse("{3bacb485-2037-4835-8268-7cec05a8f02f}"),
                    Name = "其他从业人员",
                    Spell = "QTCYRY",
                    Sort = 3
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
            modelBuilder.Entity<ComPost>()
                .HasData(new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{03ab2e38-ad6d-4ded-b81d-f30188c3ce99}"),
                    Name = "主任医师",
                    Spell = "ZRYS",
                    Sort = 0
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{849957b2-896b-469d-8c6f-fceda4e8d0bf}"),
                    Name = "副主任医师",
                    Spell = "FZRYS",
                    Sort = 1
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{3ed375b5-8384-473d-a4f2-7b0af0a2fb83}"),
                    Name = "副主任中医师",
                    Spell = "FZRZYS",
                    Sort = 2
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{3196870a-8c69-469d-b9f9-0f2cf30ed725}"),
                    Name = "副主任药师",
                    Spell = "FZRYS",
                    Sort = 3
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{eb5aada7-b36a-4481-8913-3cdb0d6c58b1}"),
                    Name = "副主任护师",
                    Spell = "FZRHS",
                    Sort = 4
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{7a877fb5-e5c2-4e7f-98b3-90a8971fa4f2}"),
                    Name = "副主任技师",
                    Spell = "FZRJS",
                    Sort = 5
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{d7ffb990-8f9d-4b22-b3cb-7f5f7866052b}"),
                    Name = "主治医师",
                    Spell = "ZYYS",
                    Sort = 6
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{3a8968ef-8fab-4e13-9d8f-87f8dc6310c3}"),
                    Name = "主管药师",
                    Spell = "ZHYS",
                    Sort = 7
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{81c18332-d2fd-46b1-90d8-da4af2413b8f}"),
                    Name = "主管护师",
                    Spell = "ZGHS",
                    Sort = 8
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{1f04b110-c7ef-46f1-bf64-64dc1d99fa01}"),
                    Name = "主管技师",
                    Spell = "ZHJS",
                    Sort = 9
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{5e1f9469-8024-4e73-bad8-1c4a6960f1e3}"),
                    Name = "主管检验师",
                    Spell = "ZGJYS",
                    Sort = 10
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{5c8d1d42-7f7f-4310-aa81-6506a363afe5}"),
                    Name = "医师",
                    Spell = "YS",
                    Sort = 11
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{0ddc1f8a-5230-4d90-9b5b-46de37de4d94}"),
                    Name = "药师",
                    Spell = "YS",
                    Sort = 12
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{54a4aaea-d563-44cd-9f2d-df074ff29f21}"),
                    Name = "护师",
                    Spell = "HS",
                    Sort = 13
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{525fc200-ceba-4fb8-9428-d0af3e56c0dc}"),
                    Name = "技师",
                    Spell = "JS",
                    Sort = 14
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{dc49d800-e709-4168-a5ae-6bf699a7e457}"),
                    Name = "康复技师",
                    Spell = "KFJS",
                    Sort = 15
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{d7c1ff7a-2a5b-4c03-a89f-2f751668e1ec}"),
                    Name = "工人技师",
                    Spell = "GRJS",
                    Sort = 16
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{622a47d3-6f08-4ed6-b203-bb6f9c35c869}"),
                    Name = "工程师",
                    Spell = "GCS",
                    Sort = 17
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{0ae60efc-8725-430e-b661-df29e489b302}"),
                    Name = "会计师",
                    Spell = "KJS",
                    Sort = 18
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{6833c8ba-7959-4d1f-96f3-b5e6e12f460b}"),
                    Name = "经济师",
                    Spell = "JJS",
                    Sort = 19
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{21ac04c5-7dbd-4cb5-b8eb-099c1938c33b}"),
                    Name = "统计师",
                    Spell = "TJS",
                    Sort = 20
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{fe525ac1-13ac-4dde-a737-73d26f163a16}"),
                    Name = "政工师",
                    Spell = "ZGS",
                    Sort = 21
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{c33dac54-066e-46ca-aa53-f5412e89bb35}"),
                    Name = "检验师",
                    Spell = "JYS",
                    Sort = 22
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{82d40cb9-8e2e-4068-bb1e-2d2f767e0a6c}"),
                    Name = "助理工程师",
                    Spell = "ZLGCS",
                    Sort = 23
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{9f39059c-4402-4812-9b0e-0a6e21707a83}"),
                    Name = "助理会计师",
                    Spell = "ZLHJS",
                    Sort = 24
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{4a289a58-cb42-487a-9664-d3af37591c77}"),
                    Name = "助理政工师",
                    Spell = "ZLZGS",
                    Sort = 25
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{d4d15612-c315-4dff-9df1-ba4da903e175}"),
                    Name = "医士",
                    Spell = "YS",
                    Sort = 26
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{9df8d9a4-8bce-422a-b0ad-45d6624cb8a4}"),
                    Name = "药士",
                    Spell = "YS",
                    Sort = 27
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{0a3333a9-7253-4d62-b6eb-d70af16542b6}"),
                    Name = "护士",
                    Spell = "HS",
                    Sort = 28
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{fe147b9a-afd1-46b9-98bc-293932cbba7f}"),
                    Name = "技士",
                    Spell = "JS",
                    Sort = 29
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{44fd7880-c1bb-411b-94c5-a83b39fe1d70}"),
                    Name = "检验士",
                    Spell = "JYS",
                    Sort = 30
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{ec959e6f-9af0-42d6-b035-65c301b6fc14}"),
                    Name = "会计员",
                    Spell = "KJY",
                    Sort = 31
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{c95e56b0-ca72-46d6-af2e-a61a2396c3db}"),
                    Name = "经济员",
                    Spell = "JJY",
                    Sort = 32
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{5ed553e9-f45c-469f-a5c7-0635f62f6f8c}"),
                    Name = "馆员",
                    Spell = "GY",
                    Sort = 33
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{75e2ed27-a4f7-4292-997d-b0b9459c4e5c}"),
                    Name = "高级技师",
                    Spell = "GJJS",
                    Sort = 0
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{f57fab19-f03e-4720-ba03-20b25af72f56}"),
                    Name = "技师",
                    Spell = "JS",
                    Sort = 1
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{ac0566d1-263a-46a7-8624-9e227963cd82}"),
                    Name = "高级工",
                    Spell = "GJG",
                    Sort = 2
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{0de14529-b648-4747-80ac-0ff90955c852}"),
                    Name = "中级工",
                    Spell = "ZJG",
                    Sort = 3
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{dc92af6b-17b7-4589-9fa5-2cd40a557e3f}"),
                    Name = "初级工",
                    Spell = "CJG",
                    Sort = 4
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{0583a494-3fdf-4c99-a96c-c220ce71c266}"),
                    Name = "普通工",
                    Spell = "PTG",
                    Sort = 5
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{90e68bcd-7867-4558-be8e-6c9dea4c4f1a}"),
                    Name = "一级职员(正部)",
                    Spell = "YJZYZB",
                    Sort = 0
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{fb9c4306-081c-41f9-8c4c-983e416c1940}"),
                    Name = "二级职员(副部)",
                    Spell = "EJZYFB",
                    Sort = 1
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{5d74a866-7316-4251-9d9b-e9dfae651d2e}"),
                    Name = "三级职员(正厅)",
                    Spell = "SJZYZT",
                    Sort = 2
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{b94f43c1-c614-4097-9d62-70969078f250}"),
                    Name = "四级职员(副厅)",
                    Spell = "SJZYFT",
                    Sort = 3
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{b6cd168e-3bee-4073-a94f-013f61cc9a98}"),
                    Name = "五级职员(正处)",
                    Spell = "WJZYZC",
                    Sort = 4
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{0507dfdc-18a6-48e2-8907-55a18bbd9666}"),
                    Name = "六级职员(副处)",
                    Spell = "LJZYFC",
                    Sort = 5
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{030f0e56-1b35-4be7-a057-abd6b82999f5}"),
                    Name = "七级职员(正科)",
                    Spell = "QJZYZK",
                    Sort = 6
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{f0bdb9b9-c798-49f1-9e4d-cc2786c7ce46}"),
                    Name = "八级职员(副科)",
                    Spell = "BJZYFK",
                    Sort = 7
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{7f200f23-fd24-4806-a593-b3fdcfc02aa4}"),
                    Name = "九级职员(科员)",
                    Spell = "JZZYKY",
                    Sort = 8
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{22c4a3d6-a13a-412c-b91e-ea9e16e2c85e}"),
                    Name = "十级职员(办事员)",
                    Spell = "SJZYBSY",
                    Sort = 9
                }, new ComPost
                {
                    TypeCode = Guid.Parse("{3bacb485-2037-4835-8268-7cec05a8f02f}"),
                    Code = Guid.Parse("{ec7ce259-7002-473b-aaf2-23e3f9628710}"),
                    Name = "未明确职务",
                    Spell = "WMQZW",
                    Sort = 0
                });
            #endregion

            #region 岗位级别
            modelBuilder.Entity<ComPostLevel>(b =>
            {
                b.ToTable("ComPostLevel");
                b.HasKey(t => t.Code);
                b.Property(t => t.Code)
                .HasDefaultValueSql("newid()");
                b.Property(t => t.Sort)
                .HasDefaultValue(0);
            });
            modelBuilder.Entity<ComPostLevel>()
                .HasData(new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{ab66bc18-a2a8-4c72-a2e2-75e10f9a1c07}"),
                    Name = "一级职员（部级正职）",
                    Spell = "YJZYBJZZ",
                    Sort = 0
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{7b173701-fd60-49e0-b1bf-155dd8edf287}"),
                    Name = "二级职员（部级副职）",
                    Spell = "EJZYBJFZ",
                    Sort = 1
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{b9424c72-2c8a-41ef-a120-7995fac42c08}"),
                    Name = "三级职员（厅级正职）",
                    Spell = "SJZYTZYTJZZ",
                    Sort = 2
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{dff6728c-67da-4d2b-a54a-c0477c96d9c5}"),
                    Name = "四级职员（厅级副职）",
                    Spell = "SJZYTJFZ",
                    Sort = 3
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{e3d937c0-93e0-43d3-9f8e-6124c6e6a5fc}"),
                    Name = "五级职员（处级正职）",
                    Spell = "WJZYCJZZ",
                    Sort = 4
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{3b0e735a-83b9-4331-9133-ec330a696f3c}"),
                    Name = "六级职员（处级副职）",
                    Spell = "LJZYCJFZ",
                    Sort = 5
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{ff871fdf-315b-41f8-bbfd-68a1f1cd84e0}"),
                    Name = "七级职员（科级正职）",
                    Spell = "QJZYKJZZ",
                    Sort = 6
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{4668379d-3e73-469e-b731-dcd99e1768ac}"),
                    Name = "八级职员（科级副职）",
                    Spell = "BJZYKJFZ",
                    Sort = 7
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{22ea8fa3-a3e1-4c06-a04a-174b5efbe1c8}"),
                    Name = "九级职员（科员）",
                    Spell = "JJZYKY",
                    Sort = 8
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{101af3fb-5081-4d9d-ba00-578b54b16eb7}"),
                    Code = Guid.Parse("{efe18ba3-9604-4544-865f-4d3474480149}"),
                    Name = "十级职员（办事员）",
                    Spell = "SJZYBSY",
                    Sort = 9
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{8b75edbe-8b3f-413c-b92b-2f308084f3dc}"),
                    Name = "一级",
                    Spell = "YJ",
                    Sort = 0
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{b9824136-b797-456b-a429-565f157f98f6}"),
                    Name = "二级",
                    Spell = "EJ",
                    Sort = 1
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{0eaec349-c3fc-4cd8-bd0b-a5cfa53861ea}"),
                    Name = "三级",
                    Spell = "SJ",
                    Sort = 2
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{9c5282ca-c12a-4779-b3e3-3a931bcd1fb9}"),
                    Name = "四级",
                    Spell = "SJ",
                    Sort = 3
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{beb3b0c1-56d2-4135-b36c-33151b4769f1}"),
                    Name = "五级",
                    Spell = "WJ",
                    Sort = 4
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{20f8d17b-88e8-4cb5-bd81-4ca77f0a4bb7}"),
                    Name = "六级",
                    Spell = "LJ",
                    Sort = 5
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{12028e5b-4ebe-4069-8595-9d526d0b9f78}"),
                    Name = "七级",
                    Spell = "QJ",
                    Sort = 6
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{975ebb9e-5d1e-4139-b806-db62aa8f9ef5}"),
                    Name = "八级",
                    Spell = "BJ",
                    Sort = 7
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{92a854b0-dd0d-4f62-bb0d-e059d626cc8a}"),
                    Name = "九级",
                    Spell = "JJ",
                    Sort = 8
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{88bd532a-a76a-4a14-aad7-edc199ac15c2}"),
                    Name = "十级",
                    Spell = "SJ",
                    Sort = 9
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{904425eb-ddbc-4892-a0f2-28530a13cc6f}"),
                    Name = "十一级",
                    Spell = "SYJ",
                    Sort = 10
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{cd71e1cb-020d-4dad-b528-49cfa73d7262}"),
                    Name = "十二级",
                    Spell = "SEJ",
                    Sort = 11
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{2acfa7dd-84a5-4041-bc10-5ce8c252e22f}"),
                    Code = Guid.Parse("{2186f63c-9f6c-40c2-81fb-53dc0341a736}"),
                    Name = "十三级",
                    Spell = "SSJ",
                    Sort = 12
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{e289d673-b2a3-4856-a29d-ceef8a5e26b2}"),
                    Name = "一级岗位（高级技师）",
                    Spell = "YJGWGJJS",
                    Sort = 0
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{3cf258fd-e6f3-43f2-9789-ded0a0256ee5}"),
                    Name = "二级岗位（技师）",
                    Spell = "EJGWJS",
                    Sort = 1
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{36d4d0b7-7fef-46bc-9b17-e094f7629040}"),
                    Name = "三级岗位（高级工）",
                    Spell = "SJGWGJG",
                    Sort = 2
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{19c9a75c-79bf-4552-8cc4-8b56e4882385}"),
                    Name = "四级岗位（中级工）",
                    Spell = "SJGWZJG",
                    Sort = 3
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{d44d5a34-78de-44eb-a26e-9930086f793b}"),
                    Name = "五级岗位（初级工）",
                    Spell = "WJGWCJG",
                    Sort = 4
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{654bbfbf-a2d4-464a-9410-0822684eb278}"),
                    Code = Guid.Parse("{dd765fd9-879f-4fe9-9d41-7b8b6b6ba061}"),
                    Name = "普通工",
                    Spell = "PTG",
                    Sort = 5
                }, new ComPostLevel
                {
                    TypeCode = Guid.Parse("{3bacb485-2037-4835-8268-7cec05a8f02f}"),
                    Code = Guid.Parse("{6c9c57c3-9cd6-4eba-8b55-3027babbc070}"),
                    Name = "其他等级人员",
                    Spell = "QTDJRY",
                    Sort = 0
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
            modelBuilder.Entity<ComEducation>()
                .HasData(new ComEducation
                {
                    Code = Guid.Parse("{1d8c8090-7bf4-40ce-8a95-c80950dcea7e}"),
                    Name = "博士研究生",
                    Spell = "BSYJS",
                    Sort = 0
                }, new ComEducation
                {
                    Code = Guid.Parse("{dc2fcf03-b3c7-4f14-b294-f9f57302f3dd}"),
                    Name = "硕士研究生",
                    Spell = "SSYJS",
                    Sort = 1
                }, new ComEducation
                {
                    Code = Guid.Parse("{e93ea2c1-6334-4b9d-8074-2d66598f6c7d}"),
                    Name = "本科",
                    Spell = "BK",
                    Sort = 2
                }, new ComEducation
                {
                    Code = Guid.Parse("{66daa3c2-e82b-4f21-aed5-73de21a0105f}"),
                    Name = "专科",
                    Spell = "ZK",
                    Sort = 3
                }, new ComEducation
                {
                    Code = Guid.Parse("{0ef17964-a7ca-4728-82e0-7237efbad498}"),
                    Name = "中专",
                    Spell = "ZZ",
                    Sort = 4
                }, new ComEducation
                {
                    Code = Guid.Parse("{1827e6cf-d98d-444b-a4bd-c487743e41dd}"),
                    Name = "高中及以下",
                    Spell = "GZJYX",
                    Sort = 5
                }, new ComEducation
                {
                    Code = Guid.Parse("{7eff5b7f-f7f6-4a84-8a67-9478ba059db6}"),
                    Name = "技校",
                    Spell = "JX",
                    Sort = 6
                }, new ComEducation
                {
                    Code = Guid.Parse("{8da05d8f-a0bd-40b9-90dc-5e7fa4db5430}"),
                    Name = "其他",
                    Spell = "QT",
                    Sort = 7
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
            modelBuilder.Entity<ComDegree>()
                .HasData(new ComDegree
                {
                    Code = Guid.Parse("{e807cc65-1bf8-4d01-9371-8eebc9810b61}"),
                    Name = "博士后",
                    Spell = "BSH",
                    Sort = 0
                }, new ComDegree
                {
                    Code = Guid.Parse("{68be9abd-3580-4cf3-9eeb-a9715d2b9e11}"),
                    Name = "博士",
                    Spell = "BS",
                    Sort = 1
                }, new ComDegree
                {
                    Code = Guid.Parse("{1fbb0aaa-ea2e-482c-97eb-31d85f5409d9}"),
                    Name = "硕士",
                    Spell = "SS",
                    Sort = 2
                }, new ComDegree
                {
                    Code = Guid.Parse("{68bcc923-b78c-4966-9ffa-a6a53c8cf20b}"),
                    Name = "学士",
                    Spell = "XS",
                    Sort = 3
                }, new ComDegree
                {
                    Code = Guid.Parse("{6e591626-8ec5-4948-ab12-584b931ba8aa}"),
                    Name = "无",
                    Spell = "W",
                    Sort = 4
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
            modelBuilder.Entity<ComMarriage>()
                .HasData(new ComMarriage
                {
                    Code = Guid.Parse("{bd31cb22-b6e4-40e1-bd94-e18d27f4d2f5}"),
                    Name = "未婚",
                    Spell = "WH",
                    Sort = 0
                }, new ComMarriage
                {
                    Code = Guid.Parse("{92d98cf5-0bda-42f2-bf4c-381272ac7318}"),
                    Name = "已婚",
                    Spell = "YH",
                    Sort = 1
                }, new ComMarriage
                {
                    Code = Guid.Parse("{c08ea67f-14d1-492e-b3c8-15f604e6b683}"),
                    Name = "初婚",
                    Spell = "CH",
                    Sort = 2
                }, new ComMarriage
                {
                    Code = Guid.Parse("{18866208-756b-43ae-a721-3615fcd5ef1b}"),
                    Name = "再婚",
                    Spell = "ZH",
                    Sort = 3
                }, new ComMarriage
                {
                    Code = Guid.Parse("{f35fe309-94cc-4f61-8805-54b8fe0bd496}"),
                    Name = "复婚",
                    Spell = "FH",
                    Sort = 4
                }, new ComMarriage
                {
                    Code = Guid.Parse("{0a9df811-b2d2-4223-a3e6-034c133b9f0d}"),
                    Name = "丧偶",
                    Spell = "SO",
                    Sort = 5
                }, new ComMarriage
                {
                    Code = Guid.Parse("{e931bbf6-3330-4c87-bfbc-af4cd1c77ed5}"),
                    Name = "离婚",
                    Spell = "LY",
                    Sort = 6
                }, new ComMarriage
                {
                    Code = Guid.Parse("{14abcb03-7b94-4fdf-a1f5-52db5147c967}"),
                    Name = "未说明的婚姻状况",
                    Spell = "WSMDHYZK",
                    Sort = 7
                });
            #endregion
            
            #region 人员
            modelBuilder.Entity<SysEmp>(b =>
            {
                b.ToTable("SysEmp");
                b.HasKey(t => t.EmpCode);
                b.Property(t => t.IsPost)
                .HasDefaultValue(true);
                b.Property(t => t.IsStop)
                .HasDefaultValue(false);
                b.Property(t => t.BirthDate)//出生日期
                .HasDefaultValueSql("getdate()");
                b.Property(t => t.HospitalDate)//来院日期
                .HasDefaultValueSql("getdate()");
                b.Property(t => t.CreateDate)//创建日期
                .HasDefaultValueSql("getdate()");
                b.HasOne(t => t.SysDept)//科室
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.DeptCode)
                .HasConstraintName("FK_DeptCode_SysDept_SysEmp");
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
                b.HasOne(t => t.ComProfessionTitleType)//职称系类
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.ProfessionTitleTypeCode)
                .HasConstraintName("FK_PTTCode_ComProfessionTitleType_SysEmp");
                b.HasOne(t => t.ComProfessionTitle)//职称
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.ProfessionTitleCode)
                .HasConstraintName("FK_PTCode_ComProfessionTitle_SysEmp");
                b.HasOne(t => t.ComProfessionTitleLevel)//职称级别
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.ProfessionTitleLevelCode)
                .HasConstraintName("FK_PTLCode_ComProfessionTitleLevel_SysEmp");
                b.HasOne(t => t.ComAdminDuty)//行政职务
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.AdminDutyCode)
                .HasConstraintName("FK_AdminDutyCode_ComAdminDuty_SysEmp");
                b.HasOne(t => t.ComAdminDuty)//行政职务
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.AdminDutyCode)
                .HasConstraintName("FK_AdminDutyCode_ComAdminDuty_SysEmp");
                b.HasOne(t => t.SysEmpType)//人员类别
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.TypeCode)
                .HasConstraintName("FK_TypeCode_SysEmpType_SysEmp");
                b.HasOne(t => t.SysEmpClass)//人员分类
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.ClassCode)
                .HasConstraintName("FK_ClassCode_SysEmpClass_SysEmp");
                b.HasOne(t => t.SysEmpAttribute)//人员属性
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.AttributeCode)
                .HasConstraintName("FK_AttributeCode_SysEmpAttribute_SysEmp");
                b.HasOne(t => t.ComPost)//岗位
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.PostCode)
                .HasConstraintName("FK_PostCode_ComPost_SysEmp");
                b.HasOne(t => t.ComPostType)//岗位类别
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.PostTypeCode)
                .HasConstraintName("FK_PostTypeCode_ComPostType_SysEmp");
                b.HasOne(t => t.ComPostLevel)//岗位级别
                .WithMany(t => t.SysEmps)
                .HasForeignKey(t => t.PostLevelCode)
                .HasConstraintName("FK_PostLevelCode_ComPostLevel_SysEmp");
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
            });
            #endregion

        }
    }
}
