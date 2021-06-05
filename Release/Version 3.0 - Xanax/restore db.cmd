echo off
cls
echo.
echo.
echo Restoring database to default...

del %localappdata%\PharmacyInformationSystem\Pharmacy.db

echo Database Restored Successfully!
pause