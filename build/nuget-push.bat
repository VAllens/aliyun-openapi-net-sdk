@echo off&setlocal enabledelayedexpansion
%~dp0nuget.exe setApiKey <nuget_api_key> -source https://www.nuget.org
%~dp0nuget.exe source Add -Name "GitHub" -Source "https://nuget.pkg.github.com/<your_name>/index.json" -UserName <your_name> -Password <github_access_token>
for /f %%a in ('dir *.nupkg /a/s/b') do (
%~dp0nuget.exe push %%a -Source https://www.nuget.org/api/v2/package
%~dp0nuget.exe push %%a -Source "GitHub"
)