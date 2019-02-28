namespace Units
{
    // those should be in separate files as well ;)
    public interface IMoveable
    {
        void Move();
    }

    public interface IShape
    {
        double Area();
    }

    public class Triangle : IShape, IMoveable
    {
        public double Area()
        {
            return 5 * 4 / 2;
        }

        public void Move()
        {
            // ??????
        }
    }

    public class Square : IShape
    {
        private int x;

        public double Area()
        {
            int aa = 5;
            int bb = 6;
            return 5 * 5;
        }
    }
}
