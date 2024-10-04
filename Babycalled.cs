using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaHuyHung_Buoi10
{
    public partial class Babycalled : Form
    {
        public Babycalled()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal[] animalArray = new Animal[3];
            animalArray[0] = new Cat();
            animalArray[1] = new Dog();
            animalArray[2] = new Bird();
            foreach (Animal animal in animalArray) { 
                Interface @interface = animal as Interface;
                if (@interface != null) {
                    MessageBox.Show($"{@interface.PrintOut()}");
                }

            }

        }
    }
}
