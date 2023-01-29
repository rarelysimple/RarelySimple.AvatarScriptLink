import React from 'react';
import clsx from 'clsx';
import styles from './styles.module.css';
import Before from './helloworld.cs.before.md';
import After from './helloworld.cs.after.md';

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
                        <Before />
                    </div>
                </div>
                <div className='row'>
                    <div className='col col--3'>
                        <h3>After</h3>
                        <p>Afterwards, you can construct your return OptionObject directly from the object received.</p>
                    </div>
                    <div className='col col--9'>
                        <After />
                    </div>
                </div>
            </div>
        </section>
    );
}