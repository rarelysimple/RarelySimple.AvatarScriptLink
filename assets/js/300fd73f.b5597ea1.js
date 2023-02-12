"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[418],{3905:(e,t,n)=>{n.d(t,{Zo:()=>c,kt:()=>p});var a=n(7294);function r(e,t,n){return t in e?Object.defineProperty(e,t,{value:n,enumerable:!0,configurable:!0,writable:!0}):e[t]=n,e}function i(e,t){var n=Object.keys(e);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);t&&(a=a.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),n.push.apply(n,a)}return n}function l(e){for(var t=1;t<arguments.length;t++){var n=null!=arguments[t]?arguments[t]:{};t%2?i(Object(n),!0).forEach((function(t){r(e,t,n[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(n)):i(Object(n)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(n,t))}))}return e}function d(e,t){if(null==e)return{};var n,a,r=function(e,t){if(null==e)return{};var n,a,r={},i=Object.keys(e);for(a=0;a<i.length;a++)n=i[a],t.indexOf(n)>=0||(r[n]=e[n]);return r}(e,t);if(Object.getOwnPropertySymbols){var i=Object.getOwnPropertySymbols(e);for(a=0;a<i.length;a++)n=i[a],t.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(e,n)&&(r[n]=e[n])}return r}var o=a.createContext({}),s=function(e){var t=a.useContext(o),n=t;return e&&(n="function"==typeof e?e(t):l(l({},t),e)),n},c=function(e){var t=s(e.components);return a.createElement(o.Provider,{value:t},e.children)},b="mdxType",u={inlineCode:"code",wrapper:function(e){var t=e.children;return a.createElement(a.Fragment,{},t)}},m=a.forwardRef((function(e,t){var n=e.components,r=e.mdxType,i=e.originalType,o=e.parentName,c=d(e,["components","mdxType","originalType","parentName"]),b=s(n),m=r,p=b["".concat(o,".").concat(m)]||b[m]||u[m]||i;return n?a.createElement(p,l(l({ref:t},c),{},{components:n})):a.createElement(p,l({ref:t},c))}));function p(e,t){var n=arguments,r=t&&t.mdxType;if("string"==typeof e||r){var i=n.length,l=new Array(i);l[0]=m;var d={};for(var o in t)hasOwnProperty.call(t,o)&&(d[o]=t[o]);d.originalType=e,d[b]="string"==typeof e?e:r,l[1]=d;for(var s=2;s<i;s++)l[s]=n[s];return a.createElement.apply(null,l)}return a.createElement.apply(null,n)}m.displayName="MDXCreateElement"},5162:(e,t,n)=>{n.d(t,{Z:()=>l});var a=n(7294),r=n(6010);const i="tabItem_Ymn6";function l(e){let{children:t,hidden:n,className:l}=e;return a.createElement("div",{role:"tabpanel",className:(0,r.Z)(i,l),hidden:n},t)}},4866:(e,t,n)=>{n.d(t,{Z:()=>F});var a=n(7462),r=n(7294),i=n(6010),l=n(2466),d=n(6550),o=n(1980),s=n(7392),c=n(12);function b(e){return function(e){return r.Children.map(e,(e=>{if((0,r.isValidElement)(e)&&"value"in e.props)return e;throw new Error(`Docusaurus error: Bad <Tabs> child <${"string"==typeof e.type?e.type:e.type.name}>: all children of the <Tabs> component should be <TabItem>, and every <TabItem> should have a unique "value" prop.`)}))}(e).map((e=>{let{props:{value:t,label:n,attributes:a,default:r}}=e;return{value:t,label:n,attributes:a,default:r}}))}function u(e){const{values:t,children:n}=e;return(0,r.useMemo)((()=>{const e=t??b(n);return function(e){const t=(0,s.l)(e,((e,t)=>e.value===t.value));if(t.length>0)throw new Error(`Docusaurus error: Duplicate values "${t.map((e=>e.value)).join(", ")}" found in <Tabs>. Every value needs to be unique.`)}(e),e}),[t,n])}function m(e){let{value:t,tabValues:n}=e;return n.some((e=>e.value===t))}function p(e){let{queryString:t=!1,groupId:n}=e;const a=(0,d.k6)(),i=function(e){let{queryString:t=!1,groupId:n}=e;if("string"==typeof t)return t;if(!1===t)return null;if(!0===t&&!n)throw new Error('Docusaurus error: The <Tabs> component groupId prop is required if queryString=true, because this value is used as the search param name. You can also provide an explicit value such as queryString="my-search-param".');return n??null}({queryString:t,groupId:n});return[(0,o._X)(i),(0,r.useCallback)((e=>{if(!i)return;const t=new URLSearchParams(a.location.search);t.set(i,e),a.replace({...a.location,search:t.toString()})}),[i,a])]}function g(e){const{defaultValue:t,queryString:n=!1,groupId:a}=e,i=u(e),[l,d]=(0,r.useState)((()=>function(e){let{defaultValue:t,tabValues:n}=e;if(0===n.length)throw new Error("Docusaurus error: the <Tabs> component requires at least one <TabItem> children component");if(t){if(!m({value:t,tabValues:n}))throw new Error(`Docusaurus error: The <Tabs> has a defaultValue "${t}" but none of its children has the corresponding value. Available values are: ${n.map((e=>e.value)).join(", ")}. If you intend to show no default tab, use defaultValue={null} instead.`);return t}const a=n.find((e=>e.default))??n[0];if(!a)throw new Error("Unexpected error: 0 tabValues");return a.value}({defaultValue:t,tabValues:i}))),[o,s]=p({queryString:n,groupId:a}),[b,g]=function(e){let{groupId:t}=e;const n=function(e){return e?`docusaurus.tab.${e}`:null}(t),[a,i]=(0,c.Nk)(n);return[a,(0,r.useCallback)((e=>{n&&i.set(e)}),[n,i])]}({groupId:a}),f=(()=>{const e=o??b;return m({value:e,tabValues:i})?e:null})();(0,r.useEffect)((()=>{f&&d(f)}),[f]);return{selectedValue:l,selectValue:(0,r.useCallback)((e=>{if(!m({value:e,tabValues:i}))throw new Error(`Can't select invalid tab value=${e}`);d(e),s(e),g(e)}),[s,g,i]),tabValues:i}}var f=n(2389);const k="tabList__CuJ",j="tabItem_LNqP";function N(e){let{className:t,block:n,selectedValue:d,selectValue:o,tabValues:s}=e;const c=[],{blockElementScrollPositionUntilNextRender:b}=(0,l.o5)(),u=e=>{const t=e.currentTarget,n=c.indexOf(t),a=s[n].value;a!==d&&(b(t),o(a))},m=e=>{let t=null;switch(e.key){case"Enter":u(e);break;case"ArrowRight":{const n=c.indexOf(e.currentTarget)+1;t=c[n]??c[0];break}case"ArrowLeft":{const n=c.indexOf(e.currentTarget)-1;t=c[n]??c[c.length-1];break}}t?.focus()};return r.createElement("ul",{role:"tablist","aria-orientation":"horizontal",className:(0,i.Z)("tabs",{"tabs--block":n},t)},s.map((e=>{let{value:t,label:n,attributes:l}=e;return r.createElement("li",(0,a.Z)({role:"tab",tabIndex:d===t?0:-1,"aria-selected":d===t,key:t,ref:e=>c.push(e),onKeyDown:m,onClick:u},l,{className:(0,i.Z)("tabs__item",j,l?.className,{"tabs__item--active":d===t})}),n??t)})))}function O(e){let{lazy:t,children:n,selectedValue:a}=e;if(t){const e=n.find((e=>e.props.value===a));return e?(0,r.cloneElement)(e,{className:"margin-top--md"}):null}return r.createElement("div",{className:"margin-top--md"},n.map(((e,t)=>(0,r.cloneElement)(e,{key:t,hidden:e.props.value!==a}))))}function h(e){const t=g(e);return r.createElement("div",{className:(0,i.Z)("tabs-container",k)},r.createElement(N,(0,a.Z)({},e,t)),r.createElement(O,(0,a.Z)({},e,t)))}function F(e){const t=(0,f.Z)();return r.createElement(h,(0,a.Z)({key:String(t)},e))}},9221:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>c,contentTitle:()=>o,default:()=>m,frontMatter:()=>d,metadata:()=>s,toc:()=>b});var a=n(7462),r=(n(7294),n(3905)),i=n(4866),l=n(5162);const d={title:"RowObject",image:"./RowObject.png",sidebar_position:5},o="RowObject",s={unversionedId:"dotnet/data-model/rowobject",id:"dotnet/data-model/rowobject",title:"RowObject",description:"The RowObject represents the contents of a myAvatar form section. I.e., the collection of FieldObjects that make up the section.",source:"@site/docs/dotnet/data-model/rowobject.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/rowobject",permalink:"/docs/dotnet/data-model/rowobject",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/rowobject.mdx",tags:[],version:"current",sidebarPosition:5,frontMatter:{title:"RowObject",image:"./RowObject.png",sidebar_position:5},sidebar:"dotnetSidebar",previous:{title:"FormObject",permalink:"/docs/dotnet/data-model/formobject"},next:{title:"FieldObject",permalink:"/docs/dotnet/data-model/fieldobject"}},c={image:n(5959).Z},b=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2},{value:"Detailed Class Diagram",id:"detailed-class-diagram",level:2}],u={toc:b};function m(e){let{components:t,...n}=e;return(0,r.kt)("wrapper",(0,a.Z)({},u,n,{components:t,mdxType:"MDXLayout"}),(0,r.kt)("h1",{id:"rowobject"},"RowObject"),(0,r.kt)("p",null,"The RowObject represents the contents of a myAvatar form section. I.e., the collection of FieldObjects that make up the section.\nAvatarScriptLink.NET adds several utility methods to assist with handlings these objects."),(0,r.kt)("mermaid",{value:'classDiagram\ndirection LR\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n    +AddFieldObject(FieldObject)\n    +AddFieldObject(string, string)\n    +AddFieldObject(string, string, string, string, string)\n    +AddFieldObject(string, string, bool, bool, bool)\n    +Clone() RowObject\n    +Equals(RowObjectBase)\n    +Equals(object)\n    +GetFieldValue(string) string\n    +GetHashCode()\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +RemoveFieldObject(FieldObject)\n    +RemoveFieldObject(string)\n    +RemoveUnmodifiedFieldObjects()\n    +SetDisabledField(string)\n    +SetDisabledFields(List~string~)\n    +SetEnabledField(string)\n    +SetEnabledFields(List~string~)\n    +SetFieldValue(string, string)\n    +SetLockedField(string)\n    +SetLockedFields(List~string~)\n    +SetOptionalField(string)\n    +SetOptionalFields(List~string~)\n    +SetRequiredField(string)\n    +SetRequiredFields(List~string~)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(List~string~)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToXml() string\n}\n\nclass FieldObject {\n    +string Enabled\n    +string FieldNumber\n    +string FieldValue\n    +string Lock\n    +string Required\n}\n\nRowObject "1" --o "*" FieldObject : Fields\n\nclick FieldObject href "./fieldobject" "Learn more about the FieldObject"'}),(0,r.kt)("h2",{id:"properties"},"Properties"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:"left"},"Property"),(0,r.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"Fields"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the Fields value.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"ParentRowId"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or Sets the ParentRowId value.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"RowAction"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the RowAction value. The supported case-sensitive values are blank, ",(0,r.kt)("inlineCode",{parentName:"td"},"ADD"),", ",(0,r.kt)("inlineCode",{parentName:"td"},"EDIT"),", and ",(0,r.kt)("inlineCode",{parentName:"td"},"DELETE"),".")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"RowId"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or set the RowId value.")))),(0,r.kt)("h2",{id:"methods"},"Methods"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:"left"},"Method"),(0,r.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"AddFieldObject(",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject"),")"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," to a the RowObject.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"AddFieldObject(string, string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," to a RowObject using supplied FieldNumber and FieldValue.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"AddFieldObject(string, string, string, string, string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," to a RowObject using supplied FieldNumber and FieldValue and setting the Enabled, Locked, and Required values (e.g., ",(0,r.kt)("inlineCode",{parentName:"td"},"Y")," or ",(0,r.kt)("inlineCode",{parentName:"td"},"N"),").")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"AddFieldObject(string, string, bool, bool, bool)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," to a RowObject using supplied FieldNumber and FieldValue and setting the Enabled, Locked, and Required values.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"Clone()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Creates a copy of the RowObject.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldValue of a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"IsFieldEnabled(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject is enabled by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"IsFieldLocked(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject is locked by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"IsFieldPresent(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject is present by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"IsFieldRequired(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject is required by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"RemoveFieldObject(",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject"),")"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Removes a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," from a RowObject.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"RemoveFieldObject(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Removes a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," from a RowObject by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"RemoveUnmodifiedFieldObjects()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Removes ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," from RowObject that have not been modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetDisabledField(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject as disabled by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetDisabledFields(List","<","string",">",")"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a RowObject as disabled by FieldNumbers.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the RowObject by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetLockedField(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject as locked by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetLockedFields(List","<","string",">",")"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a RowObject as locked by FieldNumbers.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetOptionalField(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject as enabled and not required by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetOptionalFields(List","<","string",">",")"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a RowObject as enabled and not required by FieldNumbers.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetRequiredField(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject as enabled and required by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetRequiredFields(List","<","string",">",")"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a RowObject as enabled and required by FieldNumbers.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedField(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a RowObject as unlocked by FieldNumber.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedFields(List","<","string",">",")"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,r.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a RowObject as unlocked by FieldNumbers.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString(bool)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns the RowObject as an HTML string. The ",(0,r.kt)("inlineCode",{parentName:"td"},"<html>"),", ",(0,r.kt)("inlineCode",{parentName:"td"},"<head>"),", and ",(0,r.kt)("inlineCode",{parentName:"td"},"<body>")," tags can be included if desired.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"ToJson()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns the RowObject as a JSON string.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"ToXml()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns the RowObject as an XML string.")))),(0,r.kt)("h2",{id:"examples"},"Examples"),(0,r.kt)("p",null,"Most implementations would not require working with the RowObject directly, however here is an example that uses the RowObject to create an ",(0,r.kt)("a",{parentName:"p",href:"../optionobject2015"},"OptionObject2015")," for Unit Testing."),(0,r.kt)(i.Z,{mdxType:"Tabs"},(0,r.kt)(l.Z,{value:"cs",label:"C#",mdxType:"TabItem"},(0,r.kt)("pre",null,(0,r.kt)("code",{parentName:"pre",className:"language-cs"},'[TestMethod]\npublic void TestMethod1()\n{\n    var expected = "value";\n    RowObject rowObject = new RowObject\n    {\n        RowId = "123||45"\n    };\n    Assert.AreEqual(expected, rowObject.RowId);\n}\n'))),(0,r.kt)(l.Z,{value:"vb",label:"Visual Basic",mdxType:"TabItem"},(0,r.kt)("pre",null,(0,r.kt)("code",{parentName:"pre",className:"language-vb"},'<TestMethod()> Public Sub TestMethod1()\n    Dim expected As String = "value"\n    Dim rowObject As New RowObject With {\n        .RowId = "123||45"\n    }\n    Assert.AreEqual(expected, rowObject.RowId)\nEnd Sub\n')))),(0,r.kt)("h2",{id:"detailed-class-diagram"},"Detailed Class Diagram"),(0,r.kt)("mermaid",{value:'classDiagram\ndirection LR\nclass RowObject {\n    +Clone() RowObject\n    +ToXml() string\n}\n\nclass RowObjectBase {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n    +AddFieldObject(FieldObject)\n    +AddFieldObject(string, string)\n    +AddFieldObject(string, string, string, string, string)\n    +AddFieldObject(string, string, bool, bool, bool)\n    +Clone() RowObjectBase\n    +Equals(RowObjectBase)\n    +Equals(object)\n    +GetFieldValue(string) string\n    +GetHashCode()\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +RemoveFieldObject(FieldObject)\n    +RemoveFieldObject(string)\n    +RemoveUnmodifiedFieldObjects()\n    +SetDisabledField(string)\n    +SetDisabledFields(List~string~)\n    +SetEnabledField(string)\n    +SetEnabledFields(List~string~)\n    +SetFieldValue(string, string)\n    +SetLockedField(string)\n    +SetLockedFields(List~string~)\n    +SetOptionalField(string)\n    +SetOptionalFields(List~string~)\n    +SetRequiredField(string)\n    +SetRequiredFields(List~string~)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(List~string~)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToXml() string\n    -AreBothEmpty(List~FieldObject~, List~FieldObject~)\n    -AreBothNull(List~FieldObject~, List~FieldObject~)\n    -AreFieldsEqual(List~FieldObject~, List~FieldObject~)\n}\n<<abstract>> RowObjectBase\n\nclass IRowObject {\n    List~FieldObject~ Fields\n    string ParentRowId\n    string RowAction\n    string RowId\n}\n<<interface>> IRowObject\n\nclass FieldObject {\n    +string Enabled\n    +string FieldNumber\n    +string FieldValue\n    +string Lock\n    +string Required\n}\n\nclass IEquatable~RowObjectBase~\n<<interface>> IEquatable~RowObjectBase~\n\nRowObjectBase "1" --o "*" FieldObject : Fields\n\nRowObject --|> RowObjectBase : inherits\nRowObjectBase --|> IEquatable~RowObjectBase~ : inherits\nRowObjectBase --|> IRowObject : inherits\n\nclick FieldObject href "./fieldobject" "Learn more about the FieldObject"'}))}m.isMDXComponent=!0},5959:(e,t,n)=>{n.d(t,{Z:()=>a});const a=n.p+"assets/images/RowObject-dd7067cbb966f68dfaa3167786ec9b19.png"}}]);