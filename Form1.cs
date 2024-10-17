﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class frmPrincipal : Form
    {
        //variaveis globais
        float n1, n2, n3, n4, media;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //Eventos
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dtData.Text = DateTime.Today.ToString();
            lblNome.Text = Program.usuario;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            resultado();
            mediaAluno();
        }

        //metodos
        public void resultado()
        {
            n1 = float.Parse(txtNota1.Text);
            n2 = float.Parse(txtNota2.Text);
            n3 = float.Parse(txtNota3.Text);
            n4 = float.Parse(txtNota4.Text);

            media = (n1 + n2 + n3 + n4) / 4;

            lblMedia.Text = media.ToString();
        }

        public void mediaAluno()
        {
            if (media < 7)
            {
                lblStatus.Text = "Reprovado";
            }
            else if (media == 7)
            {
                lblStatus.Text = "Aprovado com o minimo";
            }
            else 
            {
                lblStatus.Text = "Aprovado";
            }
        }
    }
}
