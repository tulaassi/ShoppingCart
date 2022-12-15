using API.Models;
using API.Repository;
using System.Collections.Generic;
using System.Linq;



public class UserRepository : IDataRepository<UserTable>
{
    shopingcartEntities _userdbcontext;
    public UserRepository(shopingcartEntities userdbcontext)
    {
        _userdbcontext = userdbcontext;
 }
    public void Add(UserTable newuser)
    {
        _userdbcontext.UserTables.Add(newuser);
        _userdbcontext.SaveChanges();
    }
    public IEnumerable<UserTable> GetAll()
    {
        return _userdbcontext.UserTables.ToList();
    }
}






