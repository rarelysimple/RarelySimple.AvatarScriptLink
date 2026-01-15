# General Copilot Custom Instructions

## About Project

This project provides a open-source libraries for building SOAP web services compatible with Netsmart Technologies' myAvatar CareRecord using ScriptLink. The libraries include the definition of the foundational data types, as well as the ScriptLink request and response structures needed to create custom SOAP web services that can interact with myAvatar. They also include helper methods formanaging and manipulating the data within these structures including creation of the SOAP response. This project aims to simplify the development of custom integrations with myAvatar by providing a robust and easy-to-use set of tools for working with ScriptLink and CareRecord data.

The libraries are intended to be packaged and delivered as NuGet packages for easy integration into .NET projects.

### Original Project (RarelySimple.AvatarScriptLink)

The original project, **RarelySimple.AvatarScriptLink**, provided both the foundational data types and the helper methods in a single package. However, to improve modularity and allow developers to use only the parts they need, new projects have been created to separate these concerns.

### New Projects

1. **RarelySimple.AvatarScriptLink.Objects**: This project focuses solely on providing the foundational data types required for working with ScriptLink and CareRecord data. It does not include any helper methods, allowing developers to use just the data structures if they prefer to implement their own logic.
2. **RarelySimple.AvatarScriptLink.Net**: This project provides the helper methods for managing and manipulating the data within the ScriptLink structures. It depends on the RarelySimple.AvatarScriptLink.Objects project for the data types, allowing developers to leverage the helper methods without being tied to a specific implementation of the data structures.
3. **RarelySimple.AvatarScriptLink.Services**: This project contains the interface for defining the ScriptLink web services, allowing developers to create custom SOAP web services that can interact with myAvatar.

## Repository Organization

The repository is organized into the following directories:

- `docs`: Contains public documentation site for the project.
- `docs/blog`: Contains blog posts related to the project.
- `docs/docs`: Contains detailed documentation and guides for using the ScriptLink libraries.
- `docs/src`: Contains the source code for custom components, CSS, and other pages of the documentation site.
- `docs/static`: Contains static assets such as images, fonts, and other resources used in the documentation site.
- `docs/versioned_docs`: Contains versioned documentation for different releases of the ScriptLink libraries.
- `docs/versioned_sidebars`: Contains versioned sidebars for navigating the documentation site.
- `dotnet`: Contains the .NET implementation of the ScriptLink libraries.
- `dotnet/RarelySimple.AvatarScriptLink`: Contains the original ScriptLink project with foundational data types and helper methods.
- `dotnet/RarelySimple.AvatarScriptLink.Tests`: Contains unit tests for the RarelySimple.AvatarScriptLink project.
- `dotnet/RarelySimple.AvatarScriptLink.Objects`: Contains the new ScriptLink project which only provides the foundational data types.
- `dotnet/RarelySimple.AvatarScriptLink.Objects.Tests`: Contains unit tests for the RarelySimple.AvatarScriptLink.Objects project.
- `dotnet/RarelySimple.AvatarScriptLink.Net`: Contains the new ScriptLink project specifically providing the helper methods for managing and manipulating the data within these structures.
- `dotnet/RarelySimple.AvatarScriptLink.Net.Tests`: Contains unit tests for the RarelySimple.AvatarScriptLink.Net project.
- `dotnet/RarelySimple.AvatarScriptLink.Services`: Contains the interface for defining the ScriptLink web services.

## Versioning Strategy

The project follows Semantic Versioning (SemVer) principles to manage version numbers and communicate changes effectively. The version number is structured as MAJOR.MINOR.PATCH, where:

- MAJOR version when you make incompatible API changes,
- MINOR version when you add functionality in a backwards-compatible manner, and
- PATCH version when you make backwards-compatible bug fixes.

Pre-release versions and build metadata can be appended to the version number as needed, following the SemVer guidelines.

### Version 1.x.x

This is the original version of the RarelySimple.AvatarScriptLink project, which includes both the foundational data types and the helper methods in a single package.

### Version 2.x.x

