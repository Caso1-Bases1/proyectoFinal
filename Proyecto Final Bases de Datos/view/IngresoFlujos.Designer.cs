namespace Proyecto_Final_Bases_de_Datos.view
{
    partial class IngresoFlujos
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
            this.components = new System.ComponentModel.Container();
            this.codigoFlujo = new System.Windows.Forms.TextBox();
            this.flujoMaster = new System.Windows.Forms.TextBox();
            this.codigoFlujoMaster = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_PRODDataSet2 = new Proyecto_Final_Bases_de_Datos.DB_PRODDataSet2();
            this.fLUJOMASTERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLUJO_MASTERTableAdapter = new Proyecto_Final_Bases_de_Datos.DB_PRODDataSet2TableAdapters.FLUJO_MASTERTableAdapter();
            this.idFlujoMaestroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flujoBtn = new System.Windows.Forms.Button();
            this.nuevoFlujo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PRODDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLUJOMASTERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoFlujo
            // 
            this.codigoFlujo.Location = new System.Drawing.Point(47, 64);
            this.codigoFlujo.Name = "codigoFlujo";
            this.codigoFlujo.Size = new System.Drawing.Size(100, 20);
            this.codigoFlujo.TabIndex = 0;
            // 
            // flujoMaster
            // 
            this.flujoMaster.Location = new System.Drawing.Point(47, 143);
            this.flujoMaster.Name = "flujoMaster";
            this.flujoMaster.Size = new System.Drawing.Size(100, 20);
            this.flujoMaster.TabIndex = 1;
            // 
            // codigoFlujoMaster
            // 
            this.codigoFlujoMaster.Location = new System.Drawing.Point(524, 64);
            this.codigoFlujoMaster.Name = "codigoFlujoMaster";
            this.codigoFlujoMaster.Size = new System.Drawing.Size(100, 20);
            this.codigoFlujoMaster.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código de flujo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Flujo mater";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingreso de flujos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo flujo master";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFlujoMaestroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fLUJOMASTERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(373, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(124, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dB_PRODDataSet2
            // 
            this.dB_PRODDataSet2.DataSetName = "DB_PRODDataSet2";
            this.dB_PRODDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fLUJOMASTERBindingSource
            // 
            this.fLUJOMASTERBindingSource.DataMember = "FLUJO_MASTER";
            this.fLUJOMASTERBindingSource.DataSource = this.dB_PRODDataSet2;
            // 
            // fLUJO_MASTERTableAdapter
            // 
            this.fLUJO_MASTERTableAdapter.ClearBeforeFill = true;
            // 
            // idFlujoMaestroDataGridViewTextBoxColumn
            // 
            this.idFlujoMaestroDataGridViewTextBoxColumn.DataPropertyName = "IdFlujoMaestro";
            this.idFlujoMaestroDataGridViewTextBoxColumn.HeaderText = "IdFlujoMaestro";
            this.idFlujoMaestroDataGridViewTextBoxColumn.Name = "idFlujoMaestroDataGridViewTextBoxColumn";
            // 
            // flujoBtn
            // 
            this.flujoBtn.Location = new System.Drawing.Point(527, 113);
            this.flujoBtn.Name = "flujoBtn";
            this.flujoBtn.Size = new System.Drawing.Size(75, 23);
            this.flujoBtn.TabIndex = 8;
            this.flujoBtn.Text = "Añadir";
            this.flujoBtn.UseVisualStyleBackColor = true;
            this.flujoBtn.Click += new System.EventHandler(this.flujoBtn_Click);
            // 
            // nuevoFlujo
            // 
            this.nuevoFlujo.Location = new System.Drawing.Point(47, 190);
            this.nuevoFlujo.Name = "nuevoFlujo";
            this.nuevoFlujo.Size = new System.Drawing.Size(75, 23);
            this.nuevoFlujo.TabIndex = 9;
            this.nuevoFlujo.Text = "Nuevo flujo";
            this.nuevoFlujo.UseVisualStyleBackColor = true;
            this.nuevoFlujo.Click += new System.EventHandler(this.nuevoFlujo_Click);
            // 
            // IngresoFlujos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 416);
            this.Controls.Add(this.nuevoFlujo);
            this.Controls.Add(this.flujoBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigoFlujoMaster);
            this.Controls.Add(this.flujoMaster);
            this.Controls.Add(this.codigoFlujo);
            this.Name = "IngresoFlujos";
            this.Text = "IngresoFlujos";
            this.Load += new System.EventHandler(this.IngresoFlujos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PRODDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLUJOMASTERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoFlujo;
        private System.Windows.Forms.TextBox flujoMaster;
        private System.Windows.Forms.TextBox codigoFlujoMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_PRODDataSet2 dB_PRODDataSet2;
        private System.Windows.Forms.BindingSource fLUJOMASTERBindingSource;
        private DB_PRODDataSet2TableAdapters.FLUJO_MASTERTableAdapter fLUJO_MASTERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFlujoMaestroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button flujoBtn;
        private System.Windows.Forms.Button nuevoFlujo;
    }
}