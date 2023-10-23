
USE MASTER;
DROP DATABASE IF EXISTS MenteCuerpo;

CREATE DATABASE MenteCuerpo;

USE MenteCuerpo;
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alimentos](
	[idAlimento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Carbohidratos] [int] NOT NULL,
	[Vegetales] [int] NOT NULL,
	[Frutas] [int] NOT NULL,
	[Lacteos] [int] NOT NULL,
	[Proteinas] [int] NOT NULL,
	[Grasas] [int] NOT NULL,
	[AlimentosLibres] [int] NOT NULL,
	[Agua] [int] NOT NULL,
	[AltoFibra] [bit] NOT NULL,
	[AltoAzucar] [bit] NOT NULL,
	[AltoGrasa] [bit] NOT NULL,
	[AltoSodio] [bit] NOT NULL,
	[LibreGluten] [bit] NOT NULL,
	[idNutriente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idAlimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ejercicios]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ejercicios](
	[idEjercicio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[EjSet] [int] NOT NULL,
	[Repeticiones] [int] NOT NULL,
	[idRutina] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEjercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EjerciciosXUsuario]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EjerciciosXUsuario](
	[idEjericioU] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[idEjercicio] [int] NOT NULL,
	[idRutina] [int] NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK__Ejercici__67CBBFD9AFF9F44C] PRIMARY KEY CLUSTERED 
(
	[idEjericioU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[errores]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[errores](
	[idError] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[mensajeError] [varchar](255) NOT NULL,
	[fechaError] [date] NOT NULL,
	[horaError] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idError] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eventos]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eventos](
	[idEvento] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[Evento] [varchar](255) NOT NULL,
	[fechaEvento] [date] NOT NULL,
	[horaEvento] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inbody]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inbody](
	[idInbody] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[fechaCarga] [date] NOT NULL,
	[ComentariosProfesional] [varchar](500) NOT NULL,
	[DocumentoInbody] [varchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idInbody] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inbox]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inbox](
	[idInbox] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[Mensaje] [varchar](500) NOT NULL,
	[fechaEnvio] [date] NOT NULL,
	[horaEnvio] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idInbox] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Membresias]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Membresias](
	[idMembresia] [int] IDENTITY(1,1) NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaExpiracion] [date] NOT NULL,
	[fechaRenovacion] [date] NOT NULL,
	[fechaFinal] [date] NOT NULL,
	[fechaPago] [date] NOT NULL,
	[idTipoMembresia] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMembresia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nutrientes]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nutrientes](
	[idNutriente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNutriente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanNutricion]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanNutricion](
	[idPlanNutricion] [int] IDENTITY(1,1) NOT NULL,
	[fechaCreacion] [date] NOT NULL,
	[fechaActual] [date] NOT NULL,
	[PNcarbohidratos] [int] NOT NULL,
	[PNvegetales] [int] NOT NULL,
	[PNfrutas] [int] NOT NULL,
	[PNlacteos] [int] NOT NULL,
	[PNproteinas] [int] NOT NULL,
	[PNgrasas] [int] NOT NULL,
	[PNalimentosLibres] [int] NOT NULL,
	[PNAgua] [int] NOT NULL,
	[PNaltoFibra] [bit] NOT NULL,
	[PNaltoAzucar] [bit] NOT NULL,
	[PNaltoGrasa] [bit] NOT NULL,
	[PNaltoSodio] [bit] NOT NULL,
	[PNlibreGluten] [bit] NOT NULL,
	[carbohidratos] [int] NOT NULL,
	[vegetales] [int] NOT NULL,
	[frutas] [int] NOT NULL,
	[lacteos] [int] NOT NULL,
	[proteinas] [int] NOT NULL,
	[grasas] [int] NOT NULL,
	[alimentosLibres] [int] NOT NULL,
	[agua] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPlanNutricion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rutina]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rutina](
	[idRutina] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NULL,
	[IdTipoRutina] [int] NOT NULL,
 CONSTRAINT [PK__rutina__9E71C71C623BDB9C] PRIMARY KEY CLUSTERED 
(
	[idRutina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoMembresias]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMembresias](
	[idTipoMembresia] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoMembresia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoRutinas]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoRutinas](
	[IdTipoRutina] [int] IDENTITY(1,1) NOT NULL,
	[TipoRutina] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoRutina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/10/2023 22:25:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [varchar](255) NOT NULL,
	[contraseña] [varchar](255) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[apellido] [varchar](255) NOT NULL,
	[correo] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alimentos]  WITH CHECK ADD FOREIGN KEY([idNutriente])
REFERENCES [dbo].[Nutrientes] ([idNutriente])
GO
ALTER TABLE [dbo].[ejercicios]  WITH CHECK ADD  CONSTRAINT [FK_ejercicios_rutina] FOREIGN KEY([idRutina])
REFERENCES [dbo].[rutina] ([idRutina])
GO
ALTER TABLE [dbo].[ejercicios] CHECK CONSTRAINT [FK_ejercicios_rutina]
GO
ALTER TABLE [dbo].[EjerciciosXUsuario]  WITH CHECK ADD  CONSTRAINT [FK_EjerciciosXUsuario_ejercicios] FOREIGN KEY([idEjercicio])
REFERENCES [dbo].[ejercicios] ([idEjercicio])
GO
ALTER TABLE [dbo].[EjerciciosXUsuario] CHECK CONSTRAINT [FK_EjerciciosXUsuario_ejercicios]
GO
ALTER TABLE [dbo].[EjerciciosXUsuario]  WITH CHECK ADD  CONSTRAINT [FK_EjerciciosXUsuario_rutina] FOREIGN KEY([idRutina])
REFERENCES [dbo].[rutina] ([idRutina])
GO
ALTER TABLE [dbo].[EjerciciosXUsuario] CHECK CONSTRAINT [FK_EjerciciosXUsuario_rutina]
GO
ALTER TABLE [dbo].[errores]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[eventos]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Inbody]  WITH CHECK ADD  CONSTRAINT [FK_Inbody_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Inbody] CHECK CONSTRAINT [FK_Inbody_Usuarios]
GO
ALTER TABLE [dbo].[inbox]  WITH CHECK ADD  CONSTRAINT [FK_Inbox_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[inbox] CHECK CONSTRAINT [FK_Inbox_Usuarios]
GO
ALTER TABLE [dbo].[Membresias]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[Membresias]  WITH CHECK ADD  CONSTRAINT [FK_Membresias_TipoMembresias] FOREIGN KEY([idTipoMembresia])
REFERENCES [dbo].[TipoMembresias] ([idTipoMembresia])
GO
ALTER TABLE [dbo].[Membresias] CHECK CONSTRAINT [FK_Membresias_TipoMembresias]
GO
ALTER TABLE [dbo].[PlanNutricion]  WITH CHECK ADD  CONSTRAINT [FK_PlanNutricion_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([idUsuario])
GO
ALTER TABLE [dbo].[PlanNutricion] CHECK CONSTRAINT [FK_PlanNutricion_Usuarios]
GO
ALTER TABLE [dbo].[rutina]  WITH CHECK ADD  CONSTRAINT [FK_rutina_TipoRutinas] FOREIGN KEY([IdTipoRutina])
REFERENCES [dbo].[TipoRutinas] ([IdTipoRutina])
GO
ALTER TABLE [dbo].[rutina] CHECK CONSTRAINT [FK_rutina_TipoRutinas]
GO
