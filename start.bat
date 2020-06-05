@echo off
set pa=%cd%
cd /d C:\Program Files (x86)\Google\Chrome\Application
start chrome.exe http://localhost:8080
# echo Sdm:
# SET ASPNETCORE_URLS=http://127.0.0.1:5000
# start cmd /k call dotnet %pa%\KunBlog.SDM\bin\Debug\netcoreapp3.1\KunBlog.SDM.dll
# echo Dal:
# SET ASPNETCORE_URLS=http://127.0.0.1:5001
# start cmd /k call dotnet %pa%\KunBlog.DAL\bin\Debug\netcoreapp3.1\KunBlog.DAL.dll

cd /d %pa%\VueClient
call npm run dev
pause