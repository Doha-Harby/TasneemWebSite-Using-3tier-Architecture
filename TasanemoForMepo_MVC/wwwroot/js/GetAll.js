
// تفعيل tooltips
var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl)
});

// وظيفة البحث
function searchTable() {
    var input = document.getElementById("searchInput");
    var filter = input.value.toUpperCase();
    var table = document.getElementById("patientsTable");
    var tr = table.getElementsByTagName("tr");

    for (var i = 1; i < tr.length; i++) {
        var td = tr[i].getElementsByTagName("td")[0]; // عمود الاسم
        if (td) {
            var txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}

// وظيفة التصفية
function filterTable() {
    var filter = document.getElementById("filterSelect").value;
    var table = document.getElementById("patientsTable");
    var tr = table.getElementsByTagName("tr");

    for (var i = 1; i < tr.length; i++) {
        var measurementsCount = parseInt(tr[i].getElementsByTagName("td")[2]?.innerText || "0");

        if (filter == "all") {
            tr[i].style.display = "";
        } else if (filter == "hasMeasurements" && measurementsCount > 0) {
            tr[i].style.display = "";
        } else if (filter == "noMeasurements" && measurementsCount == 0) {
            tr[i].style.display = "";
        } else {
            tr[i].style.display = "none";
        }
    }
}
function confirmDelete() {
    return confirm('هل أنت متأكد من عملية الحذف؟');
}