"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[9625],{4522:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>o,contentTitle:()=>s,default:()=>d,frontMatter:()=>a,metadata:()=>l,toc:()=>c});var r=n(5893),i=n(1151);const a={slug:"announcing-avatarscriptlink.net-1.2.0",title:"Announcing AvatarScriptLink.NET 1.2.0",authors:["scottolsonjr"],tags:["scriptlink","myavatar","dotnet","c#","vb","visual basic","visual studio","nuget"]},s=void 0,l={permalink:"/blog/announcing-avatarscriptlink.net-1.2.0",source:"@site/blog/2023-06-25-announcing-avatarscriptlink.net-1.2.0/index.mdx",title:"Announcing AvatarScriptLink.NET 1.2.0",description:"AvatarScriptLink.NET version 1.2.0 is now available on NuGet.",date:"2023-06-25T00:00:00.000Z",formattedDate:"June 25, 2023",tags:[{label:"scriptlink",permalink:"/blog/tags/scriptlink"},{label:"myavatar",permalink:"/blog/tags/myavatar"},{label:"dotnet",permalink:"/blog/tags/dotnet"},{label:"c#",permalink:"/blog/tags/c"},{label:"vb",permalink:"/blog/tags/vb"},{label:"visual basic",permalink:"/blog/tags/visual-basic"},{label:"visual studio",permalink:"/blog/tags/visual-studio"},{label:"nuget",permalink:"/blog/tags/nuget"}],readingTime:.79,hasTruncateMarker:!0,authors:[{name:"Scott Olson Jr",title:"RarelySimple.AvatarScriptLink Maintainer",url:"https://github.com/scottolsonjr",imageURL:"https://avatars.githubusercontent.com/u/984715?v=4",key:"scottolsonjr"}],frontMatter:{slug:"announcing-avatarscriptlink.net-1.2.0",title:"Announcing AvatarScriptLink.NET 1.2.0",authors:["scottolsonjr"],tags:["scriptlink","myavatar","dotnet","c#","vb","visual basic","visual studio","nuget"]},unlisted:!1,nextItem:{title:"Announcing AvatarScriptLink.NET 1.1.10",permalink:"/blog/announcing-avatarscriptlink.net-1.1.10"}},o={authorsImageUrls:[void 0]},c=[{value:"New Builders",id:"new-builders",level:2},{value:"Preset ErrorCode and ErrorMesg",id:"preset-errorcode-and-errormesg",level:2}];function u(e){const t={a:"a",code:"code",h2:"h2",li:"li",p:"p",pre:"pre",ul:"ul",...(0,i.a)(),...e.components};return(0,r.jsxs)(r.Fragment,{children:[(0,r.jsxs)(t.p,{children:["AvatarScriptLink.NET version 1.2.0 is ",(0,r.jsx)(t.a,{href:"https://www.nuget.org/packages/RarelySimple.AvatarScriptLink/1.2.0",children:"now available on NuGet"}),".\nThis release includes the introduction of Builder methods to assist with the creation of the various objects as well as allowing for the ",(0,r.jsxs)(t.a,{href:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/52",children:["error code and error message to be set prior to calling ",(0,r.jsx)(t.code,{children:"ToReturnOptionObject()"})]}),".\nThis is especially helpful when arranging unit tests."]}),"\n","\n",(0,r.jsx)(t.h2,{id:"new-builders",children:"New Builders"}),"\n",(0,r.jsx)(t.p,{children:"Builder methods have been added to each of the ScriptLink objects."}),"\n",(0,r.jsxs)(t.ul,{children:["\n",(0,r.jsx)(t.li,{children:(0,r.jsx)(t.a,{href:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/40",children:"OptionObject2015 (incl. OptionObject2, OptionObject)"})}),"\n",(0,r.jsx)(t.li,{children:(0,r.jsx)(t.a,{href:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/39",children:"FormObject"})}),"\n",(0,r.jsx)(t.li,{children:(0,r.jsx)(t.a,{href:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/38",children:"RowObject"})}),"\n",(0,r.jsx)(t.li,{children:(0,r.jsx)(t.a,{href:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/37",children:"FieldObject"})}),"\n"]}),"\n",(0,r.jsx)(t.pre,{children:(0,r.jsx)(t.code,{className:"language-cs",children:'[TestMethod]\npublic void TestMethod1WithFluentBuilder()\n{\n    var expected = "value";\n    FieldObject fieldObject = FieldObject.Builder()\n        .FieldNumber("123.45").FieldValue(expected)\n        .Enabled()\n        .Build();\n    Assert.AreEqual(expected, fieldObject.FieldValue);\n}\n'})}),"\n",(0,r.jsx)(t.h2,{id:"preset-errorcode-and-errormesg",children:"Preset ErrorCode and ErrorMesg"}),"\n",(0,r.jsxs)(t.p,{children:["TThere may be use cases in which you do not want to wait until the returning of the response to set the ErrorCode and ErrorMesg.\nWith this release you can set these values prior to calling ",(0,r.jsx)(t.code,{children:"ToReturnOptionObject()"}),"."]}),"\n",(0,r.jsx)(t.pre,{children:(0,r.jsx)(t.code,{className:"language-cs",children:'if (condition)\n{\n    optionObject.ErrorCode = ErrorCode.Alert;\n    optionObject.ErrorMesg = "An alert message!";\n}\nreturn optionObject.ToReturnOptionObject();\n'})})]})}function d(e={}){const{wrapper:t}={...(0,i.a)(),...e.components};return t?(0,r.jsx)(t,{...e,children:(0,r.jsx)(u,{...e})}):u(e)}},1151:(e,t,n)=>{n.d(t,{Z:()=>l,a:()=>s});var r=n(7294);const i={},a=r.createContext(i);function s(e){const t=r.useContext(a);return r.useMemo((function(){return"function"==typeof e?e(t):{...t,...e}}),[t,e])}function l(e){let t;return t=e.disableParentContext?"function"==typeof e.components?e.components(i):e.components||i:s(e.components),r.createElement(a.Provider,{value:t},e.children)}}}]);