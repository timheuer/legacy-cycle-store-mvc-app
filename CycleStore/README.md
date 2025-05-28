# Legacy Cycle Store MVC App - .NET 8 Migration

This directory contains the migrated version of the Legacy Cycle Store MVC application, upgraded from .NET Framework 4.5 to .NET 8.

## Migration Details

### Original Application
- .NET Framework 4.5
- ASP.NET MVC 4.0
- Entity Framework 5.0 with EDMX model
- Forms Authentication

### Upgraded Application
- .NET 8
- ASP.NET Core MVC
- Entity Framework Core 8.0
- Modern dependency injection
- Updated project structure

## Key Changes

1. **Project Structure**
   - Moved from legacy project format to modern SDK-style project
   - Reorganized files into Models, Views, Controllers, and Data folders

2. **Entity Framework**
   - Migrated from EDMX model to code-first approach with EF Core
   - Created entity classes with data annotations and fluent API configuration
   - Implemented DbContext with proper entity relationships

3. **Authentication**
   - Simplified authentication approach using ASP.NET Core Identity

4. **Configuration**
   - Moved from Web.config to appsettings.json
   - Configured services in Program.cs

## Running the Application

1. Ensure you have .NET 8 SDK installed
2. Create an appsettings.json file based on appsettings.template.json and update the connection string
3. Run the application using:
   ```
   cd CycleStore/CycleStore.Web
   dotnet run
   ```

## Known Issues

- Third-party C1 components were removed as they're not compatible with .NET 8
- Some UI elements may need additional styling to match the original application
