namespace ActiveCampaign.Struct
{
    public class ListField
    {
        public string Title { get; set; }
        public bool Required { get; set; }
        public string Perstag { get; set; }
        public ListFieldType ListFieldType { get; set; }
    }

    public enum ListFieldType
    {
        TextField = 1,
        TextBox = 2,
        Checkbox = 3,
        Radio = 4,
        Dropdown = 5,
        HiddenField = 6,
        ListBox = 7,
        Date = 9
    }
}