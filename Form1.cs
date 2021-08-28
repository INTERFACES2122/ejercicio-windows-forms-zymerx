using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrodeAlumnos {
    public partial class MainScreen : Form {

        public MainScreen() {
            InitializeComponent();
        }

        private void ButtonSaveName_Click(object sender, EventArgs e) {
            if(checkStudentInfo()) {
                saveStudentInfo();
            }
        }

        private bool checkStudentInfo() {
            if(BoxNameStudent.Text == "" || BoxLastname1.Text == "" || BoxLastName2.Text == "") {
                MessageBox.Show("Datos del Registro Incompletos");
                return false;
            } else {
                return true;
            }
        }

        private void saveStudentInfo() {
            MessageBox.Show("Registro Guardado Correctamente");
            GridStudents.Rows.Add(" " + BoxNameStudent.Text, " " + BoxLastname1.Text, " " + BoxLastName2.Text);
            BoxNameStudent.Text = "";
            BoxLastname1.Text = "";
            BoxLastName2.Text = "";
        }

        private void BoxNameStudent_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == 13) {
                BoxLastname1.Focus();
            }
        }

        private void BoxLastname1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                BoxLastName2.Focus();
            }
        }

        private void BoxLastName2_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                if (checkStudentInfo()) {
                    saveStudentInfo();
                }
            }
        }

        private void ButtonClearStudents_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("¿Está seguro que desea borrar todos los registros?", "Eliminar Registros", MessageBoxButtons.YesNo);
            
            if(result == DialogResult.Yes) {
                GridStudents.Rows.Clear();
            }
        }

        private void BoxSearchStudent_TextChanged(object sender, EventArgs e) {

        }

        private void ButtonSearchStudent_Click(object sender, EventArgs e) {
            
        }

    }
}
