#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BUMA Security Services/BUMA Security Services.csproj", "BUMA Security Services/"]
COPY ["Buma.Dominio/Buma.Dominio.csproj", "Buma.Dominio/"]
COPY ["../BUMA.Security.Servicios/BUMA.Security.Servicios.csproj", "../BUMA.Security.Servicios/"]
RUN dotnet restore "BUMA Security Services/BUMA Security Services.csproj"
COPY . .
WORKDIR "/src/BUMA Security Services"
RUN dotnet build "BUMA Security Services.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BUMA Security Services.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "buma.security.services.dll"]