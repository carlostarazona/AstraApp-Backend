# Astra-App

## Base de datos

![Base-de-datos](https://user-images.githubusercontent.com/54924126/75950110-49786400-5e76-11ea-8edb-313593cb5e4a.png)

## Requerimientos

```
-Visual Studio o Visual Studio Code
-Version 2.2 de Net Core SDK
-SQL Server management Studio

De usar visual code descargar Dotnet y utilizar los siguiente plugins:
   *C#
   *C# Extensions
   *Material Icon Theme
   *NuGet Package Manager
   *REST Client
   *SQL Server
   
Buscar Similares en visual studio
   
```

## Migracion del proyecto

```
En la terminal del archivo Hospital.Repositoy utilizar los siguientes comandos

-dotnet ef --startup-project ../Hospital.Api migrations add init
-dotnet ef --startup-project ../Hospital.Api database update

```
## Datos para la Base

```
SET IDENTITY_INSERT  AreaUsers ON 
INSERT INTO AreaUsers (Id, Namearea) VALUES (1, N'Cardio')
INSERT INTO AreaUsers (Id, Namearea) VALUES (2, N'Dermatologia')
INSERT INTO AreaUsers (Id, Namearea) VALUES (3, N'Reumatologia')
INSERT INTO AreaUsers (Id, Namearea) VALUES (4, N'Neurologia')
INSERT INTO AreaUsers (Id, Namearea) VALUES (5, N'Ninguna')

SET IDENTITY_INSERT  AreaUsers OFF
SET IDENTITY_INSERT  Hospitalusers ON 
INSERT INTO Hospitalusers (Id, Namehospital, Addresshospital) VALUES (1, N'Santa Rosa', N'Av. Simón Bolivar 8, Pueblo Libre 15084')
INSERT INTO Hospitalusers (Id, Namehospital, Addresshospital) VALUES (2, N'San Bernando', N'Jirón San Josė, Pueblo Libre 15084')
INSERT INTO Hospitalusers (Id, Namehospital, Addresshospital) VALUES (3, N'Ninguna', NULL)

SET IDENTITY_INSERT  Hospitalusers OFF
SET IDENTITY_INSERT  Roles ON 
INSERT INTO Roles (Id, namerole, descripcion) VALUES (1, N'Admin', N'es el encargado de la plataforma Astra')
INSERT INTO Roles (Id, namerole, descripcion) VALUES (2, N'Engineer', N'Es el ingeniero encargardo de revisar las maquinas del hospital')
INSERT INTO Roles (Id, namerole, descripcion) VALUES (3, N'Doctor', N'Es el Encargado de una area del hospital del cual quiere que revisemos sus maquina')

SET IDENTITY_INSERT  Roles OFF
SET IDENTITY_INSERT  Users ON 
INSERT INTO Users (Id, Name, Namehospital, Namearea, Namerol, Idrol, Idarea, Idhospital, Typedoc, Numdoc, Phone, Email, password, act_password, password_hash, password_salt, RoleId, AreaId, HospitalId) VALUES (1005, N'Jose', N'Ninguna', N'Ninguna', N'Admin', 1, 5, 3, N'DNI', N'72974346', N'999650147', N'joseramos@hotmail.com', N'456789', 0, 0x6CB4066C8A34DDCD613DDA08340EA97255500210D0CC11466C97F388153A2CC1099CA1359FC56C0B10AA74E7E2C76AD2E006AE14C06E3C2D5AF693B68BE1C4E7, 0xE70BBD5053DFB18A567050321E879F35E3982B5ACBCC4617231C5C6A68127C1F576C136C572274C73E4BE970D55FAC55706E7A4011BD8E2842F4C634E7128FEC955B12576BDB50A5EF45AEBC22800A806795FEB2CA6CF699B8AC3912C46871E4E5ABACD4BBFEA2AA33E8E7E6E53DBC822588095C40380022B09A77F33E98907F, NULL, NULL, NULL)
INSERT INTO Users (Id, Name, Namehospital, Namearea, Namerol, Idrol, Idarea, Idhospital, Typedoc, Numdoc, Phone, Email, password, act_password, password_hash, password_salt, RoleId, AreaId, HospitalId) VALUES (1006, N'Carlos', N'San Bernando', N'Dermatologia', N'Doctor', 3, 2, 2, N'DNI', N'78952469', N'999850466', N'carlostara987@hotmail.com', N'123456', 0, 0x75352EDE7BA2F5967C3EF3886D1093C936608418EBEA0E7CBAA3E818DC516C3194512A4BC130DE4B8CF5231C18642BCB51045DC53EDC7D5731AC2E3B258633F3, 0x234DBCAB52462172F1B8BC1721207C6BD1F32777FDA28357119226BD70DB1768B13EC672314EC5A5D62676B6BF87ABB339966A1464F2AC17450E467BDEEB3A85E1FA88B66C785EC3C71D03EE9FE8109CBFCFFE9126B9549B010A01964426E3E027009FBDB6EE99C739675EC6F452EF10558B682F41EF78C385F69CA4CF2A1C4E, NULL, NULL, NULL)
INSERT INTO Users (Id, Name, Namehospital, Namearea, Namerol, Idrol, Idarea, Idhospital, Typedoc, Numdoc, Phone, Email, password, act_password, password_hash, password_salt, RoleId, AreaId, HospitalId) VALUES (1007, N'Pedro', N'Santa Rosa', N'Neurologia', N'Doctor', 3, 4, 1, N'DNI', N'78925044', N'950488330', N'pedro850@hotmail.com', N'pedro123', 0, 0xD0A91B52BD9F82351AF466A51BEB42EA0E781A96C941137C84F194B1C9B31F296CE6FD6CBB5A524EE2760056DF56EB96F2A1A345AFBB3999B297BFF249E32748, 0x1AF68E85645F5B440953AAFCF16EBEADD89E29F535F6A5203B8F05DCD18BFBFD87C008EEEAACE8E9C4FCCDD23A2D25BDB326DC6552C6566731768F258ED787696776DBBAE20B4079D576BA3E8FD62D0A3F4166CBA37763CBA4BD293D0F61AEA84CAE2D1B29456A9F826072614B1F1FB78A1C4FE4BEC8B9306F3EEF66BDF3F3E7, NULL, NULL, NULL)
INSERT INTO Users (Id, Name, Namehospital, Namearea, Namerol, Idrol, Idarea, Idhospital, Typedoc, Numdoc, Phone, Email, password, act_password, password_hash, password_salt, RoleId, AreaId, HospitalId) VALUES (1008, N'Marcelo', N'Ninguna', N'Ninguna', N'Engineer', 2, 5, 3, N'DNI', N'74088620', N'950998075', N'marcelo900@hotmail.com', N'789123', 0, 0xCB0F9414132EBB79136D2342887FECF93A5F802978164F8632E75BD3E5352EEF8C432DA19C0B34C4E2FB9457F817B805F5E8679ED90A49ECC14A3A6C5C6B0398, 0x034FED61DE47AA39995DE2E41B1FF53E821D850FD18FF8C41D5E2CDA934E1351E3139A89D9B19C88FD291004F2B6FB3A7A5D0FD6720E5E2B26DE19E617D636A780AB0A72B6990F6684D49998095CF232AD914257E1315AA215869066C17AB7624E092A23047FF7D559B799F4DD65B2A5B39F8301C3F5169C13DC6594C334589F, NULL, NULL, NULL)
INSERT INTO Users (Id, Name, Namehospital, Namearea, Namerol, Idrol, Idarea, Idhospital, Typedoc, Numdoc, Phone, Email, password, act_password, password_hash, password_salt, RoleId, AreaId, HospitalId) VALUES (1009, N'Juliana', N'Ninguna', N'Ninguna', N'Engineer', 2, 5, 3, N'DNI', N'680144580', N'970205018', N'juliana24/7@hotmail.com', N'juli000', 0, 0x583976347FF70A33C7B5331547DFC234386A214AEFFAA97A40A8A9FB5ADD72C3ED4DF20C10F2B83CE3D1762BE84CD58BCC78914C1E4CCAB5FF5158FE3475E068, 0x5CC5C48E5D2B5E6A58C7117904A73F6BEC41B37BCA84070C7AD67040FB799A6C866A3DF3C6B8FA7F320BFA5FDD0BAD32B2EA235EF99CC6E3DF7D811F75DB0F72FAE96C2918B45692CDAB2E10E3E2E32D2D1C8403F2FF182088CE0691B9AA4B8397E9C895CD2DECBA463A83E5316CD2D0FC32F7F6814FEF46540277F853585BC0, NULL, NULL, NULL)

SET IDENTITY_INSERT  Users OFF
SET IDENTITY_INSERT  Medicalequipments ON 
INSERT INTO Medicalequipments (Id, Iduser, Nameuser, Namehospital, Namearea, Statedescription, Brand, Name, UserId) VALUES (10, 1006, N'Carlos', N'San Bernando', N'Dermatologia', N'Maquina que mide el pulso cardaquio', N'Holder', N'Pulximetro', NULL)
INSERT INTO Medicalequipments (Id, Iduser, Nameuser, Namehospital, Namearea, Statedescription, Brand, Name, UserId) VALUES (11, 1006, N'Carlos', N'San Bernando', N'Dermatologia', N'Saca placas con rayos x', N'Tyler oslon', N'Maquina Rayos x', NULL)
INSERT INTO Medicalequipments (Id, Iduser, Nameuser, Namehospital, Namearea, Statedescription, Brand, Name, UserId) VALUES (12, 1006, N'Carlos', N'San Bernando', N'Dermatologia', N'Terapia de sustitucion renal', N'Elnur', N'Hemodialisis', NULL)
INSERT INTO Medicalequipments (Id, Iduser, Nameuser, Namehospital, Namearea, Statedescription, Brand, Name, UserId) VALUES (13, 1007, N'Pedro', N'Santa Rosa', N'Neurologia', N'técnica no invasiva que utiliza el fenómeno de la resonancia magnética nuclear para obtener información sobre la estructura y composición del cuerpo a analizar.', N'Elbron', N'Maquina De Resonancia Magnetica', NULL)
INSERT INTO Medicalequipments (Id, Iduser, Nameuser, Namehospital, Namearea, Statedescription, Brand, Name, UserId) VALUES (14, 1007, N'Pedro', N'Santa Rosa', N'Neurologia', N'son ondas acústicas cuya frecuencia está por encima de la capacidad de audición del oído humano', N'Leaf', N'Ultrasonido', NULL)

SET IDENTITY_INSERT  Medicalequipments OFF
SET IDENTITY_INSERT  Orders ON 
INSERT INTO Orders (Id, Priority, Date, Idmedicalequipment, Nombremedicalequipment, Description, MedicalequipmentId) VALUES (3, 2, N'2020-03-25', 10, N'Pulximetro', N'No capta bien los pulsos de las personas ', 10)
INSERT INTO Orders (Id, Priority, Date, Idmedicalequipment, Nombremedicalequipment, Description, MedicalequipmentId) VALUES (4, 4, N'2020-03-13', 14, N'Ultrasonido', N'No produce el sonido necesario para que se pueda visualizar alguna frecuencia', 14)
INSERT INTO Orders (Id, Priority, Date, Idmedicalequipment, Nombremedicalequipment, Description, MedicalequipmentId) VALUES (5, 3, N'2020-03-27', 11, N'Maquina Rayos x', N'La maquina de Rayos X esta funcionando de forma inadecuada ', 11)
INSERT INTO Orders (Id, Priority, Date, Idmedicalequipment, Nombremedicalequipment, Description, MedicalequipmentId) VALUES (6, 2, N'2020-05-09', 11, N'Maquina Rayos x', N'no prende', 11)

SET IDENTITY_INSERT  Orders OFF
SET IDENTITY_INSERT  Schedules ON 
INSERT INTO Schedules (Id, Name, Agreeddate, arrivaldate, Idorder, Iduser, Descriptionorder, Nombremedicalequipment, Hospitaluser, OrderId, UserId) VALUES (1, N'Cronograma1', N'2020-03-05', N'2020-04-10', 4, 1009, N'No produce el sonido necesario para que se pueda visualizar alguna frecuencia', N'Ultrasonido', N'Ninguna', 4, 1009)
INSERT INTO Schedules (Id, Name, Agreeddate, arrivaldate, Idorder, Iduser, Descriptionorder, Nombremedicalequipment, Hospitaluser, OrderId, UserId) VALUES (2, N'Carlos', N'2020-02-20', N'2020-03-27', 4, 1008, N'No produce el sonido necesario para que se pueda visualizar alguna frecuencia', N'Ultrasonido', N'Ninguna', 4, 1008)
INSERT INTO Schedules (Id, Name, Agreeddate, arrivaldate, Idorder, Iduser, Descriptionorder, Nombremedicalequipment, Hospitaluser, OrderId, UserId) VALUES (1002, N'Cronograma 4', N'2020-02-22', N'2020-03-13', 6, 1009, N'no prende', N'Maquina Rayos x', N'Ninguna', 6, 1009)
INSERT INTO Schedules (Id, Name, Agreeddate, arrivaldate, Idorder, Iduser, Descriptionorder, Nombremedicalequipment, Hospitaluser, OrderId, UserId) VALUES (1003, N'Cronograma 3', N'2020-02-25', N'2020-03-07', 5, 1009, N'La maquina de Rayos X esta funcionando de forma inadecuada ', N'Maquina Rayos x', N'Ninguna', 5, 1009)

SET IDENTITY_INSERT  Schedules OFF
SET IDENTITY_INSERT  Machinereviews ON 
INSERT INTO Machinereviews (Id, Reviewdate, description, Idschedule, Nombremaquina, ScheduleId) VALUES (1, N'2020-04-09', N'La verdad que estaba bien :v', 2, N'Ultrasonido', 2)
INSERT INTO Machinereviews (Id, Reviewdate, description, Idschedule, Nombremaquina, ScheduleId) VALUES (2, N'2020-05-08', N'Este se tiene que volver a revisar', 1002, N'Maquina Rayos x', 1002)
INSERT INTO Machinereviews (Id, Reviewdate, description, Idschedule, Nombremaquina, ScheduleId) VALUES (3, N'2020-04-15', N'Este Ya no para que utilizarlo ', 1003, N'Maquina Rayos x', 1003)
INSERT INTO Machinereviews (Id, Reviewdate, description, Idschedule, Nombremaquina, ScheduleId) VALUES (4, N'2020-02-15', N'Ni que decir', 1, N'Ultrasonido', 1)

SET IDENTITY_INSERT  Machinereviews OFF
SET IDENTITY_INSERT  Finalreports ON 
INSERT INTO Finalreports (Id, Description, Reportdate, Idmachinereview, Nombremaquina, MachinereviewId) VALUES (3, N'La maquina esta bien :v', N'2020-04-10', 2, N'Maquina Rayos x', 2)
INSERT INTO Finalreports (Id, Description, Reportdate, Idmachinereview, Nombremaquina, MachinereviewId) VALUES (4, N'buena revision', N'2020-02-15', 1, N'Ultrasonido', 1)
INSERT INTO Finalreports (Id, Description, Reportdate, Idmachinereview, Nombremaquina, MachinereviewId) VALUES (5, N'buena revision', N'2020-02-15', 3, N'Maquina Rayos x', 3)

SET IDENTITY_INSERT  Finalreports OFF

```

## Arranque los proyecto
```
star Debuggins en Hospital.Entity

```
