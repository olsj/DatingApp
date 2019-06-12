namespace DatingApp.API
{
    public class Calculator {

        public int result { get; set; }

        public static int Calc (int incomingValue) {
            return incomingValue * 20;
        }
    }
}
