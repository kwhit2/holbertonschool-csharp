using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// class Item
/// </summary>
class Item : BaseClass
{
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }
    public List<string> tags { get; set; }

    /// <summary> Item method - sets name, description, price(.2dpf), List of strings tags </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="price"></param>
    /// <param name="tags"></param>
    public Item(string name, string description=null, float price=0, List<string> tags=null)
    {
        this.name = name;
        this.description = description;
        this.price = price;
        this.tags = tags;
    }
}
