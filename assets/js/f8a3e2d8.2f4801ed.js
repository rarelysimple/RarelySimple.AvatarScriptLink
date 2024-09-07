"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[2552],{9933:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>l,contentTitle:()=>s,default:()=>h,frontMatter:()=>o,metadata:()=>a,toc:()=>d});var i=n(4848),r=n(8453);const o={title:"Data Model",image:"./DataModel.png",sidebar_position:3},s="Data Model",a={id:"dotnet/data-model/README",title:"Data Model",description:"Netsmart has defined the data model to use with Avatar ScriptLink to support consitent integration with any SOAP API that can support the data model and security requirements.",source:"@site/docs/dotnet/data-model/README.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/",permalink:"/docs/next/dotnet/data-model/",draft:!1,unlisted:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/README.mdx",tags:[],version:"current",sidebarPosition:3,frontMatter:{title:"Data Model",image:"./DataModel.png",sidebar_position:3},sidebar:"dotnetSidebar",previous:{title:"Migration",permalink:"/docs/next/dotnet/getting-started/migration"},next:{title:"OptionObject2015",permalink:"/docs/next/dotnet/data-model/optionobject2015"}},l={image:n(4924).A},d=[{value:"Avatar ScriptLink",id:"avatar-scriptlink",level:2},{value:"Standard",id:"standard",level:3},{value:"Multiple Iteration",id:"multiple-iteration",level:3},{value:"AvatarScriptLink.NET",id:"avatarscriptlinknet",level:2},{value:"ErrorCode",id:"errorcode",level:3},{value:"FieldAction",id:"fieldaction",level:3},{value:"Parameter",id:"parameter",level:3},{value:"RowAction",id:"rowaction",level:3}];function c(e){const t={a:"a",code:"code",em:"em",h1:"h1",h2:"h2",h3:"h3",header:"header",mermaid:"mermaid",p:"p",table:"table",tbody:"tbody",td:"td",th:"th",thead:"thead",tr:"tr",...(0,r.R)(),...e.components};return(0,i.jsxs)(i.Fragment,{children:[(0,i.jsx)(t.header,{children:(0,i.jsx)(t.h1,{id:"data-model",children:"Data Model"})}),"\n",(0,i.jsxs)(t.p,{children:["Netsmart has defined the data model to use with Avatar ScriptLink to support consitent integration with any SOAP API that can support the data model and security requirements.\nThis includes some coded values (I.e., ",(0,i.jsx)(t.code,{children:"ErrorCode"})," and ",(0,i.jsx)(t.code,{children:"RowAction"}),") that the AvatarScriptLink.NET library defines classes for.\nAdditionally, the AvatarScriptLink.NET library expands on the data model to assist with common implementation designs."]}),"\n",(0,i.jsx)(t.h2,{id:"avatar-scriptlink",children:"Avatar ScriptLink"}),"\n",(0,i.jsx)(t.p,{children:"The request and response payloads consist of an OptionObject2015 as defined in your APIs WSDL."}),"\n",(0,i.jsx)(t.h3,{id:"standard",children:"Standard"}),"\n",(0,i.jsx)(t.p,{children:"A standard form in myAvatar will include only a single RowObject containing all fields on that form."}),"\n",(0,i.jsx)(t.mermaid,{value:'classDiagram\ndirection LR\nclass OptionObject2015 {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n}\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n}\n\nclass FieldObject {\n    +string Enabled\n    +string FieldNumber\n    +string FieldValue\n    +string Lock\n    +string Required\n}\n\nOptionObject2015 "1" --o "*" FormObject : Forms\nFormObject "1" --o "1" RowObject : CurrentRow\nRowObject "1" --o "*" FieldObject : Fields\n\nclick OptionObject2015 href "./optionobject2015" "Learn more about the OptionObject2015"\nclick FormObject href "./formobject" "Learn more about the FormObject"\nclick RowObject href "./rowobject" "Learn more about the RowObject"\nclick FieldObject href "./fieldobject" "Learn more about the FieldObject"'}),"\n",(0,i.jsx)(t.h3,{id:"multiple-iteration",children:"Multiple Iteration"}),"\n",(0,i.jsx)(t.p,{children:"When a myAvatar form (OptionObject2015) includes a multiple iteration table in one or more of the sections (FormObject), the selected RowObject will be in the CurrentRow and any other rows in OtherRows.\nMultiple Iteration Tables can never be ther first section (FormObject) on a myAvatar form."}),"\n",(0,i.jsx)(t.mermaid,{value:'classDiagram\ndirection LR\nclass OptionObject2015 {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n}\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n}\n\nclass FieldObject {\n    +string Enabled\n    +string FieldNumber\n    +string FieldValue\n    +string Lock\n    +string Required\n}\n\nOptionObject2015 "1" --o "*" FormObject : Forms\nFormObject "1" --o "1" RowObject : CurrentRow\nFormObject "1" --o "*" RowObject : OtherRows\nRowObject "1" --o "*" FieldObject : Fields\n\nclick OptionObject2015 href "./optionobject2015" "Learn more about the OptionObject2015"\nclick FormObject href "./formobject" "Learn more about the FormObject"\nclick RowObject href "./rowobject" "Learn more about the RowObject"\nclick FieldObject href "./fieldobject" "Learn more about the FieldObject"'}),"\n",(0,i.jsx)(t.h2,{id:"avatarscriptlinknet",children:"AvatarScriptLink.NET"}),"\n",(0,i.jsx)(t.p,{children:"The following have been implemented as part of the AvatarScriptLink.NET library to assist with writing and troubleshooting ScriptLink APIs."}),"\n",(0,i.jsx)(t.h3,{id:"errorcode",children:"ErrorCode"}),"\n",(0,i.jsx)(t.p,{children:"Avatar ScriptLink APIs must respond with an ErrorCode (i.e., Status Code).\nThe valid codes are defined by myAvatar and are listed below with their helper class equivalents."}),"\n",(0,i.jsx)(t.p,{children:(0,i.jsx)(t.a,{href:"./errorcode",children:"Learn more"})}),"\n",(0,i.jsx)(t.h3,{id:"fieldaction",children:"FieldAction"}),"\n",(0,i.jsx)(t.p,{children:(0,i.jsx)(t.em,{children:"This is a utility class leveraged by the library internally and is not required in the most common use cases."})}),"\n",(0,i.jsx)(t.p,{children:"The FieldAction class is used within the AvatarScriptLink.NET to indicate which action is to be performed on a FieldObject."}),"\n",(0,i.jsxs)(t.table,{children:[(0,i.jsx)(t.thead,{children:(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.th,{style:{textAlign:"left"},children:"Action"}),(0,i.jsx)(t.th,{style:{textAlign:"left"},children:"Description"})]})}),(0,i.jsxs)(t.tbody,{children:[(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Disable"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Instructs method to disable a FieldObject."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Enable"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Instructs method to enable a FieldObject."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Lock"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Instructs method to lock a FieldObject."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Modify"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Instructs method to mark a FieldObject as modified."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Optional"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Instructs method to mark a FieldObject as optional."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Require"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Instructs method to mark a FieldObject as required."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Unlock"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Instructs method to unlock a FieldObject."})]})]})]}),"\n",(0,i.jsx)(t.h3,{id:"parameter",children:"Parameter"}),"\n",(0,i.jsx)(t.p,{children:"Avatar ScriptLink allows parameters to be defined when configuring myAvatar to call your ScriptLink API.\nTypically, implementers will delimit this parameter to allow the passing of multiple values to the API to modify the behavior.\nThe Parameter class helps to parse the delimited parameter string."}),"\n",(0,i.jsx)(t.h3,{id:"rowaction",children:"RowAction"}),"\n",(0,i.jsx)(t.p,{children:"The RowAction class is used to help you return valid RowAction values to myAvatar.\nThese values instruct myAvatar to add, edit, or delete a RowObject upon receipt of the response from the ScriptLink API."}),"\n",(0,i.jsx)(t.p,{children:(0,i.jsx)(t.a,{href:"./rowaction",children:"Learn more"})})]})}function h(e={}){const{wrapper:t}={...(0,r.R)(),...e.components};return t?(0,i.jsx)(t,{...e,children:(0,i.jsx)(c,{...e})}):c(e)}},4924:(e,t,n)=>{n.d(t,{A:()=>i});const i=n.p+"assets/images/DataModel-8eb2145976456d5427bc8428c5ef02eb.png"},8453:(e,t,n)=>{n.d(t,{R:()=>s,x:()=>a});var i=n(6540);const r={},o=i.createContext(r);function s(e){const t=i.useContext(o);return i.useMemo((function(){return"function"==typeof e?e(t):{...t,...e}}),[t,e])}function a(e){let t;return t=e.disableParentContext?"function"==typeof e.components?e.components(r):e.components||r:s(e.components),i.createElement(o.Provider,{value:t},e.children)}}}]);