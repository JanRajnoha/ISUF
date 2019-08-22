$CurrentDir = $PSScriptRoot
$NuGetDirectoryName = "NuGet"

cd "$CurrentDir"
cd..

If (-Not (Test-Path ("$NuGetDirectoryName")))
{
    $NuGetDir = New-Item -Name "$NuGetDirectoryName" -ItemType "directory"
}

$NuGetDir =  "$(Get-Location)\$NuGetDirectoryName"

cd "$NuGetDir"

Remove-Item -path "$(Get-Location)\*" -Filter *.nupkg -Force

cd..
cd src

$Directories = dir -Directory

foreach ($Directory in $Directories)
{
    cd $Directory

    $Files = Get-ChildItem -Filter *.csproj
    
    foreach ($File in $Files)
    {
        C:\Users\JR\Downloads\nuget.exe pack $File -IncludeReferencedProjects -OutputDirectory "$NuGetDir"
    }

    cd..
}