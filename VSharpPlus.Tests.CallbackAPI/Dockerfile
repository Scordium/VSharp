FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["VSharpPlus.Tests.CallbackAPI/VSharpPlus.Tests.CallbackAPI.csproj", "VSharpPlus.Tests.CallbackAPI/"]
RUN dotnet restore "VSharpPlus.Tests.CallbackAPI/VSharpPlus.Tests.CallbackAPI.csproj"
COPY . .
WORKDIR "/src/VSharpPlus.Tests.CallbackAPI"
RUN dotnet build "VSharpPlus.Tests.CallbackAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VSharpPlus.Tests.CallbackAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VSharpPlus.Tests.CallbackAPI.dll"]
