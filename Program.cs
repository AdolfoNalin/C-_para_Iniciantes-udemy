using C__ParaIniciantes;
using C_para_Iniciantesudemy.Objects.Heranças;

Aluno aluno = new Aluno("Adolfo", "adolfonalin@gmail.com", "12345", "Noturno");

Zelador zelador= new Zelador("Cleiton", "cleitonnalin@hotmail.com", "12345");

zelador.Login(zelador.name, zelador.password);
zelador.GetInformation();