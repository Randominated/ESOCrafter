-- Created by Vertabelo (http://vertabelo.com)
-- Script type: create
-- Scope: [tables, references, sequences, views, procedures]
-- Generated at Mon Mar 02 19:02:36 UTC 2015



-- tables
-- Table: characters
CREATE TABLE characters (
    char_id integer NOT NULL  PRIMARY KEY AUTOINCREMENT,
    char_type integer NOT NULL,
    char_name varchar(255) NOT NULL,
    inventory_size integer NOT NULL,
    isMule boolean NOT NULL,
    isBank boolean NOT NULL
);

-- Table: equips
CREATE TABLE equips (
    equip_id integer NOT NULL  PRIMARY KEY AUTOINCREMENT,
    type varchar(255) NOT NULL,
    attribute_val integer NOT NULL,
    item_level integer NOT NULL,
    coin_val integer NOT NULL,
    ench_type varchar(255) NOT NULL,
    ench_val integer NOT NULL,
    trait_type varchar(255) NOT NULL,
    trait_val integer NOT NULL,
    characters_char_id integer NOT NULL,
    FOREIGN KEY (characters_char_id) REFERENCES characters (char_id)
);

-- Table: researches
CREATE TABLE researches (
    res_id integer NOT NULL  PRIMARY KEY AUTOINCREMENT,
    trait varchar(255) NOT NULL,
    bench_type integer NOT NULL,
    time_start datetime NOT NULL,
    time_end datetime NOT NULL,
    init_equip_id integer NOT NULL,
    characters_char_id integer NOT NULL,
    FOREIGN KEY (characters_char_id) REFERENCES characters (char_id)
);


-- views
-- View: v_char_inventory

CREATE VIEW v_char_inventory AS
SELECT * FROM equips;




-- End of file.

