---
layout: default
title: Create a New ScriptLink API Solution 
---

# Walkthrough: Create a New ScriptLink Solution

Are you new to ScriptLink and want to get going? Or perhaps you have (or have inherited) a ScriptLink solution built on .NET 3.5 or 4 and have determined the quickest path is to build a new solution or project on the latest .NET Framework and migrate any remaining code? Or you have an existing solution, but you want to try out AvatarScriptLink.NET in a new project before deciding to use it elsewhere?

This walkthrough will take you through the steps of setting up a new .NET ScriptLink solution using C# and AvatarScriptLink.NET. A sample of this [starter build can be seen on GitHub](https://github.com/rarelysimple/RS.ScriptLinkDemo.CSharp). If you prefer to use Visual Basic, a [starter build is also available on GitHub](https://github.com/rarelysimple/RS.ScriptLinkDemo.VB).

## Before You Begin

To follow along, you will need:

* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/). Community edition is free and has everything you will need.

## Step 1: Create the Web Application and Unit Testing Projects

1. Launch Visual Studio 2019 and select Create a new project.
2. Set the Language Filter to C# and the Project Type filter to Web.
3. Search for Web Application.
4. Select ASP.NET Web Application (.NET Framework).
5. Name the project. (e.g., CompanyName.ScriptLink.Web)
6. Name the soloution. (e.g., CompanyName.ScriptLink)
7. Uncheck Place solution and project in the same directory.
8. Select Create.
9. On the Create a new ASP.NET Web Application page, select the following:
    1. Empty.
    2. No authentication.
    3. Configure for HTTPS.
    4. Also create a project for Unit Tests.
10. You can use Web Forms, MVC, and/or Authentication, if you like, but for this demonstration we are going to keep it lean.
11. Select Create.

When finished, you will have a solution with both a Web Application and a Unit Testing project.

## Step 2: Install the RarelySimple.AvatarScriptLink NuGet Package

1. Right-click on the solution and select Manage NuGet Packages for Solution...
2. Select the Browse tab and search for RarelySimple. If trying this before the release version is out, check Include prerelease.
3. Select the RarelySimple.AvatarScriptLink package.
4. Check the boxes next to the Web Application and Unit Testing projects and select Install.
5. Once installed, close the NuGet - Solution tab.

## Step 3: Create the Web Service

1. Right-click on your web application project and select Add->New Folder.
2. Name the folder Api.
3. Right-click on the Api folder and select Add->New Folder.
4. Name this folder v3. This is because we are going to use the OptionObject2015 class which is the third and latest version of the OptionObject.
5. Right-click on the v3 folder and select Add->New Item...
6. Name the web service. (e.g., ScriptLinkController.asmx).
7. Select Add.
8. You should now have the web service class open and ready for editing.
9. Add a reference to the AvatarScriptLink.NET library.

```c#
using RarelySimple.AvatarScriptLink.Objects;
```

10. Replace the HelloWorld web method with the following.

```c#
[WebMethod]
public string GetVersion()
{
    return "v.0.0.1";
}

[WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Info, "Hello, World!");
}
```
## Step 4: Run the Web Application

1. Press F5 to begin debugging with your preferred browser.
2. We should now see our API (e.g., ScriptLinkController) shown in the web browser.

## Next Steps

Congratulations! You have created your first ScriptLink-compatible API using ASP.NET and the AvatarScriptLink.NET library. So what's next? Here are some recommendations.

* Test the API with SoapUI.
* Create a HelloWorld command class with supporting Unit Tests and call it from the Web method.
* Create a Factory class for creating/selecting different commands based on the parameter passed from myAvatar. Include Unit Tests for this class as well.
* Try getting or setting a FieldValue.
* Create a repository with supporting Unit Tests for making ODBC calls.
* Create a repository with supporting Unit Tests for making Avatar Web Service (SOAP) calls.
* Create a service with supporting Unit Tests for sending emails.
* Use a repository, such as GitHub or Azure DevOps, to manage your code.

You can see a. [example of many of these ideas on GitHub](https://github.com/rarelysimple/RS.ScriptLinkDemo.CSharp).