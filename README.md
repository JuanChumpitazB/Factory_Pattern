# EntregableII.FactoryPattern

## Entregable II - Factory Pattern

Aplicación de consola en C# que utiliza NotificadorFactory para crear notificadores según un parámetro.

La fábrica retorna un notificador de:

- Email
- SMS
- Teams

Cada implementación muestra un mensaje por consola. No se realizan envíos reales.

## Objetivo

Desacoplar la creación de objetos mediante una fábrica.

## Tecnologías

- C#
- .NET 10
- Aplicación de consola

## Ejecución

Desde la carpeta del proyecto:

`	ext
dotnet run
`

La aplicación crea y ejecuta un notificador para cada tipo soportado.
