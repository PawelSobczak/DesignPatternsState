using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class GrandKhavatari : OrcDevelopment
    {
        public GrandKhavatari(OrcDevelopment state) : this(state.CurrentLevel, state.Orc)
        {

        }
        public GrandKhavatari(short currentLevel, Orc orc)
        {
            this.currentLevel = currentLevel;
            this.orc = orc;
            dGradeWeaponAbility = true;
            cGradeWeaponAbility = true;
            bGradeWeaponAbility = true;
            Initialize();
        }
        private void Initialize()
        {
            classDownLevel = 59;
            classUpLevel = 80;
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
            if (currentLevel <= classDownLevel)
            {
                orc.State = new Tyrant(this);
            }
        }
    }
}
