<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="filter.aspx.cs" Inherits="Comecar.filter" %>

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
    <form id="form1" >
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
            <form runat="server">
        <div class="filtre">
            <div class="left-menü row ">
            <h1 style="text-align:center; border-bottom: 1px solid grey; padding: 15px;">Filter</h1>
          <div class="typechekbox col-6">
    <h5> Brands</h5>
    <asp:RadioButtonList ID="brandRadioButtonList" runat="server">
        <asp:ListItem Text="Mercedes" Value="1"></asp:ListItem>
        <asp:ListItem Text="Bmw" Value="2"></asp:ListItem>
        <asp:ListItem Text="Audi" Value="3"></asp:ListItem>
        <asp:ListItem Text="Volkswagen" Value="4"></asp:ListItem>
        <asp:ListItem Text="Kia" Value="5"></asp:ListItem>
        <asp:ListItem Text="Seat" Value="6"></asp:ListItem>
        <asp:ListItem Text="Skoda" Value="7"></asp:ListItem>
        <asp:ListItem Text="Renault" Value="8"></asp:ListItem>
        <asp:ListItem Text="Opel" Value="9"></asp:ListItem>
        <asp:ListItem Text="Volvo" Value="10"></asp:ListItem>
        <asp:ListItem Text="Vespa" Value="11"></asp:ListItem>
        <asp:ListItem Text="Honda" Value="12"></asp:ListItem>
        <asp:ListItem Text="Kawasakı" Value="13"></asp:ListItem>
        <asp:ListItem Text="Kuba" Value="14"></asp:ListItem>
    </asp:RadioButtonList>
</div>

            <div class="typechekbox col-6">
                <h5> Colors</h5>
                <asp:RadioButtonList ID="colorRadioButtonList" runat="server">
                <asp:ListItem Text="Black" Value="1"></asp:ListItem>
                <asp:ListItem Text="White" Value="2"></asp:ListItem>
                <asp:ListItem Text="Gray" Value="3"></asp:ListItem>
                <asp:ListItem Text="Blue" Value="4"></asp:ListItem>
             <asp:ListItem Text="Red" Value="5"></asp:ListItem>
                <asp:ListItem Text="Green" Value="6"></asp:ListItem>
                       </asp:RadioButtonList>
            </div>
            <div class="typechekbox col-6">
                <h5> Fuel Type</h5>
                 <asp:RadioButtonList ID="fuelRadioButtonList" runat="server">
              <asp:ListItem Text="Gasoline" Value="1"></asp:ListItem>
                 <asp:ListItem Text="Diesel" Value="2"></asp:ListItem>
                <asp:ListItem Text="Hybrid" Value="3"></asp:ListItem>
                <asp:ListItem Text="Electric" Value="4"></asp:ListItem>

                      </asp:RadioButtonList>
            </div>
            <div class="typechekbox col-6">
                <h5> Gear Type</h5>
                <asp:RadioButtonList ID="gearRadioButtonList" runat="server">
               <asp:ListItem Text="Automatic" Value="1"></asp:ListItem>
               <asp:ListItem Text="Manual" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Triptronic" Value="3"></asp:ListItem>
                    </asp:RadioButtonList>

            </div>
            <div class="typechekbox col-6">
                <h5> Vehicle Type</h5>
                 <asp:RadioButtonList ID="vehicleRadioButtonList" runat="server">
             <asp:ListItem Text="Car" Value="1"></asp:ListItem>
                <asp:ListItem Text="Suv" Value="2"></asp:ListItem>
                 <asp:ListItem Text="Motorcycle" Value="3"></asp:ListItem>

 </asp:RadioButtonList>

            </div>
            <div class="typechekbox col-6">
                <h5> Saler</h5>
                <asp:RadioButtonList ID="salersRadioButtonList" runat="server">
                 <asp:ListItem Text="Yaren Öztürk" Value="3"></asp:ListItem>
                <asp:ListItem Text="Sila Cinar" Value="2"></asp:ListItem>
                <asp:ListItem Text="Hakan Alaybeyoglu" Value="4"></asp:ListItem>
                <asp:ListItem Text="Kağan Alaybeyoglu" Value="1"></asp:ListItem>

                    </asp:RadioButtonList>

            </div>

            <asp:Button type="button" class="btn btn-secondary col-12" style=" --bs-btn-padding-y: .45rem; --bs-btn-padding-x: .1rem; --bs-btn-font-size: .75rem; mask-size:100%; " runat="server" OnClick="Filtrele_Click"  Text="Filter">
                   
               
            </asp:Button>
        </div>
                
        </div>
                </form>
            </main>
         <footer>
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
    </form>
</body>
</html>


