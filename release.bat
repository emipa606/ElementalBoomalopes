for %%I in (.) do set WorkingDir=%%~nxI
cd ..
IF EXIST "Elemental Boomers\" (rmdir /s /q "Elemental Boomers") ELSE (mkdir "Elemental Boomers")

xcopy /s /exclude:%WorkingDir%\excludedfiles.txt %WorkingDir% "Elemental Boomers\"

cd %WorkingDir%