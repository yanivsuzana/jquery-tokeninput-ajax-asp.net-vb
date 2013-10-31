﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="textjs.WebForm1" %>
<html>
<head>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>


    <script src="src/jquery.tokeninput.js" type="text/javascript"></script>
    <link rel="stylesheet" href="styles/token-input.css" type="text/css" />
    <link rel="stylesheet" href="styles/token-input-facebook.css" type="text/css" />

    <script type="text/javascript">
        $(document).ready(function () {


            $("input[type=button]").click(function () {
                alert("Would submit: " + $(this).siblings("input[type=text]").val());
            });


        });
    </script>
</head>

<body>
    <h1>jQuery Tokeninput Demos</h1>

    


 


    <h2 id="theme">Facebook Theme</h2>
    <div>
        <input type="text" id="demo-input-facebook-theme" name="blah2" value="" />
        <input type="button" value="Submit" />
        <script type="text/javascript">
            var firsttime = 0;
            $(document).ready(function () {

                $("#demo-input-facebook-theme").tokenInput(function () {
                    return 'http://localhost/textjs/tokeninput/search.ashx?query='  + $("#token-input-demo-input-facebook-theme").val();
                }, { theme: "facebook" });

            











            });
        </script>
    </div>


   



    
  
</body>
</html>