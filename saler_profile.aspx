<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="saler_profile.aspx.cs" Inherits="Comecar.saler_profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="StyleSheet1.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
<link href="https://getbootstrap.com/docs/5.3/assets/css/docs.css" rel="stylesheet">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
     <style>
    main {
        z-index: 1;
    }

    aside {
        z-index: 2;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <header>
        <div class="header-description">
            <small>
                Come Car
            </small>
            <small style="font-size:15px">Fast Buy Fast Sell</small>
        </div>
        <div class="authentication-link">
            <ul>
                <li>
                    <a href="login.hmtl"> Log In<sub>(for salers)</sub></a>
                </li>
                <li>
                    <a href="register.aspx"> Add Vehicle</a>
                </li>
            </ul>
        </div>


    </header>
    <nav>
        <div class="logo">
            <img src="logo.png" />
        </div>
        <div class="menü">
            <ul>
                <li>
                    <a href="index.aspx" class="active">Home Page</a>
                </li>
                <li>
                    <a href="about_us.aspx">About Us</a>
                </li>
                <li>
                    <a href="Salers.aspx">Salers</a>
                </li>
                <li>
                    <a href="contact.aspx">Contact</a>
                </li>
            </ul>
        </div>
    </nav>
    <aside>
            <div class="left-menü">
                    <!-- Satıcı Bilgileri Placeholder -->
                    <asp:PlaceHolder ID="leftMenu" runat="server"></asp:PlaceHolder>
                 
            </div>
    </aside>


    <main>

    <div class="container">
        <h1 style="text-align:center;">Seller Profile</h1>
    
        <!-- Burada dinamik olarak kartlar yüklenecek -->
        <asp:PlaceHolder ID="salersProfile" runat="server"></asp:PlaceHolder>
    </div>

    </main>



    <footer>
        <section class="row">
            <div class="sosyal-medya">
                <h5>We on Social Media</h5>
                <ul>
                    <li>
                        <a href="ınstagram.html">Instagram</a>
                    </li>
                    <li>
                        <a href="twitter.html">Twitter</a>
                    </li>
                    <li>
                        <a href="linkedin.html">Linkedin</a>
                    </li>
                </ul>
            </div>
            <div class="iletişim">
                <h5> Our Contact Information</h5>
                <ul>
                    <li> Ataşehir İstanbul</li>
                    <li>0(216) 321 456</li>
                    <li>comecar@info.com</li>
                </ul>
            </div>
            <div class="Neden">
               <p>© Copyright 2022 comecar.com All rights reserved. Site content cannot be copied or reproduced without permission.</p>
            </div>
        </section>

    </footer>

        </div>
    </form>
</body>
</html>
