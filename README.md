# Integrate Your .NET Core API With FusionAuth Using FusionAuth Hosted Backend

Setup FusionAuth using docker. Follow the setup instructions [here](https://fusionauth.io/docs/v1/tech/tutorials/integrate-dotnet-api)

In a terminal run the commands below to startup the API:

```
cd MyAPI
dotnet publish -r osx-x64
bin/Debug/net7.0/osx-x64/publish/MyAPI
```

In another terminal serve the login pages by running the following commands:

```
cd LoginPage
npx http-server -a localhost -p 3000
```

The login page will be accessible on `http://localhost:3000`