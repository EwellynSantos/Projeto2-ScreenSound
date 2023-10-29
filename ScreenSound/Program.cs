Banda bts = new Banda();
bts.Nome = "BTS";

Album albumDoBTS = new Album();
albumDoBTS.Nome = "Yet you come";

Musica musica1 = new Musica(bts);
musica1.Nome = "IDOL";
musica1.Duracao = 213;


Musica musica2 = new Musica(bts);
musica2.Nome = "Euphoria";
musica2.Duracao = 314;

albumDoBTS.AdicionarMusica(musica1);
albumDoBTS.AdicionarMusica(musica2);


bts.AdicionarAlbum(albumDoBTS);
bts.ExibirDiscografia();