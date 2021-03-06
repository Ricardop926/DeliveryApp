USE [DB_MafiaTech]
GO
/****** Object:  Table [dbo].[tbl_cliente]    Script Date: 17/06/5022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cliente](
	[IdCliente] [int]() NOT  NULL,
	[Nombre] [varchar]() NULL,
	[Email] [varchar](50) NULL,
	[FechaIngreso] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_detallepedido]    Script Date: 17/06/5022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_detallepedido](
	[idDetallePedido] [int]() NOT NULL,
	[IdPedido] [int]() NULL,
	[IdProducto] [int]() NULL,
	[IdEmpleado] [int]() NULL,
	[IdRestaurante] [int]() NULL,
	[NombreRestautante] [varchar](50) NULL,
	[NombreEmpleado] [varchar](50) NULL,
	[PrecioUnidad] [int]() NULL,
	[cantidad] [int]() NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetallePedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_empleado]    Script Date: 17/06/5022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_empleado](
	[IdEmpleado] [int]() NOT NULL,
	[NombreEmpleado] [varchar](50) NULL,
	[FechaNcimiento] [datetime]() NULL,
	[FechaIngreso] [datetime]() NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_pedidos]    Script Date: 17/06/5022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pedidos](
	[IdPedido] [int]() NOT NULL,
	[IdCliente] [int]() NULL,
	[IdProducto] [int]() NULL,
	[Fecha] [datetime]() NULL,
	[DireccionEntrega] [varchar](50) NULL,
	[IdEmpleado] [int]() NULL,
	[Precio] [int]() NULL,
	[iva] [int]() NOT NULL,
	[Total] [int]() NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_producto]    Script Date: 17/06/5022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_producto](
	[IdProducto] [int]() NOT NULL,
	[NombreProducto] [varchar](50) NULL,
	[IdRestaurante] [int]() NULL,
	[Precio] [int]() NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_restaurante]    Script Date: 17/06/5022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_restaurante](
	[IdRestaurante] [int]() NOT NULL,
	[NombreRestautante] [varchar](50) NULL,
	[DireccionRestaurante] [varchar](50) NULL,
	[EmailRestaurante] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRestaurante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_detallepedido] ADD  DEFAULT (NULL) FOR [IdPedido]
GO
ALTER TABLE [dbo].[tbl_detallepedido] ADD  DEFAULT (NULL) FOR [IdProducto]
GO
ALTER TABLE [dbo].[tbl_detallepedido] ADD  DEFAULT (NULL) FOR [IdEmpleado]
GO
ALTER TABLE [dbo].[tbl_detallepedido] ADD  DEFAULT (NULL) FOR [IdRestaurante]
GO
ALTER TABLE [dbo].[tbl_detallepedido] ADD  DEFAULT (NULL) FOR [NombreRestautante]
GO
ALTER TABLE [dbo].[tbl_detallepedido] ADD  DEFAULT (NULL) FOR [NombreEmpleado]
GO
ALTER TABLE [dbo].[tbl_detallepedido] ADD  DEFAULT (NULL) FOR [PrecioUnidad]
GO
ALTER TABLE [dbo].[tbl_detallepedido] ADD  DEFAULT (NULL) FOR [cantidad]
GO
ALTER TABLE [dbo].[tbl_empleado] ADD  DEFAULT (NULL) FOR [NombreEmpleado]
GO
ALTER TABLE [dbo].[tbl_empleado] ADD  DEFAULT (NULL) FOR [FechaNcimiento]
GO
ALTER TABLE [dbo].[tbl_empleado] ADD  DEFAULT (NULL) FOR [FechaIngreso]
GO
ALTER TABLE [dbo].[tbl_pedidos] ADD  DEFAULT (NULL) FOR [IdCliente]
GO
ALTER TABLE [dbo].[tbl_pedidos] ADD  DEFAULT (NULL) FOR [IdProducto]
GO
ALTER TABLE [dbo].[tbl_pedidos] ADD  DEFAULT (NULL) FOR [Fecha]
GO
ALTER TABLE [dbo].[tbl_pedidos] ADD  DEFAULT (NULL) FOR [DireccionEntrega]
GO
ALTER TABLE [dbo].[tbl_pedidos] ADD  DEFAULT (NULL) FOR [IdEmpleado]
GO
ALTER TABLE [dbo].[tbl_pedidos] ADD  DEFAULT (NULL) FOR [Precio]
GO
ALTER TABLE [dbo].[tbl_pedidos] ADD  DEFAULT (NULL) FOR [Total]
GO
ALTER TABLE [dbo].[tbl_producto] ADD  DEFAULT (NULL) FOR [NombreProducto]
GO
ALTER TABLE [dbo].[tbl_producto] ADD  DEFAULT (NULL) FOR [IdRestaurante]
GO
ALTER TABLE [dbo].[tbl_producto] ADD  DEFAULT (NULL) FOR [Precio]
GO
ALTER TABLE [dbo].[tbl_restaurante] ADD  DEFAULT (NULL) FOR [NombreRestautante]
GO
ALTER TABLE [dbo].[tbl_restaurante] ADD  DEFAULT (NULL) FOR [DireccionRestaurante]
GO
ALTER TABLE [dbo].[tbl_restaurante] ADD  DEFAULT (NULL) FOR [EmailRestaurante]
GO
ALTER TABLE [dbo].[tbl_detallepedido]  WITH CHECK ADD FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[tbl_empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[tbl_detallepedido]  WITH CHECK ADD FOREIGN KEY([IdPedido])
REFERENCES [dbo].[tbl_pedidos] ([IdPedido])
GO
ALTER TABLE [dbo].[tbl_detallepedido]  WITH CHECK ADD FOREIGN KEY([IdRestaurante])
REFERENCES [dbo].[tbl_restaurante] ([IdRestaurante])
GO
ALTER TABLE [dbo].[tbl_pedidos]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[tbl_cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[tbl_pedidos]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[tbl_producto] ([IdProducto])
GO
