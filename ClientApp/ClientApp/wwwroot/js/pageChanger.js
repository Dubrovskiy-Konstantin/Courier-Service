//function changeOn(newPageId) {
//    console.log(`change on ${newPageId}`)
//    document.querySelectorAll('.page').forEach(page => {
//        if (!page.classList.contains('invisible')) {
//            page.classList.add("invisible");
//        }
//    });
//    document.querySelector(newPageId).classList.remove("invisible");

//    document.querySelectorAll('.navbutton').forEach(button => {
//        if (button.classList.contains('active')) {
//            button.classList.remove("active");
//        }
//    });

//    if (['#home', '#contacts', '#feature'].includes(newPageId)) {
//        document.querySelector(`${newPageId}-button`).classList.add("active");
//    }
//}

//window.onpopstate = function (event) {
//    const newPageId = window.location.hash;
//    if (newPageId) {
//        console.log('Now on ' + newPageId);
//        changeOn(newPageId);
//    }
//    else {
//        console.log('Now on #home');
//        changeOn("#home");
//    }
//};

//(() => {
//    if (!window.location.hash) {
//        window.location.hash = '#home';
//    }
//    let newPageId = window.location.hash;
//    //console.log(newPageId);
//    changeOn(newPageId);
//})();