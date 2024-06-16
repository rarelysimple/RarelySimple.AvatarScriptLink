"use strict";(self.webpackChunkmy_website=self.webpackChunkmy_website||[]).push([[9264],{2978:(e,t,n)=>{n.r(t),n.d(t,{assets:()=>a,contentTitle:()=>d,default:()=>b,frontMatter:()=>o,metadata:()=>c,toc:()=>h});var i=n(5893),s=n(1151),l=n(4866),r=n(5162);const o={title:"OptionObject2015",image:"./OptionObject2015.png",sidebar_position:1},d="OptionObject2015",c={id:"dotnet/data-model/optionobject2015",title:"OptionObject2015",description:"The OptionObject2015 holds all of the content of and metadata describing the calling myAvatar form.",source:"@site/docs/dotnet/data-model/optionobject2015.mdx",sourceDirName:"dotnet/data-model",slug:"/dotnet/data-model/optionobject2015",permalink:"/docs/dotnet/data-model/optionobject2015",draft:!1,unlisted:!1,editUrl:"https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/docs/dotnet/data-model/optionobject2015.mdx",tags:[],version:"current",sidebarPosition:1,frontMatter:{title:"OptionObject2015",image:"./OptionObject2015.png",sidebar_position:1},sidebar:"dotnetSidebar",previous:{title:"Data Model",permalink:"/docs/dotnet/data-model/"},next:{title:"FormObject",permalink:"/docs/dotnet/data-model/formobject"}},a={image:n(6423).Z},h=[{value:"Properties",id:"properties",level:2},{value:"Methods",id:"methods",level:2},{value:"Examples",id:"examples",level:2},{value:"Detailed Class Diagram",id:"detailed-class-diagram",level:2}];function j(e){const t={a:"a",admonition:"admonition",code:"code",h1:"h1",h2:"h2",li:"li",mermaid:"mermaid",p:"p",pre:"pre",table:"table",tbody:"tbody",td:"td",th:"th",thead:"thead",tr:"tr",ul:"ul",...(0,s.a)(),...e.components};return(0,i.jsxs)(i.Fragment,{children:[(0,i.jsx)(t.h1,{id:"optionobject2015",children:"OptionObject2015"}),"\n",(0,i.jsx)(t.p,{children:"The OptionObject2015 holds all of the content of and metadata describing the calling myAvatar form.\nAvatarScriptLink.NET adds several utility methods to assist with handlings these objects."}),"\n",(0,i.jsxs)(t.admonition,{title:"Legacy Support",type:"note",children:[(0,i.jsx)(t.p,{children:"Earlier versions of this object are still supported and available for use in your projects."}),(0,i.jsxs)(t.ul,{children:["\n",(0,i.jsx)(t.li,{children:(0,i.jsx)(t.a,{href:"../optionobject2",children:"OptionObject2"})}),"\n",(0,i.jsx)(t.li,{children:(0,i.jsx)(t.a,{href:"../optionobject",children:"OptionObject"})}),"\n"]})]}),"\n",(0,i.jsx)(t.mermaid,{value:'classDiagram\ndirection LR\nclass OptionObject2015 {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n    +AddFormObject(FormObject)\n    +AddFormObject(string, bool)\n    +AddRowObject(string, RowObject)\n    +Clone() OptionObject2015\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +DisableAllFieldObjects()\n    +DisableAllFieldObjects(List~string~)\n    +Equals(OptionObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId(string) strings\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetMultipleIterationStatus(string) bool\n    +GetParentRowId(string) string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsFormPresent(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(List~string~)\n    +SetEnabledField(string)\n    +SetEnabledFields(List~string~)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(List~string~)\n    +SetOptionalField(string)\n    +SetOptionalFields(List~string~)\n    +SetRequiredField(string)\n    +SetRequiredFields(List~string~)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(List~string~)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToOptionObject() OptionObject\n    +ToOptionObject2() OptionObject2\n    +ToOptionObject2015() OptionObject2015\n    +ToReturnOptionObject() OptionObject2015\n    +ToReturnOptionObject(bool, string) OptionObject2015\n    +ToXml() string\n}\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nOptionObject2015 "1" --o "*" FormObject : Forms\n\nclick FormObject href "./formobject" "Learn more about the FormObject"'}),"\n",(0,i.jsx)(t.h2,{id:"properties",children:"Properties"}),"\n",(0,i.jsxs)(t.table,{children:[(0,i.jsx)(t.thead,{children:(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.th,{style:{textAlign:"left"},children:"Property"}),(0,i.jsx)(t.th,{style:{textAlign:"left"},children:"Description"})]})}),(0,i.jsxs)(t.tbody,{children:[(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"EntityID"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The unique Id of the selected entity. I.e., Patient, Staff, or User."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"EpisodeNumber"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The selected Episode Number. Will be null if the form is non-episodic."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ErrorCode"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Informs myAvatar of the outcome of the ScriptLink API call."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ErrorMesg"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Message to display to user with certain error codes."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Facility"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The Facility Id the user is currently working in."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Forms"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["List of myAvatar form sections including rows and fields. See ",(0,i.jsx)(t.a,{href:"../formobject",children:"FormObject"}),"."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"NamespaceName"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The Namespace the user is currently working in."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"OptionId"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The unique Id of the form that sent this request."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"OptionStaffId"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The Staff Id assigned to the logged on user. May be null/empty if not associated with a Practitioner."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"OptionUserId"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The User Id of the logged on user."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ParentNamespace"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The Parent Namespace of the Namespace the user is currently logged into."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ServerName"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The server the request was submitted from."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SystemCode"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The System Code the user is currently working in."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SessionToken"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"The SessionToken that can be used to authenticate with Avatar Web Services."})]})]})]}),"\n",(0,i.jsx)(t.h2,{id:"methods",children:"Methods"}),"\n",(0,i.jsx)(t.p,{children:"The following methods are available on the OptionObject2015 to assist with common tasks."}),"\n",(0,i.jsxs)(t.table,{children:[(0,i.jsx)(t.thead,{children:(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.th,{style:{textAlign:"left"},children:"Method"}),(0,i.jsx)(t.th,{style:{textAlign:"left"},children:"Description"})]})}),(0,i.jsxs)(t.tbody,{children:[(0,i.jsxs)(t.tr,{children:[(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["AddFormObject(",(0,i.jsx)(t.a,{href:"../formobject",children:"FormObject"}),")"]}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Adds a ",(0,i.jsx)(t.a,{href:"../formobject",children:"FormObject"})," to the OptionObject2015."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"AddFormObject(string, bool)"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Creates a ",(0,i.jsx)(t.a,{href:"../formobject",children:"FormObject"})," with specified FormId and adds to the OptionObject2015. The second parameter specifies whether the ",(0,i.jsx)(t.a,{href:"../formobject",children:"FormObject"})," should be flagged as a Multiple Iteration form."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["AddRowObject(string, ",(0,i.jsx)(t.a,{href:"../rowobject",children:"RowObject"}),")"]}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Adds a ",(0,i.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," to the ",(0,i.jsx)(t.a,{href:"../formobject",children:"FormObject"})," with the specified FormId."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Builder()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Initializes a builder for constructing a OptionObject2015."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Clone()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Clones the OptionObject2015."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["DeleteRowObject(",(0,i.jsx)(t.a,{href:"../rowobject",children:"RowObject"}),")"]}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Marks a ",(0,i.jsx)("see",{cref:"RowObject"})," for deletion."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"DeleteRowObject(string)"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Marks a ",(0,i.jsx)("see",{cref:"RowObject"})," for deletion by specified RowId."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"DisableAllFieldObjects()"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets all ",(0,i.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," as disabled."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"DisableAllFieldObjects(List of string)"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets all ",(0,i.jsx)(t.a,{href:"../fieldobject",children:"FieldObjects"})," as disabled except for any listed to be excluded."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Equals(OptionObjectBase)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Used to compare two OptionObject2015 to determine if they are equal. Returns bool."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Equals(object)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Used to compare OptionObject2015 to an object to determine if they are equal. Returns bool."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"GetCurrentRowId(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the CurrentRow RowId of the form matching the FormId."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"GetFieldValue(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the first value of the field matching the Field Number."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"GetFieldValue(string, string, string)"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns the value of the ",(0,i.jsx)("see",{cref:"FieldObject"})," matching the Field Number on the specified ",(0,i.jsx)(t.a,{href:"../formobject",children:"FormObject"})," and ",(0,i.jsx)(t.a,{href:"../rowobject",children:"RowObject"}),"."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"GetFieldValues(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the values of the field matching the Field Number."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"GetHashCode()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Overrides the GetHashCode method for a OptionObjectBase."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"GetMultipleIterationStatus(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the Multiple Iteration Status of the form matching the FormId."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"GetParentRowId(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns the CurrentRow ParentRowId of the form matching the FormId."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Initialize()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Initializes an empty OptionObject2015."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldEnabled(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns whether the specified field is enabled."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldLocked(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns whether the specified field is locked."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldModified(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns whether the specified field is modified."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldPresent(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns whether the specified field is present."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"IsFieldRequired(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns whether the specified field is required."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"IsFormPresent(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns whether the specified form is present."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"IsRowMarkedForDeletion(string)"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Returns whether the specified ",(0,i.jsx)(t.a,{href:"../rowobject",children:"RowObject"})," is marked for deletion."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"IsRowPresent(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns whether the specified row is present"})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetDisabledField(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Sets the specified field as disabled."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetDisabledFields(List of string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Sets the specified fields as disabled."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetEnabledField(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Sets the specified field as enabled."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetEnabledFields(List of string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Sets the specified fields as enabled."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetFieldValue(string, string)"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the FieldValue of a ",(0,i.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in the OptionObject2015 on the first form's CurrentRow."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetFieldValue(string, string, string, string)"}),(0,i.jsxs)(t.td,{style:{textAlign:"left"},children:["Sets the FieldValue of a ",(0,i.jsx)(t.a,{href:"../fieldobject",children:"FieldObject"})," in the OptionObject2015."]})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetLockedField(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Sets the specified field as locked."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetLockedFields(List of string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Sets the specified fields as disabled."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetOptionalField(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Set the specified field as not required and enables if disabled."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetOptionalFields(List of string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Set the specified fields as not required and enables if disabled."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetRequiredField(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Sets the specified field as required."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetRequiredFields(List of string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Sets the specified fields as required."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetUnlockedField(string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Set the specified field as unlocked."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"SetUnlockedFields(List of string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Set the specified fields as unlocked."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToHtmlString()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns a string with all of the contents of the OptionObject2015 formatted in HTML."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToHtmlString(bool)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns a string with all of the contents of the OptionObject2015 formatted in HTML. Passing true will include HTML header tags."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToJson()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns a string with all of the contents of the OptionObject2015 formatted as JSON."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToOptionObject()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Transforms the OptionObject2015 to an OptionObject."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToOptionObject2()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Transforms the OptionObject2015 as an OptionObject2."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToOptionObject2015()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Creates a clone of the OptionObject2015."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToReturnOptionObject()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Creates an OptionObject2015 with the minimum information required to return."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToReturnOptionObject(int, string)"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Creates an OptionObject2015 with the minimum information required to return plus the provided Error Code and Message."})]}),(0,i.jsxs)(t.tr,{children:[(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"ToXml()"}),(0,i.jsx)(t.td,{style:{textAlign:"left"},children:"Returns a string with all of the contents of the OptionObject2015 formatted as XML."})]})]})]}),"\n",(0,i.jsx)(t.h2,{id:"examples",children:"Examples"}),"\n",(0,i.jsx)(t.p,{children:"The following code shows how to use OptionObject2015 to construct a web service compatible with myAvatar."}),"\n",(0,i.jsxs)(l.Z,{groupId:"syntax",children:[(0,i.jsx)(r.Z,{value:"cs",label:"C#",children:(0,i.jsx)(t.pre,{children:(0,i.jsx)(t.code,{className:"language-cs",metastring:'title="MyScriptLinkDemoService.asmx"',children:'using RarelySimple.AvatarScriptLink.Objects;\nusing System.Web.Services;\n\nnamespace ScriptLinkDemo.Web.Api\n{\n    /// <summary>\n    /// Summary description for MyScriptLinkDemoService\n    /// </summary>\n    [WebService(Namespace = "http://tempuri.org/")]\n    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]\n    [System.ComponentModel.ToolboxItem(false)]\n    public class MyScriptLinkDemoService : System.Web.Services.WebService\n    {\n        [WebMethod]\n        public string GetVersion()\n        {\n            return "v.0.0.1";\n        }\n\n        [WebMethod]\n        public OptionObject2015 RunScript(OptionObject2015 optionObject2015, string parameters)\n        {\n            return optionObject2015.ToReturnOptionObject(ErrorCode.Alert, "Hello, World!");\n        }\n    }\n}\n'})})}),(0,i.jsx)(r.Z,{value:"vb",label:"Visual Basic",children:(0,i.jsx)(t.pre,{children:(0,i.jsx)(t.code,{className:"language-vb",metastring:'title="MyScriptLinkDemoService.asmx"',children:'Imports System.ComponentModel\nImports System.Web.Services\nImports RarelySimple.AvatarScriptLink.Objects\n\n<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _\n<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _\n<ToolboxItem(False)> _\nPublic Class MyScriptLinkDemoService\n    Inherits System.Web.Services.WebService\n\n    <WebMethod()>\n    Public Function GetVersion() As String\n        Return "v.0.0.1"\n    End Function\n\n    <WebMethod()>\n    Public Function RunScript(ByVal optionObject2015 As OptionObject2015, ByVal parameters As String) As OptionObject2015\n        Return optionObject2015.ToReturnOptionObject(ErrorCode.Alert, "Hello, World!")\n    End Function\n\nEnd Class\n'})})})]}),"\n",(0,i.jsx)(t.h2,{id:"detailed-class-diagram",children:"Detailed Class Diagram"}),"\n",(0,i.jsx)(t.mermaid,{value:'classDiagram\nclass OptionObject2015 {\n    +Clone() OptionObject2015\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToOptionObject() OptionObject\n    +ToOptionObject2() OptionObject2\n    +ToOptionObject2015() OptionObject2015\n    +ToReturnOptionObject() OptionObject2015\n    +ToReturnOptionObject(bool, string) OptionObject2015\n    +ToXml() string\n}\n\nclass OptionObjectBase {\n    +string EntityID\n    +double EpisodeNumber\n    +double ErrorCode\n    +string ErrorMesg\n    +string Facility\n    +List~FormObject~ Forms\n    +string NamespaceName\n    +string OptionId\n    +string OptionStaffId\n    +string OptionUserId\n    +string ParentNamespace\n    +string ServerName\n    +string SystemCode\n    +string SessionToken\n    +AddFormObject(FormObject)\n    +AddFormObject(string, bool)\n    +AddRowObject(string, RowObject)\n    +Clone() OptionObjectBase\n    +DeleteRowObject(RowObject)\n    +DeleteRowObject(string)\n    +DisableAllFieldObjects()\n    +DisableAllFieldObjects(List~string~)\n    +Equals(OptionObjectBase) bool\n    +Equals(object) bool\n    +GetCurrentRowId(string) strings\n    +GetFieldValue(string) string\n    +GetFieldValue(string, string, string) string\n    +GetFieldValues(string) List~string~\n    +GetHashCode() int\n    +GetMultipleIterationStatus(string) bool\n    +GetParentRowId(string) string\n    +IsFieldEnabled(string) bool\n    +IsFieldLocked(string) bool\n    +IsFieldModified(string) bool\n    +IsFieldPresent(string) bool\n    +IsFieldRequired(string) bool\n    +IsFormPresent(string) bool\n    +IsRowMarkedForDeletion(string) bool\n    +IsRowPresent(string) bool\n    +SetDisabledField(string)\n    +SetDisabledFields(List~string~)\n    +SetEnabledField(string)\n    +SetEnabledFields(List~string~)\n    +SetFieldValue(string, string)\n    +SetFieldValue(string, string, string, string)\n    +SetLockedField(string)\n    +SetLockedFields(List~string~)\n    +SetOptionalField(string)\n    +SetOptionalFields(List~string~)\n    +SetRequiredField(string)\n    +SetRequiredFields(List~string~)\n    +SetUnlockedField(string)\n    +SetUnlockedFields(List~string~)\n    +ToHtmlString() string\n    +ToHtmlString(bool) string\n    +ToJson() string\n    +ToOptionObject()* OptionObject\n    +ToOptionObject2()* OptionObject2\n    +ToOptionObject2015()* OptionObject2015\n    +ToReturnOptionObject() OptionObjectBase\n    +ToReturnOptionObject(double, string) OptionObjectBase\n    +ToXml() string\n    -AreBothEmpty(List~FormObject~, List~FormObject~)$ bool\n    -AreBothNull(List~FormObject~, List~FormObject~)$ bool\n    -AreFormsEqual(List~FormObject~, List~FormObject~)$ bool\n}\n<<abstract>> OptionObjectBase\n\nclass IOptionObject2015 {\n    string SessionToken\n}\n<<interface>> IOptionObject2015\n\nclass IOptionObject2 {\n    string NamespaceName\n    string ParentNamespace\n    string ServerName\n}\n<<interface>> IOptionObject2\n\nclass IOptionObject {\n    string EntityID\n    double EpisodeNumber\n    double ErrorCode\n    string ErrorMesg\n    string Facility\n    List~FormObject~ Forms\n    string OptionId\n    string OptionStaffId\n    string OptionUserId\n    string SystemCode\n}\n<<interface>> IOptionObject\n\nclass FormObject {\n    +RowObject CurrentRow\n    +string FormID\n    +bool MultipleIteration\n    +List~RowObject~ OtherRows\n}\n\nclass IEquatable~OptionObjectBase~\n<<interface>> IEquatable~OptionObjectBase~\n\nOptionObjectBase "1" --o "*" FormObject : Forms\n\nOptionObject2015 --|> OptionObjectBase : inherits\nOptionObjectBase --|> IEquatable~OptionObjectBase~ : inherits\nOptionObjectBase --|> IOptionObject2015 : inherits\nIOptionObject2015 --|> IOptionObject2 : inherits\nIOptionObject2 --|> IOptionObject : inherits\n\nclick FormObject href "./formobject" "Learn more about the FormObject"'})]})}function b(e={}){const{wrapper:t}={...(0,s.a)(),...e.components};return t?(0,i.jsx)(t,{...e,children:(0,i.jsx)(j,{...e})}):j(e)}},5162:(e,t,n)=>{n.d(t,{Z:()=>r});n(7294);var i=n(6905);const s={tabItem:"tabItem_Ymn6"};var l=n(5893);function r(e){let{children:t,hidden:n,className:r}=e;return(0,l.jsx)("div",{role:"tabpanel",className:(0,i.Z)(s.tabItem,r),hidden:n,children:t})}},4866:(e,t,n)=>{n.d(t,{Z:()=>A});var i=n(7294),s=n(6905),l=n(2466),r=n(6550),o=n(469),d=n(1980),c=n(7392),a=n(812);function h(e){return i.Children.toArray(e).filter((e=>"\n"!==e)).map((e=>{if(!e||(0,i.isValidElement)(e)&&function(e){const{props:t}=e;return!!t&&"object"==typeof t&&"value"in t}(e))return e;throw new Error(`Docusaurus error: Bad <Tabs> child <${"string"==typeof e.type?e.type:e.type.name}>: all children of the <Tabs> component should be <TabItem>, and every <TabItem> should have a unique "value" prop.`)}))?.filter(Boolean)??[]}function j(e){const{values:t,children:n}=e;return(0,i.useMemo)((()=>{const e=t??function(e){return h(e).map((e=>{let{props:{value:t,label:n,attributes:i,default:s}}=e;return{value:t,label:n,attributes:i,default:s}}))}(n);return function(e){const t=(0,c.l)(e,((e,t)=>e.value===t.value));if(t.length>0)throw new Error(`Docusaurus error: Duplicate values "${t.map((e=>e.value)).join(", ")}" found in <Tabs>. Every value needs to be unique.`)}(e),e}),[t,n])}function b(e){let{value:t,tabValues:n}=e;return n.some((e=>e.value===t))}function g(e){let{queryString:t=!1,groupId:n}=e;const s=(0,r.k6)(),l=function(e){let{queryString:t=!1,groupId:n}=e;if("string"==typeof t)return t;if(!1===t)return null;if(!0===t&&!n)throw new Error('Docusaurus error: The <Tabs> component groupId prop is required if queryString=true, because this value is used as the search param name. You can also provide an explicit value such as queryString="my-search-param".');return n??null}({queryString:t,groupId:n});return[(0,d._X)(l),(0,i.useCallback)((e=>{if(!l)return;const t=new URLSearchParams(s.location.search);t.set(l,e),s.replace({...s.location,search:t.toString()})}),[l,s])]}function x(e){const{defaultValue:t,queryString:n=!1,groupId:s}=e,l=j(e),[r,d]=(0,i.useState)((()=>function(e){let{defaultValue:t,tabValues:n}=e;if(0===n.length)throw new Error("Docusaurus error: the <Tabs> component requires at least one <TabItem> children component");if(t){if(!b({value:t,tabValues:n}))throw new Error(`Docusaurus error: The <Tabs> has a defaultValue "${t}" but none of its children has the corresponding value. Available values are: ${n.map((e=>e.value)).join(", ")}. If you intend to show no default tab, use defaultValue={null} instead.`);return t}const i=n.find((e=>e.default))??n[0];if(!i)throw new Error("Unexpected error: 0 tabValues");return i.value}({defaultValue:t,tabValues:l}))),[c,h]=g({queryString:n,groupId:s}),[x,u]=function(e){let{groupId:t}=e;const n=function(e){return e?`docusaurus.tab.${e}`:null}(t),[s,l]=(0,a.Nk)(n);return[s,(0,i.useCallback)((e=>{n&&l.set(e)}),[n,l])]}({groupId:s}),f=(()=>{const e=c??x;return b({value:e,tabValues:l})?e:null})();(0,o.Z)((()=>{f&&d(f)}),[f]);return{selectedValue:r,selectValue:(0,i.useCallback)((e=>{if(!b({value:e,tabValues:l}))throw new Error(`Can't select invalid tab value=${e}`);d(e),h(e),u(e)}),[h,u,l]),tabValues:l}}var u=n(2389);const f={tabList:"tabList__CuJ",tabItem:"tabItem_LNqP"};var p=n(5893);function m(e){let{className:t,block:n,selectedValue:i,selectValue:r,tabValues:o}=e;const d=[],{blockElementScrollPositionUntilNextRender:c}=(0,l.o5)(),a=e=>{const t=e.currentTarget,n=d.indexOf(t),s=o[n].value;s!==i&&(c(t),r(s))},h=e=>{let t=null;switch(e.key){case"Enter":a(e);break;case"ArrowRight":{const n=d.indexOf(e.currentTarget)+1;t=d[n]??d[0];break}case"ArrowLeft":{const n=d.indexOf(e.currentTarget)-1;t=d[n]??d[d.length-1];break}}t?.focus()};return(0,p.jsx)("ul",{role:"tablist","aria-orientation":"horizontal",className:(0,s.Z)("tabs",{"tabs--block":n},t),children:o.map((e=>{let{value:t,label:n,attributes:l}=e;return(0,p.jsx)("li",{role:"tab",tabIndex:i===t?0:-1,"aria-selected":i===t,ref:e=>d.push(e),onKeyDown:h,onClick:a,...l,className:(0,s.Z)("tabs__item",f.tabItem,l?.className,{"tabs__item--active":i===t}),children:n??t},t)}))})}function O(e){let{lazy:t,children:n,selectedValue:s}=e;const l=(Array.isArray(n)?n:[n]).filter(Boolean);if(t){const e=l.find((e=>e.props.value===s));return e?(0,i.cloneElement)(e,{className:"margin-top--md"}):null}return(0,p.jsx)("div",{className:"margin-top--md",children:l.map(((e,t)=>(0,i.cloneElement)(e,{key:t,hidden:e.props.value!==s})))})}function y(e){const t=x(e);return(0,p.jsxs)("div",{className:(0,s.Z)("tabs-container",f.tabList),children:[(0,p.jsx)(m,{...t,...e}),(0,p.jsx)(O,{...t,...e})]})}function A(e){const t=(0,u.Z)();return(0,p.jsx)(y,{...e,children:h(e.children)},String(t))}},6423:(e,t,n)=>{n.d(t,{Z:()=>i});const i=n.p+"assets/images/OptionObject2015-6ae774a70652472f1925264d38020b4d.png"},1151:(e,t,n)=>{n.d(t,{Z:()=>o,a:()=>r});var i=n(7294);const s={},l=i.createContext(s);function r(e){const t=i.useContext(l);return i.useMemo((function(){return"function"==typeof e?e(t):{...t,...e}}),[t,e])}function o(e){let t;return t=e.disableParentContext?"function"==typeof e.components?e.components(s):e.components||s:r(e.components),i.createElement(l.Provider,{value:t},e.children)}}}]);