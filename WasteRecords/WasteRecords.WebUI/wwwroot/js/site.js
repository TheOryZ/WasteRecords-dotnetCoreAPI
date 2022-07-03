// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    var myTable = $('.dataTable').DataTable({
        "scrollX": true

    });

    $('.dataTables_filter input')
        .unbind('keypress keyup')
        .bind('keypress keyup', function (e) {
            if ($(this).val().length < 2 && e.keyCode != 13) return;
            myTable.fnFilter($(this).val());
        });
    $("#DataTables_Table_0_wrapper > div").css('margin-bottom', '10px')
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

function RemoveItem(id) {

    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        /* Read more about isConfirmed, isDenied below */
        if (result.isConfirmed) {
            debugger;
            $.ajax({
                url: '/Home/Remove/' + id,
                type: "DELETE",
                data: { id: id },
                success: function (data) {
                    if (data.success) {
                        $("#" + id).css('background', 'gray');
                        $("#" + id).fadeOut(800, function () {
                            $(this).remove();
                        });
                        SweetAlert('success', '', data.message, '')
                    }
                    else {
                        SweetAlert('error', '', data.message, '')
                    }

                },
                error: function (data) {
                    debugger;
                    SweetAlert('error', '', data.message, '')

                }
            });
        } else if (result.isDenied) {
            Swal.fire({
                title: 'Delete Operation canceled',
                confirmButtonText: 'Okay'
            })
        }
    })
}
