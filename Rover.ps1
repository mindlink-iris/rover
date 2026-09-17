$pathExists = Test-Path -Path "./rover"

if (-not $pathExists) {
    git clone "https://github.com/mindlink-iris/rover"
}

cd ./rover
git pull
cd ..

dotnet build ./rover --configuration Release

Write-Host ""
Write-Host "### UP TO DATE ###"
Write-Host "### RUNNING ROVER ###"
Write-Host ""

$i = 0
while ($i -lt 12) {
    Write-Host "." -NoNewline
    Start-Sleep -Milliseconds 200
    $i++
}

Clear-Host

. ".\rover\Rover\bin\Release\net8.0\Rover.exe"