// --- ajax file upload start ---
$(document).ready(function() {
    if (document.getElementById('file-uploader') != null) {
        var uploader = new qq.FileUploader({
            element: document.getElementById('file-uploader'),
            action: relativePath + 'Cake/UploadImages',
            allowedExtensions: ['jpg', 'jpeg', 'png', 'gif'],
            //sizeLimit: 1048576,
            onComplete: function(id, fileName, responseJSON) {
                $('.qq-upload-list').html('');
                $('#PhotoUrl').val(responseJSON.ImageName);
                $('#companyImage').attr('src', relativePath + 'Content/CakeImages/CakeTemp/' + responseJSON.ImageName);
            }
        });
    }
    $(".qq-upload-button").click(function(e) {
        $("#file123").click();
    });
});