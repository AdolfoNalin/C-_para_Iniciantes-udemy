using C__ParaIniciantes;
using C_para_Iniciantesudemy.Objects.Heranças;

Aluno aluno = new Aluno();

aluno.name = "Adolfo";
aluno.email = "adolfonalin@hotmail.com";
aluno.password = "12345";
aluno.Login(aluno.name, aluno.password);
aluno.GetInformation();

Zelador zelador= new Zelador();

zelador.name = "Cleiton";
zelador.email = "cleitonnalin@hotmail.com";
zelador.password = "12345";

zelador.Login(zelador.name, zelador.password);
zelador.GetInformation();