create database [������������]
go
use ������������
go
create table ���������
(
id int primary key identity,
��� varchar(max),
��������� varchar(max),
������_���� bit
)
go
create table ��������
(
id int primary key identity,
��� int,
��� varchar(max),
�_c varchar(max),
��_����� varchar(max),
����_����� varchar(max),
���� varchar(max),
�_� varchar(max)
)
go
create table ��������
(
id int primary key identity,
id_���������� int,
id_��������� int,
��� varchar(max),
������ varchar(max),
���� varchar(max),
���_����� varchar(max),
����� varchar(max),
������_����� varchar(max),
�����_����� varchar(max),
����_���� bit
)
go
create table ����������
(
id int primary key identity,
����������� varchar(max)
)
go
create table ������������_���������
(
id int primary key identity,
id_���������� int,
id_��������� int,
id_���� int,
���������� varchar(max)
)
go
create table ����
(
id int primary key identity,
���� varchar(max)
)
go
ALTER TABLE ��������
   ADD CONSTRAINT FK_1 FOREIGN KEY (id_���������)
      REFERENCES  ��������(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
go
ALTER TABLE ��������
   ADD CONSTRAINT FK_2 FOREIGN KEY (id_����������)
      REFERENCES  ����������(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
go
ALTER TABLE ������������_���������
   ADD CONSTRAINT FK_3 FOREIGN KEY (id_����������)
      REFERENCES  ���������(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
ALTER TABLE ������������_���������
   ADD CONSTRAINT FK_4 FOREIGN KEY (id_����)
      REFERENCES  ����(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
go
ALTER TABLE ������������_���������
   ADD CONSTRAINT FK_5 FOREIGN KEY (id_���������)
      REFERENCES  ��������(id)
       ON DELETE CASCADE
      ON UPDATE CASCADE
go
insert into ��������� values('admin','admin','1')--���������� ��������������
