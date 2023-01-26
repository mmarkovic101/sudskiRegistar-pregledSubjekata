using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudskiRegistar.Classes
{
    public class Subjekt
    {
        public int mbs { get; set; }
        public int sud_id_nadlezan { get; set; }
        public int sud_id_sluzba { get; set; }
        public long oib { get; set; }
        public int ino_podruznica { get; set; }
        public int stecajna_masa { get; set; }
        public DateTime datum_osnivanja { get; set; }
        public int likvidacijska_masa { get; set; }
        public string potpuni_mbs { get; set; }
        public string potpuni_oib { get; set; }
        public List<Tvrtka> tvrtke { get; set; }
        public List<SkracenaTvrtka> skracene_tvrtke { get; set; }
        public List<Sjediste> sjedista { get; set; }
        public List<TemeljniKapital> temeljni_kapitali { get; set; }
        public List<PredmetPoslovanja> predmeti_poslovanja { get; set; }
        public List<PravniOblik> pravni_oblici { get; set; }
        public List<GrupaGfi> grupe_gfi { get; set; }
        public List<Postupak> postupci { get; set; }
        public SudSluzba sud_sluzba { get; set; }
        public SudNadlezan sud_nadlezan { get; set; }
    }

    public class Drzava
    {
        public int sifra { get; set; }
        public string naziv { get; set; }
        public string oznaka_2 { get; set; }
        public string oznaka_3 { get; set; }
    }

    public class GfiLista
    {
        public int gfi_rbr { get; set; }
        public int vrsta_dokumenta { get; set; }
        public int oznaka_konsolidacije { get; set; }
        public int godina_izvjestaja { get; set; }
        public DateTime datum_dostave { get; set; }
        public DateTime datum_od { get; set; }
        public DateTime datum_do { get; set; }
    }

    public class GrupaGfi
    {
        public int gfi_rbr { get; set; }
        public List<GfiLista> gfi_lista { get; set; }
    }

    public class NacKlasDjelatnost
    {
        public int id { get; set; }
        public string sifra { get; set; }
        public string puni_naziv { get; set; }
    }

    public class Postupak
    {
        public Vrsta vrsta { get; set; }
    }

    public class PravniOblik
    {
        public VrstaPravnogOblika vrsta_pravnog_oblika { get; set; }
    }

    public class PredmetPoslovanja
    {
        public int djelatnost_rbr { get; set; }
        public NacKlasDjelatnost nac_klas_djelatnosti { get; set; }
        public string djelatnost_tekst { get; set; }
    }

    public class Sjediste
    {
        public string ulica { get; set; }
        public int kucni_broj { get; set; }
        public int sifra_zupanije { get; set; }
        public string naziv_zupanije { get; set; }
        public int sifra_opcine { get; set; }
        public string naziv_opcine { get; set; }
        public int sifra_naselja { get; set; }
        public string naziv_naselja { get; set; }
    }

    public class SkracenaTvrtka
    {
        public string ime { get; set; }
    }

    public class SudNadlezan
    {
        public int id { get; set; }
        public int sifra { get; set; }
        public string naziv { get; set; }
        public int sifra_zupanije { get; set; }
        public string naziv_zupanije { get; set; }
        public int sifra_opcine { get; set; }
        public string naziv_opcine { get; set; }
        public int sifra_naselja { get; set; }
        public string naziv_naselja { get; set; }
        public int sud_id_nadlezan { get; set; }
        public int izdaje_izvatke { get; set; }
    }

    public class SudSluzba
    {
        public int id { get; set; }
        public int sifra { get; set; }
        public string naziv { get; set; }
        public int sifra_zupanije { get; set; }
        public string naziv_zupanije { get; set; }
        public int sifra_opcine { get; set; }
        public string naziv_opcine { get; set; }
        public int sifra_naselja { get; set; }
        public string naziv_naselja { get; set; }
        public int sud_id_nadlezan { get; set; }
        public int izdaje_izvatke { get; set; }
    }

    public class TemeljniKapital
    {
        public Valuta valuta { get; set; }
        public double iznos { get; set; }
    }

    public class Tvrtka
    {
        public string ime { get; set; }
        public string naznaka_imena { get; set; }
    }

    public class Valuta
    {
        public Drzava drzava { get; set; }
        public int id { get; set; }
        public int sifra { get; set; }
        public string naziv { get; set; }
    }

    public class Vrsta
    {
        public int postupak { get; set; }
        public string znacenje { get; set; }
    }

    public class VrstaPravnogOblika
    {
        public int sifra { get; set; }
        public string naziv { get; set; }
        public string kratica { get; set; }
    }
}
