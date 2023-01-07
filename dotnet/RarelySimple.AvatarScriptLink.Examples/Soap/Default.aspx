<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RarelySimple.AvatarScriptLink.Examples.Soap.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>SOAP API Examples</h1>

    <p>The following examples are designed to ensure the AvatarScriptLink.NET library will work with a variety of code designs.</p>

    <ol>
        <li><a href="v1/">Legacy Loops</a></li>
        <li><a href="v2/">Legacy Loops with Unit Testing</a></li>
        <li><a href="v3/">Simplified with AvatarScriptLink.NET</a></li>
        <li><a href="v4/">DRY-er with OptionObject Transforms</a></li>
        <li><a href="v5/">Testable with Factories and Commands</a></li>
        <li><a href="v6/">Dependency Injection with Interfaces</a></li>
    </ol>

    <hr />

    <h2>1: Legacy Loops</h2>

    <p>This example uses the legacy loop design to read and modify OptionObjects as demonstrated in various early examples, documentation, and training. This design does not support unit testing.</p>

    <a class="btn btn-primary" href="v1/">Learn more</a>

    <hr />
    
    <h2>2: Legacy Loops plus Unit Testing</h2>

    <p>This example uses the legacy loop design to read and modify OptionObjects as demonstrated in various early examples, documentation, and training, however it uses public classes and methods instead of private to allow for Unit Testing. This design does not support unit testing.</p>

    <a class="btn btn-primary" href="v2/">Learn more</a>

    <hr />

    <h2>3: Simplified with AvatarScriptLink.NET</h2>

    <p>This next version eliminates the loops of the early samples, yet still requires repeated code, concrete classes, and untestable RunScript selection.</p>
    
    <a class="btn btn-primary" href="v3/">Learn more</a>

    <hr />

    <h2>4: DRY-er with OptionObject Transforms</h2>

    <p>This version leverages the AvatarScriptLink.NET transforms to reduce repeated code by transforming legacy objects to the latest compatible version and back. This like the preceding still depends on the concrete classes and the RunScript selection remains untestable.</p>
    
    <a class="btn btn-primary" href="v4/">Learn more</a>

    <hr />

    <h2>5: Testable Selection with Factories and Commands</h2>

    <p>This design uses forms of both the Factory and Command design patterns to support Unit Testing of the RunScript processing and RunScript selection. Although this design leverages dependency injection it still uses concrete OptionObject classes and transforms.</p>

    <a class="btn btn-primary" href="v5/">Learn more</a>

    <hr />

    <h2>6: DI with Interfaces</h2>

    <p>This design leverages a specialized interface (similar to the decorator pattern) to remove dependency on concrete OptionObject classes and transforms and instead leverage a common interface.</p>

    <a class="btn btn-primary" href="v6/">Learn more</a>

</asp:Content>
