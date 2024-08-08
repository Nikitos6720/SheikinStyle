namespace SSDll.models.Products;

public class Product
{
    private Guid _id;
    private string _name;
    private string _description;
    private decimal _price;
    private Category _category;
    private AdditionalContent _media;
}