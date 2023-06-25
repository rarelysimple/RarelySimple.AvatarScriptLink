"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[376],{3905:(e,t,a)=>{a.d(t,{Zo:()=>u,kt:()=>p});var n=a(7294);function r(e,t,a){return t in e?Object.defineProperty(e,t,{value:a,enumerable:!0,configurable:!0,writable:!0}):e[t]=a,e}function l(e,t){var a=Object.keys(e);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);t&&(n=n.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),a.push.apply(a,n)}return a}function i(e){for(var t=1;t<arguments.length;t++){var a=null!=arguments[t]?arguments[t]:{};t%2?l(Object(a),!0).forEach((function(t){r(e,t,a[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(a)):l(Object(a)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(a,t))}))}return e}function d(e,t){if(null==e)return{};var a,n,r=function(e,t){if(null==e)return{};var a,n,r={},l=Object.keys(e);for(n=0;n<l.length;n++)a=l[n],t.indexOf(a)>=0||(r[a]=e[a]);return r}(e,t);if(Object.getOwnPropertySymbols){var l=Object.getOwnPropertySymbols(e);for(n=0;n<l.length;n++)a=l[n],t.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(e,a)&&(r[a]=e[a])}return r}var o=n.createContext({}),s=function(e){var t=n.useContext(o),a=t;return e&&(a="function"==typeof e?e(t):i(i({},t),e)),a},u=function(e){var t=s(e.components);return n.createElement(o.Provider,{value:t},e.children)},c="mdxType",b={inlineCode:"code",wrapper:function(e){var t=e.children;return n.createElement(n.Fragment,{},t)}},m=n.forwardRef((function(e,t){var a=e.components,r=e.mdxType,l=e.originalType,o=e.parentName,u=d(e,["components","mdxType","originalType","parentName"]),c=s(a),m=r,p=c["".concat(o,".").concat(m)]||c[m]||b[m]||l;return a?n.createElement(p,i(i({ref:t},u),{},{components:a})):n.createElement(p,i({ref:t},u))}));function p(e,t){var a=arguments,r=t&&t.mdxType;if("string"==typeof e||r){var l=a.length,i=new Array(l);i[0]=m;var d={};for(var o in t)hasOwnProperty.call(t,o)&&(d[o]=t[o]);d.originalType=e,d[c]="string"==typeof e?e:r,i[1]=d;for(var s=2;s<l;s++)i[s]=a[s];return n.createElement.apply(null,i)}return n.createElement.apply(null,a)}m.displayName="MDXCreateElement"},5162:(e,t,a)=>{a.d(t,{Z:()=>i});var n=a(7294),r=a(6010);const l={tabItem:"tabItem_Ymn6"};function i(e){let{children:t,hidden:a,className:i}=e;return n.createElement("div",{role:"tabpanel",className:(0,r.Z)(l.tabItem,i),hidden:a},t)}},4866:(e,t,a)=>{a.d(t,{Z:()=>j});var n=a(7462),r=a(7294),l=a(6010),i=a(2466),d=a(6550),o=a(1980),s=a(7392),u=a(12);function c(e){return function(e){return r.Children.map(e,(e=>{if(!e||(0,r.isValidElement)(e)&&function(e){const{props:t}=e;return!!t&&"object"==typeof t&&"value"in t}(e))return e;throw new Error(`Docusaurus error: Bad <Tabs> child <${"string"==typeof e.type?e.type:e.type.name}>: all children of the <Tabs> component should be <TabItem>, and every <TabItem> should have a unique "value" prop.`)}))?.filter(Boolean)??[]}(e).map((e=>{let{props:{value:t,label:a,attributes:n,default:r}}=e;return{value:t,label:a,attributes:n,default:r}}))}function b(e){const{values:t,children:a}=e;return(0,r.useMemo)((()=>{const e=t??c(a);return function(e){const t=(0,s.l)(e,((e,t)=>e.value===t.value));if(t.length>0)throw new Error(`Docusaurus error: Duplicate values "${t.map((e=>e.value)).join(", ")}" found in <Tabs>. Every value needs to be unique.`)}(e),e}),[t,a])}function m(e){let{value:t,tabValues:a}=e;return a.some((e=>e.value===t))}function p(e){let{queryString:t=!1,groupId:a}=e;const n=(0,d.k6)(),l=function(e){let{queryString:t=!1,groupId:a}=e;if("string"==typeof t)return t;if(!1===t)return null;if(!0===t&&!a)throw new Error('Docusaurus error: The <Tabs> component groupId prop is required if queryString=true, because this value is used as the search param name. You can also provide an explicit value such as queryString="my-search-param".');return a??null}({queryString:t,groupId:a});return[(0,o._X)(l),(0,r.useCallback)((e=>{if(!l)return;const t=new URLSearchParams(n.location.search);t.set(l,e),n.replace({...n.location,search:t.toString()})}),[l,n])]}function f(e){const{defaultValue:t,queryString:a=!1,groupId:n}=e,l=b(e),[i,d]=(0,r.useState)((()=>function(e){let{defaultValue:t,tabValues:a}=e;if(0===a.length)throw new Error("Docusaurus error: the <Tabs> component requires at least one <TabItem> children component");if(t){if(!m({value:t,tabValues:a}))throw new Error(`Docusaurus error: The <Tabs> has a defaultValue "${t}" but none of its children has the corresponding value. Available values are: ${a.map((e=>e.value)).join(", ")}. If you intend to show no default tab, use defaultValue={null} instead.`);return t}const n=a.find((e=>e.default))??a[0];if(!n)throw new Error("Unexpected error: 0 tabValues");return n.value}({defaultValue:t,tabValues:l}))),[o,s]=p({queryString:a,groupId:n}),[c,f]=function(e){let{groupId:t}=e;const a=function(e){return e?`docusaurus.tab.${e}`:null}(t),[n,l]=(0,u.Nk)(a);return[n,(0,r.useCallback)((e=>{a&&l.set(e)}),[a,l])]}({groupId:n}),g=(()=>{const e=o??c;return m({value:e,tabValues:l})?e:null})();(0,r.useLayoutEffect)((()=>{g&&d(g)}),[g]);return{selectedValue:i,selectValue:(0,r.useCallback)((e=>{if(!m({value:e,tabValues:l}))throw new Error(`Can't select invalid tab value=${e}`);d(e),s(e),f(e)}),[s,f,l]),tabValues:l}}var g=a(2389);const k={tabList:"tabList__CuJ",tabItem:"tabItem_LNqP"};function h(e){let{className:t,block:a,selectedValue:d,selectValue:o,tabValues:s}=e;const u=[],{blockElementScrollPositionUntilNextRender:c}=(0,i.o5)(),b=e=>{const t=e.currentTarget,a=u.indexOf(t),n=s[a].value;n!==d&&(c(t),o(n))},m=e=>{let t=null;switch(e.key){case"Enter":b(e);break;case"ArrowRight":{const a=u.indexOf(e.currentTarget)+1;t=u[a]??u[0];break}case"ArrowLeft":{const a=u.indexOf(e.currentTarget)-1;t=u[a]??u[u.length-1];break}}t?.focus()};return r.createElement("ul",{role:"tablist","aria-orientation":"horizontal",className:(0,l.Z)("tabs",{"tabs--block":a},t)},s.map((e=>{let{value:t,label:a,attributes:i}=e;return r.createElement("li",(0,n.Z)({role:"tab",tabIndex:d===t?0:-1,"aria-selected":d===t,key:t,ref:e=>u.push(e),onKeyDown:m,onClick:b},i,{className:(0,l.Z)("tabs__item",k.tabItem,i?.className,{"tabs__item--active":d===t})}),a??t)})))}function N(e){let{lazy:t,children:a,selectedValue:n}=e;const l=(Array.isArray(a)?a:[a]).filter(Boolean);if(t){const e=l.find((e=>e.props.value===n));return e?(0,r.cloneElement)(e,{className:"margin-top--md"}):null}return r.createElement("div",{className:"margin-top--md"},l.map(((e,t)=>(0,r.cloneElement)(e,{key:t,hidden:e.props.value!==n}))))}function O(e){const t=f(e);return r.createElement("div",{className:(0,l.Z)("tabs-container",k.tabList)},r.createElement(h,(0,n.Z)({},e,t)),r.createElement(N,(0,n.Z)({},e,t)))}function j(e){const t=(0,g.Z)();return r.createElement(O,(0,n.Z)({key:String(t)},e))}},5437:(e,t,a)=>{a.r(t),a.d(t,{assets:()=>u,contentTitle:()=>o,default:()=>p,frontMatter:()=>d,metadata:()=>s,toc:()=>c});var n=a(7462),r=(a(7294),a(3905)),l=a(4866),i=a(5162);const d={title:"FieldObject",image:"./FieldObject.png",sidebar_position:6},o="FieldObject",s={unversionedId:"dotnet/data-model/fieldobject",id:"dotnet/data-model/fieldobject",title:"FieldObject",description:"The FieldObject represents a field on a myAvatar form.",source:"@site/docs/dotnet/data-model/fieldobject.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/fieldobject",permalink:"/docs/dotnet/data-model/fieldobject",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/fieldobject.mdx",tags:[],version:"current",sidebarPosition:6,frontMatter:{title:"FieldObject",image:"./FieldObject.png",sidebar_position:6},sidebar:"dotnetSidebar",previous:{title:"RowObject",permalink:"/docs/dotnet/data-model/rowobject"},next:{title:"ErrorCode",permalink:"/docs/dotnet/data-model/errorcode"}},u={image:a(5741).Z},c=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2},{value:"Detailed Class Diagram",id:"detailed-class-diagram",level:2}],b={toc:c},m="wrapper";function p(e){let{components:t,...a}=e;return(0,r.kt)(m,(0,n.Z)({},b,a,{components:t,mdxType:"MDXLayout"}),(0,r.kt)("h1",{id:"fieldobject"},"FieldObject"),(0,r.kt)("p",null,"The FieldObject represents a field on a myAvatar form.\nAvatarScriptLink.NET adds several utility methods to assist with handlings these objects."),(0,r.kt)("mermaid",{value:"classDiagram\nclass FieldObject {\n    +string Enabled\n    +string FieldNumber\n    +string FieldValue\n    +string Lock\n    +string Required\n    +Builder() FieldObjectBuilder\n    +Clone() FieldObject\n    +Equals(FieldObjectBase) bool\n    +Equals(object) bool\n    +GetHashCode() int\n    +Initialize() FieldObject\n    +IsEnabled() bool\n    +IsLocked() bool\n    +IsModified() bool\n    +IsRequired() bool\n    +SetAsDisabled()\n    +SetAsEnabled()\n    +SetAsLocked()\n    +SetAsModified()\n    +SetAsOptional()\n    +SetAsRequired()\n    +SetAsUnlocked()\n    +SetFieldValue(string)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToXml() string\n}"}),(0,r.kt)("h2",{id:"properties"},"Properties"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:"left"},"Property"),(0,r.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"Enabled"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the Enabled value. The supported values are ",(0,r.kt)("inlineCode",{parentName:"td"},"0")," (False) and ",(0,r.kt)("inlineCode",{parentName:"td"},"1")," (True).")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"FieldNumber"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or Sets the FieldNumber value.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"FieldValue"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the FieldValue value.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"Lock"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the Lock value. The supported values are ",(0,r.kt)("inlineCode",{parentName:"td"},"0")," (False) and ",(0,r.kt)("inlineCode",{parentName:"td"},"1")," (True).")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"Required"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Gets or sets the Required value. The supported values are ",(0,r.kt)("inlineCode",{parentName:"td"},"0")," (False) and ",(0,r.kt)("inlineCode",{parentName:"td"},"1")," (True).")))),(0,r.kt)("h2",{id:"methods"},"Methods"),(0,r.kt)("table",null,(0,r.kt)("thead",{parentName:"table"},(0,r.kt)("tr",{parentName:"thead"},(0,r.kt)("th",{parentName:"tr",align:"left"},"Method"),(0,r.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,r.kt)("tbody",{parentName:"table"},(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"Builder()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Initializes a builder for constructing a FieldObject.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"Clone()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Creates a copy of the FieldObject.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldValue of a FieldObject.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"Initialize()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Initializes an empty FieldObject. This FieldObject will be disabled, unlocked, and not required upon initialization.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"IsEnabled()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns whether the FieldObject is enabled.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"IsLocked()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns whether the FieldObject is locked.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"IsModified()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns whether the FieldObject has been modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"IsRequired()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns whether the FieldObject is required.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetAsDisabled()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as disabled and marks the FieldObject as modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetAsEnabled()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as enabled and marks the FieldObject as modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetAsLocked()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as locked and marks the FieldObject as modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetAsModified()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetAsRequired()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as required and marks the FieldObject as modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetAsUnlocked()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets FieldObject as unlocked and marks the FieldObject as modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a FieldObject and marks the FieldObject as modified.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString(bool)"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldObject as an HTML string. The ",(0,r.kt)("inlineCode",{parentName:"td"},"<html>"),", ",(0,r.kt)("inlineCode",{parentName:"td"},"<head>"),", and ",(0,r.kt)("inlineCode",{parentName:"td"},"<body>")," tags can be included if desired.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"ToJson()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldObject as a JSON string.")),(0,r.kt)("tr",{parentName:"tbody"},(0,r.kt)("td",{parentName:"tr",align:"left"},"ToXml()"),(0,r.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldObject as an XML string.")))),(0,r.kt)("h2",{id:"examples"},"Examples"),(0,r.kt)("p",null,"Most implementations would not require working with the FieldObject directly, however here is an example that uses the FieldObject to create an ",(0,r.kt)("a",{parentName:"p",href:"../fieldobject"},"FieldObject")," for Unit Testing."),(0,r.kt)(l.Z,{mdxType:"Tabs"},(0,r.kt)(i.Z,{value:"cs",label:"C#",mdxType:"TabItem"},(0,r.kt)("pre",null,(0,r.kt)("code",{parentName:"pre",className:"language-cs"},'// Available in v.1.2 or later\n[TestMethod]\npublic void TestMethod1WithFluentBuilder()\n{\n    var expected = "value";\n    FieldObject fieldObject = FieldObject.Builder()\n        .FieldNumber("123.45").FieldValue(expected)\n        .Enabled()\n        .Build();\n    Assert.AreEqual(expected, fieldObject.FieldValue);\n}\n\n[TestMethod]\npublic void TestMethod1WithSimplifiedConstructor()\n{\n    var expected = "value";\n    FieldObject fieldObject = new FieldObject\n    {\n        FieldNumber = "123.45",\n        FieldValue = expected,\n        Enabled = "1"\n    };\n    Assert.AreEqual(expected, fieldObject.FieldValue);\n}\n'))),(0,r.kt)(i.Z,{value:"vb",label:"Visual Basic",mdxType:"TabItem"},(0,r.kt)("pre",null,(0,r.kt)("code",{parentName:"pre",className:"language-vb"},'\' Available in v.1.2 or later\n<TestMethod()> Public Sub TestMethod1WithFluentBuilder()\n    Dim expected As String = "value"\n    Dim fieldObject As FieldObject.Builder()\n        .FieldNumber("123.45").FieldValue(expected)\n        .Enabled()\n        .Build()\n    Assert.AreEqual(expected, fieldObject.FieldValue)\nEnd Sub\n\n<TestMethod()> Public Sub TestMethod1WithSimplifiedConstructor()\n    Dim expected As String = "value"\n    Dim fieldObject As New FieldObject With {\n        .FieldNumber = "123.45",\n        .FieldValue = expected,\n        .Enabled = "1"\n    }\n    Assert.AreEqual(expected, fieldObject.FieldValue)\nEnd Sub\n')))),(0,r.kt)("h2",{id:"detailed-class-diagram"},"Detailed Class Diagram"),(0,r.kt)("mermaid",{value:"classDiagram\nclass FieldObject {\n    +Builder() FieldObjectBuilder\n    +Clone() FieldObject\n    +Initialize() FieldObject\n    +ToXml() string\n}\n\nclass FieldObjectBase {\n    +string Enabled\n    +string FieldNumber\n    +string FieldValue\n    +string Lock\n    +string Required\n    +bool Modified\n    -string _enabled\n    -string _fieldNumber\n    -string _fieldValue\n    -string _locked\n    -bool _modified\n    -string _required\n    -string OriginalEnabled\n    -string OriginalFieldNumber\n    -string OriginalLocked\n    -string OriginalLocked\n    -string OriginalRequired\n    +Clone() FieldObjectBase\n    +Equals(FieldObjectBase) bool\n    +Equals(object) bool\n    +GetHashCode() int\n    +IsEnabled() bool\n    +IsLocked() bool\n    +IsModified() bool\n    +IsRequired() bool\n    +SetAsDisabled()\n    +SetAsEnabled()\n    +SetAsLocked()\n    +SetAsModified()\n    +SetAsOptional()\n    +SetAsRequired()\n    +SetAsUnlocked()\n    +SetFieldValue(string)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToXml() string\n}\n<<abstract>> FieldObjectBase\n\nclass IFieldObject {\n    string Enabled\n    string FieldName\n    string FieldValue\n    string Lock\n    bool Modified\n    string Required\n}\n<<interface>> IFieldObject\n\nclass IEquatable~FieldObjectBase~\n<<interface>> IEquatable~FieldObjectBase~\n\nFieldObject --|> FieldObjectBase : inherits\nFieldObjectBase --|> IEquatable~FieldObjectBase~ : inherits\nFieldObjectBase --|> IFieldObject : inherits"}))}p.isMDXComponent=!0},5741:(e,t,a)=>{a.d(t,{Z:()=>n});const n=a.p+"assets/images/FieldObject-b71e151d4fdf122213623ad545165bee.png"}}]);