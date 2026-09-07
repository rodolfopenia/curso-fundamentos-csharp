# ClasesFundamento

Este proyecto contiene un archivo por cada clase/video (`Program-videoNN.cs`) más
un `Program.cs` por defecto. Como cada uno usa **top-level statements**, .NET
solo permite que exista uno compilado a la vez por proyecto (si no, aparece el
error `CS8802: Solo una unidad de compilación puede tener instrucciones de
nivel superior`).

Para evitar ese error, el `.csproj` excluye por defecto todos los
`Program-video*.cs` y solo incluye el que se indique mediante la propiedad
MSBuild `Video`.

## Cómo ejecutar

**Correr el `Program.cs` por defecto:**

```powershell
dotnet run
```

**Correr una clase/video específico** (por ejemplo `Program-video24.cs`):

```powershell
dotnet run -p:Video=24
```

Esto compila únicamente `Program-video24.cs` (excluyendo `Program.cs` y el
resto de los videos), evitando el error CS8802.

## Cómo funciona

En `ClasesFundamento.csproj`:

```xml
<ItemGroup>
  <!-- Se excluyen todos los Program-videoNN.cs por defecto -->
  <Compile Remove="Program-video*.cs" />
</ItemGroup>

<ItemGroup Condition="'$(Video)' != ''">
  <!-- Si se pasa -p:Video=NN, se excluye Program.cs y se incluye el video pedido -->
  <Compile Remove="Program.cs" />
  <Compile Include="Program-video$(Video).cs" />
</ItemGroup>
```

## Agregar una nueva clase

1. Crear el archivo `Program-videoNN.cs` con tus instrucciones de nivel
   superior (top-level statements).
2. Ejecutarlo con `dotnet run -p:Video=NN`. No hace falta tocar el `.csproj`.
