FROM mcr.microsoft.com/dotnet/aspnet AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk AS build
ARG configuration=Release
WORKDIR /src
COPY ["firstmicroservice_shobhit/firstmicroservice_shobhit.csproj", "firstmicroservice_shobhit/"]
RUN dotnet restore "firstmicroservice_shobhit\firstmicroservice_shobhit.csproj"
COPY . .
WORKDIR "/src/firstmicroservice_shobhit"
RUN dotnet build "firstmicroservice_shobhit.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "firstmicroservice_shobhit.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "firstmicroservice_shobhit.dll"]
