"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[243],{3905:(t,e,a)=>{a.d(e,{Zo:()=>b,kt:()=>f});var r=a(7294);function n(t,e,a){return e in t?Object.defineProperty(t,e,{value:a,enumerable:!0,configurable:!0,writable:!0}):t[e]=a,t}function l(t,e){var a=Object.keys(t);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(t);e&&(r=r.filter((function(e){return Object.getOwnPropertyDescriptor(t,e).enumerable}))),a.push.apply(a,r)}return a}function i(t){for(var e=1;e<arguments.length;e++){var a=null!=arguments[e]?arguments[e]:{};e%2?l(Object(a),!0).forEach((function(e){n(t,e,a[e])})):Object.getOwnPropertyDescriptors?Object.defineProperties(t,Object.getOwnPropertyDescriptors(a)):l(Object(a)).forEach((function(e){Object.defineProperty(t,e,Object.getOwnPropertyDescriptor(a,e))}))}return t}function d(t,e){if(null==t)return{};var a,r,n=function(t,e){if(null==t)return{};var a,r,n={},l=Object.keys(t);for(r=0;r<l.length;r++)a=l[r],e.indexOf(a)>=0||(n[a]=t[a]);return n}(t,e);if(Object.getOwnPropertySymbols){var l=Object.getOwnPropertySymbols(t);for(r=0;r<l.length;r++)a=l[r],e.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(t,a)&&(n[a]=t[a])}return n}var o=r.createContext({}),m=function(t){var e=r.useContext(o),a=e;return t&&(a="function"==typeof t?t(e):i(i({},e),t)),a},b=function(t){var e=m(t.components);return r.createElement(o.Provider,{value:e},t.children)},s="mdxType",c={inlineCode:"code",wrapper:function(t){var e=t.children;return r.createElement(r.Fragment,{},e)}},p=r.forwardRef((function(t,e){var a=t.components,n=t.mdxType,l=t.originalType,o=t.parentName,b=d(t,["components","mdxType","originalType","parentName"]),s=m(a),p=n,f=s["".concat(o,".").concat(p)]||s[p]||c[p]||l;return a?r.createElement(f,i(i({ref:e},b),{},{components:a})):r.createElement(f,i({ref:e},b))}));function f(t,e){var a=arguments,n=e&&e.mdxType;if("string"==typeof t||n){var l=a.length,i=new Array(l);i[0]=p;var d={};for(var o in e)hasOwnProperty.call(e,o)&&(d[o]=e[o]);d.originalType=t,d[s]="string"==typeof t?t:n,i[1]=d;for(var m=2;m<l;m++)i[m]=a[m];return r.createElement.apply(null,i)}return r.createElement.apply(null,a)}p.displayName="MDXCreateElement"},7422:(t,e,a)=>{a.r(e),a.d(e,{assets:()=>o,contentTitle:()=>i,default:()=>s,frontMatter:()=>l,metadata:()=>d,toc:()=>m});var r=a(7462),n=(a(7294),a(3905));const l={title:"FormObject",sidebar_position:4},i="FormObject",d={unversionedId:"dotnet/data-model/formobject",id:"dotnet/data-model/formobject",title:"FormObject",description:"The FormObject represents a section of a myAvatar Form.",source:"@site/docs/dotnet/data-model/formobject.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/formobject",permalink:"/docs/dotnet/data-model/formobject",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/formobject.mdx",tags:[],version:"current",sidebarPosition:4,frontMatter:{title:"FormObject",sidebar_position:4},sidebar:"dotnetSidebar",previous:{title:"OptionObject2015",permalink:"/docs/dotnet/data-model/optionobject2015"},next:{title:"RowObject",permalink:"/docs/dotnet/data-model/rowobject"}},o={},m=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2}],b={toc:m};function s(t){let{components:e,...a}=t;return(0,n.kt)("wrapper",(0,r.Z)({},b,a,{components:e,mdxType:"MDXLayout"}),(0,n.kt)("h1",{id:"formobject"},"FormObject"),(0,n.kt)("p",null,"The FormObject represents a section of a myAvatar Form."),(0,n.kt)("h2",{id:"properties"},"Properties"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Property"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"CurrentRow"),(0,n.kt)("td",{parentName:"tr",align:"left"},"The contents of this myAvatar Form section. The selected row on multiple iteration tables.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"FormId"),(0,n.kt)("td",{parentName:"tr",align:"left"},"The unique Id assigned to this section (FormObject).")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"MultipleIteration"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Indicates whether this section uses a multiple iteration table. Note: this is not the same as TDE objects.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"OtherRows"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Contains the contents of unselected rows in the multiple iteration table.")))),(0,n.kt)("h2",{id:"methods"},"Methods"),(0,n.kt)("table",null,(0,n.kt)("thead",{parentName:"table"},(0,n.kt)("tr",{parentName:"thead"},(0,n.kt)("th",{parentName:"tr",align:"left"},"Method"),(0,n.kt)("th",{parentName:"tr",align:"left"},"Description"))),(0,n.kt)("tbody",{parentName:"table"},(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"AddRowObject(",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," to a the FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"AddRowObject(string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," to a FormObject using supplied RowId and ParentRowId.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"AddRowObject(string, string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Adds a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," to a FormObject using supplied RowId and ParentRowId and setting the RowAction.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Clone()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Creates a copy of the FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"DeleteRowObject(",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject"),")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Removes a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," from a FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"DeleteRowObject(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Removes a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," from a FormObject by RowId.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Equals(FormObjectBase)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Used to compare two FormObject to determine if they are equal. Returns bool.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"Equals(object)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Used to compare FormObject to an object to determine if they are equal. Returns bool.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetCurrentRowId()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the ID of the ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," in the CurrentRow of a FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetHashCode()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Overrides the GetHashCode method for a FormObjectBase.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldValue of a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetFieldValue(string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FieldValue of a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject by RowId and FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetFieldValues(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns a List","<","string",">"," of FieldValues in a FormObject by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetNextAvailableRowId()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the next available RowId for the FormObject.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"GetParentRowId()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the ParentRowId of the FormObject.CurrentRow.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldEnabled(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is enabled by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldLocked(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is locked by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldModified(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is modified by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldPresent(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is present by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsFieldRequired(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject is required by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsRowMarkedForDeletion(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," in a FormObject is marked for deletion by RowId.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"IsRowPresent(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns whether a ",(0,n.kt)("a",{parentName:"td",href:"../rowobject"},"RowObject")," in a FormObject is present by RowId.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetDisabledField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as disabled by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetDisabledFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as disabled by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetDisabledFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as disabled by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as disabled.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetEnabledField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as enabled by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetEnabledFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetEnabledFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as disabled.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue of a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the FormObject.CurrentRow by FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetFieldValue(string, string, string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the FieldValue a ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in the FormObject by RowId and FieldNumber.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetLockedField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Set the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as locked by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as locked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetLockedFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as locked by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetLockedFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as locked by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as locked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetOptionalField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as enabled and not required by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as enabled and not required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetOptionalFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled and not required by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetOptionalFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled and not required by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as enabled and not required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetRequiredField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as enabled and required by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as enabled and required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetRequiredFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled and required by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetRequiredFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as enabled and required by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as enabled and required.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedField(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," in a FormObject as unlocked by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as unlocked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedFields(List","<","string",">",")"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as unlocked by FieldNumbers.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"SetUnlockedFields(string)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Sets the ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObjects")," in a FormObject as unlocked by FieldNumber. If ",(0,n.kt)("a",{parentName:"td",href:"../fieldobject"},"FieldObject")," is in a multiple iteration FormObject then all occurances will be set as unlocked.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FormObject as an HTML string. The ",(0,n.kt)("inlineCode",{parentName:"td"},"<html>"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"<head>"),", and ",(0,n.kt)("inlineCode",{parentName:"td"},"<body>")," tags can be included if desired.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToHtmlString(bool)"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FormObject as an HTML string. The ",(0,n.kt)("inlineCode",{parentName:"td"},"<html>"),", ",(0,n.kt)("inlineCode",{parentName:"td"},"<head>"),", and ",(0,n.kt)("inlineCode",{parentName:"td"},"<body>")," tags can be included if desired.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToJson()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FormObject as a JSON string.")),(0,n.kt)("tr",{parentName:"tbody"},(0,n.kt)("td",{parentName:"tr",align:"left"},"ToXml()"),(0,n.kt)("td",{parentName:"tr",align:"left"},"Returns the FormObject as an XML string.")))),(0,n.kt)("h2",{id:"examples"},"Examples"),(0,n.kt)("p",null,"Most implementations would not require working with the FormObject directly, however here is an example that uses the FormObject to create an ",(0,n.kt)("a",{parentName:"p",href:"../optionobject2015"},"OptionObject2015")," for Unit Testing."))}s.isMDXComponent=!0}}]);