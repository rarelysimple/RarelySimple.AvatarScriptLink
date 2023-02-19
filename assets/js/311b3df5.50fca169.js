"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[728],{3905:(e,t,r)=>{r.d(t,{Zo:()=>s,kt:()=>f});var a=r(7294);function n(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function o(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);t&&(a=a.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,a)}return r}function d(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?o(Object(r),!0).forEach((function(t){n(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):o(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function i(e,t){if(null==e)return{};var r,a,n=function(e,t){if(null==e)return{};var r,a,n={},o=Object.keys(e);for(a=0;a<o.length;a++)r=o[a],t.indexOf(r)>=0||(n[r]=e[r]);return n}(e,t);if(Object.getOwnPropertySymbols){var o=Object.getOwnPropertySymbols(e);for(a=0;a<o.length;a++)r=o[a],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(n[r]=e[r])}return n}var l=a.createContext({}),p=function(e){var t=a.useContext(l),r=t;return e&&(r="function"==typeof e?e(t):d(d({},t),e)),r},s=function(e){var t=p(e.components);return a.createElement(l.Provider,{value:t},e.children)},c="mdxType",m={inlineCode:"code",wrapper:function(e){var t=e.children;return a.createElement(a.Fragment,{},t)}},u=a.forwardRef((function(e,t){var r=e.components,n=e.mdxType,o=e.originalType,l=e.parentName,s=i(e,["components","mdxType","originalType","parentName"]),c=p(r),u=n,f=c["".concat(l,".").concat(u)]||c[u]||m[u]||o;return r?a.createElement(f,d(d({ref:t},s),{},{components:r})):a.createElement(f,d({ref:t},s))}));function f(e,t){var r=arguments,n=t&&t.mdxType;if("string"==typeof e||n){var o=r.length,d=new Array(o);d[0]=u;var i={};for(var l in t)hasOwnProperty.call(t,l)&&(i[l]=t[l]);i.originalType=e,i[c]="string"==typeof e?e:n,d[1]=i;for(var p=2;p<o;p++)d[p]=r[p];return a.createElement.apply(null,d)}return a.createElement.apply(null,r)}u.displayName="MDXCreateElement"},6719:(e,t,r)=>{r.r(t),r.d(t,{assets:()=>l,contentTitle:()=>d,default:()=>m,frontMatter:()=>o,metadata:()=>i,toc:()=>p});var a=r(7462),n=(r(7294),r(3905));const o={title:"ErrorCode",image:"./ErrorCode.png",sidebar_position:7},d="ErrorCode",i={unversionedId:"dotnet/data-model/errorcode",id:"dotnet/data-model/errorcode",title:"ErrorCode",description:"Avatar ScriptLink APIs must respond with an ErrorCode (i.e., Status Code).",source:"@site/docs/dotnet/data-model/errorcode.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/errorcode",permalink:"/docs/dotnet/data-model/errorcode",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/errorcode.mdx",tags:[],version:"current",sidebarPosition:7,frontMatter:{title:"ErrorCode",image:"./ErrorCode.png",sidebar_position:7},sidebar:"dotnetSidebar",previous:{title:"FieldObject",permalink:"/docs/dotnet/data-model/fieldobject"},next:{title:"RowAction",permalink:"/docs/dotnet/data-model/rowaction"}},l={image:r(2095).Z},p=[],s={toc:p},c="wrapper";function m(e){let{components:t,...r}=e;return(0,n.kt)(c,(0,a.Z)({},s,r,{components:t,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"errorcode"},"ErrorCode"),(0,n.kt)("p",null,"Avatar ScriptLink APIs must respond with an ErrorCode (i.e., Status Code).\nThe valid codes are defined by myAvatar and are listed below with their helper class equivalents."),(0,n.kt)("p",null,"The helper class is designed to help your code remain readable even to new developer who have never worked with Avatar ScriptLink before."),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"myAvatar ErrorCode"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Available ErrorCodes"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"0"),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"None"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"Success")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates that the request was successful and no prompts are required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"1"),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"Error")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates an error occurred, a notice should be displayed, and processing should be aborted.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"2"),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"OkCancel"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"Warning")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates a business error occurred and the user should be prompted whether to abort processing as a result.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"3"),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"Info"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"Informational"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"Alert")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates the request was successful a message should be displayed to the user.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"4"),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"YesNo"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"Confirm")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates a business error occurred and the user should be prompted whether to abort processing as a result.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"5"),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"OpenUrl")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates that myAvatar should launch the URL passed in the ErrorMesg.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"6"),(0,n.kt)("td",{parentName:"tr",align:"left"},(0,n.kt)("inlineCode",{parentName:"td"},"OpenForm")),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates that myAvatar should launch the myAvatar form specified in the ErrorMesg.")))))}m.isMDXComponent=!0},2095:(e,t,r)=>{r.d(t,{Z:()=>a});const a=r.p+"assets/images/ErrorCode-86e368d8324662f6f30e3d8a540cf73c.png"}}]);