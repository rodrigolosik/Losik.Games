namespace Losik.Games.SharedKernel.Entities
{
    public class Game : EntityBase
    {
        public string Name { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public ICollection<string> Plataforms { get; set; }
        public ICollection<string> Genders { get; set; }
    }
}
