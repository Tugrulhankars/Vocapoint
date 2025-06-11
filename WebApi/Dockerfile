# 1. Runtime Image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# 2. Build Image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Sadece csproj dosyaları kopyalanıyor — Restore için yeterli
COPY ["WebApi/WebApi.csproj", "WebApi/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Core/Core.csproj", "Core/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Persistance/Persistance.csproj", "Persistance/"]

# Restore — sadece projeler bazında
WORKDIR "/src/WebApi"
RUN dotnet restore "WebApi.csproj"

# 🔥 Şimdi tüm kaynak dosyalarını kopyala (Program.cs, Controllers, vs.)
COPY . .

# Build aşaması
RUN dotnet build "WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish aşaması
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# 3. Final Image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "WebApi.dll"]
