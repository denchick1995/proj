create database [Документация]
go
use Документация
go
create table Сотрудник
(
id int primary key identity,
ФИО varchar(max),
должность varchar(max),
закрыт_тема bit
)
go
create table Заказчик
(
id int primary key identity,
ИНН int,
КПП varchar(max),
р_c varchar(max),
юр_адрес varchar(max),
почт_адрес varchar(max),
банк varchar(max),
к_с varchar(max)
)
go
create table Документ
(
id int primary key identity,
id_приложения int,
id_заказчика int,
тип varchar(max),
подтип varchar(max),
дата varchar(max),
рег_номер varchar(max),
номер varchar(max),
начало_работ varchar(max),
конец_работ varchar(max),
закр_тема bit
)
go
create table Приложение
(
id int primary key identity,
комментарий varchar(max)
)
go
create table Привлеченный_сотрудник
(
id int primary key identity,
id_сотрудника int,
id_документа int,
id_роли int,
коментарий varchar(max)
)
go
create table Роль
(
id int primary key identity,
роль varchar(max)
)
go
ALTER TABLE документ
   ADD CONSTRAINT FK_1 FOREIGN KEY (id_заказчика)
      REFERENCES  заказчик(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
go
ALTER TABLE документ
   ADD CONSTRAINT FK_2 FOREIGN KEY (id_приложения)
      REFERENCES  приложение(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
go
ALTER TABLE Привлеченный_сотрудник
   ADD CONSTRAINT FK_3 FOREIGN KEY (id_сотрудника)
      REFERENCES  сотрудник(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
ALTER TABLE Привлеченный_сотрудник
   ADD CONSTRAINT FK_4 FOREIGN KEY (id_роли)
      REFERENCES  роль(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
go
ALTER TABLE Привлеченный_сотрудник
   ADD CONSTRAINT FK_5 FOREIGN KEY (id_документа)
      REFERENCES  документ(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
go
insert into Сотрудник values('admin','admin','1')--добавление администратора
