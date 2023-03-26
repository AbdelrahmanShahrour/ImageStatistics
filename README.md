# ImageStatistics
ImageStatistics prj using dotnet

1. Install .NET 6 SDK:

The first step is to install the .NET 6 SDK on your Ubuntu machine. You can do this by following these steps:

* Open a terminal window and run the following command to download the Microsoft package signing key:

```Bash
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
```

* Use the following command to install the package signing key:
```Bash
sudo dpkg -i packages-microsoft-prod.deb
```

* Update the package list and install the .NET 6 SDK:
```Bash
sudo apt-get update
sudo apt-get install -y dotnet-sdk-6.0
```

2 . Create a new project:

  1. Once you have installed the .NET 6 SDK, you can create a new project using the `dotnet` command. Open a terminal window, navigate to the directory where you want to create the project, and run the following command:

  ```Bash
  dotnet new console
  ```
  
This will create a new console application with the default project structure.

3. Build and run the project:

  1. Once the project is created, you can build and run it using the following commands:

  ```Bash
  dotnet build
  ```

  ```Bash
  dotnet run
  ```
  
![image](https://miro.medium.com/v2/resize:fit:828/format:webp/1*-WtUrVBgLRZ_fnui6jRjxw.png) 

### the result: 

![image](https://github.com/AbdelrahmanShahrour/ImageStatistics/blob/main/Screenshot%20from%202023-02-25%2016-12-09.png) 
