git clone https://github.com/wantdabo/goblin.git ./goblin
git clone https://github.com/wantdabo/queen.git ./queen

dotnet tool install --global MessagePack.Generator
dotnet new tool-manifest
dotnet tool install MessagePack.Generator

rd /s /q .\goblin\config
rd /s /q .\queen\config
rd /s /q .\.config

del /s /q .\init.bat