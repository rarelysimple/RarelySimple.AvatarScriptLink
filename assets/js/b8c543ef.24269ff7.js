"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[264],{3905:(t,e,r)=>{r.d(e,{Zo:()=>p,kt:()=>u});var a=r(7294);function n(t,e,r){return e in t?Object.defineProperty(t,e,{value:r,enumerable:!0,configurable:!0,writable:!0}):t[e]=r,t}function i(t,e){var r=Object.keys(t);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(t);e&&(a=a.filter((function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable}))),r.push.apply(r,a)}return r}function l(t){for(var e=1;e<arguments.length;e++){var r=null!=arguments[e]?arguments[e]:{};e%2?i(Object(r),!0).forEach((function(e){n(t,e,r[e])})):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(r)):i(Object(r)).forEach((function(e){Object.defineProperty(t,e,Object.getOwnPropertyDescriptor(r,e))}))}return t}function o(t,e){if(null==t)return{};var r,a,n=function(t,e){if(null==t)return{};var r,a,n={},i=Object.keys(t);for(a=0;a<i.length;a++)r=i[a],e.indexOf(r)>=0||(n[r]=t[r]);return n}(t,e);if(Object.getOwnPropertySymbols){var i=Object.getOwnPropertySymbols(t);for(a=0;a<i.length;a++)r=i[a],e.indexOf(r)>=0||Object.prototype.propertyIsEnumerable.call(t,r)&&(n[r]=t[r])}return n}var d=a.createContext({}),s=function(t){var e=a.useContext(d),r=e;return t&&(r="function"==typeof t?t(e):l(l({},e),t)),r},p=function(t){var e=s(t.components);return a.createElement(d.Provider,{value:e},t.children)},m="mdxType",c={inlineCode:"code",wrapper:function(t){var e=t.children;return a.createElement(a.Fragment,{},e)}},f=a.forwardRef((function(t,e){var r=t.components,n=t.mdxType,i=t.originalType,d=t.parentName,p=o(t,["components","mdxType","originalType","parentName"]),m=s(r),f=n,u=m["".concat(d,".").concat(f)]||m[f]||c[f]||i;return r?a.createElement(u,l(l({ref:e},p),{},{components:r})):a.createElement(u,l({ref:e},p))}));function u(t,e){var r=arguments,n=e&&e.mdxType;if("string"==typeof t||n){var i=r.length,l=new Array(i);l[0]=f;var o={};for(var d in e)hasOwnProperty.call(e,d)&&(o[d]=e[d]);o.originalType=t,o[m]="string"==typeof t?t:n,l[1]=o;for(var s=2;s<i;s++)l[s]=r[s];return a.createElement.apply(null,l)}return a.createElement.apply(null,r)}f.displayName="MDXCreateElement"},7082:(t,e,r)=>{r.r(e),r.d(e,{assets:()=>R,contentTitle:()=>F,default:()=>M,frontMatter:()=>T,metadata:()=>I,toc:()=>E});var a=r(7462),n=r(7294),i=r(3905),l=r(6010),o=r(2466),d=r(6550),s=r(1980),p=r(7392),m=r(12);function c(t){return function(t){return n.Children.map(t,(t=>{if((0,n.isValidElement)(t)&&"value"in t.props)return t;throw new Error(`Docusaurus error: Bad <Tabs> child <${"string"==typeof t.type?t.type:t.type.name}>: all children of the <Tabs> component should be <TabItem>, and every <TabItem> should have a unique "value" prop.`)}))}(t).map((t=>{let{props:{value:e,label:r,attributes:a,default:n}}=t;return{value:e,label:r,attributes:a,default:n}}))}function f(t){const{values:e,children:r}=t;return(0,n.useMemo)((()=>{const t=e??c(r);return function(t){const e=(0,p.l)(t,((t,e)=>t.value===e.value));if(e.length>0)throw new Error(`Docusaurus error: Duplicate values "${e.map((t=>t.value)).join(", ")}" found in <Tabs>. Every value needs to be unique.`)}(t),t}),[e,r])}function u(t){let{value:e,tabValues:r}=t;return r.some((t=>t.value===e))}function b(t){let{queryString:e=!1,groupId:r}=t;const a=(0,d.k6)(),i=function(t){let{queryString:e=!1,groupId:r}=t;if("string"==typeof e)return e;if(!1===e)return null;if(!0===e&&!r)throw new Error('Docusaurus error: The <Tabs> component groupId prop is required if queryString=true, because this value is used as the search param name. You can also provide an explicit value such as queryString="my-search-param".');return r??null}({queryString:e,groupId:r});return[(0,s._X)(i),(0,n.useCallback)((t=>{if(!i)return;const e=new URLSearchParams(a.location.search);e.set(i,t),a.replace({...a.location,search:e.toString()})}),[i,a])]}function k(t){const{defaultValue:e,queryString:r=!1,groupId:a}=t,i=f(t),[l,o]=(0,n.useState)((()=>function(t){let{defaultValue:e,tabValues:r}=t;if(0===r.length)throw new Error("Docusaurus error: the <Tabs> component requires at least one <TabItem> children component");if(e){if(!u({value:e,tabValues:r}))throw new Error(`Docusaurus error: The <Tabs> has a defaultValue "${e}" but none of its children has the corresponding value. Available values are: ${r.map((t=>t.value)).join(", ")}. If you intend to show no default tab, use defaultValue={null} instead.`);return e}const a=r.find((t=>t.default))??r[0];if(!a)throw new Error("Unexpected error: 0 tabValues");return a.value}({defaultValue:e,tabValues:i}))),[d,s]=b({queryString:r,groupId:a}),[p,c]=function(t){let{groupId:e}=t;const r=function(t){return t?`docusaurus.tab.${t}`:null}(e),[a,i]=(0,m.Nk)(r);return[a,(0,n.useCallback)((t=>{r&&i.set(t)}),[r,i])]}({groupId:a}),k=(()=>{const t=d??p;return u({value:t,tabValues:i})?t:null})();(0,n.useEffect)((()=>{k&&o(k)}),[k]);return{selectedValue:l,selectValue:(0,n.useCallback)((t=>{if(!u({value:t,tabValues:i}))throw new Error(`Can't select invalid tab value=${t}`);o(t),s(t),c(t)}),[s,c,i]),tabValues:i}}var g=r(2389);const h="tabList__CuJ",N="tabItem_LNqP";function y(t){let{className:e,block:r,selectedValue:i,selectValue:d,tabValues:s}=t;const p=[],{blockElementScrollPositionUntilNextRender:m}=(0,o.o5)(),c=t=>{const e=t.currentTarget,r=p.indexOf(e),a=s[r].value;a!==i&&(m(e),d(a))},f=t=>{let e=null;switch(t.key){case"Enter":c(t);break;case"ArrowRight":{const r=p.indexOf(t.currentTarget)+1;e=p[r]??p[0];break}case"ArrowLeft":{const r=p.indexOf(t.currentTarget)-1;e=p[r]??p[p.length-1];break}}e?.focus()};return n.createElement("ul",{role:"tablist","aria-orientation":"horizontal",className:(0,l.Z)("tabs",{"tabs--block":r},e)},s.map((t=>{let{value:e,label:r,attributes:o}=t;return n.createElement("li",(0,a.Z)({role:"tab",tabIndex:i===e?0:-1,"aria-selected":i===e,key:e,ref:t=>p.push(t),onKeyDown:f,onClick:c},o,{className:(0,l.Z)("tabs__item",N,o?.className,{"tabs__item--active":i===e})}),r??e)})))}function O(t){let{lazy:e,children:r,selectedValue:a}=t;if(e){const t=r.find((t=>t.props.value===a));return t?(0,n.cloneElement)(t,{className:"margin-top--md"}):null}return n.createElement("div",{className:"margin-top--md"},r.map(((t,e)=>(0,n.cloneElement)(t,{key:e,hidden:t.props.value!==a}))))}function j(t){const e=k(t);return n.createElement("div",{className:(0,l.Z)("tabs-container",h)},n.createElement(y,(0,a.Z)({},t,e)),n.createElement(O,(0,a.Z)({},t,e)))}function v(t){const e=(0,g.Z)();return n.createElement(j,(0,a.Z)({key:String(e)},t))}const S="tabItem_Ymn6";function w(t){let{children:e,hidden:r,className:a}=t;return n.createElement("div",{role:"tabpanel",className:(0,l.Z)(S,a),hidden:r},e)}const T={title:"OptionObject2015",sidebar_position:1},F="OptionObject2015",I={unversionedId:"dotnet/data-model/optionobject2015",id:"dotnet/data-model/optionobject2015",title:"OptionObject2015",description:"The OptionObject2015 holds all of the content of and metadata describing the calling myAvatar form.",source:"@site/docs/dotnet/data-model/optionobject2015.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/optionobject2015",permalink:"/docs/dotnet/data-model/optionobject2015",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/optionobject2015.mdx",tags:[],version:"current",sidebarPosition:1,frontMatter:{title:"OptionObject2015",sidebar_position:1},sidebar:"dotnetSidebar",previous:{title:"Data Model",permalink:"/docs/dotnet/data-model/"},next:{title:"FormObject",permalink:"/docs/dotnet/data-model/formobject"}},R={},E=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2}],C={toc:E};function M(t){let{components:e,...r}=t;return(0,i.kt)("wrapper",(0,a.Z)({},C,r,{components:e,mdxType:"MDXLayout"}),(0,i.kt)("h1",{id:"optionobject2015"},"OptionObject2015"),(0,i.kt)("p",null,"The OptionObject2015 holds all of the content of and metadata describing the calling myAvatar form."),(0,i.kt)("p",null,"Earlier versions of this object are still supported and available for use in your projects."),(0,i.kt)("ul",null,(0,i.kt)("li",{parentName:"ul"},(0,i.kt)("a",{parentName:"li",href:"../optionobject2"},"OptionObject2")),(0,i.kt)("li",{parentName:"ul"},(0,i.kt)("a",{parentName:"li",href:"../optionobject"},"OptionObject"))),(0,i.kt)("h2",{id:"properties"},"Properties"),(0,i.kt)("table",null,(0,i.kt)("thead",{parentName:"table"},(0,i.kt)("tr",{parentName:"thead"},(0,i.kt)("th",{parentName:"tr",align:"left"},"Property"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,i.kt)("tbody",{parentName:"table"},(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"EntityID"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The unique Id of the selected entity. I.e., Patient, Staff, or User.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"EpisodeNumber"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The selected Episode Number. Will be null if the form is non-episodic.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ErrorCode"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Informs myAvatar of the outcome of the ScriptLink API call.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ErrorMesg"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Message to display to user with certain error codes.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"Facility"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The Facility Id the user is currently working in.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"Forms"),(0,i.kt)("td",{parentName:"tr",align:"left"},"List of myAvatar form sections including rows and fields. See ",(0,i.kt)("a",{parentName:"td",href:"../formobject"},"FormObject"),".")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"NamespaceName"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The Namespace the user is currently working in.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"OptionId"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The unique Id of the form that sent this request.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"OptionStaffId"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The Staff Id assigned to the logged on user. May be null/empty if not associated with a Practitioner.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"OptionUserId"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The User Id of the logged on user.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ParentNamespace"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The Parent Namespace of the Namespace the user is currently logged into.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ServerName"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The server the request was submitted from.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SystemCode"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The System Code the user is currently working in.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SessionToken"),(0,i.kt)("td",{parentName:"tr",align:"left"},"The SessionToken that can be used to authenticate with Avatar Web Services.")))),(0,i.kt)("h2",{id:"methods"},"Methods"),(0,i.kt)("p",null,"The following methods are available on the OptionObject2015 to assist with common tasks."),(0,i.kt)("table",null,(0,i.kt)("thead",{parentName:"table"},(0,i.kt)("tr",{parentName:"thead"},(0,i.kt)("th",{parentName:"tr",align:"left"},"Method"),(0,i.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,i.kt)("tbody",{parentName:"table"},(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"AddFormObject(",(0,i.kt)("a",{parentName:"td",href:"../formobject"},"FormObject"),")"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,i.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," to the OptionObject2015.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"AddFormObject(string, bool)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Creates a ",(0,i.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," with specified FormId and adds to the OptionObject2015. The second parameter specifies whether the ",(0,i.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," should be flagged as a Multiple Iteration form.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"AddRowObject(string, ",(0,i.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),")"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,i.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," to the ",(0,i.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," with the specified FormId.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"Clone"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Clones the OptionObject2015.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"DeleteRowObject(",(0,i.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),")"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Marks a ",(0,i.kt)("see",{cref:"RowObject"})," for deletion.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"DeleteRowObject(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Marks a ",(0,i.kt)("see",{cref:"RowObject"})," for deletion by specified RowId.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"DisableAllFieldObjects()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets all ",(0,i.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," as disabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"DisableAllFieldObjects(List of string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets all ",(0,i.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," as disabled except for any listed to be excluded.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"Equals(OptionObjectBase)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Used to compare two OptionObject2015 to determine if they are equal. Returns bool.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"Equals(object)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Used to compare OptionObject2015 to an object to determine if they are equal. Returns bool.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"GetCurrentRowId(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns the CurrentRow RowId of the form matching the FormId.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns the first value of the field matching the Field Number.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string, string, string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns the value of the ",(0,i.kt)("see",{cref:"FieldObject"})," matching the Field Number on the specified ",(0,i.kt)("a",{parentName:"td",href:"../formobject"},"FormObject")," and ",(0,i.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),".")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"GetFieldValues(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns the values of the field matching the Field Number.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"GetHashCode()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Overrides the GetHashCode method for a OptionObjectBase.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"GetMultipleIterationStatus(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns the Multiple Iteration Status of the form matching the FormId.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"GetParentRowId(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns the CurrentRow ParentRowId of the form matching the FormId.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"IsFieldEnabled(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is enabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"IsFieldLocked(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is locked.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"IsFieldModified(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is modified.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"IsFieldPresent(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is present.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"IsFieldRequired(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified field is required.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"IsFormPresent(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified form is present.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"IsRowMarkedForDeletion(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified ",(0,i.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," is marked for deletion.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"IsRowPresent(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns whether the specified row is present")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetDisabledField(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the specified field as disabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetDisabledFields(List of string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the specified fields as disabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetEnabledField(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the specified field as enabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetEnabledFields(List of string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the specified fields as enabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a ",(0,i.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the OptionObject2015 on the first form's CurrentRow.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string, string, string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a ",(0,i.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the OptionObject2015.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetLockedField(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the specified field as locked.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetLockedFields(List of string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the specified fields as disabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetOptionalField(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Set the specified field as not required and enables if disabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetOptionalFields(List of string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Set the specified fields as not required and enables if disabled.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetRequiredField(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the specified field as required.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetRequiredFields(List of string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Sets the specified fields as required.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedField(string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Set the specified field as unlocked.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedFields(List of string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Set the specified fields as unlocked.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns a string with all of the contents of the OptionObject2015 formatted in HTML.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString(bool)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns a string with all of the contents of the OptionObject2015 formatted in HTML. Passing true will include HTML header tags.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToJson()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns a string with all of the contents of the OptionObject2015 formatted as JSON.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToOptionObject()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Transforms the OptionObject2015 to an OptionObject.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToOptionObject2()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Transforms the OptionObject2015 as an OptionObject2.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToOptionObject2015()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Creates a clone of the OptionObject2015.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToReturnOptionObject()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Creates an OptionObject2015 with the minimum information required to return.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToReturnOptionObject(int, string)"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Creates an OptionObject2015 with the minimum information required to return plus the provided Error Code and Message.")),(0,i.kt)("tr",{parentName:"tbody"},(0,i.kt)("td",{parentName:"tr",align:"left"},"ToXml()"),(0,i.kt)("td",{parentName:"tr",align:"left"},"Returns a string with all of the contents of the OptionObject2015 formatted as XML.")))),(0,i.kt)("h2",{id:"examples"},"Examples"),(0,i.kt)("p",null,"The following code shows how to use OptionObject2015 to construct a web service compatible with myAvatar."),(0,i.kt)(v,{groupId:"syntax",mdxType:"Tabs"},(0,i.kt)(w,{value:"cs",label:"C#",mdxType:"TabItem"},(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-cs",metastring:'title="MyScriptLinkDemoService.asmx"',title:'"MyScriptLinkDemoService.asmx"'},'using RarelySimple.AvatarScriptLink.Objects;\nusing System.Web.Services;\n\nnamespace ScriptLinkDemo.Web.Api\n{\n    /// <summary>\n    /// Summary description for MyScriptLinkDemoService\n    /// </summary>\n    [WebService(Namespace = "http://tempuri.org/")]\n    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]\n    [System.ComponentModel.ToolboxItem(false)]\n    public class MyScriptLinkDemoService : System.Web.Services.WebService\n    {\n        [WebMethod]\n        public string GetVersion()\n        {\n            return "v.0.0.1";\n        }\n\n        [WebMethod]\n        public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string parameters)\n        {\n            return optionObject2015.ToReturnOptionObject(ErrorCode.Alert, "Hello, World!");\n        }\n    }\n}\n'))),(0,i.kt)(w,{value:"vb",label:"Visual Basic",mdxType:"TabItem"},(0,i.kt)("pre",null,(0,i.kt)("code",{parentName:"pre",className:"language-vb",metastring:'title="MyScriptLinkDemoService.asmx"',title:'"MyScriptLinkDemoService.asmx"'},'Imports System.ComponentModel\nImports System.Web.Services\nImports RarelySimple.AvatarScriptLink.Objects\n\n<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _\n<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _\n<ToolboxItem(False)> _\nPublic Class MyScriptLinkDemoService\n    Inherits System.Web.Services.WebService\n\n    <WebMethod()>\n    Public Function GetVersion() As String\n        Return "v.0.0.1"\n    End Function\n\n    <WebMethod()>\n    Public Function RunScript(ByVal optionObject2015 As OptionObject2015, ByVal parameters As String) As OptionObject2015\n        Return optionObject2015.ToReturnOptionObject(ErrorCode.Alert, "Hello, World!")\n    End Function\n\nEnd Class\n')))))}M.isMDXComponent=!0}}]);