FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Lab7AdvNET/Lab7AdvNET.csproj", "Lab7AdvNET/"]
RUN dotnet restore "Lab7AdvNET/Lab7AdvNET.csproj"
COPY . .
WORKDIR "/src/Lab7AdvNET"
RUN dotnet build "Lab7AdvNET.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lab7AdvNET.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lab7AdvNET.dll"]
