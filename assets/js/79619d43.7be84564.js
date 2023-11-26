"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[6243],{535:(e,t,l)=>{l.r(t),l.d(t,{assets:()=>a,contentTitle:()=>o,default:()=>h,frontMatter:()=>d,metadata:()=>c,toc:()=>j});var n=l(5893),i=l(1151),r=l(4866),s=l(5162);const d={title:"FormObject",image:"./FormObject.png",sidebar_position:4},o="FormObject",c={id:"dotnet/data-model/formobject",title:"FormObject",description:"The FormObject represents a section of a myAvatar Form.",source:"@site/docs/dotnet/data-model/formobject.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/formobject",permalink:"/docs/dotnet/data-model/formobject",draft:!1,unlisted:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/formobject.mdx",tags:[],version:"current",sidebarPosition:4,frontMatter:{title:"FormObject",image:"./FormObject.png",sidebar_position:4},sidebar:"dotnetSidebar",previous:{title:"OptionObject2015",permalink:"/docs/dotnet/data-model/optionobject2015"},next:{title:"RowObject",permalink:"/docs/dotnet/data-model/rowobject"}},a={image:l(9776).Z},j=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2},{value:"Detailed Class Diagram",id:"detailed-class-diagram",level:2}];function b(e){const t={a:"a",code:"code",h1:"h1",h2:"h2",mermaid:"mermaid",p:"p",pre:"pre",table:"table",tbody:"tbody",td:"td",th:"th",thead:"thead",tr:"tr",...(0,i.a)(),...e.components};return(0,n.jsxs)(n.Fragment,{children:[(0,n.jsx)(t.h1,{id:"formobject",children:"FormObject"}),"\n",(0,n.jsx)(t.p,{children:"The FormObject represents a section of a myAvatar Form.\nAvatarScriptLink.NET adds several utility methods to assist with handlings these objects."}),"\n",(0,n.jsx)(t.mermaid,{value:'classDiagram\ndirection LR\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormId\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n    +AddRowObject(RowObject)\n    +AddRowObject(string, string)\n    +AddRowObject(string, string, string)\n    +Builder() FormObjectBuilder\n    +Clone() FormObject\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +Equals(FormObjectBase) bool\n    +Equals(object) bool\n    +Initialize() FormObject\n    +GetCurrentRowId() string\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetNextAvailableRowId() string\n    +GetParentRowId() string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(string)\n    +SetEnabledField(string)\n    +SetEnabledFields(string)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(string)\n    +SetOptionalField(string)\n    +SetOptionalFields(string)\n    +SetRequiredField(string)\n    +SetRequiredFields(string)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(string)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToXml() string\n}\n\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n}\n\nFormObject "1" --o "1" RowObject : CurrentRow\nFormObject "1" --o "*" RowObject : OtherRows\n\nclick RowObject href "./rowobject" "Learn more about the RowObject"'}),"\n",(0,n.jsx)(t.h2,{id:"properties",children:"Properties"}),"\n",(0,n.jsxs)(t.table,{children:[(0,n.jsx)(t.thead,{children:(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.th,{style:{textAlign:"left"},children:"Property"}),(0,n.jsx)(t.th,{style:{textAlign:"left"},children:"Description"})]})}),(0,n.jsxs)(t.tbody,{children:[(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"CurrentRow"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"The contents of this myAvatar Form section. The selected row on multiple iteration tables."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"FormId"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"The unique Id assigned to this section (FormObject)."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"MultipleIteration"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Indicates whether this section uses a multiple iteration table. Note: this is not the same as TDE objects."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"OtherRows"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Contains the contents of unselected rows in the multiple iteration table."})]})]})]}),"\n",(0,n.jsx)(t.h2,{id:"methods",children:"Methods"}),"\n",(0,n.jsxs)(t.table,{children:[(0,n.jsx)(t.thead,{children:(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.th,{style:{textAlign:"left"},children:"Method"}),(0,n.jsx)(t.th,{style:{textAlign:"left"},children:"Description"})]})}),(0,n.jsxs)(t.tbody,{children:[(0,n.jsxs)(t.tr,{children:[(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["AddRowObject(",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"}),")"]}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Adds a ",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," to a the FormObject."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"AddRowObject(string, string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Adds a ",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," to a FormObject using supplied RowId and ParentRowId."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"AddRowObject(string, string, string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Adds a ",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," to a FormObject using supplied RowId and ParentRowId and setting the RowAction."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Builder()"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Initializes a builder for constructing a FormObject."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Clone()"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Creates a copy of the FormObject."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["DeleteRowObject(",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"}),")"]}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Removes a ",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," from a FormObject."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"DeleteRowObject(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Removes a ",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," from a FormObject by RowId."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Equals(FormObjectBase)"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Used to compare two FormObject to determine if they are equal. Returns bool."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Equals(object)"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Used to compare FormObject to an object to determine if they are equal. Returns bool."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"GetCurrentRowId()"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns the ID of the ",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," in the CurrentRow of a FormObject."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"GetHashCode()"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Overrides the GetHashCode method for a FormObjectBase."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"GetFieldValue(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns the FieldValue of a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"GetFieldValue(string, string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns the FieldValue of a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject by RowId and FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"GetFieldValues(string)"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Returns a List<string> of FieldValues in a FormObject by FieldNumber."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"GetNextAvailableRowId()"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the next available RowId for the FormObject."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"GetParentRowId()"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the ParentRowId of the FormObject.CurrentRow."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Initialize()"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Initializes an empty FormObject."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldEnabled(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns whether a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject is enabled by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldLocked(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns whether a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject is locked by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldModified(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns whether a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject is modified by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldPresent(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns whether a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject is present by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldRequired(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns whether a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject is required by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"IsRowMarkedForDeletion(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns whether a ",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," in a FormObject is marked for deletion by RowId."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"IsRowPresent(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns whether a ",(0,n.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," in a FormObject is present by RowId."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetDisabledField(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject as disabled by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetDisabledFields(List<string>)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as disabled by FieldNumbers."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetDisabledFields(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as disabled by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as disabled."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetEnabledField(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject as enabled by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetEnabledFields(List<string>)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as enabled by FieldNumbers."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetEnabledFields(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as enabled by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as disabled."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetFieldValue(string, string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the FieldValue of a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in the FormObject.CurrentRow by FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetFieldValue(string, string, string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the FieldValue a ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in the FormObject by RowId and FieldNumber."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetLockedField(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Set the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject as locked by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as locked."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetLockedFields(List<string>)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as locked by FieldNumbers."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetLockedFields(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as locked by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as locked."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetOptionalField(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject as enabled and not required by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as enabled and not required."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetOptionalFields(List<string>)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as enabled and not required by FieldNumbers."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetOptionalFields(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as enabled and not required by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as enabled and not required."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetRequiredField(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject as enabled and required by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as enabled and required."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetRequiredFields(List<string>)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as enabled and required by FieldNumbers."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetRequiredFields(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as enabled and required by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as enabled and required."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetUnlockedField(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in a FormObject as unlocked by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as unlocked."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetUnlockedFields(List<string>)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as unlocked by FieldNumbers."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"SetUnlockedFields(string)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," in a FormObject as unlocked by FieldNumber. If ",(0,n.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," is in a multiple iteration FormObject then all occurances will be set as unlocked."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"ToHtmlString()"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns the FormObject as an HTML string. The ",(0,n.jsx)(t.code,{children:"<html>"}),", ",(0,n.jsx)(t.code,{children:"<head>"}),", and ",(0,n.jsx)(t.code,{children:"<body>"})," tags can be included if desired."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"ToHtmlString(bool)"}),(0,n.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns the FormObject as an HTML string. The ",(0,n.jsx)(t.code,{children:"<html>"}),", ",(0,n.jsx)(t.code,{children:"<head>"}),", and ",(0,n.jsx)(t.code,{children:"<body>"})," tags can be included if desired."]})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"ToJson()"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the FormObject as a JSON string."})]}),(0,n.jsxs)(t.tr,{children:[(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"ToXml()"}),(0,n.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the FormObject as an XML string."})]})]})]}),"\n",(0,n.jsx)(t.h2,{id:"examples",children:"Examples"}),"\n",(0,n.jsxs)(t.p,{children:["Most implementations would not require working with the FormObject directly, however here is an example that uses the FormObject to create an ",(0,n.jsx)(t.a,{href:"../optionobject2015",children:"OptionObject2015"})," for Unit Testing."]}),"\n",(0,n.jsxs)(r.Z,{children:[(0,n.jsx)(s.Z,{value:"cs",label:"C#",children:(0,n.jsx)(t.pre,{children:(0,n.jsx)(t.code,{className:"language-cs",children:'// Available in v1.2 or later\n[TestMethod]\npublic void TestMethod1WithFluentBuilder()\n{\n    var expected = "123";\n    // FieldObject and RowObject definitions here \n    FormObject formObject = FormObject.Builder()\n        .FormId(expected)\n        .CurrentRow()\n            .RowId("123||1")\n            .Field(fieldObject1)\n            .Field(fieldObject2)\n            .AddRow()\n        .MultipleIteration()\n        .OtherRow()\n            .RowId("123||2")\n            .Field(fieldObject3)\n            .Field(fieldObject4)\n            .AddRow()\n        .OtherRow(rowObject)\n        .Build();\n    Assert.AreEqual(expected, formObject.FormId);\n}\n\n[TestMethod]\npublic void TestMethod1WithSimplifiedConstructor()\n{\n    var expected = "123";\n    FormObject formObject = new FormObject()\n    {\n        FormId = expected\n    };\n    Assert.AreEqual(expected, formObject.FormId);\n}\n'})})}),(0,n.jsx)(s.Z,{value:"vb",label:"Visual Basic",children:(0,n.jsx)(t.pre,{children:(0,n.jsx)(t.code,{className:"language-vb",children:'\' Available in v1.2 or later\n<TestMethod()> Public Sub TestMethod1WithFluentBuilder()\n    Dim expected As String = "123"\n    \' FieldObject and RowObject definitions here \n    Dim formObject As FormObject.Builder()\n        .FormId(expected)\n        .CurrentRow()\n            .RowId("123||1")\n            .Field(fieldObject1)\n            .Field(fieldObject2)\n            .AddRow()\n        .MultipleIteration()\n        .OtherRow()\n            .RowId("123||2")\n            .Field(fieldObject3)\n            .Field(fieldObject4)\n            .AddRow()\n        .OtherRow(rowObject)\n        .Build()\n    Assert.AreEqual(expected, formObject.FormId)\nEnd Sub\n\n\n<TestMethod()> Public Sub TestMethod1WithSimplifiedConstructor()\n    Dim expected As String = "123"\n    Dim formObject As New FormObject With {\n        .FormId = expected\n    }\n    Assert.AreEqual(expected, formObject.FormId)\nEnd Sub\n'})})})]}),"\n",(0,n.jsx)(t.h2,{id:"detailed-class-diagram",children:"Detailed Class Diagram"}),"\n",(0,n.jsx)(t.mermaid,{value:'classDiagram\ndirection LR\nclass FormObject {\n    +Builder() FormObjectBuilder\n    +Clone() FormObject\n    +Initialize() FormObject\n    +ToXml() string\n}\n\nclass FormObjectBase {\n    +RowObject CurrentRow\n    +string FormId\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n    +AddRowObject(RowObject)\n    +AddRowObject(string, string)\n    +AddRowObject(string, string, string)\n    +Clone() FormObjectBase\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +Equals(FormObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId() string\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetNextAvailableRowId() string\n    +GetParentRowId() string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(string)\n    +SetEnabledField(string)\n    +SetEnabledFields(string)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(string)\n    +SetOptionalField(string)\n    +SetOptionalFields(string)\n    +SetRequiredField(string)\n    +SetRequiredFields(string)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(string)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n}\n<<abstract>> FormObjectBase\n\nclass IFormObject {\n    RowObject CurrentRow\n    string FormId\n    bool MultipleIteration\n    List~RowObject~ OtherRows\n}\n<<interface>> IFormObject\n\nclass RowObject {\n    +List~FieldObject~ Fields\n    +string ParentRowId\n    +string RowAction\n    +string RowId\n}\n\nclass IEquatable~FormObjectBase~\n<<interface>> IEquatable~FormObjectBase~\n\nFormObjectBase "1" --o "1" RowObject : CurrentRow\nFormObjectBase "1" --o "*" RowObject : OtherRows\n\nFormObject --|> FormObjectBase : inherits\nFormObjectBase --|> IEquatable~FormObjectBase~ : inherits\nFormObjectBase --|> IFormObject : inherits\n\nclick RowObject href "./rowobject" "Learn more about the RowObject"'})]})}function h(e={}){const{wrapper:t}={...(0,i.a)(),...e.components};return t?(0,n.jsx)(t,{...e,children:(0,n.jsx)(b,{...e})}):b(e)}},5162:(e,t,l)=>{l.d(t,{Z:()=>s});l(7294);var n=l(6010);const i={tabItem:"tabItem_Ymn6"};var r=l(5893);function s(e){let{children:t,hidden:l,className:s}=e;return(0,r.jsx)("div",{role:"tabpanel",className:(0,n.Z)(i.tabItem,s),hidden:l,children:t})}},4866:(e,t,l)=>{l.d(t,{Z:()=>w});var n=l(7294),i=l(6010),r=l(2466),s=l(6550),d=l(469),o=l(1980),c=l(7392),a=l(12);function j(e){return n.Children.toArray(e).filter((e=>"\n"!==e)).map((e=>{if(!e||(0,n.isValidElement)(e)&&function(e){const{props:t}=e;return!!t&&"object"==typeof t&&"value"in t}(e))return e;throw new Error(`Docusaurus error: Bad <Tabs> child <${"string"==typeof e.type?e.type:e.type.name}>: all children of the <Tabs> component should be <TabItem>, and every <TabItem> should have a unique "value" prop.`)}))?.filter(Boolean)??[]}function b(e){const{values:t,children:l}=e;return(0,n.useMemo)((()=>{const e=t??function(e){return j(e).map((e=>{let{props:{value:t,label:l,attributes:n,default:i}}=e;return{value:t,label:l,attributes:n,default:i}}))}(l);return function(e){const t=(0,c.l)(e,((e,t)=>e.value===t.value));if(t.length>0)throw new Error(`Docusaurus error: Duplicate values "${t.map((e=>e.value)).join(", ")}" found in <Tabs>. Every value needs to be unique.`)}(e),e}),[t,l])}function h(e){let{value:t,tabValues:l}=e;return l.some((e=>e.value===t))}function u(e){let{queryString:t=!1,groupId:l}=e;const i=(0,s.k6)(),r=function(e){let{queryString:t=!1,groupId:l}=e;if("string"==typeof t)return t;if(!1===t)return null;if(!0===t&&!l)throw new Error('Docusaurus error: The <Tabs> component groupId prop is required if queryString=true, because this value is used as the search param name. You can also provide an explicit value such as queryString="my-search-param".');return l??null}({queryString:t,groupId:l});return[(0,o._X)(r),(0,n.useCallback)((e=>{if(!r)return;const t=new URLSearchParams(i.location.search);t.set(r,e),i.replace({...i.location,search:t.toString()})}),[r,i])]}function x(e){const{defaultValue:t,queryString:l=!1,groupId:i}=e,r=b(e),[s,o]=(0,n.useState)((()=>function(e){let{defaultValue:t,tabValues:l}=e;if(0===l.length)throw new Error("Docusaurus error: the <Tabs> component requires at least one <TabItem> children component");if(t){if(!h({value:t,tabValues:l}))throw new Error(`Docusaurus error: The <Tabs> has a defaultValue "${t}" but none of its children has the corresponding value. Available values are: ${l.map((e=>e.value)).join(", ")}. If you intend to show no default tab, use defaultValue={null} instead.`);return t}const n=l.find((e=>e.default))??l[0];if(!n)throw new Error("Unexpected error: 0 tabValues");return n.value}({defaultValue:t,tabValues:r}))),[c,j]=u({queryString:l,groupId:i}),[x,f]=function(e){let{groupId:t}=e;const l=function(e){return e?`docusaurus.tab.${e}`:null}(t),[i,r]=(0,a.Nk)(l);return[i,(0,n.useCallback)((e=>{l&&r.set(e)}),[l,r])]}({groupId:i}),g=(()=>{const e=c??x;return h({value:e,tabValues:r})?e:null})();(0,d.Z)((()=>{g&&o(g)}),[g]);return{selectedValue:s,selectValue:(0,n.useCallback)((e=>{if(!h({value:e,tabValues:r}))throw new Error(`Can't select invalid tab value=${e}`);o(e),j(e),f(e)}),[j,f,r]),tabValues:r}}var f=l(2389);const g={tabList:"tabList__CuJ",tabItem:"tabItem_LNqP"};var m=l(5893);function F(e){let{className:t,block:l,selectedValue:n,selectValue:s,tabValues:d}=e;const o=[],{blockElementScrollPositionUntilNextRender:c}=(0,r.o5)(),a=e=>{const t=e.currentTarget,l=o.indexOf(t),i=d[l].value;i!==n&&(c(t),s(i))},j=e=>{let t=null;switch(e.key){case"Enter":a(e);break;case"ArrowRight":{const l=o.indexOf(e.currentTarget)+1;t=o[l]??o[0];break}case"ArrowLeft":{const l=o.indexOf(e.currentTarget)-1;t=o[l]??o[o.length-1];break}}t?.focus()};return(0,m.jsx)("ul",{role:"tablist","aria-orientation":"horizontal",className:(0,i.Z)("tabs",{"tabs--block":l},t),children:d.map((e=>{let{value:t,label:l,attributes:r}=e;return(0,m.jsx)("li",{role:"tab",tabIndex:n===t?0:-1,"aria-selected":n===t,ref:e=>o.push(e),onKeyDown:j,onClick:a,...r,className:(0,i.Z)("tabs__item",g.tabItem,r?.className,{"tabs__item--active":n===t}),children:l??t},t)}))})}function O(e){let{lazy:t,children:l,selectedValue:i}=e;const r=(Array.isArray(l)?l:[l]).filter(Boolean);if(t){const e=r.find((e=>e.props.value===i));return e?(0,n.cloneElement)(e,{className:"margin-top--md"}):null}return(0,m.jsx)("div",{className:"margin-top--md",children:r.map(((e,t)=>(0,n.cloneElement)(e,{key:t,hidden:e.props.value!==i})))})}function y(e){const t=x(e);return(0,m.jsxs)("div",{className:(0,i.Z)("tabs-container",g.tabList),children:[(0,m.jsx)(F,{...e,...t}),(0,m.jsx)(O,{...e,...t})]})}function w(e){const t=(0,f.Z)();return(0,m.jsx)(y,{...e,children:j(e.children)},String(t))}},9776:(e,t,l)=>{l.d(t,{Z:()=>n});const n=l.p+"assets/images/FormObject-29093b7c4133eb699ee68d0ddbb3338e.png"},1151:(e,t,l)=>{l.d(t,{Z:()=>d,a:()=>s});var n=l(7294);const i={},r=n.createContext(i);function s(e){const t=n.useContext(r);return n.useMemo((function(){return"function"==typeof e?e(t):{...t,...e}}),[t,e])}function d(e){let t;return t=e.disableParentContext?"function"==typeof e.components?e.components(i):e.components||i:s(e.components),n.createElement(r.Provider,{value:t},e.children)}}}]);