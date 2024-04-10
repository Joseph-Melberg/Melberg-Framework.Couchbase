# MelbergFramework.Infrastructure.Couchbase
Couchbase implementation for Melberg-Framework

# Overview

An very opinionated couchbase package that trades security for ease of use.  Given a couchbase user with administration rights, it creates a bucket as detailed in the appsettings.json and creates collections as requested by the BaseRepository implementations.

# Anatomy of Appsettings.json

Place the values in the "Couchbase" section of the appsettings.json, see demo example [here](https://github.com/MelbergFramework/MelbergFramework.Infrastructure.Couchbase/blob/main/Demo/appsettings.json).

## General Execution
This project requires dotnet 8 sdk to run (install link [here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)).
## How to run a Redis Server
Docker installation guide for couchbase [here](https://docs.couchbase.com/server/current/install/getting-started-docker.html).

