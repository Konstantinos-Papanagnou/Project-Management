echo off
cls

echo.
echo.
echo Setting up default database
mkdir %localappdata%\PharmacyInformationSystem
copy Pharmacy.db %localappdata%\PharmacyInformationSystem\

echo Database was setted up successfully!
pause