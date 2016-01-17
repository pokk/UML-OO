namespace UML_OO
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.Btn_Case = new System.Windows.Forms.Button();
            this.Btn_Class = new System.Windows.Forms.Button();
            this.Btn_Com_Line = new System.Windows.Forms.Button();
            this.Btn_Gen_Line = new System.Windows.Forms.Button();
            this.Btn_Ass_Line = new System.Windows.Forms.Button();
            this.Btn_Sel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(102, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.ungroupToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.Rename);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.Group_Click);
            // 
            // ungroupToolStripMenuItem
            // 
            this.ungroupToolStripMenuItem.Name = "ungroupToolStripMenuItem";
            this.ungroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ungroupToolStripMenuItem.Text = "Ungroup";
            this.ungroupToolStripMenuItem.Click += new System.EventHandler(this.Ungroup_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.Location = new System.Drawing.Point(133, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(664, 495);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // Btn_Case
            // 
            this.Btn_Case.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Case.Font = new System.Drawing.Font("新細明體", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Case.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Case.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Case.Image")));
            this.Btn_Case.Location = new System.Drawing.Point(12, 452);
            this.Btn_Case.Name = "Btn_Case";
            this.Btn_Case.Size = new System.Drawing.Size(115, 81);
            this.Btn_Case.TabIndex = 11;
            this.Btn_Case.UseVisualStyleBackColor = false;
            this.Btn_Case.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_Class
            // 
            this.Btn_Class.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Class.Font = new System.Drawing.Font("新細明體", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Class.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Class.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Class.Image")));
            this.Btn_Class.Location = new System.Drawing.Point(12, 369);
            this.Btn_Class.Name = "Btn_Class";
            this.Btn_Class.Size = new System.Drawing.Size(115, 81);
            this.Btn_Class.TabIndex = 10;
            this.Btn_Class.UseVisualStyleBackColor = false;
            this.Btn_Class.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_Com_Line
            // 
            this.Btn_Com_Line.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Com_Line.Font = new System.Drawing.Font("新細明體", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Com_Line.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Com_Line.Image")));
            this.Btn_Com_Line.Location = new System.Drawing.Point(12, 286);
            this.Btn_Com_Line.Name = "Btn_Com_Line";
            this.Btn_Com_Line.Size = new System.Drawing.Size(115, 81);
            this.Btn_Com_Line.TabIndex = 9;
            this.Btn_Com_Line.UseVisualStyleBackColor = false;
            this.Btn_Com_Line.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_Gen_Line
            // 
            this.Btn_Gen_Line.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Gen_Line.Font = new System.Drawing.Font("新細明體", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Gen_Line.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Gen_Line.Image")));
            this.Btn_Gen_Line.Location = new System.Drawing.Point(12, 203);
            this.Btn_Gen_Line.Name = "Btn_Gen_Line";
            this.Btn_Gen_Line.Size = new System.Drawing.Size(115, 81);
            this.Btn_Gen_Line.TabIndex = 8;
            this.Btn_Gen_Line.UseVisualStyleBackColor = false;
            this.Btn_Gen_Line.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_Ass_Line
            // 
            this.Btn_Ass_Line.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Ass_Line.Font = new System.Drawing.Font("新細明體", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Ass_Line.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_Ass_Line.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ass_Line.Image")));
            this.Btn_Ass_Line.Location = new System.Drawing.Point(12, 120);
            this.Btn_Ass_Line.Name = "Btn_Ass_Line";
            this.Btn_Ass_Line.Size = new System.Drawing.Size(115, 81);
            this.Btn_Ass_Line.TabIndex = 7;
            this.Btn_Ass_Line.UseVisualStyleBackColor = false;
            this.Btn_Ass_Line.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn_Sel
            // 
            this.Btn_Sel.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Sel.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sel.Image")));
            this.Btn_Sel.Location = new System.Drawing.Point(12, 37);
            this.Btn_Sel.Name = "Btn_Sel";
            this.Btn_Sel.Size = new System.Drawing.Size(115, 81);
            this.Btn_Sel.TabIndex = 6;
            this.Btn_Sel.UseVisualStyleBackColor = false;
            this.Btn_Sel.Click += new System.EventHandler(this.Btn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem1,
            this.ungroupToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // groupToolStripMenuItem1
            // 
            this.groupToolStripMenuItem1.Name = "groupToolStripMenuItem1";
            this.groupToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.groupToolStripMenuItem1.Text = "Group";
            this.groupToolStripMenuItem1.Click += new System.EventHandler(this.Group_Click);
            // 
            // ungroupToolStripMenuItem1
            // 
            this.ungroupToolStripMenuItem1.Name = "ungroupToolStripMenuItem1";
            this.ungroupToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ungroupToolStripMenuItem1.Text = "Ungroup";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 544);
            this.Controls.Add(this.Btn_Case);
            this.Controls.Add(this.Btn_Class);
            this.Controls.Add(this.Btn_Com_Line);
            this.Controls.Add(this.Btn_Gen_Line);
            this.Controls.Add(this.Btn_Ass_Line);
            this.Controls.Add(this.Btn_Sel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "UML";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Btn_Case;
        private System.Windows.Forms.Button Btn_Class;
        private System.Windows.Forms.Button Btn_Com_Line;
        private System.Windows.Forms.Button Btn_Gen_Line;
        private System.Windows.Forms.Button Btn_Ass_Line;
        private System.Windows.Forms.Button Btn_Sel;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ungroupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ungroupToolStripMenuItem1;
    }
}

