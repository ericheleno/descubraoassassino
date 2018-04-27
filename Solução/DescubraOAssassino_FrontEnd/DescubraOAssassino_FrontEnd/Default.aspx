<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DescubraOAssassino_FrontEnd._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>O JOGO</h1>
        <p class="lead">
            O empresário Sean Bean foi assassinado e o corpo dele foi deixado na frente da delegacia de polícia. O Inspetor Jacques
        Clouseau foi escolhido para investigar este caso. Após uma série de investigações, ele organizou uma lista com
        prováveis assassinos, os locais do crime e quais armas poderiam ter sido utilizadas.
        </p>
        <p class="lead">
            Uma testemunha foi encontrada, mas ela só consegue responder se Clouseau fornecer uma teoria. Para cada teoria
        ele "chuta" um assassino, um local e uma arma. A testemunha então responde com um número.
        </p>
        <p class="lead">
            Você assumimá o papel do Inspetor Jacques Clouseau e interrogará a testemunha sugerindo uma teoria (Suspeito, Local e Arma).
        </p>
        <p class="lead">
            Boa Sorte!
        </p>

        <p><a href="Investigar.aspx" class="btn btn-primary btn-lg">Iniciar a Investigação &raquo;</a></p>
    </div>

</asp:Content>
