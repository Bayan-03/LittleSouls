using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSouls
{
    public partial class TFo : Form
    {
        littleSoulsEntities littleSouls = new littleSoulsEntities();

        public TFo()
        {
            InitializeComponent();
            dgvInvoiceItems.ColumnCount = 4;
            dgvInvoiceItems.Columns[0].Name = "كود العنصر";
            dgvInvoiceItems.Columns[1].Name = "اسم العنصر";
            dgvInvoiceItems.Columns[2].Name = "الكمية";
            dgvInvoiceItems.Columns[3].Name = "السعر الإجمالي";
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Invoices_Load(object sender, EventArgs e)
        {

        }

        decimal realtot;
        private void UpdateTotal()
        {
            // حساب الإجمالي
            decimal total = 0;
            foreach (DataGridViewRow row in dgvInvoiceItems.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[3].Value);
                }
            }
            realtot = total;
            lblTotal.Text = $"Total: {total:C}";
        }



        private void ClearForm()
        {
            // إعادة ضبط الحقول
            dgvInvoiceItems.Rows.Clear();
            lblTotal.Text = "Total: ";
            txtItemCode.Clear();
            txtQuantity.Clear();
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            // التحقق من إدخال كود العنصر والكمية
            if (string.IsNullOrEmpty(txtItemCode.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("يرجى إدخال كود العنصر والكمية.");
                return;
            }

            // تحويل الإدخالات إلى أرقام
            int itemCode;
            int quantity;

            if (!int.TryParse(txtItemCode.Text, out itemCode) || !int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("يرجى إدخال كميات صحيحة (أرقام موجبة).");
                return;
            }

            // البحث عن العنصر في قاعدة البيانات
            var item = littleSouls.items.FirstOrDefault(i => i.itemCode == itemCode);

            if (item == null)
            {
                MessageBox.Show("العنصر غير موجود.");
                return;
            }

            // التحقق من الكمية المتوفرة في المخزون
            if (item.quantity < quantity)
            {
                MessageBox.Show($"الكمية المطلوبة ({quantity}) أكبر من الكمية المتوفرة في المخزون ({item.quantity}).");
                return;
            }

            // حساب السعر الإجمالي للعنصر
            decimal totalPrice = item.sellPrice * quantity;

            // إضافة العنصر إلى جدول الفاتورة
            dgvInvoiceItems.Rows.Add(item.itemCode, item.itemName, quantity, totalPrice);

            // تقليص الكمية في المخزون
            item.quantity -= quantity;

            try
            {
                // حفظ التغييرات في قاعدة البيانات
                littleSouls.SaveChanges();

                // تحديث الإجمالي
                UpdateTotal();

                // عرض رسالة بنجاح الإضافة
                MessageBox.Show($"تمت إضافة العنصر بنجاح. الكمية المتبقية: {item.quantity}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ التغييرات: {ex.Message}");
            }

        }


        private void btnSaveInvoice_Click_1(object sender, EventArgs e)
        {
            // التحقق من إدخال بيانات الفاتورة
            if (dgvInvoiceItems.Rows.Count == 0)
            {
                MessageBox.Show("يرجى إضافة عناصر إلى الفاتورة.");
                return;
            }
            // إنشاء الفاتورة الجديدة
            using (var context = new littleSoulsEntities())
            {
                // إنشاء الفاتورة
                var invoice = new invoice
                {
                    invoiceIssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                    employeeId = 1, // معرّف الموظف المناسب
                    total = realtot
                };

                // إضافة الفاتورة إلى قاعدة البيانات
                context.invoices.Add(invoice);
                context.SaveChanges(); // سيتم توليد الرقم تلقائيًا بواسطة قاعدة البيانات

                // الحصول على رقم الفاتورة الذي تم توليده تلقائيًا
                int invoiceNumber = invoice.invoicesNumber; // تأكد من استخدام الاسم الصحيح هنا

                // إضافة تفاصيل العناصر المرتبطة بالفاتورة
                
                    

                    // إضافة عنصر إلى جدول invoiceItems
                    var invoiceItem = new invoiceItem
                    {
                        invoiceNumber = invoiceNumber, // استخدام الرقم الذي تم توليده
                        itemCode = int.Parse(txtItemCode.Text), // كود العنصر
                        quantity = int.Parse(txtQuantity.Text), // الكمية
                        /*price = decimal.Parse(price)*/ // السعر

                    };

                    // إضافة بيانات العناصر المرتبطة بالفاتورة
                    context.invoiceItems.Add(invoiceItem);
                

                // حفظ التغييرات في قاعدة البيانات
                context.SaveChanges();
                MessageBox.Show("تم حفظ الفاتورة بنجاح!");
                ClearForm(); // إعادة ضبط النموذج
            }

        }

        private void navBarPanel1_showHomeForm(object sender, EventArgs e)
        {
            this.Hide();
            var HomeForm = new Home();
            HomeForm.WindowState = FormWindowState.Maximized;
            HomeForm.FormClosed += (s, args) => this.Close();
            HomeForm.Show();
        }

        private void navBarPanel1_showMedicalCareForm(object sender, EventArgs e)
        {
            this.Hide();
            var medicalCareForm = new medicalCare();
            medicalCareForm.WindowState = FormWindowState.Maximized;
            medicalCareForm.FormClosed += (s, args) => this.Close();
            medicalCareForm.Show();
        }

        private void navBarPanel1_showPetsForm(object sender, EventArgs e)
        {
            this.Hide();
            var PetsForm = new Pets();
            PetsForm.WindowState = FormWindowState.Maximized;
            PetsForm.FormClosed += (s, args) => this.Close();
            PetsForm.Show();
        }
    }
}
