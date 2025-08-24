using FirstProject_Netology_c.Utils;

namespace FirstProject_Netology_c.Items.EconomicItems
{
    public sealed class Gold : EconomicItem
    {
        public override bool Stackable => true;

        public Gold() : base(GameConstants.Gold)
        {            
        }       
    }
}
