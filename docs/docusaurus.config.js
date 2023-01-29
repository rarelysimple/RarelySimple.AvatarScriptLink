// @ts-check
// Note: type annotations allow type checking and IDEs autocompletion

const lightCodeTheme = require('prism-react-renderer/themes/github');
const darkCodeTheme = require('prism-react-renderer/themes/dracula');

/** @type {import('@docusaurus/types').Config} */
const config = {
  title: 'AvatarScriptLink by RarelySimple',
  tagline: 'Accelating ScriptLink Development for Netsmart myAvatar',
  url: 'https://scriptlink.rarelysimple.com/',
  baseUrl: '/',
  onBrokenLinks: 'throw',
  onBrokenMarkdownLinks: 'warn',
  favicon: 'img/favicon.ico',

  organizationName: 'rarelysimple',
  projectName: 'RarelySimple.AvatarScriptLink',

  i18n: {
    defaultLocale: 'en',
    locales: ['en'],
  },

  presets: [
    [
      'classic',
      /** @type {import('@docusaurus/preset-classic').Options} */
      ({
        docs: {
          sidebarPath: require.resolve('./sidebars.js'),
          // Remove this to remove the "edit this page" links.
          editUrl:
            'https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/',
        },
        blog: false,
        // blog: {
        //   showReadingTime: true,
        //   // Remove this to remove the "edit this page" links.
        //   editUrl:
        //     'https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/tree/main/docs/',
        // },
        theme: {
          customCss: require.resolve('./src/css/custom.css'),
        },
      }),
    ],
  ],

  themeConfig:
    /** @type {import('@docusaurus/preset-classic').ThemeConfig} */
    ({
      navbar: {
        title: 'RarelySimple.AvatarScriptLink',
        logo: {
          alt: 'My Site Logo Placeholder',
          src: 'img/logo.svg',
        },
        items: [
          {
            type: 'doc',
            docId: 'dotnet/intro',
            position: 'left',
            label: '.NET',
          },
        //   {to: '/blog', label: 'Blog', position: 'left'},
          {
            href: 'https://github.com/rarelysimple/RarelySimple.AvatarScriptLink',
            label: 'GitHub',
            position: 'right',
          },
        ],
      },
      footer: {
        style: 'dark',
        links: [
            {
              title: 'Docs',
              items: [
                  {
                    label: 'Introduction',
                    to: '/docs/dotnet/intro',
                  },
                  {
                    label: 'Data Model',
                    to: '/docs/dotnet/data-model',
                  },
                  {
                    label: 'License',
                    href: 'https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/blob/master/LICENSE',
                  },
              ],
            },
          {
            title: 'Community',
            items: [
                {
                    label: 'Code of Conduct',
                    href: 'https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/blob/main/CODE_OF_CONDUCT.md'
                },
                {
                  label: 'GitHub',
                  href: 'https://github.com/rarelysimple/RarelySimple.AvatarScriptLink',
                },
                {
                    label: 'NuGet',
                    href: 'https://www.nuget.org/packages/RarelySimple.AvatarScriptLink'
                }
            ],
          },
          {
            title: 'More',
            items: [
                {
                  label: 'Report an Issue',
                  href: 'https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues',
                },
                {
                  label: 'Feature Request',
                  href: 'https://github.com/rarelysimple/RarelySimple.AvatarScriptLink/issues',
                },
            ],
          },
        ],
        copyright: `Copyright © ${new Date().getFullYear()} Scott Olson Jr. Built with Docusaurus.`,
      },
      prism: {
        theme: lightCodeTheme,
        darkTheme: darkCodeTheme,
      },
    }),
};

module.exports = config;
