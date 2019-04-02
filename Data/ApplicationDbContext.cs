using System;
using System.Collections.Generic;
using System.Text;
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
        /// 项目表
        /// </summary>
        public DbSet<SysItem> SysItems { get; set; }
        /// <summary>
        /// 项目明细表
        /// </summary>
        public DbSet<SysItemInfo> SysItemInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SysItem>( b=> {
                b.ToTable("SysItem");
                b.HasKey(t => t.ItemCode);
                b.Property(t => t.ItemCode)
                .HasDefaultValueSql("newid()");
            });

            #region 项目
            modelBuilder.Entity<SysItem>()
                .HasData(new SysItem
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemName = "民族",
                    Spell = "MZ"
                }, new SysItem
                {
                    ItemCode = Guid.Parse("{627ebe5d-c8d4-40a0-bd19-0d2b849a21b9}"),
                    ItemName = "性别",
                    Spell = "XB"
                });
            #endregion

            modelBuilder.Entity<SysItemInfo>(b => {
                b.ToTable("SysItemInfo");
                b.HasKey(t => t.ItemKey);
                b.Property(t => t.ItemKey)
                .HasDefaultValueSql("newsequentialid()");
                b.HasOne(t => t.SysItem)
                .WithMany(t => t.SysItemInfos)
                .HasForeignKey(t => t.ItemCode)
                .HasConstraintName("FK_ItemCode_SysItem")
                .OnDelete(DeleteBehavior.Cascade);
            });

            #region 民族
            modelBuilder.Entity<SysItemInfo>()
                .HasData(new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000001}"),
                    ItemValue = "汉族",
                    Spell = "HZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000002}"),
                    ItemValue = "蒙古族",
                    Spell = "MGZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000003}"),
                    ItemValue = "回族",
                    Spell = "HZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000004}"),
                    ItemValue = "藏族",
                    Spell = "ZZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000005}"),
                    ItemValue = "维吾尔族",
                    Spell = "WWEZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000006}"),
                    ItemValue = "苗族",
                    Spell = "MZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000007}"),
                    ItemValue = "彝族",
                    Spell = "YZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000008}"),
                    ItemValue = "壮族",
                    Spell = "ZZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000009}"),
                    ItemValue = "布依族",
                    Spell = "BYZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000010}"),
                    ItemValue = "朝鲜族",
                    Spell = "CXZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000011}"),
                    ItemValue = "满族",
                    Spell = "MZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000012}"),
                    ItemValue = "侗族",
                    Spell = "DZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000013}"),
                    ItemValue = "瑶族",
                    Spell = "YZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000014}"),
                    ItemValue = "白族",
                    Spell = "BZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000015}"),
                    ItemValue = "土家族",
                    Spell = "TJZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000016}"),
                    ItemValue = "哈尼族",
                    Spell = "HNZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000017}"),
                    ItemValue = "哈萨克族",
                    Spell = "HSKZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000018}"),
                    ItemValue = "傣族",
                    Spell = "TZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000019}"),
                    ItemValue = "黎族",
                    Spell = "LZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000020}"),
                    ItemValue = "傈僳族",
                    Spell = "LSZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000021}"),
                    ItemValue = "佤族",
                    Spell = "WZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000022}"),
                    ItemValue = "畲族",
                    Spell = "SZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000023}"),
                    ItemValue = "高山族",
                    Spell = "GSZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000024}"),
                    ItemValue = "拉祜族",
                    Spell = "LGZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000025}"),
                    ItemValue = "水族",
                    Spell = "SZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000026}"),
                    ItemValue = "东乡族",
                    Spell = "DXZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000027}"),
                    ItemValue = "纳西族",
                    Spell = "NXZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000028}"),
                    ItemValue = "景颇族",
                    Spell = "JPZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000029}"),
                    ItemValue = "柯尔克孜族",
                    Spell = "HEKZZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000030}"),
                    ItemValue = "土族",
                    Spell = "TZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000031}"),
                    ItemValue = "达斡尔族",
                    Spell = "DWEZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000032}"),
                    ItemValue = "仫佬族",
                    Spell = "MLZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000033}"),
                    ItemValue = "羌族",
                    Spell = "QZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000034}"),
                    ItemValue = "布朗族",
                    Spell = "BLZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000035}"),
                    ItemValue = "撒拉族",
                    Spell = "LSZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000036}"),
                    ItemValue = "毛难族",
                    Spell = "MNZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000037}"),
                    ItemValue = "仡佬族",
                    Spell = "QLZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000038}"),
                    ItemValue = "锡伯族",
                    Spell = "XBZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000039}"),
                    ItemValue = "阿昌族",
                    Spell = "ACZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000040}"),
                    ItemValue = "普米族",
                    Spell = "PMZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000041}"),
                    ItemValue = "塔吉克族",
                    Spell = "TJKZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000042}"),
                    ItemValue = "怒族",
                    Spell = "NZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000043}"),
                    ItemValue = "乌孜别克族",
                    Spell = "WZBKZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000044}"),
                    ItemValue = "俄罗斯族",
                    Spell = "ELSZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000045}"),
                    ItemValue = "鄂温克族",
                    Spell = "EWKZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000046}"),
                    ItemValue = "崩龙族",
                    Spell = "BLZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000047}"),
                    ItemValue = "保安族",
                    Spell = "BAZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000048}"),
                    ItemValue = "裕固族",
                    Spell = "YGZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000049}"),
                    ItemValue = "京族",
                    Spell = "JZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000050}"),
                    ItemValue = "塔塔尔族",
                    Spell = "TTEZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000051}"),
                    ItemValue = "独龙族",
                    Spell = "DLZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000052}"),
                    ItemValue = "鄂伦春族",
                    Spell = "ELCZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000053}"),
                    ItemValue = "赫哲族",
                    Spell = "HZZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000054}"),
                    ItemValue = "门巴族",
                    Spell = "MBZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000055}"),
                    ItemValue = "珞巴族",
                    Spell = "LBZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000056}"),
                    ItemValue = "基诺族",
                    Spell = "JNZ"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000057}"),
                    ItemValue = "其他",
                    Spell = "QT"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{c93d568d-8c7d-424a-abfd-7faec0b12360}"),
                    ItemKey = Guid.Parse("{9B849977-0000-0000-0000-000000000058}"),
                    ItemValue = "外国血统中国人士",
                    Spell = "WGXTZGRS"
                });
            #endregion

            #region 性别
            modelBuilder.Entity<SysItemInfo>()
                .HasData(new SysItemInfo
                {
                    ItemCode = Guid.Parse("{627ebe5d-c8d4-40a0-bd19-0d2b849a21b9}"),
                    ItemKey = Guid.Parse("{216CB274-0000-0000-0000-000000000001}"),
                    ItemValue = "男",
                    Spell = "N"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{627ebe5d-c8d4-40a0-bd19-0d2b849a21b9}"),
                    ItemKey = Guid.Parse("{216CB274-0000-0000-0000-000000000002}"),
                    ItemValue = "女",
                    Spell = "N"
                }, new SysItemInfo
                {
                    ItemCode = Guid.Parse("{627ebe5d-c8d4-40a0-bd19-0d2b849a21b9}"),
                    ItemKey = Guid.Parse("{216CB274-0000-0000-0000-000000000003}"),
                    ItemValue = "未知",
                    Spell = "WZ"
                });
            #endregion







        }
    }
}
