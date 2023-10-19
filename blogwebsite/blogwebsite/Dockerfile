FROM mcr.microsoft.com/dotnet/framework/sdk:4.8
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish blogwebsite.csproj -c Release -o out
WORKDIR out
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet", "blogwebsite.dll"]