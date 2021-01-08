using System;

namespace DesignPatternSamples.WebAPI.Models.Detran
{
    public class PontosCarteiraModel
    {
        public DateTime DataInfracao { get; set; }
        public string CodigoInfracao { get; set; }
        public int Quantidade { get; set; }
        public bool SituacaoAtiva { get; set; }
    }
}