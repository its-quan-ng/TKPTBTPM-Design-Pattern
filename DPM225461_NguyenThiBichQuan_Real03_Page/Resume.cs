
namespace DPM225461_NguyenThiBichQuan_Real03_Page
{
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new ExperiencePage());
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
        }
    }
}
