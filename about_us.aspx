<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="about_us.aspx.cs" Inherits="Comecar.about_us" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="StyleSheet1.css">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <link href="https://getbootstrap.com/docs/5.3/assets/css/docs.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
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
        <div class="aboutus">
            As the Comecar family, we carry out your fast and secure buying and selling transactions!
            <br /> <br />
            Founded in 2003, Comecar is located in Istanbul Ataşehir. We welcome everyone to our gallery where we have a variety of cars, SUVs and motorcycles suitable for every budget.
          <br /> <br />
            If you call us to get more detailed information about the cars you find, we make an appointment and show you the car you like. When you want to buy, we quickly carry out your notary transactions without you with the power of attorney you provide. In addition, there are low interest rates for the loans you will receive from private banks.
            We welcome everyone to Comecar for safe and fast buying and selling.
        </div>
    </main>
    <footer style='position: relative; bottom: -110px;'>
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
