using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    abstract class OrcDevelopment
    {
        protected Orc orc;
        protected short currentLevel;
        protected short classUpLevel;
        protected short classDownLevel;
        protected bool noGradeWeaponAbility;
        protected bool dGradeWeaponAbility;
        protected bool cGradeWeaponAbility;
        protected bool bGradeWeaponAbility;

        public Orc Orc
        {
            get { return orc; }
            set { orc = value; }
        }

        public short CurrentLevel
        {
            get { return currentLevel; }
            set { currentLevel = value; }
        }
        public bool BGradeWeaponAbility
        {
            get { return bGradeWeaponAbility; }
        }

        public abstract void LevelUp(short level);
        public abstract void LevelDown(short level);
        public abstract void OrcDevelopmentCheck();
    }
}
