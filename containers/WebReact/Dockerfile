FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /src

# Copy everything
COPY ./src .
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o /publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /App
COPY --from=build-env /publish .
ENTRYPOINT ["dotnet", "GC.WebReact.dll"]