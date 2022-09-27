$ver = $args[0]
dotnet pack /p:Version="$ver" --configuration Debug --output "nupkg"  AggregatorLibrary.sln