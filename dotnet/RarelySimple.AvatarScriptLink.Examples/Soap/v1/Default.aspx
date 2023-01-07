<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RarelySimple.AvatarScriptLink.Examples.Soap.v1.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Legacy Loops Example</h1>

    <p>This example leverages the loops and private methods of the early examples and documentation of myAvatar ScriptLink to verify that style remains compatible with AvatarScriptLink.NET. This is important to support migration for existing projects.</p>

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
