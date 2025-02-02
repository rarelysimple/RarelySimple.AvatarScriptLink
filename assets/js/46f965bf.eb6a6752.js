"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[7321],{1697:(t,e,n)=>{n.r(e),n.d(e,{assets:()=>o,contentTitle:()=>d,default:()=>j,frontMatter:()=>r,metadata:()=>i,toc:()=>c});const i=JSON.parse('{"id":"dotnet/decorators/optionobject","title":"OptionObject Decorator","description":"The OptionObject holds all of the content of and metadata describing the calling myAvatar form.","source":"@site/docs/dotnet/decorators/optionobject.mdx","sourceDirName":"dotnet/decorators","slug":"/dotnet/decorators/optionobject","permalink":"/docs/next/dotnet/decorators/optionobject","draft":false,"unlisted":false,"editUrl":"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/decorators/optionobject.mdx","tags":[],"version":"current","sidebarPosition":3,"frontMatter":{"title":"OptionObject Decorator","image":"./OptionObject.png","sidebar_position":3,"sidebar_label":"OptionObject","displayed_sidebar":"dotnetSidebar"},"sidebar":"dotnetSidebar"}');var s=n(4848),l=n(8453);const r={title:"OptionObject Decorator",image:"./OptionObject.png",sidebar_position:3,sidebar_label:"OptionObject",displayed_sidebar:"dotnetSidebar"},d=void 0,o={image:n(1731).A},c=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2},{value:"Detailed Class Diagram",id:"detailed-class-diagram",level:2}];function h(t){const e={a:"a",h2:"h2",mermaid:"mermaid",p:"p",table:"table",tbody:"tbody",td:"td",th:"th",thead:"thead",tr:"tr",...(0,l.R)(),...t.components};return(0,s.jsxs)(s.Fragment,{children:[(0,s.jsx)(e.p,{children:"The OptionObject holds all of the content of and metadata describing the calling myAvatar form.\nThe OptionObjectDecorator adds several utility methods to assist with handlings these objects."}),"\n",(0,s.jsx)(e.mermaid,{value:'classDiagram\ndirection LR\nclass OptionObjectDecorator {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string SystemCode\n    +AddFormObject(FormObject)\n    +AddFormObject(string, bool)\n    +AddRowObject(string, RowObject)\n    +Clone() OptionObject\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +DisableAllFieldObjects()\n    +DisableAllFieldObjects(List~string~)\n    +Equals(OptionObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId(string) strings\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetMultipleIterationStatus(string) bool\n    +GetParentRowId(string) string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsFormPresent(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(List~string~)\n    +SetEnabledField(string)\n    +SetEnabledFields(List~string~)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(List~string~)\n    +SetOptionalField(string)\n    +SetOptionalFields(List~string~)\n    +SetRequiredField(string)\n    +SetRequiredFields(List~string~)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(List~string~)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToOptionObject() OptionObject\n    +ToOptionObject2() OptionObject2\n    +ToOptionObject2015() OptionObject2015\n    +ToReturnOptionObject() OptionObject\n    +ToReturnOptionObject(bool, string) OptionObject\n    +ToXml() string\n}\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nOptionObject "1" --o "*" FormObject : Forms\n\nclick FormObject href "./formobject" "Learn more about the FormObject"'}),"\n",(0,s.jsx)(e.h2,{id:"properties",children:"Properties"}),"\n",(0,s.jsxs)(e.table,{children:[(0,s.jsx)(e.thead,{children:(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.th,{style:{textAlign:"left"},children:"Property"}),(0,s.jsx)(e.th,{style:{textAlign:"left"},children:"Description"})]})}),(0,s.jsxs)(e.tbody,{children:[(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"EntityID"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"The unique Id of the selected entity. I.e., Patient, Staff, or User."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"EpisodeNumber"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"The selected Episode Number. Will be null if the form is non-episodic."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ErrorCode"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Informs myAvatar of the outcome of the ScriptLink API call."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ErrorMesg"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Message to display to user with certain error codes."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Facility"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"The Facility Id the user is currently working in."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Forms"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["List of myAvatar form sections including rows and fields. See ",(0,s.jsx)(e.a,{href:"../formobject",children:"FormObject"}),"."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"OptionId"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"The unique Id of the form that sent this request."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"OptionStaffId"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"The Staff Id assigned to the logged on user. May be null/empty if not associated with a Practitioner."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"OptionUserId"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"The User Id of the logged on user."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ServerName"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"The server the request was submitted from."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SystemCode"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"The System Code the user is currently working in."})]})]})]}),"\n",(0,s.jsx)(e.h2,{id:"methods",children:"Methods"}),"\n",(0,s.jsx)(e.p,{children:"The following methods are available on the OptionObject to assist with common tasks."}),"\n",(0,s.jsxs)(e.table,{children:[(0,s.jsx)(e.thead,{children:(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.th,{style:{textAlign:"left"},children:"Method"}),(0,s.jsx)(e.th,{style:{textAlign:"left"},children:"Description"})]})}),(0,s.jsxs)(e.tbody,{children:[(0,s.jsxs)(e.tr,{children:[(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["AddFormObject(",(0,s.jsx)(e.a,{href:"../formobject",children:"FormObject"}),")"]}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Adds a ",(0,s.jsx)(e.a,{href:"../formobject",children:"FormObject"})," to the OptionObject."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"AddFormObject(string, bool)"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Creates a ",(0,s.jsx)(e.a,{href:"../formobject",children:"FormObject"})," with specified FormId and adds to the OptionObject2015. The second parameter specifies whether the ",(0,s.jsx)(e.a,{href:"../formobject",children:"FormObject"})," should be flagged as a Multiple Iteration form."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["AddRowObject(string, ",(0,s.jsx)(e.a,{href:"../rowobject",children:"RowObject"}),")"]}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Adds a ",(0,s.jsx)(e.a,{href:"../rowobject",children:"RowObject"})," to the ",(0,s.jsx)(e.a,{href:"../formobject",children:"FormObject"})," with the specified FormId."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Builder()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Initializes a builder for constructing a OptionObject."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Clone()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Clones the OptionObject."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["DeleteRowObject(",(0,s.jsx)(e.a,{href:"../rowobject",children:"RowObject"}),")"]}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Marks a ",(0,s.jsx)("see",{cref:"RowObject"})," for deletion."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"DeleteRowObject(string)"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Marks a ",(0,s.jsx)("see",{cref:"RowObject"})," for deletion by specified RowId."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"DisableAllFieldObjects()"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Sets all ",(0,s.jsx)(e.a,{href:"../fieldobject",children:"FieldObjects"})," as disabled."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"DisableAllFieldObjects(List of string)"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Sets all ",(0,s.jsx)(e.a,{href:"../fieldobject",children:"FieldObjects"})," as disabled except for any listed to be excluded."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Equals(OptionObjectBase)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Used to compare two OptionObject to determine if they are equal. Returns bool."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Equals(object)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Used to compare OptionObject to an object to determine if they are equal. Returns bool."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"GetCurrentRowId(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns the CurrentRow RowId of the form matching the FormId."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"GetFieldValue(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns the first value of the field matching the Field Number."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"GetFieldValue(string, string, string)"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Returns the value of the ",(0,s.jsx)("see",{cref:"FieldObject"})," matching the Field Number on the specified ",(0,s.jsx)(e.a,{href:"../formobject",children:"FormObject"})," and ",(0,s.jsx)(e.a,{href:"../rowobject",children:"RowObject"}),"."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"GetFieldValues(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns the values of the field matching the Field Number."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"GetHashCode()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Overrides the GetHashCode method for a OptionObjectBase."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"GetMultipleIterationStatus(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns the Multiple Iteration Status of the form matching the FormId."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"GetParentRowId(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns the CurrentRow ParentRowId of the form matching the FormId."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Initialize()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Initializes an empty OptionObject."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"IsFieldEnabled(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns whether the specified field is enabled."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"IsFieldLocked(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns whether the specified field is locked."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"IsFieldModified(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns whether the specified field is modified."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"IsFieldPresent(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns whether the specified field is present."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"IsFieldRequired(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns whether the specified field is required."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"IsFormPresent(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns whether the specified form is present."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"IsRowMarkedForDeletion(string)"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Returns whether the specified ",(0,s.jsx)(e.a,{href:"../rowobject",children:"RowObject"})," is marked for deletion."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"IsRowPresent(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns whether the specified row is present"})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetDisabledField(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Sets the specified field as disabled."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetDisabledFields(List of string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Sets the specified fields as disabled."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetEnabledField(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Sets the specified field as enabled."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetEnabledFields(Listof string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Sets the specified fields as enabled."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetFieldValue(string, string)"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Sets the FieldValue of a ",(0,s.jsx)(e.a,{href:"../fieldobject",children:"FieldObject"})," in the OptionObject on the first form's CurrentRow."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetFieldValue(string, string, string, string)"}),(0,s.jsxs)(e.td,{style:{textAlign:"left"},children:["Sets the FieldValue of a ",(0,s.jsx)(e.a,{href:"../fieldobject",children:"FieldObject"})," in the OptionObject."]})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetLockedField(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Sets the specified field as locked."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetLockedFields(List of string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Sets the specified fields as disabled."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetOptionalField(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Set the specified field as not required and enables if disabled."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetOptionalFields(List of string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Set the specified fields as not required and enables if disabled."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetRequiredField(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Sets the specified field as required."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetRequiredFields(List of string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Sets the specified fields as required."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetUnlockedField(string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Set the specified field as unlocked."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"SetUnlockedFields(List of string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Set the specified fields as unlocked."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToHtmlString()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns a string with all of the contents of the OptionObject formatted in HTML."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToHtmlString(bool)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns a string with all of the contents of the OptionObject formatted in HTML. Passing true will include HTML header tags."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToJson()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns a string with all of the contents of the OptionObject formatted as JSON."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToOptionObject()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Creates a clone of the OptionObject."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToOptionObject2()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Transforms the OptionObject2 to an OptionObject2."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToOptionObject2015()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Transforms the OptionObject2 as an OptionObject2015."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToReturnOptionObject()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Creates an OptionObject with the minimum information required to return."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToReturnOptionObject(int, string)"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Creates an OptionObject with the minimum information required to return plus the provided Error Code and Message."})]}),(0,s.jsxs)(e.tr,{children:[(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"ToXml()"}),(0,s.jsx)(e.td,{style:{textAlign:"left"},children:"Returns a string with all of the contents of the OptionObject formatted as XML."})]})]})]}),"\n",(0,s.jsx)(e.h2,{id:"examples",children:"Examples"}),"\n",(0,s.jsx)(e.p,{children:"The following code shows how to use OptionObject to construct a web service compatible with myAvatar."}),"\n",(0,s.jsx)(e.h2,{id:"detailed-class-diagram",children:"Detailed Class Diagram"}),"\n",(0,s.jsx)(e.mermaid,{value:'classDiagram\nclass OptionObject {\n    +Clone() OptionObject\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToOptionObject() OptionObject\n    +ToOptionObject2() OptionObject2\n    +ToOptionObject2015() OptionObject2015\n    +ToReturnOptionObject() OptionObject\n    +ToReturnOptionObject(bool, string) OptionObject\n    +ToXml() string\n}\n\nclass OptionObjectBase {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n    +AddFormObject(FormObject)\n    +AddFormObject(string, bool)\n    +AddRowObject(string, RowObject)\n    +Clone() OptionObjectBase\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +DisableAllFieldObjects()\n    +DisableAllFieldObjects(List~string~)\n    +Equals(OptionObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId(string) strings\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetMultipleIterationStatus(string) bool\n    +GetParentRowId(string) string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsFormPresent(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(List~string~)\n    +SetEnabledField(string)\n    +SetEnabledFields(List~string~)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(List~string~)\n    +SetOptionalField(string)\n    +SetOptionalFields(List~string~)\n    +SetRequiredField(string)\n    +SetRequiredFields(List~string~)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(List~string~)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToOptionObject()* OptionObject\n    +ToOptionObject2()* OptionObject2\n    +ToOptionObject2015()* OptionObject2015\n    +ToReturnOptionObject() OptionObjectBase\n    +ToReturnOptionObject(double, string) OptionObjectBase\n    +ToXml() string\n    -AreBothEmpty(List~FormObject~, List~FormObject~)$ bool\n    -AreBothNull(List~FormObject~, List~FormObject~)$ bool\n    -AreFormsEqual(List~FormObject~, List~FormObject~)$ bool\n}\n<<abstract>> OptionObjectBase\n\nclass IOptionObject2015 {\n    string SessionToken\n}\n<<interface>> IOptionObject2015\n\nclass IOptionObject2 {\n    string NamespaceName\n    string ParentNamespace\n    string ServerName\n}\n<<interface>> IOptionObject2\n\nclass IOptionObject {\n    string EntityID\n    double EpisodeNumber\n    double ErrorCode\n    string ErrorMesg\n    string Facility\n    List~FormObject~ Forms\n    string OptionId\n    string OptionStaffId\n    string OptionUserId\n    string SystemCode\n}\n<<interface>> IOptionObject\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nOptionObjectBase "1" --o "*" FormObject : Forms\n\nOptionObject --|> OptionObjectBase : inherits\nOptionObjectBase --|> IEquatable~OptionObjectBase~ : inherits\nOptionObjectBase --|> IOptionObject2015 : inherits\nIOptionObject2015 --|> IOptionObject2 : inherits\nIOptionObject2 --|> IOptionObject : inherits\n\nclick FormObject href "./formobject" "Learn more about the FormObject"'})]})}function j(t={}){const{wrapper:e}={...(0,l.R)(),...t.components};return e?(0,s.jsx)(e,{...t,children:(0,s.jsx)(h,{...t})}):h(t)}},1731:(t,e,n)=>{n.d(e,{A:()=>i});const i=n.p+"assets/images/OptionObject-6ff9bbbd08b8bf22f873b65fa1a68390.png"},8453:(t,e,n)=>{n.d(e,{R:()=>r,x:()=>d});var i=n(6540);const s={},l=i.createContext(s);function r(t){const e=i.useContext(l);return i.useMemo((function(){return"function"==typeof t?t(e):{...e,...t}}),[e,t])}function d(t){let e;return e=t.disableParentContext?"function"==typeof t.components?t.components(s):t.components||s:r(t.components),i.createElement(l.Provider,{value:e},t.children)}}}]);