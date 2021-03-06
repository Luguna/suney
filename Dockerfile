FROM mcr.microsoft.com/dotnet/core/sdk:3.0-bionic AS build
WORKDIR /app
COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:3.0-alpine3.9 AS runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "suney.dll"]