namespace firsrApi.Model
{
    public class CityModel
    {
        public int CityID { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }

        public DateTime Created {  get; set; }
    }
}
