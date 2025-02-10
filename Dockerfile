# Use Linux-based .NET image for compatibility with Railway
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files
COPY ["Portfolio.csproj", "."]
RUN dotnet restore "./Portfolio.csproj"

# Copy and build application
COPY . .
RUN dotnet publish "./Portfolio.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Use a lightweight runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "Portfolio.dll"]
