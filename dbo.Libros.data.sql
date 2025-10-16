SET IDENTITY_INSERT [dbo].[Libros] ON
INSERT INTO [dbo].[Libros] ([LibroId], [Titulo], [Autor], [Ubicacion], [Estado]) VALUES (1, N'Cien años de soledad', N'Gabriel García Márquez', N'M1', N'Disponible')
INSERT INTO [dbo].[Libros] ([LibroId], [Titulo], [Autor], [Ubicacion], [Estado]) VALUES (2, N'Don Quijote de la Mancha', N'Miguel de Cervantes', N'C1', N'Disponible')
INSERT INTO [dbo].[Libros] ([LibroId], [Titulo], [Autor], [Ubicacion], [Estado]) VALUES (3, N'El principito', N'Antoine de Saint-Exupéry', N'S1', N'Disponible')
SET IDENTITY_INSERT [dbo].[Libros] OFF
