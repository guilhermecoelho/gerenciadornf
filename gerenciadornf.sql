-- phpMyAdmin SQL Dump
-- version 3.5.2
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tempo de Geração: 
-- Versão do Servidor: 5.5.8
-- Versão do PHP: 5.4.4

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Banco de Dados: `gerenciadornf`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `IDCliente` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(255) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  `TIPO` varchar(255) DEFAULT NULL,
  `NOMEFANTASIA` varchar(255) DEFAULT NULL,
  `endereco` varchar(255) DEFAULT NULL,
  `CEP` varchar(255) DEFAULT NULL,
  `LOGRADURA` varchar(255) DEFAULT NULL,
  `NUMERO` varchar(255) DEFAULT NULL,
  `COMPLEMENTO` varchar(255) DEFAULT NULL,
  `UF` varchar(255) DEFAULT NULL,
  `CIDADE` varchar(255) DEFAULT NULL,
  `TELEFONE` varchar(255) DEFAULT NULL,
  `CNPJ` varchar(255) DEFAULT NULL,
  `CPF` varchar(255) DEFAULT NULL,
  `INSCRICAOESTADUAL` varchar(255) DEFAULT NULL,
  `INSCRICAOMUNICIPAL` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDCliente`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Extraindo dados da tabela `cliente`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `emitente`
--

CREATE TABLE IF NOT EXISTS `emitente` (
  `IDEMITENTE` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(255) DEFAULT NULL,
  `NOMEFANTASIA` varchar(255) DEFAULT NULL,
  `CEP` varchar(255) DEFAULT NULL,
  `LOGRADURA` varchar(255) DEFAULT NULL,
  `NUMERO` varchar(255) DEFAULT NULL,
  `COMPLEMENTO` varchar(255) DEFAULT NULL,
  `UF` varchar(255) DEFAULT NULL,
  `CIDADE` varchar(255) DEFAULT NULL,
  `TELEFONE` varchar(255) DEFAULT NULL,
  `CNPJ` varchar(255) DEFAULT NULL,
  `INSCRICAOESTADUAL` varchar(255) DEFAULT NULL,
  `CERTDIGITAL` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDEMITENTE`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `emitente`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `formapagamento`
--

