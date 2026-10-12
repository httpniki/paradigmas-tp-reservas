USE [TPReservasSalon]
GO
/****** Object:  Table [dbo].[ReservasSalon]    Script Date: 25/09/2026 15:38:38 ******/
SET ANSI_NULLS ON
SET DATEFORMAT ymd
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservasSalon](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[Salon] [nvarchar](50) NOT NULL,
	[NombreEvento] [nvarchar](100) NOT NULL,
	[FechaEvento] [date] NOT NULL,
	[HoraInicio] [time](0) NOT NULL,
	[HoraFin] [time](0) NOT NULL,
	[Importe] [decimal](10, 2) NOT NULL,
	[CantidadInvitados] [int] NOT NULL,
	[Confirmada] [bit] NOT NULL,
 CONSTRAINT [PK_ReservasSalon] PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ReservasSalon] ON 
GO
INSERT [dbo].[ReservasSalon] ([IdReserva], [Salon], [NombreEvento], [FechaEvento], [HoraInicio], [HoraFin], [Importe], [CantidadInvitados], [Confirmada]) VALUES (1, N'Salón Principal', N'Cumpleaños 50 años', CAST(N'2026-10-10' AS Date), CAST(N'20:00:00' AS Time), CAST(N'23:30:00' AS Time), CAST(185000.00 AS Decimal(10, 2)), 80, 1)
GO
INSERT [dbo].[ReservasSalon] ([IdReserva], [Salon], [NombreEvento], [FechaEvento], [HoraInicio], [HoraFin], [Importe], [CantidadInvitados], [Confirmada]) VALUES (2, N'Salón Norte', N'Reunión Empresarial', CAST(N'2026-10-15' AS Date), CAST(N'18:00:00' AS Time), CAST(N'22:00:00' AS Time), CAST(120000.00 AS Decimal(10, 2)), 45, 1)
GO
INSERT [dbo].[ReservasSalon] ([IdReserva], [Salon], [NombreEvento], [FechaEvento], [HoraInicio], [HoraFin], [Importe], [CantidadInvitados], [Confirmada]) VALUES (3, N'Salón Principal', N'Fiesta de Fin de Año', CAST(N'2026-12-18' AS Date), CAST(N'19:00:00' AS Time), CAST(N'23:30:00' AS Time), CAST(350000.00 AS Decimal(10, 2)), 150, 1)
GO
INSERT [dbo].[ReservasSalon] ([IdReserva], [Salon], [NombreEvento], [FechaEvento], [HoraInicio], [HoraFin], [Importe], [CantidadInvitados], [Confirmada]) VALUES (4, N'Salón Jardín', N'Bautismo Familiar', CAST(N'2026-11-08' AS Date), CAST(N'12:00:00' AS Time), CAST(N'17:00:00' AS Time), CAST(145000.00 AS Decimal(10, 2)), 60, 0)
GO
INSERT [dbo].[ReservasSalon] ([IdReserva], [Salon], [NombreEvento], [FechaEvento], [HoraInicio], [HoraFin], [Importe], [CantidadInvitados], [Confirmada]) VALUES (5, N'Salón Norte', N'Cena de Aniversario', CAST(N'2026-11-21' AS Date), CAST(N'19:30:00' AS Time), CAST(N'22:00:00' AS Time), CAST(210000.00 AS Decimal(10, 2)), 70, 1)
GO
SET IDENTITY_INSERT [dbo].[ReservasSalon] OFF
GO
