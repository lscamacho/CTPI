-- Script Date: 01/11/2021 14:34  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [funcionario] (
  [matricula] bigint IDENTITY (1,1) NOT NULL
, [nome] nvarchar(100) NOT NULL
, [cargo] nvarchar(100) NOT NULL
, [endereco] nvarchar(100) NOT NULL
, [telefone] nvarchar(100) NULL
);
GO
ALTER TABLE [funcionario] ADD CONSTRAINT [PK_funcionario] PRIMARY KEY ([matricula]);
GO


-- Script Date: 01/11/2021 15:04  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [cliente] (
  [cpf] nvarchar(100) NOT NULL
, [nome] nvarchar(100) NOT NULL
, [logadouro] nvarchar(200) NOT NULL
, [data_nascimento] datetime NOT NULL
, [estado_civil] nvarchar(20) NOT NULL
, [telefone] nvarchar(15) NOT NULL
, [renda_mensal] float NOT NULL
, [estado] nvarchar(2) NOT NULL
, [cidade] nvarchar(100) NOT NULL
, [cep] nvarchar(20) NOT NULL
);
GO
ALTER TABLE [cliente] ADD CONSTRAINT [PK_cliente] PRIMARY KEY ([cpf]);


-- Script Date: 01/11/2021 15:08  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [venda] (
  [id_venda] bigint IDENTITY (1,1) NOT NULL
, [data] datetime NOT NULL
, [valor] float NOT NULL
, [matricula_funcionario] bigint NOT NULL
, [cpf_cliente] nvarchar(100) NOT NULL
, [id_produto] bigint NOT NULL
);
GO
ALTER TABLE [venda] ADD CONSTRAINT [PK_venda] PRIMARY KEY ([id_venda]);
GO
-- Script Date: 01/11/2021 15:12  - ErikEJ.SqlCeScripting version 3.5.2.90
ALTER TABLE [venda] ADD CONSTRAINT [fk_matricula_funcionario] FOREIGN KEY ([matricula_funcionario]) REFERENCES [funcionario]([matricula]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
-- Script Date: 01/11/2021 15:13  - ErikEJ.SqlCeScripting version 3.5.2.90
ALTER TABLE [venda] ADD CONSTRAINT [fk_cpf_cliente] FOREIGN KEY ([cpf_cliente]) REFERENCES [cliente]([cpf]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
