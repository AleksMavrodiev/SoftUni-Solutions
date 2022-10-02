function editElement(element, match, replacement) {
    const content = element.textContent;
    const matcher = new RegExp(match, 'g');
    const edited = content.replace(matcher, replacement);
    element.textContent = edited;
}