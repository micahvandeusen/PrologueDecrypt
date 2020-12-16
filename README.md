# PrologueDecrypt
 
## Description

Prologue uses a static encryption key across all installations.
 PrologueDecrypt is an offensive security C# tool designed to decrypt these passwords located in Prologue config files.

## Setup

1. Download PrologueDecrypt

2. Register the required crypto COM library as an admin user `regsvr32 IPSCrypto.dll`

3. Open up PrologueDecrypt.sln in Visual Studio (was tested using Visual Studio 2019) and build.

4. Run PrologueDecrypt.exe passing the encrypted string without the @ symbol at the start of the string.
