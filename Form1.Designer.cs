namespace _02._05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewEmployees = new DataGridView();
            DelButton = new Button();
            AddButton = new Button();
            EditButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Location = new Point(12, 12);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.Size = new Size(600, 130);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // DelButton
            // 
            DelButton.Location = new Point(395, 345);
            DelButton.Name = "DelButton";
            DelButton.Size = new Size(217, 116);
            DelButton.TabIndex = 1;
            DelButton.Text = "Delete";
            DelButton.UseVisualStyleBackColor = true;
            DelButton.Click += buttonDelete_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 345);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(217, 116);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += buttonAdd_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(204, 178);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(217, 116);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 473);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(DelButton);
            Controls.Add(dataGridViewEmployees);
            Name = "Form1";
            Text = "My program ^_^";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private Button DelButton;
        private Button AddButton;
        private Button EditButton;
    }
}
