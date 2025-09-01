Coverlet
========

For official documentation, see: https://github.com/coverlet-coverage/coverlet

```
dotnet tool install -g dotnet-reportgenerator-globaltool
```

From you tests projects dir:

```
dotnet test --collect "XPlat Code Coverage"
```

```
cd TestResults
cd [GUID]
reportgenerator -reports:coverage.cobertura.xml -reporttypes:Html -TargetDir:.
``` 