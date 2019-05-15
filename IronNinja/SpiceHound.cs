namespace IronNinja
{
    class SpiceHound: Ninja
    {

        public SpiceHound(string name) : base(name, 1200)
        {}

        public override void Consume(IConsumable item)
        {
            if(item.IsSpicy)
            {
                item.Calories -= 5;
            }
                

            base.Consume(item);
        }
    }
}