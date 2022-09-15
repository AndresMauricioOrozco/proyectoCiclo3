using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Persistencia
{
    public class contextDb : DbContext
    {
        
    }

protected override void OnConfiguriong (DbContextOptionsBuilder optionsBuilder)
{
    if(!optionsBuilder.UseDqlServer(.....));
}
}