.show-menu {
    font-family: "Helvetica Neue", Helvetica, Arial, sans-serif;
    text-decoration: none;
    border-top: 1px solid #ddd;
    text-align: center;
    padding: 10px 0;
    display: none;
    cursor: pointer;
}
/*Hide checkbox*/
input[type=checkbox]{
    display: none;
}
/*Show menu when invisible checkbox is checked*/
input[type=checkbox]:checked ~ #menu{
    display: block;
}
/*Responsive Styles*/
@media screen and (max-width : 760px){
    /*Make dropdown links appear inline*/
    ul {
        position: static;
        display: none;
    }
    /*Create vertical spacing*/
    li {
        margin-bottom: 1px;
        border-bottom: 1px solid #ddd;
    }
    /*Make all menu links full width*/
    ul li, li a {
        width: 100%;
    }
    /*Display 'show menu' link*/
    .show-menu {
        display:block;
    }
}
