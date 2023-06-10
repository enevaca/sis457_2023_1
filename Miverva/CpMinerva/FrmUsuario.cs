using CadMinerva;
using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinerva
{
    public partial class FrmUsuario : Form
    {
        bool esNuevo = false;
        public FrmUsuario()
        {
            InitializeComponent();
            txtNombres.KeyPress += Util.onlyLetters;
            txtPrimerApellido.KeyPress += Util.onlyLetters;
            txtSegundoApellido.KeyPress += Util.onlyLetters;
            txtCelular.KeyPress += Util.onlyNumbers;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Size = new Size(981, 439);
            cargarCargos();
            listar();
            dtpFechaNacimiento.MinDate = DateTime.Now.AddYears(-65);
            dtpFechaNacimiento.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void cargarCargos()
        {
            cbxCargo.DataSource = CargoCln.listar();
            cbxCargo.DisplayMember = "descripcion";
            cbxCargo.ValueMember = "descripcion";
            //cbxCargo.ValueMember = "id";
        }

        private void listar()
        {
            var usuarios = UsuarioCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = usuarios;
            dgvLista.Columns["idEmpleado"].Visible = false;
            dgvLista.Columns["idUsuario"].Visible = false;
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "C.I.";
            dgvLista.Columns["nombre"].HeaderText = "Nombres";
            dgvLista.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvLista.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvLista.Columns["direccion"].HeaderText = "Dirección";
            dgvLista.Columns["celular"].HeaderText = "Celular";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["fechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dgvLista.Columns["usuario"].HeaderText = "Usuario";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = usuarios.Count > 0;
            btnEliminar.Enabled = usuarios.Count > 0;
            if (usuarios.Count > 0) dgvLista.Rows[0].Cells["cedulaIdentidad"].Selected = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(981, 598);
            txtCedulaIdentidad.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(981, 598);

            int index = dgvLista.CurrentCell.RowIndex;
            int idEmpleado = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
            var empleado = EmpleadoCln.get(idEmpleado);
            txtCedulaIdentidad.Text = empleado.cedulaIdentidad;
            txtNombres.Text = empleado.nombre;
            txtPrimerApellido.Text = empleado.primerApellido;
            txtSegundoApellido.Text = empleado.segundoApellido;
            txtDireccion.Text = empleado.direccion;
            txtCelular.Text = empleado.celular.ToString();
            cbxCargo.Text = empleado.cargo;
            dtpFechaNacimiento.Value = empleado.fechaNacimiento.Value;

            int idUsuario = Convert.ToInt32(dgvLista.Rows[index].Cells["idUsuario"].Value);
            var usuario = UsuarioCln.get(idUsuario);
            txtUsuario.Text = usuario.usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(981, 439);
            limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool validar()
        {
            bool esValido = true;
            erpCedulaIdentidad.SetError(txtCedulaIdentidad, "");
            erpNombres.SetError(txtNombres, "");
            erpApellidos.SetError(txtPrimerApellido, "");
            erpApellidos.SetError(txtSegundoApellido, "");
            erpDireccion.SetError(txtDireccion, "");
            erpCelular.SetError(txtCelular, "");
            erpCargo.SetError(cbxCargo, "");
            erpUsuario.SetError(txtUsuario, "");

            if (string.IsNullOrEmpty(txtCedulaIdentidad.Text))
            {
                erpCedulaIdentidad.SetError(txtCedulaIdentidad, "El campo CI es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                erpNombres.SetError(txtNombres, "El campo Nombre es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text) && string.IsNullOrEmpty(txtSegundoApellido.Text))
            {
                erpApellidos.SetError(txtPrimerApellido, "Debe introducir al menos un apellido");
                erpApellidos.SetError(txtSegundoApellido, "Debe introducir al menos un apellido");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                erpDireccion.SetError(txtDireccion, "El campo Dirección es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                erpCelular.SetError(txtCelular, "El campo Celular es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(cbxCargo.Text))
            {
                erpCargo.SetError(cbxCargo, "El campo Cargo es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
                esValido = false;
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = new Empleado();
                empleado.cedulaIdentidad = txtCedulaIdentidad.Text.Trim();
                empleado.nombre = txtNombres.Text.Trim();
                empleado.primerApellido = txtPrimerApellido.Text.Trim();
                empleado.segundoApellido = txtSegundoApellido.Text.Trim();
                empleado.direccion = txtDireccion.Text.Trim();
                empleado.celular = Convert.ToInt64(txtCelular.Text);
                empleado.cargo = cbxCargo.Text;
                empleado.fechaNacimiento = dtpFechaNacimiento.Value;
                empleado.usuarioRegistro = Util.usuario.usuario;

                var empleadoExistente = EmpleadoCln.validar(empleado.cedulaIdentidad);
                if (empleadoExistente != null)
                {
                    empleado.id = empleadoExistente.id;
                    EmpleadoCln.actualizar(empleado);
                }
                else
                {
                    empleado.fechaRegistro = DateTime.Now;
                    empleado.registroActivo = true;
                    EmpleadoCln.insertar(empleado);
                }

                var usuario = new Usuario();
                usuario.idEmpleado = empleado.id;
                usuario.usuario = txtUsuario.Text.Trim();
                usuario.clave = Util.Encrypt("hola123");
                usuario.usuarioRegistro = Util.usuario.usuario;

                var usuarioExistente = UsuarioCln.validar(empleado.id);
                if (usuarioExistente != null)
                {
                    usuario.id = usuarioExistente.id;
                    UsuarioCln.actualizar(usuario);
                }
                else
                {
                    usuario.fechaRegistro = DateTime.Now;
                    usuario.registroActivo = true;
                    UsuarioCln.insertar(usuario);
                }


                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Usuario guardado correctamente", "::: Minerva - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar()
        {
            txtCedulaIdentidad.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCelular.Text = string.Empty;
            cbxCargo.SelectedIndex = -1;
            txtUsuario.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now.AddYears(-18);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["idUsuario"].Value);
            string usuario = dgvLista.Rows[index].Cells["usuario"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja " +
                $"el usuario {usuario}?", "::: Minerva - Mensaje :::",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                UsuarioCln.eliminar(id, Util.usuario.usuario);
                listar();
                MessageBox.Show($"Usuario dado de baja correctamente", "::: Minerva - Mensaje :::",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
