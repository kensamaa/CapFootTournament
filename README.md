# CapFootTournament

## Dependecies

# CQRS

<p>The Command and Query Responsibility Segregation (CQRS) model of segregation of command and query responsibilities separates read and update operations for a data store.</p>

![](img/cqrs.png)

# clean architecture

<p>Clean architecture is a software design philosophy that separates the elements of a design into ring levels. An important goal of clean architecture is to provide developers with a way to organize code in such a way that it encapsulates the business logic but keeps it separate from the delivery mechanism</p>

![](img/clean.png)
![](img/d.png)
![](img/ud.png)

## Creating the sql serer container command

<p>docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=myPass123" -p 1433:1433 --name primeHotelDb -d mcr.microsoft.com/mssql/server:2017-latest</p>

## Migration code

<p>add-migration InitialMigration</p>
<p>Update-Database</p>

## Reference

<a href="https://betterprogramming.pub/the-clean-architecture-beginners-guide-e4b7058c1165"> clean architecture medium</a>
