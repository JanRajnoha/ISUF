param (
    [Parameter(Mandatory=$true)][string]$Message,
    [string]$Color = "Yellow"
 )

$DefaultColor = [console]::ForegroundColor

[console]::ForegroundColor = "$Color"
Write-Output "$Message"
[console]::ForegroundColor = "$DefaultColor"