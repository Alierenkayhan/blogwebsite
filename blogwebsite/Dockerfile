FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["blogwebsite/blogwebsite.csproj", "blogwebsite/"]
RUN dotnet restore "blogwebsite/blogwebsite.csproj"
COPY . .
WORKDIR "/src/blogwebsite"
RUN dotnet build "blogwebsite.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "blogwebsite.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "blogwebsite.dll"]