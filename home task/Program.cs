using System;
using AdminNamespace;
using NotificationNamespace;
using PostNamespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using UserNamespace;

namespace home_task
{
    
    class Program
    {
        static void Main(string[] args)
        {



            var fromAddress = new MailAddress("naranana123gt@gmail.com", "Anara");
            var toAddress = new MailAddress("naranana123gt@gmail.com", "Anara");
            const string fromPassword = "";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            Guid guid = Guid.NewGuid();
            DateTime dateTime = DateTime.Now;
            User user1 = new User { 
                Name ="nezrin",
                Surname ="rehimli",
                Age =16,
                Email ="NezrinRehimli@gmail.com",
                Id =guid,
                Password ="nezrin123"
                
            };
            User user2 = new User
            {
                Name = "Leyla",
                Surname = "Abdullayeva",
                Age = 22,
                Email = "LeylaAbdullayeva@gmail.com",
                Id = guid,
                Password = "leyla123"

            };
            User[] Users = { user1, user2 };
            Notification notification1 = new Notification
            {
                Date = dateTime ,
                FromUser =user1,
                Id =guid,
                Text ="hello"
            };
            Notification notification2 = new Notification
            {
                Date = dateTime,
                FromUser = user2,
                Id = guid,
                Text = "hello"
            };
            Post post1 = new Post
            {
                Id=guid,
                Content ="hello",
                CreationDateTime =dateTime ,
                LikeCount =5,
                ViewCount =4
            };
            Post post2 = new Post
            {
                Id = guid,
                Content = "hello",
                CreationDateTime = dateTime,
                LikeCount = 3,
                ViewCount = 1
            };
            Post[] posts = { post1, post2 };
            Notification[] notifications = { notification1, notification2 };
            Admin admin = new Admin
                {
                    Id = guid,
                    Email = "naranana123gt@gmail.com",
                    NotificationCount = 4,
                    Username ="anaraugurlu",
                    Password ="sj123",
                    PostCount =5,
                    Notifications =notifications ,
                    Posts=posts
                    
                    
                };
            Console.WriteLine("1-User or 2-Admin");

            bool isInt = char.TryParse(Console.ReadLine(), out char result);
            if (result == 1)
            {
                Console.WriteLine("include  name");
                bool isUsername = char.TryParse(Console.ReadLine(), out char username);
                Console.WriteLine("include password");
                bool isuserPassword = char.TryParse(Console.ReadLine(), out char userpassword);
                foreach (var item in Users)
                {
                    if(item.Name ==username.ToString ()&&item.Password ==userpassword.ToString ())
                    {
                        item.ToString();
                    }
                }
            }
            else if (result == 2)
            {
                Console.WriteLine("include  username");
            bool isAdminname = char.TryParse(Console.ReadLine(), out char adminname);
                Console.WriteLine("include password");
                bool isAdminPassword = char.TryParse(Console.ReadLine(), out char adminpassword);
if(adminname.ToString () ==admin .Username&&adminpassword .ToString ()==admin.Password )
                {
                    admin.ToString();
                }
            }

            //Post post = new Post
            //{
            //    Id=
            //};
        }
    }

}
 