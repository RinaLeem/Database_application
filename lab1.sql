-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
-- -----------------------------------------------------

USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Brand`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Brand` (
  `brand_id` INT NOT NULL AUTO_INCREMENT,
  `brand_name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`brand_id`),
  UNIQUE INDEX `brand_id_UNIQUE` (`brand_id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Product`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Product` (
  `product_id` INT NOT NULL AUTO_INCREMENT,
  `product_name` VARCHAR(45) NOT NULL,
  `product_count` INT NOT NULL,
  `product_price` VARCHAR(45) NOT NULL,
  `product_brand_id` INT NOT NULL,
  PRIMARY KEY (`product_id`),
  INDEX `fk_Product_Brand_idx` (`product_brand_id` ASC) VISIBLE,
  UNIQUE INDEX `product_id_UNIQUE` (`product_id` ASC) VISIBLE,
  CONSTRAINT `fk_Product_Brand`
    FOREIGN KEY (`product_brand_id`)
    REFERENCES `mydb`.`Brand` (`brand_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Company`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Company` (
  `company_id` INT NOT NULL AUTO_INCREMENT,
  `company_name` VARCHAR(45) NOT NULL,
  `company_address` VARCHAR(45) NULL,
  `company_phone` VARCHAR(45) NULL,
  PRIMARY KEY (`company_id`),
  UNIQUE INDEX `company_id_UNIQUE` (`company_id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Order`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Orders` (
  `order_id` INT NOT NULL AUTO_INCREMENT,
  `order_count` INT NOT NULL,
  `order_date` DATE NOT NULL,
  `order_deadline` DATE NULL,
  `ordert_product_id` INT NOT NULL,
  `order_company_id` INT NOT NULL,
  PRIMARY KEY (`order_id`),
  INDEX `fk_Order_Product1_idx` (`ordert_product_id` ASC) VISIBLE,
  INDEX `fk_Order_Company1_idx` (`order_company_id` ASC) VISIBLE,
  UNIQUE INDEX `order_id_UNIQUE` (`order_id` ASC) VISIBLE,
  CONSTRAINT `fk_Order_Product1`
    FOREIGN KEY (`ordert_product_id`)
    REFERENCES `mydb`.`Product` (`product_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Order_Company1`
    FOREIGN KEY (`order_company_id`)
    REFERENCES `mydb`.`Company` (`company_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Delivery`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Delivery` (
  `delivery_id` INT NOT NULL AUTO_INCREMENT,
  `delivery_date` DATE NOT NULL,
  `delivery_count` INT NOT NULL,
  `delivery_order_id` INT NOT NULL,
  PRIMARY KEY (`delivery_id`),
  INDEX `fk_Delivery_Order1_idx` (`delivery_order_id` ASC) VISIBLE,
  UNIQUE INDEX `delivery_id_UNIQUE` (`delivery_id` ASC) VISIBLE,
  CONSTRAINT `fk_Delivery_Order1`
    FOREIGN KEY (`delivery_order_id`)
    REFERENCES `mydb`.`Orders` (`order_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

insert into Brand (brand_name) values
('Cosmostars'), ('Афродита'), ('Miel pops'), ('Чиста Лилия'),
('Dolce milk'), ('Хозяюшка'), ('Домашкино'), ('Бабушка Агафья'),
('Viktoria'), ('Ekaterina');

insert into Product (product_name, product_count, product_price, product_brand_id) values
('хоз. мыло',110,15,3), ('подводка чёрная',	4,400,3), ('подводка розовая',19,415,4),
('помада',20,250,3), ('палетка теней',14,1000,1), ('тушь',32,400,1),
('гель-фиксатор',2,	189,1), ('тинт',10,	500,2), ('румяна',20,150,2),
('хайлайтер хай',41,600,2);

insert into Company (company_name, company_address, company_phone) values
('Ашан', 'Дыбенко 24','9090909'),  ('Магнит Косметик','Минская 25','2020202'),
('Золотое яблоко','Нагорная 10','3030303'), ('Дэттуаль','Дыбенко 30','4040404'),
('Рив гош',	'Московская 34','1010101'), ('Маленькая принцесса', 'Арбат 3', '9001000'),
('Подружка','Новая 4',	'5050505'), ('Кореянка','Старая 1','6060606'),
('Белорусская косметика','Узкая 45','7070707'), ('Канада','Чичикова 49','8080808');

insert into Orders (order_count, order_date, order_deadline, ordert_product_id, order_company_id) values
(30, '2021-09-29', '2021-11-29', 1, 4), (15, '2021-09-27', '2021-11-19', 1, 4),
(5, '2022-09-24', '2022-11-28', 1, 3), (6, '2021-08-29', '2021-09-29', 4, 3),
(1, '2022-08-29', '2022-09-29', 4, 2), (1, '2021-08-25', '2021-08-29', 3, 2),
(1, '2022-03-02', '2022-04-02', 2, 1), (1, '2021-03-01', '2021-04-02', 2, 1),
(6, '2022-03-16', '2022-04-02', 3, 4), (2, '2020-07-02', '2020-09-01', 3, 2),
(3, '2020-07-02', '2020-09-01', 5, 2),(2, '2020-07-02', '2020-09-01', 5, 3);

insert into Delivery (delivery_date, delivery_count, delivery_order_id) values
('2021-10-23', 20, 1), ('2021-10-04', 15, 2), ('2022-10-03', 5, 3),
('2021-09-04', 5, 4), ('2022-09-08', 6, 5), ('2021-10-23', 2, 6),
('2022-10-11', 1, 7), ('2021-10-15', 1, 8), ('2022-10-11', 1, 9),
('2020-10-12',2, 10), ('2020-10-12', 3, 11), ('2020-10-12', 2, 12);

select * from Orders;