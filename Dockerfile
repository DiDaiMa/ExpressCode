#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ExpressCode.Api/ExpressCode.Api.csproj", "ExpressCode.Api/"]
COPY ["ExpressCode.Model/ExpressCode.Model.csproj", "ExpressCode.Model/"]
COPY ["ExpressCode.Services/ExpressCode.Services.csproj", "ExpressCode.Services/"]
COPY ["ExpressCode.Repository/ExpressCode.Repository.csproj", "ExpressCode.Repository/"]
COPY ["ExpressCode.Common/ExpressCode.Common.csproj", "ExpressCode.Common/"]
RUN dotnet restore "ExpressCode.Api/ExpressCode.Api.csproj"
COPY . .
WORKDIR "/src/ExpressCode.Api"
RUN dotnet build "ExpressCode.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExpressCode.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "ExpressCode.Api.dll"]
CMD ["dotnet", "ExpressCode.Api.dll"]
