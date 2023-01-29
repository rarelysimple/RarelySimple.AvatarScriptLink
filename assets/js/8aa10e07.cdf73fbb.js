"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[376],{3905:(e,t,a)=>{a.d(t,{Zo:()=>s,kt:()=>f});var r=a(7294);function n(e,t,a){return t in e?Object.defineProperty(e,t,{value:a,enumerable:!0,configurable:!0,writable:!0}):e[t]=a,e}function l(e,t){var a=Object.keys(e);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(e);t&&(r=r.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),a.push.apply(a,r)}return a}function d(e){for(var t=1;t<arguments.length;t++){var a=null!=arguments[t]?arguments[t]:{};t%2?l(Object(a),!0).forEach((function(t){n(e,t,a[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(a)):l(Object(a)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(a,t))}))}return e}function i(e,t){if(null==e)return{};var a,r,n=function(e,t){if(null==e)return{};var a,r,n={},l=Object.keys(e);for(r=0;r<l.length;r++)a=l[r],t.indexOf(a)>=0||(n[a]=e[a]);return n}(e,t);if(Object.getOwnPropertySymbols){var l=Object.getOwnPropertySymbols(e);for(r=0;r<l.length;r++)a=l[r],t.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(e,a)&&(n[a]=e[a])}return n}var o=r.createContext({}),p=function(e){var t=r.useContext(o),a=t;return e&&(a="function"==typeof e?e(t):d(d({},t),e)),a},s=function(e){var t=p(e.components);return r.createElement(o.Provider,{value:t},e.children)},m="mdxType",c={inlineCode:"code",wrapper:function(e){var t=e.children;return r.createElement(r.Fragment,{},t)}},b=r.forwardRef((function(e,t){var a=e.components,n=e.mdxType,l=e.originalType,o=e.parentName,s=i(e,["components","mdxType","originalType","parentName"]),m=p(a),b=n,f=m["".concat(o,".").concat(b)]||m[b]||c[b]||l;return a?r.createElement(f,d(d({ref:t},s),{},{components:a})):r.createElement(f,d({ref:t},s))}));function f(e,t){var a=arguments,n=t&&t.mdxType;if("string"==typeof e||n){var l=a.length,d=new Array(l);d[0]=b;var i={};for(var o in t)hasOwnProperty.call(t,o)&&(i[o]=t[o]);i.originalType=e,i[m]="string"==typeof e?e:n,d[1]=i;for(var p=2;p<l;p++)d[p]=a[p];return r.createElement.apply(null,d)}return r.createElement.apply(null,a)}b.displayName="MDXCreateElement"},5437:(e,t,a)=>{a.r(t),a.d(t,{assets:()=>o,contentTitle:()=>d,default:()=>m,frontMatter:()=>l,metadata:()=>i,toc:()=>p});var r=a(7462),n=(a(7294),a(3905));const l={title:"FieldObject",sidebar_position:6},d="FieldObject",i={unversionedId:"dotnet/data-model/fieldobject",id:"dotnet/data-model/fieldobject",title:"FieldObject",description:"The FieldObject represents a field on a myAvatar form.",source:"@site/docs/dotnet/data-model/fieldobject.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/fieldobject",permalink:"/docs/dotnet/data-model/fieldobject",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/fieldobject.mdx",tags:[],version:"current",sidebarPosition:6,frontMatter:{title:"FieldObject",sidebar_position:6},sidebar:"dotnetSidebar",previous:{title:"RowObject",permalink:"/docs/dotnet/data-model/rowobject"},next:{title:"ErrorCode",permalink:"/docs/dotnet/data-model/errorcode"}},o={},p=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2}],s={toc:p};function m(e){let{components:t,...a}=e;return(0,n.kt)("wrapper",(0,r.Z)({},s,a,{components:t,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"fieldobject"},"FieldObject"),(0,n.kt)("p",null,"The FieldObject represents a field on a myAvatar form."),(0,n.kt)("h2",{id:"properties"},"Properties"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Property"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Enabled"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the Enabled value. The supported case-sensitive values are ",(0,n.kt)("inlineCode",{parentName:"td"},"N")," and ",(0,n.kt)("inlineCode",{parentName:"td"},"Y"),".")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"FieldNumber"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Gets or Sets the FieldNumber value.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"FieldValue"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the FieldValue value.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Lock"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the Lock value. The supported case-sensitive values are ",(0,n.kt)("inlineCode",{parentName:"td"},"N")," and ",(0,n.kt)("inlineCode",{parentName:"td"},"Y"),".")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Required"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the Required value. The supported case-sensitive values are ",(0,n.kt)("inlineCode",{parentName:"td"},"N")," and ",(0,n.kt)("inlineCode",{parentName:"td"},"Y"),".")))),(0,n.kt)("h2",{id:"methods"},"Methods"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Method"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Clone()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Creates a copy of the FieldObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldValue of a FieldObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsEnabled()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether the FieldObject is enabled.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsLocked()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether the FieldObject is locked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsModified()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether the FieldObject has been modified.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsRequired()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether the FieldObject is required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetAsDisabled()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as disabled and marks the FieldObject as modified.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetAsEnabled()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as enabled and marks the FieldObject as modified.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetAsLocked()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as locked and marks the FieldObject as modified.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetAsModified()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as modified.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetAsRequired()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as required and marks the FieldObject as modified.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetAsUnlocked()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as unlocked and marks the FieldObject as modified.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a FieldObject and marks the FieldObject as modified.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString(bool)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldObject as an HTML string. The ",(0,n.kt)("inlineCode",{parentName:"td"},"<html>"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"<head>"),", and ",(0,n.kt)("inlineCode",{parentName:"td"},"<body>")," tags can be included if desired.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToJson()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldObject as a JSON string.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToXml()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldObject as an XML string.")))),(0,n.kt)("h2",{id:"examples"},"Examples"),(0,n.kt)("p",null,"Most implementations would not require working with the FieldObject directly, however here is an example that uses the FieldObject to create an ",(0,n.kt)("a",{parentName:"p",href:"../optionobject2015"},"OptionObject2015")," for Unit Testing."))}m.isMDXComponent=!0}}]);