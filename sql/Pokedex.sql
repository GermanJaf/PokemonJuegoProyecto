DROP TABLE IF EXISTS [PokemonUsuario];
DROP TABLE IF EXISTS [HistorialTorneos];
DROP TABLE IF EXISTS [Pokemones];
DROP TABLE IF EXISTS [Ataques];
DROP TABLE IF EXISTS [Usuarios];

CREATE TABLE Usuarios(
       [Id] INTEGER PRIMARY KEY AUTOINCREMENT,
       [NombreUsuario] TEXT NOT NULL,
       [Contraseña] TEXT NOT NULL,
       [BatallasGanadas] INTEGER DEFAULT 0,
       [PuntosMejora] INTEGER DEFAULT 0
);

CREATE TABLE Ataques(
       [Id] INTEGER PRIMARY KEY AUTOINCREMENT,
       [Nombre] TEXT NOT NULL,
       [Tipo] TEXT NOT NULL,
       [Poder] INTEGER NOT NULL,
       [Presicion] INTEGER NOT NULL
);
  
CREATE TABLE Pokemones(
       [Id] INTEGER PRIMARY KEY AUTOINCREMENT,
       [Nombre] TEXT NOT NULL,
       [Tipo] TEXT NOT NULL,
       [HPBase] INTEGER NOT NULL,
       [AtaqueBase] INTEGER NOT NULL,
       [DefensaBase] INTEGER NOT NULL,
       [Ataque1Id] INTEGER,
       [Ataque2Id] INTEGER,
       [Ataque3Id] INTEGER,
       [Ataque4Id] INTEGER,
       FOREIGN KEY ([Ataque1Id]) REFERENCES Ataques([Id]),
       FOREIGN KEY ([Ataque2Id]) REFERENCES Ataques([Id]),
       FOREIGN KEY ([Ataque3Id]) REFERENCES Ataques([Id]),
       FOREIGN KEY ([Ataque4Id]) REFERENCES Ataques([Id])
);

CREATE TABLE PokemonUsuario(
       [Id] INTEGER PRIMARY KEY AUTOINCREMENT,
       [UsuarioId] INTEGER,
       [PokemonID] INTEGER,
       [Nivel] INTEGER DEFAULT 1,
       [HP] INTEGER,
       [Ataque] INTEGER,
       [Defensa] INTEGER,
       [BatallasGanadasPK] INTEGER DEFAULT 0,
       FOREIGN KEY ([UsuarioId]) REFERENCES Usuarios([Id]),
       FOREIGN KEY ([PokemonID]) REFERENCES Pokemones([Id])
);

CREATE TABLE HistorialTorneos(
       [Id] INTEGER PRIMARY KEY AUTOINCREMENT,
       [UsuarioId] INTEGER,
       [PokemonID] INTEGER,
       [FaseLograda] TEXT NOT NULL,
       FOREIGN KEY ([UsuarioId]) REFERENCES Usuarios([Id]),
       FOREIGN KEY ([PokemonID]) REFERENCES Pokemones([Id])
);

INSERT INTO Usuarios (NombreUsuario, Contraseña, BatallasGanadas) VALUES
('RodrigoFlores', '123456', 2),
('PabloRuz', 'digital67', 9),
('DiegoInurreta', 'contraseña', 1);

INSERT INTO Ataques (Nombre, Tipo, Poder, Presicion) VALUES
('Placaje', 'Normal', 40, 100),
('Arañazo', 'Normal', 40, 100),
('Ataque Rapido', 'Normal', 40, 100),
('Impactrueno', 'Electrico', 40, 100),
('Rayo', 'Electrico', 90, 100),
('Ascuas', 'Fuego', 40, 100),
('Lanzallamas', 'Fuego', 90, 100),
('Pistola Agua', 'Agua', 40, 100),
('Surf', 'Agua', 90, 100),
('Latigo Cepa', 'Planta', 45, 100),
('Hoja Afilada', 'Planta', 55, 95),
('Gruñido', 'Normal', 0, 100),
('Golpe Cabeza', 'Normal', 70, 100),
('Rapidez', 'Normal', 60, 100),
('Colmillo Ígneo', 'Fuego', 65, 95),
('Pirotecnia', 'Fuego', 70, 100),
('Hidropulso', 'Agua', 60, 100),
('Rayo Burbuja', 'Agua', 65, 100),
('Hoja Mágica', 'Planta', 60, 100),
('Megaagotar', 'Planta', 40, 100),
('Onda Choque', 'Eléctrico', 60, 100),
('Colmillo Rayo', 'Eléctrico', 65, 95),
('Rayo Aurora', 'Hielo', 65, 100),
('Colmillo Hielo', 'Hielo', 65, 95),
('Tiro Vital', 'Lucha', 70, 100),
('Golpe Roca', 'Lucha', 40, 100),
('Cola Veneno', 'Veneno', 50, 100),
('Colmillo Veneno', 'Veneno', 50, 100),
('Terratemblor', 'Tierra', 60, 100),
('Bucle Arena', 'Tierra', 35, 85),
('Aire Afilado', 'Volador', 55, 95),
('Golpe Aéreo', 'Volador', 60, 100),
('Psicorrayo', 'Psíquico', 65, 100),
('Cortefuria', 'Bicho', 40, 95),
('Viento Aciago', 'Fantasma', 60, 100),
('Dragoaliento', 'Dragón', 60, 100),
('Ciclón', 'Dragón', 40, 100),
('Finta', 'Siniestro', 60, 100),
('Buena Baza', 'Siniestro', 50, 100);

