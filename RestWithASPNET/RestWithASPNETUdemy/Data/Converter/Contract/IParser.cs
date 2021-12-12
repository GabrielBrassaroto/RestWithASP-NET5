using System.Collections.Generic;

namespace RestWithASPNETUdemy.Date.Converter.Contract
{
    public interface IParser<O,D> // O- origiem D- Destino
    {
        D Parse(O origin);

        IList<D> Parse(IList<O> origin);
    }
}
