namespace SimpletronVisual
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
            this.memoryPanel = new System.Windows.Forms.Panel();
            this.registersPanel = new System.Windows.Forms.Panel();
            this.clearMemory = new System.Windows.Forms.Button();
            this.instructionAddressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.instructionBox = new System.Windows.Forms.TextBox();
            this.instructionDescriptionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ir = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.memoryTopPanel = new System.Windows.Forms.Panel();
            this.memoryGrid = new System.Windows.Forms.DataGridView();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.loadToMemory = new System.Windows.Forms.Button();
            this.startFromTheBeginning = new System.Windows.Forms.Button();
            this.runNextLine = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.RichTextBox();
            this.memoryPanel.SuspendLayout();
            this.registersPanel.SuspendLayout();
            this.memoryTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryGrid)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // memoryPanel
            // 
            this.memoryPanel.Controls.Add(this.registersPanel);
            this.memoryPanel.Controls.Add(this.memoryTopPanel);
            this.memoryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.memoryPanel.Location = new System.Drawing.Point(0, 0);
            this.memoryPanel.Name = "memoryPanel";
            this.memoryPanel.Size = new System.Drawing.Size(464, 590);
            this.memoryPanel.TabIndex = 0;
            // 
            // registersPanel
            // 
            this.registersPanel.Controls.Add(this.clearMemory);
            this.registersPanel.Controls.Add(this.instructionAddressBox);
            this.registersPanel.Controls.Add(this.label4);
            this.registersPanel.Controls.Add(this.instructionBox);
            this.registersPanel.Controls.Add(this.instructionDescriptionBox);
            this.registersPanel.Controls.Add(this.label3);
            this.registersPanel.Controls.Add(this.accBox);
            this.registersPanel.Controls.Add(this.label2);
            this.registersPanel.Controls.Add(this.ir);
            this.registersPanel.Controls.Add(this.label);
            this.registersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registersPanel.Location = new System.Drawing.Point(0, 348);
            this.registersPanel.Name = "registersPanel";
            this.registersPanel.Size = new System.Drawing.Size(464, 242);
            this.registersPanel.TabIndex = 2;
            // 
            // clearMemory
            // 
            this.clearMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearMemory.Location = new System.Drawing.Point(339, 77);
            this.clearMemory.Name = "clearMemory";
            this.clearMemory.Size = new System.Drawing.Size(110, 56);
            this.clearMemory.TabIndex = 9;
            this.clearMemory.Text = "Clear memory";
            this.clearMemory.UseVisualStyleBackColor = true;
            this.clearMemory.Click += new System.EventHandler(this.clearMemory_Click);
            // 
            // instructionAddressBox
            // 
            this.instructionAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructionAddressBox.Location = new System.Drawing.Point(170, 99);
            this.instructionAddressBox.Name = "instructionAddressBox";
            this.instructionAddressBox.ReadOnly = true;
            this.instructionAddressBox.Size = new System.Drawing.Size(56, 50);
            this.instructionAddressBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(136, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Instruction address";
            // 
            // instructionBox
            // 
            this.instructionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructionBox.Location = new System.Drawing.Point(37, 96);
            this.instructionBox.Name = "instructionBox";
            this.instructionBox.ReadOnly = true;
            this.instructionBox.Size = new System.Drawing.Size(56, 50);
            this.instructionBox.TabIndex = 6;
            // 
            // instructionDescriptionBox
            // 
            this.instructionDescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructionDescriptionBox.Location = new System.Drawing.Point(12, 155);
            this.instructionDescriptionBox.Multiline = true;
            this.instructionDescriptionBox.Name = "instructionDescriptionBox";
            this.instructionDescriptionBox.ReadOnly = true;
            this.instructionDescriptionBox.Size = new System.Drawing.Size(437, 77);
            this.instructionDescriptionBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instruction";
            // 
            // accBox
            // 
            this.accBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accBox.Location = new System.Drawing.Point(295, 20);
            this.accBox.Name = "accBox";
            this.accBox.ReadOnly = true;
            this.accBox.Size = new System.Drawing.Size(154, 35);
            this.accBox.TabIndex = 3;
            this.accBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(203, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Accumulator";
            // 
            // ir
            // 
            this.ir.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ir.Location = new System.Drawing.Point(139, 11);
            this.ir.Name = "ir";
            this.ir.ReadOnly = true;
            this.ir.Size = new System.Drawing.Size(58, 56);
            this.ir.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(3, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(130, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Instruction Register";
            // 
            // memoryTopPanel
            // 
            this.memoryTopPanel.Controls.Add(this.memoryGrid);
            this.memoryTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.memoryTopPanel.Location = new System.Drawing.Point(0, 0);
            this.memoryTopPanel.Name = "memoryTopPanel";
            this.memoryTopPanel.Size = new System.Drawing.Size(464, 348);
            this.memoryTopPanel.TabIndex = 1;
            // 
            // memoryGrid
            // 
            this.memoryGrid.AllowUserToAddRows = false;
            this.memoryGrid.AllowUserToDeleteRows = false;
            this.memoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryGrid.Location = new System.Drawing.Point(0, 0);
            this.memoryGrid.Name = "memoryGrid";
            this.memoryGrid.RowHeadersWidth = 50;
            this.memoryGrid.Size = new System.Drawing.Size(464, 348);
            this.memoryGrid.TabIndex = 0;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Controls.Add(this.output);
            this.controlsPanel.Controls.Add(this.loadToMemory);
            this.controlsPanel.Controls.Add(this.startFromTheBeginning);
            this.controlsPanel.Controls.Add(this.runNextLine);
            this.controlsPanel.Controls.Add(this.code);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(464, 0);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(346, 590);
            this.controlsPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вывод программы";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(6, 424);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(328, 107);
            this.output.TabIndex = 5;
            this.output.Text = "";
            // 
            // loadToMemory
            // 
            this.loadToMemory.Location = new System.Drawing.Point(6, 354);
            this.loadToMemory.Name = "loadToMemory";
            this.loadToMemory.Size = new System.Drawing.Size(106, 51);
            this.loadToMemory.TabIndex = 4;
            this.loadToMemory.Text = "Загрузить программу в память";
            this.loadToMemory.UseVisualStyleBackColor = true;
            this.loadToMemory.Click += new System.EventHandler(this.loadToMemory_Click);
            // 
            // startFromTheBeginning
            // 
            this.startFromTheBeginning.Location = new System.Drawing.Point(118, 354);
            this.startFromTheBeginning.Name = "startFromTheBeginning";
            this.startFromTheBeginning.Size = new System.Drawing.Size(106, 51);
            this.startFromTheBeginning.TabIndex = 3;
            this.startFromTheBeginning.Text = "Начать выполнение с адреса 0";
            this.startFromTheBeginning.UseVisualStyleBackColor = true;
            this.startFromTheBeginning.Click += new System.EventHandler(this.startFromTheBeginning_Click);
            // 
            // runNextLine
            // 
            this.runNextLine.Location = new System.Drawing.Point(230, 354);
            this.runNextLine.Name = "runNextLine";
            this.runNextLine.Size = new System.Drawing.Size(106, 51);
            this.runNextLine.TabIndex = 2;
            this.runNextLine.Text = "Выполнить следующую инструкцию";
            this.runNextLine.UseVisualStyleBackColor = true;
            this.runNextLine.Click += new System.EventHandler(this.runNextLine_Click);
            // 
            // code
            // 
            this.code.Dock = System.Windows.Forms.DockStyle.Top;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.code.Location = new System.Drawing.Point(0, 0);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(346, 348);
            this.code.TabIndex = 0;
            this.code.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.memoryPanel);
            this.Name = "Form1";
            this.Text = "Simpletron Visual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.memoryPanel.ResumeLayout(false);
            this.registersPanel.ResumeLayout(false);
            this.registersPanel.PerformLayout();
            this.memoryTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoryGrid)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel memoryPanel;
        private System.Windows.Forms.DataGridView memoryGrid;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.RichTextBox code;
        private System.Windows.Forms.Button startFromTheBeginning;
        private System.Windows.Forms.Button runNextLine;
        private System.Windows.Forms.Button loadToMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Panel memoryTopPanel;
        private System.Windows.Forms.Panel registersPanel;
        private System.Windows.Forms.TextBox accBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ir;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox instructionDescriptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox instructionAddressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox instructionBox;
        private System.Windows.Forms.Button clearMemory;
    }
}

