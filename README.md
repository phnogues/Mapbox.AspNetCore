# Mapbox.AspNetCore
<img src="/icon.png" width="100" height="100" />

[![.NET](https://github.com/phsoftware/Mapbox.AspNetCore/actions/workflows/dotnet.yml/badge.svg)](https://github.com/phsoftware/Mapbox.AspNetCore/actions/workflows/dotnet.yml)

Library for interfacing with mapbox api

Supported functions :
- Geocoding
- ReverseGeocoding

## Get startred
Get an API key from mapbox website

Open your statup.cs, and use that code :
##### services.AddMapBoxServices(options=> options.UseApiKey(Configuration["MapboxApiKey"]));

Check the example project

## Release Note 
0.2.0
- upgrade to .Net 7
- add proximity support
