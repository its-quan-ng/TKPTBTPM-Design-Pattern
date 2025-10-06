
namespace DPM225461_NguyenThiBichQuan_Real03_Page
{
    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new BibliographyPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
        }
    }
}
