using System;
using System.Drawing;
using System.Windows.Forms;

namespace Frenlly__Nomina_Quincenal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gbDatos = new GroupBox();
            rdbTemporal = new RadioButton();
            rdbFijo = new RadioButton();
            lblContrato = new Label();
            txtEmpleado = new TextBox();
            lblNombre = new Label();
            gbRegistro = new GroupBox();
            btnRegistrar = new Button();
            chkTransporte = new CheckBox();
            txtHoras = new TextBox();
            lblHoras = new Label();
            cmbCargo = new ComboBox();
            lblCargo = new Label();
            gbNomina = new GroupBox();
            lstNomina = new ListBox();
            gbResumen = new GroupBox();
            lblNeto = new Label();
            lblDeducciones = new Label();
            lblBruto = new Label();
            lblEmpleados = new Label();
            lblNetoTitulo = new Label();
            lblDeduccionesTitulo = new Label();
            lblBrutoTitulo = new Label();
            lblEmpleadosTitulo = new Label();
            btnResumen = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            gbDatos.SuspendLayout();
            gbRegistro.SuspendLayout();
            gbNomina.SuspendLayout();
            gbResumen.SuspendLayout();
            SuspendLayout();
             
            gbDatos.Controls.Add(rdbTemporal);
            gbDatos.Controls.Add(rdbFijo);
            gbDatos.Controls.Add(lblContrato);
            gbDatos.Controls.Add(txtEmpleado);
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Location = new Point(15, 15);
            gbDatos.Margin = new Padding(4, 4, 4, 4);
            gbDatos.Name = "gbDatos";
            gbDatos.Padding = new Padding(4, 4, 4, 4);
            gbDatos.Size = new Size(525, 150);
            gbDatos.TabIndex = 0;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos del empleado";
             
            rdbTemporal.AutoSize = true;
            rdbTemporal.Location = new Point(269, 94);
            rdbTemporal.Margin = new Padding(4, 4, 4, 4);
            rdbTemporal.Name = "rdbTemporal";
            rdbTemporal.Size = new Size(110, 29);
            rdbTemporal.TabIndex = 4;
            rdbTemporal.Text = "Temporal";
            
            rdbFijo.AutoSize = true;
            rdbFijo.Checked = true;
            rdbFijo.Location = new Point(150, 94);
            rdbFijo.Margin = new Padding(4, 4, 4, 4);
            rdbFijo.Name = "rdbFijo";
            rdbFijo.Size = new Size(65, 29);
            rdbFijo.TabIndex = 3;
            rdbFijo.TabStop = true;
            rdbFijo.Text = "Fijo";
            
            lblContrato.AutoSize = true;
            lblContrato.Location = new Point(25, 96);
            lblContrato.Margin = new Padding(4, 0, 4, 0);
            lblContrato.Name = "lblContrato";
            lblContrato.Size = new Size(86, 25);
            lblContrato.TabIndex = 5;
            lblContrato.Text = "Contrato:";
            
            txtEmpleado.Location = new Point(150, 38);
            txtEmpleado.Margin = new Padding(4, 4, 4, 4);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(349, 31);
            txtEmpleado.TabIndex = 1;
            
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 41);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
           
            gbRegistro.Controls.Add(btnRegistrar);
            gbRegistro.Controls.Add(chkTransporte);
            gbRegistro.Controls.Add(txtHoras);
            gbRegistro.Controls.Add(lblHoras);
            gbRegistro.Controls.Add(cmbCargo);
            gbRegistro.Controls.Add(lblCargo);
            gbRegistro.Location = new Point(15, 188);
            gbRegistro.Margin = new Padding(4, 4, 4, 4);
            gbRegistro.Name = "gbRegistro";
            gbRegistro.Padding = new Padding(4, 4, 4, 4);
            gbRegistro.Size = new Size(525, 275);
            gbRegistro.TabIndex = 1;
            gbRegistro.TabStop = false;
            gbRegistro.Text = "Registro de pago";
            
            btnRegistrar.Location = new Point(25, 212);
            btnRegistrar.Margin = new Padding(4, 4, 4, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(475, 44);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "Registrar empleado";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            
            chkTransporte.AutoSize = true;
            chkTransporte.Location = new Point(150, 162);
            chkTransporte.Margin = new Padding(4, 4, 4, 4);
            chkTransporte.Name = "chkTransporte";
            chkTransporte.Size = new Size(277, 29);
            chkTransporte.TabIndex = 4;
            chkTransporte.Text = "Recibe incentivo de transporte";
            
            txtHoras.Location = new Point(150, 106);
            txtHoras.Margin = new Padding(4, 4, 4, 4);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(349, 31);
            txtHoras.TabIndex = 3;
            
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(25, 110);
            lblHoras.Margin = new Padding(4, 0, 4, 0);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(100, 25);
            lblHoras.TabIndex = 6;
            lblHoras.Text = "Horas trab:";
            
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Auxiliar", "Técnico", "Supervisor", "Gerente" });
            cmbCargo.Location = new Point(150, 50);
            cmbCargo.Margin = new Padding(4, 4, 4, 4);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(349, 33);
            cmbCargo.TabIndex = 2;
            
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(25, 54);
            lblCargo.Margin = new Padding(4, 0, 4, 0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(64, 25);
            lblCargo.TabIndex = 7;
            lblCargo.Text = "Cargo:";
            
            gbNomina.Controls.Add(lstNomina);
            gbNomina.Location = new Point(562, 15);
            gbNomina.Margin = new Padding(4, 4, 4, 4);
            gbNomina.Name = "gbNomina";
            gbNomina.Padding = new Padding(4, 4, 4, 4);
            gbNomina.Size = new Size(475, 225);
            gbNomina.TabIndex = 2;
            gbNomina.TabStop = false;
            gbNomina.Text = "Nómina registrada";
            
            lstNomina.FormattingEnabled = true;
            lstNomina.Location = new Point(19, 38);
            lstNomina.Margin = new Padding(4, 4, 4, 4);
            lstNomina.Name = "lstNomina";
            lstNomina.Size = new Size(436, 154);
            lstNomina.TabIndex = 0;
            
            gbResumen.Controls.Add(lblNeto);
            gbResumen.Controls.Add(lblDeducciones);
            gbResumen.Controls.Add(lblBruto);
            gbResumen.Controls.Add(lblEmpleados);
            gbResumen.Controls.Add(lblNetoTitulo);
            gbResumen.Controls.Add(lblDeduccionesTitulo);
            gbResumen.Controls.Add(lblBrutoTitulo);
            gbResumen.Controls.Add(lblEmpleadosTitulo);
            gbResumen.Location = new Point(562, 250);
            gbResumen.Margin = new Padding(4, 4, 4, 4);
            gbResumen.Name = "gbResumen";
            gbResumen.Padding = new Padding(4, 4, 4, 4);
            gbResumen.Size = new Size(475, 212);
            gbResumen.TabIndex = 3;
            gbResumen.TabStop = false;
            gbResumen.Text = "Resumen";
            
            lblNeto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNeto.Location = new Point(288, 162);
            lblNeto.Margin = new Padding(4, 0, 4, 0);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(162, 25);
            lblNeto.TabIndex = 0;
            lblNeto.Text = "RD$ 0.00";
            lblNeto.TextAlign = ContentAlignment.MiddleRight;
            
            lblDeducciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeducciones.Location = new Point(288, 119);
            lblDeducciones.Margin = new Padding(4, 0, 4, 0);
            lblDeducciones.Name = "lblDeducciones";
            lblDeducciones.Size = new Size(162, 25);
            lblDeducciones.TabIndex = 1;
            lblDeducciones.Text = "RD$ 0.00";
            lblDeducciones.TextAlign = ContentAlignment.MiddleRight;
            
            lblBruto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBruto.Location = new Point(288, 75);
            lblBruto.Margin = new Padding(4, 0, 4, 0);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(162, 25);
            lblBruto.TabIndex = 2;
            lblBruto.Text = "RD$ 0.00";
            lblBruto.TextAlign = ContentAlignment.MiddleRight;
            
            lblEmpleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmpleados.Location = new Point(288, 31);
            lblEmpleados.Margin = new Padding(4, 0, 4, 0);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(162, 25);
            lblEmpleados.TabIndex = 3;
            lblEmpleados.Text = "0";
            lblEmpleados.TextAlign = ContentAlignment.MiddleRight;
            
            lblNetoTitulo.AutoSize = true;
            lblNetoTitulo.Location = new Point(25, 162);
            lblNetoTitulo.Margin = new Padding(4, 0, 4, 0);
            lblNetoTitulo.Name = "lblNetoTitulo";
            lblNetoTitulo.Size = new Size(94, 25);
            lblNetoTitulo.TabIndex = 4;
            lblNetoTitulo.Text = "Total neto:";
            
            lblDeduccionesTitulo.AutoSize = true;
            lblDeduccionesTitulo.Location = new Point(25, 119);
            lblDeduccionesTitulo.Margin = new Padding(4, 0, 4, 0);
            lblDeduccionesTitulo.Name = "lblDeduccionesTitulo";
            lblDeduccionesTitulo.Size = new Size(157, 25);
            lblDeduccionesTitulo.TabIndex = 5;
            lblDeduccionesTitulo.Text = "Total deducciones:";
            
            lblBrutoTitulo.AutoSize = true;
            lblBrutoTitulo.Location = new Point(25, 75);
            lblBrutoTitulo.Margin = new Padding(4, 0, 4, 0);
            lblBrutoTitulo.Name = "lblBrutoTitulo";
            lblBrutoTitulo.Size = new Size(102, 25);
            lblBrutoTitulo.TabIndex = 6;
            lblBrutoTitulo.Text = "Total bruto:";
            
            lblEmpleadosTitulo.AutoSize = true;
            lblEmpleadosTitulo.Location = new Point(25, 31);
            lblEmpleadosTitulo.Margin = new Padding(4, 0, 4, 0);
            lblEmpleadosTitulo.Name = "lblEmpleadosTitulo";
            lblEmpleadosTitulo.Size = new Size(198, 25);
            lblEmpleadosTitulo.TabIndex = 7;
            lblEmpleadosTitulo.Text = "Empleados registrados:";
            
            btnResumen.Location = new Point(15, 488);
            btnResumen.Margin = new Padding(4, 4, 4, 4);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(300, 50);
            btnResumen.TabIndex = 4;
            btnResumen.Text = "Mostrar resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            
            btnLimpiar.Location = new Point(381, 488);
            btnLimpiar.Margin = new Padding(4, 4, 4, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(300, 50);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
             
            btnSalir.Location = new Point(737, 488);
            btnSalir.Margin = new Padding(4, 4, 4, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(300, 50);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 562);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnResumen);
            Controls.Add(gbResumen);
            Controls.Add(gbNomina);
            Controls.Add(gbRegistro);
            Controls.Add(gbDatos);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nómina Quincenal";
            Load += Form1_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbRegistro.ResumeLayout(false);
            gbRegistro.PerformLayout();
            gbNomina.ResumeLayout(false);
            gbResumen.ResumeLayout(false);
            gbResumen.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.RadioButton rdbFijo;
        private System.Windows.Forms.RadioButton rdbTemporal;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.CheckBox chkTransporte;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbNomina;
        private System.Windows.Forms.ListBox lstNomina;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.Label lblEmpleadosTitulo;
        private System.Windows.Forms.Label lblBrutoTitulo;
        private System.Windows.Forms.Label lblDeduccionesTitulo;
        private System.Windows.Forms.Label lblNetoTitulo;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblDeducciones;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}