@echo off
nuget.exe pack Digi21.DigiNG.Plugin.nuspec
nuget.exe sign Digi21.DigiNG.Plugin.21.0.0.nupkg -CertificateSubjectName "DREAMING WITH OBJECTS" -TimeStamper http://tsa.starfieldtech.com
