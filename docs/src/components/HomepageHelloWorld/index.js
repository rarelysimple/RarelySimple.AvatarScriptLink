import React from 'react';
import clsx from 'clsx';
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
                        <p>Before AvatarScriptLink.NET you would have to construct your return OptionObject manually.</p>
                    </div>
                    <div className='col col--9'>
                        <CodeBlock
                            language='csharp'>
                            {`[WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameters)
{
    OptionObject returnOptionObject = new OptionObject();

    returnOptionObject.ErrorCode = 3;
    returnOptionObject.ErrorMesg = "Hello, World!";

    returnOptionObject.EntityID = optionObject.EntityID;
    returnOptionObject.EpisodeNumber = optionObject.EpisodeNumber;
    returnOptionObject.Facility = optionObject.Facility;
    returnOptionObject.OptionId = optionObject.OptionId;
    returnOptionObject.OptionStaffId = optionObject.OptionStaffId;
    returnOptionObject.OptionUserId = optionObject.OptionUserId;
    returnOptionObject.SystemCode = optionObject.SystemCode;

    return returnOptionObject;
}`}
                        </CodeBlock>
                    </div>
                </div>
                <div className='row'>
                    <div className='col col--3'>
                        <h3>After</h3>
                        <p>Afterwards, you can construct your return OptionObject directly from the object received.</p>
                    </div>
                    <div className='col col--9'>
                        <CodeBlock
                            language='csharp'>
                            {`[WebMethod]
public OptionObject2015 RunScript(OptionObject2015 optionObject, string parameters)
{
    return optionObject.ToReturnOptionObject(ErrorCode.Alert, "Hello, World!");
}`}
                        </CodeBlock>
                    </div>
                </div>
            </div>
        </section>
    );
}