This version introduces the separation of concerns by creating new projects for the foundational data types and the helper methods. The RarelySimple.AvatarScriptLink project continues to exist for backward compatibility, while the new projects allow developers to choose only the components they need.

In version 2.x.x, the RarelySimple.AvatarScriptLink.Objects project provides the foundational data types, and the RarelySimple.AvatarScriptLink.Net project provides the helper methods. The RarelySimple.AvatarScriptLink.Services project contains the interface for defining the ScriptLink web services. These projects are incompatible with version RarelySimple.AvatarScriptLink due to the separation of concerns and changes in project structure.

The RarelySimple.AvatarScriptLink project in version 2.x.x will be considered deprecated and receive minimal maintenance for security fixes only. Feature enhancements will be added to the new projects instead. This transition version is intended to give developers time to migrate their implementations to the new modular structure and validate parity between the old and new structures.

### Version 3.x.x and Beyond

Future versions will continue to follow Semantic Versioning principles, with new features and improvements being added to the RarelySimple.AvatarScriptLink.Objects, RarelySimple.AvatarScriptLink.Net, and RarelySimple.AvatarScriptLink.Services projects as needed. Major version changes will be reserved for significant changes that may introduce incompatibilities or require substantial modifications to existing implementations. RarelySimple.AvatarScriptLink will be removed in version 3.0.0.

## Technology Stack & Dependencies

### Core Technologies
- **Language**: C# (.NET)
- **Target Frameworks**: 
  - RarelySimple.AvatarScriptLink: .NET Standard 2.0 (broadest compatibility)
  - RarelySimple.AvatarScriptLink.Objects: .NET Standard 2.0
  - RarelySimple.AvatarScriptLink.Net: .NET Standard 2.0
  - RarelySimple.AvatarScriptLink.Services: .NET 8.0 (requires latest features for SOAP services)
  - All projects support .NET Framework 4.6.1+, .NET Core, and modern .NET 5/6/7/8+ except for Services which requires .NET 8.0+.
- **Build System**: MSBuild via Visual Studio / dotnet CLI
- **IDE**: Visual Studio 2022 recommended (minimum version 17.4+)

### Key Dependencies
- **SoapCore**: SoapCore for SOAP web service implementation (Services project)
- **Serialization**: System.Xml for SOAP message handling
- **Strong Naming**: Uses shared signing key (RarelySimple.AvatarScriptLink.snk)

### Testing Framework
- Unit testing framework: MSTest, xUnit, or NUnit (check individual test projects)
- Test execution: `dotnet test` command or Visual Studio Test Explorer

## Getting Started for Contributors

### Prerequisites
- Visual Studio 2022 (v17.4 or later) or Visual Studio Code with C# extension
- .NET SDK 8.0 or later installed
- Git for version control

### Initial Setup
1. Clone the repository: `git clone https://github.com/rarelysimple/RarelySimple.AvatarScriptLink.git`
2. Navigate to the dotnet directory: `cd dotnet`
3. Open the solution: `RarelySimple.AvatarScriptLink.sln`
4. Restore NuGet packages: `dotnet restore`
5. Build the solution: `dotnet build`
6. Run tests: `dotnet test`

### Building & Testing Locally
- **Build**: `dotnet build RarelySimple.AvatarScriptLink.sln`
- **Run Tests**: `dotnet test RarelySimple.AvatarScriptLink.sln` or `dotnet test` in individual test project directories
- **Build for Release**: `dotnet build -c Release`
- **Create Local NuGet Packages**: `dotnet pack -c Release`

## Key Files & Configuration

### Solution Configuration
- **Solution File**: `dotnet/RarelySimple.AvatarScriptLink.sln` - Main entry point for building all projects
- **Version File**: `dotnet/version.json` - Centralized version management (used by all projects)
- **Strong Name Key**: `dotnet/RarelySimple.AvatarScriptLink.snk` - Required for signing all assemblies
- **Code Analysis Ruleset**: `dotnet/RarelySimple.AvatarScriptLink.ruleset` - Defines code quality and style rules

