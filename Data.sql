INSERT INTO Nutrientes (nombre, descripcion)
VALUES
('Proteína', 'Las proteínas son macronutrientes esenciales para el crecimiento, la reparación y el mantenimiento de los tejidos en el cuerpo.'),
('Carbohidratos', 'Los carbohidratos son la principal fuente de energía del cuerpo, incluyendo azúcares, almidones y fibras.'),
('Fibra', 'La fibra dietética ayuda a regular la digestión y apoya la salud del corazón.'),
('Vitamina C', 'La vitamina C es un antioxidante que respalda el sistema inmunológico y la salud de la piel.'),
('Vitamina D', 'La vitamina D es crucial para la salud de los huesos y ayuda al cuerpo a absorber el calcio.'),
('Hierro', 'El hierro es importante para la producción de glóbulos rojos y el transporte de oxígeno.'),
('Calcio', 'El calcio es esencial para huesos y dientes fuertes.'),
('Ácido Fólico', 'El ácido fólico, o vitamina B9, es importante para la división celular y la síntesis de ADN.'),
('Magnesio', 'El magnesio participa en varios procesos corporales, incluyendo la función muscular y nerviosa.'),
('Zinc', 'El zinc respalda el sistema inmunológico y la cicatrización de heridas.'),
('Potasio', 'El potasio ayuda a regular la presión sanguínea y las contracciones musculares.'),
('Vitamina A', 'La vitamina A es importante para la visión, la salud de la piel y la función inmunológica.'),
('Vitamina B12', 'La vitamina B12 es vital para la función nerviosa y la producción de ADN.'),
('Vitamina E', 'La vitamina E es un antioxidante que protege las células del daño.'),
('Ácidos Grasos Omega-3', 'Los omega-3 son beneficiosos para la salud del corazón y para reducir la inflamación.');

INSERT INTO Alimentos (Nombre, Carbohidratos, Vegetales, Frutas, Lacteos, Proteinas, Grasas, AlimentosLibres, Agua, AltoFibra, AltoAzucar, AltoGrasa, AltoSodio, LibreGluten, idNutriente)
VALUES
('Manzana', 25, 0, 100, 0, 1, 0, 0, 80, 1, 0, 0, 0, 1, 4),
('Arroz Integral', 45, 0, 0, 0, 5, 2, 0, 10, 1, 0, 0, 0, 1, 1),
('Pollo a la Parrilla', 0, 0, 0, 0, 30, 10, 0, 60, 0, 0, 1, 0, 1, 1),
('Brócoli', 6, 90, 0, 0, 2, 0, 0, 92, 1, 0, 0, 0, 1, 1),
('Leche', 12, 0, 0, 80, 8, 0, 0, 90, 0, 0, 0, 0, 1, 1),
('Salmón', 0, 0, 0, 0, 25, 12, 0, 60, 0, 0, 1, 0, 1, 7),
('Pan Integral', 30, 0, 0, 0, 5, 2, 0, 15, 1, 0, 0, 0, 1, 1),
('Huevos', 1, 0, 0, 0, 6, 5, 0, 75, 0, 0, 1, 0, 1, 12),
('Zanahorias', 9, 95, 0, 0, 1, 0, 0, 88, 1, 0, 0, 0, 1, 1),
('Queso Cheddar', 1, 0, 0, 80, 25, 33, 0, 39, 0, 0, 1, 0, 1, 3),
('Aguacate', 9, 0, 0, 0, 2, 14, 0, 75, 3, 0, 1, 0, 1, 14),
('Espárragos', 3, 90, 0, 0, 2, 1, 0, 94, 2, 0, 0, 0, 1, 1),
('Fresas', 7, 5, 95, 0, 1, 0, 0, 91, 3, 0, 0, 0, 1, 4),
('Tofu', 1, 0, 0, 0, 8, 5, 0, 60, 3, 0, 1, 0, 1, 1),
('Pan de Avena', 25, 0, 0, 0, 5, 3, 0, 12, 2, 0, 0, 0, 1, 1);

INSERT INTO Alimentos (Nombre, Carbohidratos, Vegetales, Frutas, Lacteos, Proteinas, Grasas, AlimentosLibres, Agua, AltoFibra, AltoAzucar, AltoGrasa, AltoSodio, LibreGluten, idNutriente)
VALUES
('Pasta Integral', 40, 0, 0, 0, 8, 2, 0, 10, 2, 0, 0, 0, 1, 1),
('Cebolla', 9, 90, 0, 0, 1, 0, 0, 88, 1, 0, 0, 0, 1, 1),
('Yogur Natural', 10, 0, 0, 75, 5, 3, 0, 85, 1, 0, 0, 0, 1, 1),
('Atún en Lata', 0, 0, 0, 0, 30, 1, 0, 70, 0, 0, 0, 0, 1, 7),
('Naranja', 20, 0, 100, 0, 1, 0, 0, 88, 1, 0, 0, 0, 1, 4),
('Carne Molida', 0, 0, 0, 0, 25, 10, 0, 60, 0, 0, 1, 0, 1, 6),
('Kiwi', 16, 0, 95, 0, 1, 0, 0, 80, 2, 0, 0, 0, 1, 4),
('Garbanzos', 61, 5, 0, 0, 19, 6, 0, 75, 5, 0, 0, 0, 1, 1);

