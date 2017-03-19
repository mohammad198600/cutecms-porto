// Initialize your tinyMCE Editor with your preferred options
tinyMCE.PluginManager.add('stylebuttons', function (editor, url) {
    ['pre', 'p', 'code', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6'].forEach(function (name) {
        editor.addButton("style-" + name, {
            tooltip: "Toggle " + name,
            text: name.toUpperCase(),
            onClick: function () { editor.execCommand('mceToggleFormat', false, name); },
            onPostRender: function () {
                var self = this, setup = function () {
                    editor.formatter.formatChanged(name, function (state) {
                        self.active(state);
                    });
                };
                editor.formatter ? setup() : editor.on('init', setup);
            }
        })
    });
});
tinyMCE.init({
    mode: "textareas",
    editor_selector: "mceEditor",
    height: 400,
    theme: "modern",
    browser_spellcheck: true,
    plugins: [
        "directionality advlist autolink lists link image charmap print preview hr anchor pagebreak",
        "searchreplace wordcount visualblocks visualchars code fullscreen",
        "insertdatetime media nonbreaking save table contextmenu directionality",
        "emoticons template paste textcolor colorpicker textpattern imagetools stylebuttons"
    ],
    toolbar1: "insertfile undo redo | bold italic underline strikethrough | alignleft aligncenter alignright alignjustify | ltr rtl | bullist numlist outdent indent | style-p style-h1 style-h2 style-h3 style-h4 style-h5 style-h6 | print preview",
    toolbar2: "link image media | forecolor backcolor emoticons",
    inline_styles: false,
    valid_styles: { '*': 'color,background-color,font-weight,font-style,text-decoration' },
    paste_preprocess: function (pl, o) {
        //o.content = strip_tags(o.content, '');
        o.content = strip_tags(o.content, '<script><b><h1><h2><h3><h4><h5><h6><strong><u><ul><li><i><p><br><img><table><th><tr><td><caption><colgroup><col><thead><tbody><tfoot>'); // use this i.e. to keep some tags
    },
    contextmenu: 'link image inserttable | tableprops cell row column deletetable',
    entity_encoding: 'raw',
    paste_auto_cleanup_on_paste: true,
    relative_urls: false,

    file_browser_callback: RoxyFileBrowser
});
function strip_tags(input, allowed) {
    allowed = (((allowed || '') + '')
      .toLowerCase()
      .match(/<[a-z][a-z0-9]*>/g) || [])
      .join(''); // making sure the allowed arg is a string containing only tags in lowercase (<a><b><c>)
    var tags = /<\/?([a-z][a-z0-9]*)\b[^>]*>/gi,
      commentsAndPhpTags = /<!--[\s\S]*?-->|<\?(?:php)?[\s\S]*?\?>/gi;
    return input.replace(commentsAndPhpTags, '')
      .replace(tags, function ($0, $1) {
          return allowed.indexOf('<' + $1.toLowerCase() + '>') > -1 ? $0 : '';
      });
}
function RoxyFileBrowser(field_name, url, type, win) {
    var roxyFileman = '/fileman/index.html';
    if (roxyFileman.indexOf("?") < 0) {
        roxyFileman += "?type=" + type;
    }
    else {
        roxyFileman += "&type=" + type;
    }
    roxyFileman += '&input=' + field_name + '&value=' + win.document.getElementById(field_name).value;
    if (tinyMCE.activeEditor.settings.language) {
        roxyFileman += '&langCode=' + tinyMCE.activeEditor.settings.language;
    }
    tinyMCE.activeEditor.windowManager.open({
        file: roxyFileman,
        title: 'File Manager',
        width: 850,
        height: 650,
        resizable: "yes",
        plugins: "media",
        inline: "yes",
        close_previous: "no"
    }, { window: win, input: field_name });
    return false;
}