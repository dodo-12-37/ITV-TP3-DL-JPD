FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /src

#install npm
RUN apt-get update -yq \
    && apt-get install curl gnupg -yq \
    && curl -sL https://deb.nodesource.com/setup_14.x | bash \
    && apt-get install nodejs -yq

# Copy everything
COPY . .
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o /publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /App
COPY --from=build-env /publish .
ENV ConnectionStrings__DefaultConnection="Server=172.17.0.2;Database=GC.WebReact;User Id=SA;Password=yourStrong(!)Password;MultipleActiveResultSets=true"
ENTRYPOINT ["dotnet", "GC.WebReact.dll"]