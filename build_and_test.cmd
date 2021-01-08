dotnet restore RefactoringToCleanerCode
dotnet build RefactoringToCleanerCode --no-restore
dotnet test RefactoringToCleanerCode --no-build --verbosity normal
