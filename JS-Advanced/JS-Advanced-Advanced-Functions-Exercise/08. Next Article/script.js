function getArticleGenerator(articles) {
    let copyArticles = Array.from(articles);
    let divTarget = document.getElementById("content");

    return function(){
        let articleText = copyArticles.shift();
        if(articleText.length <= 0 || articleText == undefined){
            return;
        }
        let articleEl = document.createElement('article');
        articleEl.textContent = articleText;
        divTarget.appendChild(articleEl);
    }
}
