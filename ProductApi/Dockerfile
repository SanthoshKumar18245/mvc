# Use the official .NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Set the working directory
WORKDIR /app

# Copy the published API files
COPY ./publish .

# Expose the default API port
EXPOSE 80

# Run the API
ENTRYPOINT ["dotnet", "ProductApi.dll"]
