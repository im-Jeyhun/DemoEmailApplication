namespace DemoEmailApplication.NotifactionDm.ViewModel
{
    public class ListItemViewModel
    {
        public string From { get; set; }
        public string To { get; set; }

        public string Title { get; set; }

        public ListItemViewModel(string from , string to , string title )
        {
            From = from;
            To = to;
            Title = title;
        }

    }
}
