using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Monk : OrcDevelopment
    {
        public Monk(OrcDevelopment state) : this(state.CurrentLevel, state.Orc)
        {

        }
        public Monk(short currentLevel, Orc orc)
        {
            this.currentLevel = currentLevel;
            this.orc = orc;
            dGradeWeaponAbility = true;
            cGradeWeaponAbility = false;
            bGradeWeaponAbility = false;
            Initialize();
        }
        private void Initialize()
        {
            classDownLevel = 19;
            classUpLevel = 40;
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
                orc.State = new Tyrant(this);
            }
            else if (currentLevel <= classDownLevel)
            {
                orc.State = new OrcFighter(this);
            }
        }
    }
}
