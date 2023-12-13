using BuilderAssignment.Builders;
using BuilderAssignment.Models;
using static BuilderAssignment.Models.RamenBowl;

namespace BuilderAssignment
{
    public class MisoRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        // - Setting broth
        [BrothType(BrothType.Miso)]
        public void setBroth()
        {
            ramen.description += "BrothType : Miso";
        }
        // - Setting noodles
        [NoodleType(NoodleType.Udon)]
        public void setNoodle()
        {
            ramen.description += ", NoodleType : Upon";
        }

        // - Adding toppings

        [Topping(Topping.GreenOnions)]
        public void addToppings()
        {
            ramen.description += ", Topping : GreenOnions";
        }

        // - Adding Extras
        [Extra(Extra.Corn)]
        public void addExtra()
        {
            ramen.description += ", Extra : Corn";
        }
        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}