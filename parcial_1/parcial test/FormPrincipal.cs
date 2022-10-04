using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltaVuelo;
using AltaPasaje;
using AltaCliente;
using VistaPasajes;

namespace parcial_test
{
    public partial class FormPrincipal : Form
    {
        List<Vendedor> VendedoresList = new List<Vendedor>();
        List<Avion> AvionesList = Auxiliar.precargarAviones();
        List<Vuelo> VuelosList = new List<Vuelo>();
        List<Destino> DestinosList = new List<Destino>();
        List<Pasaje> PasajesList = new List<Pasaje>();
        List<Pasajero> PasajerosList = new List<Pasajero>();
        int indiceVuelo;

        public FormPrincipal(Vendedor vendedor)

        {
            InitializeComponent();


            lbl_bienvenidaUser.Text = $"Usuario: {vendedor.Nombre.ToString()}";
            DestinosList = Auxiliar.precargarDestinos();

          

            Vuelo vuelo = NucleoDelSistema.altaVuelo(AvionesList[0], DestinosList[2]);
            Vuelo vuelo2 = NucleoDelSistema.altaVuelo(AvionesList[1], DestinosList[14]);

            VuelosList.Add(vuelo);
            VuelosList.Add(vuelo2);
            dtg_vuelos.DataSource = VuelosList;
            dtg_aviones.DataSource = AvionesList;
        }

        private void btn_altaVuelo_Click(object sender, EventArgs e)
        {
            frm_altaVuelo auxAltaVuelo = new frm_altaVuelo(AvionesList, DestinosList);
            auxAltaVuelo.ShowDialog();
            if (auxAltaVuelo.VueloDadoDeAlta != null)
            {

                VuelosList.Add(auxAltaVuelo.VueloDadoDeAlta);
                dtg_vuelos.DataSource = null;
                dtg_vuelos.DataSource = VuelosList;

            }



        }

   

        private void principal_Load(object sender, EventArgs e)
        {


            lbl_Fecha.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'de' yyyy");

            VendedoresList = Vendedor.DevolverVendedores();

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dtg_vuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowSeleccionada = dtg_vuelos.CurrentRow.Index;
      

        }

        private void btn_AltaPasaje_Click(object sender, EventArgs e)
        {
            int rowSeleccionada = dtg_vuelos.CurrentRow.Index;
            Vuelo auxVuelo = VuelosList[rowSeleccionada];
            if (PasajerosList.Count == 0)
            {
                MessageBox.Show("no hay clientes para agregarles pasajes");

            }
            else
            {
                frm_AltaPasaje frm_AltaPasaje = new frm_AltaPasaje(auxVuelo, PasajerosList);
                frm_AltaPasaje.ShowDialog();
                Pasaje auxPasaje = frm_AltaPasaje.PasajeDadoDeAlta;
                if (auxPasaje != null)
                {
                    PasajesList.Add(auxPasaje);
                    auxVuelo.RecaudacionTotal = auxPasaje.Costo;
                    auxVuelo.CantidadAsientosPremiumDisponibles -= auxPasaje.CantidadAsientosPremiumComprados;
                    auxVuelo.CantidadAsientosTuristaDisponibles -= auxPasaje.CantidadAsientosTuristaComprados;
                    dtg_vuelos.DataSource = null;
                    dtg_vuelos.DataSource = VuelosList;
                }

            }


        }

        private void btn_AltaCliente_Click(object sender, EventArgs e)
        {
            frm_AltaPasajero auxAltaCliente = new frm_AltaPasajero(PasajerosList);
            auxAltaCliente.ShowDialog();
            Pasajero auxPasajero = auxAltaCliente.PasajeroDadoDeAlta;
            if (auxPasajero != null)
            {

                PasajerosList.Add(auxPasajero);
           

            }

        }

        private void dtg_aviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_flota_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vuelosDisponibles_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bienvenidaUser_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void lbl_UsuarioLogeado_Click(object sender, EventArgs e)
        {

        }

        private void btn_verPasajes_Click(object sender, EventArgs e)
        {
            if(PasajesList.Count ==0)
            {
                MessageBox.Show("No hay pasajes para mostrar");
            }
            else
            {
                frm_vistaPasajes vistaPasajes = new frm_vistaPasajes(PasajesList);
                vistaPasajes.ShowDialog();
            }
        }
    }
}
