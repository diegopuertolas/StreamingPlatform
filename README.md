# Plataforma de streaming

Una plataforma dispone de diferentes tipos de contenido.

Crear una clase abstracta:

```csharp
Contenido
```

con las propiedades:

- Título.
- Duración.

Crear:

```text
Contenido
 |
 +-- Pelicula
 |
 +-- Serie
 |
 +-- Documental
```

Cada clase tendrá además información específica.

## Pelicula

- Director.

## Serie

- Número de temporadas.

## Documental

- Temática.

La clase `Contenido` definirá:

```csharp
public abstract string ObtenerDescripcion();
```

Cada clase hija deberá implementar el método.

Crear:

- 2 películas.
- 2 series.
- 1 documental.

Almacenar todos los objetos en:

```csharp
List<Contenido>
```

Recorrer la colección y mostrar la descripción de cada contenido.

## Buscar contenido

Solicitar al usuario:

```csharp
Título a buscar:
```

Buscar el contenido recorriendo la colección.

La búsqueda no deberá depender de mayúsculas y minúsculas.

Si existe:

```bash
Contenido encontrado:

Interstellar - 169 minutos
```

Si no existe:

```csharp
No se ha encontrado el contenido.
```

## Filtrar películas

Utilizando la colección del ejercicio de streaming, mostrar solamente los objetos que sean de tipo Pelicula.

Utilizar el operador:

```csharp
is
```

Después, modificar el programa para mostrar únicamente las series.

Responder:

1. ¿De qué tipo es la colección?
2. ¿De qué tipo es la variable utilizada en el foreach?
3. ¿Cómo puede el programa saber si un determinado Contenido es realmente una Pelicula?