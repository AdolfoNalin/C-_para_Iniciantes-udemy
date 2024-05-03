using C__ParaIniciantes;

Filme filme = new Filme(1, "Meu malvado favorito", "Um vilao legal", 2012, "HBO max");
Filme f = filme;
Console.WriteLine(filme.nome);
Console.WriteLine(f.nome);

f.SetAtor("Adolfo");
f.SetAtor("bred pitt");
f.SetAtor("uva");

f.GetAtores();