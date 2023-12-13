using System;

namespace BuilderAssignment.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    /// 
    public class RamenBowl {
        public string description = "";

        //TODO#1: Add attributes for each enum in IngredientEnums.cs file
        public class BrothTypeAttribute : Attribute
        {
            public BrothType Broth { get; set; }
            public BrothTypeAttribute(BrothType brothType) 
            { 
                this.Broth = brothType;
            }
        }

        public class NoodleTypeAttribute : Attribute
        {
            public NoodleType noodleType { get; set; }
            public NoodleTypeAttribute(NoodleType noodleType) { this.noodleType = noodleType; }
        }

        public class ToppingAttribute : Attribute
        {
            public Topping topping { get; set; }
            public ToppingAttribute() { }
            public ToppingAttribute(Topping topping) { this.topping = topping; }
        }

        public class ExtraAttribute : Attribute
        {
            public Extra extra { get; set; }
            public ExtraAttribute() { }
            public ExtraAttribute(Extra extra) { this.extra = extra; }
        }

        //TODO#2: Return description of finished bowl of ramen
        public static string FinishedBowlOfRamen(RamenBowl ramen)
        {
            return ramen.description;
        }
    }
}