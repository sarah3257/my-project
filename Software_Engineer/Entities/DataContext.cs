namespace Software_Engineer.Entities
{
    public class DataContext
    {

        public List<Achievements> Achievements { get; set; }
        public int countA { get; set; }
        public List<Projects> Projects { get; set; }
        public int countP { get; set; }
        public List<Office> Office { get; set; }
        public int countO { get; set; }

        public DataContext()
        {
            Achievements = new List<Achievements>();
            Achievements.Add(new Achievements { _idAchievement = 1, _nameAchievement = "תעודת מהט" });
            Achievements.Add(new Achievements { _idAchievement = 2, _nameAchievement = "קמא טק" });
            countA = 2;
            Projects = new List<Projects>();
            Projects.Add(new Projects { IdProject = 1, NameProject = "police", CreationDate = new DateTime(2021, 08, 01) });
            Projects.Add(new Projects { IdProject = 2, NameProject = "למטייל", CreationDate = new DateTime(2022, 11, 01) });
            countP = 2;
            Office = new List<Office>();
            Office.Add(new Office { _idOffice = 1, _nameOffice = "Google" });
            Office.Add(new Office { _idOffice = 2, _nameOffice = "Microsoft" });
            countO = 2;
        }
    }
}
