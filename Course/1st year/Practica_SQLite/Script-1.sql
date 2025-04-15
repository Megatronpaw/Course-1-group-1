--Часть А

CREATE TABLE Reviews (
id INTEGER PRIMARY KEY AUTOINCREMENT,
reservation_id INTEGER,
rating INTEGER,
FOREIGN KEY (reservation_id) REFERENCES Reservations(id)
);

CREATE TABLE Reservations (
id INTEGER PRIMARY KEY AUTOINCREMENT,
user_id INTEGER,
room_id INTEGER,
start_date TEXT,
end_date TEXT,
price INTEGER,
total INTEGER,
FOREIGN KEY (user_id) REFERENCES Users(id),
FOREIGN KEY (room_id) REFERENCES Rooms(id)
);

CREATE TABLE Users (
id INTEGER PRIMARY KEY AUTOINCREMENT,
name TEXT NOT NULL,
email TEXT NOT NULL,
email_verified TEXT NOT NULL,
password TEXT NOT NULL,
phone_number TEXT NOT NULL
);

CREATE TABLE Rooms (
id INTEGER PRIMARY KEY AUTOINCREMENT,
home_type TEXT NOT NULL,
address TEXT NOT NULL,
has_tv BOOLEAN,
has_internet BOOLEAN,
has_kitchen BOOLEAN,
has_air_con BOOLEAN,
price INTEGER,
owner_id INTEGER,
latitude FLOAT,
longitube FLOAT,
FOREIGN KEY (owner_id) REFERENCES Users(id)
);

INSERT INTO Reviews (rating, reservation_id) VALUES
(5, 1),
(2, 2),
(3, 3),
(9, 4),
(10, 5),
(2, 6),
(5, 7),
(4, 8),
(1, 9),
(8, 10);

INSERT INTO Reservations (user_id, room_id,start_date, end_date, price, total) VALUES
(2, 3,'2025-04-14', '2025-04-30', 5000, 3),
(3, 1,'2025-05-25', '2025-05-31', 2500, 1),
(1, 2,'2025-06-11', '2025-06-28', 4500, 2),
(4, 6,'2025-06-14', '2025-06-20', 3500, 5),
(8, 7,'2025-07-18', '2025-07-28', 1500, 4),
(9, 9,'2025-08-11', '2025-08-21', 4500, 6),
(10, 4,'2025-09-22', '2025-09-24', 2000, 8),
(7, 5,'2025-10-30', '2025-11-18', 3000, 10),
(6, 8,'2025-07-23', '2025-07-22', 4000, 7),
(5, 10,'2025-12-20', '2025-12-25', 5000, 9);

INSERT  INTO Users (name, email, email_verified, password, phone_number) VALUES
('Ольга Сергеевна', 'OlgaSerg@mail.com', 'yes', 123456, 89997743388),
('Егор Павлович', 'EgorPavl@mail.com', 'no', 356644, 81234567800),
('Анна Викторовна', 'AnnVick@mail.com', 'yes', 453216, 83453543444),
('Илья Генадьевич', 'IlyaGen@mail.com', 'yes', 975495, 89347863468),
('Артем Станиславович', 'ArtemStan@mail.com', 'no', 643532, 87549630300),
('Юля Анатольевна', 'YuliyaAnat@mail.com', 'yes', 197532, 88881778214),
('Юрий Игорьевич', 'YuriyIgor@mail.com', 'no', 345664, 87116652345),
('Наталья Вадимовна', 'NatalVadim@mail.com', 'no', 876934, 80008775432),
('Даниил Васильев', 'DanilVasil@mail.com', 'yes', 7680006, 84567655698),
('Генадий Николаевич', 'GenadiyNokol@mail.com', 'yes', 876503, 87776543136);

INSERT INTO Rooms (home_type, address, has_tv, has_internet, has_kitchen, has_air_con, price, owner_id, latitude, longitube) VALUES 
('manor', 'pushkin', TRUE, TRUE, FALSE, TRUE, 2000, 3, 100, 120),
('cottage','vysotskaya', FALSE, FALSE, TRUE , TRUE, 1200, 2, 50, 100),
('villa','dobraya', FALSE, TRUE, TRUE, FALSE, 3000, 1, 120, 200),
('four-room','nevskay', TRUE, TRUE, TRUE, FALSE, 4000, 7, 100, 200),
('one-room','nedobraya', TRUE, FALSE, TRUE, FALSE, 3500, 10, 150, 200),
('three-room','staraya', FALSE, TRUE, FALSE, FALSE, 2500, 4, 100, 150),
('one-room','zlaya', FALSE, FALSE, FALSE, FALSE, 3000, 9, 50, 100),
('villa','zjivaya', FALSE, TRUE, TRUE, TRUE, 3500, 6, 100, 200),
('two-room','novaya', TRUE, TRUE, TRUE, TRUE, 6000, 8, 150, 230),
('two-room','goydava', FALSE, TRUE, TRUE, FALSE, 2000, 5, 140, 200);

-- Часть B

SELECT r.home_type, r.has_tv, r.has_internet
FROM Rooms r 
WHERE r.has_tv = TRUE AND r.has_internet = TRUE;

SELECT re.user_id, re.room_id
FROM Reservations re 
WHERE re.user_id = 1;

SELECT u.name, u.email_verified
FROM Users u 
WHERE u.email_verified = 'no';

SELECT re.room_id, re.start_date, re.end_date
FROM Reservations re 
WHERE (re.start_date = '2025-06-11' AND re.end_date = '2025-06-28') OR ( re.start_date = '2025-08-11' AND re.end_date = '2025-08-21');

SELECT AVG(price) AS avg_price 
FROM Rooms

--Часть C 

SELECT SUM(price) AS sum_price
FROM Reservations re
WHERE (re.start_date = '2025-10-30' AND re.end_date = '2025-11-18') OR (re.start_date ='2025-07-23' AND re.end_date = '2025-07-22');

SELECT re.room_id, re.price 
FROM Reservations re
WHERE re.price > 2500 AND re.price < 5000;

SELECT COUNT(r.rating) AS count_rating, AVG(r.rating) AS avg_rating
FROM Reviews r;

SELECT r.home_type , MAX(r.price) AS max_price
FROM Rooms r
GROUP BY r.home_type;