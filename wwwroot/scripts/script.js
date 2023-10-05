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

function scrollArticleRowToPosition(amount, id) {
    var scrollDiv = document.getElementById("scrollable-article-div")
    var idName = "articleBarScrollTo" + id
    var thisitem = document.getElementById(idName)


    for (i = 1; i < 5; i++) {
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

    thisitem.classList.add("active")
    
}

function scrollEmployeeRowToPosition(amount, id) {
    var scrollDiv = document.getElementById("scrollable-employee-cards-div")
    var idName = "employeesBarScrollTo" + id
    var thisitem = document.getElementById(idName)


    for (i = 1; i < 5; i++) {
        var scrollButtonId = "employeesBarScrollTo" + i
        var scollButton = document.getElementById(scrollButtonId)
        try {
            scollButton.classList.remove("active")
        } catch (e) { }

    }

    scrollDiv.scrollTo({
        left: amount,
        behavior: "smooth",
    });

    thisitem.classList.add("active")

}


function ValidateEmail() {
    var input_value = document.getElementById("FormEmail").value;
    var regex_email = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    var errorMessage = document.getElementById("EmailError")
    var errorMessageP = document.getElementById("EmailErrorP")

    if (regex_email.test(input_value)) {
        errorMessage.innerHTML = ""
        errorMessageP.classList.add("d-none")        
    }
    else {
        errorMessage.innerHTML = "Please fill in a valid email (example@domain.com)"
        errorMessageP.classList.remove("d-none")        
    }
}


