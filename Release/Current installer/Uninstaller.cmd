echo off
cls 
echo.
echo.
echo This is the uninstaller. Please run this script as administrator for the uninstallation to have full effect.

echo.
echo.
echo Uninstalling Application ...
cd %programfiles(x86)%\PharmacyInformationSystem

for /r %%i in (*) do (echo Removing %%i & del "%%i" & echo ... OK)
rmdir /S /Q "%programfiles(x86)%\PharmacyInformationSystem"
	

echo.
echo.
echo Removing Application Data... (Pharmacy.db)
del "%localappdata%\PharmacyInformationSystem\Pharmacy.db"
echo %localappdata%\PharmacyInformationSystem\Pharmacy.db ... OK
rmdir -S -Q "%localappdata%\PharmacyInformationSystem"
echo %localappdata%\PharmacyInformationSystem ... OK

echo.
echo.
echo Removing Shortcuts...
del "%appdata%\Microsoft\Windows\Start Menu\Pharmacy*"
echo %appdata%\Microsoft\Windows\Start Menu\Pharmacy Information System ... OK

del "%appdata%\Microsoft\Windows\Start Menu\Programs\Pharmacy*"
echo %appdata%\Microsoft\Windows\Start Menu\Startup\Pharmacy Information System ... OK

del "%appdata%\Microsoft\Windows\Start Menu\Programs\Startup\Pharmacy*"
echo %appdata%\Microsoft\Windows\Start Menu\Programs\Startup\Pharmacy Information System ... OK

del "%userprofile%\Desktop\Pharmacy*"
echo %userprofile%\Desktop\Pharmacy Information System ... OK



echo.
echo.
echo Uninstallation process completed successfully
pause