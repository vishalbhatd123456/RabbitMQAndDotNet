# RabbitMQAndDotNet

Needed tools and software :

 1) Dotnet sdk (latest is ~7)
 2) Docker for pulling RabbitMQ images
 3) Visual Studio / VSCode (former is preferred over here)
 4) RabbitMQClient Nuget Package

Docker command to pull the RabbitMQ Image from Docker Hub : docker run -d --hostname my-rabbit --name ecom-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management

Here the port numbers are not to be changed as these are managed for the RabbitMQ specifically and might break the changes otherwise

For monitoring the health of the RabbitMQ : 

1)Open your browser and type http://localhost:15672/#/
2) You can view the statistics such as disk usage, incomming traffic load, Queues (initially null) set up, etc...
 
By default refer to the RabbitMQ Offcial doc for the admin password and username 
