& $WriteMessage "Getting latest NuGet program"

Remove-Item -path "$CurrentDir\*" -Filter *.exe -Force

$NuGetUrl = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
$Output = "$CurrentDir\nuget.exe"

Import-Module BitsTransfer
Start-BitsTransfer -Source $NuGetUrl -Destination $Output

& $WriteMessage "Download completed"