# DarkenedRTM-COD4

RTM Tool para **Call of Duty 4 (PS3, versión BLES)** desarrollada en **C#** con interfaz **WinForms** y conexión mediante **CCAPI (Control Console API)**.  
El objetivo del proyecto es ofrecer una herramienta modular y pública que permita realizar acciones de **Recovery**, **Non-Host** y futuras **Protecciones**, de forma responsable y educativa.

---

## 🎯 Características actuales

### ✅ Conexión
- Conexión a consola vía **CCAPI** (modo CEX o DEX)
- Gestión de conexión y attach con validación, mensajes y notificaciones vía Trophy en PS3

### 🛠 Recovery Menu
- Modificación de Prestige (0–10)
- Nivel máximo (Level 55 - XP)
- Seteo de:
  - Kills
  - Deaths
  - Score
  - K/D Ratio
- Función **Unlock All**
- Cambiar nombre de usuario + función **Reset Name** que almacena el nombre original en tiempo real

### 🧠 Non-Host Menu *(fase de testeo)*
- Toggle **Red Boxes** (`0x001206C8`)
- Toggle **Super Steady Aim** (`0x00AB8EC`)
- Toggle **No Recoil** (`0x19B244`)
- Toggle **UAV Always On** (`0x0011FD98`)
- Validadores de conexión antes de ejecutar cualquier función
- Estados ON/OFF visuales en los botones (verde/rojo)

---

## 🧠 ¿Qué es el Big Endian?

La PS3 utiliza formato de almacenamiento **Big Endian**, es decir, el byte más significativo se almacena primero.  
Por eso usamos métodos como `BitConverter.GetBytes()` + `Array.Reverse()` antes de escribir en la memoria para que los valores (int, float, string) sean interpretados correctamente por el juego.

---

## 📡 ¿Qué es CCAPI?

[ControlConsoleAPI (CCAPI)](https://www.enstoneworld.com/) es una API que permite:
- Conectarse remotamente a consolas PS3 (CEX o DEX)
- Leer y escribir valores directamente en la memoria RAM de la consola en tiempo real
- Enviar notificaciones tipo Trophy, reiniciar procesos, cambiar LEDs, y más

Es indispensable para conectar la Tool con la consola y aplicar modificaciones.

---

## 🔧 Tecnologías utilizadas

| Tecnología        | Uso principal                        |
|------------------|--------------------------------------|
| **C# (.NET)**    | Lógica principal del programa        |
| **Windows Forms**| Interfaz gráfica (Recovery / NonHost)|
| **PS3Lib.dll**   | Comunicación con CCAPI               |
| **Visual Studio**| Desarrollo del proyecto              |
| **CCAPI v2.80+** | Conexión y acceso remoto a PS3       |

---

## 🖼 Logos del proyecto

El proyecto incluye logos y arte digital estilo black-metal, generados con IA:  
- Recovery → Corona con cuchillo estilo *CobraTec*
- Non-Host → AK con mira táctica, bayoneta y lanzagranadas

Diseños monocromáticos tipo *scratchboard*, inspirados en estética underground y en el Usuario " Warhead ".

---

## ⚠️ Aviso

> Este proyecto tiene fines educativos, de prueba y preservación digital.  
> El uso indebido del software es responsabilidad exclusiva del usuario.  
> No se incluye ni incluirá ninguna función relacionada a freeze lobbies, packet sniffing, manipulación de terceros o daño a consolas.

---

## 🚀 Próximas funciones

- Módulo de Protecciones
- Editor de Stats avanzados
- Dump de offsets personalizado
- Modo seguro para prevenir softlocks

> Video de Demostracion: https://www.youtube.com/watch?v=rn2JDXdoSo8

---