CREATE TABLE IF NOT EXISTS `formapagamento` (
  `IDFORMAPAGAMENTO` int(11) NOT NULL AUTO_INCREMENT,
  `DESCRICAO` varchar(255) DEFAULT NULL,
  `QTDPARCELA` int(11) DEFAULT NULL,
  `QTDDIAS` int(11) DEFAULT NULL,
  `Indicador` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDFORMAPAGAMENTO`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `formapagamento`
--



-- --------------------------------------------------------

--
-- Estrutura da tabela `imposto`
--

CREATE TABLE IF NOT EXISTS `imposto` (
  `IDIMPOSTO` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(255) DEFAULT NULL,
  `DESCRICAO` varchar(255) DEFAULT NULL,
  `VALOR` int(11) DEFAULT NULL,
  `ClassificacaoFiscal` varchar(255) DEFAULT NULL,
  `OrigemMercadoria` varchar(255) DEFAULT NULL,
  `SituacaoTributaria` varchar(255) DEFAULT NULL,
  `Modalidade` varchar(255) DEFAULT NULL,
  `AliquitaICMS` double DEFAULT NULL,
  `AliquitaIPI` double DEFAULT NULL,
  PRIMARY KEY (`IDIMPOSTO`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `imposto`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `item`
--

CREATE TABLE IF NOT EXISTS `item` (
  `IDITEM` int(11) NOT NULL AUTO_INCREMENT,
  `NOME` varchar(255) DEFAULT NULL,
  `DESCRICAO` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDITEM`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `item`
--



-- --------------------------------------------------------

--
-- Estrutura da tabela `notafiscal`
--

CREATE TABLE IF NOT EXISTS `notafiscal` (
  `IDNotaFiscal` int(11) NOT NULL AUTO_INCREMENT,
  `IDEmitente` int(11) DEFAULT NULL,
  `IDTransportadora` int(11) DEFAULT NULL,
  `IDCliente` int(11) DEFAULT NULL,
  `iDFormaPagamento` int(11) DEFAULT NULL,
  `ValorTotal` double DEFAULT NULL,
  `DataCadastro` date DEFAULT NULL,
  `TipoSaidaEntrada` varchar(255) DEFAULT NULL,
  `DataSaidaEntrada` date DEFAULT NULL,
  `QtdTransporte` int(11) DEFAULT NULL,
  `TipoTransporte` varchar(255) DEFAULT NULL,
  `EspecieTransporte` varchar(255) DEFAULT NULL,
  `MarcaTransporte` varchar(255) DEFAULT NULL,
  `NumeroTransporte` int(11) DEFAULT NULL,
  `PesoBruto` double DEFAULT NULL,
  `PesoLiquido` double DEFAULT NULL,
  PRIMARY KEY (`IDNotaFiscal`),
  KEY `IDEmitente` (`IDEmitente`),
  KEY `IDTransportadora` (`IDTransportadora`),
  KEY `IDCliente` (`IDCliente`),
  KEY `iDFormaPagamento` (`iDFormaPagamento`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Extraindo dados da tabela `notafiscal`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `notafiscalproduto`
--

CREATE TABLE IF NOT EXISTS `notafiscalproduto` (
  `IDNotaFiscalProduto` int(11) NOT NULL AUTO_INCREMENT,
  `IDNotaFiscal` int(11) DEFAULT NULL,
  `IDProduto` int(11) DEFAULT NULL,
  `QtdProduto` int(11) DEFAULT NULL,
  `ValorTotal` double DEFAULT NULL,
  `icms` double DEFAULT NULL,
  `ipi` double DEFAULT NULL,
  PRIMARY KEY (`IDNotaFiscalProduto`),
  KEY `IDNotaFiscal` (`IDNotaFiscal`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Extraindo dados da tabela `notafiscalproduto`
--



-- --------------------------------------------------------

--
-- Estrutura da tabela `notafiscaltransportados`
--

CREATE TABLE IF NOT EXISTS `notafiscaltransportados` (
  `IDNotaFiscalTransportados` int(11) NOT NULL,
  `IDNotaFiscal` int(11) NOT NULL,
  `Qtd` int(11) NOT NULL,
  `Especie` varchar(255) NOT NULL,
  `Marca` varchar(255) NOT NULL,
  `Numero` varchar(255) NOT NULL,
  `PesoBruto` double NOT NULL,
  `PesoLiquido` double NOT NULL,
  PRIMARY KEY (`IDNotaFiscalTransportados`),
  KEY `IDNotaFiscal` (`IDNotaFiscal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE IF NOT EXISTS `produto` (
  `IDPRODUTO` int(11) NOT NULL AUTO_INCREMENT,
  `DESCRICAO` varchar(255) DEFAULT NULL,
  `NCM` varchar(255) DEFAULT NULL,
  `CFOP` varchar(255) DEFAULT NULL,
  `UnidadeComercializada` varchar(255) DEFAULT NULL,
  `ValorUnitario` double DEFAULT NULL,
  `UnidadeTributaria` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDPRODUTO`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Extraindo dados da tabela `produto`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `tipousuario`
--

CREATE TABLE IF NOT EXISTS `tipousuario` (
  `IDTIPOUSUARIO` int(11) NOT NULL AUTO_INCREMENT,
  `TIPO` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDTIPOUSUARIO`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Extraindo dados da tabela `tipousuario`
--

INSERT INTO `tipousuario` (`IDTIPOUSUARIO`, `TIPO`) VALUES
(1, 'admin'),
(2, 'faturista');

-- --------------------------------------------------------

--
-- Estrutura da tabela `transportadora`
--

CREATE TABLE IF NOT EXISTS `transportadora` (
  `IDTransportadora` int(10) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(255) DEFAULT NULL,
  `RazaoSocial` varchar(255) DEFAULT NULL,
  `Endereco` varchar(255) NOT NULL,
  `Cep` varchar(255) DEFAULT NULL,
  `Logradura` varchar(255) DEFAULT NULL,
  `Numero` varchar(255) DEFAULT NULL,
  `Complemento` varchar(255) DEFAULT NULL,
  `Uf` varchar(255) DEFAULT NULL,
  `Cidade` varchar(255) DEFAULT NULL,
  `Telefone` varchar(255) DEFAULT NULL,
  `Cnpj` varchar(255) DEFAULT NULL,
  `InscricaoEstadual` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDTransportadora`),
  KEY `IDTransportadora` (`IDTransportadora`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Extraindo dados da tabela `transportadora`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
  `IDUSUARIO` int(11) NOT NULL AUTO_INCREMENT,
  `LOGIN` varchar(255) DEFAULT NULL,
  `PASSWORD` varchar(255) DEFAULT NULL,
  `TIPOUSUARIO` int(11) DEFAULT NULL,
  `NOME` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDUSUARIO`),
  KEY `FK22E07F0E4C7D0317` (`TIPOUSUARIO`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`IDUSUARIO`, `LOGIN`, `PASSWORD`, `TIPOUSUARIO`, `NOME`) VALUES
(1, 'testeadm', '123', 1, 'asf'),
(2, 'testefat', '123', 2, 'hdagahgar1');


-- --------------------------------------------------------

--
-- Estrutura stand-in para visualizar `vwnotafiscal`
--
CREATE TABLE IF NOT EXISTS `vwnotafiscal` (
`IDNotaFiscal` int(11)
,`IDEmitente` int(11)
,`IDTransportadora` int(11)
,`IDCliente` int(11)
,`iDFormaPagamento` int(11)
,`ValorTotal` double
,`DataCadastro` date
,`NomeEmitente` varchar(255)
,`NomeFantasiaEmitente` varchar(255)
,`CidadeEmitente` varchar(255)
,`UFEmitente` varchar(255)
,`InscricaoEstadualEmitente` varchar(255)
,`CNPJEmitente` varchar(255)
,`nomeCliente` varchar(255)
,`nomeFantasiaCliente` varchar(255)
,`cnpjCliente` varchar(255)
,`cpfCliente` varchar(255)
,`EnderecoCliente` varchar(255)
,`cidadeCliente` varchar(255)
,`UFCliente` varchar(255)
,`numeroCliente` varchar(255)
,`telefoneCliente` varchar(255)
,`InscricaoEstadualCliente` varchar(255)
,`nomeTransp` varchar(255)
,`razaoSocialTransp` varchar(255)
,`EnderecoTransp` varchar(255)
,`cidadeTransp` varchar(255)
,`UFTransp` varchar(255)
,`numeroTransp` varchar(255)
,`telefoneTransp` varchar(255)
,`InscricaoEstadualTransp` varchar(255)
,`descricao` varchar(255)
,`QTDPARCELA` int(11)
,`QTDDIAS` int(11)
,`Indicador` varchar(255)
);
-- --------------------------------------------------------

--
-- Estrutura para visualizar `vwnotafiscal`
--
DROP TABLE IF EXISTS `vwnotafiscal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwnotafiscal` AS select `nf`.`IDNotaFiscal` AS `IDNotaFiscal`,`nf`.`IDEmitente` AS `IDEmitente`,`nf`.`IDTransportadora` AS `IDTransportadora`,`nf`.`IDCliente` AS `IDCliente`,`nf`.`iDFormaPagamento` AS `iDFormaPagamento`,`nf`.`ValorTotal` AS `ValorTotal`,`nf`.`DataCadastro` AS `DataCadastro`,`em`.`NOME` AS `NomeEmitente`,`em`.`NOMEFANTASIA` AS `NomeFantasiaEmitente`,`em`.`CIDADE` AS `CidadeEmitente`,`em`.`UF` AS `UFEmitente`,`em`.`INSCRICAOESTADUAL` AS `InscricaoEstadualEmitente`,`em`.`CNPJ` AS `CNPJEmitente`,`cl`.`NOME` AS `nomeCliente`,`cl`.`NOMEFANTASIA` AS `nomeFantasiaCliente`,`cl`.`CNPJ` AS `cnpjCliente`,`cl`.`CPF` AS `cpfCliente`,`cl`.`endereco` AS `EnderecoCliente`,`cl`.`CIDADE` AS `cidadeCliente`,`cl`.`UF` AS `UFCliente`,`cl`.`NUMERO` AS `numeroCliente`,`cl`.`TELEFONE` AS `telefoneCliente`,`cl`.`INSCRICAOESTADUAL` AS `InscricaoEstadualCliente`,`tr`.`Nome` AS `nomeTransp`,`tr`.`RazaoSocial` AS `razaoSocialTransp`,`tr`.`Endereco` AS `EnderecoTransp`,`tr`.`Cidade` AS `cidadeTransp`,`tr`.`Uf` AS `UFTransp`,`tr`.`Numero` AS `numeroTransp`,`tr`.`Telefone` AS `telefoneTransp`,`tr`.`InscricaoEstadual` AS `InscricaoEstadualTransp`,`fp`.`DESCRICAO` AS `descricao`,`fp`.`QTDPARCELA` AS `QTDPARCELA`,`fp`.`QTDDIAS` AS `QTDDIAS`,`fp`.`Indicador` AS `Indicador` from ((((`notafiscal` `nf` join `emitente` `em` on((`em`.`IDEMITENTE` = `nf`.`IDEmitente`))) join `transportadora` `tr` on((`tr`.`IDTransportadora` = `nf`.`IDTransportadora`))) join `cliente` `cl` on((`cl`.`IDCliente` = `nf`.`IDCliente`))) join `formapagamento` `fp` on((`fp`.`IDFORMAPAGAMENTO` = `nf`.`iDFormaPagamento`)));

--
-- Restrições para as tabelas dumpadas
--

--
-- Restrições para a tabela `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `FK22E07F0E4C7D0317` FOREIGN KEY (`TIPOUSUARIO`) REFERENCES `tipousuario` (`IDTIPOUSUARIO`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
