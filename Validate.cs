using System;

namespace HospitalPersonnelSystem
{
    /// <summary>
    /// 验证提示
    /// </summary>
    public class Validate
    {
        /// <summary>
        /// 必填
        /// </summary>
        public const string Required = "【{0}】 为必填。";
        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public const string Email = "请输入有效的电子邮件地址。";
        /// <summary>
        /// 网址
        /// </summary>
        public const string Url = "请输入有效的网址。";
        /// <summary>
        /// 日期
        /// </summary>
        public const string Date = "【{0}】 请输入有效的日期。";
        /// <summary>
        /// 日期 (YYYY-MM-DD)
        /// </summary>
        public const string DateISO = "【{0}】 请输入有效的日期 (YYYY-MM-DD)。";
        /// <summary>
        /// 有效数字
        /// </summary>
        public const string Number = "【{0}】 请输入有效的数字。";
        /// <summary>
        /// 只能数字
        /// </summary>
        public const string Digits = "【{0}】 只能输入数字。";
        /// <summary>
        /// 信用卡
        /// </summary>
        public const string Creditcard = "请输入有效的信用卡号码。";
        /// <summary>
        /// 不相同
        /// </summary>
        public const string EqualTo = "你的输入不相同。";
        /// <summary>
        /// 后缀
        /// </summary>
        public const string Extension = "请输入有效的后缀。";
        /// <summary>
        /// 最大字符
        /// </summary>
        public const string StringLengthMax = "【{0}】 最多可以输入 {1} 个字符。";
        /// <summary>
        /// 最小字符
        /// </summary>
        public const string StringLengthMin = "【{0}】 最少要输入 {0} 个字符。";
        /// <summary>
        /// 之间字符
        /// </summary>
        public const string StringLength = "【{0}】 请输入长度在 {1} 到 {2} 之间的字符。";
        /// <summary>
        /// 范围数值
        /// </summary>
        public const string Range = "【{0}】 请输入范围在 {1} 到 {2} 之间的数值。";
        /// <summary>
        /// 整数倍
        /// </summary>
        public const string Step = "【{0}】 请输入 {1} 的整数倍值。";
        /// <summary>
        /// 不大于
        /// </summary>
        public const string Max = "【{0}】 请输入不大于 {1} 的数值。";
        /// <summary>
        /// 不小于
        /// </summary>
        public const string Min = "【{0}】 请输入不小于 {1} 的数值。";
        /// <summary>
        /// 不正确
        /// </summary>
        public const string Compare = "【{0}】 不正确。";
        /*
        required: "这是必填字段",
        remote: "请修正此字段",
        email: "请输入有效的电子邮件地址",
        url: "请输入有效的网址",
        date: "请输入有效的日期",
        dateISO: "请输入有效的日期 (YYYY-MM-DD)",
        number: "请输入有效的数字",
        digits: "只能输入数字",
        creditcard: "请输入有效的信用卡号码",
        equalTo: "你的输入不相同",
        extension: "请输入有效的后缀",
        maxlength: $.validator.format( "最多可以输入 {0} 个字符" ),
        minlength: $.validator.format( "最少要输入 {0} 个字符" ),
        rangelength: $.validator.format( "请输入长度在 {0} 到 {1} 之间的字符串" ),
        range: $.validator.format( "请输入范围在 {0} 到 {1} 之间的数值" ),
        step: $.validator.format( "请输入 {0} 的整数倍值" ),
        max: $.validator.format( "请输入不大于 {0} 的数值" ),
        min: $.validator.format( "请输入不小于 {0} 的数值" )
        */
    }
}
