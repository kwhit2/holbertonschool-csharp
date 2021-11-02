using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// class User
/// </summary>
class User : BaseClass
{
    string name { get; set; }

    /// <summary>
    /// User method - sets name
    /// </summary>
    /// <param name="name"></param>
    public User(string name)
    {
        this.name = name;
    }
}
