<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RarelySimple.AvatarScriptLink.Examples.Soap.v4.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>DRY-er with Transforms</h1>

     <p>This example replaces the code written for each OptionObject version with transforms to the newer version and back. This allows for the "Don't Repeat Yourself" practice to reduce future errors. It also helps to bring a project up to a newer version prior to modification or replacement of the WSDL.</p>

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
