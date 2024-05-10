const theme = window.matchMedia('(prefers-color-scheme: dark)');
changeTheme(theme.matches);
changeThemeAdmin(theme.matches);


window.matchMedia('(prefers-color-scheme: dark)')
            .addEventListener('change',({ matches }) => {
                    changeTheme(matches);
                    changeThemeAdmin(matches);
                });

function changeTheme(matches) {
    if (matches) {
        $("html").removeClass("theme-skin-light").addClass("theme-skin-dark");
    } else {
        $("html").removeClass("theme-skin-dark").addClass("theme-skin-light");
    }
}

function changeThemeAdmin(matches) {
    if (matches) {
        $("body").attr("data-bs-theme", "dark");
    } else {
        $("body").attr("data-bs-theme", "light");
    }
}