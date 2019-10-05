$CurrentDir = $PSScriptRoot
$NuGetDirectoryName = "NuGet"
$WriteMessage = "$PSScriptRoot\Write-Message.ps1"
$NuGetDownload = "$PSScriptRoot\NuGet-Download.ps1"
$NuGetExport = "$PSScriptRoot\NuGet-Export.ps1"

Set-Location "$CurrentDir"

& $NuGetDownload
& $WriteMessage "Searching for output direcotry"

Set-Location ..

If (-Not (Test-Path ("$NuGetDirectoryName")))
{
    $NuGetDir = New-Item -Name "$NuGetDirectoryName" -ItemType "directory"
}

$NuGetDir =  "$(Get-Location)\$NuGetDirectoryName"

Set-Location "$NuGetDir"

& $WriteMessage "Removing old NuGet packages"

Remove-Item -path "$(Get-Location)\*" -Filter *.nupkg -Force

& $NuGetExport 

if ($PublishPackagesFile = Get-ChildItem $CurrentDir -Name "Publish-Packages.ps1" -File)
{
	& "$CurrentDir\$PublishPackagesFile"
}