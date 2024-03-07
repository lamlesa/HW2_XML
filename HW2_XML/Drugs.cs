namespace HW2_XML
{
    public class Drugs
    {
        private string name;
        private byte death_dose;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public byte Death_Dose
        {
            get { return death_dose; }
            set { death_dose = value; }
        }
    }
}