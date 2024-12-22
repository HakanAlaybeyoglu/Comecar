<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Comecar.contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
<link href="https://getbootstrap.com/docs/5.3/assets/css/docs.css" rel="stylesheet">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
     <link rel="stylesheet" href="StyleSheet1.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
    <div class="header-description">
        <small >
            Come Car

        </small >
        <small style="font-size:15px" >Fast Buy Fast Sell</small> 
    </div>
    
</header>
    <nav>
      <div class="logo">
          <img src="logo.png" />
      </div>
      <div class="menü">
          <ul>
                <li><a href="index.aspx" class="active">Home Page</a></li>
                <li><a href="Salers.aspx">Salers</a></li>
                <li><a href="about_us.aspx">About Us</a></li>
                <li><a href="contact.aspx">Contact</a></li>
          </ul>
      </div>
    </nav>
   
    <main>
        <h1 class="konumhead" style="text-align:center"> CONTACT INFORMATION </h1>
     <div class="container2">
        <div class="konum">
       <img src="map.png" width="550px" height="230px" alt="Comecar Location"/>
            </div>
        <div class="konum">
            Ataşehir Atatürk Mah. Ataşehir Bulv. 3 Cad. No:7 Atatürk, 34758 Ataşehir/İstanbul, Türkiye
            <br> <br>
            8.00-18.00
            <br> <br>
            0(216) 321 456
            <br> <br>
            comecar@info.com
            </div>
      </div>
    </main>
    <footer style='position: relative; bottom: -210px;'>
        <section class="row">
            <div class="sosyal-medya">
            <h5>We on Social Media</h5>
            <ul>
                <li> <a href="https://www.instagram.com/">Instagram</a></li>
                <li> <a href="https://x.com/">Twitter</a></li>
                <li> <a href="https://www.linkedin.com/">Linkedin</a></li>
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
