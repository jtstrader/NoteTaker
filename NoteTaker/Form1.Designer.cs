
namespace NoteTaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.msgTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.bNew = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            // 
            // msgTxt
            // 
            this.msgTxt.Location = new System.Drawing.Point(18, 84);
            this.msgTxt.Multiline = true;
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(338, 330);
            this.msgTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(18, 29);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(176, 20);
            this.titleTxt.TabIndex = 3;
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.AllowUserToResizeColumns = false;
            this.dGrid.AllowUserToResizeRows = false;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Location = new System.Drawing.Point(548, 84);
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.RowHeadersVisible = false;
            this.dGrid.Size = new System.Drawing.Size(240, 330);
            this.dGrid.TabIndex = 4;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(362, 84);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(70, 23);
            this.bNew.TabIndex = 5;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(362, 135);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(70, 23);
            this.bLoad.TabIndex = 6;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(472, 135);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(70, 23);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(472, 84);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(70, 23);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.dGrid);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msgTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
    }
}

