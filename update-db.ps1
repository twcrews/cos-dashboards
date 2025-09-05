param(
    [string]$Connection = $null
)

Set-Location Cos.Internal.Dashboards

if ($Connection) {
    dotnet ef database update --project ../Cos.Internal.Dashboards.Data --connection $Connection
} else {
    dotnet ef database update --project ../Cos.Internal.Dashboards.Data
}

if ($LASTEXITCODE -eq 0) {
    Write-Host "Database updated successfully" -ForegroundColor Green
} else {
    Write-Host "Database update failed" -ForegroundColor Red
}