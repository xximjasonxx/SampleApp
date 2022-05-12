FROM mcr.microsoft.com/dotnet/sdk:6.0 as base
WORKDIR /code

COPY . .
RUN dotnet restore && \
    dotnet publish -c Release -o /output

FROM mcr.microsoft.com/dotnet/aspnet:6.0 as final
WORKDIR /app

COPY --from=base /output .
EXPOSE 443
EXPOSE 80

CMD ["dotnet", "run", "SampleApi.dll"]