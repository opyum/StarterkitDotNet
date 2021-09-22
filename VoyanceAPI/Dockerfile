#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["VoyanceApi/VoyanceApi.csproj", "VoyanceApi/"]
COPY ["DTOs/DTOs.csproj", "DTOs/"]
COPY ["Commun/Commun.csproj", "Commun/"]
COPY ["DataAccessLayer/DataAccessLayer.csproj", "DataAccessLayer/"]
RUN dotnet restore "VoyanceApi/VoyanceApi.csproj"
COPY . .
WORKDIR "/src/VoyanceApi"
RUN dotnet build "VoyanceApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VoyanceApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VoyanceApi.dll"]