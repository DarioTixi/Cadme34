using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace CadmeNormas
{
    public partial class Form1 : Form
    {
        private Button botones;
         Ingreso login = new Ingreso();
        public Form1()
        {
            InitializeComponent();
            IniciarLosSubmenuOcultos();
            
         
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void CambiarColorBoton(object senderBtn,Color color) {
           
            if (senderBtn != null) {
                VolverColorOriginal();
                botones = (Button)senderBtn;
                botones.BackColor = Color.FromArgb(37, 36, 81);
                botones.ForeColor = color;
            }
        }
        private void VolverColorOriginal() {
            if (botones != null) {
                botones.BackColor = Color.FromArgb(23, 20,26);
                botones.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private struct RGBColors {

            public static Color color1 = Color.FromArgb(172,126,241);
        }


      
       
        private void OcultarLosSubmenu()
        {
            if (SubMenuL1.Visible == true)
                SubMenuL1.Visible = false;
            if (SubMenuL2.Visible == true)
                SubMenuL2.Visible = false;
            if (SubMenuL3.Visible == true)
                SubMenuL3.Visible = false;
            if (SubMenuL4.Visible == true)
                SubMenuL4.Visible = false;
            if (SubMenuL5.Visible == true)
                SubMenuL5.Visible = false;
            if (SubMenuL6.Visible == true)
                SubMenuL6.Visible = false;
            if (SubMenuL7.Visible == true)
                SubMenuL7.Visible = false;
            if (SubMenuM1.Visible == true)
                SubMenuM1.Visible = false;
            if (SubMenuM2.Visible == true)
                SubMenuM2.Visible = false;
            if (SubMenuM3.Visible == true)
                SubMenuM3.Visible = false;
            if (SubMenuN1.Visible == true)
                SubMenuN1.Visible = false;
            if (SubMenuN2.Visible == true)
                SubMenuN2.Visible = false;
            if (SubMenuN3.Visible == true)
                SubMenuN3.Visible = false;
            if (SubMenuO1.Visible == true)
                SubMenuO1.Visible = false;
            if (SubMenuO2.Visible == true)
                SubMenuO2.Visible = false;
            if (SubMenuO2.Visible == true)
                SubMenuO2.Visible = false;
            if (SubMenuO3.Visible == true)
                SubMenuO3.Visible = false;
            if (SubMenuO4.Visible == true)
                SubMenuO4.Visible = false;
            if (SubMenuT.Visible == true)
                SubMenuT.Visible = false;

        }

        private void IniciarLosSubmenuOcultos(){
            SubMenuL1.Visible = false;
            SubMenuL2.Visible = false;
            SubMenuL3.Visible = false;
            SubMenuL4.Visible = false;
            SubMenuL5.Visible = false;
            SubMenuL6.Visible = false;
            SubMenuL7.Visible = false;
            SubMenuM1.Visible = false;
            SubMenuM2.Visible = false;
            SubMenuM3.Visible = false;
            SubMenuN1.Visible = false;
            SubMenuN2.Visible = false;
            SubMenuN3.Visible = false;
            SubMenuO1.Visible = false;
            SubMenuO2.Visible = false;
            SubMenuO3.Visible = false;
            SubMenuO4.Visible = false;
            SubMenuT.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                OcultarLosSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void L1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuL1);
        }

       

        private void L2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuL2);
        }
        private void buttonL3_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuL3);
        }

        private void buttonL4_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuL4);
        }

        private void buttonL5_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuL5);
        }

        private void buttonL6_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuL6);
        }

        private void buttonL7_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuL7);
        }

        private void buttonM1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuM1);
        }

        private void buttonM2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuM2);
        }

        private void buttonM3_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuM3);
        }

        private void buttonN1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuN1);
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuN2);
        }

        private void buttonN3_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuN3);
        }

        private void buttonO1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuO1);
        }

        private void buttonO2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuO2);
        }

        private void buttonO3_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuO3);
        }

        private void buttonO4_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuO4);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubMenuT);
        }

        private void LimpiarTexto() {
            Norma1.Text = "";
            Norma2.Text = "";
            Norma3.Text = "";
            Norma4.Text = "";
            Texto1.Text = "";
            Texto2.Text = "";
            Texto3.Text = "";
            Texto4.Text = "";
            Texto5.Text = "";
            Texto6.Text = "";
            Norma5.Text = "";
            Norma6.Text = "";
            Titulo.Text = "";

        }

        private void buttonL11_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender,RGBColors.color1);
            LimpiarTexto();
         //  MostrarCuadros();
            Titulo.Text = "1. Dispositivos de alumbrado y de señalizacion luminosa.";
            Texto1.Text = "Vehículos automotores. Dispositivos para mantener o mejorar la visibilidad.";
            Norma1.Text = "NTE INEN 1155";
            Texto2.Text = "ONU. Disposiciones Relativas Uniformes a la aprobación lámparas frontales y traseras de posición, lamparas de freno y lámparas marcadoras de fin para vehículos motorizados(excepto motocicletas) y sus remolques.";
            Norma2.Text = "UN 7";
         //   SIesstavacio();
         //  OcultarLosSubmenu();
        }

     

        private void buttonL13_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaFrenado();
        }

        private void SistemaFrenado()
        {

            LimpiarTexto();
           // MostrarCuadros();
            Titulo.Text = "3. Frenos";
            Texto1.Text = "Sistema de Frenado.";
            Norma1.Text = "UN 13-H";
           // SIesstavacio();
            // OcultarLosSubmenu();
        }

        private void buttonL16_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();     

        }

        private void SistemaSuspension()
        {
            LimpiarTexto();
            //MostrarCuadros();
            Titulo.Text = "6. Suspensión";
            Texto1.Text = "Suspensión: Los vehículos automotores deben disponer de un sistema de suspensión con elementos amortiguadores en todos sus ejes o ruedas, no se admiten las modificaciones a las suspensiones originales que se provean en el vehículo.";
           // SIesstavacio();
          //  OcultarLosSubmenu();
        }

        private void buttonL17_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionIncompleto();
        }

        private void DireccionIncompleto()
        {
            LimpiarTexto();
           // MostrarCuadros();
            Titulo.Text = "7. Dirección";
            Texto1.Text = "Los vehículos automotores deben disponer de un sistema de dirección asistida, prohibiéndose modificaciones al sistema original provisto por el fabricante.";
            Norma1.Text = "";
           // SIesstavacio();
           // OcultarLosSubmenu();
        }

        private void buttonL18_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void Vidrios()
        {
            LimpiarTexto();
            //MostrarCuadros();
            Titulo.Text = "8. Vidrios";
            Texto1.Text = "Vidrios de seguridad para automotores. Requisitos.";
            Norma1.Text = "RTE INEN 084";
            Texto2.Text = "ONU.- Disposiciones uniformes concernientes a la aprobación de materiales de cristales de seguridad y su instalación en vehículos.";
            Norma2.Text = "UN 43";
            //SIesstavacio();
           // OcultarLosSubmenu();
        }

        private void buttonL21_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1();
        }
        private void llenarCon1() {
            LimpiarTexto();
            Titulo.Text = "1. Dispositivos de alumbrado y de señalizacion luminosa";
            Texto1.Text = "Vehículos automotores. Dispositivos para mantener o mejorar la visibilidad.";
            Norma1.Text = "NTE INEN 1155";
            Texto2.Text = "ONU. Disposiciones Relativas Uniformes a la aprobación lámparas frontales y traseras de posición, lamparas de freno y lámparas marcadoras de fin para vehículos motorizados(excepto motocicletas) y sus remolques.";
            Norma2.Text = "UN 7";
           // OcultarLosSubmenu();
        }
        private void llenarCon1Completa()
        {
            LimpiarTexto();
            Titulo.Text = "1. Dispositivos de alumbrado y de señalizacion luminosa";
            Texto1.Text = "Vehículos automotores. Dispositivos para mantener o mejorar la visibilidad.";
            Norma1.Text = "NTE INEN 1155";
            Texto2.Text = "ONU. Dispositivos Relativas Uniformes a la aprobación de vehículos en lo referente a iluminación y dispositivos de señalización luminosa.";
            Norma2.Text = "UN 48";
            Texto3.Text = "ONU. Disposiciones Relativas Uniformes a la aprobación lámparas frontales y traseras de posición, lamparas de freno y lámparas marcadoras de fin para vehículos motorizados(excepto motocicletas) y sus remolques.";
            Norma3.Text = "UN 7";
           // OcultarLosSubmenu();
        }

        private void buttonL22_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            L22Incompleto();
          
        }

        private void L22Incompleto()
        {
            LimpiarTexto();
            Titulo.Text = "2. Asientos y sus anclajes";
            Texto1.Text = "Disposiciones Relativas Uniformes a la aprobación de apoya cabezas(reposacabezas), incorporados o no en asientos de vehículos.";
            Norma1.Text = "UN 25";
            Texto2.Text = "Apoya cabezas.";
            Norma2.Text = "GTR 7";
           // OcultarLosSubmenu();
        }

        private void buttonL23_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaFrenado();
        }

        private void buttonL26_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonL28_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonL29_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonL31_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1();
        }

        private void buttonL33_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaFrenado();
        }

        private void buttonL36_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonL37_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionIncompleto();
        }

        private void buttonL38_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonL41_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1();
        }

        private void buttonL42_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            L22Incompleto();
        }

        private void buttonL43_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaFrenado();
        }

        private void buttonL46_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonL47_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionIncompleto();
        }

        private void buttonL48_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonL49_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonL51_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1();
        }

        private void buttonL52_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            L22Incompleto();
        }

        private void buttonL53_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaFrenado();
        }

        private void buttonL56_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonL57_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionIncompleto();
        }

        private void buttonL58_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonL59_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonL61_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1();
        }

        private void buttonL62_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            L22Incompleto();
        }

        private void buttonL63_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaFrenado();
            
        }

        private void buttonL66_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonL67_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionIncompleto();
        }

        private void buttonL68_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonL69_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
           
        }

        private void CinturonDeSeguridadIncompleto()
        {
            LimpiarTexto();
            Titulo.Text = "9. Cinturones de Seguridad";
            Texto1.Text = "ONU. Prescripciones uniformes relativas a la aprobación de cinturones de seguridad, sistemas de retención, sistemas de retención infantil y sistemas de retención infantil ISOFIX para ocupantes de vehículos de motor.";
            Norma1.Text = "UN 16";
         //   OcultarLosSubmenu();
        }

        private void buttonL71_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1();
        }

        private void buttonL72_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            L22Incompleto();
        }

        private void buttonL73_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaFrenado();
        }

        private void buttonL76_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonL77_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionIncompleto();
        }

        private void buttonL78_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonL79_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonM11_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonM12_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "2. Asientos y sus anclajes";
            Texto1.Text = "Disposiciones Relativas Uniformes a la aprobación de apoya cabezas (reposacabezas), incorporados o no en asientos de vehículos.";
            Norma1.Text = "UN 25";
            Texto2.Text = "Apoya cabezas";
            Norma2.Text = "GTR 7";
            Texto3.Text = "Asientos, anclajes y apoya cabezas";
            Norma3.Text = "UN 17";
            Texto4.Text = "Respaldos y desplazamiento de equipaje";
            Norma4.Text = "UN 17";
            Texto5.Text = "ONU. Prescripciones Uniformes relativas a la aprobación de los vehículos en lo que concierne a los anclajes de los cinturones de seguridad.";
            Norma5.Text = "UN 14";
            Texto6.Text = "Prescripciones Uniformes relativas a la aprobación de los vehículos en lo que concierne a anclajes ISOFIX y los anclajes superiores ISOFIX.";
            Norma6.Text = "UN 14";
          //  OcultarLosSubmenu();
        }

        private void buttonM13_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "3. Frenos";
            Texto1.Text = "ONU. Disposiciones uniformes sobre la aprobación de los vehículos automóviles de pasajeros en lo relativo al frenado.";
            Norma1.Text = "UN 13-H";
            Texto2.Text = "ONU. ABS obligatorio conforme con lo que establezca la Reglamentación Técnica No. 13 H de la ONU.";
            Norma2.Text = "UN 13-H";
            Texto3.Text = "ONU. Disposiciones uniformes relacionadas con la aprobación de vehículos de categorías M, N y O con relación al sistema de frenos.";
            Norma3.Text = "UN 13";           
           // OcultarLosSubmenu();
        }

        private void buttonM14_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            ControlElectrico();
        }

        private void ControlElectrico()
        {
           
            LimpiarTexto();
            Titulo.Text = "4. Control electrónico de estabilidad";
            Texto1.Text = "Control electrónico de estabilidad conforme a lo establecido por el Reglamento Técnico Global GT R8 Sistemas Electrónicos ONU – Control de Estabilidad ESC.";
            Norma1.Text = "GTR 8";
            Texto2.Text = "Control electrónico de estabilidad conforme a lo establecido por la Reglamentación Técnica No. 13 - H de la ONU.";
            Norma2.Text = "UN 13-H";
          //  OcultarLosSubmenu();
        }

        private void buttonM15_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosArriba();
        }

        private void NeumaticosArriba()
        {
            LimpiarTexto();
            Titulo.Text = "5. Neumáticos";
            Texto1.Text = "ONU Disposiciones uniformes concernientes a la aprobación de neumáticos para vehículos motorizados y sus remolques.";
            Norma1.Text = "UN 30";
           // OcultarLosSubmenu();
        }

        private void buttonM16_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonM17_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void DireccionCompleto()
        {

            LimpiarTexto();
            Titulo.Text = "7. Dirección";
            Texto1.Text = "Los vehículos automotores deben disponer de un sistema de dirección asistida, prohibiéndose modificaciones al sistema original provisto por el fabricante.";
            Norma1.Text = "";
            Texto2.Text = "ONU. Disposiciones uniformes concernientes a la aprobación de vehículos en referencia a su equipamiento de dirección.";
            Norma2.Text = "UN 79";
          //  OcultarLosSubmenu();
        }

        private void buttonM18_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonM19_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "9. Cinturones de Seguridad";
            Texto1.Text = "Cinturón de seguridad de tres puntos en todas las plazas de todos los vehículos.";
            Norma1.Text = "";
            Texto2.Text = "ONU. Prescripciones uniformes relativas a la aprobación de cinturones de seguridad, sistemas de retención, sistemas de retención infantil y sistemas de retención infantil ISOFIX para ocupantes de vehículos de motor.";
            Norma2.Text = "UN 16";
            Texto3.Text = "NU. Prescripción uniformes relativas a la aprobación de: sistemas de retención infantil y sistemas de retención infantil ISOFIX.";
            Norma3.Text = "UN 16";
           // OcultarLosSubmenu();
        }

        private void buttonM110_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Parachoque();           

        }

        private void Parachoque()
        {
            LimpiarTexto();
            Titulo.Text = "10. Parachoque frontal y posterior";
            Texto1.Text = "ONU. Seguridad de peatones.";
            Norma1.Text = "GTR 9";
            Texto2.Text = "ONU. Disposiciones uniformes sobre la aprobación de vehículos automóviles en lo relativo al desempeño de seguridad de peatones.";
            Norma2.Text = "UN 127";
          //  OcultarLosSubmenu();
        }

        private void buttonM111_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "11. Protección para impacto frontal y lateral";
            Texto1.Text = "ONU. Prescripciones uniformes sobre la aprobación de los vehículos en lo relativo a la protección de sus ocupantes en caso de colisión frontal.";
            Norma1.Text = "UN 94";
            Texto2.Text = "ONU. Prescripciones uniformes sobre la aprobación de los vehículos en lo relativo a la protección de sus ocupantes en caso de colisión lateral.";
            Norma2.Text = "UN 95";
           // OcultarLosSubmenu();

        }

        private void buttonM112_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "12. Bolsas de aire(AIR BAGS)";
            Texto1.Text = "ONU. Prescripciones uniformes sobre la aprobación de los vehículos en lo relativo a la protección de sus ocupantes en caso de colisión frontal.";
            Norma1.Text = "UN 94";
            Texto2.Text = "";
            Norma2.Text = "";
           // OcultarLosSubmenu();
        }

        private void buttonM113_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "13. Avisador acústico de uso de cinturón";
            Texto1.Text = "Avisador acústico de uso de cinturón. ONU.- Prescripciones uniformes relativas a la aprobación de: Recordatorio de cinturones de seguridad.";
            Norma1.Text = "UN 16";
            Texto2.Text = "";
            Norma2.Text = "";
          //  OcultarLosSubmenu();
        }

        private void buttonM21_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonM22_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "2. Asientos y sus anclajes";
            Texto1.Text = "Disposiciones Relativas Uniformes a la aprobación de apoya cabezas (reposacabezas), incorporados o no en asientos de vehículos.";
            Norma1.Text = "UN 25";
            Texto2.Text = "Apoya cabezas";
            Norma2.Text = "GTR 7";         
            Texto3.Text = "Asientos, anclajes y apoya cabezas no cubierto por Norma UN 80 (por casos técnicos particulares).";
            Norma3.Text = "UN 17";
            Texto4.Text = "ONU. Prescripciones uniformes relativas a la aprobación de asientos de vehículos de grandes dimensiones para el transporte de pasajeros y de estos vehículos por lo que respecta a la resistencia de los asientos y de sus anclajes.";
            Norma4.Text = "UN 80";
            Texto5.Text = "ONU. Prescripciones Uniformes relativas a la aprobación de los vehículos en lo que concierne a los anclajes de los cinturones de seguridad.";
            Norma5.Text = "UN 14";
            //OcultarLosSubmenu();
        }

        private void buttonM23_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "3. Frenos";
            Texto1.Text = "ONU. Disposiciones uniformes relacionadas con la aprobación de vehículos de categorías M, N y O con relación al sistema de frenos.";
            Norma1.Text = "UN 13";
            Texto2.Text = "";
            Norma2.Text = "";
            //OcultarLosSubmenu();
        }

        private void buttonM25_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "5. Neumáticos";
            Texto1.Text = "ONU Disposiciones uniformes concernientes a la aprobación de neumáticos para vehículos motorizados y sus remolques.";
            Norma1.Text = "UN 30";
            Texto2.Text = "ONU. Disposiciones uniformes concernientes a la aprobación de neumáticos para vehículos comerciales y sus remolques.";
            Norma2.Text = "UN 54";
           // OcultarLosSubmenu();
           
        }

        private void NeumaticosAbajo()
        {
            LimpiarTexto();
            Titulo.Text = "5. Neumáticos";
            Texto1.Text = "ONU. Disposiciones uniformes concernientes a la aprobación de neumáticos para vehículos comerciales y sus remolques.";
            Norma1.Text = "UN 54";
            //OcultarLosSubmenu();
        }

        private void buttonM26_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonM27_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonM28_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonM29_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "9. Cinturones de Seguridad";
            Texto1.Text = "ONU. Prescripciones uniformes relativas a la aprobación de cinturones de seguridad, sistemas de retención, sistemas de retención infantil y sistemas de retención infantil ISOFIX para ocupantes de vehículos de motor.";
            Norma1.Text = "UN 16";
            Texto2.Text = "ONU. Prescripción uniformes relativas a la aprobación de: sistemas de retención infantil y sistemas de retención infantil ISOFIX.";
            Norma2.Text = "UN 16";
           // OcultarLosSubmenu();
        }

        private void buttonM31_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonM32_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "2. Asientos y sus anclajes";
            Texto1.Text = "Disposiciones Relativas Uniformes a la aprobación de apoya cabezas (reposacabezas), incorporados o no en asientos de vehículos.";
            Norma1.Text = "UN 25";
            Texto2.Text = "Apoya cabezas";
            Norma2.Text = "GTR 7";
            Texto3.Text = "Asientos, anclajes y apoya cabezas no cubierto por Norma UN 80 (por casos técnicos particulares).";
            Norma3.Text = "UN 17";
            Texto4.Text = "ONU. Prescripciones uniformes relativas a la aprobación de asientos de vehículos de grandes dimensiones para el transporte de pasajeros y de estos vehículos por lo que respecta a la resistencia de los asientos y de sus anclajes.";
            Norma4.Text = "UN 80";
            Texto5.Text = "ONU. Prescripciones Uniformes relativas a la aprobación de los vehículos en lo que concierne a los anclajes de los cinturones de seguridad.";
            Norma5.Text = "UN 14";
            //OcultarLosSubmenu();

        }

        private void buttonM33_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            FrenosUno();         
        }

        private void FrenosUno()
        {
            LimpiarTexto();
            Titulo.Text = "3. Frenos";
            Texto1.Text = "ONU. Disposiciones uniformes relacionadas con la aprobación de vehículos de categorías M, N y O con relación al sistema de frenos.";
            Norma1.Text = "UN 13";
           // OcultarLosSubmenu();
        }

        private void buttonM35_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosAbajo();
        }

        private void buttonM36_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonM37_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonM38_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonM39_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "9. Cinturones de Seguridad";
            Texto1.Text = "ONU. Prescripciones uniformes relativas a la aprobación de cinturones de seguridad, sistemas de retención, sistemas de retención infantil y sistemas de retención infantil ISOFIX para ocupantes de vehículos de motor.";
            Norma1.Text = "UN 16";
            Texto2.Text = "ONU. Prescripción uniformes relativas a la aprobación de: sistemas de retención infantil y sistemas de retención infantil ISOFIX.";
            Norma2.Text = "UN 16";
            //OcultarLosSubmenu();
        }

        private void buttonM314_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "14. Tacógrafo";
            Texto1.Text = "TACOGRAFO";
            Norma1.Text = "";
            //OcultarLosSubmenu();
        }

        private void buttonN14_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonN12_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "2. Asientos y sus anclajes";
            Texto1.Text = "Disposiciones Relativas Uniformes a la aprobación de apoya cabezas (reposacabezas), incorporados o no en asientos de vehículos.";
            Norma1.Text = "UN 25";
            Texto2.Text = "Apoya cabezas.";
            Norma2.Text = "GTR 7";
            Texto3.Text = "Asientos, anclajes y apoya cabezas.";
            Norma3.Text = "UN 17";
            Texto4.Text = "ONU. Prescripciones Uniformes relativas a la aprobación de los vehículos en lo que concierne a los anclajes de los cinturones de seguridad.";
            Norma4.Text = "UN 14";
            //OcultarLosSubmenu();
            
        }

        private void buttonN13_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "3. Frenos";
            Texto1.Text = "ONU. Disposiciones uniformes sobre la aprobación de los vehículos automóviles de pasajeros en lo relativo al frenado.";
            Norma1.Text = "UN 13-H";
            Texto2.Text = "ONU. ABS obligatorio conforme con lo que establezca la Reglamentación Técnica No. 13 H de la ONU.";
            Norma2.Text = "UN 13-H";
            Texto3.Text = "ONU. Disposiciones uniformes relacionadas con la aprobación de vehículos de categorías M, N y O con relación al sistema de frenos.";
            Norma3.Text = "UN 13";
            //OcultarLosSubmenu();
        }

        private void buttonN114_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            ControlElectrico();
        }

        private void buttonN15_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosAbajo();
        }

        private void buttonN16_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonN17_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonN18_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonN19_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "9. Cinturones de Seguridad";
            Texto1.Text = "Cinturón de seguridad de tres puntos en todas las plazas de todos los vehículos.";
            Norma1.Text = "";
            Texto2.Text = "ONU. Prescripciones uniformes relativas a la aprobación de cinturones de seguridad, sistemas de retención, sistemas de retención infantil y sistemas de retención infantil ISOFIX para ocupantes de vehículos de motor.";
            Norma2.Text = "UN 16";
            Texto3.Text = "ONU. Prescripción uniformes relativas a la aprobación de: sistemas de retención infantil y sistemas de retención infantil ISOFIX.";
            Norma3.Text = "UN 16";
           // OcultarLosSubmenu();
        }

        private void buttonN110_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Parachoque();
        }

        private void buttonN111_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "11. Protección para impacto frontal y lateral";
            Texto1.Text = "ONU. Prescripciones uniformes sobre la aprobación de los vehículos en lo relativo a la protección de sus ocupantes en caso de colisión lateral.";
            Norma1.Text = "UN 95";
            //OcultarLosSubmenu();
        }

        private void buttonN21_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonN22_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "2. Asientos y sus anclajes";
            Texto1.Text = "Disposiciones Relativas Uniformes a la aprobación de apoya cabezas (reposacabezas), incorporados o no en asientos de vehículos.";
            Norma1.Text = "UN 25";
            Texto2.Text = "Apoya cabezas.";
            Norma2.Text = "GTR 7";
            Texto3.Text = "Asientos, anclajes y apoya cabezas.";
            Norma3.Text = "UN 17";
            Texto4.Text = "ONU. Prescripciones Uniformes relativas a la aprobación de los vehículos en lo que concierne a los anclajes de los cinturones de seguridad.";
            Norma4.Text = "UN 14";
         //   OcultarLosSubmenu();
             }

        private void buttonN23_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            FrenosUno();
        }

        private void buttonN25_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosAbajo();
        }

        private void buttonN26_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonN27_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonN28_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonN29_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonN31_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonN32_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "2. Asientos y sus anclajes";
            Texto1.Text = "Disposiciones Relativas Uniformes a la aprobación de apoya cabezas (reposacabezas), incorporados o no en asientos de vehículos.";
            Norma1.Text = "UN 25";
            Texto2.Text = "Apoya cabezas.";
            Norma2.Text = "GTR 7";
            Texto3.Text = "Asientos, anclajes y apoya cabezas.";
            Norma3.Text = "UN 17";
            Texto4.Text = "ONU. Prescripciones Uniformes relativas a la aprobación de los vehículos en lo que concierne a los anclajes de los cinturones de seguridad.";
            Norma4.Text = "UN 14";
           // OcultarLosSubmenu();
        }

        private void buttonN33_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            FrenosUno();
        }

        private void buttonN35_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosAbajo();
        }

        private void buttonN36_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonN37_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonN38_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonN39_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonN314_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            LimpiarTexto();
            Titulo.Text = "14. Tacógrafo";
            Texto1.Text = "TACOGRAFO";
            Norma1.Text = "";
            //OcultarLosSubmenu();
        }

        private void buttonO11_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonO13_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            FrenosUno();
        }

        private void buttonO15_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosArriba();
        }

        private void buttonO16_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonO17_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonO18_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonO19_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonO21_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonO23_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            FrenosUno();
        }

        private void buttonO25_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosArriba();
        }

        private void buttonO26_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonO27_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonO28_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonO29_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonO31_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonO33_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            FrenosUno();
        }

        private void buttonO35_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosAbajo();
        }

        private void buttonO36_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonO37_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonO38_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonO39_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonO41_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1Completa();
        }

        private void buttonO43_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            FrenosUno();
        }

        private void buttonO45_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            NeumaticosAbajo();
        }

        private void buttonO46_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonO47_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionCompleto();
        }

        private void buttonO48_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonO49_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void buttonT1_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            llenarCon1();
        }

        private void buttonT6_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            SistemaSuspension();
        }

        private void buttonT7_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            DireccionIncompleto();
        }

        private void buttonT8_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            Vidrios();
        }

        private void buttonT9_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(sender, RGBColors.color1);
            CinturonDeSeguridadIncompleto();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();           
            login.Show();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {                       
                this.WindowState = FormWindowState.Maximized;         
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Cadme_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
