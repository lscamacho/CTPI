-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema webapp
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema webapp
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `webapp` DEFAULT CHARACTER SET utf8 ;
USE `webapp` ;

-- -----------------------------------------------------
-- Table `webapp`.`FUNCIONARIO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `webapp`.`FUNCIONARIO` (
  `MATRICULA` INT NOT NULL,
  `NOME` VARCHAR(45) NOT NULL,
  `CARGO` VARCHAR(45) NULL,
  `ENDERECO` VARCHAR(45) NULL,
  `TELEFONE` VARCHAR(45) NULL,
  PRIMARY KEY (`MATRICULA`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `webapp`.`CLIENTE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `webapp`.`CLIENTE` (
  `CPF` INT NOT NULL,
  `NOME` VARCHAR(45) NOT NULL,
  `LONGRADOURO` VARCHAR(45) NULL,
  `DATA_NASCIMENTO` DATE NULL,
  `SEXO` VARCHAR(45) NULL,
  `ESTADO_CIVIL` VARCHAR(45) NULL,
  `TELEFONE` VARCHAR(45) NULL,
  `RENDA_MENSAL` DECIMAL(18,2) NULL,
  `ESTADO` VARCHAR(2) NULL,
  `CIDADE` VARCHAR(45) NULL,
  `CEP` VARCHAR(45) NULL,
  PRIMARY KEY (`CPF`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `webapp`.`PRODUTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `webapp`.`PRODUTO` (
  `ID_PRODUTO` INT NOT NULL,
  `DESCRICAO` VARCHAR(45) NULL,
  `TIPO` VARCHAR(45) NULL,
  `PRECO` DECIMAL(18,2) NULL,
  PRIMARY KEY (`ID_PRODUTO`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `webapp`.`VENDA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `webapp`.`VENDA` (
  `ID_VENDA` INT NOT NULL,
  `DATA` DATE NULL,
  `VALOR` DECIMAL(18,2) NULL,
  `FUNCIONARIO_MATRICULA` INT NOT NULL,
  `CLIENTE_CPF` INT NOT NULL,
  `PRODUTO_ID_PRODUTO` INT NOT NULL,
  PRIMARY KEY (`ID_VENDA`),
  INDEX `fk_VENDA_FUNCIONARIO_idx` (`FUNCIONARIO_MATRICULA` ASC) VISIBLE,
  INDEX `fk_VENDA_CLIENTE1_idx` (`CLIENTE_CPF` ASC) VISIBLE,
  INDEX `fk_VENDA_PRODUTO1_idx` (`PRODUTO_ID_PRODUTO` ASC) VISIBLE,
  CONSTRAINT `fk_VENDA_FUNCIONARIO`
    FOREIGN KEY (`FUNCIONARIO_MATRICULA`)
    REFERENCES `webapp`.`FUNCIONARIO` (`MATRICULA`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_VENDA_CLIENTE1`
    FOREIGN KEY (`CLIENTE_CPF`)
    REFERENCES `webapp`.`CLIENTE` (`CPF`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_VENDA_PRODUTO1`
    FOREIGN KEY (`PRODUTO_ID_PRODUTO`)
    REFERENCES `webapp`.`PRODUTO` (`ID_PRODUTO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `webapp`.`PAGAMENTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `webapp`.`PAGAMENTO` (
  `ID_PAGAMENTO` INT NOT NULL,
  `TIPO_PAGAMENTO` VARCHAR(45) NULL,
  `VENDA_ID_VENDA` INT NOT NULL,
  PRIMARY KEY (`ID_PAGAMENTO`),
  INDEX `fk_PAGAMENTO_VENDA1_idx` (`VENDA_ID_VENDA` ASC) VISIBLE,
  CONSTRAINT `fk_PAGAMENTO_VENDA1`
    FOREIGN KEY (`VENDA_ID_VENDA`)
    REFERENCES `webapp`.`VENDA` (`ID_VENDA`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `webapp`.`VENDA_has_PRODUTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `webapp`.`VENDA_has_PRODUTO` (
  `VENDA_ID_VENDA` INT NOT NULL,
  `PRODUTO_ID_PRODUTO` INT NOT NULL,
  PRIMARY KEY (`VENDA_ID_VENDA`, `PRODUTO_ID_PRODUTO`),
  INDEX `fk_VENDA_has_PRODUTO_PRODUTO1_idx` (`PRODUTO_ID_PRODUTO` ASC) VISIBLE,
  INDEX `fk_VENDA_has_PRODUTO_VENDA1_idx` (`VENDA_ID_VENDA` ASC) VISIBLE,
  CONSTRAINT `fk_VENDA_has_PRODUTO_VENDA1`
    FOREIGN KEY (`VENDA_ID_VENDA`)
    REFERENCES `webapp`.`VENDA` (`ID_VENDA`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_VENDA_has_PRODUTO_PRODUTO1`
    FOREIGN KEY (`PRODUTO_ID_PRODUTO`)
    REFERENCES `webapp`.`PRODUTO` (`ID_PRODUTO`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
