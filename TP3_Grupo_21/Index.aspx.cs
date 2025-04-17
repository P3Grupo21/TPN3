using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_Grupo_21
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarLocalidad_Click(object sender, EventArgs e)
        {
            
            if (ddlLocalidades.Items.Contains(new ListItem(txtNombreLocalidad.Text)))
            {
                lblMensaje.Text = "La localidad ya existe"; 
                lblMensaje.ForeColor = System.Drawing.Color.Red; 
                return;
            }

            ddlLocalidades.Items.Add(txtNombreLocalidad.Text);
            
            txtNombreLocalidad.Text = "";
           
            lblMensaje.Text = "Localidad guardada exitosamente";
            lblMensaje.ForeColor = System.Drawing.Color.Green;
        }
    }
}