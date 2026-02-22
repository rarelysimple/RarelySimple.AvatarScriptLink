---
applyTo: "dotnet/**"
---

# .NET Solution Guidelines

This directory contains the .NET implementation of the RarelySimple.AvatarScriptLink project, which provides open-source libraries for building SOAP web services compatible with Netsmart Technologies' myAvatar CareRecord using ScriptLink. The solution is organized into multiple projects to separate concerns and improve modularity.

## Projects

1. **RarelySimple.AvatarScriptLink**: The original project that includes both the foundational data types and helper methods. This project is maintained for backward compatibility but is considered deprecated in favor of the new modular projects.
2. **RarelySimple.AvatarScriptLink.Objects**: Foundational data types required for working with ScriptLink and CareRecord data.
3. **RarelySimple.AvatarScriptLink.Objects.Helpers**: Extension methods and helper operations for querying and manipulating ScriptLink objects.
4. **RarelySimple.AvatarScriptLink.Objects.Builders**: Fluent builders for constructing ScriptLink objects.
5. **RarelySimple.AvatarScriptLink.Objects.Converters**: Conversion helpers between object representations.
6. **RarelySimple.AvatarScriptLink.Objects.Validators**: Validation helpers and rules for ScriptLink objects.
7. **RarelySimple.AvatarScriptLink.Net**: Batteries-included meta-package that references Objects, Builders, Converters, Helpers, and Validators.
8. **RarelySimple.AvatarScriptLink.Services**: Interfaces for defining ScriptLink web services.
9. **Unit Test Projects**: Each primary project has a corresponding unit test project (e.g., `RarelySimple.AvatarScriptLink.Objects.Helpers.Tests`, `RarelySimple.AvatarScriptLink.Objects.Builders.Tests`, `RarelySimple.AvatarScriptLink.Objects.Converters.Tests`, `RarelySimple.AvatarScriptLink.Objects.Validators.Tests`).

## Compatibiltility

To provide the broadest compatiblity, core libraries target .NET Standard 2.0, allowing them to be used in a wide range of .NET applications, including .NET Framework, .NET Core, and modern .NET. However, due to reliance on .NET 8+-specific features, RarelySimple.AvatarScriptLink.Services targets .NET 8.0.
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
Understanding RowAction values is critical for proper row state management in ScriptLink operations. The RowAction determines which rows are included in the response payload sent back to myAvatar:
- **RowActions.None** (`""` empty string or `null`): No action pending on the row. Both empty string and null are treated equivalently as None. Rows with RowAction.None are **excluded from the response payload** and not sent back to myAvatar, effectively preserving them as-is. When modifying fields in a row initially in None state, set it to RowActions.Edit to include it in the response payload.
- **RowActions.Add** (`"ADD"`): A new row is being added to the form. This row **is included in the response payload** to instruct myAvatar to add it. Preserve this action when modifying the row; do not override with Edit.
- **RowActions.Edit** (`"EDIT"`): An existing row is being modified. This row **is included in the response payload** to instruct myAvatar to update it. Set a row's RowAction to Edit when making field changes on a row that was previously in None state to ensure the modifications are sent to myAvatar.
- **RowActions.Delete** (`"DELETE"`): The row is marked for removal from the form. This row **is included in the response payload** to instruct myAvatar to delete it. Do not change this action even if fields are modified; the row deletion takes precedence.

When implementing helper methods that modify rows (e.g., `DisableAllFieldObjects`, `SetFieldValue`):
- Only set RowAction to Edit if it's currently None (use `string.IsNullOrEmpty()` to check for None), so the modified row is included in the response payload
- Preserve existing RowAction values (Add, Edit, Delete) to avoid overriding the intended operation
- This ensures that a row marked for deletion remains marked for deletion, a row being added retains that intent, and rows with no changes are not unnecessarily included in the response

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
