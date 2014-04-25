$(document).ready(function(){
    attachCakePagination();
});

function attachCakePagination() {
    $(document).on("click", ".pagination a", function () {
        if ($("#cakeList").length > 0) {
            if ($(this).parent().attr("class") == "active")
                return false;
            $('html,body').animate({
                scrollTop: 100
            }, '1500000000');
            var pageUrl = $(this).attr("href");

            $.ajax({
                type: "POST",
                url: pageUrl,
                data: {
                    CatId: $("#catId").val()
                },
                traditional: true,
                dataType: 'html',
                success: function (resp, st, xhr) {
                    if (st == "success") {
                        $("#cakeList").html(resp);
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                }
            });
            return false;
        }
        return true;
    });
};
