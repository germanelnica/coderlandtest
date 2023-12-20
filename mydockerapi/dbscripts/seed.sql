\connect blogdb

CREATE TABLE cardbrand
(
 id serial PRIMARY KEY,
 name VARCHAR (250) NOT NULL,
 description VARCHAR (250) NULL
);
ALTER TABLE "cardbrand" OWNER TO germannunez;

Insert into cardbrand(name,description) values( 'Toyota','The largest automobile manufacturer in the world');
Insert into cardbrand(name,description) values( 'Lexus', 'Luxury vehicle division of the Japanese automaker Toyota Motor Corporation');
Insert into cardbrand(name,description) values( 'Subaru','Premium reliable vehicles, with excellent safety features and impressive technology');
Insert into cardbrand(name,description) values( 'Hyndai','The Korean domestic market and exports vehicles to 190 countries worldwide');
