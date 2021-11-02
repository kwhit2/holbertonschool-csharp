using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// class Inventory
/// </summary>
class Inventory : BaseClass
{
    public string user_id;
    public string item_id;
    public int quantity;

    /// <summary>
    /// Inventory method - sets user_id, item_id, quantity
    /// </summary>
    /// <param name="user_id"></param>
    /// <param name="item_id"></param>
    /// <param name="quantity"></param>
    public Inventory(string user_id, string item_id, int quantity)
    {
        this.user_id = user_id;
        this.item_id = item_id;

        if (quantity < 0)
            this.quantity = 1;
        else
            this.quantity = quantity;
    }
}
