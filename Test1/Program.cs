using Test1.Models;
using Test1.View;

namespace Test1
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = RegisterUser();

            if (user != null)
            {
                Console.Clear();

                bool loggedInFailed = true;
                int Attempts = 0;

                do
                {
                    Console.Clear();
                    User loggedInUser = Loggin();
                    if (loggedInUser.Password == user.Password && loggedInUser.Username == user.Username)
                    {
                        Console.Clear();
                        Collection collection = CollectionInformation();
                        Console.Clear();
                        Delivery delivery = DeliveryInformation();
                        Console.Clear();
                        Parcel parcel = ParcelInformation();
                        Console.Clear();

                        CheckoutSummary checkoutSummary = new CheckoutSummary();

                        checkoutSummary.CollectionInformation = collection;
                        checkoutSummary.ParcelInformation = parcel;
                        checkoutSummary.DeliveryInformation = delivery;


                        checkoutSummaryInformation(checkoutSummary);

                        loggedInFailed = false;
                    }
                    else
                    {
                        Attempts++;
                    }

                    if (Attempts > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("You have reached your number of attempts : ");
                        Console.WriteLine("Enter R to retry again or C to create a new username and password : ");

                        var input = Console.ReadLine();

                        if (input.Equals("R"))
                        {
                            Attempts = 0;
                            continue;
                        }

                        if (input.Equals("C"))
                        {
                           Console.Clear();
                           var  ResetUser = RegisterUser();
                           continue;
                        }
                    }
                } while (loggedInFailed);

            }
            Console.ReadLine();
        }

        public static User RegisterUser()
        {
            RegisterView registerView = new RegisterView();
            return registerView.Register();
        }

        public static User Loggin()
        {
            RegisterView registerView = new RegisterView();
            return registerView.Login();
        }

        public static Collection CollectionInformation()
        {
            CollectionView collection = new CollectionView();
            return collection.CollectionCapture();
        }

        public static Delivery DeliveryInformation()
        {
            DeliveryView deliveryView = new DeliveryView();
            return deliveryView.CaptureDelivery();
        }

        public static Parcel ParcelInformation()
        {
            ParcelView parcelView = new ParcelView();
            return parcelView.CaptureParcelInformation();
        }

        public static void checkoutSummaryInformation(CheckoutSummary checkoutSummary)
        {
            CheckOutSummartView checkOutSummartView = new CheckOutSummartView(checkoutSummary);
            checkOutSummartView.CheckoutSummary();

        }
    }
}