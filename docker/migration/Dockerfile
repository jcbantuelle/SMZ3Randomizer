FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN apt-get update -yq && apt-get install nodejs npm cmake build-essential python3.7 -yq
RUN ln -s /usr/bin/python3.7 /usr/bin/python3

ENV PATH $PATH:/root/.dotnet/tools
RUN dotnet tool install -g dotnet-ef --version 3.1.1

WORKDIR /app/WebRandomizer

COPY docker/migration/docker-entrypoint.sh /usr/local/bin/
RUN chmod +x /usr/local/bin/docker-entrypoint.sh
CMD "/usr/local/bin/docker-entrypoint.sh"
