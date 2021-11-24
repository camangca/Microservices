# First step is specify the docke image that we want to pull up
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
# Working directory
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "PlatformService.dll" ]