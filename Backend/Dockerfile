# Establece la imagen base de .NET Core para construir la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:6.0.413 AS base
WORKDIR /app
EXPOSE 80

# Establece la imagen base de .NET Core para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:6.0.413 AS build
WORKDIR /src
COPY ["Backend.csproj", "Backend/"]
RUN dotnet restore "Backend/Backend.csproj"
COPY . .
WORKDIR "/src/Backend"
RUN dotnet build "Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Backend.csproj" -c Release -o /app/publish

# Establece la imagen base de .NET Core para ejecutar la aplicación
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Backend.dll"]
