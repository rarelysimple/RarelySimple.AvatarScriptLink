<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RarelySimple.AvatarScriptLink.Examples.Soap.v4.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Testable Selection with Factories and Commands</h1>

     <p>This example makes the script selection testable by moving it to a factory class and modifying the script to a command class. The command class uses dependency injection but uses the concrete OptionObject classes.</p>

    <div class="row">
        <div class="col">
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title">OptionObject</h5>
                    <p class="card-text">The WSDL based on the legacy OptionObject class.</p>
                    <a href="OptionObjectService.asmx?WSDL" class="btn btn-secondary">WSDL</a>
                </div>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title">OptionObject2</h5>
                    <p class="card-text">The WSDL based on the legacy OptionObject2 class.</p>
                    <a href="OptionObject2Service.asmx?WSDL" class="btn btn-secondary">WSDL</a>
                </div>
            </div>
        </div>
        <div class="col">
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title">OptionObject2015</h5>
                    <p class="card-text">The WSDL based on the legacy OptionObject2015 class.</p>
                    <a href="OptionObject2015Service.asmx?WSDL" class="btn btn-primary">WSDL</a>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
