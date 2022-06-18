USE [DB_MafiaTech]
GO
/****** Object:  Table [dbo].[tbl_cliente]    Script Date: 17/06/2022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cliente](
	[IdCliente] [decimal](18, 0) NOT NULL,
	[Nombre] [decimal](18, 0) NULL,
	[Email] [varchar](20) NULL,
	[FechaIngreso] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_detallepedido]    Script Date: 17/06/2022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_detallepedido](
	[idDetallePedido] [decimal](38, 0) NOT NULL,
	[IdPedido] [decimal](18, 0) NULL,
	[IdProducto] [decimal](18, 0) NULL,
	[IdEmpleado] [decimal](18, 0) NULL,
	[IdRestaurante] [decimal](18, 0) NULL,
	[NombreRestautante] [varchar](20) NULL,
	[NombreEmpleado] [varchar](20) NULL,
	[PrecioUnidad] [decimal](20, 0) NULL,
	[cantidad] [decimal](20, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetallePedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_empleado]    Script Date: 17/06/2022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_empleado](
	[IdEmpleado] [decimal](18, 0) NOT NULL,
	[NombreEmpleado] [varchar](18) NULL,
	[FechaNcimiento] [decimal](18, 0) NULL,
	[FechaIngreso] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_pedidos]    Script Date: 17/06/2022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pedidos](
	[IdPedido] [decimal](18, 0) NOT NULL,
	[IdCliente] [decimal](18, 0) NULL,
	[IdProducto] [decimal](18, 0) NULL,
	[Fecha] [varchar](18) NULL,
	[DireccionEntrega] [varchar](18) NULL,
	[IdEmpleado] [decimal](18, 0) NULL,
	[Precio] [decimal](18, 0) NULL,
	[iva] [decimal](18, 0) NOT NULL,
	[Total] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_producto]    Script Date: 17/06/2022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_producto](
	[IdProducto] [decimal](18, 0) NOT NULL,
	[NombreProducto] [varchar](18) NULL,
	[IdRestaurante] [decimal](18, 0) NULL,
	[Precio] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_restaurante]    Script Date: 17/06/2022 8:40:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_restaurante](
	[IdRestaurante] [decimal](18, 0) NOT NULL,
	[NombreRestautante] [varchar](18) NULL,
	[DireccionRestaurante] [varchar](18) NULL,
	[EmailRestaurante] [varchar](18) NULL,
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