### Project File Considerations
- All `.csproj` files reference the shared ruleset and signing key
- Version information is managed centrally via `version.json`
- Package metadata is included in each `.csproj` (authors, license, repository, project URLs)
- Nullable annotation context should be enabled in all project files

### Root Configuration Files
- **LICENSE**: MIT License - all code must comply
- **CONTRIBUTING.md**: Contribution guidelines and process
- **.github/copilot-instructions.md**: These general instructions
- **.github/instructions/**: Specific instructions for different parts of the repo (dotnet, docs)

## Design Principles & Architecture

### Core Architectural Decisions
1. **Separation of Concerns**: Data models (Objects) are separate from utilities (Net), enabling flexibility
2. **Dependency Injection**: Use DI containers for loose coupling and testability
3. **Interface-Based Design**: All public services expose interfaces, allowing multiple implementations
4. **SOAP Web Service Foundation**: Built on .NET's SOAP/WCF capabilities for myAvatar compatibility
5. **Strong Typing**: Leverage C# type system to prevent runtime errors and improve IntelliSense support

### Project Dependency Graph
```
RarelySimple.AvatarScriptLink.Objects
├── RarelySimple.AvatarScriptLink.Net (depends on Objects)
└── RarelySimple.AvatarScriptLink.Services (depends on Net)

RarelySimple.AvatarScriptLink (legacy, depends on Objects)
└── Contains both Objects and Net functionality for backward compatibility
```

### SOAP & myAvatar Integration
- All web service interfaces are designed for SOAP compatibility with Netsmart myAvatar
- ScriptLink request/response structures must maintain exact compatibility with myAvatar's expectations
- XML serialization behavior is critical and must not change between versions
- Always consider backward compatibility when modifying data structures

## Development Workflow

### Branch Naming Conventions
- **Feature**: `feature/description-of-feature` (e.g., `feature/add-new-helper-method`)
- **Bug Fix**: `bugfix/description-of-bug` (e.g., `bugfix/fix-serialization-issue`)
- **Documentation**: `docs/description` (e.g., `docs/update-getting-started`)
- **Release**: Use tags directly from `main`; release branches are not required (e.g., `v2.x.x`)

### Commit Message Standards
- Use clear, descriptive commit messages
- Start with an action verb: "Add", "Fix", "Update", "Remove", "Refactor"
- Example: `Add helper method for creating response objects`
- Include issue number if applicable: `Fix #123 - Resolve serialization bug`

### Pre-Commit Checklist
- [ ] Code builds successfully: `dotnet build`
- [ ] All tests pass locally: `dotnet test`
- [ ] No build warnings introduced
- [ ] SonarQube issues addressed (if integrated)
- [ ] Code follows established style guidelines
- [ ] XML documentation added for public members
- [ ] Tests added or updated for changes
- [ ] Documentation updated if behavior changed

### Pull Request Process
1. Push changes to a feature branch
2. Submit PR with clear title and description
3. Reference related issue(s)
4. Ensure all CI/CD checks pass
5. Request review from project maintainers
6. Address review feedback
7. Merge when approved

## Known Limitations & Considerations

### SOAP Web Services
- All data serialization must maintain compatibility with myAvatar's SOAP expectations
- XML serialization order may matter for some myAvatar versions
- Test thoroughly with actual myAvatar instances when making serialization changes

### MyAvatar Integration Requirements
- ScriptLink interfaces must exactly match myAvatar's expectations
- CareRecord data types must remain compatible with myAvatar's object model
- Breaking changes to core data structures should increment MAJOR version
- Any changes should be tested against supported myAvatar versions

### .NET Framework Considerations
- .NET Standard 2.0 target limits use of modern C# features in Objects and Net projects
- .NET 8.0-specific features only in Services project
- Developers on .NET Framework 4.x will use these libraries, maintain compatibility
- Consider impact on downstream consumers before adding external dependencies

### Version Compatibility
- Version 1.x.x is now legacy; minimal support
- Version 2.x.x is the transition version with deprecated components
- Version 3.x.x will remove legacy components entirely
- Always document which version introduced/removed features

## Maintenance & Support

### Active Maintenance
- **Version 2.x.x**: Active development, bug fixes, and minor features
- **Version 1.x.x**: Security fixes only (legacy support)
- **Version 3.x.x and Beyond**: Future releases following SemVer

### Deprecation Policy
- Deprecated features remain functional for at least one major version
- Clear deprecation notices added in code comments and documentation
- Migration paths provided in documentation and blog posts
- Breaking changes only occur on major version bumps

### Security Updates
- Security issues addressed immediately, regardless of version
- Released as patch versions when possible to encourage updates
- Security fixes backported to previous major versions when feasible
- Announce security updates in release notes and blog

### End of Life
- After Version 3.0.0, Version 1.x.x will no longer receive updates
- Developers on older versions encouraged to migrate to newer releases
- Documentation preserved for historical reference

## Contributing Guidelines

### Types of Contributions Welcome
- **Bug Reports**: Issues discovered during testing
- **Feature Requests**: Ideas for new functionality
- **Bug Fixes**: Patches for reported issues
- **Documentation**: Improvements to docs, blog posts, examples
- **Tests**: Additional test cases improving coverage
- **Performance Improvements**: Optimizations maintaining backward compatibility

### Code Review Process
- All code changes require peer review before merging
- Reviews check for:
  - Code quality and adherence to standards
  - Test coverage for changes
  - Documentation updates
  - Backward compatibility implications
  - Security considerations
- Constructive feedback is provided to help improve code

### What NOT to Contribute
- Code tied to specific myAvatar versions (should be abstracted)
- Hardcoded configuration values (use dependency injection instead)
- Undocumented external dependencies without strong justification
- Changes that break backward compatibility in patch/minor versions

## Common Tasks

### Adding a New Project to the Solution
1. Create new folder in `dotnet/` directory
2. Create `.csproj` file using existing projects as template
3. Reference `RarelySimple.AvatarScriptLink.snk` for signing
4. Reference `RarelySimple.AvatarScriptLink.ruleset` for code analysis
5. Add project to `RarelySimple.AvatarScriptLink.sln`
6. Create corresponding `.Tests` project for unit tests
7. Update documentation and this file

### Creating a New NuGet Package Release
1. Update version in `version.json`
2. Update `CHANGELOG.md` or release notes
3. Update blog post with release announcement
4. Commit changes with message: `Release v2.x.x`
5. Push to `main` branch
6. Create an annotated tag: `git tag -a v2.x.x -m "Release v2.x.x"`
7. Push the tag: `git push origin v2.x.x`
8. Create GitHub release from the tag (via GitHub UI or CLI)
9. CI/CD pipeline automatically builds and publishes to NuGet.org

### Updating Documentation for New Features
1. Add feature documentation to `docs/docs/`
2. Update relevant API reference pages
3. Create blog post announcing feature (if significant)
4. Update `docs/sidebars.js` if new section added
5. Test locally with `npm run start` in docs directory
6. Ensure documentation builds without errors
7. Include documentation updates in PR with code changes

### Handling Breaking Changes
1. **Planning**: Discuss breaking change scope and timing
2. **Documentation**: Create migration guide in docs
3. **Versioning**: Plan for next MAJOR version bump
4. **Deprecation**: Add deprecation warnings in current version first (if possible)
5. **Communication**: Announce in blog post well in advance
6. **Transition Period**: Allow users time to migrate (typically 1-2 major versions)
7. **Release**: Document breaking changes in release notes

### Setting Up Local Development Environment
1. Clone repository and checkout `main` branch
2. Open `dotnet/RarelySimple.AvatarScriptLink.sln` in Visual Studio 2022
3. Restore NuGet packages: `dotnet restore`
4. Build solution: `dotnet build`
5. Run all tests: `dotnet test`
6. For documentation work, navigate to `docs/` and run `npm install && npm start`
7. Review `.github/instructions/` files for specific guidelines
