using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class ClassRegister
    {
        private string _name;
        private string _numberGroup;
        private string _avarageScore;
        private string _numberCB;

        public ClassRegister(string name, string numberGroup, string avarageScore, string numberCB)
        {
            this._name = name;
            this._numberGroup = numberGroup;
            this._avarageScore = avarageScore;
            this._numberCB = numberCB;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetNumberGroup()
        {
            return _numberGroup;
        }
        public string GetNumberCB()
        {
            return _numberCB;
        }
        public string GetAvarageScore()
        {
            return _avarageScore;
        }
    }
}
