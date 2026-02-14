---
applyTo: "dotnet/**"
---

# .NET Solution Guidelines

This directory contains the .NET implementation of the RarelySimple.AvatarScriptLink project, which provides open-source libraries for building SOAP web services compatible with Netsmart Technologies' myAvatar CareRecord using ScriptLink. The solution is organized into multiple projects to separate concerns and improve modularity.

## Projects

1. **RarelySimple.AvatarScriptLink**: The original project that includes both the foundational data types and helper methods. This project is maintained for backward compatibility but is considered deprecated in favor of the new modular projects.
2. **RarelySimple.AvatarScriptLink.Objects**: This project provides the foundational data types required for working with ScriptLink and CareRecord data. It does not include any helper methods, allowing developers to use just the data structures if they prefer to implement their own logic.
3. **RarelySimple.AvatarScriptLink.Net**: This project provides the helper methods for managing and manipulating the data within the ScriptLink structures. It depends on the RarelySimple.AvatarScriptLink.Objects project for the data types, allowing developers to leverage the helper methods without being tied to a specific implementation of the data structures.
4. **RarelySimple.AvatarScriptLink.Services**: This project contains the interface for defining the ScriptLink web services, allowing developers to create custom SOAP web services that can interact with myAvatar.
5. **Unit Test Projects**: Each of the main projects has a corresponding unit test project (e.g., `RarelySimple.AvatarScriptLink.Tests`, `RarelySimple.AvatarScriptLink.Objects.Tests`, `RarelySimple.AvatarScriptLink.Net.Tests`) to ensure code quality and reliability.

## Compatibiltility

To provide the broadest compatiblity, the projects target .NET Standard 2.0, allowing them to be used in a wide range of .NET applications, including .NET Framework, .NET Core, and .NET 5/6/7+. However, due to the reliance on .NET 8+-specific features, RarelySimple.AvatarScriptLink.Services targets .NET 8.0.
## Best Practices

### Project Structure & Organization
- Keep projects focused and single-purpose to maintain modularity
- Use consistent naming conventions matching the namespace structure
- Place related classes in appropriate folders within projects
- Separate concerns: interfaces, implementations, helpers, and exceptions in distinct folders
- Use meaningful folder names that reflect the functionality they contain

### Naming Conventions
- Use PascalCase for class names, method names, and public properties
- Use camelCase for local variables and parameters
- Use UPPER_CASE for constants
- Prefix interfaces with `I`: `IScriptLinkService`, `IFormatter`
- Use descriptive names that clearly indicate purpose and functionality

### Code Style & Standards
- Follow Microsoft's C# Coding Conventions and guidelines
- Use `var` for local variables when the type is obvious, explicitly specify types when not
- Always use braces for single-line conditional blocks and loops
- Use expression-bodied members for simple, single-line implementations
- Keep methods focused and small (aim for single responsibility)
- Use nullable reference types and enable nullable annotation context in project files
- Add XML documentation comments for all public members (classes, methods, properties, enums)

### Dependencies & Project References
- Minimize external dependencies to reduce maintenance burden
- Only reference projects that are required for functionality
- Avoid circular dependencies between projects
- Use dependency injection for loose coupling and testability
- Document why external dependencies are necessary

### Testing
- Write unit tests for all public methods and critical logic
- Use descriptive test names that explain what is being tested and expected outcome
- Follow the Arrange-Act-Assert (AAA) pattern in test methods
- Test both success and failure scenarios
- Aim for high code coverage on critical paths
- Keep tests independent and isolated from each other
- Use test fixtures and helpers to reduce code duplication

### Error Handling & Validation
- Create custom exceptions for domain-specific errors
- Use meaningful exception messages that help debugging
- Validate input parameters at method entry points
- Use guard clauses to handle null or invalid inputs early
- Avoid catching generic `Exception` types; catch specific exceptions
- Log exceptions with sufficient context for troubleshooting

### RowAction Semantics
Understanding RowAction values is critical for proper row state management in ScriptLink operations:
- **RowActions.None** (`""` empty string): No action pending on the row. Use this to indicate that a row should be preserved as-is. When modifying fields in a row with RowAction.None, set it to RowActions.Edit to indicate modification.
- **RowActions.Add** (`"ADD"`): A new row is being added to the form. Preserve this action when modifying the row; do not override with Edit.
- **RowActions.Edit** (`"EDIT"`): An existing row is being modified. Set a row's RowAction to Edit when making field changes on a row that was previously in None state.
- **RowActions.Delete** (`"DELETE"`): The row is marked for removal from the form. Do not change this action even if fields are modified; the row deletion takes precedence.

When implementing helper methods that modify rows (e.g., `DisableAllFieldObjects`, `SetFieldValue`):
- Only set RowAction to Edit if it's currently None
- Preserve existing RowAction values (Add, Edit, Delete) to avoid overriding the intended operation
- This ensures that a row marked for deletion remains marked for deletion, a row being added retains that intent, etc.

### Documentation
- Include XML documentation for all public types and members
- Document non-obvious logic with inline comments
- Explain why certain decisions are made, especially regarding RowAction handling
- Include examples in XML documentation for complex methods
- Keep documentation up-to-date with code changes
- Document breaking changes and migration paths in release notes
- Maintain a README.md in each project explaining its purpose

### Build & Compilation
- Ensure solutions build without warnings
- Run static analysis and code quality checks regularly
- Fix any SonarQube or similar code analysis issues before committing
- Verify all unit tests pass locally before pushing changes
- Test on the target framework versions before release
- Keep .csproj files clean and organized

### Version Management & Compatibility
- Follow Semantic Versioning (SemVer) for version numbering
- Document breaking changes clearly when bumping major versions
- Maintain backward compatibility when possible, especially for patch/minor versions
- Test changes against supported .NET versions and frameworks
- Include version information in release notes and blog posts
- Keep old versions documented for users on legacy versions

### NuGet Publishing
- Include comprehensive package metadata (description, tags, authors)
- Add a README.md to the package for visibility on NuGet.org
- Use meaningful version numbers and follow SemVer guidelines
- Document any dependencies and their version requirements
- Include license information in package metadata
- Test package installation and functionality before official release

### Monorepo Considerations
- Keep documentation and code changes synchronized in pull requests
- Update both documentation and code when breaking changes are introduced
- Reference documentation from code comments and XML docs when appropriate
- Ensure test projects align with documentation examples
- Maintain consistent versioning across related projects in the solution
- Document how projects interact and depend on each other

### Code Review & Quality
- Ensure all code is peer-reviewed before merging
- Address SonarQube findings and security hotspots
- Verify that changes include appropriate unit tests
- Update documentation alongside code changes
- Maintain consistent code formatting across the project
- Follow established architectural patterns used in the project

### Security
- Use strong typing to prevent type-related vulnerabilities
- Validate all external input, especially for web service interfaces
- Avoid hardcoding secrets or sensitive information
- Use secure methods for data serialization (SOAP in this case)
- Keep dependencies updated to patch known vulnerabilities
- Review security hotspots identified by SonarQube
