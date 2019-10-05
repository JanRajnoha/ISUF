param (
    [Parameter(Mandatory=$true)][string]$Path
 )

$NuGetFileContent = Get-Content -Path $Path
$i = 0

while ($i -lt $NuGetFileContent.Length)
{
    if ($NuGetFileContent[$i].Contains('<version>'))
    {
        $NuGetFileContent[$i] = $NuGetFileContent[$i].Replace(" ","")
        $NuGetFileContent[$i] = $NuGetFileContent[$i].Replace("<version>","")
        $NuGetFileContent[$i] = $NuGetFileContent[$i].Replace("</version>","")
        $VersionWithoutBeta = $NuGetFileContent[$i].Replace("-beta", "")
        $VersionParts = $VersionWithoutBeta.Split('.')
        $VersionParts[2] = [int]$VersionParts[2] + 1
        $NuGetFileContent[$i] = "<version>$($VersionParts[0]).$($VersionParts[1]).$($VersionParts[2])-beta</version>"
    }

    $i++
}

$NuGetFileContent | Out-File -FilePath $Path