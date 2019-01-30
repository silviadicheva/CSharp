namespace House
{
    class House : Building
    {
        public Person Owner { get; set; }
        private Room[] rooms;

        public House(Room[] rooms, double height, string color, Person owner)
            : base(height, color)
        {
            this.rooms = rooms;
            Owner = owner;
        }

        public override double Area
        {
            get
            {
                double area = 0;
                for (int i = 0; i < rooms.Length; i++)
                {
                    area += rooms[i].Area;
                }
                return area;
            }
        }
    }
}
