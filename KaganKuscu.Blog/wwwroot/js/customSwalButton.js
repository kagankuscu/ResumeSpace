const themeColor = window.matchMedia('(prefers-color-scheme: dark)');

const SwalToast = Swal.mixin
({
    toast: true,
    position: "top-end", 
    showConfirmButton: false,
    timer: 3000,
    timerProgressBar: true,
    background: themeColor.matches ? "#2C2E3B" : "#fff", 
    color: themeColor.matches ? "#fff" : "#2C2E3B" ,
    didOpen: (toast) => {
        toast.onmouseenter = Swal.stopTimer;
        toast.onmouseleave = Swal.resumeTimer;
    }
});
    
const SwalSave = Swal.mixin
({
    title: "Kaydetmek istediğinizden emin misiniz ?",
    icon: "warning",
    showCancelButton: true,
    confirmButtonText: "Kaydet",
    cancelButtonText: "İptal",
    confirmButtonColor: "#198754",
});

const SwalRemove = Swal.mixin
({
    title: "Silmek istediğinizde emin misiniz ?",
    icon: "warning",
    showCancelButton: true,
    confirmButtonText: "Sil",
    cancelButtonText: "İptal",
    confirmButtonColor: "#dc3545",
});

const SwalAlert = Swal.mixin ({
    icon: "error",
    title: "Oops...",
    text: "You have entered an invalid username or password",
    timer: 3000,
    timerProgressBar: true
});