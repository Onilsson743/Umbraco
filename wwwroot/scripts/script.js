function openMobileMenu() {
    const menu = document.getElementById("navigation-dropdown-menu");
    
    if (!menu.classList.contains("mobile-menu-open")) {
        menu.classList.add("mobile-menu-open");
    } else {
        menu.classList.remove("mobile-menu-open");
    }
}

function closePopUpWindow() {
    const popupwindow = document.getElementById("popup-window");

    popupwindow.classList.add("d-none");
}

function scrollToPosition(amount, item) {
    var scrollDiv = document.getElementById("scrollable-article-div")

    for (i = 0; i < 4; i++) {
        var scrollButtonId = "articleBarScrollTo" + i
        var scollButton = document.getElementById(scrollButtonId)
        try {
            scollButton.classList.remove("active")
        } catch (e) { }
        
    }

    scrollDiv.scrollTo({
        left: amount,
        behavior: "smooth",
    });

    item.classList.add("active")
    
}


