// função Main() implícita

using ComposicaoNotaFiscal;
ItemNf it1 = new ItemNf(5);
ItemNf it2 = new ItemNf(3);
List<ItemNf> vetI = new List<ItemNf>();
vetI.Add(it1);
vetI.Add(it2);

NotaFiscal nf = new NotaFiscal(1, "24/03/2023", vetI);

foreach (ItemNf it in nf.VetItemNf)
    Console.WriteLine("quantidade de itens: " + it.Qtde);

nf = null;
GC.Collect();    

