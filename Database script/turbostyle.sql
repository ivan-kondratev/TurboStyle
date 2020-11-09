-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
-- -----------------------------------------------------
-- Schema turbostyle
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `turbostyle` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `turbostyle` ;

-- -----------------------------------------------------
-- Table `turbostyle`.`statuses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turbostyle`.`statuses` (
  `statusID` INT(11) NOT NULL,
  `statusName` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`statusID`),
  UNIQUE INDEX `statusID_UNIQUE` (`statusID` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `turbostyle`.`requests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turbostyle`.`requests` (
  `requestID` INT(11) NOT NULL AUTO_INCREMENT,
  `statusID` INT(11) NOT NULL,
  `CarMark` VARCHAR(30) NOT NULL,
  `CarModel` VARCHAR(30) NOT NULL,
  `CarVIN` VARCHAR(30) NOT NULL,
  `LastName` VARCHAR(30) NOT NULL,
  `FirstName` VARCHAR(30) NOT NULL,
  `Patronymic` VARCHAR(30) NULL DEFAULT NULL,
  `PhoneNumber` VARCHAR(14) NOT NULL,
  PRIMARY KEY (`requestID`),
  UNIQUE INDEX `requestID_UNIQUE` (`requestID` ASC) VISIBLE,
  INDEX `status_fk_idx` (`statusID` ASC) VISIBLE,
  CONSTRAINT `req_st`
    FOREIGN KEY (`statusID`)
    REFERENCES `turbostyle`.`statuses` (`statusID`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `turbostyle`.`inspections`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turbostyle`.`inspections` (
  `resultID` INT(11) NOT NULL AUTO_INCREMENT,
  `result` VARCHAR(1000) NOT NULL,
  `requestID` INT(11) NOT NULL,
  `decision` TINYINT(1) NOT NULL,
  PRIMARY KEY (`resultID`),
  UNIQUE INDEX `resultID_UNIQUE` (`resultID` ASC) VISIBLE,
  INDEX `ins_req_idx` (`requestID` ASC) VISIBLE,
  CONSTRAINT `ins_req`
    FOREIGN KEY (`requestID`)
    REFERENCES `turbostyle`.`requests` (`requestID`))
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `turbostyle`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turbostyle`.`users` (
  `userID` INT(11) NOT NULL AUTO_INCREMENT,
  `userLogin` VARCHAR(16) NOT NULL,
  `userPassword` VARCHAR(32) NOT NULL,
  `userType` CHAR(1) NOT NULL,
  PRIMARY KEY (`userID`),
  UNIQUE INDEX `userID_UNIQUE` (`userID` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
