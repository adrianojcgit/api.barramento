namespace API.Barramento.Application.DTO
{
    public class PropostaBaseDto
    {
        public List<PropostaDto> Propostas { get; set; }
        public PropostaBaseDto(List<PropostaDto> propostas)
        {
            Propostas = propostas;
        }
    }
}
