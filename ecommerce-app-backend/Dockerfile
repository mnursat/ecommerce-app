# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src

# Restore
COPY ["src/EcommerceAppBackend.API/EcommerceAppBackend.API.csproj", "EcommerceAppBackend.API/"]
RUN dotnet restore "EcommerceAppBackend.API/EcommerceAppBackend.API.csproj"

# Build
COPY ["src/EcommerceAppBackend.API", "EcommerceAppBackend.API/"]
WORKDIR /src/EcommerceAppBackend.API
RUN dotnet build "EcommerceAppBackend.API.csproj" -c Release -o /app/build

# Stage 2: Publish
FROM build AS publish
RUN dotnet publish "EcommerceAppBackend.API.csproj" -c Release -o /app/publish

# Stage 3: Run
FROM mcr.microsoft.com/dotnet/aspnet:9.0
ENV ASPNETCORE_HTTP_PORTS=5001
EXPOSE 5001
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EcommerceAppBackend.API.dll"]