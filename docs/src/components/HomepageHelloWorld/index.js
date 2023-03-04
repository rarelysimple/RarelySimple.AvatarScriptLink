import React from 'react';
import styles from './styles.module.css';
import CodeBlock from '@theme/CodeBlock';

export default function HomepageHelloWorld() {
    return (
        <section className={styles.example}>
            <div className='container'>
                <div className='row'>
                    <div className='col'>
                        <h2 className='text--center'>Hello, World!</h2>
                        <p className='text--center'>AvatarScriptLink.NET simplifies common use cases as demonstrated by this Hello, World! example.</p>
                    </div>
                </div>
                <div className='row'>
                    <div className='col col--3'>
                        <h3>Before</h3>
                        <p>Before AvatarScriptLink.NET you would have to construct your return OptionObject manually and often make changes directly to the incoming OptionObject.</p>
                    </div>
                    <div className='col col--9'>
                        <CodeBlock
                            language='csharp'>
                            {`[WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameters)
{
    OptionObject returnOptionObject = new OptionObject();

    returnOptionObject.EntityID = optionObject.EntityID;
    returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
    returnOptionObject.Facility = optionObject.Facility;
    returnOptionObject.Forms = optionObject.Forms;
    returnOptionObject.NamespaceName = optionObject.NamespaceName;
    returnOptionObject.OptionId = optionObject.OptionId;
    returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
    returnOptionObject.OptionUserId = optionObject.OptionUserId;
    returnOptionObject.ParentNamespace = optionObject.ParentNamespace;
    returnOptionObject.ServerName = optionObject.ServerName;
    returnOptionObject.SystemCode = optionObject.SystemCode;
    returnOptionObject.SessionToken = optionObject.SessionToken;

    // Do work here on returnOptionObject and prepare for return

    returnOptionObject.ErrorCode = 3;
    returnOptionObject.ErrorMesg = "Informational message...";

    return returnOptionObject;
}`}
                        </CodeBlock>
                    </div>
                </div>
                <div className='row'>
                    <div className='col col--3'>
                        <h3>After</h3>
                        <p>Afterwards, you can construct your working copy of the OptionObject directly from the object received.</p>
                        <p>You can also prepare the OptionObject for return as well as set the ErrorCode and ErrorMesg in a single command.</p>
                    </div>
                    <div className='col col--9'>
                        <CodeBlock
                            language='csharp'>
                            {`[WebMethod]
public OptionObject2015 RunScript(OptionObject2015 incomingOptionObject, string parameters)
{
    OptionObject2015 optionObject = incomingOptionObject.Clone();
    // Do work here on the clone of incoming OptionObject to retain original request for later comparison or restore
    return optionObject.ToReturnOptionObject(ErrorCode.Informational, "Informational message...");
}`}
                        </CodeBlock>
                    </div>
                </div>
            </div>
        </section>
    );
}