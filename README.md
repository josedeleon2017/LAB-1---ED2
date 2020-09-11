# LABORATORIO #1

### **Objetivos:**

- Aplicar los conceptos de Árboles Multicamino
- Crear múltiples proyectos en una solución de Visual Studio
- Crear una API utilizando los conceptos aprendidos.
- Manipular archivos en una API

***Kevin Romero 1047519***

***José De León   1072619***

---

### Contenido

- Implementación de un árbol multicamino genérico de grado variable
- Implementación del un árbol multicamino de enteros en consola
- Implementación del un árbol multicamino de películas en una API

---

### Uso del Proyecto de Consola

Al compilar la clase ***program*** observará los resultados de los recorridos *inorden*, *preorden* y *postorden* de una secuencia de enteros previamente agregada al árbol multicamino de grado tres. 

---

### Uso de la API

1. Haga una petición **POST** en ***api/movies*** agregando en el apartado raw del body lo siguiente

    ```json
    {
    	"order": 5
    }
    ```

    Con esto se incializará un árbol del grado específicado, no menor a grado dos.

2. Haga una petición **POST** en ***api/movies/populate*** agregando en el apartado form-data el archivo Json de prueba, la llave con la que se ingresa el archivo deberá llamarse **file**
3. Haga una petición **GET** en ***api/movies/{traversal}*** intercambiando el parámetro de la petición por el recorrido desado (ej: ***api/movies/inorden*** , ***api/movies/preorden*** , ***api/movies/postorden***)

Para volver a iniciar el árbol con distinto grado, repita la secuencia anterior variando el grado ingresado en el inciso uno.
