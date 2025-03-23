using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300145
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (title == null || title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak boleh null dan maksimal 100 karakter.");
            }

            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                throw new ArgumentException("Penambahan play count maksimal 10.000.000 per panggilan");
            }

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }

            catch (OverflowException)
            {
                Console.WriteLine("Error: Overflow terjadi pada penambahan play count.");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            SayaTubeVideo videos = new SayaTubeVideo("Tutorial Design By Contract - Elvina Nilysti Huang");
            for (int i = 0; i < 3; i++)
            {
                videos.IncreasePlayCount(10000000);
                videos.PrintVideoDetails();
            }


            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Elvina Nilysti Huang");
                video.IncreasePlayCount(99999999);
                video.PrintVideoDetails();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
