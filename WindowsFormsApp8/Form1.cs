using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp8.Form1;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            dog.makesound();
            dog.run();
            dog.speak();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fish fish = new Fish();
            fish.makesound();
            fish.swim();
            fish.speak();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bird bird = new bird();
            bird.makesound();
            bird.fly();
            bird.speak();
        }
    }


    public abstract class animal
    {
        public string kind { get; set; }
        public abstract void makesound();
    }


    public class Dog : animal, Irun
    {

        public override void makesound()
        {
            Console.WriteLine("hoohohoho");
        }
        public void run()
        {
            Console.WriteLine("iruning");
        }
    }

    public class Fish : animal, Iswim
    {
        public override void makesound()
        {
            Console.WriteLine("im fishing");
        }

        public void swim()
        {
            Console.WriteLine("im fishing");
        }
    }
    public class bird : animal, Ifly
    {
        public override void makesound()
        {
            Console.WriteLine("im flying");
        }

        public void fly()
        {
            Console.WriteLine("im flying");
        }
    }
    public interface Iswim
    {
        void swim();
    }
    public interface Irun
    {
        void run();
    }
    public interface Ifly
    {
        void fly();
    }
    public static class extinon
    {
        public static void speak(this animal animal)
        {
            Console.WriteLine("hello");
        }
    }
}

       