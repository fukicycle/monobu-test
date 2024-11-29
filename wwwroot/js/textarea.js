function loadedTextArea() {
    const inputTextArea = document.getElementById('editor');
    const submitButton = document.getElementById('submitButton');
    inputTextArea.onkeydown = function (e) {
        console.log(e.key);
        if (e.key === 'Tab') {
            this.setRangeText('\t', this.selectionStart, this.selectionStart, 'end');
            return false;
        }
        if (e.key === 'Enter' && e.ctrlKey) {
            submitButton.click();
        }
    }
}