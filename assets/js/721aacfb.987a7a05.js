"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[4298],{7590:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>o,contentTitle:()=>s,default:()=>u,frontMatter:()=>r,metadata:()=>i,toc:()=>c});var i=n(1626),l=n(4848),a=n(8453);const r={slug:"announcing-avatarscriptlink.net-1.1.6",title:"Announcing AvatarScriptLink.NET 1.1.6",authors:["scottolsonjr"],tags:["scriptlink","myavatar","dotnet","c#","vb","visual basic","visual studio","nuget"]},s=void 0,o={authorsImageUrls:[void 0]},c=[{value:"Migrating from 1.0.x to 1.1.x",id:"migrating-from-10x-to-11x",level:2}];function d(e){const t={a:"a",code:"code",h2:"h2",li:"li",p:"p",pre:"pre",ul:"ul",...(0,a.R)(),...e.components};return(0,l.jsxs)(l.Fragment,{children:[(0,l.jsxs)(t.p,{children:["AvatarScriptLink.NET version 1.1.6 is ",(0,l.jsx)(t.a,{href:"https://www.nuget.org/packages/RarelySimple.AvatarScriptLink/1.1.6",children:"now available on NuGet"}),".\nThis release refines ",(0,l.jsx)(t.a,{href:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues/20",children:"the behavior of setting a FieldObject as required or optional"}),"."]}),"\n",(0,l.jsx)(t.p,{children:"With the release:"}),"\n",(0,l.jsxs)(t.ul,{children:["\n",(0,l.jsxs)(t.li,{children:[(0,l.jsx)(t.code,{children:"SetRequiredField()"})," will no longer set the FieldObject as Enabled as well. Use ",(0,l.jsx)(t.code,{children:"SetEnabledField()"})," as well if this is the desired result."]}),"\n",(0,l.jsxs)(t.li,{children:[(0,l.jsx)(t.code,{children:"SetDisabledField()"})," will no longer set the FieldObject as Optional as well. Use ",(0,l.jsx)(t.code,{children:"SetOptionalField()"})," well if this is the desired result."]}),"\n"]}),"\n","\n",(0,l.jsx)(t.h2,{id:"migrating-from-10x-to-11x",children:"Migrating from 1.0.x to 1.1.x"}),"\n",(0,l.jsx)(t.p,{children:'Due to the change of behavior there could be unintended changes to the behavior of implemented ScriptLink APIs.\nIf your implementation relies on the assumptions that "all required fields are enabled" or "all disabled fields are optional" then you may need to apply the following updates to your project.'}),"\n",(0,l.jsxs)(t.p,{children:["For ",(0,l.jsx)(t.code,{children:"SetRequiredField()"}),", add another line to ",(0,l.jsx)(t.code,{children:"SetEnabledField()"})," to ensure the FieldObject is enabled as expected."]}),"\n",(0,l.jsx)(t.pre,{children:(0,l.jsx)(t.code,{className:"language-cs",children:"// In version 1.0 SetRequiredField would also enable the FieldObject\noptionObject.SetRequiredField(fieldNumber);\n// In version 1.1 and later this must must explicitly requested.\n// highlight-next-line\noptionObject.SetEnabledField(fieldNumber);\n"})}),"\n",(0,l.jsxs)(t.p,{children:["For ",(0,l.jsx)(t.code,{children:"SetDisabledField()"}),", add another line to ",(0,l.jsx)(t.code,{children:"SetOptionalField()"})," to ensure the FieldObject is set to optional as expected."]}),"\n",(0,l.jsx)(t.pre,{children:(0,l.jsx)(t.code,{className:"language-cs",children:"// In version 1.0 SetDisabledField would also set the FieldObject as optional (not required)\noptionObject.SetDisabledField(fieldNumber);\n// In version 1.1 and later this must must explicitly requested.\n// highlight-next-line\noptionObject.SetOptionalField(fieldNumber);\n"})})]})}function u(e={}){const{wrapper:t}={...(0,a.R)(),...e.components};return t?(0,l.jsx)(t,{...e,children:(0,l.jsx)(d,{...e})}):d(e)}},8453:(e,t,n)=>{n.d(t,{R:()=>r,x:()=>s});var i=n(6540);const l={},a=i.createContext(l);function r(e){const t=i.useContext(a);return i.useMemo((function(){return"function"==typeof e?e(t):{...t,...e}}),[t,e])}function s(e){let t;return t=e.disableParentContext?"function"==typeof e.components?e.components(l):e.components||l:r(e.components),i.createElement(a.Provider,{value:t},e.children)}},1626:e=>{e.exports=JSON.parse('{"permalink":"/blog/announcing-avatarscriptlink.net-1.1.6","source":"@site/blog/2022-09-04-announcing-avatarscriptlink.net-1.1.6/index.mdx","title":"Announcing AvatarScriptLink.NET 1.1.6","description":"AvatarScriptLink.NET version 1.1.6 is now available on NuGet.","date":"2022-09-04T00:00:00.000Z","tags":[{"inline":true,"label":"scriptlink","permalink":"/blog/tags/scriptlink"},{"inline":true,"label":"myavatar","permalink":"/blog/tags/myavatar"},{"inline":true,"label":"dotnet","permalink":"/blog/tags/dotnet"},{"inline":true,"label":"c#","permalink":"/blog/tags/c"},{"inline":true,"label":"vb","permalink":"/blog/tags/vb"},{"inline":true,"label":"visual basic","permalink":"/blog/tags/visual-basic"},{"inline":true,"label":"visual studio","permalink":"/blog/tags/visual-studio"},{"inline":true,"label":"nuget","permalink":"/blog/tags/nuget"}],"readingTime":1.075,"hasTruncateMarker":true,"authors":[{"name":"Scott Olson Jr","title":"RarelySimple.AvatarScriptLink Maintainer","url":"https://github.com/scottolsonjr","imageURL":"https://avatars.githubusercontent.com/u/984715?v=4","key":"scottolsonjr","page":null}],"frontMatter":{"slug":"announcing-avatarscriptlink.net-1.1.6","title":"Announcing AvatarScriptLink.NET 1.1.6","authors":["scottolsonjr"],"tags":["scriptlink","myavatar","dotnet","c#","vb","visual basic","visual studio","nuget"]},"unlisted":false,"prevItem":{"title":"Announcing AvatarScriptLink.NET 1.1.10","permalink":"/blog/announcing-avatarscriptlink.net-1.1.10"},"nextItem":{"title":"Announcing AvatarScriptLink.NET 1.0.28","permalink":"/blog/announcing-avatarscriptlink.net-1.0.28"}}')}}]);