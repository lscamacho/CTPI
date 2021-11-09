-- Script Date: 01/11/2021 14:34  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [funcionario] (
  [matricula] bigint NOT NULL
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
  [id_venda] bigint NOT NULL
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

-- Script Date: 09/11/2021 16:26  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [produto] (
  [id_produto] bigint NOT NULL
, [descricao] nvarchar(100) NOT NULL
, [tipo] nvarchar(100) NOT NULL
, [preco] float NOT NULL
);
GO
ALTER TABLE [produto] ADD CONSTRAINT [PK_produto] PRIMARY KEY ([id_produto]);
GO

-- Script Date: 09/11/2021 16:28  - ErikEJ.SqlCeScripting version 3.5.2.90
ALTER TABLE [venda] ADD CONSTRAINT [fk_produto] FOREIGN KEY ([id_produto]) REFERENCES [produto]([id_produto]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Script Date: 09/11/2021 16:29  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [pagamento] (
  [id_pagamento] bigint NOT NULL
, [tipo_pagamento] nvarchar(100) NOT NULL
, [id_venda] bigint NOT NULL
);
GO
ALTER TABLE [pagamento] ADD CONSTRAINT [PK_pagamento] PRIMARY KEY ([id_pagamento]);
GO

-- Script Date: 09/11/2021 16:31  - ErikEJ.SqlCeScripting version 3.5.2.90
ALTER TABLE [pagamento] ADD CONSTRAINT [fk_id_venda] FOREIGN KEY ([id_venda]) REFERENCES [venda]([id_venda]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Script Date: 09/11/2021 16:32  - ErikEJ.SqlCeScripting version 3.5.2.90
CREATE TABLE [venda_has_produto] (
  [id_venda] bigint NOT NULL
, [id_produto] bigint NOT NULL
);
GO

-- Script Date: 09/11/2021 16:33  - ErikEJ.SqlCeScripting version 3.5.2.90
ALTER TABLE [venda_has_produto] ADD CONSTRAINT [fk_id_venda] FOREIGN KEY ([id_venda]) REFERENCES [venda]([id_venda]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Script Date: 09/11/2021 16:33  - ErikEJ.SqlCeScripting version 3.5.2.90
ALTER TABLE [venda_has_produto] ADD CONSTRAINT [fk_id_produto] FOREIGN KEY ([id_produto]) REFERENCES [produto]([id_produto]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
