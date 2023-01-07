<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RarelySimple.AvatarScriptLink.Examples.Soap.v6.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Dependency Injection with Interfaces</h1>

    <p>This example attempts to remove all concrete classes from injection into the commands. The goal is to remove the need to transform the legacy OptionObjects.</p>

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
