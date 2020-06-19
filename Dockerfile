FROM mcr.microsoft.com/dotnet/core/sdk AS build
COPY . /tests
WORKDIR /tests
RUN dotnet test