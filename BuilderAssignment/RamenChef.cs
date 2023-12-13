using BuilderAssignment.Builders;                                                                                                                                                                              
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.setBroth();
            builder.setNoodle();
            builder.addToppings();
            builder.addExtra();

            RamenBowl buildBowl = builder.GetRamen();
            
            return buildBowl; //TODO#2: Finaly return build bowl of ramen
        }
    }
}