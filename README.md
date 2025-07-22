# DarkenedRTM-COD4

RTM Tool para Call of Duty 4 (PS3) desarrollada en C# con interfaz WinForms y conexión mediante CCAPI (Control Console API). El objetivo del proyecto es ofrecer una herramienta modular y pública que permita realizar acciones de Recovery, Non-Host y Protecciones en tiempo real, de forma responsable y educativa.

## 🎯 Características actuales

- ✅ Conexión a consola vía CCAPI (CEX o DEX)
- ✅ Gestión de conexión y attach con mensajes en pantalla y notificaciones en PS3
- ✅ Menú de Recovery:
  - Modificación de Prestige
  - Aplicación de nivel máximo (55)
  - Seteo de Kills, Deaths, Score y K/D Ratio
  - Función Unlock All
  - Validaciones y escritura en memoria en formato Big Endian

## 📡 ¿Qué es CCAPI?

[ControlConsoleAPI (CCAPI)](https://www.enstoneworld.com/) es una API que permite conectarse remotamente a consolas PlayStation 3 en modo CEX o DEX. Se utiliza para leer y escribir en la memoria de la consola en tiempo real desde una aplicación externa (como esta Tool en C#).

## 🧠 ¿Qué es el Big Endian?

La PS3 utiliza el formato de almacenamiento Big Endian, donde el byte más significativo se escribe primero. Al escribir valores como `int` o `float` en memoria, es necesario invertir el orden de los bytes con `Array.Reverse()` para que el valor sea interpretado correctamente en la consola.

## 🧱 Tecnologías utilizadas

- C# (.NET Framework 4.x)
- Windows Forms (UI)
- PS3Lib.dll (para interacción CCAPI)
- Visual Studio 2022
- CCAPI v2.80+

## ⚠️ Aviso

Este proyecto está orientado a propósitos educativos y de preservación. El uso indebido o malicioso del código no es responsabilidad del autor. Las funciones relacionadas con freeze, sniffing o manipulación de terceros no serán incluidas.

---
