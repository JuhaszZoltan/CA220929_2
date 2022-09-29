namespace CA220929_2
{
    public class Ember
    {
        private int _eletkor;

        public int Eletkor
        {
            set
            {
                if (value < 0)
                    throw new Exception(
                        message: "Az ember életkora nem lehet kevesebb, mint 0");
                if (value > 100)
                    throw new Exception(
                        message: "Az ember életkora nem lehet több, mintt 100!");
                _eletkor = value;
            }
            get
            {
                return _eletkor;
            }
        }

        //public void SetEletkor(int eletkor)
        //{
        //    if (eletkor < 0)
        //        throw new Exception("az életkor nem lehet kisebb, mint 0!");
        //    if (eletkor > 100)
        //        throw new Exception("az életkor nem lehet nagyobb, mint 100!");
        //    _eletkor = eletkor;
        //}
        //public int GetEletkor()
        //{
        //    return _eletkor;
        //}
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Ember e = new();

            //set része fut le a property-nek
            e.Eletkor = 200;

            //get része fut le a propertynek
            Console.WriteLine(e.Eletkor);
            
            //e.SetEletkor(20);
            //e.SetEletkor(e.GetEletkor() + 1);
            //Console.WriteLine($"Ember életkora: {e.GetEletkor()}");

        }
    }


}