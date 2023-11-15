# Aplicación de administración de almacenes - QuickCarry

## Descripción

Esta una aplicación de escritorio diseñada para simplificar la administración de almacenes, brindando funcionalidades para realizar operaciones CRUD en paquetes y lotes, así como asignar lotes a camiones y paquetes a lotes. Esta aplicación es desarrollada por QuickCarry para facilitar la gestión eficiente de su inventario y procesos de logística.

## Tecnologías Utilizadas

- **Plataforma:** .NET Windows Forms
- **APIs Necesarias:**
  - [API de Autenticación](https://github.com/ReactivENM/api_auth): Gestión de autenticación de usuarios.
  - [API de Almacén](https://github.com/ReactivENM/api_warehouse): Provee los servicios necesarios para las operaciones de almacén.

## Funcionalidades Principales

1. **Gestión de Paquetes:**
   - Crear nuevos paquetes con información detallada.
   - Visualizar la lista de todos los paquetes almacenados.
   - Actualizar la información de un paquete existente.
   - Eliminar paquetes que ya no son necesarios.

2. **Gestión de Lotes:**
   - Crear lotes para organizar eficientemente los productos.
   - Ver la lista de todos los lotes disponibles.
   - Modificar la información asociada a un lote específico.
   - Eliminar lotes que ya no se requieren.

3. **Asignación de Lotes a Camiones:**
   - Asignar lotes específicos a camiones para su transporte.
   - Visualizar la asignación de lotes a camiones.

4. **Asignación de Paquetes a Lotes:**
   - Asignar paquetes a lotes para un mejor control.
   - Consultar la asignación de paquetes a lotes.

## Instalación y Configuración

1. Clona el repositorio desde GitHub:

   ```bash
   git clone https://github.com/ReactivENM/app_warehouse.git
   ```
2. Instalar Dependencias:

Asegúrate de tener instalado .NET y las dependencias necesarias para el proyecto.

3. Configurar Conexión a APIs:

Abre el proyecto en tu entorno de desarrollo (por ejemplo, Visual Studio).
Busca y actualiza las configuraciones de conexión en el código para que apunten a las URLs de las APIs necesarias.

4. Compilar y Ejecutar:

Compila el proyecto en tu entorno de desarrollo.
Ejecuta la aplicación resultante.
