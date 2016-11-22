namespace XmlSerialization
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
            this.btn_Serialize = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_SerializeAdvanced = new System.Windows.Forms.Button();
            this.btn_Deserialize = new System.Windows.Forms.Button();
            this.btn_DeserializeNested = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Serialize
            // 
            this.btn_Serialize.Location = new System.Drawing.Point(55, 57);
            this.btn_Serialize.Name = "btn_Serialize";
            this.btn_Serialize.Size = new System.Drawing.Size(181, 23);
            this.btn_Serialize.TabIndex = 0;
            this.btn_Serialize.Text = "Serialize";
            this.btn_Serialize.UseVisualStyleBackColor = true;
            this.btn_Serialize.Click += new System.EventHandler(this.btn_Serialize_Click);
            // 
            // btn_SerializeAdvanced
            // 
            this.btn_SerializeAdvanced.Location = new System.Drawing.Point(55, 86);
            this.btn_SerializeAdvanced.Name = "btn_SerializeAdvanced";
            this.btn_SerializeAdvanced.Size = new System.Drawing.Size(181, 23);
            this.btn_SerializeAdvanced.TabIndex = 1;
            this.btn_SerializeAdvanced.Text = "Serialize - Nested Class";
            this.btn_SerializeAdvanced.UseVisualStyleBackColor = true;
            this.btn_SerializeAdvanced.Click += new System.EventHandler(this.btn_SerializeAdvanced_Click);
            // 
            // btn_Deserialize
            // 
            this.btn_Deserialize.Location = new System.Drawing.Point(55, 145);
            this.btn_Deserialize.Name = "btn_Deserialize";
            this.btn_Deserialize.Size = new System.Drawing.Size(181, 23);
            this.btn_Deserialize.TabIndex = 2;
            this.btn_Deserialize.Text = "Deserialize";
            this.btn_Deserialize.UseVisualStyleBackColor = true;
            this.btn_Deserialize.Click += new System.EventHandler(this.btn_Deserialize_Click);
            // 
            // btn_DeserializeNested
            // 
            this.btn_DeserializeNested.Location = new System.Drawing.Point(55, 174);
            this.btn_DeserializeNested.Name = "btn_DeserializeNested";
            this.btn_DeserializeNested.Size = new System.Drawing.Size(181, 23);
            this.btn_DeserializeNested.TabIndex = 3;
            this.btn_DeserializeNested.Text = "Deserialize - Nested XML";
            this.btn_DeserializeNested.UseVisualStyleBackColor = true;
            this.btn_DeserializeNested.Click += new System.EventHandler(this.btn_DeserializeNested_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_DeserializeNested);
            this.Controls.Add(this.btn_Deserialize);
            this.Controls.Add(this.btn_SerializeAdvanced);
            this.Controls.Add(this.btn_Serialize);
            this.Name = "Form1";
            this.Text = "XML Serialization & De-Serialization";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Serialize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_SerializeAdvanced;
        private System.Windows.Forms.Button btn_Deserialize;
        private System.Windows.Forms.Button btn_DeserializeNested;
    }
}

