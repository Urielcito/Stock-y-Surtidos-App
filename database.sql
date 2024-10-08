-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: stockysurtidosapp
-- ------------------------------------------------------
-- Server version	8.4.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (21,'Crear nueva...'),(22,'Cualquiera'),(23,'Comida'),(24,'Producto de limpieza'),(25,'Postre'),(26,'Comida chatarra'),(27,'Condimento'),(28,'Congelado'),(29,'Alcohol'),(30,'Verdura'),(31,'Fruta'),(32,'Embutido'),(33,'Papeleria'),(34,'Bazar'),(35,'Higiene personal'),(36,'Mascotas'),(37,'Fiambreria'),(38,'Ferreteria'),(39,'Maquillaje'),(40,'Medicamento'),(41,'Tecnologia'),(42,'Aderezo'),(43,'Bebida'),(44,'SNACK'),(46,'Aromatizantes');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fuente`
--

DROP TABLE IF EXISTS `fuente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fuente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `aceptan_tarjeta` tinyint DEFAULT NULL,
  `telefono` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='		';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fuente`
--

LOCK TABLES `fuente` WRITE;
/*!40000 ALTER TABLE `fuente` DISABLE KEYS */;
INSERT INTO `fuente` VALUES (1,'Cualquiera',0,0),(2,'La pañalera',0,45227418),(4,'Ta-Ta',0,92953181),(5,'Micro Macro Tigre 1',1,45225084),(6,'Super USA',1,45228422),(7,'Polleria A Comer!',1,99599067),(8,'El Economico',1,45227298);
/*!40000 ALTER TABLE `fuente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_fuente` int DEFAULT NULL,
  `id_categoria` int DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `precio` decimal(10,0) DEFAULT NULL,
  `cuanto_tenemos` varchar(45) DEFAULT NULL,
  `importante` tinyint DEFAULT NULL,
  `nombre_imagen` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_fuente_idx` (`id_fuente`),
  KEY `id_categoria_idx` (`id_categoria`),
  CONSTRAINT `id_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `categoria` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `id_fuente` FOREIGN KEY (`id_fuente`) REFERENCES `fuente` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (34,2,24,'PERFUMOL CRISTAL 3 LTS',130,'BIEN',0,''),(35,2,24,'ROLLO COCINA MAXI 200 H',70,'BIEN',0,''),(36,2,24,'DENTRIFICO PERIODONT 90 G',290,'BIEN',0,''),(37,2,24,'AGUA LAVANDINA SELLO ROJO 2 LTS',120,'BIEN',0,''),(38,2,24,'JABON ASTRAL 125 G',40,'BIEN',0,''),(39,2,24,'BOLSAS RESIDUO NARANJA X 30',80,'BIEN',0,''),(40,2,35,'ENJUAGUE LISTERINE CUIDADO TOTAL 1 LTS',500,'BIEN',0,''),(41,2,24,'PAPEL HIGIENICO HIGIENOL 12 UN',280,'BIEN',0,''),(42,2,23,'DULCE MEMBRILLO 4 KG EL RETOÑO',355,'BIEN',0,''),(43,2,23,'PULPA DE TOMATE QUALITAS 1 KG',46,'BIEN',0,''),(44,2,23,'GRASA COLOLO 400 GR',37,'BIEN',0,''),(45,2,46,'VAINILLA MONTE CUDINE 120 ML',140,'BIEN',0,''),(46,2,27,'CALDOS MAGGI VERD 12 UN',48,'BIEN',0,''),(47,2,23,'QUESO MAGNOLIA FINO 200 GR',175,'BIEN',0,''),(48,2,23,'MAICENA REVELACION 1 KG',68,'BIEN',0,''),(49,2,23,'POLVO DE HORNEAR ROYAL 100 GR',60,'BIEN',0,''),(50,2,43,'TÉ HORNIMANS 50 UN',167,'BIEN',0,''),(51,2,23,'COCOA VASCOLET 1 KG',330,'BIEN',0,''),(52,2,23,'AZUCAR AZUCARLITO 2 KG',105,'BIEN',0,''),(53,2,23,'ACEITE URUGUAY 0,9 LITROS',75,'POCO',1,''),(54,2,23,'HARINA URUGUAY 0000 1 KG',38,'BIEN',0,''),(55,2,24,'PERFUMOL FABULOSO 2 LTS',157,'BIEN',0,''),(56,2,35,'ACONDICIONADOR FRUCTIS 350 ML',280,'BIEN',0,''),(57,2,27,'PIMENTON MONTE CUDINE 25 GR',32,'BIEN',0,'');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-10-08 18:30:00
