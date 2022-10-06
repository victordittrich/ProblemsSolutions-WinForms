-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 04-Out-2022 às 03:56
-- Versão do servidor: 5.7.11
-- PHP Version: 5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `situationsapp`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`id`, `usuario`, `senha`) VALUES
(1, 'test', '12345678'),
(2, 'vito', '12345678'),
(3, 'victor', '12345678'),
(4, 'test', '12345678'),
(5, 'aaaa', '12345678'),
(6, 'asqax', '12345678');

-- --------------------------------------------------------

--
-- Estrutura da tabela `problemas`
--

CREATE TABLE `problemas` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `problema` varchar(2555) NOT NULL,
  `solucao` varchar(2555) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `problemas`
--

INSERT INTO `problemas` (`id`, `usuario`, `problema`, `solucao`) VALUES
(1, 'probleminha pai', 'probleminha pai', 'A metodologia da Caixa Branca é um teste estrutural que submete o código-fonte do programa à análise. Esse método analisa o fluxo de dados, os componentes do sistema e a segurança para avaliar também os componentes.'),
(2, 'victor', 'problemao', 'A metodologia da Caixa Branca é um teste estrutural que submete o código-fonte do programa à análise. Esse método analisa o fluxo de dados, os componentes do sistema e a segurança para avaliar também os componentes.'),
(3, 'victor', 'oi', 'asas'),
(4, 'victor', 'aaaaaaaaaaaaaaa', 'A metodologia da Caixa Branca é um teste estrutural que submete o código-fonte do programa à análise. Esse método analisa o fluxo de dados, os componentes do sistema e a segurança para avaliar também os componentes.'),
(5, 'victor', 'aaaaaaaaaaaaaa', 'Esse tipo de teste une as técnicas da Caixa Branca e da Caixa Preta. Sendo assim, a estrutura do código-fonte e  as funcionalidades do sistema são submetidas a avaliações. A Caixa Cinza também é chamada de engenharia reversa, pois é utilizada para compreender o que causou erros e falhas no sistema. Isso possibilita que sejam posteriormente solucionados.  '),
(6, 'victor', 'aaaaaaaaaaaaaa', 'A metodologia da regressão testa todas as versões ou protótipos de um sistema. Ela é aplicada cada vez que uma funcionalidade sofre mudanças ou quando são incluídas novas funções. A finalidade desse tipo de teste é evitar a repetição de erros das versões anteriores.'),
(7, 'victor', 'aaaaaaaaaaaaaa', 'Os testes não-funcionais estão ligados à avaliação de quesitos que não se relacionam diretamente com as funções e respostas do sistema. Na verdade, eles analisam a usabilidade, velocidade, segurança e outros aspectos que não dependem das ações executadas pelo sistema.'),
(8, 'victor', 'aaaaaaaaaaaaaa', 'A metodologia da Caixa Branca é um teste estrutural que submete o código-fonte do programa à análise. Esse método analisa o fluxo de dados, os componentes do sistema e a segurança para avaliar também os componentes.'),
(9, 'victor', 'aa', 'A metodologia da Caixa Branca é um teste estrutural que submete o código-fonte do programa à análise. Esse método analisa o fluxo de dados, os componentes do sistema e a segurança para avaliar também os componentes.'),
(10, 'victor', 'dqwcwc', 'Os testes não-funcionais estão ligados à avaliação de quesitos que não se relacionam diretamente com as funções e respostas do sistema. Na verdade, eles analisam a usabilidade, velocidade, segurança e outros aspectos que não dependem das ações executadas pelo sistema.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `problemas`
--
ALTER TABLE `problemas`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `problemas`
--
ALTER TABLE `problemas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
