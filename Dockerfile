# Use the .NET SDK image to build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy project files
COPY ["Portfolio.csproj", "."]
RUN dotnet restore "./Portfolio.csproj"

# Copy the rest of the app files and publish
COPY . .
RUN dotnet publish "./Portfolio.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Use a lightweight runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "Portfolio.dll"]
