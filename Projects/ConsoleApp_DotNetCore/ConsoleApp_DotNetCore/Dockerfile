#FROM microsoft/dotnet:2.0-runtime-nanoserver-sac2016 AS base
#WORKDIR /app
#
#FROM microsoft/dotnet:2.0-sdk-nanoserver-sac2016 AS build
#WORKDIR /src
#COPY ConsoleApp_DotNetCore/ConsoleApp_DotNetCore.csproj ConsoleApp_DotNetCore/
#RUN dotnet restore ConsoleApp_DotNetCore/ConsoleApp_DotNetCore.csproj
#COPY . .
#WORKDIR /src/ConsoleApp_DotNetCore
#RUN dotnet build ConsoleApp_DotNetCore.csproj -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish ConsoleApp_DotNetCore.csproj -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "ConsoleApp_DotNetCore.dll"]


FROM microsoft/dotnet:2.0-runtime-nanoserver-sac2016 AS base
WORKDIR /app

COPY /bin/debug/netcoreapp2.0/publish/ .

ENTRYPOINT ["dotnet", "ConsoleApp_DotNetCore.dll"]
