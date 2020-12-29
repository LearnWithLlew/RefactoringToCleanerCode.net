# To run this script directly, open PowerShell and run this command:
#     PS> Invoke-WebRequest -UseBasicParsing https://raw.githubusercontent.com/LearnWithLlew/RefactoringToCleanerCode.net/master/machine-setup.ps1 | Invoke-Expression

#Requires -RunAsAdministrator

iwr -useb https://raw.githubusercontent.com/JayBazuzi/machine-setup/main/windows.ps1 | iex
iwr -useb https://raw.githubusercontent.com/JayBazuzi/machine-setup/main/visual-studio.ps1 | iex

cinst typora

& "C:\Program Files\Git\cmd\git.exe" clone https://github.com/LearnWithLlew/RefactoringToCleanerCode.net.git C:\Source\RefactoringToCleanerCode.net
github C:\Source\RefactoringToCleanerCode.net

& "C:\Program Files\Git\cmd\git.exe" clone https://github.com/LearnWithLlew/RefactoringToCleanerCode.slides.git C:\Source\RefactoringToCleanerCode.slides

Expand-Archive C:\Source\RefactoringToCleanerCode.Slides\fonts\playfair-display.zip C:\Source\RefactoringToCleanerCode.Slides\fonts\
Expand-Archive C:\Source\RefactoringToCleanerCode.Slides\fonts\pt-serif.zip
Invoke-Item C:\Source\RefactoringToCleanerCode.Slides\fonts\
