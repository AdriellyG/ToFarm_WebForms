﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_insertTipoSolo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        TipoSolo tipo = new TipoSolo();

        tipo.Nome = txtNome.Text;
        tipo.Acidez = Convert.ToDouble(txtAcidez.Text);

        if (TipoSoloDB.Insert(tipo))
        {
            lbl.Text = "Cadastrado com sucesso!";
            txtNome.Text = "";
            txtAcidez.Text = "";
            txtNome.Focus();
        }
        else
            lbl.Text = "Erro!";

    }
}