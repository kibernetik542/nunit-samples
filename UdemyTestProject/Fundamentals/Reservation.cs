namespace UdemyTestProject.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { private get; set; }

        public bool CanBeCancelledBy(User user) => (user.IsAdmin || MadeBy == user);
    }
}