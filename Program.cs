namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { Name = "Areg", Age = 83 };
            User user2 = new User { Name = "Hovo", Age = 30 };

            using (Context db = new Context())
            {
                //Create
                //db.Users.AddRange(user1, user2);
                //db.SaveChanges();

                //Read
                var users = db.Users.ToList();
                foreach(User user in users)
                {
                    Console.WriteLine($"{user.Id}: {user.Name} - {user.Age}");
                }
            }

            //Update
            using(Context db = new Context()) 
            {
                var usersList = db.Users.ToList();
                User user = db.Users.Find(3);
                if(user != null)
                {
                    user.Name = "Poghos";
                    user.Age = 7;
                    db.SaveChanges();
                }
              

                foreach(User u in usersList)
                {
                    Console.WriteLine($"{u.Id}: {u.Name} - {u.Age}");
                }
            }
        }
    }
}