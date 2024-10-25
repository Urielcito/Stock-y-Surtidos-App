-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: stockysurtidosapp
-- ------------------------------------------------------
-- Server version	8.3.0

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
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (21,'Crear nueva...'),(22,'Cualquiera'),(23,'Comida'),(24,'Producto de limpieza'),(25,'Postre'),(26,'Comida chatarra'),(27,'Condimento'),(28,'Congelado'),(29,'Alcohol'),(30,'Verdura'),(31,'Fruta'),(32,'Embutido'),(33,'Papeleria'),(34,'Bazar'),(35,'Higiene personal'),(36,'Mascotas'),(37,'Fiambreria'),(38,'Ferreteria'),(39,'Maquillaje'),(40,'Medicamento'),(41,'Tecnologia'),(42,'Aderezo'),(43,'Bebida'),(44,'SNACK'),(46,'Aromatizantes'),(47,'Panaderia');
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
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='		';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fuente`
--

LOCK TABLES `fuente` WRITE;
/*!40000 ALTER TABLE `fuente` DISABLE KEYS */;
INSERT INTO `fuente` VALUES (1,'Cualquiera',0,0),(2,'La pañalera',0,45227418),(4,'Ta-Ta',0,92953181),(5,'Micro Macro Tigre 1',1,45225084),(6,'Super USA',1,45228422),(7,'Polleria A Comer!',1,99599067),(8,'El Economico',1,45227298),(9,'FarmaShop',1,28484848),(10,'Precios mas bajo',0,45222745),(11,'BON GOUT CARNICERIA',1,45222553);
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
) ENGINE=InnoDB AUTO_INCREMENT=134 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (34,2,24,'PERFUMOL CRISTAL 3 LTS',130,'BIEN',0,''),(35,2,24,'ROLLO COCINA MAXI 200 H',70,'BIEN',0,''),(36,2,24,'DENTRIFICO PERIODONT 90 G',282,'BIEN',0,''),(37,2,24,'AGUA LAVANDINA SELLO ROJO 2 LTS',120,'BIEN',0,''),(38,2,24,'JABON ASTRAL 125 G',40,'BIEN',0,''),(39,2,24,'BOLSAS RESIDUO NARANJA X 30',80,'BIEN',0,''),(40,2,35,'ENJUAGUE LISTERINE CUIDADO TOTAL 1 LTS',500,'BIEN',0,''),(41,2,24,'PAPEL HIGIENICO HIGIENOL 12 UN',325,'BIEN',0,''),(42,2,23,'DULCE MEMBRILLO 4 KG EL RETOÑO',355,'BIEN',0,''),(43,2,23,'PULPA DE TOMATE QUALITAS 1 KG',46,'BIEN',0,''),(44,2,23,'GRASA COLOLO 400 GR',37,'BIEN',0,''),(45,2,46,'VAINILLA MONTE CUDINE 120 ML',140,'BIEN',0,''),(46,2,27,'CALDOS MAGGI VERD 12 UN',35,'BIEN',0,''),(47,2,23,'QUESO MAGNOLIA FINO 200 GR',175,'BIEN',0,''),(48,2,23,'MAICENA REVELACION 1 KG',72,'BIEN',0,''),(49,2,23,'POLVO DE HORNEAR ROYAL 100 GR',60,'BIEN',0,''),(50,2,43,'TÉ HORNIMANS 50 UN',167,'BIEN',0,''),(51,2,23,'COCOA VASCOLET 1 KG',365,'BIEN',0,''),(52,2,23,'AZUCAR AZUCARLITO 2 KG',105,'BIEN',0,''),(53,2,23,'ACEITE URUGUAY 0,9 LITROS',75,'BIEN',1,''),(54,2,23,'HARINA URUGUAY 0000 1 KG',38,'BIEN',0,''),(55,2,24,'PERFUMOL FABULOSO 2 LTS',157,'BIEN',0,''),(56,2,35,'ACONDICIONADOR FRUCTIS 350 ML',280,'BIEN',0,''),(57,2,27,'PIMENTON MONTE CUDINE 25 GR',32,'BIEN',0,''),(66,2,35,'CEPILLO DE DIENTES MEDIO COLGATE X2',77,'BIEN',0,''),(67,2,35,'DESODORANTE SKALA 60 ML',60,'BIEN',0,''),(68,2,24,'ESPONJA JASPE 6 UN',170,'BIEN',0,''),(69,2,35,'JABON LIQUIDO MANOS FARNESSE 1 LT',90,'BIEN',0,''),(70,2,24,'AGUA LAVANDINA CRISTAL 2 LT',100,'BIEN',0,''),(71,2,24,'JABON BARRA ROPA GIGANTE 200 GR',34,'BIEN',0,''),(72,2,35,'TOALLITAS KOTEX 32 UN',255,'BIEN',0,''),(73,2,35,'ACONDICIONADOR SEDAL 650 ML',240,'BIEN',0,''),(74,2,35,'ALGODON NUBE 140 GR',105,'BIEN',0,''),(75,2,35,'ALGODON NUBE 300 GR',205,'BIEN',0,''),(76,2,24,'SUAVIZANTE GIRANDO SOL 5 LT',225,'BIEN',0,''),(77,2,25,'DULCE DE LECHE PTO SUACE 900 GR',120,'BIEN',0,''),(78,2,23,'SAL SEK FINA 500 GR',35,'BIEN',0,''),(79,2,23,'SAL SEK GRUESA 500 GR',35,'BIEN',0,''),(80,2,23,'CAFE MONTESOL 1 KG',715,'BIEN',0,''),(81,2,26,'ALFAJOR 3 DESEOS',37,'BIEN',0,''),(82,2,26,'ALFAJOR PEPITOS',45,'BIEN',0,''),(83,2,26,'ALFAJOR COFLER MOUSSE',25,'BIEN',0,''),(84,2,35,'GILLETTE 1 UN',50,'BIEN',0,''),(85,2,32,'ATUN BLUE MAR ACEIT 170 GR',52,'BIEN',0,''),(86,2,26,'CHOCOLATADA LACTOLATE 1 LT',70,'BIEN',0,''),(87,2,35,'DESODORANTE REXONA 250 ML',205,'BIEN',0,''),(88,2,32,'PATE ODERICH 100 GR',36,'BIEN',0,''),(89,2,24,'PAPEL HIGIENICO HIGIENOL VERDE 12 UN',150,'BIEN',0,''),(90,2,42,'MAYONESA MANLEY 500 CC',90,'BIEN',0,''),(91,2,42,'KETCHUP PONTEVEDRA 2OO ML',60,'BIEN',0,''),(92,2,42,'MOSTAZA MONTEVEDRA 200 ML',60,'BIEN',0,''),(93,2,23,'COCOA MONTESOL 500 GR',185,'BIEN',0,''),(94,8,28,'BONDIOLA 1 KG',220,'BIEN',0,''),(95,8,28,'SUPREMA DE POLLO 1 KG',350,'BIEN',0,''),(96,8,28,'RAVIOLES BATUK 750 GR',125,'BIEN',0,''),(97,8,37,'QUESO LOVER 100 GR',48,'BIEN',0,''),(99,9,39,'NEUTROGENA CREMA HIDRATANTE',885,'BIEN',0,''),(100,9,40,'JERINGA DESCARTABLE 5',22,'BIEN',0,''),(101,9,40,'SUERO FISIOLOGICO 0.9',168,'BIEN',0,''),(102,10,44,'PAPAS PAY 500 GR',260,'BIEN',0,''),(103,10,28,'PANCHOS FENIX 1 KG',250,'BIEN',0,''),(104,8,47,'PAN PANCHOS X4 CORTOS',56,'BIEN',0,''),(105,2,23,'ARROZ GREEN CHEF 1 KG',56,'BIEN',0,''),(106,9,40,'FLODIGRIP DESCONGESTIVO 10 UN',353,'BIEN',0,''),(107,9,39,'BALSAMO VOGUE FRESAS',209,'BIEN',0,''),(108,9,39,'DELINEADOR VOGUE ESSEN (P.ANTO)',159,'BIEN',0,''),(110,9,39,'LABIAL VOGUE ROJO MATE BAILA',525,'BIEN',0,''),(111,9,39,'MASCARA DE PESTAÑAS VOGUE EFECTO CURVO',363,'BIEN',0,''),(113,9,39,'DELINEADOR VOGUE RESIST A PRUEBA DE AGUA',445,'BIEN',0,''),(114,2,24,'JABON NEVEX MATIC 5 KG',590,'BIEN',0,''),(115,2,24,'RAID MOSCAS 360 CC',275,'BIEN',0,''),(116,2,35,'TOALLITAS CAREFREE 150 UN',415,'BIEN',0,''),(117,2,23,'POLVO DE HORNEAR ROYAL 200 GR',105,'BIEN',0,''),(118,2,44,'GALLETAS FORTALEZA CRACKER 400 GR',48,'BIEN',0,''),(119,2,23,'ADRIA CABELLO ANGEL 500 GR',75,'BIEN',0,''),(120,2,35,'TOALLAS CHERITO 2X150 UN',155,'BIEN',0,''),(121,2,23,'PAN LACTAL SORCHANTE 480 GR',105,'BIEN',0,''),(122,2,23,'HUEVOS SARANDI 15 UN',120,'BIEN',0,''),(123,2,35,'TALCO XANAPIE SPECIAL 180 GR',95,'BIEN',0,''),(124,11,28,'BONDIOLA 1 KG',214,'BIEN',0,''),(125,11,28,'MILANESA DE POLLO 1 KG',340,'BIEN',0,''),(126,2,43,'FAGAR COLA 2 LT 6 UN',470,'BIEN',0,''),(127,2,35,'COTONETES JOHNSONS 150 UN',140,'BIEN',0,''),(128,2,23,'POLENTA PRESTO PRONTA 500 GR',45,'BIEN',0,''),(129,2,42,'MOSTAZA ODERICH 1 KG',95,'BIEN',0,''),(130,2,23,'LENTEJAS REVELACION 1 KG',170,'BIEN',0,''),(131,2,28,'HAMBURGUESAS SCHNECK CLASICA',73,'BIEN',0,''),(132,2,28,'HAMBURGUESAS SCHNECK CHORI',68,'BIEN',0,''),(133,2,42,'MAYONESA URUGUAY 1000 CC',126,'BIEN',0,'');
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

-- Dump completed on 2024-10-12  0:35:21
