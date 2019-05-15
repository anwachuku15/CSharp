using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public SweetTooth(string name) : base(name, 1500)
        {}
        
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if(item.IsSweet)
            {
                calorieIntake += 10;
            }
            base.Consume(item);
        }
    }

}