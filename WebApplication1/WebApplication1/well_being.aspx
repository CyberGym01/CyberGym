<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="well_being.aspx.cs" Inherits="WebApplication1.well_being" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="static/bg.css" rel="stylesheet" />
    <link rel="stylesheet" href="/static/cards.css" type="text/css" />

    
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="card">
        <div class="card-image"></div>
        <div class="card-text">
          <span class="date">4 days ago</span>
          <h2>gain weight</h2>
          <p>Lorem ipsum dolor sit amet consectetur, Ducimus, repudiandae temporibus omnis illum maxime quod deserunt eligendi dolor</p>
        </div>
        <div class="card-stats">
          <div class="stat">
            <div class="value">4<sup>m</sup></div>
            <div class="type">read</div>
          </div>
          <div class="stat border">
            <div class="value">5123</div>
            <div class="type">views</div>
          </div>
          <div class="stat">
            <div class="value">32</div>
            <div class="type">comments</div>
          </div>
        </div>
          
      </div>


      <div class="card">
        <div class="card-image2"></div>
        <div class="card-text">
          <span class="date">4 days ago</span>
          <h2>fixed weight</h2>
          <p>Lorem ipsum dolor sit amet consectetur, Ducimus, repudiandae temporibus omnis illum maxime quod deserunt eligendi dolor</p>
        </div>
        <div class="card-stats">
          <div class="stat">
            <div class="value">4<sup>m</sup></div>
            <div class="type">read</div>
          </div>
          <div class="stat border">
            <div class="value">5123</div>
            <div class="type">views</div>
          </div>
          <div class="stat">
            <div class="value">32</div>
            <div class="type">comments</div>
          </div>
        </div>
    </div>

    <div class="card">
        <div class="card-image3"></div>
        <div class="card-text">
          <span class="date">4 days ago</span>
          <h2>loss weight</h2>
          <p>Lorem ipsum dolor sit amet consectetur, Ducimus, repudiandae temporibus omnis illum maxime quod deserunt eligendi dolor</p>
        </div>
        <div class="card-stats">
          <div class="stat">
            <div class="value">4<sup>m</sup></div>
            <div class="type">read</div>
          </div>
          <div class="stat border">
            <div class="value">5123</div>
            <div class="type">views</div>
          </div>
          <div class="stat">
            <div class="value">32</div>
            <div class="type">comments</div>
          </div>
        </div>
    </div>
</asp:Content>
