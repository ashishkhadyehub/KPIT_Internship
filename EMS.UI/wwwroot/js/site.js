$(document).ready(function () {
    $('#tableEmployees').DataTable({
        dom: 'lBfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print', 'colvis'
        ],
        "scrollY": "450px",
        "scrollCollapse": true,
        "paging": true
    });
});