INSERT INTO TipoRutinas (TipoRutina, Active)
VALUES
    ('Cardiovascular', 1),
    ('Entrenamiento de Fuerza', 1),
    ('Entrenamiento en Intervalos de Alta Intensidad (HIIT)', 1),
    ('Yoga', 1),
    ('Pilates', 1),
    ('CrossFit', 1),
    ('Entrenamiento Funcional', 1),
    ('Entrenamiento con Peso Corporal', 1),
    ('Entrenamiento en Circuito', 1),
    ('Tai Chi', 1);


INSERT INTO rutina (Descripcion, Activo, FechaCreacion, IdTipoRutina)
VALUES
    ('Rutina de Cardio', 1, GETDATE(), 1),
    ('Rutina de Entrenamiento de Fuerza', 1, GETDATE(), 2),
    ('Rutina de Yoga', 1, GETDATE(), 4),
    ('Rutina de Pilates', 1, GETDATE(), 5),
    ('Rutina de CrossFit', 1, GETDATE(), 6),
    ('Rutina de Entrenamiento Funcional', 1, GETDATE(), 7),
    ('Rutina de Peso Corporal', 1, GETDATE(), 8),
    ('Rutina de Entrenamiento en Circuito', 1, GETDATE(), 9),
    ('Rutina de Tai Chi', 1, GETDATE(), 10),
    ('Rutina de HIIT', 1, GETDATE(), 3),
    ('Rutina de Estiramiento', 1, GETDATE(), 4),
    ('Rutina de Spinning', 1, GETDATE(), 1),
    ('Rutina de Natación', 1, GETDATE(), 3),
    ('Rutina de Entrenamiento en Casa', 1, GETDATE(), 8),
    ('Rutina de Baile', 1, GETDATE(), 7),
    ('Rutina de Senderismo', 1, GETDATE(), 9),
    ('Rutina de Escalada', 1, GETDATE(), 10),
    ('Rutina de Kickboxing', 1, GETDATE(), 6),
    ('Rutina de Calistenia', 1, GETDATE(), 8),
    ('Rutina de Artes Marciales', 1, GETDATE(), 5);

INSERT INTO Usuarios (nombreUsuario, contraseña, nombre, apellido, correo)
VALUES
    ('AnaPerez', 'clave123', 'Ana', 'Pérez', 'ana.perez@email.com'),
    ('LuisGonzalez', 'contraseña321', 'Luis', 'González', 'luis.gonzalez@email.com'),
    ('SofiaMartinez', 'segura123', 'Sofía', 'Martínez', 'sofia.martinez@email.com'),
    ('JavierLopez', 'p4ssw0rd', 'Javier', 'López', 'javier.lopez@email.com'),
    ('MariaSanchez', 'c0ntr4señ4', 'María', 'Sánchez', 'maria.sanchez@email.com'),
    ('CarlosRodriguez', 'cclave321', 'Carlos', 'Rodríguez', 'carlos.rodriguez@email.com'),
    ('ElenaFernandez', 'r3alpass', 'Elena', 'Fernández', 'elena.fernandez@email.com'),
    ('DiegoTorres', 'd1egopass', 'Diego', 'Torres', 'diego.torres@email.com'),
    ('LauraDiaz', 'laur4clave', 'Laura', 'Díaz', 'laura.diaz@email.com'),
    ('MiguelRamirez', 'm1guel123', 'Miguel', 'Ramírez', 'miguel.ramirez@email.com');

INSERT INTO TipoMembresias (Nombre, Descripcion)
VALUES
    ('Membresía Básica', 'Acceso básico a nuestros servicios'),
    ('Membresía Premium', 'Acceso premium a nuestros servicios'),
    ('Membresía Familiar', 'Acceso para toda la familia'),
    ('Membresía VIP', 'Membresía exclusiva con beneficios VIP');

