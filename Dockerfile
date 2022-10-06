FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-environment
WORKDIR /app
COPY ../src ./

RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-environment /app/out .
EXPOSE 80

# docker run -d -p 127.0.0.1:8080:80 --name gamming lottery-gamming-api

ENTRYPOINT ["dotnet", "Lottery.Gamming.Api.dll", "--environment=Development"]