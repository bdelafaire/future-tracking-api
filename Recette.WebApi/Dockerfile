#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Recette.WebApi/Recette.WebApi.csproj", "Recette.WebApi/"]
RUN dotnet restore "Recette.WebApi/Recette.WebApi.csproj"
COPY . .
WORKDIR "/src/Recette.WebApi"
RUN dotnet build "Recette.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Recette.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Recette.WebApi.dll"]