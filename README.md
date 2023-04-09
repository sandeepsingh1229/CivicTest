# Blazor Server App and SQL Server Database - With Docker Compose

Watch Tutorial Video Now: https://www.youtube.com/watch?v=hpLvXNASyTI&list=PLzewa6pjbr3JQKhB_U_FiuYwQC70i-TyU&index=5

This is .Net Core Docker Tutorial [.Net Docker Tutorial] that explains how to containerize .Net application with SQL Server Database. Visual Studio provides the options to easily develop applications with Docker Support, Debug with Docker [Docker .Net Core Debug], and Deploy the Docker Container [Deploy .Net Core to Docker].

We are using the Official container image for Microsoft SQL Server on Linux for Docker Engine [SQL Server Docker]. We'll use this docker image for creating a container for SQL Server Database. Then the .Net Core application container can connect to the database container for read-write operations.

In this .NET Docker tutorial, you'll learn how to manage more than one container and communicate between them when using Container Tools in Visual Studio. Managing multiple containers requires container orchestration and requires an orchestrator such as Docker Compose, Kubernetes, or Service Fabric. Here, we'll use Docker Compose. Docker Compose is great for local debugging and testing in the course of the development cycle. This is a very important video as it covers a major part of Docker .Net Core Microservices.

Visual Studio provides a consistent way to develop Docker containers and validate your application locally. You can run and debug your apps in Linux or Windows containers running on your local Windows desktop with Docker installed, and you don't have to restart the container each time you make a code change.

You can view what's going on inside the containers that host your app by using the Containers window. If you're used to using the command prompt to run Docker commands to view and diagnose what's going on with your containers, this window provides a more convenient way to monitor your containers without leaving the Visual Studio IDE.

What is Docker Compose?
Docker Compose is a tool for defining and running multi-container Docker applications. With Compose, you use a YAML file to configure your application’s services. Then, with a single command, you create and start all the services from your configuration.

Docker .Net Core:
.NET Core can easily run in a Docker container. Containers provide a lightweight way to isolate your application from the rest of the host system, sharing just the kernel, and using resources given to your application. Learn how to use docker for .Net Core and deploy .Net Core to Docker.

.NET Core images
Official .NET Core Docker images are published to the Microsoft Container Registry (MCR) and are discoverable at the Microsoft .NET Core Docker Hub repository. Each repository contains images for different combinations of the .NET (SDK or Runtime) and OS that you can use.
Microsoft provides images that are tailored for specific scenarios. For example, the ASP.NET Core repository provides images that are built for running ASP.NET Core apps in production.

The tools included in Visual Studio for developing with Docker containers [.Net Core Docker Container] are easy to use, and greatly simplify building, debugging, and deployment for containerized applications. You can work with a container for a single project, or use container orchestration with Docker Compose or Service Fabric to work with multiple services in containers.

Docker support in Visual Studio:
Docker support is available for ASP.NET projects, ASP.NET Core projects, and .NET Core and .NET Framework console projects.

The support for Docker in Visual Studio has changed over a number of releases in response to customer needs. There are two levels of Docker support you can add to a project, and the supported options vary by the type of project and the version of Visual Studio. With some supported project types, if you just want a container for a single project, without using orchestration, you can do that by adding Docker support. The next level is container orchestration support, which adds appropriate support files for the particular orchestrator you choose.

Docker support for a .Net Project [Blazor Docker]:
You can enable Docker support during project creation by selecting Enable Docker Support when creating a new project. You can add Docker support to an existing project by selecting Add - Docker Support in Solution Explorer. The Add - Docker Support and Add - Container Orchestrator Support commands are located on the right-click menu (or context menu) of the project node for an ASP.NET Core project in Solution Explorer.

#CodingDroplets #Docker #Microservices
