using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Orc
    {
        private OrcDevelopment _state;
        private string _orcMale;

        public Orc(string orcMale)
        {
            _orcMale = orcMale;
            _state = new OrcFighter(0, this);
        }
        public double CurrentLevel
        {
            get { return _state.CurrentLevel; }
        }
        public bool BGradeWeaponAbility
        {
            get { return _state.BGradeWeaponAbility; }
        }

        public OrcDevelopment State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void LevelUp(short level)
        {
            _state.LevelUp(level);
            Console.WriteLine("{0} increased level by {1} levels.", _orcMale,level);
            Console.WriteLine("Current level is {0}", CurrentLevel);
            Console.WriteLine("{0} is now: {1}", _orcMale,State.GetType().Name);
            if (BGradeWeaponAbility)
            {
                Console.WriteLine("{0} can now use B-Grade Weapons without getting penalty! Chop their heads off!!!", _orcMale);
            }
            Console.WriteLine("");
        }

        public void LevelDown(short level)
        {
            _state.LevelDown(level);
            Console.WriteLine("{0} decreased level by {1} levels.", _orcMale, level);
            Console.WriteLine("Current level is {0}", CurrentLevel);
            Console.WriteLine("{0} is now: {1}", _orcMale, State.GetType().Name);
            Console.WriteLine("");
        }
    }
}
