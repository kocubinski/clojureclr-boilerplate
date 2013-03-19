$webClient = New-Object System.Net.WebClient
$webClient.DownloadFile(
    "https://dl.dropbox.com/u/101986306/Microsoft.Dynamic.dll",
    "..\lib\Microsoft.Dynamic.dll")
$webClient.DownloadFile(
    "https://dl.dropbox.com/u/101986306/Microsoft.Scripting.dll",
    "..\lib\Microsoft.Script.dll")
