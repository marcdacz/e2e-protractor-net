# e2e-protractor-net
End-to-end test automation template utilising Protractor for .NET

[![protractor logo](http://www.protractortest.org/img/protractor-logo-450.png)](http://www.protractortest.org/#/) <a href="https://blogs.msdn.microsoft.com/dotnet/2017/08/14/announcing-net-core-2-0/"><img src="https://docs.microsoft.com/en-us/dotnet/images/hub/netcore.svg" align="left" height="96" width="96" ></a>






### Features:
- Using **.NET Core 2.0** which allows execution of tests in different platforms (ie. Windows, Linux and Mac OS)
- Page Object Model 

### Pre-requisitie:
1. Ensure that you have installed [.NET Core 2.0](https://www.microsoft.com/net/download/core)
2. Install docker, pull the selenium-chrome-debug image from the [hub](https://hub.docker.com/r/selenium/standalone-chrome-debug/) then start the docker container
    ```sh
    $ docker pull selenium/standalone-chrome-debug
    $ docker run -d -p 4444:4444 selenium/standalone-chrome-debug
    ```

### Installation:
Clone the repository then restor and build the solution from the command-line:
```sh
$ cd e2e-protractor-net
$ dotnet restore
$ dotnet build
```

### Execution:
To execute the tests from the command-line:
```sh
$ cd .\e2e-protractor-net\E2E.Protractor.Net.Tests
$ dotnet test
```

Alternatively, on Windows or Mac OS you can use Visual Studio to restore, build and execute the tests.

### Folder Structure:
1. Config
    - This folder contains the Browser configuration as well as the Driver Context used in tests
2. Pages
    - This folder contains the Page Object Model for each page
    - Note that another way to write the POM pattern is the PageFactory. Unfortunately, this is not yet fully supported in .NET Core 2.0. See this [issue](https://github.com/SeleniumHQ/selenium/issues/4387).
3. Tests
    - This folder contains the tests 





