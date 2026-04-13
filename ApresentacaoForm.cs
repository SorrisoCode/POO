using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace POO
{
    internal class ApresentacaoForm: Form
    {
        //objeto label
        Label titulo01 = new Label();
        Label titulo02 = new Label();
        Automovel obj01 = new Automovel();

        //CONSTRUTOR
        public ApresentacaoForm()
        {
            this.Text = "Apresentação";
            this.Size = new Size(500, 500);
            titulo01.Text = "Apresentação de elementos em classe!!";
            titulo01.Font = new Font("Arial", 16);
            titulo01.AutoSize = true; //ajustar no comprimento do texto
            titulo01.Location = new Point(100, 100);
            //add MARCA a objeto 
            obj01.Marca = "Ford";
            titulo02.Location = new Point(105, 105);
            titulo02.AutoSize = true;
            titulo02.Text = obj01.Marca;
            //fazer o elemento exibir no form
            //array de controls
            Control[] elementos = { titulo01, titulo02 };
            this.Controls.AddRange(elementos);
            //this.Controls.Add(titulo02);
            //this.Controls.Add(titulo01);
        }
    }
}
