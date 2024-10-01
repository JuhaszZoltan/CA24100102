namespace CA24100102
{
    internal class SportEvent
    {
        public int Year { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Dictionary<string, int> Medals { get; set; }

        public SportEvent(string row)
        {
            var v = row.Split(';');
            Year = int.Parse(v[0]);
            Country = v[1];
            City = v[2];
            Medals = new()
            {
                { "gold", int.Parse(v[3])},
                { "silver", int.Parse(v[4])},
                { "bronze", int.Parse(v[5])},
            };
        }
    }
}
