using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Tyrant : OrcDevelopment
    {
        public Tyrant(OrcDevelopment state) : this(state.CurrentLevel, state.Orc)
        {

        }
        public Tyrant(short currentLevel, Orc orc)
        {
            this.currentLevel = currentLevel;
            this.orc = orc;
            dGradeWeaponAbility = true;
            cGradeWeaponAbility = true;
            bGradeWeaponAbility = false;
            Initialize();
        }
        private void Initialize()
        {
            classDownLevel = 39;
            classUpLevel = 60;
            //dGradeWeaponAbility = true;
            //cGradeWeaponAbility = false;
            //bGradeWeaponAbility = false;
        }
        public override void LevelDown(short level)
        {
            currentLevel -= level;
            OrcDevelopmentCheck();
        }

        public override void LevelUp(short level)
        {
            currentLevel += level;
            OrcDevelopmentCheck();
        }

        public override void OrcDevelopmentCheck()
        {
            if (currentLevel >= classUpLevel)
            {
                orc.State = new GrandKhavatari(this);
            }
            else if (currentLevel <= classDownLevel)
            {
                orc.State = new Monk(this);
            }
        }
    }
}
