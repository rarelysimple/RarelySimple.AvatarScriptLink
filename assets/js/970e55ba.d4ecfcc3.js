"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[6693],{6417:(e,n,t)=>{t.r(n),t.d(n,{assets:()=>d,contentTitle:()=>a,default:()=>p,frontMatter:()=>s,metadata:()=>c,toc:()=>u});var r=t(5893),i=t(1151),l=t(4866),o=t(5162);const s={title:"Hello World API",image:"./HelloWorldDotnet.png",sidebar_position:1},a=void 0,c={id:"dotnet/tutorials/hello-world-dotnet/index",title:"Hello World API",description:"This tutorial will show how to create a myAvatar ScriptLink-compatible API with .NET 8.0.",source:"@site/docs/dotnet/tutorials/hello-world-dotnet/index.mdx",sourceDirName:"dotnet/tutorials/hello-world-dotnet",slug:"/dotnet/tutorials/hello-world-dotnet/",permalink:"/docs/dotnet/tutorials/hello-world-dotnet/",draft:!1,unlisted:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/tutorials/hello-world-dotnet/index.mdx",tags:[],version:"current",sidebarPosition:1,frontMatter:{title:"Hello World API",image:"./HelloWorldDotnet.png",sidebar_position:1},sidebar:"dotnetSidebar",previous:{title:"Multiple-Iteration Tables",permalink:"/docs/dotnet/advanced/multiple-iteration-tables"},next:{title:"Hello World API (.NET Framework)",permalink:"/docs/dotnet/tutorials/hello-world-dotnet-framework/"}},d={image:t(5043).Z},u=[{value:"Before You Begin",id:"before-you-begin",level:2},{value:"Create Project",id:"create-project",level:2},{value:"Add Dependencies",id:"add-dependencies",level:2},{value:"Create the Service Contract",id:"create-the-service-contract",level:2},{value:"Create ScriptLink Service",id:"create-scriptlink-service",level:2},{value:"Update Program.cs",id:"update-programcs",level:2},{value:"Update Launch Settings",id:"update-launch-settings",level:2},{value:"Run the application",id:"run-the-application",level:2}];function h(e){const n={a:"a",code:"code",em:"em",h2:"h2",li:"li",ol:"ol",p:"p",pre:"pre",strong:"strong",ul:"ul",...(0,i.a)(),...e.components};return(0,r.jsxs)(r.Fragment,{children:[(0,r.jsx)(n.p,{children:"This tutorial will show how to create a myAvatar ScriptLink-compatible API with .NET 8.0."}),"\n",(0,r.jsx)(n.h2,{id:"before-you-begin",children:"Before You Begin"}),"\n",(0,r.jsx)(n.p,{children:"You will need the following to complete this tutorial:"}),"\n",(0,r.jsxs)(n.ul,{children:["\n",(0,r.jsxs)(n.li,{children:[(0,r.jsx)(n.a,{href:"https://visualstudio.microsoft.com/downloads/",children:"Visual Studio 2022"})," or ",(0,r.jsx)(n.a,{href:"https://code.visualstudio.com/",children:"Visual Studio Code"})]}),"\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.a,{href:"https://learn.microsoft.com/en-us/dotnet/core/install/",children:".NET SDK"})}),"\n"]}),"\n",(0,r.jsxs)(l.Z,{groupId:"ide",queryString:"ide",children:[(0,r.jsxs)(o.Z,{value:"vs",label:"Visual Studio",default:!0,children:[(0,r.jsx)(n.p,{children:"When using Visual Studio you will want the following workloads and components installed."}),(0,r.jsxs)(n.ul,{children:["\n",(0,r.jsx)(n.li,{children:"ASP.NET and web development workload."}),"\n",(0,r.jsx)(n.li,{children:".NET 8.0 Runtime (if not already included with the install of the above workload)"}),"\n"]})]}),(0,r.jsxs)(o.Z,{value:"code",label:"Visual Studio Code",children:[(0,r.jsx)(n.p,{children:"The following extensions are recommended when using Visual Studio Code."}),(0,r.jsxs)(n.ul,{children:["\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.a,{href:"https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit",children:"C# Dev Kit"})}),"\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.a,{href:"https://marketplace.visualstudio.com/items?itemName=humao.rest-client",children:"REST Client"})}),"\n"]})]})]}),"\n",(0,r.jsx)(n.h2,{id:"create-project",children:"Create Project"}),"\n",(0,r.jsxs)(l.Z,{groupId:"ide",queryString:"ide",children:[(0,r.jsx)(o.Z,{value:"vs",label:"Visual Studio",default:!0,children:(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Launch ",(0,r.jsx)(n.strong,{children:"Visual Studio 2022"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:[(0,r.jsx)(n.strong,{children:"Create a new project"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.em,{children:"C#"})," and then search for ",(0,r.jsx)(n.strong,{children:"ASP.NET"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.strong,{children:"ASP.NET Core Empty"})," and then select ",(0,r.jsx)(n.strong,{children:"Next"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Configure your new project.","\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsx)(n.li,{children:"Set your project name."}),"\n",(0,r.jsx)(n.li,{children:"Select the location to store your project."}),"\n",(0,r.jsx)(n.li,{children:"Set your solution name."}),"\n",(0,r.jsxs)(n.li,{children:["Don't check ",(0,r.jsx)(n.em,{children:"Place solution and project in the same folder"}),". we will be adding additional projects to this solution in other tutorials."]}),"\n"]}),"\n"]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.strong,{children:"Next"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Set the ",(0,r.jsx)(n.strong,{children:"Framework"})," to ",(0,r.jsx)(n.em,{children:".NET 8.0 (Long Term Support)"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.strong,{children:"Configure for HTTPS"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select ",(0,r.jsx)(n.strong,{children:"Create"}),"."]}),"\n"]})}),(0,r.jsxs)(o.Z,{value:"code",label:"Visual Studio Code",children:[(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsx)(n.li,{children:"Open Windows Terminal."}),"\n",(0,r.jsx)(n.li,{children:"Navigate to the directory you wish to store the solution and project in."}),"\n",(0,r.jsx)(n.li,{children:"Create the solution and then change to that directory"}),"\n"]}),(0,r.jsx)(n.pre,{children:(0,r.jsx)(n.code,{className:"language-bash",children:"dotnet new sln --output ScriptLinkHelloWorldDemo\ncd ScriptLinkHelloWorldDemo\ndotnet new web --output ScriptLinkHelloWorldDemo\ndotnet sln add ScriptLinkHelloWorldDemo/ScriptLinkHelloWorldDemo.csproj\ncode .\n"})})]})]}),"\n",(0,r.jsx)(n.h2,{id:"add-dependencies",children:"Add Dependencies"}),"\n",(0,r.jsx)(n.p,{children:"We will add two NuGet packages to our project."}),"\n",(0,r.jsxs)(n.ul,{children:["\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.a,{href:"https://www.nuget.org/packages/RarelySimple.AvatarScriptLink",children:"RarelySimple.AvatarScriptLink"})}),"\n",(0,r.jsx)(n.li,{children:(0,r.jsx)(n.a,{href:"https://www.nuget.org/packages/SoapCore",children:"SoapCore"})}),"\n"]}),"\n",(0,r.jsxs)(l.Z,{groupId:"ide",queryString:"ide",children:[(0,r.jsx)(o.Z,{value:"vs",label:"Visual Studio",default:!0,children:(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Right-click on the soution in Solution Explorer and select ",(0,r.jsx)(n.strong,{children:"Manage NuGet Packages for Solution..."}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Select Browse and search for ",(0,r.jsx)(n.em,{children:"AvatarScriptLink"}),". Select RarelySimple.AvatarScriptLink by Scott Olson Jr and install this in your project."]}),"\n",(0,r.jsxs)(n.li,{children:["Select Browse and search for ",(0,r.jsx)(n.em,{children:"SoapCore"}),". Select SoapCore by Digital Design and install this in your project."]}),"\n",(0,r.jsx)(n.li,{children:"Select the Install tab, clear the search text and confirm you now have two packages installed in your project."}),"\n"]})}),(0,r.jsxs)(o.Z,{value:"code",label:"Visual Studio Code",children:[(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsx)(n.li,{children:"Change to the project directory."}),"\n",(0,r.jsx)(n.li,{children:"Select View > Terminal (Ctrl +`) to show the Terminal."}),"\n",(0,r.jsxs)(n.li,{children:["Install RarelySimple.AvatarScriptLink with ",(0,r.jsx)(n.code,{children:"dotnet add package RarelySimple.AvatarScriptLink"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Install SoapCore with ",(0,r.jsx)(n.code,{children:"dotnet add package SoapCore"}),"."]}),"\n"]}),(0,r.jsx)(n.pre,{children:(0,r.jsx)(n.code,{className:"language-bash",children:"cd ScriptLinkHelloWorldDemo\ndotnet add package RarelySimple.AvatarScriptLink\ndotnet add package SoapCore\n"})})]})]}),"\n",(0,r.jsx)(n.h2,{id:"create-the-service-contract",children:"Create the Service Contract"}),"\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Add a new class to your project named ",(0,r.jsx)(n.em,{children:"IScriptLinkService2015"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Implement the ",(0,r.jsx)(n.em,{children:"GetVersion"})," and ",(0,r.jsx)(n.em,{children:"RunScript"})," operation contracts as shown below."]}),"\n"]}),"\n",(0,r.jsx)(n.pre,{children:(0,r.jsx)(n.code,{className:"language-cs",metastring:'title="/IScriptLinkService2015.cs"',children:"using RarelySimple.AvatarScriptLink.Objects;\nusing System.ServiceModel;\n\nnamespace ScriptLinkHelloWorldDemo\n{\n    [ServiceContract]\n    public interface IScriptLinkService\n    {\n        [OperationContract]\n        string GetVersion();\n\n        [OperationContract]\n        OptionObject RunScript(OptionObject optionObject, string parameter);\n    }\n}\n"})}),"\n",(0,r.jsx)(n.h2,{id:"create-scriptlink-service",children:"Create ScriptLink Service"}),"\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Add a new class to your project named ",(0,r.jsx)(n.em,{children:"ScriptLinkService"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Inherit this class from ",(0,r.jsx)(n.em,{children:"IScriptLinkService2015"}),"."]}),"\n",(0,r.jsxs)(n.li,{children:["Implement the ",(0,r.jsx)(n.em,{children:"GetVersion"})," and ",(0,r.jsx)(n.em,{children:"RunScript"})," methods as shown below."]}),"\n"]}),"\n",(0,r.jsx)(n.pre,{children:(0,r.jsx)(n.code,{className:"language-cs",metastring:'title="/ScriptLinkService.cs"',children:'using RarelySimple.AvatarScriptLink.Objects;\n\nnamespace ScriptLinkHelloWorldDemo\n{\n    public class ScriptLinkService : IScriptLinkService2015\n    {\n        public string GetVersion()\n        {\n            return "0.1.0";\n        }\n\n        public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)\n        {\n            return optionObject.ToReturnOptionObject(ErrorCode.Alert, "Hello World!");\n        }\n    }\n}\n'})}),"\n",(0,r.jsx)(n.h2,{id:"update-programcs",children:"Update Program.cs"}),"\n",(0,r.jsx)(n.p,{children:'In this step, we are going to replace the default "Hello World!" API with our new ScriptLink-compatible API.'}),"\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Open the ",(0,r.jsx)(n.strong,{children:"Program.cs"})," file."]}),"\n",(0,r.jsx)(n.li,{children:"Update the file to include the following:"}),"\n"]}),"\n",(0,r.jsx)(n.pre,{children:(0,r.jsx)(n.code,{className:"language-cs",metastring:'title="/Program.cs"',children:'using Microsoft.Extensions.DependencyInjection.Extensions;\nusing SoapCore;\n\nvar builder = WebApplication.CreateBuilder(args);\n// highlight-start\nbuilder.Services.AddSoapCore();\nbuilder.Services.TryAddSingleton<IScriptLinkService2015, ScriptLinkService>();\n// highlight-end\nvar app = builder.Build();\n\n// highlight-start\napp.UseHttpsRedirection();\napp.UseRouting();\napp.UseEndpoints(endpoints =>\n{\n    _ = endpoints.UseSoapEndpoint<IScriptLinkService>("/ScriptLinkService.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);\n    // Optional Alternative\n    // _ = endpoints.UseSoapEndpoint<IScriptLinkService>("/ScriptLinkService.svc", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);\n});\n// highlight-end\n\napp.Run();\n'})}),"\n",(0,r.jsx)(n.h2,{id:"update-launch-settings",children:"Update Launch Settings"}),"\n",(0,r.jsx)(n.p,{children:"This will help us launch the app and load the WSDL in the browser once running."}),"\n",(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Expand the Properties Folder and open the ",(0,r.jsx)(n.strong,{children:"launchSettings.json"})," file."]}),"\n",(0,r.jsxs)(n.li,{children:["In the ",(0,r.jsx)(n.em,{children:"https"})," profile insert the following line before the applicationUrl: ",(0,r.jsx)(n.code,{children:'"launchUrl": "ScriptLinkService.asmx",'}),"."]}),"\n"]}),"\n",(0,r.jsx)(n.pre,{children:(0,r.jsx)(n.code,{className:"language-json",metastring:'title="Properties/launchSettings.json"',children:'{\n    // previous content\n    "https": {\n      "commandName": "Project",\n      "dotnetRunMessages": true,\n      "launchBrowser": true,\n      // highlight-next-line\n      "launchUrl": "ScriptLinkService.asmx",\n      "applicationUrl": "https://localhost:7140;http://localhost:5106",\n      "environmentVariables": {\n        "ASPNETCORE_ENVIRONMENT": "Development"\n      }\n    },\n    // following content\n}\n'})}),"\n",(0,r.jsx)(n.h2,{id:"run-the-application",children:"Run the application"}),"\n",(0,r.jsxs)(l.Z,{groupId:"ide",queryString:"ide",children:[(0,r.jsx)(o.Z,{value:"vs",label:"Visual Studio",default:!0,children:(0,r.jsxs)(n.ol,{children:["\n",(0,r.jsxs)(n.li,{children:["Run/debug the application with the ",(0,r.jsx)(n.em,{children:"https"})," profile."]}),"\n"]})}),(0,r.jsx)(o.Z,{value:"code",label:"Visual Studio Code",children:(0,r.jsx)(n.pre,{children:(0,r.jsx)(n.code,{className:"language-bash",children:"dotnet run --launch-profile https\n"})})})]}),"\n",(0,r.jsx)(n.p,{children:"Congratulations! You should now see your WSDL showing in the browser and are ready to make the API calls."}),"\n",(0,r.jsxs)(n.p,{children:["If the WSDL was not automatically launched in your browser, you can get the URL from the launchSettings.json file. For example, ",(0,r.jsx)(n.a,{href:"https://localhost:7140/ScriptLinkService.asmx",children:"https://localhost:7140/ScriptLinkService.asmx"})," as seen in the same launchSettings file above."]})]})}function p(e={}){const{wrapper:n}={...(0,i.a)(),...e.components};return n?(0,r.jsx)(n,{...e,children:(0,r.jsx)(h,{...e})}):h(e)}},5162:(e,n,t)=>{t.d(n,{Z:()=>o});t(7294);var r=t(6905);const i={tabItem:"tabItem_Ymn6"};var l=t(5893);function o(e){let{children:n,hidden:t,className:o}=e;return(0,l.jsx)("div",{role:"tabpanel",className:(0,r.Z)(i.tabItem,o),hidden:t,children:n})}},4866:(e,n,t)=>{t.d(n,{Z:()=>w});var r=t(7294),i=t(6905),l=t(2466),o=t(6550),s=t(469),a=t(1980),c=t(7392),d=t(12);function u(e){return r.Children.toArray(e).filter((e=>"\n"!==e)).map((e=>{if(!e||(0,r.isValidElement)(e)&&function(e){const{props:n}=e;return!!n&&"object"==typeof n&&"value"in n}(e))return e;throw new Error(`Docusaurus error: Bad <Tabs> child <${"string"==typeof e.type?e.type:e.type.name}>: all children of the <Tabs> component should be <TabItem>, and every <TabItem> should have a unique "value" prop.`)}))?.filter(Boolean)??[]}function h(e){const{values:n,children:t}=e;return(0,r.useMemo)((()=>{const e=n??function(e){return u(e).map((e=>{let{props:{value:n,label:t,attributes:r,default:i}}=e;return{value:n,label:t,attributes:r,default:i}}))}(t);return function(e){const n=(0,c.l)(e,((e,n)=>e.value===n.value));if(n.length>0)throw new Error(`Docusaurus error: Duplicate values "${n.map((e=>e.value)).join(", ")}" found in <Tabs>. Every value needs to be unique.`)}(e),e}),[n,t])}function p(e){let{value:n,tabValues:t}=e;return t.some((e=>e.value===n))}function m(e){let{queryString:n=!1,groupId:t}=e;const i=(0,o.k6)(),l=function(e){let{queryString:n=!1,groupId:t}=e;if("string"==typeof n)return n;if(!1===n)return null;if(!0===n&&!t)throw new Error('Docusaurus error: The <Tabs> component groupId prop is required if queryString=true, because this value is used as the search param name. You can also provide an explicit value such as queryString="my-search-param".');return t??null}({queryString:n,groupId:t});return[(0,a._X)(l),(0,r.useCallback)((e=>{if(!l)return;const n=new URLSearchParams(i.location.search);n.set(l,e),i.replace({...i.location,search:n.toString()})}),[l,i])]}function j(e){const{defaultValue:n,queryString:t=!1,groupId:i}=e,l=h(e),[o,a]=(0,r.useState)((()=>function(e){let{defaultValue:n,tabValues:t}=e;if(0===t.length)throw new Error("Docusaurus error: the <Tabs> component requires at least one <TabItem> children component");if(n){if(!p({value:n,tabValues:t}))throw new Error(`Docusaurus error: The <Tabs> has a defaultValue "${n}" but none of its children has the corresponding value. Available values are: ${t.map((e=>e.value)).join(", ")}. If you intend to show no default tab, use defaultValue={null} instead.`);return n}const r=t.find((e=>e.default))??t[0];if(!r)throw new Error("Unexpected error: 0 tabValues");return r.value}({defaultValue:n,tabValues:l}))),[c,u]=m({queryString:t,groupId:i}),[j,x]=function(e){let{groupId:n}=e;const t=function(e){return e?`docusaurus.tab.${e}`:null}(n),[i,l]=(0,d.Nk)(t);return[i,(0,r.useCallback)((e=>{t&&l.set(e)}),[t,l])]}({groupId:i}),S=(()=>{const e=c??j;return p({value:e,tabValues:l})?e:null})();(0,s.Z)((()=>{S&&a(S)}),[S]);return{selectedValue:o,selectValue:(0,r.useCallback)((e=>{if(!p({value:e,tabValues:l}))throw new Error(`Can't select invalid tab value=${e}`);a(e),u(e),x(e)}),[u,x,l]),tabValues:l}}var x=t(2389);const S={tabList:"tabList__CuJ",tabItem:"tabItem_LNqP"};var g=t(5893);function v(e){let{className:n,block:t,selectedValue:r,selectValue:o,tabValues:s}=e;const a=[],{blockElementScrollPositionUntilNextRender:c}=(0,l.o5)(),d=e=>{const n=e.currentTarget,t=a.indexOf(n),i=s[t].value;i!==r&&(c(n),o(i))},u=e=>{let n=null;switch(e.key){case"Enter":d(e);break;case"ArrowRight":{const t=a.indexOf(e.currentTarget)+1;n=a[t]??a[0];break}case"ArrowLeft":{const t=a.indexOf(e.currentTarget)-1;n=a[t]??a[a.length-1];break}}n?.focus()};return(0,g.jsx)("ul",{role:"tablist","aria-orientation":"horizontal",className:(0,i.Z)("tabs",{"tabs--block":t},n),children:s.map((e=>{let{value:n,label:t,attributes:l}=e;return(0,g.jsx)("li",{role:"tab",tabIndex:r===n?0:-1,"aria-selected":r===n,ref:e=>a.push(e),onKeyDown:u,onClick:d,...l,className:(0,i.Z)("tabs__item",S.tabItem,l?.className,{"tabs__item--active":r===n}),children:t??n},n)}))})}function b(e){let{lazy:n,children:t,selectedValue:i}=e;const l=(Array.isArray(t)?t:[t]).filter(Boolean);if(n){const e=l.find((e=>e.props.value===i));return e?(0,r.cloneElement)(e,{className:"margin-top--md"}):null}return(0,g.jsx)("div",{className:"margin-top--md",children:l.map(((e,n)=>(0,r.cloneElement)(e,{key:n,hidden:e.props.value!==i})))})}function f(e){const n=j(e);return(0,g.jsxs)("div",{className:(0,i.Z)("tabs-container",S.tabList),children:[(0,g.jsx)(v,{...e,...n}),(0,g.jsx)(b,{...e,...n})]})}function w(e){const n=(0,x.Z)();return(0,g.jsx)(f,{...e,children:u(e.children)},String(n))}},5043:(e,n,t)=>{t.d(n,{Z:()=>r});const r=t.p+"assets/images/HelloWorldDotnet-77753e42fc06dd67f9e09de589f0e6e4.png"},1151:(e,n,t)=>{t.d(n,{Z:()=>s,a:()=>o});var r=t(7294);const i={},l=r.createContext(i);function o(e){const n=r.useContext(l);return r.useMemo((function(){return"function"==typeof e?e(n):{...n,...e}}),[n,e])}function s(e){let n;return n=e.disableParentContext?"function"==typeof e.components?e.components(i):e.components||i:o(e.components),r.createElement(l.Provider,{value:n},e.children)}}}]);