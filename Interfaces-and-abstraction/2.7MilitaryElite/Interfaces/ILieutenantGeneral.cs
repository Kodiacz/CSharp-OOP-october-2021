using System.Collections.Generic;

namespace _2._7MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        public List<IPrivate> Privates { get; set; }
    }
}