INSERT INTO ejercicios (nombre, EjSet, Repeticiones, idRutina)
VALUES
    ('Levantamiento de pesas', 4, 12, 1),
    ('Correr en la cinta', 3, 30, 2),
    ('Yoga matutino', 1, 60, 3),
    ('Ciclismo en montaña', 2, 45, 4),
    ('Natación en piscina', 3, 20, 1),
    ('Entrenamiento de intervalos', 5, 10, 2),
    ('Ejercicios de resistencia', 4, 15, 3),
    ('Pilates de cuerpo entero', 2, 45, 4),
    ('Caminata relajante', 1, 60, 1),
    ('Clases de baile latino', 3, 30, 2);


INSERT INTO EjerciciosXUsuario (idUsuario, idEjercicio, Cantidad)
VALUES
    (1, 1, 3),
    (2, 2, 5),
    (3, 3, 2),
    (4, 4, 4),
    (5, 5, 6),
    (6, 6, 3),
    (7, 7, 4),
    (8, 8, 5);

INSERT INTO eventos (idUsuario, Evento, fechaEvento, horaEvento)
VALUES
    (1, 'Sesión de yoga', '2023-11-01', '08:00:00'),
    (2, 'Entrenamiento de fuerza', '2023-11-02', '17:30:00'),
    (3, 'Caminata en el parque', '2023-11-03', '10:00:00'),
    (4, 'Clase de natación', '2023-11-04', '19:00:00'),
    (5, 'Carrera de 5 km', '2023-11-05', '07:00:00'),
    (6, 'Rutina de ejercicios HIIT', '2023-11-06', '16:00:00'),
    (7, 'Sesión de meditación', '2023-11-07', '09:30:00'),
    (8, 'Yoga al atardecer', '2023-11-08', '18:00:00'),
    (9, 'Paseo en bicicleta', '2023-11-09', '14:00:00'),
    (1, 'Clase de zumba', '2023-11-10', '17:00:00'),
    (2, 'Entrenamiento en el gimnasio', '2023-11-11', '12:30:00'),
    (5, 'Ejercicios de estiramiento', '2023-11-12', '07:30:00'),
    (6, 'Yoga al amanecer', '2023-11-13', '06:00:00'),
    (7, 'Caminata relajante', '2023-11-14', '15:30:00'),
    (8, 'Natación en el mar', '2023-11-15', '11:00:00');


INSERT INTO Inbody (idUsuario, fechaCarga, ComentariosProfesional, DocumentoInbody)
VALUES
    (1, '2023-11-01', 'Evaluación de composición corporal completa', 'Informe_Inbody_1.pdf'),
    (2, '2023-11-02', 'Seguimiento mensual de medidas corporales', 'Informe_Inbody_2.pdf'),
    (3, '2023-11-03', 'Análisis de masa muscular y grasa corporal', 'Informe_Inbody_3.pdf'),
    (4, '2023-11-04', 'Informe de progreso físico', 'Informe_Inbody_4.pdf'),
    (5, '2023-11-05', 'Resultados de la evaluación de salud', 'Informe_Inbody_5.pdf'),
    (6, '2023-11-06', 'Evaluación de composición corporal avanzada', 'Informe_Inbody_6.pdf'),
    (7, '2023-11-07', 'Seguimiento de la pérdida de peso', 'Informe_Inbody_7.pdf'),
    (8, '2023-11-08', 'Informe de análisis corporal completo', 'Informe_Inbody_8.pdf'),
    (9, '2023-11-09', 'Evaluación de salud y estado físico', 'Informe_Inbody_9.pdf'),
    (10, '2023-11-10', 'Informe de progreso físico y objetivos', 'Informe_Inbody_10.pdf');

INSERT INTO inbox (idUsuario, Mensaje, fechaEnvio, horaEnvio)
VALUES
    (1, 'Hola, ¿cómo te sientes hoy?', '2023-11-15', '09:30:00'),
    (1, 'Recordatorio: Tienes una cita mañana.', '2023-11-17', '15:45:00'),
    (1, '¡Nuevo plan de entrenamiento disponible!', '2023-11-20', '08:20:00'),
    (1, 'Mensaje de motivación: ¡Sigue adelante!', '2023-11-25', '17:15:00'),
    (2, 'Resumen de tu progreso esta semana.', '2023-11-15', '10:10:00'),
    (2, 'Preguntas sobre tu plan nutricional.', '2023-11-18', '13:55:00'),
    (2, 'Recordatorio: Clase de yoga mañana.', '2023-11-21', '16:30:00'),
    (2, 'Actualización de tu membresía', '2023-11-26', '11:40:00'),
    (3, 'Mensaje de bienvenida al programa', '2023-11-16', '09:00:00'),
    (3, 'Recetas saludables para tu dieta', '2023-11-19', '14:20:00'),
    (3, 'Rutina de ejercicios personalizada', '2023-11-22', '17:05:00'),
    (3, 'Mensaje de apoyo de tu entrenador', '2023-11-27', '15:30:00'),
    (4, 'Actualización sobre tu membresía', '2023-11-16', '10:05:00'),
    (4, 'Pautas para el control de peso', '2023-11-19', '12:40:00'),
    (4, '¡Nuevos ejercicios para ti!', '2023-11-23', '16:15:00'),
    (4, 'Recordatorio: Reunión de seguimiento', '2023-11-28', '11:20:00'),
    (5, 'Resumen de tus resultados de Inbody', '2023-11-17', '08:45:00'),
    (5, 'Consejos para mejorar tu salud', '2023-11-20', '12:30:00'),
    (5, 'Horarios de las clases de fitness', '2023-11-24', '14:55:00'),
    (5, 'Mensaje de motivación: ¡Tú puedes!', '2023-11-29', '10:10:00');

