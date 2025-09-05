param(
    [Parameter(Mandatory=$true)]
    [string]$Name
)

Write-Host "Creating migration '$Name' using startup project configuration..." -ForegroundColor Yellow
dotnet ef migrations add $Name --project ./Cos.Internal.Dashboards.Data

if ($LASTEXITCODE -eq 0) {
    Write-Host "Migration '$Name' created successfully" -ForegroundColor Green
} else {
    Write-Host "Migration creation failed" -ForegroundColor Red
}