# ===== Etapa de BUILD =====
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiamos primero la solución y los csproj para cachear el restore
#COPY ["SchoolMeBackend.sln", "."]
COPY ["Web/Web.csproj", "Web/"]
COPY ["Business/Business.csproj", "Business/"]
COPY ["Data/Data.csproj", "Data/"]
COPY ["Entity/Entity.csproj", "Entity/"]
COPY ["Utilities/Utilities.csproj", "Utilities/"]

# Restore del proyecto Web (o de la solución si prefieres)
RUN dotnet restore "Web/Web.csproj"

# Ahora sí, copiamos TODO el código
COPY . .

# Publicamos en Release a una carpeta limpia
RUN dotnet publish "Web/Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

# ===== Etapa FINAL (runtime) =====
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

# Importante: expone HTTP en 8080 y forzamos que Kestrel escuche ahí
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Copiamos el publish
COPY --from=build /app/publish .

# Arranque de la API
ENTRYPOINT ["dotnet", "Web.dll"]