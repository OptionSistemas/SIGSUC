namespace SIGSUC.Desktop.Forms.Config
{
    partial class frmSqliteUsers
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtPasswordC = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkAgricola = new DevExpress.XtraEditors.CheckEdit();
            this.chkAlmoxarifado = new DevExpress.XtraEditors.CheckEdit();
            this.chkAdministrador = new DevExpress.XtraEditors.CheckEdit();
            this.grdSqliteUsers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkAtivo = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAgricola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAlmoxarifado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdministrador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSqliteUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAtivo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Login";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nome Completo do Usuário";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Informe a Senha";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 162);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(112, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Confirmação Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(12, 34);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(125, 22);
            this.txtLogin.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(13, 84);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(420, 22);
            this.txtUser.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(13, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(204, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // txtPasswordC
            // 
            this.txtPasswordC.Location = new System.Drawing.Point(12, 184);
            this.txtPasswordC.Name = "txtPasswordC";
            this.txtPasswordC.Properties.UseSystemPasswordChar = true;
            this.txtPasswordC.Size = new System.Drawing.Size(205, 22);
            this.txtPasswordC.TabIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkAgricola);
            this.groupControl1.Controls.Add(this.chkAlmoxarifado);
            this.groupControl1.Controls.Add(this.chkAdministrador);
            this.groupControl1.Location = new System.Drawing.Point(439, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(218, 194);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Acesso";
            // 
            // chkAgricola
            // 
            this.chkAgricola.Location = new System.Drawing.Point(16, 89);
            this.chkAgricola.Name = "chkAgricola";
            this.chkAgricola.Properties.Caption = "Agrícola";
            this.chkAgricola.Size = new System.Drawing.Size(112, 20);
            this.chkAgricola.TabIndex = 2;
            // 
            // chkAlmoxarifado
            // 
            this.chkAlmoxarifado.Location = new System.Drawing.Point(16, 63);
            this.chkAlmoxarifado.Name = "chkAlmoxarifado";
            this.chkAlmoxarifado.Properties.Caption = "Almoxaridado";
            this.chkAlmoxarifado.Size = new System.Drawing.Size(112, 20);
            this.chkAlmoxarifado.TabIndex = 1;
            // 
            // chkAdministrador
            // 
            this.chkAdministrador.Location = new System.Drawing.Point(16, 37);
            this.chkAdministrador.Name = "chkAdministrador";
            this.chkAdministrador.Properties.Caption = "Administrador";
            this.chkAdministrador.Size = new System.Drawing.Size(112, 20);
            this.chkAdministrador.TabIndex = 0;
            // 
            // grdSqliteUsers
            // 
            this.grdSqliteUsers.Location = new System.Drawing.Point(12, 244);
            this.grdSqliteUsers.MainView = this.gridView1;
            this.grdSqliteUsers.Name = "grdSqliteUsers";
            this.grdSqliteUsers.Size = new System.Drawing.Size(644, 279);
            this.grdSqliteUsers.TabIndex = 9;
            this.grdSqliteUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.grdSqliteUsers;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.GridView1_CustomUnboundColumnData);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Login";
            this.gridColumn1.FieldName = "Login_";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Usuário";
            this.gridColumn2.FieldName = "User_";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(563, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Sair";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(14, 529);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "Novo";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.EditValue = true;
            this.chkAtivo.Location = new System.Drawing.Point(256, 185);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Properties.Caption = "Usuário Ativo";
            this.chkAtivo.Size = new System.Drawing.Size(128, 20);
            this.chkAtivo.TabIndex = 13;
            // 
            // frmSqliteUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 580);
            this.ControlBox = false;
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grdSqliteUsers);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtPasswordC);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSqliteUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários do Sistema";
            this.Load += new System.EventHandler(this.FrmSqliteUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkAgricola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAlmoxarifado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdministrador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSqliteUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAtivo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtPasswordC;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkAgricola;
        private DevExpress.XtraEditors.CheckEdit chkAlmoxarifado;
        private DevExpress.XtraEditors.CheckEdit chkAdministrador;
        private DevExpress.XtraGrid.GridControl grdSqliteUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.CheckEdit chkAtivo;
    }
}