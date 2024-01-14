import React from 'react';
import clsx from 'clsx';
import Link from '@docusaurus/Link';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import Layout from '@theme/Layout';
import Head from '@docusaurus/Head';
import HomepageFeatures from '@site/src/components/HomepageFeatures';
import HomepageHelloWorld from '@site/src/components/HomepageHelloWorld';
import HomepageTestimonial from '@site/src/components/HomepageTestimonial';

import styles from './index.module.css';

function HomepageHeader() {
  const {siteConfig} = useDocusaurusContext();
  return (
    <header className={clsx('hero hero--primary', styles.heroBanner)}>
      <div className="container">
        <h1 className="hero__title">Accelerate your myAvatar ScriptLink development.</h1>
        <p className="hero__subtitle">Get started today with .NET or .NET Framework.</p>
        <div className={styles.buttons}>
          <Link
            className="button button--secondary button--lg heroButton"
            to="/docs/dotnet/tutorials/hello-world-dotnet">
            .NET
          </Link>
          <Link
            className="button button--secondary button--lg heroButton"
            to="/docs/dotnet/tutorials/hello-world-dotnet-framework">
            .NET Framework
          </Link>
        </div>
      </div>
    </header>
  );
}

export default function Home() {
  const {siteConfig} = useDocusaurusContext();
  return (
    <Layout
    //   title={`${siteConfig.title}`}
      description="RarelySimple.AvatarScriptLink helps accelerate ScriptLink development for Netsmart myAvatar.">
      <Head>
        <meta property="og:image" content={`${siteConfig.url}/img/AvatarScriptLink.png`} />
      </Head>
      <HomepageHeader />
      <main>
        <HomepageHelloWorld />
      </main>
    </Layout>
  );
}
