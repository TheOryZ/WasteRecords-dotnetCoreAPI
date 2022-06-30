// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.dataTable').DataTable({
        "scrollX": true

    });
});
function SweetAlert(state, title, text, redirectUrl) {
    let timerInterval
    Swal.fire({
        position: 'center',
        icon: state,
        title: title,
        html: text,
        showConfirmButton: false,
        timer: 1500,
        didOpen: () => {
            const b = Swal.getHtmlContainer().querySelector('b')
            timerInterval = setInterval(() => {
                b.textContent = Swal.getTimerLeft()
            }, 100)
        },
        willClose: () => {
            clearInterval(timerInterval)
        }
    }).then((result) => {
        /* Read more about handling dismissals below */
        if (result.dismiss === Swal.DismissReason.timer) {
            if (state == "success") {
                location.href = redirectUrl;
            }
        }
    })

}
