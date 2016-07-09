/*
SQLyog Community v12.2.1 (64 bit)
MySQL - 5.7.9 : Database - ferreteria
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`ferreteria` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_bin */;

USE `ferreteria`;

/*Table structure for table `administrador` */

DROP TABLE IF EXISTS `administrador`;

CREATE TABLE `administrador` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) COLLATE utf8_bin NOT NULL,
  `direccion` varchar(100) COLLATE utf8_bin NOT NULL,
  `contraseña` varchar(12) COLLATE utf8_bin NOT NULL,
  `fechaInserccion` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `administrador` */

insert  into `administrador`(`id`,`nombre`,`direccion`,`contraseña`,`fechaInserccion`) values 
(1,'Jesus Avit','Nuevo Amanecer','1234','2016-02-28');

/*Table structure for table `articulos` */

DROP TABLE IF EXISTS `articulos`;

CREATE TABLE `articulos` (
  `Codigo_A` int(11) NOT NULL,
  `Nombre` varchar(20) COLLATE utf8_bin NOT NULL,
  `Tipo` varchar(20) COLLATE utf8_bin NOT NULL,
  `Precio` decimal(10,0) NOT NULL,
  `Stock` int(11) DEFAULT '0',
  `Estado` varchar(12) COLLATE utf8_bin DEFAULT 'Activo',
  PRIMARY KEY (`Codigo_A`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `articulos` */

insert  into `articulos`(`Codigo_A`,`Nombre`,`Tipo`,`Precio`,`Stock`,`Estado`) values 
(1,'Jabon','Aseo','5',40,'Inactivo'),
(2,'Sal','Comida','10',10,'Activo'),
(3,'Escoba','Aseo','20',30,'Activo'),
(4,'Martillo','Herr','50',35,'Activo'),
(6,'Art','Herr','10',0,'Activo');

/*Table structure for table `clientes` */

DROP TABLE IF EXISTS `clientes`;

CREATE TABLE `clientes` (
  `Codigo_C` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_C` varchar(30) COLLATE utf8_bin NOT NULL,
  `Num_Tel` varchar(20) COLLATE utf8_bin NOT NULL,
  `estado` varchar(20) COLLATE utf8_bin NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`Codigo_C`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `clientes` */

insert  into `clientes`(`Codigo_C`,`Nombre_C`,`Num_Tel`,`estado`) values 
(1,'Alan','7551271524','Inactivo'),
(2,'Jose','7551271524','Inactivo'),
(3,'Julian','7551271524','Activo'),
(4,'Alan','1431413','Activo');

/*Table structure for table `compras` */

DROP TABLE IF EXISTS `compras`;

CREATE TABLE `compras` (
  `CC` int(11) NOT NULL AUTO_INCREMENT,
  `CProducto` int(11) NOT NULL,
  `Codigo_P` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Fecha_C` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`CC`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `compras` */

insert  into `compras`(`CC`,`CProducto`,`Codigo_P`,`Cantidad`,`Fecha_C`) values 
(1,1,123,10,'2016-02-28 10:53:50'),
(2,1,123,10,'2016-02-28 10:55:52'),
(3,1,123,20,'2016-02-28 15:52:43'),
(4,3,123,20,'2016-02-28 15:53:21'),
(5,4,123,30,'2016-02-28 15:55:33'),
(6,4,123,5,'2016-02-28 15:55:46');

/*Table structure for table `empleados` */

DROP TABLE IF EXISTS `empleados`;

CREATE TABLE `empleados` (
  `CC` int(3) NOT NULL,
  `Nombre` varchar(30) COLLATE utf8_bin NOT NULL,
  `Puesto` varchar(15) COLLATE utf8_bin NOT NULL,
  `Num_Tel` int(11) NOT NULL,
  `Direccion` varchar(50) COLLATE utf8_bin NOT NULL,
  `Contraseña` varchar(12) COLLATE utf8_bin NOT NULL,
  `Estado` varchar(20) COLLATE utf8_bin NOT NULL DEFAULT 'Activo',
  PRIMARY KEY (`CC`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `empleados` */

insert  into `empleados`(`CC`,`Nombre`,`Puesto`,`Num_Tel`,`Direccion`,`Contraseña`,`Estado`) values 
(1,'Jesus Avit','Administrador',11425,'Nuevo Amanecer','1234','Activo'),
(2,'Luis Alberto','Cajero',12345,'Su casa','9876543210','Inactivo'),
(21515,'Luis Alberto','Cajero',12345,'Su casa','9876543210','Activo'),
(123456,'Alan Hernandez ','Cajero',151436,'Su casa','HOLAMUNDO','Activo');

/*Table structure for table `proveedor` */

DROP TABLE IF EXISTS `proveedor`;

CREATE TABLE `proveedor` (
  `Codigo_P` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_P` varchar(30) COLLATE utf8_bin NOT NULL,
  `Num_Tel` varchar(20) COLLATE utf8_bin NOT NULL,
  `Direccion` varchar(50) COLLATE utf8_bin NOT NULL,
  `Estado` varchar(12) COLLATE utf8_bin DEFAULT 'Activo',
  PRIMARY KEY (`Codigo_P`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `proveedor` */

insert  into `proveedor`(`Codigo_P`,`Nombre_P`,`Num_Tel`,`Direccion`,`Estado`) values 
(1,'egfqwfge','154315','dsgw','Inactivo'),
(2,'Whre','14156','ghgwer','Inactivo');

/*Table structure for table `ventas` */

DROP TABLE IF EXISTS `ventas`;

CREATE TABLE `ventas` (
  `NV` int(11) NOT NULL AUTO_INCREMENT,
  `Codigo_C` int(11) DEFAULT NULL,
  `Codigo_P` int(11) DEFAULT NULL,
  `Fecha` datetime DEFAULT CURRENT_TIMESTAMP,
  `Subtotal` decimal(10,0) DEFAULT NULL,
  `IVA_C` decimal(10,0) DEFAULT NULL,
  `Total_C` decimal(10,0) DEFAULT NULL,
  `Estado` varchar(12) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`NV`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

/*Data for the table `ventas` */

insert  into `ventas`(`NV`,`Codigo_C`,`Codigo_P`,`Fecha`,`Subtotal`,`IVA_C`,`Total_C`,`Estado`) values 
(1,1,2,'2016-02-29 05:19:06','114','513','412','431');

/* Procedure structure for procedure `inhabilitarCliente` */

/*!50003 DROP PROCEDURE IF EXISTS  `inhabilitarCliente` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `inhabilitarCliente`(in _idCliente int)
BEGIN
update clientes set Estado='Inactivo' where Codigo_C=_idCliente;
END */$$
DELIMITER ;

/* Procedure structure for procedure `inhabilitarEmpleado` */

/*!50003 DROP PROCEDURE IF EXISTS  `inhabilitarEmpleado` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `inhabilitarEmpleado`(in _idEmpleado int)
BEGIN
update empleados set Estado='Inactivo' where CC=_idEmpleado;
END */$$
DELIMITER ;

/* Procedure structure for procedure `inhabilitarProducto` */

/*!50003 DROP PROCEDURE IF EXISTS  `inhabilitarProducto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `inhabilitarProducto`(in _idProducto int)
BEGIN
UPDATE articulos SET Estado='Inactivo' WHERE Codigo_A=_idProducto;
END */$$
DELIMITER ;

/* Procedure structure for procedure `inhabilitarProveedor` */

/*!50003 DROP PROCEDURE IF EXISTS  `inhabilitarProveedor` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `inhabilitarProveedor`(in codigoproveedor int)
BEGIN
update proveedor set Estado='Inactivo' where Codigo_P=codigoproveedor;
END */$$
DELIMITER ;

/* Procedure structure for procedure `ventaenProceso` */

/*!50003 DROP PROCEDURE IF EXISTS  `ventaenProceso` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `ventaenProceso`(in _codCliente int ,in _codProducto int)
BEGIN
insert into ventas
(
Codigo_C,
Codigo_P,
Estado
)
values
(
_codCliente,
_codProducto,
'En Proceso'
);
    END */$$
DELIMITER ;

/* Procedure structure for procedure `ventaFinalizada` */

/*!50003 DROP PROCEDURE IF EXISTS  `ventaFinalizada` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `ventaFinalizada`(in _idClie int,in _idProd int,in _subtotal decimal,in _IVA decimal,in _total decimal)
BEGIN
insert into ventas
(
Codigo_C,
Codigo_P,
Subtotal,
IVA_C,
Total_C,
Estado
)
values
(
_idClie,
_idProd,
_subtotal,
_IVA,
_total,
'Finalizada'
);
    END */$$
DELIMITER ;

/*Table structure for table `verarticulos` */

DROP TABLE IF EXISTS `verarticulos`;

/*!50001 DROP VIEW IF EXISTS `verarticulos` */;
/*!50001 DROP TABLE IF EXISTS `verarticulos` */;

/*!50001 CREATE TABLE  `verarticulos`(
 `Codigo_A` int(11) ,
 `Nombre` varchar(20) ,
 `Tipo` varchar(20) ,
 `Precio` decimal(10,0) ,
 `Stock` int(11) 
)*/;

/*Table structure for table `verclientes` */

DROP TABLE IF EXISTS `verclientes`;

/*!50001 DROP VIEW IF EXISTS `verclientes` */;
/*!50001 DROP TABLE IF EXISTS `verclientes` */;

/*!50001 CREATE TABLE  `verclientes`(
 `Codigo_C` int(11) ,
 `Nombre_C` varchar(30) ,
 `Num_Tel` varchar(20) ,
 `estado` varchar(20) 
)*/;

/*Table structure for table `verempleados` */

DROP TABLE IF EXISTS `verempleados`;

/*!50001 DROP VIEW IF EXISTS `verempleados` */;
/*!50001 DROP TABLE IF EXISTS `verempleados` */;

/*!50001 CREATE TABLE  `verempleados`(
 `Codigo del Empleado` int(3) ,
 `Nombre` varchar(30) ,
 `Puesto` varchar(15) ,
 `Numero de Telefono` int(11) ,
 `Direccion` varchar(50) 
)*/;

/*Table structure for table `verproveedores` */

DROP TABLE IF EXISTS `verproveedores`;

/*!50001 DROP VIEW IF EXISTS `verproveedores` */;
/*!50001 DROP TABLE IF EXISTS `verproveedores` */;

/*!50001 CREATE TABLE  `verproveedores`(
 `Codigo_P` int(11) ,
 `Nombre_P` varchar(30) ,
 `Num_Tel` varchar(20) ,
 `Direccion` varchar(50) 
)*/;

/*Table structure for table `verventas` */

DROP TABLE IF EXISTS `verventas`;

/*!50001 DROP VIEW IF EXISTS `verventas` */;
/*!50001 DROP TABLE IF EXISTS `verventas` */;

/*!50001 CREATE TABLE  `verventas`(
 `NV` int(11) ,
 `Codigo_C` int(11) ,
 `Codigo_P` int(11) ,
 `Fecha` datetime ,
 `Subtotal` decimal(10,0) ,
 `IVA_C` decimal(10,0) ,
 `Total_C` decimal(10,0) ,
 `Estado` varchar(12) 
)*/;

/*View structure for view verarticulos */

/*!50001 DROP TABLE IF EXISTS `verarticulos` */;
/*!50001 DROP VIEW IF EXISTS `verarticulos` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `verarticulos` AS (select `articulos`.`Codigo_A` AS `Codigo_A`,`articulos`.`Nombre` AS `Nombre`,`articulos`.`Tipo` AS `Tipo`,`articulos`.`Precio` AS `Precio`,`articulos`.`Stock` AS `Stock` from `articulos`) */;

/*View structure for view verclientes */

/*!50001 DROP TABLE IF EXISTS `verclientes` */;
/*!50001 DROP VIEW IF EXISTS `verclientes` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `verclientes` AS (select `clientes`.`Codigo_C` AS `Codigo_C`,`clientes`.`Nombre_C` AS `Nombre_C`,`clientes`.`Num_Tel` AS `Num_Tel`,`clientes`.`estado` AS `estado` from `clientes`) */;

/*View structure for view verempleados */

/*!50001 DROP TABLE IF EXISTS `verempleados` */;
/*!50001 DROP VIEW IF EXISTS `verempleados` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `verempleados` AS (select `empleados`.`CC` AS `Codigo del Empleado`,`empleados`.`Nombre` AS `Nombre`,`empleados`.`Puesto` AS `Puesto`,`empleados`.`Num_Tel` AS `Numero de Telefono`,`empleados`.`Direccion` AS `Direccion` from `empleados`) */;

/*View structure for view verproveedores */

/*!50001 DROP TABLE IF EXISTS `verproveedores` */;
/*!50001 DROP VIEW IF EXISTS `verproveedores` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `verproveedores` AS (select `proveedor`.`Codigo_P` AS `Codigo_P`,`proveedor`.`Nombre_P` AS `Nombre_P`,`proveedor`.`Num_Tel` AS `Num_Tel`,`proveedor`.`Direccion` AS `Direccion` from `proveedor`) */;

/*View structure for view verventas */

/*!50001 DROP TABLE IF EXISTS `verventas` */;
/*!50001 DROP VIEW IF EXISTS `verventas` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `verventas` AS (select `ventas`.`NV` AS `NV`,`ventas`.`Codigo_C` AS `Codigo_C`,`ventas`.`Codigo_P` AS `Codigo_P`,`ventas`.`Fecha` AS `Fecha`,`ventas`.`Subtotal` AS `Subtotal`,`ventas`.`IVA_C` AS `IVA_C`,`ventas`.`Total_C` AS `Total_C`,`ventas`.`Estado` AS `Estado` from `ventas`) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
