# Use Windows Server Core image with IIS & ASP.NET
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8

# Set the working directory
WORKDIR /inetpub/wwwroot

# Copy published files into IIS directory
COPY ./publish/ .

# IIS automatically serves the application
