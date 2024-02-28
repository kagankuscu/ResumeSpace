const theme = window.matchMedia('(prefers-color-scheme: dark)');
changeTheme(theme.matches);


window.matchMedia('(prefers-color-scheme: dark)')
            .addEventListener('change',({ matches }) => {
                    changeTheme(matches);
                });

function changeTheme(matches) {
    if (matches) {
        $("html").removeClass("theme-skin-light").addClass("theme-skin-dark");
    } else {
        $("html").removeClass("theme-skin-dark").addClass("theme-skin-light");
    }
}