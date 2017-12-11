using System;

namespace CodeSkill_11._12._2017
{
    public class FindMissingNumbers
    {
        private int[] _tab;
        private int _result;
        public FindMissingNumbers(int[] tab)
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
                    int dummyPositiveAlways = 1;
                    if (_tab[i] < 0)
                    {
                        dummyPositiveAlways = -1;
                    }
                    if (_tab[i + 1] * dummyPositiveAlways - _tab[i] * dummyPositiveAlways != 1)
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
