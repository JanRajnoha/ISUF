$CurrentDir = $PSScriptRoot
$NuGetProgram = "$CurrentDir\nuget.exe"

& $WriteMessage "Creating new packages"

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

            if ($IncrementVersionFile = Get-ChildItem $CurrentDir -Name "Increment-Version.ps1" -File)
            {
	            & "$CurrentDir\$IncrementVersionFile" $NuspecFile.FullName
            }

		    & $NuGetProgram pack $File -IncludeReferencedProjects -OutputDirectory $NuGetDir
		}
	}

    Set-Location ..
}

& $WriteMessage "Packages was exported"