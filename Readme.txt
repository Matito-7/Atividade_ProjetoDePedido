1. Conceito: A intersecção;
O Inner Join 

Tabela de usuário
id,
CPF unique,
Matheus

Tabela de Pedidos
Intens
id
CREATE DATABASE lojaDeRoupa;
use lojaDeRoupa;

CREATE TABLE Clientes (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE
);

CREATE TABLE Pedidos (
    id_pedido INT AUTO_INCREMENT PRIMARY KEY,
    item VARCHAR(100) NOT NULL,
    valor DECIMAL(10, 2),
    id_cliente INT,
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente)
);
