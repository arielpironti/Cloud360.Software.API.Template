#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Cloud360.Software.Api.Template.API/Cloud360.Software.Api.Template.API.csproj", "src/Cloud360.Software.Api.Template.API/"]
COPY ["src/Cloud360.Software.Api.Template.Infrastructure/Cloud360.Software.Api.Template.Infrastructure.csproj", "src/Cloud360.Software.Api.Template.Infrastructure/"]
COPY ["src/Cloud360.Software.Api.Template.Domain/Cloud360.Software.Api.Template.Domain.csproj", "src/Cloud360.Software.Api.Template.Domain/"]
COPY ["src/Cloud360.Software.Api.Template.Application/Cloud360.Software.Api.Template.Application.csproj", "src/Cloud360.Software.Api.Template.Application/"]
RUN dotnet restore "src/Cloud360.Software.Api.Template.API/Cloud360.Software.Api.Template.API.csproj"
COPY . .
WORKDIR "/src/src/Cloud360.Software.Api.Template.API"
RUN dotnet build "Cloud360.Software.Api.Template.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cloud360.Software.Api.Template.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cloud360.Software.Api.Template.API.dll"]
