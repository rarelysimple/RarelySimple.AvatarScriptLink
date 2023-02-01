"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[689],{3905:(t,e,n)=>{n.d(e,{Zo:()=>d,kt:()=>u});var r=n(7294);function a(t,e,n){return e in t?Object.defineProperty(t,e,{value:n,enumerable:!0,configurable:!0,writable:!0}):t[e]=n,t}function i(t,e){var n=Object.keys(t);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(t);e&&(r=r.filter((function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable}))),n.push.apply(n,r)}return n}function o(t){for(var e=1;e<arguments.length;e++){var n=null!=arguments[e]?arguments[e]:{};e%2?i(Object(n),!0).forEach((function(e){a(t,e,n[e])})):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(n)):i(Object(n)).forEach((function(e){Object.defineProperty(t,e,Object.getOwnPropertyDescriptor(n,e))}))}return t}function l(t,e){if(null==t)return{};var n,r,a=function(t,e){if(null==t)return{};var n,r,a={},i=Object.keys(t);for(r=0;r<i.length;r++)n=i[r],e.indexOf(n)>=0||(a[n]=t[n]);return a}(t,e);if(Object.getOwnPropertySymbols){var i=Object.getOwnPropertySymbols(t);for(r=0;r<i.length;r++)n=i[r],e.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(t,n)&&(a[n]=t[n])}return a}var s=r.createContext({}),c=function(t){var e=r.useContext(s),n=e;return t&&(n="function"==typeof t?t(e):o(o({},e),t)),n},d=function(t){var e=c(t.components);return r.createElement(s.Provider,{value:e},t.children)},p="mdxType",m={inlineCode:"code",wrapper:function(t){var e=t.children;return r.createElement(r.Fragment,{},e)}},b=r.forwardRef((function(t,e){var n=t.components,a=t.mdxType,i=t.originalType,s=t.parentName,d=l(t,["components","mdxType","originalType","parentName"]),p=c(n),b=a,u=p["".concat(s,".").concat(b)]||p[b]||m[b]||i;return n?r.createElement(u,o(o({ref:e},d),{},{components:n})):r.createElement(u,o({ref:e},d))}));function u(t,e){var n=arguments,a=e&&e.mdxType;if("string"==typeof t||a){var i=n.length,o=new Array(i);o[0]=b;var l={};for(var s in e)hasOwnProperty.call(e,s)&&(l[s]=e[s]);l.originalType=t,l[p]="string"==typeof t?t:a,o[1]=l;for(var c=2;c<i;c++)o[c]=n[c];return r.createElement.apply(null,o)}return r.createElement.apply(null,n)}b.displayName="MDXCreateElement"},3795:(t,e,n)=>{n.r(e),n.d(e,{assets:()=>s,contentTitle:()=>o,default:()=>p,frontMatter:()=>i,metadata:()=>l,toc:()=>c});var r=n(7462),a=(n(7294),n(3905));const i={title:"Data Model",sidebar_position:3},o="Data Model",l={unversionedId:"dotnet/data-model/README",id:"dotnet/data-model/README",title:"Data Model",description:"Netsmart has defined the data model to use with Avatar ScriptLink to support consitent integration with any SOAP API that can support the data model and security requirements.",source:"@site/docs/dotnet/data-model/README.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/",permalink:"/docs/dotnet/data-model/",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/README.mdx",tags:[],version:"current",sidebarPosition:3,frontMatter:{title:"Data Model",sidebar_position:3},sidebar:"dotnetSidebar",previous:{title:"Compatibility",permalink:"/docs/dotnet/getting-started/compatibility"},next:{title:"OptionObject2015",permalink:"/docs/dotnet/data-model/optionobject2015"}},s={},c=[{value:"Avatar ScriptLink",id:"avatar-scriptlink",level:2},{value:"Standard",id:"standard",level:3},{value:"Multiple Iteration",id:"multiple-iteration",level:3},{value:"AvatarScriptLink.NET",id:"avatarscriptlinknet",level:2},{value:"ErrorCode",id:"errorcode",level:3},{value:"FieldAction",id:"fieldaction",level:3},{value:"Parameter",id:"parameter",level:3},{value:"RowAction",id:"rowaction",level:3}],d={toc:c};function p(t){let{components:e,...n}=t;return(0,a.kt)("wrapper",(0,r.Z)({},d,n,{components:e,mdxType:"MDXLayout"}),(0,a.kt)("h1",{id:"data-model"},"Data Model"),(0,a.kt)("p",null,"Netsmart has defined the data model to use with Avatar ScriptLink to support consitent integration with any SOAP API that can support the data model and security requirements.\nThis includes some coded values (I.e., ",(0,a.kt)("inlineCode",{parentName:"p"},"ErrorCode")," and ",(0,a.kt)("inlineCode",{parentName:"p"},"RowAction"),") that the AvatarScriptLink.NET library defines classes for.\nAdditionally, the AvatarScriptLink.NET library expands on the data model to assist with common implementation designs."),(0,a.kt)("h2",{id:"avatar-scriptlink"},"Avatar ScriptLink"),(0,a.kt)("p",null,"The request and response payloads consist of an OptionObject2015 as defined in your APIs WSDL."),(0,a.kt)("h3",{id:"standard"},"Standard"),(0,a.kt)("p",null,"A standard form in myAvatar will include only a single RowObject containing all fields on that form."),(0,a.kt)("mermaid",{value:'classDiagram\ndirection LR\nclass OptionObject2015 {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n}\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n}\n\nclass FieldObject {\n    +string Enabled\n    +string FieldNumber\n    +string FieldValue\n    +string Lock\n    +string Required\n}\n\nOptionObject2015 "1" --o "*" FormObject : Forms\nFormObject "1" --o "1" RowObject : CurrentRow\nRowObject "1" --o "*" FieldObject : Fields\n\nclick OptionObject2015 href "./optionobject2015" "Learn more about the OptionObject2015"\nclick FormObject href "./formobject" "Learn more about the FormObject"\nclick RowObject href "./rowobject" "Learn more about the RowObject"\nclick FieldObject href "./fieldobject" "Learn more about the FieldObject"'}),(0,a.kt)("h3",{id:"multiple-iteration"},"Multiple Iteration"),(0,a.kt)("p",null,"When a myAvatar form (OptionObject2015) includes a multiple iteration table in one or more of the sections (FormObject), the selected RowObject will be in the CurrentRow and any other rows in OtherRows.\nMultiple Iteration Tables can never be ther first section (FormObject) on a myAvatar form."),(0,a.kt)("mermaid",{value:'classDiagram\ndirection LR\nclass OptionObject2015 {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n}\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n}\n\nclass FieldObject {\n    +string Enabled\n    +string FieldNumber\n    +string FieldValue\n    +string Lock\n    +string Required\n}\n\nOptionObject2015 "1" --o "*" FormObject : Forms\nFormObject "1" --o "1" RowObject : CurrentRow\nFormObject "1" --o "*" RowObject : OtherRows\nRowObject "1" --o "*" FieldObject : Fields\n\nclick OptionObject2015 href "./optionobject2015" "Learn more about the OptionObject2015"\nclick FormObject href "./formobject" "Learn more about the FormObject"\nclick RowObject href "./rowobject" "Learn more about the RowObject"\nclick FieldObject href "./fieldobject" "Learn more about the FieldObject"'}),(0,a.kt)("h2",{id:"avatarscriptlinknet"},"AvatarScriptLink.NET"),(0,a.kt)("p",null,"The following have been implemented as part of the AvatarScriptLink.NET library to assist with writing and troubleshooting ScriptLink APIs."),(0,a.kt)("h3",{id:"errorcode"},"ErrorCode"),(0,a.kt)("p",null,"Avatar ScriptLink APIs must respond with an ErrorCode (i.e., Status Code).\nThe valid codes are defined by myAvatar and are listed below with their helper class equivalents."),(0,a.kt)("p",null,(0,a.kt)("a",{parentName:"p",href:"./errorcode"},"Learn more")),(0,a.kt)("h3",{id:"fieldaction"},"FieldAction"),(0,a.kt)("p",null,(0,a.kt)("em",{parentName:"p"},"This is a utility class leveraged by the library internally and is not required in the most common use cases.")),(0,a.kt)("p",null,"The FieldAction class is used within the AvatarScriptLink.NET to indicate which action is to be performed on a FieldObject."),(0,a.kt)("table",null,(0,a.kt)("thead",{parentName:"table"},(0,a.kt)("tr",{parentName:"thead"},(0,a.kt)("th",{parentName:"tr",align:"left"},"Action"),(0,a.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,a.kt)("tbody",{parentName:"table"},(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Disable"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Instructs method to disable a FieldObject.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Enable"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Instructs method to enable a FieldObject.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Lock"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Instructs method to lock a FieldObject.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Modify"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Instructs method to mark a FieldObject as modified.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Optional"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Instructs method to mark a FieldObject as optional.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Require"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Instructs method to mark a FieldObject as required.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Unlock"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Instructs method to unlock a FieldObject.")))),(0,a.kt)("h3",{id:"parameter"},"Parameter"),(0,a.kt)("p",null,"Avatar ScriptLink allows parameters to be defined when configuring myAvatar to call your ScriptLink API.\nTypically, implementers will delimit this parameter to allow the passing of multiple values to the API to modify the behavior.\nThe Parameter class helps to parse the delimited parameter string."),(0,a.kt)("h3",{id:"rowaction"},"RowAction"),(0,a.kt)("p",null,"The RowAction class is used to help you return valid RowAction values to myAvatar.\nThese values instruct myAvatar to add, edit, or delete a RowObject upon receipt of the response from the ScriptLink API."),(0,a.kt)("p",null,(0,a.kt)("a",{parentName:"p",href:"./rowaction"},"Learn more")))}p.isMDXComponent=!0}}]);