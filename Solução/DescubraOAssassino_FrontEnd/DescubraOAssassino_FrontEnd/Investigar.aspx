<%@ Page Title="Investigando" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Investigar.aspx.cs" Inherits="DescubraOAssassino_FrontEnd.Contact" Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Crime</h1>
        <asp:Label ID="lblCrime" runat="server" Text="Label"></asp:Label>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Suspeito</h2>
            <p>
                <asp:DropDownList ID="ddlSuspeito" runat="server" Width="250px"></asp:DropDownList>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Local</h2>
            <p>
                <asp:DropDownList ID="ddlLocal" runat="server" Width="250px"></asp:DropDownList>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Arma</h2>
            <p>
                <asp:DropDownList ID="ddlArma" runat="server" Width="250px"></asp:DropDownList>
            </p>
        </div>
    </div>

    <br />

    <div class="row col-xs-12 col-sm-12 col-md-12 col-lg-12" align="center">
        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
    </div>

    <br />

    <div class="row col-xs-12 col-sm-12 col-md-12 col-lg-12" align="center">
        <asp:Button CssClass="btn btn-primary" ID="btnNovaInvestigacao" runat="server" Text="Realizar Nova Investigação" OnClick="btnNovaInvestigacao_Click" />
        <asp:Button CssClass="btn btn-primary" ID="btnValidarTeoria" runat="server" Text="Validar Teoria" OnClick="btnValidarTeoria_Click" />
    </div>

</asp:Content>
