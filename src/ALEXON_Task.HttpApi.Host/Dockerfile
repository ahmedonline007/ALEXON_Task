#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/ALEXON_Task.HttpApi.Host/ALEXON_Task.HttpApi.Host.csproj", "src/ALEXON_Task.HttpApi.Host/"]
COPY ["src/ALEXON_Task.Application/ALEXON_Task.Application.csproj", "src/ALEXON_Task.Application/"]
COPY ["src/ALEXON_Task.Domain/ALEXON_Task.Domain.csproj", "src/ALEXON_Task.Domain/"]
COPY ["src/ALEXON_Task.Domain.Shared/ALEXON_Task.Domain.Shared.csproj", "src/ALEXON_Task.Domain.Shared/"]
COPY ["src/ALEXON_Task.Application.Contracts/ALEXON_Task.Application.Contracts.csproj", "src/ALEXON_Task.Application.Contracts/"]
COPY ["src/ALEXON_Task.EntityFrameworkCore/ALEXON_Task.EntityFrameworkCore.csproj", "src/ALEXON_Task.EntityFrameworkCore/"]
COPY ["src/ALEXON_Task.HttpApi/ALEXON_Task.HttpApi.csproj", "src/ALEXON_Task.HttpApi/"]
RUN dotnet restore "./src/ALEXON_Task.HttpApi.Host/ALEXON_Task.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/ALEXON_Task.HttpApi.Host"
RUN dotnet build "./ALEXON_Task.HttpApi.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ALEXON_Task.HttpApi.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ALEXON_Task.HttpApi.Host.dll"]