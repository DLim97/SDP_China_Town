<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master_page.Master" CodeBehind="Billings.aspx.vb" Inherits="SDP_China_Town.WebForm10" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <div class="row">

        <div class="col-md-12 center-block">
            <h1>Managing Bills and Payment</h1>
        </div>

        <div class="col-md-3" style="left: 0px; top: 0px">
            <h4>Name:</h4>
        </div>

        <div class="col-md-9">
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

    </div>

    <div class="row">

        <div class="col-md-3" style="left: 0px; top: 0px">
            <h4>Identification Number:</h4>
        </div>

        <div class="col-md-9">
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

    </div>

    <div class="row">

        <div class="col-md-12" style="left: 0px; top: 0px">
            <asp:Label ID="Label1" runat="server" Text="Bill Details" BorderStyle="Ridge"></asp:Label>
        </div>

    </div>

        <div class="row">

            <div class="col-md-12" style="left: 0px; top: 0px">
                <asp:Button ID="Button1" runat="server" Text="Pay Bills" CssClass="btn btn-info center-block"/>
            </div>

    </div>
</asp:Content>
