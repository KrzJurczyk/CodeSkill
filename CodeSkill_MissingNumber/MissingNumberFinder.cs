using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSkill_MissingNumber
{
    public class MissingNumberFinder
    {
        private int[] _tab;
        private int _result;
        public MissingNumberFinder(int[] tab)
        {
            _tab = tab;
        }

        public int FirstMissingNumber()
        {
            if (_tab.Length == 0)
            {
                throw new Exception("Collection is empty, unspecified beginning of the collection");
            }

            else
            {
                for (int i = 0; i < _tab.Length - 1; i++)
                {
                    if ((_tab[i + 1] - _tab[i] != 1) || ((_tab[i] * -1) - (_tab[i+1] * -1) !=  1))
                    {
                        _result = _tab[i] + 1;
                        break;
                    }
                    else _result = _tab[i + 1] + 1;
                }
            }
            return _result;
        }
    }
}