:del C:\Users\patricke\Documents\autorest\output\* /s /q
xcopy AutoRest\Generators\CSharp\CSharp\bin\Net45-Release\AutoRest.Generator.CSharp.dll binaries\net45\ /y
xcopy AutoRest\AutoRest.Core\bin\Net45-Release\AutoRest.Core.dll binaries\net45\ /y

binaries\net45\AutoRest -CodeGenerator CSharp -Modeler Swagger -Namespace VoipDomain -OutputDirectory "%cd%\output" -Input swagger.json
:pause