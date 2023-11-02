Episodio ep1 = new(4, "Técnicas Contra as Artes das Trevas", 90);
ep1.AdicionarConvidado("LockHart");
ep1.AdicionarConvidado("Humbriged");

Episodio ep2 = new(2, "Herbologia", 78);
ep2.AdicionarConvidado("Prof. Sprout");

Episodio ep3 = new(3, "Técnicas de Pegadinhas", 87);
ep3.AdicionarConvidado("Fred Weasley");
ep3.AdicionarConvidado("Jorge Weasley");

Episodio ep0 = new(1, "Aula de Poções", 93);
ep0.AdicionarConvidado("Principe Mestiço");

Podcast podcast = new("Aulas de Hogwarts", "Albus");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.AdicionarEpisodio(ep0);

podcast.ExibirDetalhes();