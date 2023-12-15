@echo off
nuget.exe pack Digi21.DigiNG.Plugin.nuspec
nuget.exe sign *.nupkg -CertificatePath "C:\Users\josea\OneDrive\certificados\certificadosslparafirmarnuget.pfx" -TimeStamper http://timestamp.comodoca.com?td=sha256.
