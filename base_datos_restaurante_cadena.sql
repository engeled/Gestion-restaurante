
-- Crear base de datos
CREATE DATABASE IF NOT EXISTS RestauranteChain;
USE RestauranteChain;

-- Tabla Restaurante
CREATE TABLE Restaurante (
    idRestaurante INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    direccion VARCHAR(200),
    telefono VARCHAR(20),
    email VARCHAR(100),
    estado ENUM('activo', 'inactivo') DEFAULT 'activo'
);

-- Tabla Empleado
CREATE TABLE Empleado (
    idEmpleado INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    usuario VARCHAR(50),
    rol VARCHAR(50),
    email VARCHAR(100),
    contraseñaHasheada VARCHAR(255),
    estado ENUM('activo', 'inactivo') DEFAULT 'activo'
);

-- Relación Empleado y Restaurante
CREATE TABLE EmpleadoRestaurante (
    idEmpleadoRestaurante INT AUTO_INCREMENT PRIMARY KEY,
    idEmpleado INT,
    idRestaurante INT,
    fechaInicio DATE,
    fechaFin DATE,
    FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
    FOREIGN KEY (idRestaurante) REFERENCES Restaurante(idRestaurante)
);

-- Tabla Cliente
CREATE TABLE Cliente (
    idCliente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    telefono VARCHAR(20),
    email VARCHAR(100)
);

-- Tabla Categoria
CREATE TABLE Categoria (
    idCategoria INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100)
);

-- Tabla Producto (insumos)
CREATE TABLE Producto (
    idProducto INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    idCategoria INT,
    unidadMedida VARCHAR(20),
    FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria)
);

-- Inventario por Restaurante
CREATE TABLE Inventario (
    idInventario INT AUTO_INCREMENT PRIMARY KEY,
    idProducto INT,
    idRestaurante INT,
    stockActual DECIMAL(10,2),
    stockMinimo DECIMAL(10,2),
    precioCompra DECIMAL(10,2),
    fechaActualizacion DATE,
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto),
    FOREIGN KEY (idRestaurante) REFERENCES Restaurante(idRestaurante)
);

-- Compras de insumos
CREATE TABLE CompraInsumo (
    idCompra INT AUTO_INCREMENT PRIMARY KEY,
    fecha DATE,
    idEmpleado INT,
    idRestaurante INT,
    total DECIMAL(10,2),
    FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
    FOREIGN KEY (idRestaurante) REFERENCES Restaurante(idRestaurante)
);

-- Detalle de compra
CREATE TABLE DetalleCompra (
    idDetalleCompra INT AUTO_INCREMENT PRIMARY KEY,
    idCompra INT,
    idProducto INT,
    cantidad DECIMAL(10,2),
    precioUnitario DECIMAL(10,2),
    subtotal DECIMAL(10,2),
    FOREIGN KEY (idCompra) REFERENCES CompraInsumo(idCompra),
    FOREIGN KEY (idProducto) REFERENCES Producto(idProducto)
);

-- Mesas por Restaurante
CREATE TABLE Mesa (
    idMesa INT AUTO_INCREMENT PRIMARY KEY,
    numero INT,
    capacidad INT,
    idRestaurante INT,
    estado ENUM('libre', 'ocupada', 'reservada') DEFAULT 'libre',
    FOREIGN KEY (idRestaurante) REFERENCES Restaurante(idRestaurante)
);

-- Reservas de mesas
CREATE TABLE Reserva (
    idReserva INT AUTO_INCREMENT PRIMARY KEY,
    idCliente INT,
    idMesa INT,
    fechaHora DATETIME,
    estado ENUM('pendiente', 'confirmada', 'cancelada') DEFAULT 'pendiente',
    FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente),
    FOREIGN KEY (idMesa) REFERENCES Mesa(idMesa)
);

-- Platos del restaurante
CREATE TABLE Plato (
    idPlato INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    descripcion TEXT,
    precio DECIMAL(10,2),
    activo BOOLEAN DEFAULT TRUE
);

-- Menú
CREATE TABLE Menu (
    idMenu INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    descripcion TEXT,
    fechaInicio DATE,
    fechaFin DATE
);

-- Platos en el Menú
CREATE TABLE PlatoMenu (
    idPlatoMenu INT AUTO_INCREMENT PRIMARY KEY,
    idMenu INT,
    idPlato INT,
    FOREIGN KEY (idMenu) REFERENCES Menu(idMenu),
    FOREIGN KEY (idPlato) REFERENCES Plato(idPlato)
);

-- Pedidos
CREATE TABLE Pedido (
    idPedido INT AUTO_INCREMENT PRIMARY KEY,
    idCliente INT,
    idEmpleado INT,
    idRestaurante INT,
    idMesa INT,
    fecha DATETIME,
    estado ENUM('pendiente', 'en cocina', 'servido', 'pagado') DEFAULT 'pendiente',
    formaPago VARCHAR(50),
    FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente),
    FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
    FOREIGN KEY (idRestaurante) REFERENCES Restaurante(idRestaurante),
    FOREIGN KEY (idMesa) REFERENCES Mesa(idMesa)
);

-- Detalle del pedido
CREATE TABLE DetallePedido (
    idDetalle INT AUTO_INCREMENT PRIMARY KEY,
    idPedido INT,
    idPlato INT,
    cantidad INT,
    precioUnitario DECIMAL(10,2),
    subtotal DECIMAL(10,2),
    FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido),
    FOREIGN KEY (idPlato) REFERENCES Plato(idPlato)
);

-- Pagos
CREATE TABLE Pago (
    idPago INT AUTO_INCREMENT PRIMARY KEY,
    idPedido INT,
    monto DECIMAL(10,2),
    formaPago VARCHAR(50),
    fechaPago DATETIME,
    FOREIGN KEY (idPedido) REFERENCES Pedido(idPedido)
);

-- Reportes
CREATE TABLE Reporte (
    idReporte INT AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(50),
    idEmpleado INT,
    idRestaurante INT,
    fechaGeneracion DATETIME,
    descripcion TEXT,
    FOREIGN KEY (idEmpleado) REFERENCES Empleado(idEmpleado),
    FOREIGN KEY (idRestaurante) REFERENCES Restaurante(idRestaurante)
);
