# Sistema de Gestión para Restaurante

Aplicación de escritorio desarrollada en C# y .NET 6 para automatización de operaciones de restaurante con gestión de pedidos, control de inventarios y reportes gerenciales.

---

## Descripción del Proyecto

Sistema de escritorio que automatiza las operaciones de **El Rincón del Sabor**, un restaurante familiar en Lima que atiende 120 clientes diarios. La aplicación permite gestionar pedidos en tiempo real, controlar inventarios de ingredientes, cambiar estados de órdenes y generar reportes estadísticos de ventas y stock.

**Contexto del negocio:** Restaurante con 5 años de operación, 40 comensales de capacidad, 15 empleados, especializado en comida criolla peruana que enfrentaba desafíos operativos derivados de procesos manuales de registro y control.

**Solución implementada:**
- Sistema de escritorio con C# y .NET 6 para automatización de operaciones
- Gestión digital de pedidos con seguimiento de estados
- Control de inventario de ingredientes con alertas de stock bajo
- Reportes automatizados de ventas, productos y rentabilidad
- Sincronización en tiempo real entre pedidos e inventario

**Impacto:** Reducción del 70% en errores operativos mediante automatización de procesos manuales y sincronización en tiempo real entre inventarios y facturación.

**Tecnologías:** C# • .NET 6 • Windows Forms • SQL Server • Entity Framework Core

---

## Funcionalidades del Sistema

### Gestión de Pedidos
- **Registro de pedidos**: Captura de plato, cantidad y fecha del pedido
- **Eliminación de pedidos**: Cancelación de órdenes pendientes
- **Control de estados**: Actualización del estado de pedidos (Pendiente → En Preparación → Listo)
- **Visualización en tiempo real**: Tablero de pedidos activos con estados actualizados
- **Validaciones automáticas**: Control de campos obligatorios y cantidades válidas

### Control de Ingredientes
- **Inventario de ingredientes**: Visualización completa del stock disponible
- **Monitoreo de niveles**: Control de cantidades en tiempo real
- **Identificación de ingredientes críticos**: Detección automática de productos con stock bajo
- **Actualización automática**: Sincronización del inventario con pedidos procesados

### Interfaz Especializada
- **Módulo de Meseros**: Registro rápido de pedidos con selección de platos y cantidades
- **Módulo de Cocina**: Visualización de pedidos pendientes y actualización de estados
- **Módulo de Administración**: Acceso a reportes gerenciales y control de inventario

---

## Reportes Estadísticos

El sistema genera los siguientes reportes automatizados:

### Reporte 1: Cantidad de Menús Vendidos
Muestra el total de menús vendidos en un periodo, permitiendo evaluar el volumen de operaciones del restaurante.

### Reporte 2: Ingredientes con Stock Bajo
Lista los ingredientes que han alcanzado niveles críticos de inventario, facilitando la gestión de compras y prevención de desabastecimiento.

### Reporte 3: Menús Más Vendidos
Identifica los platos con mayor demanda, permitiendo optimizar el menú y la gestión de ingredientes más utilizados.

### Reporte 4: Total Recaudado por Fecha
Calcula los ingresos totales generados en una fecha específica, proporcionando información para análisis de rentabilidad diaria.

---

## Aplicaciones Generales

Este tipo de sistema se utiliza en diversos establecimientos del sector gastronómico:

**Restaurantes y Cafeterías**  
Control operativo de pedidos, inventario de ingredientes y reportes de ventas para establecimientos de distintos tamaños.

**Bares y Pubs**  
Gestión de órdenes de bebidas y alimentos con control de stock de insumos críticos.

**Hoteles y Hostales**  
Administración de servicios de alimentación con seguimiento de estados de pedidos y control de costos.

**Servicios de Catering**  
Planificación de eventos con gestión de ingredientes necesarios y análisis de rentabilidad por servicio.

**Comedores Empresariales**  
Control de menús diarios con reportes de consumo y gestión de inventario de insumos.

---

## Licencia

Proyecto desarrollado con fines académicos.

---

**Curso:** Fundamento de Sistemas de Información         
**Grupo:** #             
**Ciclo:** 2025-1           
**Desarrollado durante:** Mar 2025 - Jul 2025
