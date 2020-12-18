
namespace SgRaquetaAlvaroMerino
{
    partial class AdminPista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPista));
            System.Windows.Forms.Label idPistaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label ubicacionLabel;
            System.Windows.Forms.Label precioHoraLabel;
            System.Windows.Forms.Label label1;
            this.dsBD = new SgRaquetaAlvaroMerino.dsBD();
            this.pistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pistasTableAdapter = new SgRaquetaAlvaroMerino.dsBDTableAdapters.pistasTableAdapter();
            this.tableAdapterManager = new SgRaquetaAlvaroMerino.dsBDTableAdapters.TableAdapterManager();
            this.pistasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pistasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPistaLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.ubicacionTextBox = new System.Windows.Forms.TextBox();
            this.precioHoraTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            idPistaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ubicacionLabel = new System.Windows.Forms.Label();
            precioHoraLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingNavigator)).BeginInit();
            this.pistasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pistasBindingSource
            // 
            this.pistasBindingSource.DataMember = "pistas";
            this.pistasBindingSource.DataSource = this.dsBD;
            // 
            // pistasTableAdapter
            // 
            this.pistasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pistasTableAdapter = this.pistasTableAdapter;
            this.tableAdapterManager.reservasTableAdapter = null;
            this.tableAdapterManager.sociosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SgRaquetaAlvaroMerino.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pistasBindingNavigator
            // 
            this.pistasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pistasBindingNavigator.BindingSource = this.pistasBindingSource;
            this.pistasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pistasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pistasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pistasBindingNavigatorSaveItem});
            this.pistasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pistasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pistasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pistasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pistasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pistasBindingNavigator.Name = "pistasBindingNavigator";
            this.pistasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pistasBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pistasBindingNavigator.TabIndex = 0;
            this.pistasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // pistasBindingNavigatorSaveItem
            // 
            this.pistasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pistasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pistasBindingNavigatorSaveItem.Image")));
            this.pistasBindingNavigatorSaveItem.Name = "pistasBindingNavigatorSaveItem";
            this.pistasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pistasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pistasBindingNavigatorSaveItem.Click += new System.EventHandler(this.pistasBindingNavigatorSaveItem_Click);
            // 
            // idPistaLabel
            // 
            idPistaLabel.AutoSize = true;
            idPistaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPistaLabel.Location = new System.Drawing.Point(65, 60);
            idPistaLabel.Name = "idPistaLabel";
            idPistaLabel.Size = new System.Drawing.Size(59, 15);
            idPistaLabel.TabIndex = 1;
            idPistaLabel.Text = "id Pista:";
            // 
            // idPistaLabel1
            // 
            this.idPistaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "idPista", true));
            this.idPistaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPistaLabel1.Location = new System.Drawing.Point(136, 60);
            this.idPistaLabel1.Name = "idPistaLabel1";
            this.idPistaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idPistaLabel1.TabIndex = 2;
            this.idPistaLabel1.Text = "label1";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(65, 89);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 15);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(136, 86);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(202, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // ubicacionLabel
            // 
            ubicacionLabel.AutoSize = true;
            ubicacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ubicacionLabel.Location = new System.Drawing.Point(65, 135);
            ubicacionLabel.Name = "ubicacionLabel";
            ubicacionLabel.Size = new System.Drawing.Size(73, 15);
            ubicacionLabel.TabIndex = 5;
            ubicacionLabel.Text = "ubicacion:";
            // 
            // ubicacionTextBox
            // 
            this.ubicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "ubicacion", true));
            this.ubicacionTextBox.Location = new System.Drawing.Point(136, 130);
            this.ubicacionTextBox.Multiline = true;
            this.ubicacionTextBox.Name = "ubicacionTextBox";
            this.ubicacionTextBox.Size = new System.Drawing.Size(202, 100);
            this.ubicacionTextBox.TabIndex = 6;
            // 
            // precioHoraLabel
            // 
            precioHoraLabel.AutoSize = true;
            precioHoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioHoraLabel.Location = new System.Drawing.Point(65, 255);
            precioHoraLabel.Name = "precioHoraLabel";
            precioHoraLabel.Size = new System.Drawing.Size(87, 15);
            precioHoraLabel.TabIndex = 7;
            precioHoraLabel.Text = "Precio Hora:";
            // 
            // precioHoraTextBox
            // 
            this.precioHoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pistasBindingSource, "precioHora", true));
            this.precioHoraTextBox.Location = new System.Drawing.Point(157, 250);
            this.precioHoraTextBox.Name = "precioHoraTextBox";
            this.precioHoraTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioHoraTextBox.TabIndex = 8;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pistasBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(382, 86);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(255, 144);
            this.fotoPictureBox.TabIndex = 10;
            this.fotoPictureBox.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(382, 255);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(255, 23);
            this.btnFoto.TabIndex = 11;
            this.btnFoto.Text = "Cambiar Imagen";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(263, 251);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 12;
            label1.Text = "euros";
            // 
            // AdminPista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(idPistaLabel);
            this.Controls.Add(this.idPistaLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(ubicacionLabel);
            this.Controls.Add(this.ubicacionTextBox);
            this.Controls.Add(precioHoraLabel);
            this.Controls.Add(this.precioHoraTextBox);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.pistasBindingNavigator);
            this.Name = "AdminPista";
            this.Text = "Administrador de Pistas";
            this.Load += new System.EventHandler(this.AdminPista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistasBindingNavigator)).EndInit();
            this.pistasBindingNavigator.ResumeLayout(false);
            this.pistasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBD dsBD;
        private System.Windows.Forms.BindingSource pistasBindingSource;
        private dsBDTableAdapters.pistasTableAdapter pistasTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pistasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pistasBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idPistaLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox ubicacionTextBox;
        private System.Windows.Forms.TextBox precioHoraTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button btnFoto;
    }
}