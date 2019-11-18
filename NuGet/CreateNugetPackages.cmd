@echo off
nuget.exe pack Digi21.DigiNG.Plugin.nuspec
nuget.exe sign Digi21.DigiNG.Plugin.17.2.0.nupkg -CertificatePath dwo.pfx -TimeStamper http://tsa.starfieldtech.com
