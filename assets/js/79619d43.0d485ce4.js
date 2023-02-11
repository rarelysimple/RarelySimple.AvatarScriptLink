"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[243],{3905:(e,t,r)=>{r.d(t,{Zo:()=>c,kt:()=>p});var a=r(7294);function n(e,t,r){return t in e?Object.defineProperty(e,t,{value:r,enumerable:!0,configurable:!0,writable:!0}):e[t]=r,e}function l(e,t){var r=Object.keys(e);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);t&&(a=a.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),r.push.apply(r,a)}return r}function i(e){for(var t=1;t<arguments.length;t++){var r=null!=arguments[t]?arguments[t]:{};t%2?l(Object(r),!0).forEach((function(t){n(e,t,r[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(r)):l(Object(r)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(r,t))}))}return e}function o(e,t){if(null==e)return{};var r,a,n=function(e,t){if(null==e)return{};var r,a,n={},l=Object.keys(e);for(a=0;a<l.length;a++)r=l[a],t.indexOf(r)>=0||(n[r]=e[r]);return n}(e,t);if(Object.getOwnPropertySymbols){var l=Object.getOwnPropertySymbols(e);for(a=0;a<l.length;a++)r=l[a],t.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(e,r)&&(n[r]=e[r])}return n}var d=a.createContext({}),s=function(e){var t=a.useContext(d),r=t;return e&&(r="function"==typeof e?e(t):i(i({},t),e)),r},c=function(e){var t=s(e.components);return a.createElement(d.Provider,{value:t},e.children)},b="mdxType",m={inlineCode:"code",wrapper:function(e){var t=e.children;return a.createElement(a.Fragment,{},t)}},u=a.forwardRef((function(e,t){var r=e.components,n=e.mdxType,l=e.originalType,d=e.parentName,c=o(e,["components","mdxType","originalType","parentName"]),b=s(r),u=n,p=b["".concat(d,".").concat(u)]||b[u]||m[u]||l;return r?a.createElement(p,i(i({ref:t},c),{},{components:r})):a.createElement(p,i({ref:t},c))}));function p(e,t){var r=arguments,n=t&&t.mdxType;if("string"==typeof e||n){var l=r.length,i=new Array(l);i[0]=u;var o={};for(var d in t)hasOwnProperty.call(t,d)&&(o[d]=t[d]);o.originalType=e,o[b]="string"==typeof e?e:n,i[1]=o;for(var s=2;s<l;s++)i[s]=r[s];return a.createElement.apply(null,i)}return a.createElement.apply(null,r)}u.displayName="MDXCreateElement"},5162:(e,t,r)=>{r.d(t,{Z:()=>i});var a=r(7294),n=r(6010);const l="tabItem_Ymn6";function i(e){let{children:t,hidden:r,className:i}=e;return a.createElement("div",{role:"tabpanel",className:(0,n.Z)(l,i),hidden:r},t)}},4866:(e,t,r)=>{r.d(t,{Z:()=>O});var a=r(7462),n=r(7294),l=r(6010),i=r(2466),o=r(6550),d=r(1980),s=r(7392),c=r(12);function b(e){return function(e){return n.Children.map(e,(e=>{if((0,n.isValidElement)(e)&&"value"in e.props)return e;throw new Error(`Docusaurus error: Bad <Tabs> child <${"string"==typeof e.type?e.type:e.type.name}>: all children of the <Tabs> component should be <TabItem>, and every <TabItem> should have a unique "value" prop.`)}))}(e).map((e=>{let{props:{value:t,label:r,attributes:a,default:n}}=e;return{value:t,label:r,attributes:a,default:n}}))}function m(e){const{values:t,children:r}=e;return(0,n.useMemo)((()=>{const e=t??b(r);return function(e){const t=(0,s.l)(e,((e,t)=>e.value===t.value));if(t.length>0)throw new Error(`Docusaurus error: Duplicate values "${t.map((e=>e.value)).join(", ")}" found in <Tabs>. Every value needs to be unique.`)}(e),e}),[t,r])}function u(e){let{value:t,tabValues:r}=e;return r.some((e=>e.value===t))}function p(e){let{queryString:t=!1,groupId:r}=e;const a=(0,o.k6)(),l=function(e){let{queryString:t=!1,groupId:r}=e;if("string"==typeof t)return t;if(!1===t)return null;if(!0===t&&!r)throw new Error('Docusaurus error: The <Tabs> component groupId prop is required if queryString=true, because this value is used as the search param name. You can also provide an explicit value such as queryString="my-search-param".');return r??null}({queryString:t,groupId:r});return[(0,d._X)(l),(0,n.useCallback)((e=>{if(!l)return;const t=new URLSearchParams(a.location.search);t.set(l,e),a.replace({...a.location,search:t.toString()})}),[l,a])]}function f(e){const{defaultValue:t,queryString:r=!1,groupId:a}=e,l=m(e),[i,o]=(0,n.useState)((()=>function(e){let{defaultValue:t,tabValues:r}=e;if(0===r.length)throw new Error("Docusaurus error: the <Tabs> component requires at least one <TabItem> children component");if(t){if(!u({value:t,tabValues:r}))throw new Error(`Docusaurus error: The <Tabs> has a defaultValue "${t}" but none of its children has the corresponding value. Available values are: ${r.map((e=>e.value)).join(", ")}. If you intend to show no default tab, use defaultValue={null} instead.`);return t}const a=r.find((e=>e.default))??r[0];if(!a)throw new Error("Unexpected error: 0 tabValues");return a.value}({defaultValue:t,tabValues:l}))),[d,s]=p({queryString:r,groupId:a}),[b,f]=function(e){let{groupId:t}=e;const r=function(e){return e?`docusaurus.tab.${e}`:null}(t),[a,l]=(0,c.Nk)(r);return[a,(0,n.useCallback)((e=>{r&&l.set(e)}),[r,l])]}({groupId:a}),g=(()=>{const e=d??b;return u({value:e,tabValues:l})?e:null})();(0,n.useEffect)((()=>{g&&o(g)}),[g]);return{selectedValue:i,selectValue:(0,n.useCallback)((e=>{if(!u({value:e,tabValues:l}))throw new Error(`Can't select invalid tab value=${e}`);o(e),s(e),f(e)}),[s,f,l]),tabValues:l}}var g=r(2389);const k="tabList__CuJ",N="tabItem_LNqP";function j(e){let{className:t,block:r,selectedValue:o,selectValue:d,tabValues:s}=e;const c=[],{blockElementScrollPositionUntilNextRender:b}=(0,i.o5)(),m=e=>{const t=e.currentTarget,r=c.indexOf(t),a=s[r].value;a!==o&&(b(t),d(a))},u=e=>{let t=null;switch(e.key){case"Enter":m(e);break;case"ArrowRight":{const r=c.indexOf(e.currentTarget)+1;t=c[r]??c[0];break}case"ArrowLeft":{const r=c.indexOf(e.currentTarget)-1;t=c[r]??c[c.length-1];break}}t?.focus()};return n.createElement("ul",{role:"tablist","aria-orientation":"horizontal",className:(0,l.Z)("tabs",{"tabs--block":r},t)},s.map((e=>{let{value:t,label:r,attributes:i}=e;return n.createElement("li",(0,a.Z)({role:"tab",tabIndex:o===t?0:-1,"aria-selected":o===t,key:t,ref:e=>c.push(e),onKeyDown:u,onClick:m},i,{className:(0,l.Z)("tabs__item",N,i?.className,{"tabs__item--active":o===t})}),r??t)})))}function F(e){let{lazy:t,children:r,selectedValue:a}=e;if(t){const e=r.find((e=>e.props.value===a));return e?(0,n.cloneElement)(e,{className:"margin-top--md"}):null}return n.createElement("div",{className:"margin-top--md"},r.map(((e,t)=>(0,n.cloneElement)(e,{key:t,hidden:e.props.value!==a}))))}function h(e){const t=f(e);return n.createElement("div",{className:(0,l.Z)("tabs-container",k)},n.createElement(j,(0,a.Z)({},e,t)),n.createElement(F,(0,a.Z)({},e,t)))}function O(e){const t=(0,g.Z)();return n.createElement(h,(0,a.Z)({key:String(t)},e))}},7422:(e,t,r)=>{r.r(t),r.d(t,{assets:()=>c,contentTitle:()=>d,default:()=>u,frontMatter:()=>o,metadata:()=>s,toc:()=>b});var a=r(7462),n=(r(7294),r(3905)),l=r(4866),i=r(5162);const o={title:"FormObject",sidebar_position:4},d="FormObject",s={unversionedId:"dotnet/data-model/formobject",id:"dotnet/data-model/formobject",title:"FormObject",description:"The FormObject represents a section of a myAvatar Form.",source:"@site/docs/dotnet/data-model/formobject.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/formobject",permalink:"/docs/dotnet/data-model/formobject",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/formobject.mdx",tags:[],version:"current",sidebarPosition:4,frontMatter:{title:"FormObject",sidebar_position:4},sidebar:"dotnetSidebar",previous:{title:"OptionObject2015",permalink:"/docs/dotnet/data-model/optionobject2015"},next:{title:"RowObject",permalink:"/docs/dotnet/data-model/rowobject"}},c={},b=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2},{value:"Detailed Class Diagram",id:"detailed-class-diagram",level:2}],m={toc:b};function u(e){let{components:t,...r}=e;return(0,n.kt)("wrapper",(0,a.Z)({},m,r,{components:t,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"formobject"},"FormObject"),(0,n.kt)("p",null,"The FormObject represents a section of a myAvatar Form.\nAvatarScriptLink.NET adds several utility methods to assist with handlings these objects."),(0,n.kt)("mermaid",{value:'classDiagram\ndirection LR\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormId\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n    +AddRowObject(RowObject)\n    +AddRowObject(string, string)\n    +AddRowObject(string, string, string)\n    +Clone() FormObject\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +Equals(FormObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId() string\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetNextAvailableRowId() string\n    +GetParentRowId() string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(string)\n    +SetEnabledField(string)\n    +SetEnabledFields(string)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(string)\n    +SetOptionalField(string)\n    +SetOptionalFields(string)\n    +SetRequiredField(string)\n    +SetRequiredFields(string)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(string)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToXml() string\n}\n\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n}\n\nFormObject "1" --o "1" RowObject : CurrentRow\nFormObject "1" --o "*" RowObject : OtherRows\n\nclick RowObject href "./rowobject" "Learn more about the RowObject"'}),(0,n.kt)("h2",{id:"properties"},"Properties"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Property"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"CurrentRow"),(0,n.kt)("td",{parentName:"tr",align:"left"},"The contents of this myAvatar Form section. The selected row on multiple iteration tables.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"FormId"),(0,n.kt)("td",{parentName:"tr",align:"left"},"The unique Id assigned to this section (FormObject).")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"MultipleIteration"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates whether this section uses a multiple iteration table. Note: this is not the same as TDE objects.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"OtherRows"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Contains the contents of unselected rows in the multiple iteration table.")))),(0,n.kt)("h2",{id:"methods"},"Methods"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Method"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"AddRowObject(",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," to a the FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"AddRowObject(string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," to a FormObject using supplied RowId and ParentRowId.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"AddRowObject(string, string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," to a FormObject using supplied RowId and ParentRowId and setting the RowAction.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Clone()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Creates a copy of the FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"DeleteRowObject(",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Removes a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," from a FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"DeleteRowObject(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Removes a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," from a FormObject by RowId.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Equals(FormObjectBase)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Used to compare two FormObject to determine if they are equal. Returns bool.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Equals(object)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Used to compare FormObject to an object to determine if they are equal. Returns bool.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetCurrentRowId()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the ID of the ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," in the CurrentRow of a FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetHashCode()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Overrides the GetHashCode method for a FormObjectBase.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldValue of a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldValue of a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject by RowId and FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetFieldValues(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns a List","<","string",">"," of FieldValues in a FormObject by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetNextAvailableRowId()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the next available RowId for the FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetParentRowId()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the ParentRowId of the FormObject.CurrentRow.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldEnabled(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is enabled by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldLocked(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is locked by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldModified(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is modified by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldPresent(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is present by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldRequired(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is required by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsRowMarkedForDeletion(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," in a FormObject is marked for deletion by RowId.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsRowPresent(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," in a FormObject is present by RowId.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetDisabledField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as disabled by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetDisabledFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as disabled by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetDisabledFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as disabled by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as disabled.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetEnabledField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as enabled by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetEnabledFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetEnabledFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as disabled.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the FormObject.CurrentRow by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the FormObject by RowId and FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetLockedField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Set the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as locked by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as locked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetLockedFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as locked by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetLockedFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as locked by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as locked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetOptionalField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as enabled and not required by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as enabled and not required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetOptionalFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled and not required by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetOptionalFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled and not required by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as enabled and not required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetRequiredField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as enabled and required by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as enabled and required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetRequiredFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled and required by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetRequiredFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled and required by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as enabled and required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as unlocked by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as unlocked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as unlocked by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as unlocked by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as unlocked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FormObject as an HTML string. The ",(0,n.kt)("inlineCode",{parentName:"td"},"<html>"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"<head>"),", and ",(0,n.kt)("inlineCode",{parentName:"td"},"<body>")," tags can be included if desired.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString(bool)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FormObject as an HTML string. The ",(0,n.kt)("inlineCode",{parentName:"td"},"<html>"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"<head>"),", and ",(0,n.kt)("inlineCode",{parentName:"td"},"<body>")," tags can be included if desired.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToJson()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FormObject as a JSON string.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToXml()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FormObject as an XML string.")))),(0,n.kt)("h2",{id:"examples"},"Examples"),(0,n.kt)("p",null,"Most implementations would not require working with the FormObject directly, however here is an example that uses the FormObject to create an ",(0,n.kt)("a",{parentName:"p",href:"../optionobject2015"},"OptionObject2015")," for Unit Testing."),(0,n.kt)(l.Z,{mdxType:"Tabs"},(0,n.kt)(i.Z,{value:"cs",label:"C#",mdxType:"TabItem"},(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-cs"},'[TestMethod]\npublic void TestMethod1()\n{\n    var expected = "value";\n    FormObject formObject = new FormObject\n    {\n        FormId = "123"\n    };\n    Assert.AreEqual(expected, formObject.FormId);\n}\n'))),(0,n.kt)(i.Z,{value:"vb",label:"Visual Basic",mdxType:"TabItem"},(0,n.kt)("pre",null,(0,n.kt)("code",{parentName:"pre",className:"language-vb"},'<TestMethod()> Public Sub TestMethod1()\n    Dim expected As String = "value"\n    Dim formObject As New FormObject With {\n        .FormId = "123"\n    }\n    Assert.AreEqual(expected, formObject.FormId)\nEnd Sub\n')))),(0,n.kt)("h2",{id:"detailed-class-diagram"},"Detailed Class Diagram"),(0,n.kt)("mermaid",{value:'classDiagram\ndirection LR\nclass FormObject {\n    +Clone() FormObject\n    +ToXml() string\n}\n\nclass FormObjectBase {\n    +RowObject CurrentRow\n    +string FormId\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n    +AddRowObject(RowObject)\n    +AddRowObject(string, string)\n    +AddRowObject(string, string, string)\n    +Clone() FormObjectBase\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +Equals(FormObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId() string\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetNextAvailableRowId() string\n    +GetParentRowId() string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(string)\n    +SetEnabledField(string)\n    +SetEnabledFields(string)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(string)\n    +SetOptionalField(string)\n    +SetOptionalFields(string)\n    +SetRequiredField(string)\n    +SetRequiredFields(string)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(string)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n}\n<<abstract>> FormObjectBase\n\nclass IFormObject {\n    RowObject CurrentRow\n    string FormId\n    bool MultipleIteration\n    List~RowObject~ OtherRows\n}\n<<interface>> IFormObject\n\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n}\n\nclass IEquatable~FormObjectBase~\n<<interface>> IEquatable~FormObjectBase~\n\nFormObjectBase "1" --o "1" RowObject : CurrentRow\nFormObjectBase "1" --o "*" RowObject : OtherRows\n\nFormObject --|> FormObjectBase : inherits\nFormObjectBase --|> IEquatable~FormObjectBase~ : inherits\nFormObjectBase --|> IFormObject : inherits\n\nclick RowObject href "./rowobject" "Learn more about the RowObject"'}))}u.isMDXComponent=!0}}]);