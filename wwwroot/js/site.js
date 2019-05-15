//拼音码
$(function () {
    $('[data-spell="name"]').change(function () {
        var name = $(this).val();
        $.get("/Home/GetSpell?chinese=" + encodeURI(name), function (result) {
            $('[data-spell="spell"]').val(result);
        });
    });
});
//提示
$(function () {
    $('[data-toggle="tooltip"]').tooltip();
});
//排序
$(function () {
    $('[data-sort="table"]').tablesorter({
        //此选项将向表“TableSorter-Theme”中添加一个主题CSS类名
        theme: "bootstrap",
        //是否固定列宽度
        widthFixed: true,
        //加载窗口小部件，
        widgets: ["filter", "columns", "zebra"],
        //窗口小部件配置
        widgetOptions:{
            //奇偶行样式
            zebra: ["even", "odd"],
            //排序时加入class名称
            columns: ["primary", "secondary", "tertiary"],
            //查询重置按钮
            filter_reset: ".reset",
            //查询框的class名称
            filter_cssFilter:[
                'form-control',
                'form-control',
                'form-control',
                'form-control',
                'form-control',
                'form-control',
                'form-control',
                'form-control',
                'form-control',
                'form-control custom-select',
                'form-control',
                'form-control',
                'form-control',
                'form-control',
                'form-control',
                'form-control custom-select',
                'form-control'
            ]
        }
    }).tablesorterPager({
        // 分页class名称
        container: $(".ts-pager"),
        // 分页页面跳转class名称
        cssGoto: ".pagenum",
        // remove rows from the table to speed up the sort of large tables.
        // setting this to false, only hides the non-visible rows; needed if you plan to add/remove rows with the pager enabled.
        removeRows: false,
        // output string - default is '{page}/{totalPages}';
        // possible variables: {page}, {totalPages}, {filteredPages}, {startRow}, {endRow}, {filteredRows} and {totalRows}
        output: '{startRow} - {endRow} / {filteredRows} ({totalRows})'
    });
});
// 默认值当前时间
function getdate() {
    var now = new Date();
    //alert(now.getDate() + '-' + now.getMonth());
    //格式化日，如果小于9，前面补0
    var day = ("0" + now.getDate()).slice(-2);
    //格式化月，如果小于9，前面补0
    var month = ("0" + (now.getMonth() + 1)).slice(-2);
    //拼装完整日期格式
    return now.getFullYear() + "-" + (month) + "-" + (day);
}