TCE9UJIF@echo off
nuget.exe pack Digi21.DigiNG.Plugin.nuspec
nuget.exe sign Digi21.DigiNG.Plugin.23.0.0.nupkg -CertificatePath "C:\Users\josea\OneDrive\certificados\certificadosslparafirmarnuget.pfx" -TimeStamper http://timestamp.comodoca.com?td=sha256.
