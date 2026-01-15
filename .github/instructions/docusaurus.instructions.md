---
applyTo: "docs/**"
---

# Docusaurus Documentation Site Guidelines

This directory contains the public documentation site for the RarelySimple.AvatarScriptLink project, which provides open-source libraries for building SOAP web services compatible with Netsmart Technologies' myAvatar CareRecord using ScriptLink. The documentation site is built using Docusaurus, a popular static site generator for creating documentation websites.

## Directory Structure
- `blog`: Contains blog posts related to the project.
- `docs`: Contains detailed documentation and guides for using the ScriptLink libraries.
- `src`: Contains the source code for custom components, CSS, and other pages of the documentation site.
- `static`: Contains static assets such as images, fonts, and other resources used in the documentation site.
- `versioned_docs`: Contains versioned documentation for different releases of the ScriptLink libraries.
- `versioned_sidebars`: Contains versioned sidebars for navigating the documentation site.

## Documentation Content

The documentation site includes various types of content to help users understand and utilize the ScriptLink libraries effectively:

- **Getting Started Guides**: Step-by-step instructions for setting up and using the ScriptLink libraries.
- **API Reference**: Detailed documentation of the classes, methods, and properties available in the ScriptLink libraries.
- **Tutorials**: In-depth tutorials covering common use cases and scenarios for integrating with myAvatar using ScriptLink.
- **Blog Posts**: Articles discussing updates, best practices, and other relevant topics related to the ScriptLink project.
- **Versioned Documentation**: Documentation for different versions of the ScriptLink libraries, allowing users to access information relevant to the version they are using.

## Best Practices

### Frontmatter & Metadata
- Include frontmatter in all markdown files with: `title`, `description`, `keywords`, `sidebar_position`, and `tags`
- Use consistent metadata across documents to improve SEO and discoverability
- Frontmatter example:
  ```yaml
  ---
  title: Getting Started
  description: Learn how to get started with ScriptLink
  keywords: [setup, installation, guide]
  sidebar_position: 1
  tags: [tutorial, getting-started]
  ---
  ```

### File Organization
- Use logical folder structure that mirrors your sidebar configuration
- Name files in lowercase with hyphens (kebab-case): `getting-started.md`, `api-reference.md`
- Use `sidebar_position` for explicit ordering instead of relying on alphabetical sorting
- Keep related content in dedicated subdirectories

### Link Management
- Use relative links for internal cross-references: `[Link text](../path/to/file.md)`
- For MDX files, use proper syntax: `[Link text](../path/to/file.mdx)`
- Avoid absolute URLs for internal documentation links
- Test all links before committing to catch broken references

### Content Best Practices
- Keep markdown clean and avoid deeply nested structures
- Use proper heading hierarchy: start with h2 (`##`), reserve h1 for page titles
- Leverage Docusaurus admonitions for callouts:
  - `:::note` for general information
  - `:::warning` for important cautions
  - `:::info` for additional context
  - `:::danger` for critical warnings
  - `:::tip` for helpful suggestions
- Include a table of contents for longer documents by ensuring proper heading hierarchy
- Write clear, concise descriptions for each section

### Code Examples
- Specify language in code blocks for proper syntax highlighting: ````csharp`, ````javascript`, ````xml`
- Include practical, runnable examples where applicable
- Mark code blocks with language identifiers: `csharp`, `xml`, `bash`, etc.
- Keep examples focused and easy to understand

### Version Management
- Clearly document version-specific information
- Keep versioned docs in sync when making updates to unreleased documentation
- Use version tags to indicate which versions a feature applies to
- Maintain backward compatibility information in appropriate sections

### Blog Posts
- Include proper frontmatter: `title`, `authors`, `tags`, `date`
- Use filename format: `YYYY-MM-DD-post-title.md` or `YYYY-MM-DD-post-title/index.md`
- Include a brief description or summary for blog archives
- Use author profiles from `authors.yml` for consistent authorship

### Build & Testing
- Run `npm run start` locally to preview changes before committing
- Test all interactive components and internal links during local preview
- Run `npm run build` to verify the site builds successfully
- Check for missing images and broken links in the build output
- Test documentation site on multiple viewports to ensure responsive design

### Documentation Maintenance
- Review and update documentation when code changes are released
- Keep examples and code snippets synchronized with actual implementation
- Remove outdated or deprecated information promptly
- Document breaking changes clearly in release notes and migration guides
