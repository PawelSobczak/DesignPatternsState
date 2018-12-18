using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class OrcFighter : OrcDevelopment
    {
        public OrcFighter(OrcDevelopment state) : this(state.CurrentLevel, state.Orc)
        {

        }
        public OrcFighter(short currentLevel, Orc orc)
        {
            this.currentLevel = currentLevel;
            this.orc = orc;
            Initialize();
        }

        private void Initialize()
        {
            classDownLevel = 0;
            classUpLevel = 20;
            noGradeWeaponAbility = true;
            dGradeWeaponAbility = false;
            cGradeWeaponAbility = false;
            bGradeWeaponAbility = false;
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
            if (currentLevel>=classUpLevel)
            {
                orc.State = new Monk(this);
            }
        }
    }
}
