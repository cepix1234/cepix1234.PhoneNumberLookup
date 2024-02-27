dotnet publish .\src\cepix1234.PhoneNumberLookup.Console -r linux-x64 -p:PublishSingleFile=true --self-contained true
dotnet publish .\src\cepix1234.PhoneNumberLookup.Console -r win-x64 -p:PublishSingleFile=true --self-contained true

Copy-Item .\src\cepix1234.PhoneNumberLookup.Console\bin\Debug\net7.0\win-x64\publish\cepix1234.PhoneNumberLookup.Console.exe .\Release\Windows\cepix1234.PhoneNumberLookup.exe
Copy-Item .\src\cepix1234.PhoneNumberLookup.Console\bin\Debug\net7.0\win-x64\publish\appsettings.json .\Release\Windows\appsettings.json
Copy-Item .\src\cepix1234.PhoneNumberLookup.Console\bin\Debug\net7.0\linux-x64\publish\cepix1234.PhoneNumberLookup.Console .\Release\Linux\cepix1234.PhoneNumberLookup
Copy-Item .\src\cepix1234.PhoneNumberLookup.Console\bin\Debug\net7.0\linux-x64\publish\appsettings.json .\Release\Linux\appsettings.json