namespace ApiPractice.Data
{
    public static class Veri
    {
        public static List<Kisi> Kisiler()
        {
            return new List<Kisi>()
            {
                new Kisi() { Id = 1, Ad = "Mitski" },
                new Kisi() { Id = 2, Ad = "Chappell Roan" },
                new Kisi() { Id = 3, Ad = "Pedro Pascal" },
                new Kisi() { Id = 4, Ad = "Paul Mescal" },
                new Kisi() { Id = 5, Ad = "Keanu Reeves" },
                new Kisi() { Id = 6, Ad = "Daisy Edgar-Jones" }
            };
        }
    }
}
