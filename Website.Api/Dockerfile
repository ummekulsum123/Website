FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS copier
WORKDIR /src
COPY ["Website.Api", "Website.Api/"]
COPY ["Website.Domain", "Website.Domain/"]
COPY ["Website.Infrastructure", "Website.Infrastructure/"]

FROM copier AS publish
WORKDIR /src/Website.Api
RUN dotnet publish "Website.Api.csproj" -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS final
EXPOSE 80
ARG Environment=Production
ENV ASPNETCORE_ENVIRONMENT=$Environment
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Website.Api.dll"]
