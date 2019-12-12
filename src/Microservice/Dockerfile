FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Microservice/Microservice.csproj", "Microservice/"]
RUN dotnet restore "Microservice/Microservice.csproj"
COPY . .
WORKDIR "/src/Microservice"
RUN dotnet build "Microservice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Microservice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Microservice.dll"]
