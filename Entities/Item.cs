namespace AuctionService.Entities;

public enum item{
    public Guid Id {get; set;}
    public string Make {get; set;}
    public string Model {get; set;}

    public int Year {get: set;}

    public string Color {get; set;}

    public int Milage {get; set;}

    public string ImageUrl {get; set;}
    
}