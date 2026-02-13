using Microsoft.EntityFrameworkCore;

using RMS.Domain;
using RMS.Domain.Entities;
using RMS.Infrastructure;

using System;

using System.Linq;

using System.Windows.Forms;
using System.Drawing;

namespace RMS.App
{
    public partial class MainForm : Form
    {
        private RmsDBContext _context;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RmsDBContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=RMS_Db;Integrated Security=True");
            _context = new RmsDBContext(optionsBuilder.Options);
            _context.Database.EnsureCreated();

            cboStatus.DataSource = Enum.GetValues(typeof(LoanStatus));

            LoadData();
        }

        private void LoadData()
        {
            var list = _context.Equipments.ToList();
            dgvEquipment.SelectionChanged -= dgvEquipment_SelectionChanged;
            dgvEquipment.AutoGenerateColumns = false;
            dgvEquipment.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                Name = "Id",
                Visible = true
            };
            dgvEquipment.Columns.Add(colId);

            dgvEquipment.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SerialNumber",
                Name = "SerialNumber",
                HeaderText = "Serial Number"
            });

            dgvEquipment.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Model",
                Name = "Model",
                HeaderText = "Model"
            });

            dgvEquipment.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                Name = "Category",
                HeaderText = "Category"
            });

            dgvEquipment.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "status",
                Name = "Status",
                HeaderText = "Status"
            });

            dgvEquipment.EnableHeadersVisualStyles = false;
            dgvEquipment.ColumnHeadersDefaultCellStyle.Font = new Font(dgvEquipment.Font, FontStyle.Bold);
            dgvEquipment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEquipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEquipment.DataSource = list;
            dgvEquipment.ClearSelection();
            dgvEquipment.SelectionChanged += dgvEquipment_SelectionChanged;
        }

        private void ClearInputs()
        {
            txtSerial.Clear();
            txtModel.Clear();
            txtCategory.Clear();
            cboStatus.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerial.Text))
            {
                MessageBox.Show("Serial Number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerial.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus();
                return;
            }
            var newEquip = new Equipment
            {
                SerialNumber = txtSerial.Text.Trim(),
                Model = txtModel.Text.Trim(),
                Category = txtCategory.Text?.Trim(),
                status = (LoanStatus)cboStatus.SelectedItem
            };
            _context.Equipments.Add(newEquip);
            _context.SaveChanges();
            LoadData();
            ClearInputs();
            MessageBox.Show("Equipment added successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)

        {
            if (dgvEquipment.CurrentRow == null)
            {
                MessageBox.Show("Select an equipment to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSerial.Text))
            {
                MessageBox.Show("Serial Number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSerial.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus();
                return;
            }
            var idObj = dgvEquipment.CurrentRow.Cells["Id"].Value;
            if (idObj == null)
            {
                MessageBox.Show("Unable to determine selected equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = (int)idObj;
            var equipment = _context.Equipments.Find(id);
            if (equipment == null)
            {
                MessageBox.Show("Selected equipment no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
                return;
            }
          
            equipment.SerialNumber = txtSerial.Text.Trim();
            equipment.Model = txtModel.Text.Trim();
            equipment.Category = txtCategory.Text?.Trim();
            equipment.status = (LoanStatus)cboStatus.SelectedItem;
            _context.SaveChanges();
            LoadData();

            MessageBox.Show("Equipment updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEquipment.CurrentRow == null)
            {
                MessageBox.Show("Select an equipment to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var idObj = dgvEquipment.CurrentRow.Cells["Id"].Value;
            if (idObj == null)
            {
                MessageBox.Show("Unable to determine selected equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirm = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;
            int id = (int)idObj;
            var equipment = _context.Equipments.Find(id);
            if (equipment == null)
            {
                MessageBox.Show("Selected equipment no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
                return;
            }
            _context.Equipments.Remove(equipment);
            _context.SaveChanges();
            LoadData();
            ClearInputs();
            MessageBox.Show("Equipment deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvEquipment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEquipment.CurrentRow == null)
            {
                ClearInputs();
                return;
            }
            if (!dgvEquipment.Columns.Contains("SerialNumber") || !dgvEquipment.Columns.Contains("Model") || !dgvEquipment.Columns.Contains("Category") || !dgvEquipment.Columns.Contains("Status"))
            {
                return;
            }
            txtSerial.Text = dgvEquipment.CurrentRow.Cells["SerialNumber"].Value?.ToString();
            txtModel.Text = dgvEquipment.CurrentRow.Cells["Model"].Value?.ToString();
            txtCategory.Text = dgvEquipment.CurrentRow.Cells["Category"].Value?.ToString();
            var statusVal = dgvEquipment.CurrentRow.Cells["Status"].Value;
            if (statusVal != null) cboStatus.SelectedItem = statusVal;
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}