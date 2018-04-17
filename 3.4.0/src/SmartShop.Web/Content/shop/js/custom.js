document.write('<div id="htDiv" style="display: none; position: fixed;top: 0px;z-index: 999;width: 100%;height: 100%;"><div class="htMask" style="position: absolute;width: 100%;height: 100%;background-color: rgb(0, 0, 0);opacity: 0.6;"></div><img src="/content/shop/images/img_114renzheng.png" alt="" style="position: absolute; top: 50%; left: 50%; width: 7rem; max-width:80%; height: auto; padding: 0.15rem; transform: translate(-50%, -50%);"></div>')


$(document).ready(function () {
    $('.copyright').on('click', function () {
        $('#htDiv').show();
    });
    $('#htDiv').on('click', function () {
        $('#htDiv').hide();
    });


});

// 获取购物车商品数量
function getcart() {
    $.get("/shop/GetCartCount", function (result) {
        var el = $('.navmenu i');
        if (result > 0) {
            el.text(result);
            el.show();
        }
        else {
            el.hide();
        }
    });
}