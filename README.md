# Cliente ASP.NET Web Forms para servicio WCF en C#

Proyecto de ejemplo desarrollado con **ASP.NET Web Forms**, **C#** y **.NET Framework 4.7.2** que consume un servicio **WCF** para validar usuarios y consultar datos remotos.

El repositorio muestra cómo integrar una aplicación web ASP.NET con un servicio WCF mediante una referencia de servicio, bindings de `System.ServiceModel` y una interfaz sencilla basada en Web Forms.

## Funcionalidades

La aplicación incluye:

- Formulario de acceso de usuarios.
- Validación de credenciales mediante un servicio WCF.
- Redirección a una página de datos tras un acceso correcto.
- Consulta remota del listado de usuarios.
- Visualización de resultados mediante `GridView`.
- Configuración de bindings y endpoints WCF.

## Tecnologías utilizadas

- **C#**
- **ASP.NET Web Forms**
- **.NET Framework 4.7.2**
- **Windows Communication Foundation (WCF)**
- **System.ServiceModel**
- **Visual Studio**
- **IIS Express**
- **HTML / CSS**

## Estructura principal

```text
Ejemplo-WebASPNET-2-2/
├── LoginPage.aspx
├── LoginPage.aspx.cs
├── DatosPage.aspx
├── DatosPage.aspx.cs
├── Connection.cs
├── Connected Services/
│   └── ServiceReference1/
├── Web.config
├── css/
│   └── Style.css
└── EjemploWebASPNET.csproj
```

### `LoginPage.aspx`

Contiene el formulario de acceso con los campos de usuario y contraseña.

### `LoginPage.aspx.cs`

Gestiona el evento de inicio de sesión y utiliza el servicio WCF para comprobar las credenciales mediante la operación `VerificarAcceso`.

### `DatosPage.aspx`

Página encargada de mostrar los datos obtenidos desde el servicio.

### `DatosPage.aspx.cs`

Consume la operación `obtenerUsuarios()` y enlaza el resultado con un control `GridView`.

### `Connection.cs`

Centraliza la creación del cliente WCF y la configuración del binding y del endpoint.

### `Connected Services/ServiceReference1`

Contiene el proxy generado por Visual Studio para consumir el contrato `IService1` del servicio WCF.

## Relación con el servicio WCF

Este proyecto funciona como **cliente web** de un servicio WCF que expone operaciones relacionadas con usuarios, entre ellas:

- `obtenerUsuarios`
- `VerificarAcceso`
- `InsertarUsuario`
- `EliminarUsuario`
- `DesactivarUsuario`

Por tanto, para probar la aplicación es necesario disponer del servicio WCF correspondiente en ejecución y ajustar su endpoint si la URL local es distinta.

El repositorio relacionado del servicio es:

**[Ejercicio-WCF-1-2](https://github.com/smarinwm/Ejercicio-WCF-1-2)**

## Puesta en marcha

1. Clona el repositorio:

```bash
git clone https://github.com/smarinwm/Ejemplo-WebASPNET-2-2.git
```

2. Abre `EjemploWebASPNET.sln` con **Visual Studio**.

3. Asegúrate de que el servicio WCF asociado está en ejecución.

4. Revisa la dirección del servicio configurada en:

```text
Connection.cs
Web.config
```

5. Si es necesario, actualiza el endpoint para que coincida con la URL del servicio WCF en tu entorno local.

6. Compila y ejecuta el proyecto mediante IIS Express o Visual Studio.

## Objetivo didáctico

Este proyecto permite trabajar conceptos como:

- Desarrollo web con ASP.NET Web Forms.
- Consumo de servicios WCF desde una aplicación cliente.
- Referencias de servicio en Visual Studio.
- Contratos y proxies WCF.
- Configuración de bindings y endpoints.
- Comunicación cliente-servidor.
- Autenticación básica contra un servicio remoto.
- Data binding con `GridView`.
- Integración entre aplicaciones .NET Framework.

## Consideraciones de seguridad

Este repositorio tiene finalidad educativa y **no debe utilizarse directamente en producción**.

Antes de llevar una solución similar a un entorno real conviene:

- Utilizar HTTPS y bindings seguros.
- Evitar endpoints sin cifrado cuando se transmitan credenciales.
- Implementar autenticación y autorización adecuadas.
- No almacenar ni comparar contraseñas en texto plano.
- Gestionar URLs y configuración sensible mediante mecanismos externos al código.
- Validar correctamente las entradas del usuario.
- Revisar la gestión de sesiones y errores de autenticación.

## Autor

**Silverio Marín** — Docente TIC en Valencia, especializado en programación y desarrollo de software.

Más contenidos sobre **programación y desarrollo de software**:

**[silveriomarin.com/programacion](https://silveriomarin.com/programacion/)**

GitHub: **[@smarinwm](https://github.com/smarinwm)**
