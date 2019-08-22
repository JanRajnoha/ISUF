$CurrentDir = $PSScriptRoot

If (-Not (Test-Path ($CurrentDir + "\NuGet")))
{
    New-Item -Path $CurrentDir -Name "NuGet" -ItemType "directory"
}

$Directories = dir $CurrentDir -Directory

foreach ($Directory in $Directories)
{
    cd $Directory

    $Files = Get-ChildItem -Filter *.nuspec
    
    foreach ($File in $Files)
    {
        C:\Users\JR\Downloads\nuget.exe pack $File -IncludeReferencedProjects -OutputDirectory "$CurrentDir\NuGet"
    }

    cd..
}