#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Losik.Games.Web/Losik.Games.Web.csproj", "Losik.Games.Web/"]
RUN dotnet restore "Losik.Games.Web/Losik.Games.Web.csproj"
COPY . .
WORKDIR "/src/Losik.Games.Web"
RUN dotnet build "Losik.Games.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Losik.Games.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Losik.Games.Web.dll"]