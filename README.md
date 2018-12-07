# API em node e mongoDB.

## funções:
Registro de usuários
Autenticação por meio de email e senha onde gera um token com a duração de 1 dia. 
Criptografia de senha por meio de has
Tem a opção de enviar um e-mail com novo token para recadastrar nova senha
CRUD com rotas de Post, Get, Delet e Update 


Bibliotecas e dependencias utilizadas na Api     
-bcryptjs: "2.4.3",
-body-parser: "1.18.3",
-express: "4.16.4",
-fs: "0.0.1-security",
-jsonwebtoken: "8.4.0",
-mongodb: "3.1.10",
-mongoose: "5.3.14",
-nodemailer: "4.7.0",
-nodemailer-express-handlebars: "3.0.0",
-path: "0.12.7",
-yarn: "1.12.3"
    
    
No processo de teste a Api foi testada no Insomia 
Carregada com Seed de usuários 
E o email para troca de senha foi simulado com Mailtrap.
