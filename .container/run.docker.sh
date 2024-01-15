#!/bin/sh

docker build -f Dockerfile -t img-xo-azdo-proxy-api-$1 .

docker run -it --detach \
	--network xo -m_mandy \
	--name xo-azdo-proxy-api-$1 \
	-p 8000:80 \
	-p 8001:443 \
	-e ASPNETCORE_URLS="https://+;http://+" \
	-e ASPNETCORE_HTTPS_PORT=8001 \
	-e ASPNETCORE_ENVIRONMENT=Development \
	-e ASPNETCORE_Kestrel__Certificates__Default__Path=/root/.aspnet/https/aspnetcore-localhost-F49228DDFD1771875A1B6D9415EC27363D3DA105.pfx \
	-v ${HOME}/.aspnet/dev-certs/https/:/root/.aspnet/https/ \
	img-xo-azdo-proxy-api-$1