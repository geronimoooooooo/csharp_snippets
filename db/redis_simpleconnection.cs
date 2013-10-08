using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServiceStack.Redis;
using ServiceStack.Text;
using ServiceStack.IO;

namespace Redis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            using (var redisClient = new RedisClient("researchstudio.at:6379"))
            {
                redisClient.SetEntry("name", "Michael Sarchet");

                 Make m = new Make();
                m.Id = 20;
                m.Name = "mname";

                redisClient.Store(m);

                // Read the file as one string. 
                string text = System.IO.File.ReadAllText(@"C:\dll\dipl_simo\io_geoJson_131008_matching.json");
                redisClient.SetEntry("file1", text);

                Thread.Sleep(2000); //Wait 6 seconds to prove we can expire our old Astra
                Byte []  barray =redisClient.Get("file1");

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                String response= enc.GetString(barray);

                System.Diagnostics.Debug.WriteLine("response:" + response);

                return;

                

                System.Diagnostics.Debug.WriteLine(redisClient.Get("name").ToString());


                var m2 = redisClient.GetAll<Make>();



                foreach (var car in m2)
                {
                    Console.WriteLine("Redis Has a ->" + m.Id);
                    System.Diagnostics.Debug.WriteLine("mid: " + m.Id);
                }

            }
            
            return;
            /*
            using (var cars = redisClient.GetType())
            {
                if (cars.GetAll().Count > 0)
                    cars.DeleteAll();

                var dansFord = new Car
                {
                    Id = cars.GetNextSequence(),
                    Title = "Dan's Ford",
                    Make = new Make { Name = "Ford" },
                    Model = new Model { Name = "Fiesta" }
                };
                var beccisFord = new Car
                {
                    Id = cars.GetNextSequence(),
                    Title = "Becci's Ford",
                    Make = new Make { Name = "Ford" },
                    Model = new Model { Name = "Focus" }
                };
                var vauxhallAstra = new Car
                {
                    Id = cars.GetNextSequence(),
                    Title = "Dans Vauxhall Astra",
                    Make = new Make { Name = "Vauxhall" },
                    Model = new Model { Name = "Asta" }
                };
                var vauxhallNova = new Car
                {
                    Id = cars.GetNextSequence(),
                    Title = "Dans Vauxhall Nova",
                    Make = new Make { Name = "Vauxhall" },
                    Model = new Model { Name = "Nova" }
                };

                var carsToStore = new List<object> { dansFord, beccisFord, vauxhallAstra, vauxhallNova };
                cars.StoreAll(carsToStore);

                Console.WriteLine("Redis Has-> " + cars.GetAll().Count + " cars");
                Console.WriteLine(cars.GetAll().Dump());

                cars.ExpireAt(vauxhallAstra.Id, DateTime.Now.AddSeconds(5)); //Expire Vauxhall Astra in 5 seconds

                Thread.Sleep(6000); //Wait 6 seconds to prove we can expire our old Astra

                Console.WriteLine("Redis Has-> " + cars.GetAll().Count + " cars");
                Console.WriteLine(cars.GetAll().Dump());

                //Get Cars out of Redis
                var carsFromRedis = cars.GetAll().Where(car => car.Make.Name == "Ford");

                foreach (var car in carsFromRedis)
                {
                    Console.WriteLine("Redis Has a ->" + car.Title);
                }

            }                      */

        }
    }



    public class Car
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
    }

    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Model
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public string Name { get; set; }
    }



}
