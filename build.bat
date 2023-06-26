:: Generated by: https://github.com/swagger-api/swagger-codegen.git
::
:: Licensed under the Apache License, Version 2.0 (the "License");
:: you may not use this file except in compliance with the License.
:: You may obtain a copy of the License at
::
::      http://www.apache.org/licenses/LICENSE-2.0
::
:: Unless required by applicable law or agreed to in writing, software
:: distributed under the License is distributed on an "AS IS" BASIS,
:: WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
:: See the License for the specific language governing permissions and
:: limitations under the License.

@echo off

set FORGESDK_VERSION=1.9.8
set RESTSHARP_VERSION=108.0.1
set NEWTOWNSOFT_VERSION=13.0.1

:: if "%VCINSTALLDIR%" == ""
call "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\Tools\VsDevCmd.bat"
::set CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe"^
  powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://nuget.org/nuget.exe', '.\nuget.exe')"
  
nuget restore Autodesk.Forge.sln
::if not exist ".\packages\RestSharp.%RESTSHARP_VERSION%"^
::  .\nuget.exe install RestSharp -Version %RESTSHARP_VERSION% -OutputDirectory packages
::if not exist ".\packages\Newtonsoft.Json.%NEWTOWNSOFT_VERSION%"^
::  .\nuget.exe install Newtonsoft.Json -Version %NEWTOWNSOFT_VERSION% -OutputDirectory packages

:: if not exist ".\bin" mkdir bin
:: copy packages\Newtonsoft.Json.%NEWTOWNSOFT_VERSION%\lib\net452\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
:: copy packages\RestSharp.%RESTSHARP_VERSION%\lib\net452\RestSharp.dll bin\RestSharp.dll
:: /platform:anycpu - default
:: /debug - not default
:: %CSCPATH%\csc /reference:bin\Newtonsoft.Json.dll;bin\RestSharp.dll /target:library /out:bin\Autodesk.Forge.dll /recurse:src\Autodesk.Forge\*.cs /doc:bin\Autodesk.Forge.xml
:: .\nuget pack src\Autodesk.Forge\Autodesk.Forge.csproj -Prop Platform=AnyCPU -Prop Configuration=Release
:: .\nuget pack Autodesk.Forge.nuspec

::%CSCPATH%\csc
::  -platform:anycpu 
::  /reference:packages\Newtonsoft.Json.%NEWTOWNSOFT_VERSION%\lib\net452\Newtonsoft.Json.dll;packages\RestSharp.%RESTSHARP_VERSION%\lib\net452\RestSharp.dll
::  /target:library
::  /out:src\Autodesk.Forge\bin\Release\Autodesk.Forge.dll
::  /recurse:src\Autodesk.Forge\*.cs
::  /doc:src\Autodesk.Forge\bin\Release\Autodesk.Forge.xml
msbuild Autodesk.Forge.sln /p:Platform="Any CPU" /p:Configuration=Release

:: if not exist ".\bin\Release\Autodesk.Forge\bin\Release"
::  mkdir ".\bin\Release\Autodesk.Forge\bin\Release"
::xcopy .\src\Autodesk.Forge\bin\Release .\bin\Release\Autodesk.Forge\bin\Release /E /C /Y
:: nuget pack src\Autodesk.Forge\Autodesk.Forge.csproj -Prop Platform=AnyCPU -Prop Configuration=Release
:: nuget pack src\Autodesk.Forge\Autodesk.Forge.csproj -Prop Platform=AnyCPU -Prop Configuration=Release
nuget pack src\Autodesk.Forge\Autodesk.Forge.nuspec

echo .
echo ".\nuget push Autodesk.Forge.%FORGESDK_VERSION%.nupkg %NUGETAPIKEY% -Source https://www.nuget.org/api/v2/package"
:: .\nuget push Autodesk.Forge.%FORGESDK_VERSION%.nupkg %NUGETAPIKEY% -Source https://www.nuget.org/api/v2/package
