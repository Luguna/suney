FROM mcr.microsoft.com/dotnet/core/sdk:3.0-bionic AS build

FROM mcr.microsoft.com/dotnet/core/runtime:3.0-alpine3.9 AS runtime
