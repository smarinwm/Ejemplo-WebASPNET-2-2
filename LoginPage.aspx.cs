using System;
using System.ServiceModel;
using System.Web;

namespace EjemploWebASPNET
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client servicio = new Connection().CrearConexion();
            if (servicio.VerificarAcceso(txt_Username.Text, txt_password.Text))
            {
                HttpContext.Current.Response.Redirect("DatosPage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario Incorrecto');</script>");
            }
        }
    }
}