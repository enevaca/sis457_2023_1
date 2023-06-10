# sis457_2023_1

## Scaffold NetCore
Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=Minerva;User ID=usrminerva;Password=123456" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -F

## Error generación CAD

Modificar el archivo C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\Extensions\Microsoft\Entity Framework Tools\Templates\Includes\EF6.Utility.CS.ttinclude

Línea 192, función -> private DynamicTextTransformation(object instance)

Quitar cambiar NonPublic a Public, quedando de la siguiente manera:

_generationEnvironment = type.GetProperty("GenerationEnvironment", BindingFlags.Instance | BindingFlags.Public);
