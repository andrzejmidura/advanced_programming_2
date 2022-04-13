drop table reservations cascade;
drop table orders cascade;
drop table vehicles cascade;
drop table clients cascade;

begin;

create table clients(
	idClient	serial	 		primary key,
	name		varchar(20) 	not null,
	surname		varchar(20) 	not null,
	address		varchar(40)		not null,
	phone		numeric(9,0)	not null
);

create table vehicles(
	idVehicle	integer 	primary key,
	brand		varchar(20)	not null,
	model		varchar(40) not null,
	engine		varchar(20) not null,
	color		varchar(20) not null
);

create table orders(
	idOrder		serial	primary key,
	idClient	integer not null references clients,
	idVehicle	integer not null references vehicles,
	orderDate	date 	not null
);

create table reservations(
	idReservation	serial 	primary key,
	idClient		integer not null references clients,
	idOrder			integer not null references orders,
	reservationDate	date 	not null
);

copy vehicles from stdin with (null '', delimiter '|');
1|Alfa Romeo|6|2.5 i.e.|bialy
2|Alfa Romeo|6|2.5 i.e.|czarny
3|Aston Martin|AMV8|5.3 V8 Vantage|czarny
4|Aston Martin|AMV8|5.3 V8 Vantage|zielony
5|Aston Martin|AMV8|5.3 V8 Vantage|granatowy
6|Aston Martin|DB4 GT|3.7|zielony
7|Aston Martin|DB4 GT|3.7|blekitny
8|Aston Martin|DB4 GT|3.7|granatowy
9|Ford|Mustang Convertible I (facelift 1971)|7.0 Cobra Jet V8|czerwony
10|Ford|Mustang Convertible I (facelift 1971)|7.0 Cobra Jet V8|bialy
11|Ford|Mustang Convertible I (facelift 1971)|7.0 Cobra Jet V8|czarny
12|Ford|Mustang Convertible I (facelift 1971)|5.8 V8|czarny
13|Ford|Mustang Convertible I (facelift 1971)|5.8 V8|bialy
14|Ford|Mustang Convertible I (facelift 1971)|5.8 V8|czerwony
\.

commit;

























