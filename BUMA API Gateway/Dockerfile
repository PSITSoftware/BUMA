#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["BUMA API Gateway/BUMA API Gateway.csproj", "BUMA API Gateway/"]
RUN dotnet restore "BUMA API Gateway/BUMA API Gateway.csproj"
COPY . .
WORKDIR "/src/BUMA API Gateway"
RUN dotnet build "BUMA API Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BUMA API Gateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BUMA API Gateway.dll"]