INSERT INTO Membresias (fechaInicio, fechaExpiracion, fechaRenovacion, fechaFinal, fechaPago, idTipoMembresia, idUsuario)
VALUES
    ('2023-11-01', '2023-11-30', '2023-11-30', '2023-11-30', '2023-11-01', 1, 1),
    ('2023-11-02', '2023-12-02', '2023-12-02', '2023-12-02', '2023-11-02', 2, 2),
    ('2023-11-03', '2023-12-03', '2023-12-03', '2023-12-03', '2023-11-03', 3, 3),
    ('2023-11-04', '2023-12-04', '2023-12-04', '2023-12-04', '2023-11-04', 4, 4),
    ('2023-11-05', '2023-11-30', '2023-11-30', '2023-11-30', '2023-11-05', 1, 5),
    ('2023-11-06', '2023-12-06', '2023-12-06', '2023-12-06', '2023-11-06', 2, 6),
    ('2023-11-07', '2023-12-07', '2023-12-07', '2023-12-07', '2023-11-07', 3, 7),
    ('2023-11-08', '2023-12-08', '2023-12-08', '2023-12-08', '2023-11-08', 4, 8),
    ('2023-11-09', '2023-11-30', '2023-11-30', '2023-11-30', '2023-11-09', 1, 9),
    ('2023-11-10', '2023-12-10', '2023-12-10', '2023-12-10', '2023-11-10', 2, 10);

INSERT INTO PlanNutricion (
    fechaCreacion, fechaActual, PNcarbohidratos, PNvegetales, PNfrutas,
    PNlacteos, PNproteinas, PNgrasas, PNalimentosLibres, PNAgua, PNaltoFibra,
    PNaltoAzucar, PNaltoGrasa, PNaltoSodio, PNlibreGluten, carbohidratos,
    vegetales, frutas, lacteos, proteinas, grasas, alimentosLibres, agua, idUsuario
) VALUES
    ('2023-11-01', '2023-11-01', 50, 20, 30, 20, 20, 10, 5, 8, 1, 0, 0, 0, 0, 200, 100, 200, 200, 50, 40, 10, 200, 1),
    ('2023-11-02', '2023-11-02', 60, 25, 35, 30, 25, 15, 6, 10, 1, 0, 0, 0, 0, 250, 150, 250, 250, 60, 50, 15, 250, 2),
    ('2023-11-03', '2023-11-03', 70, 30, 40, 40, 30, 20, 8, 12, 1, 0, 0, 0, 0, 300, 200, 300, 300, 70, 60, 20, 300, 3),
    ('2023-11-04', '2023-11-04', 80, 35, 45, 50, 35, 25, 10, 14, 1, 0, 0, 0, 0, 350, 250, 350, 350, 80, 70, 25, 350, 4),
    ('2023-11-05', '2023-11-05', 90, 40, 50, 60, 40, 30, 12, 16, 1, 0, 0, 0, 0, 400, 300, 400, 400, 90, 80, 30, 400, 5),
    ('2023-11-06', '2023-11-06', 70, 35, 60, 50, 45, 35, 15, 18, 1, 0, 0, 0, 0, 450, 350, 450, 450, 70, 90, 35, 450, 6),
    ('2023-11-07', '2023-11-07', 75, 40, 65, 70, 50, 40, 16, 20, 1, 0, 0, 0, 0, 500, 400, 500, 500, 75, 100, 40, 500, 7),
    ('2023-11-08', '2023-11-08', 80, 45, 70, 80, 55, 45, 18, 22, 1, 0, 0, 0, 0, 550, 450, 550, 550, 80, 110, 45, 550, 8),
    ('2023-11-09', '2023-11-09', 85, 50, 75, 90, 60, 50, 20, 24, 1, 0, 0, 0, 0, 600, 500, 600, 600, 85, 120, 50, 600, 9),
    ('2023-11-10', '2023-11-10', 90, 55, 80, 100, 65, 55, 22, 26, 1, 0, 0, 0, 0, 650, 550, 650, 650, 90, 130, 55, 650, 10);
