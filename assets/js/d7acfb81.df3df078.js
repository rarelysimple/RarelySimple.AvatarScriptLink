"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[7805],{8553:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>o,contentTitle:()=>r,default:()=>u,frontMatter:()=>d,metadata:()=>i,toc:()=>c});const i=JSON.parse('{"id":"dotnet/guides/working-with-fieldobjects","title":"Working with FieldObjects","description":"Nearly all ScriptLink use cases invlove working with FieldObjects whether reading, setting, or modifying.","source":"@site/versioned_docs/version-1.2.0/dotnet/guides/working-with-fieldobjects.mdx","sourceDirName":"dotnet/guides","slug":"/dotnet/guides/working-with-fieldobjects","permalink":"/docs/dotnet/guides/working-with-fieldobjects","draft":false,"unlisted":false,"editUrl":"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/versioned_docs/version-1.2.0/dotnet/guides/working-with-fieldobjects.mdx","tags":[],"version":"1.2.0","sidebarPosition":3,"frontMatter":{"title":"Working with FieldObjects","image":"./WorkingWithFieldObjects.png","sidebar_position":3},"sidebar":"dotnetSidebar","previous":{"title":"RowAction","permalink":"/docs/dotnet/data-model/rowaction"},"next":{"title":"Multiple-Iteration Tables","permalink":"/docs/dotnet/advanced/multiple-iteration-tables"}}');var l=n(4848),s=n(8453);const d={title:"Working with FieldObjects",image:"./WorkingWithFieldObjects.png",sidebar_position:3},r=void 0,o={image:n(4122).A},c=[{value:"Read the Value",id:"read-the-value",level:2},{value:"Set the Value",id:"set-the-value",level:2},{value:"Verify Presence",id:"verify-presence",level:2},{value:"Set Statuses",id:"set-statuses",level:2},{value:"Verify Statuses",id:"verify-statuses",level:2}];function a(e){const t={a:"a",code:"code",h2:"h2",li:"li",p:"p",pre:"pre",ul:"ul",...(0,s.R)(),...e.components};return(0,l.jsxs)(l.Fragment,{children:[(0,l.jsxs)(t.p,{children:["Nearly all ScriptLink use cases invlove working with ",(0,l.jsx)(t.a,{href:"/docs/dotnet/data-model/fieldobject",children:"FieldObjects"})," whether reading, setting, or modifying.\nThe AvatarScriptLink.NET library helps with these very common tasks."]}),"\n",(0,l.jsx)(t.h2,{id:"read-the-value",children:"Read the Value"}),"\n",(0,l.jsxs)(t.p,{children:["The ",(0,l.jsx)(t.code,{children:"GetFieldObject"})," method will return the FieldValue from the matching FieldObject in the CurrentRow."]}),"\n",(0,l.jsx)(t.pre,{children:(0,l.jsx)(t.code,{className:"language-cs",metastring:'title="Read the Value of a FieldObject"',children:'var clone = _optionObject.Clone();\n\nstring fieldValue = clone.GetFieldValue("123.45");\n\nreturn clone.ToReturnOptionObject();\n'})}),"\n",(0,l.jsx)(t.h2,{id:"set-the-value",children:"Set the Value"}),"\n",(0,l.jsxs)(t.p,{children:["When setting the value of a ",(0,l.jsx)(t.a,{href:"/docs/dotnet/data-model/fieldobject",children:"FieldObject"})," the ",(0,l.jsx)(t.code,{children:"SetFieldObject"})," method will also update the ",(0,l.jsx)(t.a,{href:"/docs/dotnet/data-model/rowaction",children:"RowAction"})," to ",(0,l.jsx)(t.code,{children:"EDIT"})," for you."]}),"\n",(0,l.jsx)(t.pre,{children:(0,l.jsx)(t.code,{className:"language-cs",metastring:'title="Read a FieldValue"',children:'var clone = _optionObject.Clone();\n\nclone.SetFieldValue("123.45", "My new value.");\n\nreturn clone.ToReturnOptionObject();\n'})}),"\n",(0,l.jsx)(t.h2,{id:"verify-presence",children:"Verify Presence"}),"\n",(0,l.jsxs)(t.p,{children:["The ",(0,l.jsx)(t.code,{children:"IsFieldPresent"})," can be used to assist with validation and unit testing."]}),"\n",(0,l.jsx)(t.pre,{children:(0,l.jsx)(t.code,{className:"language-cs",metastring:'title="Verify a Field is Present before Modification"',children:'var clone = _optionObject.Clone();\n\nstring fieldNumber = "123.45";\nif (clone.IsFieldPresent(fieldNumber))\n    clone.SetFieldValue(fieldNumber, "My new value.");\n\nreturn clone.ToReturnOptionObject();\n'})}),"\n",(0,l.jsx)(t.h2,{id:"set-statuses",children:"Set Statuses"}),"\n",(0,l.jsxs)(t.p,{children:["There are three different statuses that can be set on a ",(0,l.jsx)(t.a,{href:"/docs/dotnet/data-model/fieldobject",children:"FieldObject"}),": ",(0,l.jsx)(t.code,{children:"Enabled"}),", ",(0,l.jsx)(t.code,{children:"Locked"}),", and ",(0,l.jsx)(t.code,{children:"Required"}),"."]}),"\n",(0,l.jsx)(t.pre,{children:(0,l.jsx)(t.code,{className:"language-cs",metastring:'title="Set/Change the Status of a FieldObject"',children:'var clone = _optionObject.Clone();\n\nstring fieldNumber = "123.45";\n\nclone.SetEnabledField(fieldNumber)      // or clone.SetDisabledField(fieldNumber)\nclone.SetLockedField(fieldNumber)       // or clone.SetUnlockedField(fieldNumber)\nclone.SetRequiredField(fieldNumber);    // or clone.SetOptionalField(fieldNumber)\n\nreturn clone.ToReturnOptionObject();\n'})}),"\n",(0,l.jsxs)(t.p,{children:["You can also set the status of multiple ",(0,l.jsx)(t.a,{href:"/docs/dotnet/data-model/fieldobject",children:"FieldObjects"})," in a single request."]}),"\n",(0,l.jsx)(t.pre,{children:(0,l.jsx)(t.code,{className:"language-cs",metastring:'title="Set/Change the Status of a FieldObject"',children:'var clone = _optionObject.Clone();\n\nList<string> fieldNumbers = new List<string>() {\n    "123.45",\n    "123.46",\n    "123.54"\n};\n\nclone.SetEnabledFields(fieldNumbers)     // or clone.SetDisabledFields(fieldNumbers)\nclone.SetLockedFields(fieldNumbers)      // or clone.SetUnlockedFields(fieldNumbers)\nclone.SetRequiredFields(fieldNumbers);   // or clone.SetOptionalFields(fieldNumbers)\n\nreturn clone.ToReturnOptionObject();\n'})}),"\n",(0,l.jsx)(t.h2,{id:"verify-statuses",children:"Verify Statuses"}),"\n",(0,l.jsxs)(t.p,{children:["There are also helper methods to help verify the current state of a ",(0,l.jsx)(t.a,{href:"/docs/dotnet/data-model/fieldobject",children:"FieldObject"}),"."]}),"\n",(0,l.jsxs)(t.ul,{children:["\n",(0,l.jsx)(t.li,{children:(0,l.jsx)(t.code,{children:"IsFieldEnabled"})}),"\n",(0,l.jsx)(t.li,{children:(0,l.jsx)(t.code,{children:"IsFieldLocked"})}),"\n",(0,l.jsx)(t.li,{children:(0,l.jsx)(t.code,{children:"IsFieldRequired"})}),"\n"]}),"\n",(0,l.jsx)(t.pre,{children:(0,l.jsx)(t.code,{className:"language-cs",metastring:'title="Verify the Status of a FieldObject"',children:'var clone = _optionObject.Clone();\n\nstring fieldNumber = "123.45";\n\nif (!clone.IsFieldRequired(fieldNumber))\n    clone.SetRequiredField(fieldNumber);\n\nreturn clone.ToReturnOptionObject();\n'})})]})}function u(e={}){const{wrapper:t}={...(0,s.R)(),...e.components};return t?(0,l.jsx)(t,{...e,children:(0,l.jsx)(a,{...e})}):a(e)}},4122:(e,t,n)=>{n.d(t,{A:()=>i});const i=n.p+"assets/images/WorkingWithFieldObjects-dc3a2683af6eb47c8809afbfec392896.png"},8453:(e,t,n)=>{n.d(t,{R:()=>d,x:()=>r});var i=n(6540);const l={},s=i.createContext(l);function d(e){const t=i.useContext(s);return i.useMemo((function(){return"function"==typeof e?e(t):{...t,...e}}),[t,e])}function r(e){let t;return t=e.disableParentContext?"function"==typeof e.components?e.components(l):e.components||l:d(e.components),i.createElement(s.Provider,{value:t},e.children)}}}]);