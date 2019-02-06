function removecolor() {
    let colorSelect = document.getElementById('colorSelect');

    for (let i = 0; i < colorSelect.selectedOptions.length; i++) {
        let option = colorSelect.selectedOptions[i];
        option.outerHTML = '';
    }
}