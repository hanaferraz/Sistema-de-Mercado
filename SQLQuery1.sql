CREATE TABLE Produtos (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100) NOT NULL,
    Preco DECIMAL(18, 2) NOT NULL,
    QuantidadeEmEstoque INT NOT NULL,
    CodigoBarras NVARCHAR(50) UNIQUE
);

-- Tabela para Funcionarios
CREATE TABLE Funcionarios (
    Id INT PRIMARY KEY IDENTITY,
    Nome NVARCHAR(100) NOT NULL,
    Cargo NVARCHAR(50) NOT NULL,
    Salario DECIMAL(18, 2) NOT NULL
);

CREATE TABLE Estoque (
    Id INT IDENTITY(1,1) PRIMARY KEY, -- Identificador único
    Nome NVARCHAR(100) NOT NULL,     -- Nome do produto
    Quantidade INT NOT NULL DEFAULT 0, -- Quantidade em estoque
    Preco DECIMAL(10, 2) NULL,       -- Preço unitário do produto (opcional)
    DataCadastro DATETIME DEFAULT GETDATE(), -- Data de cadastro do produto
    Ativo BIT NOT NULL DEFAULT 1    -- Status do produto (1 = ativo, 0 = inativo)
);



GO