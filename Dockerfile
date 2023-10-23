# Use the official .NET 6 SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Use the official ASP.NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

WORKDIR /app
COPY --from=build /app/out ./

# Expose the port your application listens on
EXPOSE 80

# Start the application
ENTRYPOINT ["dotnet", "WebAppApplication.dll"]
