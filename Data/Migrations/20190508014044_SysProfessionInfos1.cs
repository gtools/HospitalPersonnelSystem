using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPersonnelSystem.Data.Migrations
{
    public partial class SysProfessionInfos1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("06b15f21-b1bb-43ef-9b85-25c5cc7d1896"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("2127bb90-131e-4552-971c-4601cde0d4fa"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("3fec702d-4290-403e-8059-a76cf8b75ac3"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("53b18bbb-fa4f-4cbd-8edd-b46a2d016971"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("5bdf4b49-780d-4ef9-8b2a-3001127eb556"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("680de19b-b9dd-4e4c-9d33-a21350276507"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("80b6ca1e-2d1a-4163-ae83-cb22b560718a"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("8d56384e-6fd1-4d29-af7b-b92091df2cd2"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("bc0b0bd2-96c7-42db-bb58-07ff6d18b14d"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("bc275333-e563-4631-9463-5a028b67a9b1"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("d1f707c7-f979-46aa-af12-b073c02e2006"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("d22b321e-bf7d-42d4-b0fb-83a5453b7049"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("e30f5863-4891-448a-b7d3-9abd0bf62d3a"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("e7f3a3f2-215f-4a8d-813f-6860164e0734"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("065f8555-559e-431e-b487-4bf6a1481d7e"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("3e4b550a-5547-4a69-b415-897821663135"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("aa1f8735-4405-4515-92db-40f8c7c2022e"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("ab48042c-bda5-4a90-adf3-5faaaee7b837"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("fe23815f-bf5b-409f-8193-3e1e8cfd4a95"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("2f1e73bb-d863-4c09-b454-5650e0f5eee8"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("36a55f45-2bf4-49a1-bd79-40557c2fc87c"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("598c7ada-5b5d-47c7-a412-be4095d2a7e6"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("6525dca8-5ace-4742-8f40-b375dc2c6387"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("8dcff26e-1c87-4fc9-bb5c-47a0e0083589"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("af94de61-4372-4c0d-89ea-eed6b641d471"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("dd4643ca-51ba-41b5-a3b3-804f68e774e8"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("ebebd4bd-b10d-4299-9dd7-9b1c13a112c3"));

            migrationBuilder.DeleteData(
                table: "ComGender",
                keyColumn: "Code",
                keyValue: new Guid("1cbcbc78-c7cc-4c94-8958-fbc666189eb4"));

            migrationBuilder.DeleteData(
                table: "ComGender",
                keyColumn: "Code",
                keyValue: new Guid("39110852-a554-4fda-8e20-26cedb375910"));

            migrationBuilder.DeleteData(
                table: "ComMarriage",
                keyColumn: "Code",
                keyValue: new Guid("27c4e2d0-bd62-4610-b03e-e45b79cdaaee"));

            migrationBuilder.DeleteData(
                table: "ComMarriage",
                keyColumn: "Code",
                keyValue: new Guid("81209711-0f91-4e9e-8517-e570a3daa0e3"));

            migrationBuilder.DeleteData(
                table: "ComMarriage",
                keyColumn: "Code",
                keyValue: new Guid("d9c7ebcd-9b3c-410c-be39-684add01eb7c"));

            migrationBuilder.DeleteData(
                table: "ComMarriage",
                keyColumn: "Code",
                keyValue: new Guid("ee4eaf9b-1fed-4957-bc5b-c9f64b1d807e"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("0004470b-17ad-4f12-ae05-40c338d97e6c"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("0094ae61-da07-40e7-8dd6-05a5ef36b9ea"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("0101fe13-7f5f-4795-a32c-26725480f142"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("0589c66a-031e-4965-ae0b-3c03740a5246"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("06f5c961-aad4-4f02-834d-34fcbc01c304"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("0a400814-49ff-44af-8924-d294ed5263dd"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("11cab3ba-e9e7-4993-a515-03b71d6d1587"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("18c5dada-149b-4c30-868a-025935e83700"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("1a996aa2-28af-409b-83ad-ef41db992c35"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("1be8ad52-7ffb-4640-8ddd-bf14c81997d3"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("1dd61069-79fc-4377-953e-ffb103752e41"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("1effed20-217e-4a72-9882-9d77b053fd35"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("214d7404-8154-407a-88e3-074bc886f0e2"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("2212d7bf-d7ce-46c7-831b-432577f36837"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("2229dfc4-2ef4-4a2b-abaf-bb2dde71e5a3"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("25f1245c-3b6f-4c84-adee-d62f78db3c4c"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("27c80eac-9213-4e13-87c1-31eff1108be0"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("2c062c88-e993-43fa-b9ad-4f15ed50d7d3"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("3841088d-340b-4698-9e33-0d0712d1deed"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("3ab6afdc-24cd-433b-98a3-c22e81a48f7a"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("3ec59f39-6bf8-4052-aeb8-cf5a6d55606b"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("3f70ba16-4880-4976-946c-6640a3be8436"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("416518d7-8d6a-47fa-88e5-982e9841da37"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("451ce873-cad9-4f61-b99c-cbf19dbcd431"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("52fa0e86-db7b-4d30-88ae-64693f5f6d84"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("59f237e3-3f63-4283-864b-ff38be3ec7a6"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("59f573e1-d4a9-46c7-a300-5bbcf3153a77"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("63fadaaa-c221-4214-b6cd-4ee8bb0d5130"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("66135bba-724f-4147-bc66-3f20f602f04a"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("6ebef184-425c-492e-890b-3374f4ab8e7b"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("76d931a7-5c41-4e29-8876-ce7bc7874aec"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("7a7d33f6-ebed-40ba-ab1c-a227cefc73dc"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("7cca7a8d-42e4-4908-a4f8-6d1b9fb54586"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("7eca8f40-c45f-468f-84a3-8da870605efb"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("820810bd-5ede-4f49-9642-998475b83454"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("84834f70-f616-45a3-a99d-1f89f66d5cf6"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("8978384d-0ff6-4191-a027-3bb6187ae1ba"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("91cb2100-35e2-40f5-9086-5df0cd8f594d"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("935ff2e6-a94a-4b4e-8747-3bf03c965598"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("9cd0e643-ad5a-4992-9f12-7db858f77633"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("a067463b-1b88-4d31-9b60-75a462787c56"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("a1be7c6b-c5ae-4aa0-8fd6-639ca4d1e20c"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("a3701e7a-662b-44e3-9f94-80de18c3e367"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("b31d1d47-9158-4861-bdb6-0218def1dada"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("b6271a27-2898-48b8-a523-2a78a57fcbae"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("beb67fca-8653-4e10-89eb-062c8c28ad5f"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("c25b7dec-7f8e-4ac6-ae26-25b13933578e"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("c44f2064-1e65-4589-b3d2-a8f650a3c78a"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("cfb6c6b9-82e0-4519-abf9-6a7319769e2f"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("d6108846-0cf2-484c-8327-785c63a5b0ec"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("dd7a8396-964c-465d-90ea-18043f269a25"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("e4b073ea-eeef-4df8-afc1-026303cb6546"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("e5a52fdd-aba5-4962-8ce8-5d097f9971fc"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("e8107920-ae2a-4b50-888f-aeb3ea389a99"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("ee00813f-3401-42e2-8776-78cffa6c51d9"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("f37fccef-028a-4992-8324-202a653f2d2f"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("ffcb28c7-5347-47e0-8952-89c882cc7e1d"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("00575efc-b43b-4a73-b1bf-4858c2f18101"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("1d4765c7-d13a-48f7-9e11-33d9c74e4bf5"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("3580ef9e-7125-4e7f-812e-e21d2eaff385"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("375bebe3-d412-4497-9356-9fb0ecb33979"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("4494bcf7-c97f-4351-a322-377853d326f5"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("95b9f284-c121-4f74-971e-60899f760429"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("9b8b3378-0284-49c9-97e5-0da1ab7c680c"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("a493a95d-3968-40b0-a8d6-2fc5a3e0da1a"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("cf7f0db9-5c84-4f3c-8483-326a9d2b08a4"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("d36d4db7-632f-4ced-bca7-76bce39c6173"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("d91b4fbd-640c-4537-b619-b9c7f4652081"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("ecfd6bca-2847-4183-95a5-271399c44f86"));

            migrationBuilder.DeleteData(
                table: "ComPost",
                keyColumn: "Code",
                keyValue: new Guid("1d7007dd-7235-4804-a272-12473b05bc8a"));

            migrationBuilder.DeleteData(
                table: "ComPost",
                keyColumn: "Code",
                keyValue: new Guid("c67aa674-a5ac-4776-940d-10c76e3ba5bf"));

            migrationBuilder.DeleteData(
                table: "ComProfessionExtent",
                keyColumn: "Code",
                keyValue: new Guid("d2239660-a82b-4e1f-92fe-6dd7525b026b"));

            migrationBuilder.DeleteData(
                table: "ComProfessionExtent",
                keyColumn: "Code",
                keyValue: new Guid("fed126a6-1425-4b9f-a8ab-2f985fbda75f"));

            migrationBuilder.DeleteData(
                table: "ComProfessionRegister",
                keyColumn: "Code",
                keyValue: new Guid("9e8ce404-db80-452e-9292-8b0b703926eb"));

            migrationBuilder.DeleteData(
                table: "ComProfessionRegister",
                keyColumn: "Code",
                keyValue: new Guid("b5c2dfe6-3951-4b79-889c-798228ded7e1"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("12e1adeb-1169-41e4-933d-5034e1656b05"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("16304a5d-79ac-490a-9f15-8837636d6523"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("18c4334c-6701-4d40-a3a2-7387d520e609"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("1a950b6f-1e90-48d8-8d16-68b247209a79"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("1fb12ef6-3257-448a-972a-497e94fd8fcb"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("28d18652-63d8-42a2-988e-9a40f79aea9f"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("2ef6498f-2156-4ae0-86cc-aedeee9ac4cb"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("334e733d-f743-491d-b135-ba58f356165b"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("4ae234ff-9e5b-4731-8d99-3f93c6786a99"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("52264a28-9d61-438f-8aa0-63240ce993b4"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("61da1618-8db4-4b34-abb0-2fef82bc49a0"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("71714970-1440-4d6e-8521-3b30d9c0214e"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("7724bb4a-1105-4cdf-9f7d-b99175351595"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("b826e1d6-ffd0-41dc-8b54-e55fed35f91c"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("bb3efbc8-8195-4911-b109-e8dc25b6f211"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("ce3a3816-6e96-4dd7-a363-a7f41335621e"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("dd3f18e5-f6ff-4c0b-9a4e-6c72847655c6"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("e8add0e9-c7fd-4e18-8230-c00f4835c11b"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("f1cdae05-ec1f-4900-9251-5d729a0ee8ea"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("f982fd67-6584-4da9-89aa-5d9579224592"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("fa618b39-ab46-45d1-b9af-dcf930dd4859"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("09ea9c13-2639-4bd9-9431-30fcda21f800"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("16751b23-8f72-4d40-a60c-e5e75e19e32c"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("238b9d42-6d10-4523-9c15-57e9d0d453fb"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("2800c85e-eef2-49b9-86da-a1610e1c8bf4"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("2ceb2a55-6609-4602-9ae8-9a46978bed8d"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("3ab98224-31ad-4184-8def-c2d6bc57f41c"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("3b613654-324b-4a8c-a752-ec55005b3981"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("403c3b08-c9e5-474e-b2b9-526954ca96b3"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("453551dd-d672-4221-b4a4-d446e10b1354"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("5df5a1e4-bda8-4b8f-a5e8-83a598fc7a37"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("62ea2e20-89f9-4b16-a78e-b7c43cc7bac8"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("632fa798-e852-4ce1-91a0-b2e3734ba01e"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("646585d8-115a-447e-af48-1cfeb7614643"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("6be12002-d489-405a-be90-c4350d675db2"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("6c30e2c3-55d9-49ec-8f2e-7ceb85a95ab1"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("6f87fa29-dbc0-4cd1-b99e-5cd28c844d35"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("76494471-894c-433a-972a-642ed1d05929"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("86ac6438-543a-4c19-8d59-aa103a6ac5b8"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("942622db-41e1-456e-aef8-87e19adfebf8"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("997dffc8-4904-4f63-8a5a-fb115e3edae2"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("a2bd6753-e7b0-4300-9932-3e4ca886e38f"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("a432ebaf-1398-401e-815d-ab94ff674ee4"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("a509bf10-d072-48e6-98a8-c0626a0b6bc9"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("a6e0eb8f-6bb5-4c5a-91f1-5d7f9cad4cb7"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("a7b20501-2da0-4099-ae55-bda79381ac36"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("a875771f-d030-45a7-a3f2-22428ba31d1b"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("cd001c66-1045-4571-a609-43cfe032b1df"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("f22a5b51-0a54-47c7-a396-e88b9b3bf66e"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("f3452967-8456-4996-8c70-0c3127daffbc"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("f7ee47bd-ce17-4151-9309-fff8fa8534f2"));

            migrationBuilder.DeleteData(
                table: "ComProfessionType",
                keyColumn: "Code",
                keyValue: new Guid("049aca76-a429-4945-952b-cd792823fcf4"));

            migrationBuilder.DeleteData(
                table: "ComProfessionType",
                keyColumn: "Code",
                keyValue: new Guid("6db24fe9-1d97-449d-9637-8c31a45ab991"));

            migrationBuilder.DeleteData(
                table: "ComProfessionType",
                keyColumn: "Code",
                keyValue: new Guid("80b9200a-99e1-4ee9-a7c9-cade73d73654"));

            migrationBuilder.DeleteData(
                table: "ComProfessionType",
                keyColumn: "Code",
                keyValue: new Guid("d3f15955-b585-418d-8391-28495dfb47f1"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("32058174-22f0-4aeb-9bc6-385599c173af"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("3739ca89-ba4c-49e0-a669-8ee9801ce02f"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("3c750202-5964-406e-a207-36125fe66f96"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("3df65b5c-d0f1-4643-9677-d3d982269c96"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("40198c10-ad88-4810-b55b-cbcefe6e11d4"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("4191fa72-007e-474a-9177-316963c09e8a"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("4a3210d3-67db-4463-ad79-468e0a358dad"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("50d55a83-529d-4bb5-a31a-6e617e3aa294"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("d3e60eb3-cc44-476b-850a-fa167166f824"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("db4e3706-ccde-433a-8356-def5451273a6"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("e0e97799-2ea7-410b-9073-ecc4cdc70fdc"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("e8450549-1d3d-44fa-998e-d04480e5af0d"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("f6e19408-3016-42d2-9945-74d7690009ed"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("fd863878-e499-47e0-a06d-def8e936642e"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("ff97d6d5-09db-4a55-9542-c2103e015241"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("0affccb2-ff6d-431d-82a6-36b3ab7e405f"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("0e411a24-4fc2-4c9a-a60c-d5e88421c80e"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("2feee364-c732-467c-a0a3-e516f30f0356"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("42782c5e-59f8-4608-80fc-8ca87ed9470c"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("466863a1-c2c4-47b0-b668-1f1cc3e044de"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("639e945c-ffc7-47d5-b248-267167e423b1"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("747b47e8-453f-461a-bfa0-35055dcdb870"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("8f582a69-04c1-44c2-8d00-9c301c007b1d"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("9896efad-210a-44de-a367-6ecba6d749ee"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("a66f30d0-fa30-4a50-b865-913da3751dfc"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("ad136c8c-9398-4d1e-af3a-bbc75f6c4c16"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("ce5b8299-120a-4a39-a760-a18b89a79056"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("db7bb185-ca7c-4996-8a81-92b6e7f9ee68"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("de74243f-4389-4765-b89c-771dd8718b63"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("ea54d9f5-5ba4-40d3-9804-e5547c0b64dc"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("fb676bcd-a480-4893-8eba-a92e8f7f089d"));

            migrationBuilder.InsertData(
                table: "ComAdminDuty",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("836700ed-6f5e-431f-a3c4-0c2d3a51c09c"), "院长", 1, "YC,YZ" },
                    { new Guid("8720ac63-1168-43b9-ae73-d9997dcaba7c"), "副院长", 2, "FYC,FYZ" },
                    { new Guid("02baddf4-c358-4287-9f73-fc7e26efc037"), "书记", 3, "SJ" },
                    { new Guid("00c0fb0a-790d-4eb2-98cc-702dab79ea08"), "副书记", 4, "FSJ" },
                    { new Guid("5650c098-4c99-4ed8-a82d-878027b5f50d"), "团委书记", 5, "TWSJ" },
                    { new Guid("783e110b-8dae-4877-a52b-e9e57a9d1da9"), "团委副书记", 6, "TWFSJ" },
                    { new Guid("ea2ce311-d891-4462-8a7e-26e7a378c7ba"), "大科主任", 7, "DKZR" },
                    { new Guid("477e0415-4b10-4d44-8fff-af7b46818b01"), "科主任", 8, "KZR" },
                    { new Guid("17a9acb7-5538-4217-8334-26159a1444c5"), "副主任", 9, "FZR" },
                    { new Guid("476f6ed6-cb59-4c5a-919f-4d34fdad6cd4"), "护士长", 10, "HSC,HSZ" },
                    { new Guid("f83a3a08-7985-454f-a34f-e3683d21d4f4"), "副护士长", 11, "FHSC,FHSZ" },
                    { new Guid("74101e58-9957-47b5-8fb6-c69ff448a11d"), "科员", 12, "KY" },
                    { new Guid("7f50fde9-2e4c-4627-8ae3-c9b2987c2c84"), "干事", 13, "GS" },
                    { new Guid("d80b331a-0f8c-4182-bdbe-c02410cff7a5"), "返聘", 14, "FP" }
                });

            migrationBuilder.InsertData(
                table: "ComDegree",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("45ebca26-6683-4c1b-9d2b-6037daeb5ec4"), "无", 5, "M,W" },
                    { new Guid("98ca7720-fdce-4b0b-894a-0a58cbf8bb79"), "学士", 4, "XS" },
                    { new Guid("28c874d8-4f22-4ffa-bb9c-a44d3200f7b5"), "博士", 2, "BS" },
                    { new Guid("3fd09490-0217-4629-b854-86c1aa08b60d"), "博士后", 1, "BSH" },
                    { new Guid("e5781fb6-9656-4611-81dd-7dd417cd734e"), "硕士", 3, "SS" }
                });

            migrationBuilder.InsertData(
                table: "ComEducation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("1841e737-dfba-4638-97a2-3d887e433a65"), "博士研究生", 1, "BSYJS" },
                    { new Guid("2886fc90-4149-480e-8029-35870d1fb60f"), "硕士研究生", 2, "SSYJS" },
                    { new Guid("22903bdd-c22b-476b-b1c1-e5c663714b21"), "本科", 3, "BK" },
                    { new Guid("f7ef9c66-a461-446c-95ec-51c16a3c3c5d"), "专科", 4, "ZK" },
                    { new Guid("834463f5-0e49-4730-b1b2-45e1e9ff993a"), "中专", 5, "ZZ" },
                    { new Guid("4c54ffa9-59fa-4374-8c14-8d283be7e501"), "高中及以下", 6, "GZJYX" },
                    { new Guid("19e5de04-1d98-4440-be39-35e1ed8291a8"), "技校", 7, "JJ,JX" },
                    { new Guid("e3d08f45-b217-4cfa-abda-f0e65cdfde3b"), "其他", 8, "JT,QT" }
                });

            migrationBuilder.InsertData(
                table: "ComGender",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("e1beb0cc-860a-4406-b548-55b88b44728a"), "男", 1, "N" },
                    { new Guid("c4997de5-7dfd-41c0-a822-a2eb42d02a74"), "女", 2, "N" }
                });

            migrationBuilder.InsertData(
                table: "ComMarriage",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("80917b34-dfea-4017-88f2-cb1319c1fe64"), "离婚", 4, "LH" },
                    { new Guid("40b2269a-a2b4-4e49-a846-1fda107f5ad4"), "丧偶", 3, "SO" },
                    { new Guid("0679549d-ac21-4b70-8207-5a865c62d4f0"), "已婚", 2, "YH" },
                    { new Guid("4096da9e-acef-48ef-9a17-5783f0404353"), "未婚", 1, "WH" }
                });

            migrationBuilder.InsertData(
                table: "ComNation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("3b330621-0ae1-4b08-9cdc-7888012c69aa"), "羌族", 33, "QZ" },
                    { new Guid("0ec87847-12b4-4fe4-a4e2-c3635f0e16fe"), "布朗族", 34, "BLZ" },
                    { new Guid("cf06ff99-65b9-43fa-8c97-5801ea7d4b4e"), "撒拉族", 35, "SLZ" },
                    { new Guid("02a9ea4b-405b-4c92-b679-e44ad61537fe"), "毛难族", 36, "MNZ" },
                    { new Guid("2058dcfd-033a-4615-9d03-686293a311de"), "仡佬族", 37, "GLZ,YLZ" },
                    { new Guid("6f621ccb-77c5-4ab2-9d09-3d1fee235105"), "锡伯族", 38, "XBZ" },
                    { new Guid("98cb5363-c602-43d8-a4eb-262326689ab9"), "阿昌族", 39, "ACZ,ECZ" },
                    { new Guid("46fdb393-1002-465e-82e2-6062f65dbb46"), "普米族", 40, "PMZ" },
                    { new Guid("654cd922-36c0-4092-a460-8f483707e14e"), "塔吉克族", 41, "DJKZ,TJKZ" },
                    { new Guid("d6bcb0dd-48da-487f-a3d6-c90dd3e80d60"), "怒族", 42, "NZ" },
                    { new Guid("6d468b7a-d064-4c2e-b310-d27866fcb6c5"), "乌孜别克族", 43, "WZBKZ" },
                    { new Guid("28dddf49-f2a2-4cac-91f6-cc130cb84dd2"), "俄罗斯族", 44, "ELSZ" },
                    { new Guid("a81176d2-1db1-4c66-b6d0-07a70b7b33ff"), "仫佬族", 32, "MLZ" },
                    { new Guid("6c03cb0b-4e91-4ff7-a4b9-a5192de2779a"), "鄂温克族", 45, "EWKZ" },
                    { new Guid("2a52360b-f7fe-42e5-b060-5482e47b24ce"), "保安族", 47, "BAZ" },
                    { new Guid("c3c7ad0c-7830-4efe-95c7-226a138fae4e"), "裕固族", 48, "YGZ" },
                    { new Guid("68440cd8-ee6f-4cd6-8da8-b4332259aaae"), "京族", 49, "JZ" },
                    { new Guid("5bf29641-366a-4dc3-a9ff-aed64ba10fdb"), "塔塔尔族", 50, "DDEZ,TDEZ,DTEZ,TTEZ" },
                    { new Guid("1fa15e3e-8e40-4b24-9407-7c8526443460"), "独龙族", 51, "DLZ" },
                    { new Guid("a20e2acd-bb92-477e-9393-703655b0b896"), "鄂伦春族", 52, "ELCZ" },
                    { new Guid("47c5001b-b9fc-4995-872c-7f9403200191"), "赫哲族", 53, "HZZ" },
                    { new Guid("bef03d93-d487-48ff-bb16-58d69d0ac983"), "门巴族", 54, "MBZ" },
                    { new Guid("6b82ca5f-49ba-4658-9ede-b9a1efe3f101"), "珞巴族", 55, "LBZ" },
                    { new Guid("392cd28e-4dd1-47f9-a62a-7af9166eba27"), "基诺族", 56, "JNZ" },
                    { new Guid("e5653cbf-d897-4428-8fda-0957e35ae131"), "其他", 57, "JT,QT" },
                    { new Guid("ee626dea-dc23-4537-9dea-c6a22a20ec37"), "外国血统中国人士", 58, "WGXTZGRS" },
                    { new Guid("099beb73-00a7-4c57-94d8-94232914da79"), "崩龙族", 46, "BLZ" },
                    { new Guid("ad6a47a0-b8c8-486b-87a6-10f330ca6661"), "达斡尔族", 31, "DWEZ" },
                    { new Guid("412747bf-9a23-4d68-82dd-d33dc921100c"), "哈尼族", 16, "HNZ" },
                    { new Guid("c436293c-5142-4276-904c-0744270c924e"), "柯尔克孜族", 29, "KEKZZ" },
                    { new Guid("107dd205-4c59-4f48-8981-ede79ed0a443"), "蒙古族", 2, "MGZ" },
                    { new Guid("345a082e-e839-43dd-959c-fff8a4029aa6"), "回族", 3, "HZ" },
                    { new Guid("3f5c6fa7-e1f9-4e7d-967a-51bfe4275f57"), "藏族", 4, "CZ,ZZ" },
                    { new Guid("8110c7f3-79dc-4aee-af2d-bc14ab03da5e"), "维吾尔族", 5, "WWEZ" },
                    { new Guid("5bf5b103-0580-41ab-9d60-34f5cc4bc042"), "苗族", 6, "MZ" },
                    { new Guid("b51bf4cd-c77c-48b5-b189-5c65865ed42d"), "彝族", 7, "YZ" },
                    { new Guid("68846386-efc4-4cc5-b97e-e9710e264bf7"), "壮族", 8, "ZZ" },
                    { new Guid("f80d635c-d191-4040-be72-dd27597c5c13"), "布依族", 9, "BYZ" },
                    { new Guid("21b75187-24b2-47d6-8a6c-3154606dbcfa"), "朝鲜族", 10, "CXZ,ZXZ" },
                    { new Guid("8cb48cb8-4ca5-4ddf-9ed2-bc5ddc82f5f1"), "满族", 11, "MZ" },
                    { new Guid("d6a08418-d594-4d87-b611-9d14c0dfc7d2"), "侗族", 12, "DZ,TZ" },
                    { new Guid("d5d7dcf4-a80e-4db5-b758-56cdf1d395ff"), "土族", 30, "TZ" },
                    { new Guid("bc197037-4838-4256-9dfb-a80dc9f0cfad"), "白族", 14, "BZ" },
                    { new Guid("b9cbc4b1-1f3e-4e41-a8d2-3611ae7c2697"), "瑶族", 13, "YZ" },
                    { new Guid("0fd61088-5c57-4a18-bf99-e3c9b93f9bb5"), "拉祜族", 24, "LHZ" },
                    { new Guid("d6c248f0-817f-42ce-8e74-04ec2c1f35c1"), "哈萨克族", 17, "HSKZ" },
                    { new Guid("7b5b1bc0-d833-4bb7-87e1-68562bc8874c"), "傣族", 18, "DZ" },
                    { new Guid("da6a04f9-54b4-4604-b804-05269870a1bd"), "黎族", 19, "LZ" },
                    { new Guid("48d9b39c-6445-4e13-b331-374a03fdd2db"), "傈僳族", 20, "LSZ" },
                    { new Guid("51e95735-0810-40b4-9eee-a2882e60857d"), "佤族", 21, "WZ" },
                    { new Guid("42f0be92-1696-44c6-a02a-ce0cb2677c67"), "畲族", 22, "SZ" },
                    { new Guid("0aafde19-e376-4024-9c86-701cfd73661a"), "高山族", 23, "GSZ" },
                    { new Guid("67736ba4-76f5-4f5b-9007-9e628895c228"), "土家族", 15, "TGZ,TJZ" },
                    { new Guid("8c84f969-5635-4bcc-bd00-a9fa2c64a45f"), "水族", 25, "SZ" },
                    { new Guid("c5cb2b10-ecf4-44e4-aee9-36eec15c3491"), "东乡族", 26, "DXZ" },
                    { new Guid("e6a44627-245c-45db-a3d5-c91b36ea39be"), "纳西族", 27, "NXZ" },
                    { new Guid("609f4844-4c8d-47ff-836d-06cdbb809258"), "景颇族", 28, "JPZ" }
                });

            migrationBuilder.InsertData(
                table: "ComPolitical",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("09823386-810b-43dd-bfea-d9a265c9d96a"), "九三学社社员", 10, "JSXSSY" },
                    { new Guid("3c606957-01a5-4f69-8a41-5ce4f61e25ee"), "农工党党员", 8, "NGDDY" },
                    { new Guid("577948c2-f6e8-4bc7-817a-baff537c4aa6"), "无党派人士", 12, "MDPRS,WDPRS" },
                    { new Guid("f955b073-9cd9-4398-a14e-49930792c1ea"), "台盟盟员", 11, "TMMY" },
                    { new Guid("817b6186-3b44-44bc-a53d-452997ada768"), "民进会员", 7, "MJHY,MJKY" },
                    { new Guid("bdc8dd1c-ffdc-4e4c-b135-98927d6ba720"), "致公党党员", 9, "ZGDDY" },
                    { new Guid("3d5961ca-def7-4ea3-b211-3a6a8e5bd789"), "民盟盟员", 5, "MMMY" },
                    { new Guid("c2e9a0b6-c6cb-45fe-b708-5e467fa44fd1"), "民革党员", 4, "MGDY,MJDY" },
                    { new Guid("732f83d0-a33f-47ab-81a6-8be55072aba2"), "民建会员", 6, "MJHY,MJKY" },
                    { new Guid("04a66db1-373b-45a6-b85a-2d5ed016a069"), "共青团员", 3, "GQTY" },
                    { new Guid("3e214932-54bf-4062-847b-153b8fdbd4d3"), "中共预备党员", 2, "ZGYBDY" },
                    { new Guid("eeb3fa49-db8f-4e5d-b4e9-c766aa37f916"), "中共党员", 1, "ZGDY" }
                });

            migrationBuilder.InsertData(
                table: "ComPost",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("6729cccb-ec0b-4833-9a6b-cc08c83e80b7"), "卫", 1, "W" },
                    { new Guid("cc4be172-3a70-4527-bb81-85a3d3263902"), "工", 2, "G" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionExtent",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("268c2131-45f1-47ed-8dde-16783b1edc17"), "护理专业", 1, "HLZY" },
                    { new Guid("16bd271a-455d-4628-b4f8-aafe3aa0975a"), "外科专业", 2, "WKZY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionRegister",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("24a292b7-3f8a-481c-8213-b4746006a66c"), "执业医师", 2, "ZYYS" },
                    { new Guid("f05b6055-df4f-4553-92df-b370b2098915"), "执业护士", 1, "ZYHS" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitle",
                columns: new[] { "Code", "LevelCode", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("31bcdad8-e042-4eda-849c-ef16e0ee9866"), new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无职称", 21, "MZC,WZC", new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c") },
                    { new Guid("60f9436c-1759-45b7-a769-8e0b470c8157"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技士", 20, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("db8385a8-a7ba-47a6-96d5-f65bd8614754"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技师", 19, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("de35c520-6a4d-44e5-8b61-698450aaa8c8"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护士", 18, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("d2fc5f48-53ff-475d-a409-6b02df3e06d9"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护师", 17, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("a7dd45a6-ed8f-418b-a6ec-b958639857ef"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药士", 16, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("40d4048c-4adb-4a6a-ae23-d1d100283ddf"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药师", 15, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("e4687b51-9b24-4ee7-8e46-5e9bdeda6ae4"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医士", 14, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("9269643a-ed6d-48f8-b194-03ed40161047"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医师", 13, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("90f778f5-afd2-4ba3-8f69-e8f3df0feced"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管护师", 11, "ZGHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("65b4615c-cbf2-4b42-bf10-9db91b017c93"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管技师", 12, "ZGJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("40137f92-2d2d-4a11-979e-1eee9880c29c"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主治医师", 9, "ZZYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("2c0c89d4-7234-4ec5-9d43-8d383e5f041f"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任技师", 8, "FZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("427ee48f-3538-46bc-8299-62eb22bdff27"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任护师", 7, "FZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("e237376c-3ee8-4f42-9a52-c59f8cdc89c6"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任药师", 6, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("8ea6e4f8-6572-4399-8868-79ce1177bdc5"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任医师", 5, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("d2944a4d-4ffa-4cbe-af8f-f9142404a44c"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任技师", 4, "ZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("46a8e35c-0b78-413a-a903-8d5168cece09"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任护师", 3, "ZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("b17c7f30-898b-44dc-8250-99dd71887801"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任药师", 2, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("c7440693-58fa-45ec-8b6d-db61c56c8e25"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任医师", 1, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("91c2762b-5106-470b-a48b-c7a30ed56448"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管药师", 10, "ZGYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitleType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("171859a0-8cdf-48ae-b5a9-ea402d49d833"), "图书资料专业人员", 18, "TSZLZYRY" },
                    { new Guid("23633498-581b-4389-8ae9-15b3bced2213"), "思想政治工作人员", 31, "SXZZGZRY" },
                    { new Guid("5a9d5634-9a87-448b-874a-0d789e48279e"), "档案专业人员", 20, "DAZYRY" },
                    { new Guid("f82eea27-c506-4a06-bbff-d35fa4727337"), "广播电视播音人员", 21, "ABDSBYRY,GBDSBYRY" },
                    { new Guid("8269bc07-59fa-49aa-b98e-a9fd292d260b"), "翻译人员", 22, "FYRY" },
                    { new Guid("a6092819-ec93-43fb-9ac0-a1efc165686c"), "律师", 23, "LS" },
                    { new Guid("32cf3bd3-d24d-45cc-8d6e-6543871f81ab"), "工艺美术专业人员", 29, "GYMSZYRY,GYMZZYRY" },
                    { new Guid("17154a18-d356-4f70-beb4-1ea48e64165a"), "海关人员", 25, "HGRY" },
                    { new Guid("353564d2-88f1-4048-9311-ab1bad850505"), "船舶技术人员", 26, "CBJSRY,CBJZRY" },
                    { new Guid("b8fdbfb5-e8f2-4236-b610-b6ee23d6f9da"), "民用航空飞行技术人员", 27, "MYHKFHJSRY,MYHKFXJSRY,MYHKFHJZRY,MYHKFXJZRY" },
                    { new Guid("16b33dca-63fd-42fa-b78e-1e6928f519bf"), "艺术专业人员", 28, "YSZYRY,YZZYRY" },
                    { new Guid("98a639d3-06dd-4544-a10b-2bef36d6edd9"), "体育教练员", 30, "TYJLY" },
                    { new Guid("baf4d991-e4e1-4505-808a-93291d1adc1f"), "公证员", 24, "GZY" },
                    { new Guid("696c46ef-9c2d-4162-95b3-c3dc4682f6b8"), "出版专业人员", 17, "CBZYRY" },
                    { new Guid("8a14987a-bb5a-4ffd-bb79-b5e42b331ddf"), "文物博物专业人员", 19, "WWBWZYRY" },
                    { new Guid("1fc4162a-71a1-4d81-8968-6cb984eeda49"), "统计专业人员", 15, "TJZYRY" },
                    { new Guid("cad66d6e-44f6-41a9-bb7b-73416438cb1b"), "高等学校教师", 2, "GDXJJS,GDXXJS" },
                    { new Guid("a0d81440-ac53-49de-9d9f-dfe20a6f0d4e"), "技工学校教师", 4, "JGXJJS,JGXXJS" },
                    { new Guid("f7856921-aa48-400b-bc64-160377736e8c"), "中学教师", 5, "ZXJS" },
                    { new Guid("c564f2a7-f9ed-4c27-924b-6540a599eb08"), "小学（幼儿园）教师", 6, "XX（YEY）JS" },
                    { new Guid("57a01456-ccbf-447a-9de5-da9786e5acfa"), "自然科学研究人员", 7, "ZRKXYJRY" },
                    { new Guid("50507d36-3b7f-4f75-8482-8bb19c676c6f"), "社会科学研究人员", 8, "SHKXYJRY,SKKXYJRY" },
                    { new Guid("734e5891-782e-441f-bbbb-0451c5a46e49"), "中等专业学校教师", 3, "ZDZYXJJS,ZDZYXXJS" },
                    { new Guid("4be3223e-d59b-48ec-872c-f255a45dbebb"), "实验技术人员", 10, "SYJSRY,SYJZRY" },
                    { new Guid("4af2b1d3-8534-417f-8c72-d87c15b13054"), "工程技术人员", 9, "GCJSRY,GCJZRY" },
                    { new Guid("eb024f2b-b71d-40b6-8f78-c159da68aeb8"), "审计专业人员", 14, "SJZYRY" },
                    { new Guid("4df9751c-794d-4bd2-b5d1-f6172aae0bf6"), "新闻专业人员", 16, "XWZYRY" },
                    { new Guid("459e9951-dbab-4cba-b3dc-a40d21597653"), "经济专业人员", 12, "JJZYRY" },
                    { new Guid("f4d7f217-c9d4-44fc-819f-4f9b76bf1251"), "农业技术人员", 11, "NYJSRY,NYJZRY" },
                    { new Guid("97809a94-375a-4ff3-8425-3db31dbb6e25"), "会计专业人员", 13, "HJZYRY,KJZYRY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("c866b73d-e175-48ba-a4b8-3966c3b3060a"), "临床", 1, "LC" },
                    { new Guid("1df24171-b9d9-4561-8ac9-58ff375c6171"), "公卫", 3, "GW" },
                    { new Guid("3889c8fa-ae75-49cc-a6ad-40cc15a24daa"), "中医", 4, "ZY" },
                    { new Guid("19584e5b-2a59-4455-a1fb-0b4b4261bac2"), "口腔", 2, "KQ" }
                });

            migrationBuilder.InsertData(
                table: "SysEmpType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("3618b688-81ea-491b-8d52-d4c0395205ff"), "实习进修", 9, "SXJX" },
                    { new Guid("bb43bbfd-e941-452d-86aa-d1bb130b1b73"), "内部退养", 15, "NBTY" },
                    { new Guid("9b8a3003-364e-480d-a30d-1fe40c48c03e"), "编外离岗人员", 14, "BWLGRY" },
                    { new Guid("85c4d797-ae34-412c-8b39-35e20a8e1d9a"), "停薪留职人员", 13, "TXLZRY" },
                    { new Guid("75cb1ed5-8f58-4674-b10a-5f7b41650a78"), "自动离职人员", 12, "ZDLZRY" },
                    { new Guid("94d24c8f-de05-4478-9868-6f975a5a8106"), "长期出国人员", 11, "CJCGRY,ZJCGRY,CQCGRY,ZQCGRY" },
                    { new Guid("faa980e5-fe9c-4d8f-8790-443d623bbc03"), "借出人员", 10, "JCRY" },
                    { new Guid("1a545a94-8962-4a2e-ac80-ed0dd2a128a1"), "除名人员", 8, "CMRY" },
                    { new Guid("322689f2-887f-48d7-a3d3-3c56ab44e654"), "返聘人员", 6, "FPRY" },
                    { new Guid("c22c2d00-988c-4a4d-85ee-7e1589998aa4"), "辞职人员", 5, "CZRY" },
                    { new Guid("c9ae695a-7c89-4134-a4ca-701bc9ac23f7"), "离退人员", 4, "LTRY" },
                    { new Guid("a9f4f196-9002-4fac-b26b-0ca93e672399"), "临时人员", 3, "LSRY" },
                    { new Guid("ef5ed46a-35dd-4b70-88ac-c4d63ef854c7"), "人事代理", 2, "RSDL" },
                    { new Guid("bf66b173-e71d-45c4-8f24-aaf1002cf0d2"), "在编人员", 1, "ZBRY" },
                    { new Guid("2882b1e2-201d-4fdb-9ad6-44c577e1268d"), "调出人员", 7, "DCRY,TCRY" }
                });

            migrationBuilder.InsertData(
                table: "SysNavbar",
                columns: new[] { "Code", "Action", "Controller", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("92976039-acb0-4720-87b9-b95a1d8f8b7c"), "Index", "SysDept", "科室信息", 17, "KSXX", new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e") },
                    { new Guid("f794757c-b9de-4085-868f-fae969e45c23"), "Index", "ComDegree", "学位", 16, "XW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("171c4970-a8bf-4b9a-9203-3632be6b5825"), "Index", "ComEducation", "学历", 15, "XL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("060e9524-063f-43a6-bc96-5758b02db582"), "Index", "SysEmpType", "人员类别", 14, "RYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("9749c47b-add7-4fd1-8bbf-ee42525b3ad5"), "Index", "ComAdminDuty", "行政职务", 13, "HZZW,XZZW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("7cc0cad2-1699-4b52-be52-15c34bbb7d70"), "Index", "ComProfessionType", "执业类别", 12, "ZYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("e91d9a58-b7e8-4e4d-aa54-e11f91cc2f0e"), "Index", "ComProfessionExtent", "执业范围", 11, "ZYFW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("0c611254-e79f-44d4-bc66-9093cbe04dd3"), "Index", "ComProfessionRegister", "执业资格", 10, "ZYZG", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("85804855-ee8f-42a1-a411-522a41eda690"), "Index", "ComPolitical", "政治面貌", 6, "ZZMM", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("ccb7a3ec-389d-45d9-ab6d-b660c3909f3d"), "Index", "ComProfessionTitleLevel", "职称级别", 8, "ZCJB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("d5c4dbee-58e1-47fb-b701-28715799ea15"), "Index", "ComProfessionTitle", "职称", 7, "ZC", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("cc93f42f-3f72-41a0-b960-0fc280ae12f7"), "Index", "ComNation", "民族", 5, "MZ", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("0653fc1f-0aa7-4f25-8054-809177ff0168"), "Index", "ComPost", "岗位", 4, "GW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("44c91c33-e155-4bdd-9576-8f4a958cd561"), "Index", "ComGender", "性别", 3, "XB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("7e8df3ef-a890-4190-98b1-f321cc08c553"), "Index", "SysNavbar", "菜单", 2, "CC,CD,CS", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("6788ca66-14bc-4db3-a6e6-7be3987159a4"), "Index", "SysNavbarType", "菜单类别", 1, "CCLB,CDLB,CSLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("8ff3e5db-d5f3-4a2b-ad42-f7e5ed6d83e4"), "Index", "SysEmp", "人员管理", 18, "RYGL", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") },
                    { new Guid("3e337836-0ef4-46a3-9850-999565b16d0d"), "Index", "ComProfessionTitleType", "职称系列", 9, "ZCJL,ZCXL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("29a6b3ff-2d9a-44ce-87ab-2604c48a45cf"), "Index", "SysProfessionInfo", "职称评定", 19, "ZCPD", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("00c0fb0a-790d-4eb2-98cc-702dab79ea08"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("02baddf4-c358-4287-9f73-fc7e26efc037"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("17a9acb7-5538-4217-8334-26159a1444c5"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("476f6ed6-cb59-4c5a-919f-4d34fdad6cd4"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("477e0415-4b10-4d44-8fff-af7b46818b01"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("5650c098-4c99-4ed8-a82d-878027b5f50d"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("74101e58-9957-47b5-8fb6-c69ff448a11d"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("783e110b-8dae-4877-a52b-e9e57a9d1da9"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("7f50fde9-2e4c-4627-8ae3-c9b2987c2c84"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("836700ed-6f5e-431f-a3c4-0c2d3a51c09c"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("8720ac63-1168-43b9-ae73-d9997dcaba7c"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("d80b331a-0f8c-4182-bdbe-c02410cff7a5"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("ea2ce311-d891-4462-8a7e-26e7a378c7ba"));

            migrationBuilder.DeleteData(
                table: "ComAdminDuty",
                keyColumn: "Code",
                keyValue: new Guid("f83a3a08-7985-454f-a34f-e3683d21d4f4"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("28c874d8-4f22-4ffa-bb9c-a44d3200f7b5"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("3fd09490-0217-4629-b854-86c1aa08b60d"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("45ebca26-6683-4c1b-9d2b-6037daeb5ec4"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("98ca7720-fdce-4b0b-894a-0a58cbf8bb79"));

            migrationBuilder.DeleteData(
                table: "ComDegree",
                keyColumn: "Code",
                keyValue: new Guid("e5781fb6-9656-4611-81dd-7dd417cd734e"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("1841e737-dfba-4638-97a2-3d887e433a65"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("19e5de04-1d98-4440-be39-35e1ed8291a8"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("22903bdd-c22b-476b-b1c1-e5c663714b21"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("2886fc90-4149-480e-8029-35870d1fb60f"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("4c54ffa9-59fa-4374-8c14-8d283be7e501"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("834463f5-0e49-4730-b1b2-45e1e9ff993a"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("e3d08f45-b217-4cfa-abda-f0e65cdfde3b"));

            migrationBuilder.DeleteData(
                table: "ComEducation",
                keyColumn: "Code",
                keyValue: new Guid("f7ef9c66-a461-446c-95ec-51c16a3c3c5d"));

            migrationBuilder.DeleteData(
                table: "ComGender",
                keyColumn: "Code",
                keyValue: new Guid("c4997de5-7dfd-41c0-a822-a2eb42d02a74"));

            migrationBuilder.DeleteData(
                table: "ComGender",
                keyColumn: "Code",
                keyValue: new Guid("e1beb0cc-860a-4406-b548-55b88b44728a"));

            migrationBuilder.DeleteData(
                table: "ComMarriage",
                keyColumn: "Code",
                keyValue: new Guid("0679549d-ac21-4b70-8207-5a865c62d4f0"));

            migrationBuilder.DeleteData(
                table: "ComMarriage",
                keyColumn: "Code",
                keyValue: new Guid("4096da9e-acef-48ef-9a17-5783f0404353"));

            migrationBuilder.DeleteData(
                table: "ComMarriage",
                keyColumn: "Code",
                keyValue: new Guid("40b2269a-a2b4-4e49-a846-1fda107f5ad4"));

            migrationBuilder.DeleteData(
                table: "ComMarriage",
                keyColumn: "Code",
                keyValue: new Guid("80917b34-dfea-4017-88f2-cb1319c1fe64"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("02a9ea4b-405b-4c92-b679-e44ad61537fe"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("099beb73-00a7-4c57-94d8-94232914da79"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("0aafde19-e376-4024-9c86-701cfd73661a"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("0ec87847-12b4-4fe4-a4e2-c3635f0e16fe"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("0fd61088-5c57-4a18-bf99-e3c9b93f9bb5"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("107dd205-4c59-4f48-8981-ede79ed0a443"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("1fa15e3e-8e40-4b24-9407-7c8526443460"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("2058dcfd-033a-4615-9d03-686293a311de"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("21b75187-24b2-47d6-8a6c-3154606dbcfa"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("28dddf49-f2a2-4cac-91f6-cc130cb84dd2"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("2a52360b-f7fe-42e5-b060-5482e47b24ce"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("345a082e-e839-43dd-959c-fff8a4029aa6"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("392cd28e-4dd1-47f9-a62a-7af9166eba27"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("3b330621-0ae1-4b08-9cdc-7888012c69aa"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("3f5c6fa7-e1f9-4e7d-967a-51bfe4275f57"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("412747bf-9a23-4d68-82dd-d33dc921100c"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("42f0be92-1696-44c6-a02a-ce0cb2677c67"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("46fdb393-1002-465e-82e2-6062f65dbb46"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("47c5001b-b9fc-4995-872c-7f9403200191"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("48d9b39c-6445-4e13-b331-374a03fdd2db"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("51e95735-0810-40b4-9eee-a2882e60857d"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("5bf29641-366a-4dc3-a9ff-aed64ba10fdb"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("5bf5b103-0580-41ab-9d60-34f5cc4bc042"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("609f4844-4c8d-47ff-836d-06cdbb809258"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("654cd922-36c0-4092-a460-8f483707e14e"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("67736ba4-76f5-4f5b-9007-9e628895c228"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("68440cd8-ee6f-4cd6-8da8-b4332259aaae"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("68846386-efc4-4cc5-b97e-e9710e264bf7"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("6b82ca5f-49ba-4658-9ede-b9a1efe3f101"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("6c03cb0b-4e91-4ff7-a4b9-a5192de2779a"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("6d468b7a-d064-4c2e-b310-d27866fcb6c5"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("6f621ccb-77c5-4ab2-9d09-3d1fee235105"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("7b5b1bc0-d833-4bb7-87e1-68562bc8874c"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("8110c7f3-79dc-4aee-af2d-bc14ab03da5e"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("8c84f969-5635-4bcc-bd00-a9fa2c64a45f"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("8cb48cb8-4ca5-4ddf-9ed2-bc5ddc82f5f1"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("98cb5363-c602-43d8-a4eb-262326689ab9"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("a20e2acd-bb92-477e-9393-703655b0b896"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("a81176d2-1db1-4c66-b6d0-07a70b7b33ff"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("ad6a47a0-b8c8-486b-87a6-10f330ca6661"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("b51bf4cd-c77c-48b5-b189-5c65865ed42d"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("b9cbc4b1-1f3e-4e41-a8d2-3611ae7c2697"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("bc197037-4838-4256-9dfb-a80dc9f0cfad"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("bef03d93-d487-48ff-bb16-58d69d0ac983"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("c3c7ad0c-7830-4efe-95c7-226a138fae4e"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("c436293c-5142-4276-904c-0744270c924e"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("c5cb2b10-ecf4-44e4-aee9-36eec15c3491"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("cf06ff99-65b9-43fa-8c97-5801ea7d4b4e"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("d5d7dcf4-a80e-4db5-b758-56cdf1d395ff"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("d6a08418-d594-4d87-b611-9d14c0dfc7d2"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("d6bcb0dd-48da-487f-a3d6-c90dd3e80d60"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("d6c248f0-817f-42ce-8e74-04ec2c1f35c1"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("da6a04f9-54b4-4604-b804-05269870a1bd"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("e5653cbf-d897-4428-8fda-0957e35ae131"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("e6a44627-245c-45db-a3d5-c91b36ea39be"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("ee626dea-dc23-4537-9dea-c6a22a20ec37"));

            migrationBuilder.DeleteData(
                table: "ComNation",
                keyColumn: "Code",
                keyValue: new Guid("f80d635c-d191-4040-be72-dd27597c5c13"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("04a66db1-373b-45a6-b85a-2d5ed016a069"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("09823386-810b-43dd-bfea-d9a265c9d96a"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("3c606957-01a5-4f69-8a41-5ce4f61e25ee"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("3d5961ca-def7-4ea3-b211-3a6a8e5bd789"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("3e214932-54bf-4062-847b-153b8fdbd4d3"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("577948c2-f6e8-4bc7-817a-baff537c4aa6"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("732f83d0-a33f-47ab-81a6-8be55072aba2"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("817b6186-3b44-44bc-a53d-452997ada768"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("bdc8dd1c-ffdc-4e4c-b135-98927d6ba720"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("c2e9a0b6-c6cb-45fe-b708-5e467fa44fd1"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("eeb3fa49-db8f-4e5d-b4e9-c766aa37f916"));

            migrationBuilder.DeleteData(
                table: "ComPolitical",
                keyColumn: "Code",
                keyValue: new Guid("f955b073-9cd9-4398-a14e-49930792c1ea"));

            migrationBuilder.DeleteData(
                table: "ComPost",
                keyColumn: "Code",
                keyValue: new Guid("6729cccb-ec0b-4833-9a6b-cc08c83e80b7"));

            migrationBuilder.DeleteData(
                table: "ComPost",
                keyColumn: "Code",
                keyValue: new Guid("cc4be172-3a70-4527-bb81-85a3d3263902"));

            migrationBuilder.DeleteData(
                table: "ComProfessionExtent",
                keyColumn: "Code",
                keyValue: new Guid("16bd271a-455d-4628-b4f8-aafe3aa0975a"));

            migrationBuilder.DeleteData(
                table: "ComProfessionExtent",
                keyColumn: "Code",
                keyValue: new Guid("268c2131-45f1-47ed-8dde-16783b1edc17"));

            migrationBuilder.DeleteData(
                table: "ComProfessionRegister",
                keyColumn: "Code",
                keyValue: new Guid("24a292b7-3f8a-481c-8213-b4746006a66c"));

            migrationBuilder.DeleteData(
                table: "ComProfessionRegister",
                keyColumn: "Code",
                keyValue: new Guid("f05b6055-df4f-4553-92df-b370b2098915"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("2c0c89d4-7234-4ec5-9d43-8d383e5f041f"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("31bcdad8-e042-4eda-849c-ef16e0ee9866"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("40137f92-2d2d-4a11-979e-1eee9880c29c"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("40d4048c-4adb-4a6a-ae23-d1d100283ddf"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("427ee48f-3538-46bc-8299-62eb22bdff27"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("46a8e35c-0b78-413a-a903-8d5168cece09"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("60f9436c-1759-45b7-a769-8e0b470c8157"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("65b4615c-cbf2-4b42-bf10-9db91b017c93"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("8ea6e4f8-6572-4399-8868-79ce1177bdc5"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("90f778f5-afd2-4ba3-8f69-e8f3df0feced"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("91c2762b-5106-470b-a48b-c7a30ed56448"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("9269643a-ed6d-48f8-b194-03ed40161047"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("a7dd45a6-ed8f-418b-a6ec-b958639857ef"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("b17c7f30-898b-44dc-8250-99dd71887801"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("c7440693-58fa-45ec-8b6d-db61c56c8e25"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("d2944a4d-4ffa-4cbe-af8f-f9142404a44c"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("d2fc5f48-53ff-475d-a409-6b02df3e06d9"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("db8385a8-a7ba-47a6-96d5-f65bd8614754"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("de35c520-6a4d-44e5-8b61-698450aaa8c8"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("e237376c-3ee8-4f42-9a52-c59f8cdc89c6"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitle",
                keyColumn: "Code",
                keyValue: new Guid("e4687b51-9b24-4ee7-8e46-5e9bdeda6ae4"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("16b33dca-63fd-42fa-b78e-1e6928f519bf"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("17154a18-d356-4f70-beb4-1ea48e64165a"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("171859a0-8cdf-48ae-b5a9-ea402d49d833"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("1fc4162a-71a1-4d81-8968-6cb984eeda49"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("23633498-581b-4389-8ae9-15b3bced2213"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("32cf3bd3-d24d-45cc-8d6e-6543871f81ab"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("353564d2-88f1-4048-9311-ab1bad850505"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("459e9951-dbab-4cba-b3dc-a40d21597653"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("4af2b1d3-8534-417f-8c72-d87c15b13054"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("4be3223e-d59b-48ec-872c-f255a45dbebb"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("4df9751c-794d-4bd2-b5d1-f6172aae0bf6"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("50507d36-3b7f-4f75-8482-8bb19c676c6f"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("57a01456-ccbf-447a-9de5-da9786e5acfa"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("5a9d5634-9a87-448b-874a-0d789e48279e"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("696c46ef-9c2d-4162-95b3-c3dc4682f6b8"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("734e5891-782e-441f-bbbb-0451c5a46e49"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("8269bc07-59fa-49aa-b98e-a9fd292d260b"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("8a14987a-bb5a-4ffd-bb79-b5e42b331ddf"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("97809a94-375a-4ff3-8425-3db31dbb6e25"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("98a639d3-06dd-4544-a10b-2bef36d6edd9"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("a0d81440-ac53-49de-9d9f-dfe20a6f0d4e"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("a6092819-ec93-43fb-9ac0-a1efc165686c"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("b8fdbfb5-e8f2-4236-b610-b6ee23d6f9da"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("baf4d991-e4e1-4505-808a-93291d1adc1f"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("c564f2a7-f9ed-4c27-924b-6540a599eb08"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("cad66d6e-44f6-41a9-bb7b-73416438cb1b"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("eb024f2b-b71d-40b6-8f78-c159da68aeb8"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("f4d7f217-c9d4-44fc-819f-4f9b76bf1251"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("f7856921-aa48-400b-bc64-160377736e8c"));

            migrationBuilder.DeleteData(
                table: "ComProfessionTitleType",
                keyColumn: "Code",
                keyValue: new Guid("f82eea27-c506-4a06-bbff-d35fa4727337"));

            migrationBuilder.DeleteData(
                table: "ComProfessionType",
                keyColumn: "Code",
                keyValue: new Guid("19584e5b-2a59-4455-a1fb-0b4b4261bac2"));

            migrationBuilder.DeleteData(
                table: "ComProfessionType",
                keyColumn: "Code",
                keyValue: new Guid("1df24171-b9d9-4561-8ac9-58ff375c6171"));

            migrationBuilder.DeleteData(
                table: "ComProfessionType",
                keyColumn: "Code",
                keyValue: new Guid("3889c8fa-ae75-49cc-a6ad-40cc15a24daa"));

            migrationBuilder.DeleteData(
                table: "ComProfessionType",
                keyColumn: "Code",
                keyValue: new Guid("c866b73d-e175-48ba-a4b8-3966c3b3060a"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("1a545a94-8962-4a2e-ac80-ed0dd2a128a1"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("2882b1e2-201d-4fdb-9ad6-44c577e1268d"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("322689f2-887f-48d7-a3d3-3c56ab44e654"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("3618b688-81ea-491b-8d52-d4c0395205ff"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("75cb1ed5-8f58-4674-b10a-5f7b41650a78"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("85c4d797-ae34-412c-8b39-35e20a8e1d9a"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("94d24c8f-de05-4478-9868-6f975a5a8106"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("9b8a3003-364e-480d-a30d-1fe40c48c03e"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("a9f4f196-9002-4fac-b26b-0ca93e672399"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("bb43bbfd-e941-452d-86aa-d1bb130b1b73"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("bf66b173-e71d-45c4-8f24-aaf1002cf0d2"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("c22c2d00-988c-4a4d-85ee-7e1589998aa4"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("c9ae695a-7c89-4134-a4ca-701bc9ac23f7"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("ef5ed46a-35dd-4b70-88ac-c4d63ef854c7"));

            migrationBuilder.DeleteData(
                table: "SysEmpType",
                keyColumn: "Code",
                keyValue: new Guid("faa980e5-fe9c-4d8f-8790-443d623bbc03"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("060e9524-063f-43a6-bc96-5758b02db582"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("0653fc1f-0aa7-4f25-8054-809177ff0168"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("0c611254-e79f-44d4-bc66-9093cbe04dd3"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("171c4970-a8bf-4b9a-9203-3632be6b5825"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("29a6b3ff-2d9a-44ce-87ab-2604c48a45cf"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("3e337836-0ef4-46a3-9850-999565b16d0d"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("44c91c33-e155-4bdd-9576-8f4a958cd561"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("6788ca66-14bc-4db3-a6e6-7be3987159a4"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("7cc0cad2-1699-4b52-be52-15c34bbb7d70"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("7e8df3ef-a890-4190-98b1-f321cc08c553"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("85804855-ee8f-42a1-a411-522a41eda690"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("8ff3e5db-d5f3-4a2b-ad42-f7e5ed6d83e4"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("92976039-acb0-4720-87b9-b95a1d8f8b7c"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("9749c47b-add7-4fd1-8bbf-ee42525b3ad5"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("cc93f42f-3f72-41a0-b960-0fc280ae12f7"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("ccb7a3ec-389d-45d9-ab6d-b660c3909f3d"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("d5c4dbee-58e1-47fb-b701-28715799ea15"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("e91d9a58-b7e8-4e4d-aa54-e11f91cc2f0e"));

            migrationBuilder.DeleteData(
                table: "SysNavbar",
                keyColumn: "Code",
                keyValue: new Guid("f794757c-b9de-4085-868f-fae969e45c23"));

            migrationBuilder.InsertData(
                table: "ComAdminDuty",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("3fec702d-4290-403e-8059-a76cf8b75ac3"), "院长", 1, "YC,YZ" },
                    { new Guid("d22b321e-bf7d-42d4-b0fb-83a5453b7049"), "副院长", 2, "FYC,FYZ" },
                    { new Guid("5bdf4b49-780d-4ef9-8b2a-3001127eb556"), "书记", 3, "SJ" },
                    { new Guid("e30f5863-4891-448a-b7d3-9abd0bf62d3a"), "副书记", 4, "FSJ" },
                    { new Guid("680de19b-b9dd-4e4c-9d33-a21350276507"), "团委书记", 5, "TWSJ" },
                    { new Guid("8d56384e-6fd1-4d29-af7b-b92091df2cd2"), "团委副书记", 6, "TWFSJ" },
                    { new Guid("53b18bbb-fa4f-4cbd-8edd-b46a2d016971"), "大科主任", 7, "DKZR" },
                    { new Guid("80b6ca1e-2d1a-4163-ae83-cb22b560718a"), "科主任", 8, "KZR" },
                    { new Guid("2127bb90-131e-4552-971c-4601cde0d4fa"), "副主任", 9, "FZR" },
                    { new Guid("bc0b0bd2-96c7-42db-bb58-07ff6d18b14d"), "护士长", 10, "HSC,HSZ" },
                    { new Guid("bc275333-e563-4631-9463-5a028b67a9b1"), "副护士长", 11, "FHSC,FHSZ" },
                    { new Guid("06b15f21-b1bb-43ef-9b85-25c5cc7d1896"), "科员", 12, "KY" },
                    { new Guid("e7f3a3f2-215f-4a8d-813f-6860164e0734"), "干事", 13, "GS" },
                    { new Guid("d1f707c7-f979-46aa-af12-b073c02e2006"), "返聘", 14, "FP" }
                });

            migrationBuilder.InsertData(
                table: "ComDegree",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("065f8555-559e-431e-b487-4bf6a1481d7e"), "无", 5, "M,W" },
                    { new Guid("3e4b550a-5547-4a69-b415-897821663135"), "学士", 4, "XS" },
                    { new Guid("aa1f8735-4405-4515-92db-40f8c7c2022e"), "博士", 2, "BS" },
                    { new Guid("ab48042c-bda5-4a90-adf3-5faaaee7b837"), "博士后", 1, "BSH" },
                    { new Guid("fe23815f-bf5b-409f-8193-3e1e8cfd4a95"), "硕士", 3, "SS" }
                });

            migrationBuilder.InsertData(
                table: "ComEducation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("af94de61-4372-4c0d-89ea-eed6b641d471"), "博士研究生", 1, "BSYJS" },
                    { new Guid("36a55f45-2bf4-49a1-bd79-40557c2fc87c"), "硕士研究生", 2, "SSYJS" },
                    { new Guid("598c7ada-5b5d-47c7-a412-be4095d2a7e6"), "本科", 3, "BK" },
                    { new Guid("6525dca8-5ace-4742-8f40-b375dc2c6387"), "专科", 4, "ZK" },
                    { new Guid("2f1e73bb-d863-4c09-b454-5650e0f5eee8"), "中专", 5, "ZZ" },
                    { new Guid("dd4643ca-51ba-41b5-a3b3-804f68e774e8"), "高中及以下", 6, "GZJYX" },
                    { new Guid("ebebd4bd-b10d-4299-9dd7-9b1c13a112c3"), "技校", 7, "JJ,JX" },
                    { new Guid("8dcff26e-1c87-4fc9-bb5c-47a0e0083589"), "其他", 8, "JT,QT" }
                });

            migrationBuilder.InsertData(
                table: "ComGender",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("1cbcbc78-c7cc-4c94-8958-fbc666189eb4"), "男", 1, "N" },
                    { new Guid("39110852-a554-4fda-8e20-26cedb375910"), "女", 2, "N" }
                });

            migrationBuilder.InsertData(
                table: "ComMarriage",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("81209711-0f91-4e9e-8517-e570a3daa0e3"), "离婚", 4, "LH" },
                    { new Guid("ee4eaf9b-1fed-4957-bc5b-c9f64b1d807e"), "丧偶", 3, "SO" },
                    { new Guid("d9c7ebcd-9b3c-410c-be39-684add01eb7c"), "已婚", 2, "YH" },
                    { new Guid("27c4e2d0-bd62-4610-b03e-e45b79cdaaee"), "未婚", 1, "WH" }
                });

            migrationBuilder.InsertData(
                table: "ComNation",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("820810bd-5ede-4f49-9642-998475b83454"), "羌族", 33, "QZ" },
                    { new Guid("9cd0e643-ad5a-4992-9f12-7db858f77633"), "布朗族", 34, "BLZ" },
                    { new Guid("0589c66a-031e-4965-ae0b-3c03740a5246"), "撒拉族", 35, "SLZ" },
                    { new Guid("f37fccef-028a-4992-8324-202a653f2d2f"), "毛难族", 36, "MNZ" },
                    { new Guid("a067463b-1b88-4d31-9b60-75a462787c56"), "仡佬族", 37, "GLZ,YLZ" },
                    { new Guid("1dd61069-79fc-4377-953e-ffb103752e41"), "锡伯族", 38, "XBZ" },
                    { new Guid("84834f70-f616-45a3-a99d-1f89f66d5cf6"), "阿昌族", 39, "ACZ,ECZ" },
                    { new Guid("1be8ad52-7ffb-4640-8ddd-bf14c81997d3"), "普米族", 40, "PMZ" },
                    { new Guid("935ff2e6-a94a-4b4e-8747-3bf03c965598"), "塔吉克族", 41, "DJKZ,TJKZ" },
                    { new Guid("416518d7-8d6a-47fa-88e5-982e9841da37"), "怒族", 42, "NZ" },
                    { new Guid("1a996aa2-28af-409b-83ad-ef41db992c35"), "乌孜别克族", 43, "WZBKZ" },
                    { new Guid("beb67fca-8653-4e10-89eb-062c8c28ad5f"), "俄罗斯族", 44, "ELSZ" },
                    { new Guid("1effed20-217e-4a72-9882-9d77b053fd35"), "仫佬族", 32, "MLZ" },
                    { new Guid("c25b7dec-7f8e-4ac6-ae26-25b13933578e"), "鄂温克族", 45, "EWKZ" },
                    { new Guid("59f573e1-d4a9-46c7-a300-5bbcf3153a77"), "保安族", 47, "BAZ" },
                    { new Guid("2212d7bf-d7ce-46c7-831b-432577f36837"), "裕固族", 48, "YGZ" },
                    { new Guid("ee00813f-3401-42e2-8776-78cffa6c51d9"), "京族", 49, "JZ" },
                    { new Guid("e5a52fdd-aba5-4962-8ce8-5d097f9971fc"), "塔塔尔族", 50, "DDEZ,TDEZ,DTEZ,TTEZ" },
                    { new Guid("cfb6c6b9-82e0-4519-abf9-6a7319769e2f"), "独龙族", 51, "DLZ" },
                    { new Guid("3841088d-340b-4698-9e33-0d0712d1deed"), "鄂伦春族", 52, "ELCZ" },
                    { new Guid("76d931a7-5c41-4e29-8876-ce7bc7874aec"), "赫哲族", 53, "HZZ" },
                    { new Guid("7eca8f40-c45f-468f-84a3-8da870605efb"), "门巴族", 54, "MBZ" },
                    { new Guid("7a7d33f6-ebed-40ba-ab1c-a227cefc73dc"), "珞巴族", 55, "LBZ" },
                    { new Guid("27c80eac-9213-4e13-87c1-31eff1108be0"), "基诺族", 56, "JNZ" },
                    { new Guid("6ebef184-425c-492e-890b-3374f4ab8e7b"), "其他", 57, "JT,QT" },
                    { new Guid("66135bba-724f-4147-bc66-3f20f602f04a"), "外国血统中国人士", 58, "WGXTZGRS" },
                    { new Guid("59f237e3-3f63-4283-864b-ff38be3ec7a6"), "崩龙族", 46, "BLZ" },
                    { new Guid("e4b073ea-eeef-4df8-afc1-026303cb6546"), "达斡尔族", 31, "DWEZ" },
                    { new Guid("25f1245c-3b6f-4c84-adee-d62f78db3c4c"), "哈尼族", 16, "HNZ" },
                    { new Guid("a3701e7a-662b-44e3-9f94-80de18c3e367"), "柯尔克孜族", 29, "KEKZZ" },
                    { new Guid("11cab3ba-e9e7-4993-a515-03b71d6d1587"), "蒙古族", 2, "MGZ" },
                    { new Guid("a1be7c6b-c5ae-4aa0-8fd6-639ca4d1e20c"), "回族", 3, "HZ" },
                    { new Guid("ffcb28c7-5347-47e0-8952-89c882cc7e1d"), "藏族", 4, "CZ,ZZ" },
                    { new Guid("18c5dada-149b-4c30-868a-025935e83700"), "维吾尔族", 5, "WWEZ" },
                    { new Guid("b6271a27-2898-48b8-a523-2a78a57fcbae"), "苗族", 6, "MZ" },
                    { new Guid("0101fe13-7f5f-4795-a32c-26725480f142"), "彝族", 7, "YZ" },
                    { new Guid("52fa0e86-db7b-4d30-88ae-64693f5f6d84"), "壮族", 8, "ZZ" },
                    { new Guid("214d7404-8154-407a-88e3-074bc886f0e2"), "布依族", 9, "BYZ" },
                    { new Guid("0094ae61-da07-40e7-8dd6-05a5ef36b9ea"), "朝鲜族", 10, "CXZ,ZXZ" },
                    { new Guid("e8107920-ae2a-4b50-888f-aeb3ea389a99"), "满族", 11, "MZ" },
                    { new Guid("451ce873-cad9-4f61-b99c-cbf19dbcd431"), "侗族", 12, "DZ,TZ" },
                    { new Guid("3f70ba16-4880-4976-946c-6640a3be8436"), "土族", 30, "TZ" },
                    { new Guid("7cca7a8d-42e4-4908-a4f8-6d1b9fb54586"), "白族", 14, "BZ" },
                    { new Guid("06f5c961-aad4-4f02-834d-34fcbc01c304"), "瑶族", 13, "YZ" },
                    { new Guid("8978384d-0ff6-4191-a027-3bb6187ae1ba"), "拉祜族", 24, "LHZ" },
                    { new Guid("91cb2100-35e2-40f5-9086-5df0cd8f594d"), "哈萨克族", 17, "HSKZ" },
                    { new Guid("3ec59f39-6bf8-4052-aeb8-cf5a6d55606b"), "傣族", 18, "DZ" },
                    { new Guid("b31d1d47-9158-4861-bdb6-0218def1dada"), "黎族", 19, "LZ" },
                    { new Guid("3ab6afdc-24cd-433b-98a3-c22e81a48f7a"), "傈僳族", 20, "LSZ" },
                    { new Guid("c44f2064-1e65-4589-b3d2-a8f650a3c78a"), "佤族", 21, "WZ" },
                    { new Guid("0004470b-17ad-4f12-ae05-40c338d97e6c"), "畲族", 22, "SZ" },
                    { new Guid("63fadaaa-c221-4214-b6cd-4ee8bb0d5130"), "高山族", 23, "GSZ" },
                    { new Guid("0a400814-49ff-44af-8924-d294ed5263dd"), "土家族", 15, "TGZ,TJZ" },
                    { new Guid("dd7a8396-964c-465d-90ea-18043f269a25"), "水族", 25, "SZ" },
                    { new Guid("d6108846-0cf2-484c-8327-785c63a5b0ec"), "东乡族", 26, "DXZ" },
                    { new Guid("2229dfc4-2ef4-4a2b-abaf-bb2dde71e5a3"), "纳西族", 27, "NXZ" },
                    { new Guid("2c062c88-e993-43fa-b9ad-4f15ed50d7d3"), "景颇族", 28, "JPZ" }
                });

            migrationBuilder.InsertData(
                table: "ComPolitical",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("00575efc-b43b-4a73-b1bf-4858c2f18101"), "九三学社社员", 10, "JSXSSY" },
                    { new Guid("cf7f0db9-5c84-4f3c-8483-326a9d2b08a4"), "致公党党员", 9, "ZGDDY" },
                    { new Guid("375bebe3-d412-4497-9356-9fb0ecb33979"), "无党派人士", 12, "MDPRS,WDPRS" },
                    { new Guid("ecfd6bca-2847-4183-95a5-271399c44f86"), "台盟盟员", 11, "TMMY" },
                    { new Guid("d36d4db7-632f-4ced-bca7-76bce39c6173"), "农工党党员", 8, "NGDDY" },
                    { new Guid("d91b4fbd-640c-4537-b619-b9c7f4652081"), "民进会员", 7, "MJHY,MJKY" },
                    { new Guid("9b8b3378-0284-49c9-97e5-0da1ab7c680c"), "民建会员", 6, "MJHY,MJKY" },
                    { new Guid("1d4765c7-d13a-48f7-9e11-33d9c74e4bf5"), "民盟盟员", 5, "MMMY" },
                    { new Guid("a493a95d-3968-40b0-a8d6-2fc5a3e0da1a"), "民革党员", 4, "MGDY,MJDY" },
                    { new Guid("3580ef9e-7125-4e7f-812e-e21d2eaff385"), "共青团员", 3, "GQTY" },
                    { new Guid("95b9f284-c121-4f74-971e-60899f760429"), "中共预备党员", 2, "ZGYBDY" },
                    { new Guid("4494bcf7-c97f-4351-a322-377853d326f5"), "中共党员", 1, "ZGDY" }
                });

            migrationBuilder.InsertData(
                table: "ComPost",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("1d7007dd-7235-4804-a272-12473b05bc8a"), "卫", 1, "W" },
                    { new Guid("c67aa674-a5ac-4776-940d-10c76e3ba5bf"), "工", 2, "G" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionExtent",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("d2239660-a82b-4e1f-92fe-6dd7525b026b"), "护理专业", 1, "HLZY" },
                    { new Guid("fed126a6-1425-4b9f-a8ab-2f985fbda75f"), "外科专业", 2, "WKZY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionRegister",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("9e8ce404-db80-452e-9292-8b0b703926eb"), "执业医师", 2, "ZYYS" },
                    { new Guid("b5c2dfe6-3951-4b79-889c-798228ded7e1"), "执业护士", 1, "ZYHS" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitle",
                columns: new[] { "Code", "LevelCode", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("bb3efbc8-8195-4911-b109-e8dc25b6f211"), new Guid("2d9f5ae2-a9b1-497f-97f4-e31cfe6f0ba0"), "无职称", 21, "MZC,WZC", new Guid("f20164e3-99ce-42ba-ac19-f6bd740ed46c") },
                    { new Guid("fa618b39-ab46-45d1-b9af-dcf930dd4859"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技士", 20, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("334e733d-f743-491d-b135-ba58f356165b"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "技师", 19, "JS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("dd3f18e5-f6ff-4c0b-9a4e-6c72847655c6"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护士", 18, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("52264a28-9d61-438f-8aa0-63240ce993b4"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "护师", 17, "HS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("ce3a3816-6e96-4dd7-a363-a7f41335621e"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药士", 16, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("f982fd67-6584-4da9-89aa-5d9579224592"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "药师", 15, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("18c4334c-6701-4d40-a3a2-7387d520e609"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医士", 14, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("2ef6498f-2156-4ae0-86cc-aedeee9ac4cb"), new Guid("4e8d76cd-5bc0-4281-8e68-446a8b649b82"), "医师", 13, "YS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("1a950b6f-1e90-48d8-8d16-68b247209a79"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管护师", 11, "ZGHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("16304a5d-79ac-490a-9f15-8837636d6523"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管技师", 12, "ZGJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("61da1618-8db4-4b34-abb0-2fef82bc49a0"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任药师", 2, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("28d18652-63d8-42a2-988e-9a40f79aea9f"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主治医师", 9, "ZZYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("f1cdae05-ec1f-4900-9251-5d729a0ee8ea"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任技师", 8, "FZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("4ae234ff-9e5b-4731-8d99-3f93c6786a99"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任护师", 7, "FZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("1fb12ef6-3257-448a-972a-497e94fd8fcb"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任药师", 6, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("12e1adeb-1169-41e4-933d-5034e1656b05"), new Guid("4ef010d0-5c7e-4e38-bcff-fffcd69627cf"), "副主任医师", 5, "FZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("71714970-1440-4d6e-8521-3b30d9c0214e"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任技师", 4, "ZRJS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("b826e1d6-ffd0-41dc-8b54-e55fed35f91c"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任护师", 3, "ZRHS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("e8add0e9-c7fd-4e18-8230-c00f4835c11b"), new Guid("9ee36b90-1e89-4591-b849-9d79badce3a8"), "主任医师", 1, "ZRYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") },
                    { new Guid("7724bb4a-1105-4cdf-9f7d-b99175351595"), new Guid("f469629a-4d6d-4640-804b-f2e5c44f5ca4"), "主管药师", 10, "ZGYS", new Guid("b9bbcf12-f2c7-48e1-9ece-12068ac58768") }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionTitleType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("a6e0eb8f-6bb5-4c5a-91f1-5d7f9cad4cb7"), "翻译人员", 22, "FYRY" },
                    { new Guid("a2bd6753-e7b0-4300-9932-3e4ca886e38f"), "广播电视播音人员", 21, "ABDSBYRY,GBDSBYRY" },
                    { new Guid("6c30e2c3-55d9-49ec-8f2e-7ceb85a95ab1"), "图书资料专业人员", 18, "TSZLZYRY" },
                    { new Guid("a509bf10-d072-48e6-98a8-c0626a0b6bc9"), "文物博物专业人员", 19, "WWBWZYRY" },
                    { new Guid("86ac6438-543a-4c19-8d59-aa103a6ac5b8"), "律师", 23, "LS" },
                    { new Guid("238b9d42-6d10-4523-9c15-57e9d0d453fb"), "档案专业人员", 20, "DAZYRY" },
                    { new Guid("6be12002-d489-405a-be90-c4350d675db2"), "公证员", 24, "GZY" },
                    { new Guid("62ea2e20-89f9-4b16-a78e-b7c43cc7bac8"), "工艺美术专业人员", 29, "GYMSZYRY,GYMZZYRY" },
                    { new Guid("632fa798-e852-4ce1-91a0-b2e3734ba01e"), "船舶技术人员", 26, "CBJSRY,CBJZRY" },
                    { new Guid("2800c85e-eef2-49b9-86da-a1610e1c8bf4"), "民用航空飞行技术人员", 27, "MYHKFHJSRY,MYHKFXJSRY,MYHKFHJZRY,MYHKFXJZRY" },
                    { new Guid("942622db-41e1-456e-aef8-87e19adfebf8"), "艺术专业人员", 28, "YSZYRY,YZZYRY" },
                    { new Guid("a875771f-d030-45a7-a3f2-22428ba31d1b"), "体育教练员", 30, "TYJLY" },
                    { new Guid("f3452967-8456-4996-8c70-0c3127daffbc"), "思想政治工作人员", 31, "SXZZGZRY" },
                    { new Guid("f7ee47bd-ce17-4151-9309-fff8fa8534f2"), "海关人员", 25, "HGRY" },
                    { new Guid("3ab98224-31ad-4184-8def-c2d6bc57f41c"), "出版专业人员", 17, "CBZYRY" },
                    { new Guid("6f87fa29-dbc0-4cd1-b99e-5cd28c844d35"), "会计专业人员", 13, "HJZYRY,KJZYRY" },
                    { new Guid("f22a5b51-0a54-47c7-a396-e88b9b3bf66e"), "统计专业人员", 15, "TJZYRY" },
                    { new Guid("5df5a1e4-bda8-4b8f-a5e8-83a598fc7a37"), "新闻专业人员", 16, "XWZYRY" },
                    { new Guid("a7b20501-2da0-4099-ae55-bda79381ac36"), "高等学校教师", 2, "GDXJJS,GDXXJS" },
                    { new Guid("2ceb2a55-6609-4602-9ae8-9a46978bed8d"), "技工学校教师", 4, "JGXJJS,JGXXJS" },
                    { new Guid("997dffc8-4904-4f63-8a5a-fb115e3edae2"), "中学教师", 5, "ZXJS" },
                    { new Guid("16751b23-8f72-4d40-a60c-e5e75e19e32c"), "小学（幼儿园）教师", 6, "XX（YEY）JS" },
                    { new Guid("403c3b08-c9e5-474e-b2b9-526954ca96b3"), "自然科学研究人员", 7, "ZRKXYJRY" },
                    { new Guid("09ea9c13-2639-4bd9-9431-30fcda21f800"), "中等专业学校教师", 3, "ZDZYXJJS,ZDZYXXJS" },
                    { new Guid("cd001c66-1045-4571-a609-43cfe032b1df"), "工程技术人员", 9, "GCJSRY,GCJZRY" },
                    { new Guid("453551dd-d672-4221-b4a4-d446e10b1354"), "实验技术人员", 10, "SYJSRY,SYJZRY" },
                    { new Guid("646585d8-115a-447e-af48-1cfeb7614643"), "农业技术人员", 11, "NYJSRY,NYJZRY" },
                    { new Guid("76494471-894c-433a-972a-642ed1d05929"), "经济专业人员", 12, "JJZYRY" },
                    { new Guid("a432ebaf-1398-401e-815d-ab94ff674ee4"), "审计专业人员", 14, "SJZYRY" },
                    { new Guid("3b613654-324b-4a8c-a752-ec55005b3981"), "社会科学研究人员", 8, "SHKXYJRY,SKKXYJRY" }
                });

            migrationBuilder.InsertData(
                table: "ComProfessionType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("049aca76-a429-4945-952b-cd792823fcf4"), "中医", 4, "ZY" },
                    { new Guid("d3f15955-b585-418d-8391-28495dfb47f1"), "公卫", 3, "GW" },
                    { new Guid("80b9200a-99e1-4ee9-a7c9-cade73d73654"), "临床", 1, "LC" },
                    { new Guid("6db24fe9-1d97-449d-9637-8c31a45ab991"), "口腔", 2, "KQ" }
                });

            migrationBuilder.InsertData(
                table: "SysEmpType",
                columns: new[] { "Code", "Name", "Sort", "Spell" },
                values: new object[,]
                {
                    { new Guid("4191fa72-007e-474a-9177-316963c09e8a"), "内部退养", 15, "NBTY" },
                    { new Guid("40198c10-ad88-4810-b55b-cbcefe6e11d4"), "编外离岗人员", 14, "BWLGRY" },
                    { new Guid("fd863878-e499-47e0-a06d-def8e936642e"), "借出人员", 10, "JCRY" },
                    { new Guid("3c750202-5964-406e-a207-36125fe66f96"), "停薪留职人员", 13, "TXLZRY" },
                    { new Guid("3739ca89-ba4c-49e0-a669-8ee9801ce02f"), "自动离职人员", 12, "ZDLZRY" },
                    { new Guid("50d55a83-529d-4bb5-a31a-6e617e3aa294"), "长期出国人员", 11, "CJCGRY,ZJCGRY,CQCGRY,ZQCGRY" },
                    { new Guid("e8450549-1d3d-44fa-998e-d04480e5af0d"), "实习进修", 9, "SXJX" },
                    { new Guid("4a3210d3-67db-4463-ad79-468e0a358dad"), "人事代理", 2, "RSDL" },
                    { new Guid("ff97d6d5-09db-4a55-9542-c2103e015241"), "调出人员", 7, "DCRY,TCRY" },
                    { new Guid("db4e3706-ccde-433a-8356-def5451273a6"), "返聘人员", 6, "FPRY" },
                    { new Guid("d3e60eb3-cc44-476b-850a-fa167166f824"), "辞职人员", 5, "CZRY" },
                    { new Guid("e0e97799-2ea7-410b-9073-ecc4cdc70fdc"), "离退人员", 4, "LTRY" },
                    { new Guid("f6e19408-3016-42d2-9945-74d7690009ed"), "临时人员", 3, "LSRY" },
                    { new Guid("32058174-22f0-4aeb-9bc6-385599c173af"), "在编人员", 1, "ZBRY" },
                    { new Guid("3df65b5c-d0f1-4643-9677-d3d982269c96"), "除名人员", 8, "CMRY" }
                });

            migrationBuilder.InsertData(
                table: "SysNavbar",
                columns: new[] { "Code", "Action", "Controller", "Name", "Sort", "Spell", "TypeCode" },
                values: new object[,]
                {
                    { new Guid("639e945c-ffc7-47d5-b248-267167e423b1"), "Index", "ComAdminDuty", "行政职务", 9, "HZZW,XZZW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("ce5b8299-120a-4a39-a760-a18b89a79056"), "Index", "SysDept", "科室信息", 14, "KSXX", new Guid("c4aa85c9-bd15-47e7-bc1f-b7fd24c7a52e") },
                    { new Guid("747b47e8-453f-461a-bfa0-35055dcdb870"), "Index", "ComMarriage", "婚姻状况", 13, "HYZK", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("9896efad-210a-44de-a367-6ecba6d749ee"), "Index", "ComDegree", "学位", 12, "XW", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("db7bb185-ca7c-4996-8a81-92b6e7f9ee68"), "Index", "ComEducation", "学历", 11, "XL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("a66f30d0-fa30-4a50-b865-913da3751dfc"), "Index", "SysEmpType", "人员类别", 10, "RYLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("8f582a69-04c1-44c2-8d00-9c301c007b1d"), "Index", "ComProfessionTitle", "职称", 8, "ZC", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("ad136c8c-9398-4d1e-af3a-bbc75f6c4c16"), "Index", "SysEmp", "人员管理", 15, "RYGL", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") },
                    { new Guid("0affccb2-ff6d-431d-82a6-36b3ab7e405f"), "Index", "ComProfessionTitleType", "职称系列", 6, "ZCJL,ZCXL", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("0e411a24-4fc2-4c9a-a60c-d5e88421c80e"), "Index", "ComPolitical", "政治面貌", 5, "ZZMM", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("ea54d9f5-5ba4-40d3-9804-e5547c0b64dc"), "Index", "ComNation", "民族", 4, "MZ", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("42782c5e-59f8-4608-80fc-8ca87ed9470c"), "Index", "ComGender", "性别", 3, "XB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("466863a1-c2c4-47b0-b668-1f1cc3e044de"), "Index", "SysNavbar", "菜单", 2, "CC,CD,CS", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("de74243f-4389-4765-b89c-771dd8718b63"), "Index", "SysNavbarType", "菜单类别", 1, "CCLB,CDLB,CSLB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("2feee364-c732-467c-a0a3-e516f30f0356"), "Index", "ComProfessionTitleLevel", "职称级别", 7, "ZCJB", new Guid("4d3c3953-fd9e-4df1-aa18-3285e020d4bc") },
                    { new Guid("fb676bcd-a480-4893-8eba-a92e8f7f089d"), "Index", "SysProfessionInfo", "职称评定", 16, "ZCPD", new Guid("f356c105-78d1-4d16-bb8d-a48fc1072993") }
                });
        }
    }
}
