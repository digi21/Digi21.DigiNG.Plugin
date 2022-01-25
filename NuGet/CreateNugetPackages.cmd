@echo off
nuget.exe pack Digi21.DigiNG.Plugin.nuspec
nuget.exe sign Digi21.DigiNG.Plugin.22.2.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://timestamp.comodoca.com?td=sha256.
