# Implemented Changes
- Put each class, interface, service, etc into a separate file
- Class, Interface, etc. should begin with a capital letter
- Interfaces should begin with a capital I
- Properties should begin with a capital letter
- Parmeters to methods should begin with a common letter
- Curly braces should be in separate lines for easy reading (not like JavaScript)
- Models folder should contain Entity Classes
- Interface folder contains interfaces
- Services folder contains the main services that your library will offer to the public
- Services should be able to be injected into end user class using Dependency Injection
- The Dependency Inversion principle should be used throughout the project

# Next Project
## Project 2 : Create a Class Library

- Recreate this entire project (with the implemented changes) into a new C# NET Standard Class Library. Name the new project 'WatertankVolumeCalculator'
- Do not copy and paste code, re-write the entire project from scratch and try to understand how it works
- Write one class at a time and fully understand its operation before writing the next class
- In your solution, create a new MSTest Test Project
- Write tests to test the VolumeService
- Create a new repo in Github and upload your new Solution (with Libary and Test projects)
- Pack your Class Library into a Nuget Package. Identity the version, author, description, etc of the Nuget Package.

# Useful Links
- Search the web extensively to complete this project. Some useful links to get started:
- NET Standard Class Library : https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?tabs=csharp
- MSTest Test Project : https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio
- NuGet : https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio?tabs=netcore-cli
- NuGet Local Feeds : https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds
- GitHub Publishing : https://github.com/github/VisualStudio/blob/master/docs/using/publishing-an-existing-project-to-github.md
