use master

create table Doctor_Details
(
Doctor_Id int,
Doctor_FullName nvarchar(200),
UIN nvarchar(400),
YOE Datetime,
Date_of_Birth Datetime,
Gendar nvarchar(30)
)

ALTER TABLE Doctor_Details
ADD ID int primary key;

select * from Doctor_Details
insert into Doctor_Details values('Rajiv Modi','00000000','04/10/1994','05/09/2000','Male',1)