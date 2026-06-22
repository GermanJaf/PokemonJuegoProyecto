DROP TABLE IF EXISTS [PokemonUsuario];
DROP TABLE IF EXISTS [HistorialTorneos];
DROP TABLE IF EXISTS [Usuarios];
DROP TABLE IF EXISTS [Ataques];
DROP TABLE IF EXISTS [Pokemones];

CREATE TABLE Usuarios(
       [Id] INTEGER PRIMARY KEY AUTOINCREMENT,
       [NombreUsuario] TEXT NOT NULL,
       [Contraseña] TEXT NOT NULL,
       [BatallasGanadas] INTEGER DEFAULT 0
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
       [DefensaBase] INTEGER NOT NULL
);

CREATE TABLE PokemonUsuario(
       [Id] INTEGER PRIMARY KEY AUTOINCREMENT,
       [UsuarioId] INTEGER,
       [PokemonID] INTEGER,
       [Nivel] INTEGER DEFAULT 1,
       [HP] INTEGER,
       [BatallasGanadasPK] INTEGER DEFAULT 0,
       [Ataque1Id] INTEGER,
       [Ataque2Id] INTEGER,
       [Ataque3Id] INTEGER,
       [Ataque4Id] INTEGER,
       FOREIGN KEY ([UsuarioId]) REFERENCES Usuarios([Id]),
       FOREIGN KEY ([PokemonID]) REFERENCES Pokemones([Id]),
       FOREIGN KEY ([Ataque1Id]) REFERENCES Ataques([Id]),
       FOREIGN KEY ([Ataque2Id]) REFERENCES Ataques([Id]),
       FOREIGN KEY ([Ataque3Id]) REFERENCES Ataques([Id]),
       FOREIGN KEY ([Ataque4Id]) REFERENCES Ataques([Id])
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
('Gruñido', 'Normal', 0, 100);

INSERT INTO Pokemones (Nombre, Tipo, HPBase, AtaqueBase, DefensaBase) VALUES
('Pikachu', 'Electrico', 35, 55, 40),
('Charmander', 'Fuego', 39, 52, 43),
('Squirtle', 'Agua', 44, 48, 65),
('Bulbasaur', 'Planta', 45, 49, 49);

INSERT INTO PokemonUsuario (UsuarioId, PokemonID, Nivel, HP, Ataque1Id, Ataque2Id, Ataque3Id, Ataque4Id) VALUES
(1, 2, 1, 35, 6, 7, 2, 12),
(2, 1, 1, 35, 3, 4, 5, 12),
(3, 3, 1, 43, 8, 9, 1, 12);

INSERT INTO HistorialTorneos (UsuarioId, PokemonID, FaseLograda) VALUES
(1, 2, '16VO'),
(2, 1, 'Semifinales'),
(3, 3, 'Campeon');


--HOLA MAYATES