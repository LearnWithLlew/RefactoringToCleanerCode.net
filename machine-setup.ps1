# To run this script directly, open PowerShell and run this command:
#     PS> Invoke-WebRequest -UseBasicParsing https://raw.githubusercontent.com/LearnWithLlew/RefactoringToCleanerCode.net/master/machine-setup.ps1 | Invoke-Expression

#Requires -RunAsAdministrator

iwr -useb https://raw.githubusercontent.com/JayBazuzi/machine-setup/main/windows.ps1 | iex
iwr -useb https://raw.githubusercontent.com/JayBazuzi/machine-setup/main/visual-studio.ps1 | iex

cinst typora

# Install ReSharper_SilentCleanupOnSavePreview extension to Visual Studio
iwr https://marketplace.visualstudio.com/_apis/public/gallery/publishers/Grahamvs/vsextensions/ReSharperSilentCleanupOnSave/0.1/vspackage -O ReSharper_SilentCleanupOnSavePreview.vsix
& "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Common7\IDE\VSIXInstaller.exe" .\ReSharper_SilentCleanupOnSavePreview.vsix  /q

& "C:\Program Files\Git\cmd\git.exe" clone https://github.com/LearnWithLlew/RefactoringToCleanerCode.slides.git C:\Source\RefactoringToCleanerCode.slides
github C:\Source\RefactoringToCleanerCode.slides

& "C:\Program Files\Git\cmd\git.exe" clone https://github.com/LearnWithLlew/RefactoringToCleanerCode.net.git C:\Source\RefactoringToCleanerCode.net
github C:\Source\RefactoringToCleanerCode.net

Expand-Archive C:\Source\RefactoringToCleanerCode.Slides\fonts\playfair-display.zip C:\Source\RefactoringToCleanerCode.Slides\fonts\
Expand-Archive C:\Source\RefactoringToCleanerCode.Slides\fonts\pt-serif.zip
Invoke-Item C:\Source\RefactoringToCleanerCode.Slides\fonts\
