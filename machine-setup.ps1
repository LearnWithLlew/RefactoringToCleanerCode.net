# To run this script directly, open PowerShell and run this command:
#     PS> Invoke-WebRequest -UseBasicParsing https://raw.githubusercontent.com/LearnWithLlew/RefactoringToCleanerCode.net/master/machine-setup.ps1 | Invoke-Expression

#Requires -RunAsAdministrator

iwr -useb https://raw.githubusercontent.com/JayBazuzi/machine-setup/main/windows.ps1 | iex
iwr -useb https://raw.githubusercontent.com/JayBazuzi/machine-setup/main/visual-studio.ps1 | iex

cinst typora

# Don't Install ReSharper_SilentCleanupOnSavePreview extension to Visual Studio - it interferes with undo
# iwr https://marketplace.visualstudio.com/_apis/public/gallery/publishers/Grahamvs/vsextensions/ReSharperSilentCleanupOnSave/0.1/vspackage -O ReSharper_SilentCleanupOnSavePreview.vsix
# & "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Common7\IDE\VSIXInstaller.exe" .\ReSharper_SilentCleanupOnSavePreview.vsix  /q

mkdir C:\Source\
pushd C:\Source\

Set-Alias github $env:LOCALAPPDATA\GitHubDesktop\bin\github.bat
& "C:\Program Files\Git\cmd\git.exe" clone https://github.com/LearnWithLlew/RefactoringToCleanerCode.slides.git
pushd RefactoringToCleanerCode.Slides\
github .
Expand-Archive fonts\playfair-display.zip fonts\install-me
Expand-Archive fonts\pt-serif.zip fonts\install-me
Invoke-Item fonts\install-me
popd


& "C:\Program Files\Git\cmd\git.exe" clone https://github.com/LearnWithLlew/RefactoringToCleanerCode.net.git
pushd RefactoringToCleanerCode.net
github .
& "C:\Program Files\dotnet\dotnet.exe" test RefactoringToCleanerCode\
& "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Common7\IDE\devenv.exe" RefactoringToCleanerCode\RefactoringToCleanerCode.sln
# force prompt for credentials
& 'C:\Program Files\Git\cmd\git.exe' push
popd

popd
