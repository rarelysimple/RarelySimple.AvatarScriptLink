"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[264],{3905:(t,e,n)=>{n.d(e,{Zo:()=>p,kt:()=>g});var r=n(7294);function a(t,e,n){return e in t?Object.defineProperty(t,e,{value:n,enumerable:!0,configurable:!0,writable:!0}):t[e]=n,t}function i(t,e){var n=Object.keys(t);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(t);e&&(r=r.filter((function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable}))),n.push.apply(n,r)}return n}function o(t){for(var e=1;e<arguments.length;e++){var n=null!=arguments[e]?arguments[e]:{};e%2?i(Object(n),!0).forEach((function(e){a(t,e,n[e])})):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(n)):i(Object(n)).forEach((function(e){Object.defineProperty(t,e,Object.getOwnPropertyDescriptor(n,e))}))}return t}function l(t,e){if(null==t)return{};var n,r,a=function(t,e){if(null==t)return{};var n,r,a={},i=Object.keys(t);for(r=0;r<i.length;r++)n=i[r],e.indexOf(n)>=0||(a[n]=t[n]);return a}(t,e);if(Object.getOwnPropertySymbols){var i=Object.getOwnPropertySymbols(t);for(r=0;r<i.length;r++)n=i[r],e.indexOf(n)>=0||Object.prototype.propertyIsEnumerable.call(t,n)&&(a[n]=t[n])}return a}var s=r.createContext({}),d=function(t){var e=r.useContext(s),n=e;return t&&(n="function"==typeof t?t(e):o(o({},e),t)),n},p=function(t){var e=d(t.components);return r.createElement(s.Provider,{value:e},t.children)},c="mdxType",m={inlineCode:"code",wrapper:function(t){var e=t.children;return r.createElement(r.Fragment,{},e)}},b=r.forwardRef((function(t,e){var n=t.components,a=t.mdxType,i=t.originalType,s=t.parentName,p=l(t,["components","mdxType","originalType","parentName"]),c=d(n),b=a,g=c["".concat(s,".").concat(b)]||c[b]||m[b]||i;return n?r.createElement(g,o(o({ref:e},p),{},{components:n})):r.createElement(g,o({ref:e},p))}));function g(t,e){var n=arguments,a=e&&e.mdxType;if("string"==typeof t||a){var i=n.length,o=new Array(i);o[0]=b;var l={};for(var s in e)hasOwnProperty.call(e,s)&&(l[s]=e[s]);l.originalType=t,l[c]="string"==typeof t?t:a,o[1]=l;for(var d=2;d<i;d++)o[d]=n[d];return r.createElement.apply(null,o)}return r.createElement.apply(null,n)}b.displayName="MDXCreateElement"},5162:(t,e,n)=>{n.d(e,{Z:()=>o});var r=n(7294),a=n(6010);const i="tabItem_Ymn6";function o(t){let{children:e,hidden:n,className:o}=t;return r.createElement("div",{role:"tabpanel",className:(0,a.Z)(i,o),hidden:n},e)}},4866:(t,e,n)=>{n.d(e,{Z:()=>y});var r=n(7462),a=n(7294),i=n(6010),o=n(2466),l=n(6550),s=n(1980),d=n(7392),p=n(12);function c(t){return function(t){return a.Children.map(t,(t=>{if((0,a.isValidElement)(t)&&"value"in t.props)return t;throw new Error(`Docusaurus error: Bad <Tabs> child <${"string"==typeof t.type?t.type:t.type.name}>: all children of the <Tabs> component should be <TabItem>, and every <TabItem> should have a unique "value" prop.`)}))}(t).map((t=>{let{props:{value:e,label:n,attributes:r,default:a}}=t;return{value:e,label:n,attributes:r,default:a}}))}function m(t){const{values:e,children:n}=t;return(0,a.useMemo)((()=>{const t=e??c(n);return function(t){const e=(0,d.l)(t,((t,e)=>t.value===e.value));if(e.length>0)throw new Error(`Docusaurus error: Duplicate values "${e.map((t=>t.value)).join(", ")}" found in <Tabs>. Every value needs to be unique.`)}(t),t}),[e,n])}function b(t){let{value:e,tabValues:n}=t;return n.some((t=>t.value===e))}function g(t){let{queryString:e=!1,groupId:n}=t;const r=(0,l.k6)(),i=function(t){let{queryString:e=!1,groupId:n}=t;if("string"==typeof e)return e;if(!1===e)return null;if(!0===e&&!n)throw new Error('Docusaurus error: The <Tabs> component groupId prop is required if queryString=true, because this value is used as the search param name. You can also provide an explicit value such as queryString="my-search-param".');return n??null}({queryString:e,groupId:n});return[(0,s._X)(i),(0,a.useCallback)((t=>{if(!i)return;const e=new URLSearchParams(r.location.search);e.set(i,t),r.replace({...r.location,search:e.toString()})}),[i,r])]}function u(t){const{defaultValue:e,queryString:n=!1,groupId:r}=t,i=m(t),[o,l]=(0,a.useState)((()=>function(t){let{defaultValue:e,tabValues:n}=t;if(0===n.length)throw new Error("Docusaurus error: the <Tabs> component requires at least one <TabItem> children component");if(e){if(!b({value:e,tabValues:n}))throw new Error(`Docusaurus error: The <Tabs> has a defaultValue "${e}" but none of its children has the corresponding value. Available values are: ${n.map((t=>t.value)).join(", ")}. If you intend to show no default tab, use defaultValue={null} instead.`);return e}const r=n.find((t=>t.default))??n[0];if(!r)throw new Error("Unexpected error: 0 tabValues");return r.value}({defaultValue:e,tabValues:i}))),[s,d]=g({queryString:n,groupId:r}),[c,u]=function(t){let{groupId:e}=t;const n=function(t){return t?`docusaurus.tab.${t}`:null}(e),[r,i]=(0,p.Nk)(n);return[r,(0,a.useCallback)((t=>{n&&i.set(t)}),[n,i])]}({groupId:r}),f=(()=>{const t=s??c;return b({value:t,tabValues:i})?t:null})();(0,a.useEffect)((()=>{f&&l(f)}),[f]);return{selectedValue:o,selectValue:(0,a.useCallback)((t=>{if(!b({value:t,tabValues:i}))throw new Error(`Can't select invalid tab value=${t}`);l(t),d(t),u(t)}),[d,u,i]),tabValues:i}}var f=n(2389);const O="tabList__CuJ",k="tabItem_LNqP";function h(t){let{className:e,block:n,selectedValue:l,selectValue:s,tabValues:d}=t;const p=[],{blockElementScrollPositionUntilNextRender:c}=(0,o.o5)(),m=t=>{const e=t.currentTarget,n=p.indexOf(e),r=d[n].value;r!==l&&(c(e),s(r))},b=t=>{let e=null;switch(t.key){case"Enter":m(t);break;case"ArrowRight":{const n=p.indexOf(t.currentTarget)+1;e=p[n]??p[0];break}case"ArrowLeft":{const n=p.indexOf(t.currentTarget)-1;e=p[n]??p[p.length-1];break}}e?.focus()};return a.createElement("ul",{role:"tablist","aria-orientation":"horizontal",className:(0,i.Z)("tabs",{"tabs--block":n},e)},d.map((t=>{let{value:e,label:n,attributes:o}=t;return a.createElement("li",(0,r.Z)({role:"tab",tabIndex:l===e?0:-1,"aria-selected":l===e,key:e,ref:t=>p.push(t),onKeyDown:b,onClick:m},o,{className:(0,i.Z)("tabs__item",k,o?.className,{"tabs__item--active":l===e})}),n??e)})))}function N(t){let{lazy:e,children:n,selectedValue:r}=t;if(e){const t=n.find((t=>t.props.value===r));return t?(0,a.cloneElement)(t,{className:"margin-top--md"}):null}return a.createElement("div",{className:"margin-top--md"},n.map(((t,e)=>(0,a.cloneElement)(t,{key:e,hidden:t.props.value!==r}))))}function j(t){const e=u(t);return a.createElement("div",{className:(0,i.Z)("tabs-container",O)},a.createElement(h,(0,r.Z)({},t,e)),a.createElement(N,(0,r.Z)({},t,e)))}function y(t){const e=(0,f.Z)();return a.createElement(j,(0,r.Z)({key:String(e)},t))}},5249:(t,e,n)=>{n.r(e),n.d(e,{assets:()=>p,contentTitle:()=>s,default:()=>b,frontMatter:()=>l,metadata:()=>d,toc:()=>c});var r=n(7462),a=(n(7294),n(3905)),i=n(4866),o=n(5162);const l={title:"OptionObject2015",image:"./OptionObject2015.png",sidebar_position:1},s="OptionObject2015",d={unversionedId:"dotnet/data-model/optionobject2015",id:"dotnet/data-model/optionobject2015",title:"OptionObject2015",description:"The OptionObject2015 holds all of the content of and metadata describing the calling myAvatar form.",source:"@site/docs/dotnet/data-model/optionobject2015.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/optionobject2015",permalink:"/docs/dotnet/data-model/optionobject2015",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/optionobject2015.mdx",tags:[],version:"current",sidebarPosition:1,frontMatter:{title:"OptionObject2015",image:"./OptionObject2015.png",sidebar_position:1},sidebar:"dotnetSidebar",previous:{title:"Data Model",permalink:"/docs/dotnet/data-model/"},next:{title:"FormObject",permalink:"/docs/dotnet/data-model/formobject"}},p={image:n(1660).Z},c=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2},{value:"Detailed Class Diagram",id:"detailed-class-diagram",level:2}],m={toc:c};function b(t){let{components:e,...n}=t;return(0,a.kt)("wrapper",(0,r.Z)({},m,n,{components:e,mdxType:"MDXLayout"}),(0,a.kt)("h1",{id:"optionobject2015"},"OptionObject2015"),(0,a.kt)("p",null,"The OptionObject2015 holds all of the content of and metadata describing the calling myAvatar form.\nAvatarScriptLink.NET adds several utility methods to assist with handlings these objects."),(0,a.kt)("admonition",{title:"Legacy Support",type:"note"},(0,a.kt)("p",{parentName:"admonition"},"Earlier versions of this object are still supported and available for use in your projects."),(0,a.kt)("ul",{parentName:"admonition"},(0,a.kt)("li",{parentName:"ul"},(0,a.kt)("a",{parentName:"li",href:"../optionobject2"},"OptionObject2")),(0,a.kt)("li",{parentName:"ul"},(0,a.kt)("a",{parentName:"li",href:"../optionobject"},"OptionObject")))),(0,a.kt)("mermaid",{value:'classDiagram\ndirection LR\nclass OptionObject2015 {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n    +AddFormObject(FormObject)\n    +AddFormObject(string, bool)\n    +AddRowObject(string, RowObject)\n    +Clone() OptionObject2015\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +DisableAllFieldObjects()\n    +DisableAllFieldObjects(List~string~)\n    +Equals(OptionObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId(string) strings\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetMultipleIterationStatus(string) bool\n    +GetParentRowId(string) string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsFormPresent(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(List~string~)\n    +SetEnabledField(string)\n    +SetEnabledFields(List~string~)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(List~string~)\n    +SetOptionalField(string)\n    +SetOptionalFields(List~string~)\n    +SetRequiredField(string)\n    +SetRequiredFields(List~string~)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(List~string~)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToOptionObject() OptionObject\n    +ToOptionObject2() OptionObject2\n    +ToOptionObject2015() OptionObject2015\n    +ToReturnOptionObject() OptionObject2015\n    +ToReturnOptionObject(bool, string) OptionObject2015\n    +ToXml() string\n}\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nOptionObject2015 "1" --o "*" FormObject : Forms\n\nclick FormObject href "./formobject" "Learn more about the FormObject"'}),(0,a.kt)("h2",{id:"properties"},"Properties"),(0,a.kt)("table",null,(0,a.kt)("thead",{parentName:"table"},(0,a.kt)("tr",{parentName:"thead"},(0,a.kt)("th",{parentName:"tr",align:"left"},"Property"),(0,a.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,a.kt)("tbody",{parentName:"table"},(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"EntityID"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The unique Id of the selected entity. I.e., Patient, Staff, or User.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"EpisodeNumber"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The selected Episode Number. Will be null if the form is non-episodic.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ErrorCode"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Informs myAvatar of the outcome of the ScriptLink API call.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ErrorMesg"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Message to display to user with certain error codes.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Facility"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The Facility Id the user is currently working in.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Forms"),(0,a.kt)("td",{parentName:"tr",align:"left"},"List of myAvatar form sections including rows and fields. See ",(0,a.kt)("a",{parentName:"td",href:"../formobject"},"FormObject"),".")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"NamespaceName"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The Namespace the user is currently working in.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"OptionId"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The unique Id of the form that sent this request.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"OptionStaffId"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The Staff Id assigned to the logged on user. May be null/empty if not associated with a Practitioner.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"OptionUserId"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The User Id of the logged on user.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ParentNamespace"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The Parent Namespace of the Namespace the user is currently logged into.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ServerName"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The server the request was submitted from.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SystemCode"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The System Code the user is currently working in.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SessionToken"),(0,a.kt)("td",{parentName:"tr",align:"left"},"The SessionToken that can be used to authenticate with Avatar Web Services.")))),(0,a.kt)("h2",{id:"methods"},"Methods"),(0,a.kt)("p",null,"The following methods are available on the OptionObject2015 to assist with common tasks."),(0,a.kt)("table",null,(0,a.kt)("thead",{parentName:"table"},(0,a.kt)("tr",{parentName:"thead"},(0,a.kt)("th",{parentName:"tr",align:"left"},"Method"),(0,a.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,a.kt)("tbody",{parentName:"table"},(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"AddFormObject(",(0,a.kt)("a",{parentName:"td",href:"../formobject"},"FormObject"),")"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,a.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," to the OptionObject2015.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"AddFormObject(string, bool)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Creates a ",(0,a.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," with specified FormId and adds to the OptionObject2015. The second parameter specifies whether the ",(0,a.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," should be flagged as a Multiple Iteration form.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"AddRowObject(string, ",(0,a.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),")"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,a.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," to the ",(0,a.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," with the specified FormId.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Clone"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Clones the OptionObject2015.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"DeleteRowObject(",(0,a.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),")"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Marks a ",(0,a.kt)("see",{cref:"RowObject"})," for deletion.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"DeleteRowObject(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Marks a ",(0,a.kt)("see",{cref:"RowObject"})," for deletion by specified RowId.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"DisableAllFieldObjects()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets all ",(0,a.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," as disabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"DisableAllFieldObjects(List of string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets all ",(0,a.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," as disabled except for any listed to be excluded.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Equals(OptionObjectBase)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Used to compare two OptionObject2015 to determine if they are equal. Returns bool.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"Equals(object)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Used to compare OptionObject2015 to an object to determine if they are equal. Returns bool.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"GetCurrentRowId(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns the CurrentRow RowId of the form matching the FormId.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns the first value of the field matching the Field Number.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string, string, string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns the value of the ",(0,a.kt)("see",{cref:"FieldObject"})," matching the Field Number on the specified ",(0,a.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," and ",(0,a.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),".")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"GetFieldValues(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns the values of the field matching the Field Number.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"GetHashCode()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Overrides the GetHashCode method for a OptionObjectBase.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"GetMultipleIterationStatus(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns the Multiple Iteration Status of the form matching the FormId.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"GetParentRowId(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns the CurrentRow ParentRowId of the form matching the FormId.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"IsFieldEnabled(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is enabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"IsFieldLocked(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is locked.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"IsFieldModified(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is modified.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"IsFieldPresent(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is present.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"IsFieldRequired(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is required.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"IsFormPresent(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified form is present.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"IsRowMarkedForDeletion(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified ",(0,a.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," is marked for deletion.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"IsRowPresent(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified row is present")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetDisabledField(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the specified field as disabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetDisabledFields(List of string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the specified fields as disabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetEnabledField(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the specified field as enabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetEnabledFields(List of string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the specified fields as enabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a ",(0,a.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the OptionObject2015 on the first form's CurrentRow.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string, string, string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a ",(0,a.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the OptionObject2015.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetLockedField(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the specified field as locked.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetLockedFields(List of string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the specified fields as disabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetOptionalField(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Set the specified field as not required and enables if disabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetOptionalFields(List of string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Set the specified fields as not required and enables if disabled.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetRequiredField(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the specified field as required.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetRequiredFields(List of string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Sets the specified fields as required.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedField(string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Set the specified field as unlocked.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedFields(List of string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Set the specified fields as unlocked.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns a string with all of the contents of the OptionObject2015 formatted in HTML.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString(bool)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns a string with all of the contents of the OptionObject2015 formatted in HTML. Passing true will include HTML header tags.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToJson()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns a string with all of the contents of the OptionObject2015 formatted as JSON.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToOptionObject()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Transforms the OptionObject2015 to an OptionObject.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToOptionObject2()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Transforms the OptionObject2015 as an OptionObject2.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToOptionObject2015()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Creates a clone of the OptionObject2015.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToReturnOptionObject()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Creates an OptionObject2015 with the minimum information required to return.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToReturnOptionObject(int, string)"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Creates an OptionObject2015 with the minimum information required to return plus the provided Error Code and Message.")),(0,a.kt)("tr",{parentName:"tbody"},(0,a.kt)("td",{parentName:"tr",align:"left"},"ToXml()"),(0,a.kt)("td",{parentName:"tr",align:"left"},"Returns a string with all of the contents of the OptionObject2015 formatted as XML.")))),(0,a.kt)("h2",{id:"examples"},"Examples"),(0,a.kt)("p",null,"The following code shows how to use OptionObject2015 to construct a web service compatible with myAvatar."),(0,a.kt)(i.Z,{groupId:"syntax",mdxType:"Tabs"},(0,a.kt)(o.Z,{value:"cs",label:"C#",mdxType:"TabItem"},(0,a.kt)("pre",null,(0,a.kt)("code",{parentName:"pre",className:"language-cs",metastring:'title="MyScriptLinkDemoService.asmx"',title:'"MyScriptLinkDemoService.asmx"'},'using RarelySimple.AvatarScriptLink.Objects;\nusing System.Web.Services;\n\nnamespace ScriptLinkDemo.Web.Api\n{\n    /// <summary>\n    /// Summary description for MyScriptLinkDemoService\n    /// </summary>\n    [WebService(Namespace = "http://tempuri.org/")]\n    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]\n    [System.ComponentModel.ToolboxItem(false)]\n    public class MyScriptLinkDemoService : System.Web.Services.WebService\n    {\n        [WebMethod]\n        public string GetVersion()\n        {\n            return "v.0.0.1";\n        }\n\n        [WebMethod]\n        public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string parameters)\n        {\n            return optionObject2015.ToReturnOptionObject(ErrorCode.Alert, "Hello, World!");\n        }\n    }\n}\n'))),(0,a.kt)(o.Z,{value:"vb",label:"Visual Basic",mdxType:"TabItem"},(0,a.kt)("pre",null,(0,a.kt)("code",{parentName:"pre",className:"language-vb",metastring:'title="MyScriptLinkDemoService.asmx"',title:'"MyScriptLinkDemoService.asmx"'},'Imports System.ComponentModel\nImports System.Web.Services\nImports RarelySimple.AvatarScriptLink.Objects\n\n<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _\n<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _\n<ToolboxItem(False)> _\nPublic Class MyScriptLinkDemoService\n    Inherits System.Web.Services.WebService\n\n    <WebMethod()>\n    Public Function GetVersion() As String\n        Return "v.0.0.1"\n    End Function\n\n    <WebMethod()>\n    Public Function RunScript(ByVal optionObject2015 As OptionObject2015, ByVal parameters As String) As OptionObject2015\n        Return optionObject2015.ToReturnOptionObject(ErrorCode.Alert, "Hello, World!")\n    End Function\n\nEnd Class\n')))),(0,a.kt)("h2",{id:"detailed-class-diagram"},"Detailed Class Diagram"),(0,a.kt)("mermaid",{value:'classDiagram\nclass OptionObject2015 {\n    +Clone() OptionObject2015\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToOptionObject() OptionObject\n    +ToOptionObject2() OptionObject2\n    +ToOptionObject2015() OptionObject2015\n    +ToReturnOptionObject() OptionObject2015\n    +ToReturnOptionObject(bool, string) OptionObject2015\n    +ToXml() string\n}\n\nclass OptionObjectBase {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n    +AddFormObject(FormObject)\n    +AddFormObject(string, bool)\n    +AddRowObject(string, RowObject)\n    +Clone() OptionObjectBase\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +DisableAllFieldObjects()\n    +DisableAllFieldObjects(List~string~)\n    +Equals(OptionObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId(string) strings\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetMultipleIterationStatus(string) bool\n    +GetParentRowId(string) string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsFormPresent(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(List~string~)\n    +SetEnabledField(string)\n    +SetEnabledFields(List~string~)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(List~string~)\n    +SetOptionalField(string)\n    +SetOptionalFields(List~string~)\n    +SetRequiredField(string)\n    +SetRequiredFields(List~string~)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(List~string~)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToOptionObject()* OptionObject\n    +ToOptionObject2()* OptionObject2\n    +ToOptionObject2015()* OptionObject2015\n    +ToReturnOptionObject() OptionObjectBase\n    +ToReturnOptionObject(double, string) OptionObjectBase\n    +ToXml() string\n    -AreBothEmpty(List~FormObject~, List~FormObject~)$ bool\n    -AreBothNull(List~FormObject~, List~FormObject~)$ bool\n    -AreFormsEqual(List~FormObject~, List~FormObject~)$ bool\n}\n<<abstract>> OptionObjectBase\n\nclass IOptionObject2015 {\n    string SessionToken\n}\n<<interface>> IOptionObject2015\n\nclass IOptionObject2 {\n    string NamespaceName\n    string ParentNamespace\n    string ServerName\n}\n<<interface>> IOptionObject2\n\nclass IOptionObject {\n    string EntityID\n    double EpisodeNumber\n    double ErrorCode\n    string ErrorMesg\n    string Facility\n    List~FormObject~ Forms\n    string OptionId\n    string OptionStaffId\n    string OptionUserId\n    string SystemCode\n}\n<<interface>> IOptionObject\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nclass IEquatable~OptionObjectBase~\n<<interface>> IEquatable~OptionObjectBase~\n\nOptionObjectBase "1" --o "*" FormObject : Forms\n\nOptionObject2015 --|> OptionObjectBase : inherits\nOptionObjectBase --|> IEquatable~OptionObjectBase~ : inherits\nOptionObjectBase --|> IOptionObject2015 : inherits\nIOptionObject2015 --|> IOptionObject2 : inherits\nIOptionObject2 --|> IOptionObject : inherits\n\nclick FormObject href "./formobject" "Learn more about the FormObject"'}))}b.isMDXComponent=!0},1660:(t,e,n)=>{n.d(e,{Z:()=>r});const r=n.p+"assets/images/OptionObject2015-6ae774a70652472f1925264d38020b4d.png"}}]);