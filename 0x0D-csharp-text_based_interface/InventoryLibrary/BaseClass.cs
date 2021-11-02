using System;

/// <summary>
/// class BaseClass
/// </summary>
public class BaseClass
{
    public string id { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }

    /// <summary> BaseClass method - sets id, date_created </summary>
    public BaseClass()
    {
        this.id = id;
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
}
