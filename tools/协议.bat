cd ../queen/Commands/
call gen_resolver.bat
cd ../Queen.Protocols.Gen/
dotnet run --project Queen.Protocols.Gen.csproj
cd ../../
xcopy /e /y "%cd%\queen\Queen.Protocols\*.cs" "%cd%\goblin\Assets\Scripts\Goblin\Common\Network\Protocols\"
xcopy \e \y "%cd%\queen\Queen.Protocols\Common\*" "%cd%\goblin\Assets\Scripts\Goblin\Common\Network\Protocols\"
rmdir /s /q "%cd%\goblin\Assets\Scripts\Goblin\Common\Network\Protocols\bin"
rmdir /s /q "%cd%\goblin\Assets\Scripts\Goblin\Common\Network\Protocols\obj"
pause