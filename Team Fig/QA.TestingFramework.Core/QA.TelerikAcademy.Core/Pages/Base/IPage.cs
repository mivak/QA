namespace QA.TelerikAcademy.Core.Pages.Base
{
    public interface IPage
    {
        string Url { get; set; }

        void Navigate();
    }
}