let themeTinymce = window.matchMedia('(prefers-color-scheme: dark)').matches;

let tinymceConfig = 
{
    selector: 'textarea#default',
    skin: ( themeTinymce ? 'oxide-dark' : 'oxide'),
    content_css: (themeTinymce ? 'dark' : 'default'),
    menubar: false,
    statusbar: false,
    plugins: [
        'advlist', 'autolink',
        'lists', 'link', 'image', 'charmap', 'preview', 'anchor', 'searchreplace', 'visualblocks',
         'fullscreen', 'insertdatetime', 'media', 'table', 'help', 'wordcount'
    ],
    toolbar: 'undo redo | a11ycheck casechange blocks | bold italic backcolor | alignleft aligncenter alignright alignjustify | bullist numlist checklist outdent indent | removeformat | code table help',
    height: 500
    // init_instance_callback: function (editor) {
    //     editor.on('focus', function (e) 
    //     {
    //         console.log('Editor got focus!');
    //         $("#mdlAddAndUpdate .modal-body div.row:not(#test)").fadeOut(1500)
    //     });
    //     editor.on('blur', function (e) 
    //     {
    //         console.log(e);
    //         $("#mdlAddAndUpdate .modal-body div.row:not(#test)").fadeIn(1500)
    //     });
    // }
};
$(document).ready(() =>
{
    window.matchMedia('(prefers-color-scheme: dark)')
    .addEventListener('change',({ matches }) => {
            changeTinymceTheme(matches);
        });

    tinymce.init(tinymceConfig);
});

function changeTinymceTheme(matches)
{
    tinymce.remove();
    tinymceConfig.skin = (matches ? 'oxide-dark' : 'oxide');
    tinymceConfig.content_css = (matches ? 'dark' : 'default');
    tinymce.init(tinymceConfig);
}