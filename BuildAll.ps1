$ver = (Get-Date).ToString("yyyy.MM.dd.HHmm")

rm -r -Force "nupkg"

./BuildDebug $ver