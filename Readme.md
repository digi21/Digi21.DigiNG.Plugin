[![NuGet](https://img.shields.io/nuget/v/Digi21.DigiNG.Plugin?style=flat)](https://www.nuget.org/packages/Digi21.DigiNG.Plugin/)

# Digi21.DigiNG.Plugin

This repository contains the source code of the reference assembly: Digi21.DigiNG.Plugin that is distributed through NuGet package for creating Digi3D.AI extensions such as commands, search engines, etc.

## Publishing

Push a tag `v<version>` whose version matches `<version>` in the `.nuspec` of the `NuGet` folder. The *Release* workflow builds the reference assembly, packs it and publishes it to nuget.org with trusted publishing (repository secret `NUGET_USER`, the nuget.org profile name). The packages are not author-signed; the reference assembly is public-signed with `Digi21.PublicKey.snk`, which contains only the public key.
