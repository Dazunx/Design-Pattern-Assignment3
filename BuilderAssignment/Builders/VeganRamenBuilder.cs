using BuilderAssignment.Builders;
using BuilderAssignment.Models;
using static BuilderAssignment.Models.RamenBowl;

namespace BuilderAssignment
{
    public class VeganRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        // - Setting broth
        [BrothType(BrothType.Vegan)]
        public void setBroth()
        {
            ramen.description += "BrothType : Vegan";
        }
        // - Setting noodles
        [NoodleType(NoodleType.Soba)]
        public void setNoodle()
        {
            ramen.description += ", NoodleType : Soba";
        }

        // - Adding toppings

        [Topping(Topping.BambooShoots & Topping.Seaweed)]
        public void addToppings()
        {
            ramen.description += ", Topping : BambooShoots & Seaweed";
        }

        // - Adding Extras
        [Extra()]
        public void addExtra()
        {
            ramen.description += "";
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
