function openMobileMenu() {
    const menu = document.getElementById("navigation-dropdown-menu");
    
    if (!menu.classList.contains("mobile-menu-open")) {
        menu.classList.add("mobile-menu-open");
    } else {
        menu.classList.remove("mobile-menu-open");

    }
}

function Test(item) {
    console.log(item)
}
