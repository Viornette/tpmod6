﻿using System;
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
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
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
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Elvina Nilysti Huang");
            video.PrintVideoDetails();
        }
    }
}
