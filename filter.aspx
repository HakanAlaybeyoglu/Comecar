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
        <main>
            <form runat="server">
        <div class="filtre">
            <div class="left-menü row ">
            <h1 style="text-align:center; border-bottom: 1px solid grey; padding: 15px;">Filter</h1>
            <div class="typechekbox col-6">
                <h5> Brands</h5>
                  <asp:CheckBoxList ID="brandCheckBoxList" runat="server">
             <asp:ListItem Text="Mercedes" Value="Mercedes"></asp:ListItem>
              <asp:ListItem Text="Bmv" Value="Bmv"></asp:ListItem>
                <asp:ListItem Text="Audi" Value="Audi"></asp:ListItem>
               
                 <asp:ListItem Text="Volkswagen" Value="Volkswagen"></asp:ListItem>
                <asp:ListItem Text="Kia" Value="Kia"></asp:ListItem>
                 <asp:ListItem Text="Seat" Value="Seat"></asp:ListItem>
                 <asp:ListItem Text="Skoda" Value="Skoda"></asp:ListItem>
                 <asp:ListItem Text="Renault" Value="Renault"></asp:ListItem>
              <asp:ListItem Text="Opel" Value="Opel"></asp:ListItem>
                 <asp:ListItem Text=">Volvo" Value="Volvo"></asp:ListItem>
                <asp:ListItem Text="Vespa" Value="Vespa"></asp:ListItem>
               <asp:ListItem Text="Honda" Value="Honda"></asp:ListItem>
                <asp:ListItem Text="Kawasakı" Value="Kawasakı"></asp:ListItem>
               <asp:ListItem Text="Kuba" Value="Kuba"></asp:ListItem>
                       </asp:CheckBoxList>
            </div>
            <div class="typechekbox col-6">
                <h5> Color</h5>
                <asp:CheckBoxList ID="colorCheckBoxList" runat="server">
                <asp:ListItem Text="Black" Value="Black"></asp:ListItem>
                <asp:ListItem Text="White" Value="White"></asp:ListItem>
                <asp:ListItem Text="Blue" Value="Blue"></asp:ListItem>
                <asp:ListItem Text="Green" Value="Green"></asp:ListItem>
             <asp:ListItem Text="Grey" Value="Grey"></asp:ListItem>
                <asp:ListItem Text="Red" Value="Red"></asp:ListItem>
                       </asp:CheckBoxList>
            </div>
            <div class="typechekbox col-6">
                <h5> Fuel Type</h5>
                 <asp:CheckBoxList ID="fuelCheckBoxList" runat="server">
              <asp:ListItem Text="Gasoline" Value="Gasoline"></asp:ListItem>
                 <asp:ListItem Text="Diesel" Value="Diesel"></asp:ListItem>
                <asp:ListItem Text="Hybrid" Value="Hybrid"></asp:ListItem>
                <asp:ListItem Text="Electric" Value="Electric"></asp:ListItem>

                      </asp:CheckBoxList>
            </div>
            <div class="typechekbox col-6">
                <h5> Gear Type</h5>
                <asp:CheckBoxList ID="gearCheckBoxList" runat="server">
               <asp:ListItem Text="Automatic" Value="Automatic"></asp:ListItem>
               <asp:ListItem Text="Manual" Value="Manual"></asp:ListItem>
                    <asp:ListItem Text="Triptronic" Value="Triptronic"></asp:ListItem>
                

                    </asp:CheckBoxList>

            </div>
            <div class="typechekbox col-6">
                <h5> Vehicle Type</h5>
                 <asp:CheckBoxList ID="vehıcleCheckBoxList" runat="server">
             <asp:ListItem Text="Car" Value="Car"></asp:ListItem>
                <asp:ListItem Text="Suv" Value="Suv"></asp:ListItem>
                 <asp:ListItem Text="Motorcycle" Value="Motorcycle"></asp:ListItem>

 </asp:CheckBoxList>

            </div>
            <div class="typechekbox col-6">
                <h5> Saler</h5>
                <asp:CheckBoxList ID="salersCheckBoxList" runat="server">
                 <asp:ListItem Text="Yaren Beren Öztürk" Value="Yaren Beren Öztürk"></asp:ListItem>
                <asp:ListItem Text="Sila Güler Cinar" Value="Sila Güler Cinar"></asp:ListItem>
                <asp:ListItem Text="Hakan Alaybeyoglu" Value="Hakan Alaybeyoglu"></asp:ListItem>
                <asp:ListItem Text="Kağan Alaybeyoglu" Value="Kagan Alaybeyoglu"></asp:ListItem>

                    </asp:CheckBoxList>

            </div>

            <asp:Button type="button" class="btn btn-secondary col-12" style=" --bs-btn-padding-y: .45rem; --bs-btn-padding-x: .1rem; --bs-btn-font-size: .75rem; mask-size:100%; " runat="server" onserverclick="Filtrele_Click"  Text="Filter">
                   
               
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
    </form>
</body>
</html>
