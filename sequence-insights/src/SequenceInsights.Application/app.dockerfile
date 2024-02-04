# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy project files and restore dependencies
COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

# Copy published application from build stage
COPY --from=build-env /app/out .

# Set the entry point
ENTRYPOINT ["dotnet", "SequenceInsights.Application.dll"]
