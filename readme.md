#ClashSharp

##A C# client library for the Clash of Clans API
Register for your own developer account here - https://developer.clashofclans.com/
Create your token(s) here - https://developer.clashofclans.com/#/account


##Configure Your API Access Token

Create a config file in the same location as your App.config / Web.config called `app.secrets.config`.  Put this config in the new file and set "value" to your API access token. 

```
<?xml version="1.0" encoding="utf-8" ?>
<appSettings>
  <add key="clashAPIKey" value="" />
</appSettings>
```

*Make sure you don't commit your token to source control!*
