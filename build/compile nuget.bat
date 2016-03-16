@echo off

echo Begin create nuget for PersistenceMap.Interception
nuget.exe pack ..\src\PersistenceMap.Interception.nuspec

echo End create nuget for PersistenceMap.Interception
pause