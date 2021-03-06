-- MySQL Script generated by MySQL Workbench
-- Mon Jun  1 11:57:52 2020
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering
-- -----------------------------------------------------
-- Table `UserGroups`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `UserGroups` ;

CREATE TABLE IF NOT EXISTS `UserGroups` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `Name_UNIQUE` (`Name` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `StudentGroups`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `StudentGroups` ;

CREATE TABLE IF NOT EXISTS `StudentGroups` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `Name_UNIQUE` (`Name` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Users` ;

CREATE TABLE IF NOT EXISTS `Users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL,
  `Surname` VARCHAR(50) NOT NULL,
  `Login` VARCHAR(50) NOT NULL,
  `Password` VARCHAR(256) NOT NULL,
  `UserGroup` INT NOT NULL,
  `StudentGroup` INT NULL,
  PRIMARY KEY (`id`),
  INDEX `UsersUserGroups_idx` (`UserGroup` ASC) VISIBLE,
  INDEX `UsersStudentGroup_idx` (`StudentGroup` ASC) VISIBLE,
  CONSTRAINT `UsersUserGroups`
    FOREIGN KEY (`UserGroup`)
    REFERENCES `UserGroups` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `UsersStudentGroup`
    FOREIGN KEY (`StudentGroup`)
    REFERENCES `StudentGroups` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Subjects`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Subjects` ;

CREATE TABLE IF NOT EXISTS `Subjects` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `Name_UNIQUE` (`Name` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Tests`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Tests` ;

CREATE TABLE IF NOT EXISTS `Tests` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(100) NOT NULL,
  `Creator` INT NOT NULL,
  `EditDate` DATETIME NOT NULL,
  `Subject` INT NOT NULL,
  `PassAvailable` TINYINT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `Name_UNIQUE` (`Name` ASC) VISIBLE,
  INDEX `TestsCreator_idx` (`Creator` ASC) VISIBLE,
  INDEX `TestsSubject_idx` (`Subject` ASC) VISIBLE,
  CONSTRAINT `TestsCreator`
    FOREIGN KEY (`Creator`)
    REFERENCES `Users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `TestsSubject`
    FOREIGN KEY (`Subject`)
    REFERENCES `Subjects` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `TestResults`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `TestResults` ;

CREATE TABLE IF NOT EXISTS `TestResults` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Test` INT NOT NULL,
  `Student` INT NOT NULL,
  `Mark` INT NOT NULL,
  `PassingTime` TIME NOT NULL,
  `Date` DATE NOT NULL,
  `Result` BLOB NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `TestResultsTest_idx` (`Test` ASC) VISIBLE,
  INDEX `TestResultsUser_idx` (`Student` ASC) VISIBLE,
  CONSTRAINT `TestResultsTest`
    FOREIGN KEY (`Test`)
    REFERENCES `Tests` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `TestResultsUser`
    FOREIGN KEY (`Student`)
    REFERENCES `Users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;