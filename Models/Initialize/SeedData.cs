using System;
using System.Linq;
using HospitalPersonnelSystem.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
        /// <param name="clear">是否重置初始化数据</param>
        public static void Initialize(ApplicationDbContext context, UserManager<HPSUser> userManager, bool clear)
        {
            #region 菜单类别
            if (context.SysNavbarTypes.Any() && clear)//判断是否有数据//判断是否重置
                context.SysNavbarTypes.RemoveRange(context.SysNavbarTypes.Include(b => b.SysNavbars).ToList());
            else
                context.SysNavbarTypes.AddRange(SysNavbarTypes());
            #endregion

            #region 菜单
            if (context.SysNavbars.Any() && clear)
                context.SysNavbars.RemoveRange(context.SysNavbars.ToList());
            else
                context.SysNavbars.AddRange(SysNavbars());
            #endregion

            #region 性别
            if (context.ComGenders.Any() && clear)
                context.ComGenders.RemoveRange(context.ComGenders.ToList());
            else
                context.ComGenders.AddRange(ComGenders());
            #endregion

            #region 民族
            if (context.ComNations.Any() && clear)
                context.ComNations.RemoveRange(context.ComNations.ToList());
            else
                context.ComNations.AddRange(ComNations());
            #endregion

            #region 政治面貌
            if (context.ComPoliticals.Any() && clear)
                context.ComPoliticals.RemoveRange(context.ComPoliticals.ToList());
            else
                context.ComPoliticals.AddRange(ComPoliticals());
            #endregion

            #region 岗位
            if (context.ComPosts.Any() && clear)
                context.ComPosts.RemoveRange(context.ComPosts.ToList());
            else
                context.ComPosts.AddRange(ComPosts());
            #endregion

            #region 科室
            if (context.SysDepts.Any() && clear)
                context.SysDepts.RemoveRange(context.SysDepts.ToList());
            else
                context.SysDepts.AddRange(SysDepts());
            #endregion

            #region 人员
            if (context.SysEmps.Any() && clear)
                context.SysEmps.RemoveRange(context.SysEmps.ToList());
            else
                context.SysEmps.AddRange(SysEmps());
            #endregion

            #region 默认用户
            if (context.Users.Any() && clear)
                context.Users.RemoveRange(context.Users.ToList());
            else
                userManager.CreateAsync(HPSUsers(), HPSUsers().UserName);
            #endregion

            //估计userManager.CreateAsync方法提交过了，再次提交会报错。
            //context.SaveChanges();
        }

        /// <summary>
        /// 测试数据
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userManager"></param>
        public static void InitializeTest(ApplicationDbContext context, UserManager<HPSUser> userManager)
        {

        }

        /// <summary>
        /// 菜单类别
        /// </summary>
        /// <returns></returns>
        static List<SysNavbarType> SysNavbarTypes()
        {
            return new List<SysNavbarType>
            {
                new SysNavbarType("49b247e4-33bb-4793-a23f-ef86ebc5f654", 1, "系统设置", "JTSZ"),
                new SysNavbarType("f356c105-78d1-4d16-bb8d-a48fc1072993", 2, "人事档案", "RSDA"),
                new SysNavbarType("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e", 3, "机构管理", "JGGL"),
                new SysNavbarType("4d3c3953-fd9e-4df1-aa18-3285e020d4bc", 4, "基础数据维护", "JCSJWH")
            };
        }

        /// <summary>
        /// 菜单
        /// </summary>
        /// <returns></returns>
        static List<SysNavbar> SysNavbars()
        {
            return new List<SysNavbar>()
            {
                new SysNavbar("43155cdf-69c5-4610-9578-711a8830e39c", SysNavbarTypes()[0].Code.ToString(), 1, "账号&权限管理", null, "Admin", "UserIndex", "ZHQXGL"),
                new SysNavbar("84694a3e-bd02-4c7b-809a-13b03179ec47", SysNavbarTypes()[0].Code.ToString(), 2, "菜单管理", null, "SysNavbar", "Index", "CDGL")
            };
        }

        /// <summary>
        /// 性别
        /// </summary>
        /// <returns></returns>
        static List<ComGender> ComGenders()
        {
            return new List<ComGender>()
            {
                new ComGender("c09d4a7e-3ddd-4221-b8fb-e786e5bff7a7", "男", 1, "N"),
                new ComGender("15424909-5fd9-4798-99f5-0689e3e13a80", "女", 2, "N"),
                new ComGender("f1384219-82c1-47d8-8689-0be7c7f41129", "未知", 3, "WZ")
            };
        }

        /// <summary>
        /// 民族
        /// </summary>
        /// <returns></returns>
        static List<ComNation> ComNations()
        {
            return new List<ComNation>()
            {
                new ComNation("ce17f92b-ee53-4aa6-8f3d-c3b13d865e2d", "汉族", 1, "HZ"),
                new ComNation("fe1b5cdf-a56a-4af2-9292-fdbfe1f0b530", "蒙古族", 2, "MGZ"),
                new ComNation("77070aa5-6016-4d97-91e5-d4d2b94b1cf5", "回族", 3, "HZ"),
                new ComNation("0de9c5de-79ec-4ab2-96e7-893309ef5a11", "藏族", 4, "CZ,ZZ"),
                new ComNation("9330d875-72f8-4aa2-9619-864f0bf09a86", "维吾尔族", 5, "WWEZ"),
                new ComNation("27c2656d-a169-40eb-b119-8be5a7d9fe5e", "苗族", 6, "MZ"),
                new ComNation("c6fffde3-3486-45ea-9773-373e3f80ce65", "彝族", 7, "YZ"),
                new ComNation("55c3e5bd-728a-46bd-a7b4-5f7b74bed31d", "壮族", 8, "ZZ"),
                new ComNation("c11f7e7a-e826-4788-8ad5-89c880ccff73", "布依族", 9, "BYZ"),
                new ComNation("cd8af0ab-8f9e-4cfb-87f4-972b7ede8f3d", "朝鲜族", 10, "CXZ,ZXZ"),
                new ComNation("b7b2f88a-e31f-401d-805d-8043781ee725", "满族", 11, "MZ"),
                new ComNation("f4d89b8c-f725-42d0-8972-0eee98a0a82a", "侗族", 12, "DZ,TZ"),
                new ComNation("bdb9290a-eb65-4fb4-8ef8-ad50631654d9", "瑶族", 13, "YZ"),
                new ComNation("786b96c6-51a7-45ce-b7a0-c22619364f5f", "白族", 14, "BZ"),
                new ComNation("05eacb66-c76a-4062-a414-fa4366ef3ff5", "土家族", 15, "TGZ,TJZ"),
                new ComNation("55285e0a-4461-4056-96d1-201a2c59b5f6", "哈尼族", 16, "HNZ"),
                new ComNation("d0ac4e5b-dbc8-4812-ba72-b6ebafc137c7", "哈萨克族", 17, "HSKZ"),
                new ComNation("36ee5060-6325-4c57-8b09-dad263296106", "傣族", 18, "DZ"),
                new ComNation("e0ce34ec-edc6-455b-9b76-1b09a4796192", "黎族", 19, "LZ"),
                new ComNation("2bb906e6-565d-4086-b81d-3060aabad081", "傈僳族", 20, "LSZ"),
                new ComNation("1749ac7d-28fe-4b53-92b6-78f959699e6f", "佤族", 21, "WZ"),
                new ComNation("86f8c2c2-e7f5-4b8e-8345-a17cc827a5fd", "畲族", 22, "SZ"),
                new ComNation("e732013a-1e0d-4493-ad17-0a4e33391a23", "高山族", 23, "GSZ"),
                new ComNation("7931e107-a881-4b13-a9ee-f498fb7f3721", "拉祜族", 24, "LHZ"),
                new ComNation("5296cce9-356d-4e6c-9c53-0fe232bcf0a7", "水族", 25, "SZ"),
                new ComNation("a1874836-f9c9-4a02-b069-e5425c04aaa0", "东乡族", 26, "DXZ"),
                new ComNation("de308b82-428d-4145-ba32-fa6afa908b73", "纳西族", 27, "NXZ"),
                new ComNation("fa087a7b-e04a-4a2b-b9b0-f0258cf10f17", "景颇族", 28, "JPZ"),
                new ComNation("63f7f37d-64b3-47b3-8a7e-372bc3fcc5d0", "柯尔克孜族", 29, "KEKZZ"),
                new ComNation("ec032b4e-2c4c-4b68-bd61-c2d9d2b8ae17", "土族", 30, "TZ"),
                new ComNation("8e0843d7-4dc0-470c-b259-477cdc8d2cb9", "达斡尔族", 31, "DWEZ"),
                new ComNation("af3b4946-51ba-467e-84fc-b1a0b916014b", "仫佬族", 32, "MLZ"),
                new ComNation("633648e2-e5b4-4255-9066-7998e08d7554", "羌族", 33, "QZ"),
                new ComNation("5be47248-1b42-48f3-8104-cec698f17fb6", "布朗族", 34, "BLZ"),
                new ComNation("abd2c0ce-5f80-46f3-b5d5-dbfe3e91dd16", "撒拉族", 35, "SLZ"),
                new ComNation("013f5281-7eb2-442f-a8ae-33f91024b941", "毛难族", 36, "MNZ"),
                new ComNation("9a11301e-f8a4-4270-b2e5-018f046d1370", "仡佬族", 37, "GLZ,YLZ"),
                new ComNation("fe864400-bffe-4987-b347-cf577843aa4f", "锡伯族", 38, "XBZ"),
                new ComNation("72756c98-10d6-426e-ae0c-4f4923bbeb50", "阿昌族", 39, "ACZ,ECZ"),
                new ComNation("6624026e-9b9d-4a43-8c2b-03bba6dfc633", "普米族", 40, "PMZ"),
                new ComNation("785103a3-c622-47cd-b729-299bffdb41c8", "塔吉克族", 41, "DJKZ,TJKZ"),
                new ComNation("46fe69c2-c35d-4f61-918b-bb1781116ed4", "怒族", 42, "NZ"),
                new ComNation("f46a746c-28a6-4cff-8320-da97fcbd4ba6", "乌孜别克族", 43, "WZBKZ"),
                new ComNation("a9e6154f-8e84-444b-96a4-08d0e98538a6", "俄罗斯族", 44, "ELSZ"),
                new ComNation("173b5721-c8f2-4022-a9bb-7b54766175f2", "鄂温克族", 45, "EWKZ"),
                new ComNation("6e732fba-d0ac-4f07-82ab-05a8abdcbb5d", "崩龙族", 46, "BLZ"),
                new ComNation("7e14c3a9-6302-43c5-9640-9ba803c67152", "保安族", 47, "BAZ"),
                new ComNation("21ba2da8-79a0-4bea-a7ce-db67623e9e54", "裕固族", 48, "YGZ"),
                new ComNation("192bc7db-fdab-469a-98f5-be4aa48226a9", "京族", 49, "JZ"),
                new ComNation("8eac3697-bb0e-4529-b261-c1cae32d52b0", "塔塔尔族", 50, "DDEZ,TDEZ,DTEZ,TTEZ"),
                new ComNation("2956dc8d-c4a7-4ef8-ab81-498c19701b3d", "独龙族", 51, "DLZ"),
                new ComNation("3ea5a56b-759f-4edf-b1c7-f2fc765aec7c", "鄂伦春族", 52, "ELCZ"),
                new ComNation("4ee672ba-ccd8-4b1a-8eb3-21d6cf195e11", "赫哲族", 53, "HZZ"),
                new ComNation("c8e14e07-3f8d-47f6-9b0c-7e2a0868244e", "门巴族", 54, "MBZ"),
                new ComNation("18893556-ca2c-4bf0-96d1-9e4d2c208e12", "珞巴族", 55, "LBZ"),
                new ComNation("46867956-52ec-4561-935f-31ba818f7896", "基诺族", 56, "JNZ"),
                new ComNation("d9ca5ffc-4373-4b0a-ac32-779f6c2d26d0", "其他", 57, "JT,QT"),
                new ComNation("516663b7-6e78-42e0-bb24-82b3ce1c86e2", "外国血统中国人士", 58, "WGXTZGRS")
            };
        }

        /// <summary>
        /// 政治面貌
        /// </summary>
        /// <returns></returns>
        static List<ComPolitical> ComPoliticals()
        {
            return new List<ComPolitical>()
            {
                new ComPolitical("8e871348-b291-44e3-9aff-534cfe8eb4cf", "群众", 13, "QZ"),
                new ComPolitical("688037b9-9131-46c6-9c2f-bd8f51ae79b2", "中共党员", 1, "ZGDY"),
                new ComPolitical("3cae2d48-a455-4aaf-a8ec-69a5f68ba6a8", "中共预备党员", 2, "ZGYBDY"),
                new ComPolitical("78744d56-814d-4d3b-a9bb-e6bf16e92b82", "共青团员", 3, "GQTY"),
                new ComPolitical("1b250db6-c552-4042-bc47-d6b09e2056e5", "民革党员", 4, "MGDY,MJDY"),
                new ComPolitical("612f876f-7e4a-4890-86bb-060090a7bced", "民盟盟员", 5, "MMMY"),
                new ComPolitical("0e64f9f6-6e5f-484f-a23a-180b4b6fbdee", "民建会员", 6, "MJHY,MJKY"),
                new ComPolitical("ce317a66-b116-4161-aa69-92a4119e7615", "民进会员", 7, "MJHY,MJKY"),
                new ComPolitical("6c28a531-c937-4445-8143-adf40047151e", "农工党党员", 8, "NGDDY"),
                new ComPolitical("393c1c7e-2611-449b-b80c-a8395a0fb1b7", "致公党党员", 9, "ZGDDY"),
                new ComPolitical("8a7868d4-6fb3-4eb1-be84-70e45f8a9044", "九三学社社员", 10, "JSXSSY"),
                new ComPolitical("174728d1-d724-4aea-97fc-58c2b6fcd6f9", "台盟盟员", 11, "TMMY"),
                new ComPolitical("9d1fe0bc-f2c3-41f8-a3fc-11f5bd076065", "无党派人士", 12, "MDPRS,WDPRS")
            };
        }

        /// <summary>
        /// 岗位
        /// </summary>
        /// <returns></returns>
        static List<ComPost> ComPosts()
        {
            return new List<ComPost>()
            {
                new ComPost("bbe31057-4a91-4800-99f7-7d99226e7e7f", "无", 3, "W"),
                new ComPost("5d0f8ac1-2de4-4983-b49d-5304b571c11e", "卫", 1, "W"),
                new ComPost("2e526cd1-9b1c-41db-932f-999c4e7f4163", "工", 2, "G")
            };
        }

        /// <summary>
        /// 科室
        /// </summary>
        /// <returns></returns>
        static List<SysDept> SysDepts()
        {
            return new List<SysDept>() { new SysDept("0000", 1, "初始化科", "CSHK") };
        }

        /// <summary>
        /// 员工
        /// </summary>
        /// <returns></returns>
        static List<SysEmp> SysEmps()
        {
            return new List<SysEmp>()
            {
                new SysEmp()
                {
                    EmpCode = "000000",
                    EmpName = "管理员",
                    Spell = "GLY",
                    DeptCode = "0000",
                    GenderCode = ComGenders()[0].Code,
                    NationCode = ComNations()[0].Code,
                    BirthDate = DateTime.Now,
                    PoliticalCode = ComPoliticals()[0].Code,
                    IdentityCard = "41010119880808",
                    IsPost = false,
                    HospitalDate = DateTime.Now,
                    PostCode = ComPosts()[0].Code
                }
            };
        }

        /// <summary>
        /// 管理员用户
        /// </summary>
        /// <returns></returns>
        static HPSUser HPSUsers()
        {
            return new HPSUser() { UserName = "000000", EmpCode = "000000" };
        }








        ///// <summary>
        ///// 默认数据
        ///// </summary>
        ///// <param name="modelBuilder"></param>
        //void InsertData(ModelBuilder modelBuilder)
        //{

        //    #region 菜单
        //    modelBuilder.Entity<SysNavbar>().HasData(
        //        new SysNavbar("43155cdf-69c5-4610-9578-711a8830e39c", "49b247e4-33bb-4793-a23f-ef86ebc5f654", 1, "账号管理", "Account", "Index", "ZHGL"),
        //        new SysNavbar("84694a3e-bd02-4c7b-809a-13b03179ec47", "49b247e4-33bb-4793-a23f-ef86ebc5f654", 2, "菜单类别", "SysNavbarType", "Index", "CDLB"),
        //        new SysNavbar("b5c4e0db-5fe3-45e8-ae94-66b451509232", "49b247e4-33bb-4793-a23f-ef86ebc5f654", 3, "菜单", "SysNavbar", "Index", "CD"));






        //    //new SysNavbar("84694a3e-bd02-4c7b-809a-13b03179ec47", "Index", "SysNavbarType", "菜单类别", 1, "CCLB,CDLB,CSLB", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("b5c4e0db-5fe3-45e8-ae94-66b451509232", "Index", "SysNavbar", "菜单", 2, "CC,CD,CS", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("766ba75a-cc1d-47c4-b81f-896fcbd50192", "Index", "ComGender", "性别", 3, "XB", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("46864280-4032-40f2-997d-ff4bd91e940c", "Index", "ComPost", "岗位", 4, "GW", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("1a2260db-c848-4355-aaa2-16f5bab953be", "Index", "ComNation", "民族", 5, "MZ", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("7bcff967-fed2-4568-86e9-a7bd8a72b792", "Index", "ComPolitical", "政治面貌", 6, "ZZMM", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("c5fe9b01-e255-4c0b-902b-eb05b9668f14", "Index", "ComProfessionTitle", "职称", 7, "ZC", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("bf9643b4-66f9-4bf5-824f-e3d24a7c6e1a", "Index", "ComProfessionTitleLevel", "职称级别", 8, "ZCJB", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("f9b26629-8847-43a5-8294-3fe1933b575c", "Index", "ComProfessionTitleType", "职称系列", 9, "ZCJL,ZCXL", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("af3efd75-fb74-4558-8df5-68bb475f96e7", "Index", "ComProfessionRegister", "执业资格", 10, "ZYZG", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("dfa8acb3-f106-4c82-b1e3-8795bf8e9db2", "Index", "ComProfessionExtent", "执业范围", 11, "ZYFW", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("461bcde9-fcb8-4aa7-9922-36515446e2e3", "Index", "ComProfessionType", "执业类别", 12, "ZYLB", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("4c518faf-feef-4b78-a29a-81e82c1de9d6", "Index", "ComAdminDuty", "行政职务", 13, "HZZW,XZZW", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("c3b0c898-9365-406a-8df0-a57ab94d4f19", "Index", "SysEmpType", "人员类别", 14, "RYLB", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("3127a184-7bb8-4005-8f50-f525ab6ac2c5", "Index", "ComEducation", "学历", 15, "XL", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("49ffea21-b9be-4d82-9116-1e06975a91d4", "Index", "ComDegree", "学位", 16, "XW", "4d3c3953-fd9e-4df1-aa18-3285e020d4bc"),
        //    //new SysNavbar("a91f758f-b5b7-429a-b5be-a3b09b63fde3", "Index", "SysDept", "科室信息", 17, "KSXX", "c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e"),
        //    //new SysNavbar("8c0a45fb-6b72-474e-974a-fbf100ecfeef", "Index", "SysEmp", "人员管理", 18, "RYGL", "f356c105-78d1-4d16-bb8d-a48fc1072993"),
        //    //new SysNavbar("34121d7c-15d1-4488-8158-7bb6885521cc", "Index", "SysProfessionInfo", "职称评定", 19, "ZCPD", "f356c105-78d1-4d16-bb8d-a48fc1072993"),
        //    //new SysNavbar("fa1db30f-fbe0-4ebf-ba6e-90bac56deb11", "Index", "SysEducation", "学历评定", 20, "XLPD", "f356c105-78d1-4d16-bb8d-a48fc1072993"),
        //    //new SysNavbar("0dc5856b-2399-4334-a790-a00385b5b285", "Index", "SysContract", "合同", 21, "HT", "f356c105-78d1-4d16-bb8d-a48fc1072993"),
        //    //new SysNavbar("1ba40056-ff15-4fba-b064-636e57235ab7", "Register", "Admin", "用户注册", 22, "YHZC", "49b247e4-33bb-4793-a23f-ef86ebc5f654"),
        //    //new SysNavbar("43155cdf-69c5-4610-9578-711a8830e39c", "UserIndex", "Admin", "用户管理", 23, "YHZC", "49b247e4-33bb-4793-a23f-ef86ebc5f654"));
        //    #endregion



        

        

        

        //    #region 职称系列
        //    modelBuilder.Entity<ComProfessionTitleType>().HasData(
        //        new ComProfessionTitleType("b9bbcf12-f2c7-48e1-9ece-12068ac58768", "卫生技术人员", 1, "WSJSRY,WSJZRY"),
        //        new ComProfessionTitleType("072c109c-b77a-4ce5-8379-0e01aade0099", "高等学校教师", 2, "GDXJJS,GDXXJS"),
        //        new ComProfessionTitleType("e63e2af4-6278-45fd-9e6e-1619e46bd6d6", "中等专业学校教师", 3, "ZDZYXJJS,ZDZYXXJS"),
        //        new ComProfessionTitleType("16c8d407-a09c-42e5-b780-ebba33162ebf", "技工学校教师", 4, "JGXJJS,JGXXJS"),
        //        new ComProfessionTitleType("5824b69d-28c8-47dc-b49c-0eb48732f780", "中学教师", 5, "ZXJS"),
        //        new ComProfessionTitleType("cf256af3-9556-4049-8e6b-b05106babd00", "小学（幼儿园）教师", 6, "XX（YEY）JS"),
        //        new ComProfessionTitleType("cc0a3196-7793-4729-a79f-b55b4f42cc58", "自然科学研究人员", 7, "ZRKXYJRY"),
        //        new ComProfessionTitleType("b3d09255-1d6e-4c89-8671-3227659957ea", "社会科学研究人员", 8, "SHKXYJRY,SKKXYJRY"),
        //        new ComProfessionTitleType("c7f8405f-0966-4811-8f33-a3d9ddd4d17f", "工程技术人员", 9, "GCJSRY,GCJZRY"),
        //        new ComProfessionTitleType("234ace94-7cd4-480b-aef0-e7e161b02697", "实验技术人员", 10, "SYJSRY,SYJZRY"),
        //        new ComProfessionTitleType("a43b05e2-f2df-4016-984f-40c95bb03c0b", "农业技术人员", 11, "NYJSRY,NYJZRY"),
        //        new ComProfessionTitleType("83cb5dd3-fc2a-4d90-90e5-b0d544e57f19", "经济专业人员", 12, "JJZYRY"),
        //        new ComProfessionTitleType("45c3f3a9-efeb-4d43-9db9-0470245d1d35", "会计专业人员", 13, "HJZYRY,KJZYRY"),
        //        new ComProfessionTitleType("eea9ecc4-f934-4b07-afe5-1c99fd3da8b4", "审计专业人员", 14, "SJZYRY"),
        //        new ComProfessionTitleType("990ea624-3736-4f12-915b-3e872cdd4913", "统计专业人员", 15, "TJZYRY"),
        //        new ComProfessionTitleType("27c45a02-43b3-47e0-ac0b-8ebf8af37d59", "新闻专业人员", 16, "XWZYRY"),
        //        new ComProfessionTitleType("805682d1-68dd-44cc-97d2-aee76cd88f4b", "出版专业人员", 17, "CBZYRY"),
        //        new ComProfessionTitleType("a75c01cb-707f-4704-8ce4-37183d8a6c69", "图书资料专业人员", 18, "TSZLZYRY"),
        //        new ComProfessionTitleType("f977393b-d721-4bae-87af-0d34138be4af", "文物博物专业人员", 19, "WWBWZYRY"),
        //        new ComProfessionTitleType("41cb832e-b01a-41d2-b3d4-a887e79f07ac", "档案专业人员", 20, "DAZYRY"),
        //        new ComProfessionTitleType("78960f3e-1f31-4a41-8bc9-d7b296e8ba55", "广播电视播音人员", 21, "ABDSBYRY,GBDSBYRY"),
        //        new ComProfessionTitleType("19f3d687-7d72-4c90-ab9a-d6b470b04d06", "翻译人员", 22, "FYRY"),
        //        new ComProfessionTitleType("0f188db0-9691-4296-a5cb-20b69101aac2", "律师", 23, "LS"),
        //        new ComProfessionTitleType("afca33cc-1504-4cea-8ed7-531ff50d801c", "公证员", 24, "GZY"),
        //        new ComProfessionTitleType("8f4f6be4-784e-4d68-8ce7-cbd96435718d", "海关人员", 25, "HGRY"),
        //        new ComProfessionTitleType("85233e97-ea84-4e37-ac56-90f0629f92ba", "船舶技术人员", 26, "CBJSRY,CBJZRY"),
        //        new ComProfessionTitleType("65816271-4a14-4e8e-b74f-8802c3a1a50c", "民用航空飞行技术人员", 27, "MYHKFHJSRY,MYHKFXJSRY,MYHKFHJZRY,MYHKFXJZRY"),
        //        new ComProfessionTitleType("c3a7e48e-52b0-4ff9-882b-124cd939b773", "艺术专业人员", 28, "YSZYRY,YZZYRY"),
        //        new ComProfessionTitleType("d1274053-074b-4e27-88e3-7799dd395d1a", "工艺美术专业人员", 29, "GYMSZYRY,GYMZZYRY"),
        //        new ComProfessionTitleType("45af0571-55a8-4ff6-a2fb-8434df78e053", "体育教练员", 30, "TYJLY"),
        //        new ComProfessionTitleType("6a70cc98-9e72-4b97-a37b-b2ebf66e2ca7", "思想政治工作人员", 31, "SXZZGZRY"),
        //        new ComProfessionTitleType("f20164e3-99ce-42ba-ac19-f6bd740ed46c", "无", 32, "M,W"));
        //    #endregion

        //    #region 职称级别
        //    modelBuilder.Entity<ComProfessionTitleLevel>().HasData(
        //        new ComProfessionTitleLevel("9ee36b90-1e89-4591-b849-9d79badce3a8", "正高级", 1, "ZGJ"),
        //        new ComProfessionTitleLevel("4ef010d0-5c7e-4e38-bcff-fffcd69627cf", "副高级", 2, "FGJ"),
        //        new ComProfessionTitleLevel("f469629a-4d6d-4640-804b-f2e5c44f5ca4", "中级", 3, "ZJ"),
        //        new ComProfessionTitleLevel("4e8d76cd-5bc0-4281-8e68-446a8b649b82", "初级", 4, "CJ"),
        //        new ComProfessionTitleLevel("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0", "无", 5, "M,W"));
        //    #endregion

        //    #region 职称
        //    modelBuilder.Entity<ComProfessionTitle>().HasData(
        //        new ComProfessionTitle("9a6587f1-877a-4cd9-9190-9586357ff374", "9ee36b90-1e89-4591-b849-9d79badce3a8", "主任医师", 1, "ZRYS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("2a993f3e-1acf-49bc-a2ce-32ad5f974b9a", "9ee36b90-1e89-4591-b849-9d79badce3a8", "主任药师", 2, "ZRYS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("138b4279-3551-484c-826f-11831c29b8ef", "9ee36b90-1e89-4591-b849-9d79badce3a8", "主任护师", 3, "ZRHS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("c31f1667-013d-4331-9809-00580c55761b", "9ee36b90-1e89-4591-b849-9d79badce3a8", "主任技师", 4, "ZRJS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("a247f5a9-b7e6-42f9-9f52-39ae90766e63", "4ef010d0-5c7e-4e38-bcff-fffcd69627cf", "副主任医师", 5, "FZRYS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("d51ce584-a443-459e-bad9-3641a39f0ea3", "4ef010d0-5c7e-4e38-bcff-fffcd69627cf", "副主任药师", 6, "FZRYS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("36d00ebd-7224-439e-962a-f215318c914e", "4ef010d0-5c7e-4e38-bcff-fffcd69627cf", "副主任护师", 7, "FZRHS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("3ddab2f1-3c6a-4b09-a0ec-d743297fd662", "4ef010d0-5c7e-4e38-bcff-fffcd69627cf", "副主任技师", 8, "FZRJS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("9e2e2813-14a1-417f-ad41-018760bb4345", "f469629a-4d6d-4640-804b-f2e5c44f5ca4", "主治医师", 9, "ZZYS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("959e0116-a6b0-48e7-ade2-84576055ca58", "f469629a-4d6d-4640-804b-f2e5c44f5ca4", "主管药师", 10, "ZGYS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("b9527c98-b7ef-47b7-b1a8-5710506ba47a", "f469629a-4d6d-4640-804b-f2e5c44f5ca4", "主管护师", 11, "ZGHS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("92223c91-dd24-44d4-9b04-b65b0811f8a2", "f469629a-4d6d-4640-804b-f2e5c44f5ca4", "主管技师", 12, "ZGJS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("efc6b47b-5bd5-46e8-809e-c570ed09b446", "4e8d76cd-5bc0-4281-8e68-446a8b649b82", "医师", 13, "YS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("11a39f8b-0c38-4673-8649-d3b5c574fe93", "4e8d76cd-5bc0-4281-8e68-446a8b649b82", "医士", 14, "YS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("a66cc816-b673-41b6-a17c-313ea811b90b", "4e8d76cd-5bc0-4281-8e68-446a8b649b82", "药师", 15, "YS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("70648907-3292-4e6f-bf4d-9e94e2b07fe6", "4e8d76cd-5bc0-4281-8e68-446a8b649b82", "药士", 16, "YS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("00a56523-a8ba-4534-910c-1d0e51d288ea", "4e8d76cd-5bc0-4281-8e68-446a8b649b82", "护师", 17, "HS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("7e101785-9817-4c56-92da-92716ecbbeab", "4e8d76cd-5bc0-4281-8e68-446a8b649b82", "护士", 18, "HS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("1573ab91-609f-42f5-8666-ead60dbb7e16", "4e8d76cd-5bc0-4281-8e68-446a8b649b82", "技师", 19, "JS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("28683b64-719d-42d9-83bb-9da0a599d4d0", "4e8d76cd-5bc0-4281-8e68-446a8b649b82", "技士", 20, "JS", "b9bbcf12-f2c7-48e1-9ece-12068ac58768"),
        //        new ComProfessionTitle("a888cb9b-2f27-48fe-a0d7-65f0220cd457", "2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0", "无职称", 21, "MZC,WZC", "f20164e3-99ce-42ba-ac19-f6bd740ed46c"));
        //    #endregion

        //    #region 行政职务
        //    modelBuilder.Entity<ComAdminDuty>().HasData(
        //        new ComAdminDuty("164d8115-f202-4f6a-a3bb-36a291c258cf", "院长", 1, "YC,YZ"),
        //        new ComAdminDuty("2da11464-675c-4c37-b0a1-f68d03f5e7bc", "副院长", 2, "FYC,FYZ"),
        //        new ComAdminDuty("e409ac30-d6c7-4c36-85ed-82105557084b", "书记", 3, "SJ"),
        //        new ComAdminDuty("6649cc52-e576-47ff-8346-049b07781203", "副书记", 4, "FSJ"),
        //        new ComAdminDuty("bd070422-5fda-4dfd-a1ba-363d1c8f9d82", "团委书记", 5, "TWSJ"),
        //        new ComAdminDuty("0be2bbcd-a59b-4f06-99dc-e2890d9c032b", "团委副书记", 6, "TWFSJ"),
        //        new ComAdminDuty("337522c2-c6ce-4f0d-bf16-9ded4bcf66fb", "大科主任", 7, "DKZR"),
        //        new ComAdminDuty("c738e049-6584-4c01-8609-ef130d73c3e4", "科主任", 8, "KZR"),
        //        new ComAdminDuty("fe3d2f08-1572-4c75-b69e-282a43a667cc", "副主任", 9, "FZR"),
        //        new ComAdminDuty("e2c25ecd-62f2-4024-99c2-316b818f9a2f", "护士长", 10, "HSC,HSZ"),
        //        new ComAdminDuty("fd8a6cf4-1b05-4219-981f-cfae6f640fab", "副护士长", 11, "FHSC,FHSZ"),
        //        new ComAdminDuty("66812653-08e6-4228-ba75-299ac9c46d08", "科员", 12, "KY"),
        //        new ComAdminDuty("e5eb4516-012c-47b2-8d27-fe3af11479f5", "干事", 13, "GS"),
        //        new ComAdminDuty("0296ea3c-f503-40e6-8cbe-d3ed6f6b9f78", "返聘", 14, "FP"),
        //        new ComAdminDuty("40574e21-beb0-47fd-a754-143abb0a85dd", "无", 15, "M,W"));
        //    #endregion

        //    #region 人员类别
        //    modelBuilder.Entity<SysEmpType>().HasData(
        //        new SysEmpType("440ad1b9-4aa1-4c4f-a42b-00fd4b072323", "试用人员", 16, "SYRY"),
        //        new SysEmpType("e3fd1637-6145-445a-a4fe-53d86a985043", "借出人员", 10, "JCRY"),
        //        new SysEmpType("1e9b7246-5011-4184-af07-b243ac36346d", "内部退养", 15, "NBTY"),
        //        new SysEmpType("56fc114c-1856-4bcb-90ca-7b889dc6feee", "编外离岗人员", 14, "BWLGRY"),
        //        new SysEmpType("903c7582-2a2a-425e-8191-70f16323c35c", "停薪留职人员", 13, "TXLZRY"),
        //        new SysEmpType("ed1897bc-7f87-45f9-a2a5-fa9092c9ae29", "自动离职人员", 12, "ZDLZRY"),
        //        new SysEmpType("7ac7856f-6f65-4d18-b66d-3e6010546bd3", "长期出国人员", 11, "CJCGRY,ZJCGRY,CQCGRY,ZQCGRY"),
        //        new SysEmpType("d463c3dd-c0f4-4ebe-8df9-7e88ca63d4d0", "实习进修", 9, "SXJX"),
        //        new SysEmpType("6dff62ac-b4db-48ea-96c6-c84f45f8dd30", "在编人员", 1, "ZBRY"),
        //        new SysEmpType("98fc0e39-0b39-43a2-8ab6-32ed9eb40cea", "调出人员", 7, "DCRY,TCRY"),
        //        new SysEmpType("b9880b91-c847-4ce1-80e8-bb88b1ca5039", "返聘人员", 6, "FPRY"),
        //        new SysEmpType("3b48a92c-7795-464d-88ec-bca44ba5fbb4", "辞职人员", 5, "CZRY"),
        //        new SysEmpType("457aeb73-f984-4909-874a-7b8d4d64f648", "离退人员", 4, "LTRY"),
        //        new SysEmpType("91b82903-e614-4004-9e14-d49ec0829415", "临时人员", 3, "LSRY"),
        //        new SysEmpType("db50bd4a-3540-4cb9-8bac-60fb10f17e42", "人事代理", 2, "RSDL"),
        //        new SysEmpType("46daac30-61f5-423e-98a0-317ce956ba3c", "除名人员", 8, "CMRY"));
        //    #endregion

        //    #region 学历
        //    modelBuilder.Entity<ComEducation>().HasData(
        //        new ComEducation("cfc54993-df96-4df9-8612-a04a587dbfac", "博士研究生", 1, "BSYJS"),
        //        new ComEducation("b968d27c-b8b7-4ee4-a2ba-542fbb92e40d", "硕士研究生", 2, "SSYJS"),
        //        new ComEducation("5c447706-3043-4316-a762-8a13ed012ee1", "本科", 3, "BK"),
        //        new ComEducation("5577bfe1-bcdc-487d-9d48-14227dabdf8a", "专科", 4, "ZK"),
        //        new ComEducation("32216522-238e-4750-ae47-b1b2380970a0", "中专", 5, "ZZ"),
        //        new ComEducation("0b87e5b4-59fb-4af6-a915-15946ce39371", "高中及以下", 6, "GZJYX"),
        //        new ComEducation("763ab2e4-f879-4283-99aa-0216413e46a6", "技校", 7, "JJ,JX"),
        //        new ComEducation("c3db4429-1d5a-4f8b-8b0d-cdcd22cee8a2", "其他", 8, "JT,QT"));
        //    #endregion

        //    #region 学位
        //    modelBuilder.Entity<ComDegree>().HasData(
        //        new ComDegree("da151fb9-a147-4a18-8c45-ffa292629364", "博士后", 1, "BSH"),
        //        new ComDegree("c02891ec-f550-4ffd-8bc3-f697a47b94fe", "博士", 2, "BS"),
        //        new ComDegree("1d07fb7a-2dfa-4fba-bd95-36257a739519", "硕士", 3, "SS"),
        //        new ComDegree("4fc980f1-9113-48c2-9da3-c483d62428eb", "学士", 4, "XS"),
        //        new ComDegree("ab01e65b-9656-44d8-9379-edf132bb7915", "无", 5, "M,W"));
        //    #endregion

        //    #region 婚姻状况
        //    modelBuilder.Entity<ComMarriage>().HasData(
        //        new ComMarriage("d4f19b14-3ffb-4721-b708-035bb9475b35", "未婚", 1, "WH"),
        //        new ComMarriage("148e5991-32f9-4f00-ba94-0b857e67351c", "已婚", 2, "YH"),
        //        new ComMarriage("4834ec49-2306-401c-aaaa-efa824b7be66", "丧偶", 3, "SO"),
        //        new ComMarriage("2e5b8119-4d9f-4208-ab8b-af66256ed71d", "离婚", 4, "LH"),
        //        new ComMarriage("6cca4dd0-8fa7-46be-90ab-f6ac0379adde", "未说明的婚姻状况", 5, "WSMDHYZK,WYMDHYZK"));
        //    #endregion

        //    #region 执业资格
        //    modelBuilder.Entity<ComProfessionRegister>().HasData(
        //        new ComProfessionRegister("972d26e3-2057-4fbb-8ea5-5cd27ef08f56", "执业护士", 1, "ZYHS"),
        //        new ComProfessionRegister("5682174b-a606-49ac-8e21-cd1f4528b2bb", "执业医师", 2, "ZYYS"),
        //        new ComProfessionRegister("77aa99bd-d60b-4294-b8ad-fae4ff12c4d8", "无", 3, "M,W"));
        //    #endregion

        //    #region 执业类别
        //    modelBuilder.Entity<ComProfessionType>().HasData(
        //        new ComProfessionType("8f0f9e11-21dc-4f27-9fa1-bfcd3866b98c", "临床", 1, "LC"),
        //        new ComProfessionType("cecfc213-7f9c-4794-9fd3-48f03552175f", "口腔", 2, "KQ"),
        //        new ComProfessionType("1bef14e7-017f-408d-8b21-a2be1081f3e9", "公卫", 3, "GW"),
        //        new ComProfessionType("ce7e7937-e090-4900-baeb-3faa6da4c39d", "中医", 4, "ZY"));
        //    #endregion

        //    #region 执业范围
        //    modelBuilder.Entity<ComProfessionExtent>().HasData(
        //        new ComProfessionExtent("81dc3ba0-c02b-46ca-88e1-169cfdcdaf28", "护理专业", 1, "HLZY"),
        //        new ComProfessionExtent("057361fe-d658-4870-a9aa-6d4b3d588a3e", "外科专业", 2, "WKZY"));
        //    #endregion


        //}




    }
}