INSERT INTO Pokemones (Nombre, Tipo, HPBase, AtaqueBase, DefensaBase, Ataque1Id, Ataque2Id, Ataque3Id, Ataque4Id) VALUES
-- Generación 1
('Bulbasaur', 'Planta', 45, 49, 49, 1, 12, 10, 20),
('Charmander', 'Fuego', 39, 52, 43, 2, 12, 6, 15),
('Squirtle', 'Agua', 44, 48, 65, 1, 12, 8, 18),
('Caterpie', 'Bicho', 45, 30, 35, 1, 2, 34, 12),
('Pidgey', 'Volador', 40, 45, 40, 1, 31, 3, 32),
('Rattata', 'Normal', 30, 56, 35, 1, 3, 28, 13),
('Pikachu', 'Eléctrico', 35, 55, 40, 4, 14, 21, 3),
('Sandshrew', 'Tierra', 50, 75, 85, 2, 30, 27, 29),
('Vulpix', 'Fuego', 38, 41, 40, 6, 3, 35, 16),
('Zubat', 'Veneno', 40, 45, 35, 28, 31, 12, 32),
('Machop', 'Lucha', 70, 80, 50, 26, 12, 25, 13),
('Geodude', 'Tierra', 40, 80, 100, 1, 13, 30, 29),
('Gastly', 'Fantasma', 30, 35, 30, 12, 35, 38, 33),
('Eevee', 'Normal', 55, 55, 50, 1, 12, 3, 13),
('Dratini', 'Dragón', 41, 64, 45, 12, 37, 21, 36),

-- Generación 2
('Chikorita', 'Planta', 45, 49, 65, 1, 12, 11, 19),
('Cyndaquil', 'Fuego', 39, 52, 43, 1, 12, 6, 14),
('Totodile', 'Agua', 50, 65, 64, 2, 12, 8, 24),
('Mareep', 'Eléctrico', 55, 40, 40, 1, 12, 4, 21),
('Houndour', 'Siniestro', 45, 60, 30, 6, 12, 38, 15),
('Phanpy', 'Tierra', 90, 60, 60, 1, 12, 29, 13),
('Larvitar', 'Tierra', 50, 64, 50, 38, 13, 30, 29),
('Swinub', 'Hielo', 50, 50, 40, 1, 23, 29, 24),
('Teddiursa', 'Normal', 60, 80, 50, 2, 12, 38, 13),
('Togepi', 'Normal', 35, 20, 65, 12, 1, 38, 33),

-- Generación 3
('Treecko', 'Planta', 40, 45, 35, 1, 12, 20, 3),
('Torchic', 'Fuego', 45, 60, 40, 2, 12, 6, 32),
('Mudkip', 'Agua', 50, 70, 50, 1, 12, 8, 30),
('Poochyena', 'Siniestro', 35, 55, 35, 1, 12, 38, 28),
('Ralts', 'Psíquico', 28, 25, 25, 12, 33, 19, 21),
('Aron', 'Normal', 50, 70, 100, 1, 29, 14, 13),
('Trapinch', 'Tierra', 45, 100, 45, 2, 30, 38, 29),
('Snorunt', 'Hielo', 50, 50, 50, 1, 23, 35, 24),
('Bagon', 'Dragón', 45, 75, 60, 1, 37, 13, 36),
('Beldum', 'Psíquico', 40, 55, 80, 1, 33, 13, 3),

-- Generación 4
('Turtwig', 'Planta', 55, 68, 64, 1, 20, 11, 13),
('Chimchar', 'Fuego', 44, 58, 44, 2, 6, 26, 16),
('Piplup', 'Agua', 53, 51, 53, 1, 12, 18, 32),
('Shinx', 'Eléctrico', 45, 65, 34, 1, 12, 22, 28),
('Cranidos', 'Normal', 67, 125, 40, 13, 14, 38, 29),
('Gible', 'Dragón', 58, 70, 45, 1, 30, 37, 36),
('Riolu', 'Lucha', 40, 70, 40, 3, 12, 26, 25),
('Snover', 'Hielo', 60, 62, 50, 1, 20, 23, 19),

-- Generación 5
('Snivy', 'Planta', 45, 45, 55, 1, 10, 31, 19),
('Tepig', 'Fuego', 65, 63, 45, 1, 6, 26, 15),
('Oshawott', 'Agua', 55, 55, 45, 1, 8, 17, 34),
('Venipede', 'Bicho', 30, 45, 59, 28, 34, 27, 13),
('Sandile', 'Tierra', 50, 72, 35, 1, 30, 39, 29),
('Zorua', 'Siniestro', 40, 65, 40, 2, 38, 14, 39),
('Axew', 'Dragón', 46, 87, 60, 2, 38, 37, 36);

INSERT INTO PokemonUsuario (UsuarioId, PokemonID, Nivel, HP, Ataque, Defensa) VALUES
(1, 2, 1, 39, 52, 43),
(2, 1, 1, 35, 55, 40),
(3, 3, 1, 44, 48, 65);

INSERT INTO HistorialTorneos (UsuarioId, PokemonID, FaseLograda) VALUES
(1, 2, '16VO'),
(2, 1, 'Semifinales'),
(3, 3, 'Campeon');