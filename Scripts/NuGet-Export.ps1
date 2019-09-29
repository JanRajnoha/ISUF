$CurrentDir = $PSScriptRoot
$NuGetDirectoryName = "NuGet"
$NuGetProgram = "$($CurrentDir)\nuget.exe"

Set-Location "$CurrentDir"
Set-Location ..

If (-Not (Test-Path ("$NuGetDirectoryName")))
{
    $NuGetDir = New-Item -Name "$NuGetDirectoryName" -ItemType "directory"
}

$NuGetDir =  "$(Get-Location)\$NuGetDirectoryName"

Set-Location "$NuGetDir"

Remove-Item -path "$(Get-Location)\*" -Filter *.nupkg -Force

Set-Location ..
Set-Location src

$Directories = Get-ChildItem -Directory

foreach ($Directory in $Directories)
{
    Set-Location $Directory

    $Files = Get-ChildItem -Filter *.csproj
	$NuspecFile = Get-ChildItem -Filter *.nuspec

	if ($null -ne $NuspecFile)
    {
		foreach ($File in $Files)
		{
		    & $NuGetProgram pack $File -IncludeReferencedProjects -OutputDirectory $NuGetDir
		}
	}

    Set-Location ..
}

if ($PublishPackagesFile = Get-ChildItem $CurrentDir -Name "Publish-Packages.ps1" -File)
{
	& "$PSScriptRoot\$PublishPackagesFile"
}