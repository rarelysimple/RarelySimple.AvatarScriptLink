"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[379],{3905:(e,t,o)=>{o.d(t,{Zo:()=>s,kt:()=>b});var n=o(7294);function r(e,t,o){return t in e?Object.defineProperty(e,t,{value:o,enumerable:!0,configurable:!0,writable:!0}):e[t]=o,e}function a(e,t){var o=Object.keys(e);if(Object.getOwnPropertySymbols){var n=Object.getOwnPropertySymbols(e);t&&(n=n.filter((function(t){return Object.getOwnPropertyDescriptor(e,t).enumerable}))),o.push.apply(o,n)}return o}function i(e){for(var t=1;t<arguments.length;t++){var o=null!=arguments[t]?arguments[t]:{};t%2?a(Object(o),!0).forEach((function(t){r(e,t,o[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(o)):a(Object(o)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(o,t))}))}return e}function d(e,t){if(null==e)return{};var o,n,r=function(e,t){if(null==e)return{};var o,n,r={},a=Object.keys(e);for(n=0;n<a.length;n++)o=a[n],t.indexOf(o)>=0||(r[o]=e[o]);return r}(e,t);if(Object.getOwnPropertySymbols){var a=Object.getOwnPropertySymbols(e);for(n=0;n<a.length;n++)o=a[n],t.indexOf(o)>=0||Object.prototype.propertyIsEnumerable.call(e,o)&&(r[o]=e[o])}return r}var l=n.createContext({}),c=function(e){var t=n.useContext(l),o=t;return e&&(o="function"==typeof e?e(t):i(i({},t),e)),o},s=function(e){var t=c(e.components);return n.createElement(l.Provider,{value:t},e.children)},p="mdxType",m={inlineCode:"code",wrapper:function(e){var t=e.children;return n.createElement(n.Fragment,{},t)}},u=n.forwardRef((function(e,t){var o=e.components,r=e.mdxType,a=e.originalType,l=e.parentName,s=d(e,["components","mdxType","originalType","parentName"]),p=c(o),u=r,b=p["".concat(l,".").concat(u)]||p[u]||m[u]||a;return o?n.createElement(b,i(i({ref:t},s),{},{components:o})):n.createElement(b,i({ref:t},s))}));function b(e,t){var o=arguments,r=t&&t.mdxType;if("string"==typeof e||r){var a=o.length,i=new Array(a);i[0]=u;var d={};for(var l in t)hasOwnProperty.call(t,l)&&(d[l]=t[l]);d.originalType=e,d[p]="string"==typeof e?e:r,i[1]=d;for(var c=2;c<a;c++)i[c]=o[c];return n.createElement.apply(null,i)}return n.createElement.apply(null,o)}u.displayName="MDXCreateElement"},887:(e,t,o)=>{o.r(t),o.d(t,{assets:()=>l,contentTitle:()=>i,default:()=>m,frontMatter:()=>a,metadata:()=>d,toc:()=>c});var n=o(7462),r=(o(7294),o(3905));const a={title:"Adding Rows to Multiple-Iteration Tables",image:"./AddingRowsToMultipleIterationTables.png",sidebar_position:1},i=void 0,d={unversionedId:"dotnet/advanced/adding-rows-to-multiple-iteration-tables",id:"dotnet/advanced/adding-rows-to-multiple-iteration-tables",title:"Adding Rows to Multiple-Iteration Tables",description:"Multiple-iteration tables are a special kind of FormObject that allow for multiple RowObjects.",source:"@site/docs/dotnet/advanced/adding-rows-to-multiple-iteration-tables.md",sourceDirName:"dotnet/advanced",slug:"/dotnet/advanced/adding-rows-to-multiple-iteration-tables",permalink:"/docs/dotnet/advanced/adding-rows-to-multiple-iteration-tables",draft:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/advanced/adding-rows-to-multiple-iteration-tables.md",tags:[],version:"current",sidebarPosition:1,frontMatter:{title:"Adding Rows to Multiple-Iteration Tables",image:"./AddingRowsToMultipleIterationTables.png",sidebar_position:1},sidebar:"dotnetSidebar",previous:{title:"RowAction",permalink:"/docs/dotnet/data-model/rowaction"},next:{title:"AvatarScriptLink.NET Changelog",permalink:"/docs/dotnet/changelog/"}},l={image:o(69).Z},c=[{value:"Add RowObjects with AddRowObject",id:"add-rowobjects-with-addrowobject",level:2},{value:"Handling Exceptions",id:"handling-exceptions",level:2},{value:"Complete Example",id:"complete-example",level:2}],s={toc:c},p="wrapper";function m(e){let{components:t,...o}=e;return(0,r.kt)(p,(0,n.Z)({},s,o,{components:t,mdxType:"MDXLayout"}),(0,r.kt)("p",null,"Multiple-iteration tables are a special kind of ",(0,r.kt)("a",{parentName:"p",href:"/docs/dotnet/data-model/formobject"},"FormObject")," that allow for multiple ",(0,r.kt)("a",{parentName:"p",href:"/docs/dotnet/data-model/rowobject"},"RowObjects"),"."),(0,r.kt)("p",null,"There are some constraints when working with multiple-iteration tables."),(0,r.kt)("ul",null,(0,r.kt)("li",{parentName:"ul"},"Cannot be the first ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/formobject"},"FormObject")," in an ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/optionobject2015"},"OptionObject"),"."),(0,r.kt)("li",{parentName:"ul"},(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/rowobject"},"RowObjects")," cannot share the same RowId.")),(0,r.kt)("p",null,"The AvatarScriptLink.NET library helps with managing these constraints by:"),(0,r.kt)("ul",null,(0,r.kt)("li",{parentName:"ul"},"Throwing an exception when attempting to add additional ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/rowobject"},"RowObjects")," to a non-multiple-iteration ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/formobject"},"FormObject"),"."),(0,r.kt)("li",{parentName:"ul"},"Automatically sets the ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/rowaction"},"RowAction"),' to "ADD".'),(0,r.kt)("li",{parentName:"ul"},"Automatically assigns RowIds to prevent duplicates."),(0,r.kt)("li",{parentName:"ul"},"Automatically adds new ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/rowobject"},"RowObjects")," to OtherRows when CurrentRow is already set.")),(0,r.kt)("h2",{id:"add-rowobjects-with-addrowobject"},"Add RowObjects with AddRowObject"),(0,r.kt)("admonition",{type:"warning"},(0,r.kt)("p",{parentName:"admonition"},"At this time we want to avoid using the ",(0,r.kt)("a",{parentName:"p",href:"/docs/dotnet/data-model/rowobject"},"RowObject")," Builder to build the ",(0,r.kt)("a",{parentName:"p",href:"/docs/dotnet/data-model/rowobject"},"RowObjects")," as it requires setting the RowId instead of allowing the AddRowObject method to auto-assign it. This may change in a future update.")),(0,r.kt)("p",null,"To take advantage of the library features described above, we want to use the AddRowObject method exclusively to add the new rows."),(0,r.kt)("pre",null,(0,r.kt)("code",{parentName:"pre",className:"language-cs"},'var clone = _optionObject.Clone();\n\nvar miFormId = "123";\n\nvar firstRow = new RowObject();\nfirstRow.AddFieldObject(new FieldObject("123.45", "Test #1"));\nclone.AddRowObject(miFormId, firstRow);\n\nvar secondRow = new RowObject();\nsecondRow.AddFieldObject(new FieldObject("123.45", "Test #2"));\nclone.AddRowObject(miFormId, secondRow);\n\nreturn clone.ToReturnOptionObject();\n')),(0,r.kt)("h2",{id:"handling-exceptions"},"Handling Exceptions"),(0,r.kt)("p",null,"Two of the most common errors that can occur include:"),(0,r.kt)("ul",null,(0,r.kt)("li",{parentName:"ul"},"Attempting to reference a ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/formobject"},"FormObject")," that is not in this ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/optionobject2015"},"OptionObject"),"."),(0,r.kt)("li",{parentName:"ul"},"Attempting to add multiple ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/rowobject"},"RowObjects")," to a non-multiple iteration ",(0,r.kt)("a",{parentName:"li",href:"/docs/dotnet/data-model/formobject"},"FormObject"),".")),(0,r.kt)("p",null,"This can be handled with conditionals and exception handling."),(0,r.kt)("pre",null,(0,r.kt)("code",{parentName:"pre",className:"language-cs"},'var clone = _optionObject.Clone();\n\nvar miFormId = "123";\nif (clone.IsFormPresent(miFormId))\n{\n    try\n    {\n        var firstRow = new RowObject();\n        firstRow.AddFieldObject(new FieldObject("123.45", "Test #1"));\n        clone.AddRowObject(miFormId, firstRow);\n\n        var secondRow = new RowObject();\n        secondRow.AddFieldObject(new FieldObject("123.45", "Test #2"));\n        clone.AddRowObject(miFormId, secondRow);\n\n        return clone.ToReturnOptionObject();\n    }\n    catch (ArguementException ex) {\n        return clone.ToReturnOptionObject(ErrorCode.Error, ex.Message);\n    }\n}\nreturn clone.ToReturnOptionObject(ErrorCode.Error, "Could not find expected multiple-iteration form.");\n')),(0,r.kt)("h2",{id:"complete-example"},"Complete Example"),(0,r.kt)("p",null,"Below is the complete example with options for initializing and building the different objects."),(0,r.kt)("pre",null,(0,r.kt)("code",{parentName:"pre",className:"language-cs"},'// Cloning the received OptionObject2015 to avoid modifying what was received\nvar clone = _optionObject.Clone();\n\n// The FormID of the Multiple-Iteration Table to add rows to\nvar miFormId = "123";\n// Verify Form is present\nif (clone.IsFormPresent(miFormId))\n{\n    try\n    {\n        // Using Constructor instead of Builder to allow AddRowObject to assign the RowId automatically \n        var firstRow = new RowObject();\n        // Adding FieldObjects using Constructors\n        firstRow.AddFieldObject(new FieldObject("123.45", "Test #1"));\n        firstRow.AddFieldObject(new FieldObject("123.46", "Another field in the row."));\n        // If the MI Form doesn\'t have any rows yet this will be placed in CurrentRow. Otherwise, it will be added to OtherRows.\n        clone.AddRowObject(miFormId, firstRow);\n\n        // You can also use the Initializer\n        var secondRow = RowObject.Initialize();\n        // Adding FieldObjects using Builder\n        secondRow.AddFieldObject(FieldObject.Builder().FieldNumber("123.45").FieldValue("Test #2").Build());\n        firstRow.AddFieldObject(FieldObject.Builder().FieldNumber("123.46").FieldValue("More information.").Build());\n        // This row will be added to OtherRows\n        clone.AddRowObject(miFormId, secondRow);\n\n        return clone.ToReturnOptionObject();\n    }\n    catch (ArgumentException ex)\n    {\n        // ArgumentException is expected when attempting to add multiple rows to a non-MI form\n        logger.Error(ex);\n        return clone.ToReturnOptionObject(ErrorCode.Error, ex.Message);\n    }\n}\nlogger.Error("Could not find expected multiple-iteration FormObject.");\nreturn clone.ToReturnOptionObject(ErrorCode.Error, "Could not find expected multiple-iteration form.");\n')))}m.isMDXComponent=!0},69:(e,t,o)=>{o.d(t,{Z:()=>n});const n=o.p+"assets/images/AddingRowsToMultipleIterationTables-569618cc1521e6e0cebc197df9188afb.png"}}]);