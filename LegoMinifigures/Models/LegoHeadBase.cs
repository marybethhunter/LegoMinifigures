namespace LegoMinifigures.Models
{
    internal class LegoHeadBase
        {
            public LegoColor Color { get; set; }
            public string Theme { get; set; }
            public string Expression { get; set; }
            public string FacialHair { get; set; }
    }
    //enum - make a type for specific options, not a class but a struct
    public enum LegoColor
    {
        None,
        Yellow,
        Gray,
        Red,
        Orange,
        Green,
        Blue,
        Purple
    }

    public enum Status
    {
        Active,
        Inactive,
        Deleted
    }

}