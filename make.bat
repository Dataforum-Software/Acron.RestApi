@echo off
echo .

SET CSVERBOSITY=minimal
SET VSPATH="C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\Tools\VSDevCmd.BAT"

IF "%1" == "" (
	SET CONFIG=Release
) ELSE (
	SET CONFIG=%1
)

echo Caution: calling VSDevCmd.bat from default Visual Studio 2022 installation path
echo %VSPATH%

IF EXIST %VSPATH% (
	CALL %VSPATH%
) ELSE (
	GOTO ERROR
)

cls

MSBuild Acron.RestApi.Client.sln /t:restore;build /p:configuration=%CONFIG%;platform=x64 /verbosity:%CSVERBOSITY% 
IF ERRORLEVEL 1 GOTO ERROR

GOTO OUT

:ERROR
echo .
echo      ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
echo        !!!!!!!! ERROR !!!!!!!!
echo      ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
echo .
pause

:OUT
echo on
exit