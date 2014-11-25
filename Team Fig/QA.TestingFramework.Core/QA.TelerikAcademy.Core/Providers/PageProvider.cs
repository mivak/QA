using QA.TelerikAcademy.Core.Pages.Base;

namespace QA.TelerikAcademy.Core.Providers
{
    public static class PageProvider<T> where T: IPage, new()
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }
}