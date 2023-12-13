using BuilderAssignment.Builders;
using BuilderAssignment.Models;
using static BuilderAssignment.Models.RamenBowl;

namespace BuilderAssignment
{
    public class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        // - Setting broth
        [BrothType(BrothType.SpicyTonkotsu)]
        public void setBroth()
        {
            ramen.description += "BrothType : SpicyTonkotsu";
        }
        // - Setting noodles
        [NoodleType(NoodleType.Thin)]
        public void setNoodle()
        {
            ramen.description += ", NoodleType : Thin";
        }

        // - Adding toppings

        [Topping(Topping.ChashuPork & Topping.GreenOnions)]
        public void addToppings()
        {
            ramen.description += ", Topping : ChashuPork & GreenOnions";
        }

        // - Adding Extras
        [Extra(Extra.ExtraSpice)]
        public void addExtra()
        {
            ramen.description += ", Extra : ExtraSpice";
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}