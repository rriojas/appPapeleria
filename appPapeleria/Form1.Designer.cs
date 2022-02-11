
namespace appPapeleria
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lstvArticulos = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtExistencia = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPrecio = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.txtCambioExistencia = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lstvArticulos
      // 
      this.lstvArticulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
      this.lstvArticulos.FullRowSelect = true;
      this.lstvArticulos.HideSelection = false;
      this.lstvArticulos.Location = new System.Drawing.Point(70, 154);
      this.lstvArticulos.Name = "lstvArticulos";
      this.lstvArticulos.Size = new System.Drawing.Size(672, 129);
      this.lstvArticulos.TabIndex = 0;
      this.lstvArticulos.UseCompatibleStateImageBehavior = false;
      this.lstvArticulos.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Codigo";
      this.columnHeader1.Width = 93;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Nombre";
      this.columnHeader2.Width = 395;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Existencia";
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Precio";
      this.columnHeader4.Width = 106;
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(144, 61);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(100, 20);
      this.txtNombre.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(77, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Nombre";
      // 
      // txtExistencia
      // 
      this.txtExistencia.Location = new System.Drawing.Point(144, 91);
      this.txtExistencia.Name = "txtExistencia";
      this.txtExistencia.Size = new System.Drawing.Size(100, 20);
      this.txtExistencia.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(77, 90);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Existencia";
      // 
      // txtPrecio
      // 
      this.txtPrecio.Location = new System.Drawing.Point(144, 117);
      this.txtPrecio.Name = "txtPrecio";
      this.txtPrecio.Size = new System.Drawing.Size(100, 20);
      this.txtPrecio.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(77, 116);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Precio";
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(266, 116);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(75, 23);
      this.btnGuardar.TabIndex = 9;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // txtCambioExistencia
      // 
      this.txtCambioExistencia.Location = new System.Drawing.Point(501, 300);
      this.txtCambioExistencia.Name = "txtCambioExistencia";
      this.txtCambioExistencia.Size = new System.Drawing.Size(100, 20);
      this.txtCambioExistencia.TabIndex = 11;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(440, 303);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Existencia";
      // 
      // btnActualizar
      // 
      this.btnActualizar.Location = new System.Drawing.Point(607, 297);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(75, 23);
      this.btnActualizar.TabIndex = 12;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = true;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.txtCambioExistencia);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.txtExistencia);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtPrecio);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lstvArticulos);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lstvArticulos;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtExistencia;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPrecio;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.TextBox txtCambioExistencia;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnActualizar;
  }
}

