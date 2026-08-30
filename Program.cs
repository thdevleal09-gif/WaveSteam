using WaveSteam;

Banda Travis_Scott = new Banda("Travis Scott");



Album albumDoTravis = new Album("ASTROWORLD");


Musica musica1 = new Musica("SICKO MODE", Travis_Scott, 312, false);
Musica musica2 = new Musica("STARGAZING", Travis_Scott, 250, true);
Musica musica3 = new Musica("STOP TRYING TO BE GOD", Travis_Scott, 300, false);
Musica musica4 = new Musica("BUTTERFLY EFFECT", Travis_Scott, 200, true);


albumDoTravis.AdicionarMusica(musica1);
albumDoTravis.AdicionarMusica(musica2);
albumDoTravis.AdicionarMusica(musica3);
albumDoTravis.AdicionarMusica(musica4);

Travis_Scott.AdicionarAlbum(albumDoTravis);
Travis_Scott.Discografia();
musica1.ExibirFichaTecnica();
Console.WriteLine();
musica2.ExibirFichaTecnica();
Console.WriteLine();
musica3.ExibirFichaTecnica();
Console.WriteLine();
musica4.ExibirFichaTecnica();
Console.WriteLine();
albumDoTravis.ExibirMusicasDoAlbum();
Travis_Scott.AdicionarAlbum(albumDoTravis);
