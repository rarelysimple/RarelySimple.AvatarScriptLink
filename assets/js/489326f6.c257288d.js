"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[3254],{5355:(e,n,t)=>{t.r(n),t.d(n,{assets:()=>c,contentTitle:()=>l,default:()=>h,frontMatter:()=>o,metadata:()=>s,toc:()=>a});var r=t(5893),i=t(1151);const o={title:"Hello World API (.NET Framework)",image:"./HelloWorldDotnetFramework.png",sidebar_position:2},l=void 0,s={id:"dotnet/tutorials/hello-world-dotnet-framework",title:"Hello World API (.NET Framework)",description:"This tutorial will show how to create a myAvatar ScriptLink-compatible API with .NET 8.0.",source:"@site/docs/dotnet/tutorials/hello-world-dotnet-framework.mdx",sourceDirName:"dotnet/tutorials",slug:"/dotnet/tutorials/hello-world-dotnet-framework",permalink:"/docs/dotnet/tutorials/hello-world-dotnet-framework",draft:!1,unlisted:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/tutorials/hello-world-dotnet-framework.mdx",tags:[],version:"current",sidebarPosition:2,frontMatter:{title:"Hello World API (.NET Framework)",image:"./HelloWorldDotnetFramework.png",sidebar_position:2},sidebar:"dotnetSidebar",previous:{title:"Hello World API",permalink:"/docs/dotnet/tutorials/hello-world-dotnet"},next:{title:"AvatarScriptLink.NET Changelog",permalink:"/docs/dotnet/changelog/"}},c={image:t(3657).Z},a=[{value:"Before You Begin",id:"before-you-begin",level:2},{value:"Create Project",id:"create-project",level:2},{value:"Add Dependencies",id:"add-dependencies",level:2},{value:"Create ScriptLink Service",id:"create-scriptlink-service",level:2},{value:"Run Application",id:"run-application",level:2}];function d(e){const n={a:"a",code:"code",em:"em",h2:"h2",li:"li",ol:"ol",p:"p",pre:"pre",strong:"strong",ul:"ul",...(0,i.a)(),...e.components};return(0,r.jsxs)(r.Fragment,{children:[(0,r.jsx)(n.p,{children:"This tutorial will show how to create a myAvatar ScriptLink-compatible API with .NET 8.0."}),"\n",(0,r.jsx)(n.h2,{id:"before-you-begin",children:"Before You Begin"}),"\n",(0,r.jsx)(n.p,{children:"You will need the following to complete this tutorial:"}),"\n",(0,r.jsxs)(n.ul,{children:["\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.a,{href:"https://visualstudio.microsoft.com/downloads/",children:"Visual Studio 2022"})}),"\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.a,{href:"https://dotnet.microsoft.com/en-us/download/dotnet-framework",children:".NET Framework"})}),"\n"]}),"\n",(0,r.jsx)(n.p,{children:"When using Visual Studio you will want the following workloads and components installed."}),"\n",(0,r.jsxs)(n.ul,{children:["\n",(0,r.jsx)(n.li,{children:"ASP.NET and web development workload."}),"\n",(0,r.jsx)(n.li,{children:".NET Framework 4.8.1 SDK (if not already included with the install of the above workload)"}),"\n",(0,r.jsx)(n.li,{children:".NET Framework project and item templates (if not already included with the install of the above workload)"}),"\n"]}),"\n",(0,r.jsx)(n.h2,{id:"create-project",children:"Create Project"}),"\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Launch ",(0,r.jsx)(n.strong,{children:"Visual Studio 2022"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:[(0,r.jsx)(n.strong,{children:"Create a new project"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.em,{children:"C#"})," and then search for ",(0,r.jsx)(n.strong,{children:"ASP.NET"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.strong,{children:"ASP.NET Web Application (.NET Framework)"})," and then select ",(0,r.jsx)(n.strong,{children:"Next"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Configure your new project.","\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsx)(n.li,{children:"Set your project name."}),"\n",(0,r.jsx)(n.li,{children:"Select the location to store your project."}),"\n",(0,r.jsx)(n.li,{children:"Set your solution name."}),"\n",(0,r.jsxs)(n.li,{children:["Don't check ",(0,r.jsx)(n.em,{children:"Place solution and project in the same folder"}),". we will be adding additional projects to this solution in other tutorials."]}),"\n"]}),"\n"]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.strong,{children:"Next"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Set the ",(0,r.jsx)(n.strong,{children:"Framework"})," to ",(0,r.jsx)(n.em,{children:".NET Framework 4.8.1"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.strong,{children:"Create"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select the ",(0,r.jsx)(n.strong,{children:"Empty"})," project template and the following recommend settings:","\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:[(0,r.jsx)(n.strong,{children:"Configure for HTTPS"}),"."]}),"\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.strong,{children:"Also create a project for unit tests"})}),"\n"]}),"\n"]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.strong,{children:"Create"}),"."]}),"\n"]}),"\n",(0,r.jsx)(n.h2,{id:"add-dependencies",children:"Add Dependencies"}),"\n",(0,r.jsx)(n.p,{children:"We will add the RarelySimple.AvatarScriptLink package to our project."}),"\n",(0,r.jsxs)(n.ul,{children:["\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.a,{href:"https://www.nuget.org/packages/RarelySimple.AvatarScriptLink",children:"RarelySimple.AvatarScriptLink"})}),"\n"]}),"\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Right-click on the soution in Solution Explorer and select ",(0,r.jsx)(n.strong,{children:"Manage NuGet Packages for Solution..."}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select Browse and search for ",(0,r.jsx)(n.em,{children:"AvatarScriptLink"}),". Select RarelySimple.AvatarScriptLink by Scott Olson Jr and install this in your project."]}),"\n",(0,r.jsx)(n.li,{children:"Select the Install tab, clear the search text and confirm you now have the package installed in your project."}),"\n"]}),"\n",(0,r.jsx)(n.h2,{id:"create-scriptlink-service",children:"Create ScriptLink Service"}),"\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Right-click on your web application project and select ",(0,r.jsx)(n.strong,{children:"Add->New Folder"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Name the folder ",(0,r.jsx)(n.em,{children:"api"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Add a new ",(0,r.jsx)(n.strong,{children:"Web Service (ASMX)"})," to this folder named ",(0,r.jsx)(n.em,{children:"ScriptLinkService.asmx"}),". (Select Show All Templates if needed.)"]}),"\n",(0,r.jsxs)(n.li,{children:["Implement the ",(0,r.jsx)(n.em,{children:"GetVersion"})," and ",(0,r.jsx)(n.em,{children:"RunScript"})," methods as shown below."]}),"\n"]}),"\n",(0,r.jsx)(n.pre,{children:(0,r.jsx)(n.code,{className:"language-cs",metastring:'title="/api/ScriptLinkService.asmx"',children:'using RarelySimple.AvatarScriptLink.Objects;\nusing System.Web.Services;\n\nnamespace ScriptLinkService7.api\n{\n    /// <summary>\n    /// Summary description for ScriptLinkService\n    /// </summary>\n    [WebService(Namespace = "http://tempuri.org/")]\n    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]\n    [System.ComponentModel.ToolboxItem(false)]\n    public class ScriptLinkService : System.Web.Services.WebService\n    {\n        [WebMethod]\n        public string GetVersion()\n        {\n            return "0.1.0";\n        }\n\n        [WebMethod]\n        public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)\n        {\n            return optionObject.ToReturnOptionObject(ErrorCode.Alert, "Hello World!");\n        }\n    }\n}\n'})}),"\n",(0,r.jsx)(n.h2,{id:"run-application",children:"Run Application"}),"\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsx)(n.li,{children:"Press F5 to run the service in your default browser."}),"\n"]}),"\n",(0,r.jsx)(n.p,{children:"Congratulations! You should now see your API showing in the browser and are ready to make the API calls."}),"\n",(0,r.jsxs)(n.p,{children:["You can get the WSDL for import to myAvatar by appending the address with ",(0,r.jsx)(n.code,{children:"?WSDL"}),". For example, ",(0,r.jsx)(n.code,{children:"https://localhost:44376/api/ScriptLinkService.asmx?WSDL"}),"."]})]})}function h(e={}){const{wrapper:n}={...(0,i.a)(),...e.components};return n?(0,r.jsx)(n,{...e,children:(0,r.jsx)(d,{...e})}):d(e)}},3657:(e,n,t)=>{t.d(n,{Z:()=>r});const r=t.p+"assets/images/HelloWorldDotnetFramework-35bbe2dc699a0f73ddfc6cc928f90c13.png"},1151:(e,n,t)=>{t.d(n,{Z:()=>s,a:()=>l});var r=t(7294);const i={},o=r.createContext(i);function l(e){const n=r.useContext(o);return r.useMemo((function(){return"function"==typeof e?e(n):{...n,...e}}),[n,e])}function s(e){let n;return n=e.disableParentContext?"function"==typeof e.components?e.components(i):e.components||i:l(e.components),r.createElement(o.Provider,{value:n},e.children)}}}]);