# Mapbox.AspNetCore
<img src="/icon.png" width="100" height="100" />

[![NuGet latest version](https://badgen.net/nuget/v/Mapbox.AspNetCore/latest)](https://nuget.org/packages/Mapbox.AspNetCore)
[![.NET](https://github.com/phsoftware/Mapbox.AspNetCore/actions/workflows/build.yml/badge.svg)](https://github.com/phsoftware/Mapbox.AspNetCore/actions/workflows/build.yml)

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

1.1.0.0
- upgrade to .Net 8
- add support for response text language 

## Enjoy !
<a href="https://www.buymeacoffee.com/phnogues" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

