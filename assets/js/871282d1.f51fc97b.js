"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[6454],{2699:(t,e,n)=>{n.r(e),n.d(e,{assets:()=>s,contentTitle:()=>c,default:()=>l,frontMatter:()=>a,metadata:()=>i,toc:()=>p});const i=JSON.parse('{"id":"dotnet/intro","title":"AvatarScriptLink.NET","description":"AvatarScriptLink.NET is a framework for managing and manipulating Netsmart myAvatar ScriptLink OptionObjects. What it does is accelerate the development of clean and stable myAvatar ScriptLink-compatible APIs.","source":"@site/versioned_docs/version-1.2.0/dotnet/intro.md","sourceDirName":"dotnet","slug":"/dotnet/intro","permalink":"/docs/dotnet/intro","draft":false,"unlisted":false,"editUrl":"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/versioned_docs/version-1.2.0/dotnet/intro.md","tags":[],"version":"1.2.0","sidebarPosition":1,"frontMatter":{"title":"AvatarScriptLink.NET","image":"./AvatarScriptLink.NET.png","sidebar_position":1},"sidebar":"dotnetSidebar","next":{"title":"Installation","permalink":"/docs/dotnet/getting-started/installation"}}');var r=n(4848),o=n(8453);const a={title:"AvatarScriptLink.NET",image:"./AvatarScriptLink.NET.png",sidebar_position:1},c="AvatarScriptLink.NET",s={image:n(8148).A},p=[];function d(t){const e={a:"a",code:"code",h1:"h1",header:"header",p:"p",pre:"pre",...(0,o.R)(),...t.components};return(0,r.jsxs)(r.Fragment,{children:[(0,r.jsx)(e.header,{children:(0,r.jsx)(e.h1,{id:"avatarscriptlinknet",children:"AvatarScriptLink.NET"})}),"\n",(0,r.jsxs)(e.p,{children:["AvatarScriptLink.NET is a framework for managing and manipulating ",(0,r.jsx)(e.a,{href:"https://www.ntst.com/Solutions-and-Services/Offerings/myAvatar",children:"Netsmart myAvatar"})," ScriptLink OptionObjects. What it does is accelerate the development of clean and stable myAvatar ScriptLink-compatible APIs."]}),"\n",(0,r.jsx)(e.p,{children:'Most ScriptLink-compatible APIs are built with a local version of the NTST.ScriptLinkService.Objects library. Here\'s what a "Hello, World!" response might look like in this scenario.'}),"\n",(0,r.jsx)(e.pre,{children:(0,r.jsx)(e.code,{className:"language-cs",metastring:'title="Without AvatarScriptLink.NET"',children:'[WebMethod]\npublic OptionObject RunScript(OptionObject optionObject, string parameter)\n{\n    OptionObject returnOptionObject = new OptionObject();\n\n    returnOptionObject.ErrorCode = 3;\n    returnOptionObject.ErrorMesg = "Hello, World!";\n\n    returnOptionObject.EntityID = optionObject.EntityID;\n    returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;\n    returnOptionObject.Facility = optionObject.Facility;\n    returnOptionObject.OptionId = optionObject.OptionId;\n    returnOptionObject.OptionStaffId = optionObject.OptionStaffId;\n    returnOptionObject.OptionUserId = optionObject.OptionUserId;\n    returnOptionObject.SystemCode = optionObject.SystemCode;\n\n    return returnOptionObject;\n}\n'})}),"\n",(0,r.jsx)(e.p,{children:"With AvatarScriptLink.NET, this same code can be simplified to:"}),"\n",(0,r.jsx)(e.pre,{children:(0,r.jsx)(e.code,{className:"language-cs",metastring:'title="With AvatarScriptLink.NET"',children:'[WebMethod]\npublic OptionObject RunScript(OptionObject optionObject, string parameter)\n{\n    return optionObject.ToReturnOptionObject(ErrorCode.Informational, "Hello, World!");\n}\n'})}),"\n",(0,r.jsx)(e.p,{children:"Likewise, to bring this same API up to the latest OptionObject version doesn't require accounting for the new properties. Just update the OptionObject version and import the new/updated WSDL into myAvatar."}),"\n",(0,r.jsx)(e.pre,{children:(0,r.jsx)(e.code,{className:"language-cs",metastring:'title="Upgrading from OptionObject to OptionObject2015"',children:'[WebMethod]\npublic OptionObject2015 RunScript(OptionObject2015 optionObject, string parameter)\n{\n    return optionObject.ToReturnOptionObject(ErrorCode.Informational, "Hello, World!");\n}\n'})})]})}function l(t={}){const{wrapper:e}={...(0,o.R)(),...t.components};return e?(0,r.jsx)(e,{...t,children:(0,r.jsx)(d,{...t})}):d(t)}},8148:(t,e,n)=>{n.d(e,{A:()=>i});const i=n.p+"assets/images/AvatarScriptLink.NET-e674667d9929de2d87f882f61981fe6b.png"},8453:(t,e,n)=>{n.d(e,{R:()=>a,x:()=>c});var i=n(6540);const r={},o=i.createContext(r);function a(t){const e=i.useContext(o);return i.useMemo((function(){return"function"==typeof t?t(e):{...e,...t}}),[e,t])}function c(t){let e;return e=t.disableParentContext?"function"==typeof t.components?t.components(r):t.components||r:a(t.components),i.createElement(o.Provider,{value:e},t.children)}}}]);