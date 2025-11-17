# Prueba 1 – Arbol y Grafo 

Aplicación de ejemplo en WinForms (C# 7.3) que incluye dos componentes independientes:
1. Gestión y recorridos de un árbol jerárquico visual (TreeView).
2. Construcción y exploración de un grafo no dirigido con cálculo de rutas vía BFS.

## Contenido funcional

### 1. Módulo Árbol (FrmArbol)
Operaciones sobre un único árbol mostrado con un TreeView.
Características:
- Un solo nodo raíz (no se permite agregar más de uno).
- Agregar nodos hijos al nodo seleccionado.
- Búsqueda de nodo por texto (resalta el encontrado en color amarillo).
- Eliminación del nodo seleccionado (subárbol incluido).
- Contador total de nodos (incluyendo raíz y todos los descendientes).
- Recorridos:
  - Preorden
  - Postorden
  - Por niveles (BFS)
- Visualización del recorrido en ListBox y también en un MessageBox concatenado con flechas.
Limitaciones actuales:
- No existe lógica de dominio en `arbolmodel` (archivo vacío).
- No hay validaciones avanzadas (nombres duplicados, caracteres inválidos, etc.).
- No se persiste el árbol (se pierde al cerrar el formulario).

### 2. Módulo Grafo (FrmGrafo)
Manipulación de un grafo no dirigido de “edificios”.
Características:
- Agregar edificios (nodos) únicos (case-insensitive).
- Conectar dos edificios con distancia positiva (aristas bidireccionales).
- Representación textual del grafo (lista de adyacencia).
- Cálculo de ruta entre dos edificios usando BFS (minimiza saltos, no pesos).
- Reconstrucción de ruta y suma de distancias de las aristas atravesadas.
Validaciones:
- Nombres no vacíos.
- No conecta un nodo consigo mismo.
- Distancia > 0.
- Se exige que ambos edificios existan.
Advertencia:
- BFS actual encuentra mínima cantidad de aristas, no necesariamente la distancia mínima ponderada; para eso se requeriría Dijkstra.

### 3. Formulario Principal (FrnPrincipal)
- Menú principal con opciones para abrir los formularios de Árbol y Grafo.
- Opción de salida de la aplicación.
Nota: Los textos de los ítems del menú están invertidos funcionalmente:
- “Arbol” abre el formulario de Grafo.
- “Arbol” y “Grafo” deberían revisarse para alinearlos semánticamente (en código: `grafoToolStripMenuItem` lanza `new FrmArbol()` y `arbolToolStripMenuItem` lanza `new FrmGrafo()`).

## Estructura del proyecto
- Program.cs: Punto de entrada (arranca FrnPrincipal).
- Formularios:
  - `Formularios/FrnPrincipal.*`
  - `Formularios/FrmArbol.*`
  - `Formularios/FrmGrafo.*`
- Modelos:
  - `Modelos/GrafoModel.cs`: Lógica de grafo (diccionario de listas de adyacencia).
  - `Modelos/arbolmodel.cs`: Placeholder sin implementación.
- Recursos `.resx` asociados a cada formulario.

## GrafoModel (resumen API)
- `bool AgregarEdificio(string nombre)`
- `bool Conectar(string origen, string destino, int distancia)`
- `string RepresentacionTexto()`
- `string RutaBfs(string origen, string destino)`

## Ejemplo ruta (Grafo)
Edificios: A, B, C  
Conexiones: A–B (10), B–C (4)  
Ruta solicitada: A → C  
Resultado: `Ruta (3 edificios, distancia total 14): A -> B -> C`

## Construcción y ejecución
1. Abrir la solución en Visual Studio 2022.
2. Verificar el framework: __Project > Properties > Application > Target framework__ = .NET Framework 4.7.2.
3. Compilar: __Build > Build Solution__.
4. Ejecutar: __Debug > Start Without Debugging__ o __Debug > Start Debugging__.

## Requisitos técnicos
- .NET Framework 4.7.2
- C# 7.3
- WinForms


## Rama y repositorio
Rama activa: modularizacion  
Remoto: origin (GitHub) - “Caso-de-estudio-Arboles-”  




## Estado actual
Funcional para demostración interactiva básica. Estructura simple, sin capas adicionales (no MVP/MVVM). Lista para ser extendida.
	