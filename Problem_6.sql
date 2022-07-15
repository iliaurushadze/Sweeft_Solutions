/* ააგეთ ნებისმიერ რელაციურ ბაზაში ისეთი დამოკიდებულება, რომელიც საშუალებას მოგვცემს, 
რომ მასწავლებელმა ასწავლოს რამოდენიმე მოსწავლეს და ამავდროულად მოსწავლეს ჰყავდეს 
რამდენიმე მასწავლებელი (როგორც რეალურ ცხოვრებაში).*/

/*1. დაწერეთ sql რომელიც ააგებს შესაბამის table-ებს.*/

CREATE TABLE Teacher(
teacher_id SERIAL PRIMARY KEY,
firstname VARCHAR(20) NOT NULL,
surname VARCHAR(20) NOT NULL,
sex VARCHAR(1) NOT NULL,
subject_name VARCHAR(20) NOT NULL
);
	
INSERT INTO Teacher(firstname, surname, sex, subject_name)
VALUES
('Teona', 'Kikvadze', 'F', 'Biology'),
('Ivane', 'Sajaia', 'M', 'Mathematics'),
('Maro', 'Nutsubidze', 'F', 'Geography'),
('Anzor', 'Shonia', 'M', 'Sports'),
('Inga', 'Gogia', 'F', 'English');



CREATE TABLE Pupil(
pupil_id SERIAL PRIMARY KEY,
firstname VARCHAR(20) NOT NULL,
surname VARCHAR(20) NOT NULL,
sex VARCHAR(1) NOT NULL,
grade SMALLINT NOT NULL
);



INSERT INTO Pupil(firstname, surname, sex, grade)
VALUES
('Asmat', 'Pantsulaia', 'F', 8),
('Giorgi', 'Gvasalia', 'M', 7),
('Keto', 'Kapanadze', 'F', 5),
('Lia', 'Tsereteli', 'F', 6),
('Mediko', 'Tkebuchava', 'F', 10),
('Giorgi', 'Kvinikadze', 'M', 8),
('Dali', 'Lursmanashvili', 'F', 11),
('Giorgi', 'Dvalishvili', 'M', 12),
('Irine', 'Bokuchava', 'F', 6),
('Koba', 'Kalandadze', 'M', 8),
('Joni', 'Demetrashvili', 'M', 4),
('Lili', 'Kvernadze', 'F', 10),
('Iza', 'Kevkhishvili', 'F', 9),
('Giorgi', 'Gharibashvili', 'M', 9),
('Nino', 'Jalaghonia', 'F', 7);


CREATE TABLE Subject(
subject_id SERIAL PRIMARY KEY,
subject_name VARCHAR(15) NOT NULL,
subject_grade SMALLINT NOT NULL,
pupil_id INTEGER REFERENCES Pupil(pupil_id),
teacher_id INTEGER REFERENCES Teacher(teacher_id)
);


INSERT INTO Subject(subject_name, subject_grade, pupil_id, teacher_id)
VALUES
('Biology', 7, 8, 1),
('Biology', 8, 2, 1),
('Biology', 9, 6, 1),
('Biology', 10, 14, 1),
('Biology', 7, 15, 1),
('Biology', 8, 10, 1),
('Biology', 9, 13, 1),
('Biology', 9, 14, 1),
('Biology', 10, 5, 1),
('Mathematics', 4, 11, 2),
('Mathematics', 5, 3, 2),
('Mathematics', 6, 4, 2),
('Mathematics', 7, 8, 2),
('Mathematics', 8, 2, 2),
('Mathematics', 9, 6, 2),
('Mathematics', 10, 12, 2),
('Mathematics', 11, 7, 2),
('Mathematics', 12, 8, 2),
('Geography', 5, 3, 3),
('Geography', 4, 11, 3),
('Sports', 7, 8, 4),
('Sports', 8, 2, 4),
('Sports', 9, 6, 4),
('English', 5, 3, 5),
('English', 6, 9, 5),
('English', 7, 8, 5),
('English', 8, 2, 5),
('English', 8, 6, 5),
('English', 8, 1, 5);


/*2. დაწერეთ sql რომელიც დააბრუნებს ყველა მასწავლებელს, რომელიც ასწავლის 
მოსწავლეს, რომელის 	სახელია: „გიორგი“.*/

SELECT DISTINCT Teacher.firstname, Teacher.surname
FROM Teacher
INNER JOIN Subject
ON Teacher.teacher_id = Subject.teacher_id
INNER JOIN Pupil
ON Subject.pupil_id = Pupil.pupil_id
WHERE Pupil.firstname = 'Giorgi';