# UF2-Tasques-per-a-casa

## T2.1 Inventario de funciones de Input (b)

| Función | Qué retorna | Cuándo usarla | Ejemplo de una línea |
| --- | --- | --- | --- |
| `Input.GetKey(KeyCode)` | `bool` (true mientras la tecla esté pulsada) | Acciones continuas (ej: mantener pulsado un botón para correr o disparar en ráfaga). | `if (Input.GetKey(KeyCode.Space)) { /* ... */ }` |
| `Input.GetKeyDown(KeyCode)` | `bool` (true solo el fotograma en que se pulsa la tecla) | Acciones de un solo uso (ej: saltar, abrir un inventario, disparar). | `if (Input.GetKeyDown(KeyCode.Space)) { Jump(); }` |
| `Input.GetKeyUp(KeyCode)` | `bool` (true solo el fotograma en que se suelta la tecla) | Acciones al soltar (ej: cargar un arco y soltar la flecha). | `if (Input.GetKeyUp(KeyCode.Space)) { ReleaseArrow(); }` |
| `Input.GetAxis(string)` | `float` (valor suave entre -1 y 1 con aceleración/desaceleración) | Movimiento fluido de personajes (caminar, conducir) con la inercia del Input Manager. | `float move = Input.GetAxis("Horizontal");` |
| `Input.GetAxisRaw(string)` | `float` (valores estrictos: -1, 0 o 1, sin transición) | Movimiento tipo arcade o menús donde quieres respuesta inmediata sin deslizamiento. | `float move = Input.GetAxisRaw("Horizontal");` |
| `Input.GetButtonDown(string)` | `bool` (true el fotograma que se pulsa un botón configurado) | Acciones ligadas a botones genéricos del Input Manager (ej: "Jump", "Fire1"). | `if (Input.GetButtonDown("Jump")) { /* ... */ }` |
