
namespace JabRegister
{
    partial class FormMain
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
            this.lblDtNasc = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpDtNasc = new System.Windows.Forms.DateTimePicker();
            this.txtEndereco = new MaterialSkin.Controls.MaterialTextBox();
            this.rdoGenO = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdoGenM = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblGen = new MaterialSkin.Controls.MaterialLabel();
            this.rdoGenF = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtTel = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCpf = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Depth = 0;
            this.lblDtNasc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDtNasc.Location = new System.Drawing.Point(30, 532);
            this.lblDtNasc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(149, 19);
            this.lblDtNasc.TabIndex = 41;
            this.lblDtNasc.Text = "Data de Nascimento:";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "Email:";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(30, 239);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(391, 50);
            this.txtEmail.TabIndex = 40;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // dtpDtNasc
            // 
            this.dtpDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNasc.Location = new System.Drawing.Point(30, 554);
            this.dtpDtNasc.Name = "dtpDtNasc";
            this.dtpDtNasc.Size = new System.Drawing.Size(391, 26);
            this.dtpDtNasc.TabIndex = 39;
            // 
            // txtEndereco
            // 
            this.txtEndereco.AnimateReadOnly = false;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndereco.Hint = "Endereço:";
            this.txtEndereco.LeadingIcon = null;
            this.txtEndereco.Location = new System.Drawing.Point(30, 474);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEndereco.Multiline = false;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(391, 50);
            this.txtEndereco.TabIndex = 38;
            this.txtEndereco.Text = "";
            this.txtEndereco.TrailingIcon = null;
            // 
            // rdoGenO
            // 
            this.rdoGenO.AutoSize = true;
            this.rdoGenO.Depth = 0;
            this.rdoGenO.Location = new System.Drawing.Point(30, 426);
            this.rdoGenO.Margin = new System.Windows.Forms.Padding(0);
            this.rdoGenO.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoGenO.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoGenO.Name = "rdoGenO";
            this.rdoGenO.Ripple = true;
            this.rdoGenO.Size = new System.Drawing.Size(74, 37);
            this.rdoGenO.TabIndex = 37;
            this.rdoGenO.TabStop = true;
            this.rdoGenO.Text = "Outro";
            this.rdoGenO.UseVisualStyleBackColor = true;
            // 
            // rdoGenM
            // 
            this.rdoGenM.AutoSize = true;
            this.rdoGenM.Depth = 0;
            this.rdoGenM.Location = new System.Drawing.Point(30, 380);
            this.rdoGenM.Margin = new System.Windows.Forms.Padding(0);
            this.rdoGenM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoGenM.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoGenM.Name = "rdoGenM";
            this.rdoGenM.Ripple = true;
            this.rdoGenM.Size = new System.Drawing.Size(109, 37);
            this.rdoGenM.TabIndex = 36;
            this.rdoGenM.TabStop = true;
            this.rdoGenM.Text = "Masculino";
            this.rdoGenM.UseVisualStyleBackColor = true;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Depth = 0;
            this.lblGen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGen.Location = new System.Drawing.Point(30, 303);
            this.lblGen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(55, 19);
            this.lblGen.TabIndex = 35;
            this.lblGen.Text = "Gênero:";
            // 
            // rdoGenF
            // 
            this.rdoGenF.AutoSize = true;
            this.rdoGenF.Depth = 0;
            this.rdoGenF.Location = new System.Drawing.Point(30, 333);
            this.rdoGenF.Margin = new System.Windows.Forms.Padding(0);
            this.rdoGenF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoGenF.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdoGenF.Name = "rdoGenF";
            this.rdoGenF.Ripple = true;
            this.rdoGenF.Size = new System.Drawing.Size(101, 37);
            this.rdoGenF.TabIndex = 34;
            this.rdoGenF.TabStop = true;
            this.rdoGenF.Text = "Feminino";
            this.rdoGenF.UseVisualStyleBackColor = true;
            // 
            // txtTel
            // 
            this.txtTel.AllowPromptAsInput = true;
            this.txtTel.AnimateReadOnly = false;
            this.txtTel.AsciiOnly = false;
            this.txtTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTel.BeepOnError = false;
            this.txtTel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTel.Depth = 0;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTel.HidePromptOnLeave = false;
            this.txtTel.HideSelection = true;
            this.txtTel.Hint = "Telefone:";
            this.txtTel.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTel.LeadingIcon = null;
            this.txtTel.Location = new System.Drawing.Point(30, 185);
            this.txtTel.Mask = "(99) 9999-9999";
            this.txtTel.MaxLength = 32767;
            this.txtTel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.PrefixSuffixText = null;
            this.txtTel.PromptChar = '_';
            this.txtTel.ReadOnly = false;
            this.txtTel.RejectInputOnFirstFailure = false;
            this.txtTel.ResetOnPrompt = true;
            this.txtTel.ResetOnSpace = true;
            this.txtTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTel.SelectedText = "";
            this.txtTel.SelectionLength = 0;
            this.txtTel.SelectionStart = 0;
            this.txtTel.ShortcutsEnabled = true;
            this.txtTel.Size = new System.Drawing.Size(391, 48);
            this.txtTel.SkipLiterals = true;
            this.txtTel.TabIndex = 33;
            this.txtTel.TabStop = false;
            this.txtTel.Text = "(  )     -";
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTel.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTel.TrailingIcon = null;
            this.txtTel.UseSystemPasswordChar = false;
            this.txtTel.ValidatingType = null;
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Hint = "Nome:";
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(30, 75);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(391, 50);
            this.txtName.TabIndex = 32;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            // 
            // txtCpf
            // 
            this.txtCpf.AllowPromptAsInput = true;
            this.txtCpf.AnimateReadOnly = false;
            this.txtCpf.AsciiOnly = false;
            this.txtCpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCpf.BeepOnError = false;
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCpf.Depth = 0;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCpf.HidePromptOnLeave = false;
            this.txtCpf.HideSelection = true;
            this.txtCpf.Hint = "CPF:";
            this.txtCpf.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCpf.LeadingIcon = null;
            this.txtCpf.Location = new System.Drawing.Point(30, 131);
            this.txtCpf.Mask = "999.999.999-99";
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.PrefixSuffixText = null;
            this.txtCpf.PromptChar = '_';
            this.txtCpf.ReadOnly = false;
            this.txtCpf.RejectInputOnFirstFailure = false;
            this.txtCpf.ResetOnPrompt = true;
            this.txtCpf.ResetOnSpace = true;
            this.txtCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.ShortcutsEnabled = true;
            this.txtCpf.Size = new System.Drawing.Size(391, 48);
            this.txtCpf.SkipLiterals = true;
            this.txtCpf.TabIndex = 31;
            this.txtCpf.TabStop = false;
            this.txtCpf.Text = "   .   .   -";
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCpf.TrailingIcon = null;
            this.txtCpf.UseSystemPasswordChar = false;
            this.txtCpf.ValidatingType = null;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AutoSize = false;
            this.btnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.HighEmphasis = true;
            this.btnCadastrar.Icon = null;
            this.btnCadastrar.Location = new System.Drawing.Point(30, 589);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrar.Size = new System.Drawing.Size(391, 36);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrar.UseAccentColor = false;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpDtNasc);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.rdoGenO);
            this.Controls.Add(this.rdoGenM);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.rdoGenF);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCpf);
            this.Name = "FormMain";
            this.Text = "JAB Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblDtNasc;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDtNasc;
        private MaterialSkin.Controls.MaterialTextBox txtEndereco;
        private MaterialSkin.Controls.MaterialRadioButton rdoGenO;
        private MaterialSkin.Controls.MaterialRadioButton rdoGenM;
        private MaterialSkin.Controls.MaterialLabel lblGen;
        private MaterialSkin.Controls.MaterialRadioButton rdoGenF;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTel;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtCpf;
        private MaterialSkin.Controls.MaterialButton btnCadastrar;
    }
}