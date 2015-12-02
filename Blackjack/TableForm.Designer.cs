namespace Blackjack
{
    partial class TableForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.handValue = new System.Windows.Forms.Label();
            this.houseValue = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bet1Button = new System.Windows.Forms.Button();
            this.bet5Button = new System.Windows.Forms.Button();
            this.bet25Button = new System.Windows.Forms.Button();
            this.bet100Button = new System.Windows.Forms.Button();
            this.bet500Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(127, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name Label";
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(1070, 23);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(135, 57);
            this.dealButton.TabIndex = 2;
            this.dealButton.Text = "DEAL";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(926, 744);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(107, 63);
            this.hitButton.TabIndex = 3;
            this.hitButton.Text = "HIT";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(1039, 744);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(166, 63);
            this.standButton.TabIndex = 4;
            this.standButton.Text = "STAND";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // handValue
            // 
            this.handValue.AutoSize = true;
            this.handValue.Location = new System.Drawing.Point(557, 413);
            this.handValue.Name = "handValue";
            this.handValue.Size = new System.Drawing.Size(130, 25);
            this.handValue.TabIndex = 5;
            this.handValue.Text = "Hand Value:";
            // 
            // houseValue
            // 
            this.houseValue.AutoSize = true;
            this.houseValue.Location = new System.Drawing.Point(557, 23);
            this.houseValue.Name = "houseValue";
            this.houseValue.Size = new System.Drawing.Size(147, 25);
            this.houseValue.TabIndex = 6;
            this.houseValue.Text = "House Value: ";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(557, 377);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 671);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Balance: ";
            // 
            // bet1Button
            // 
            this.bet1Button.Location = new System.Drawing.Point(32, 718);
            this.bet1Button.Name = "bet1Button";
            this.bet1Button.Size = new System.Drawing.Size(97, 42);
            this.bet1Button.TabIndex = 9;
            this.bet1Button.Text = "$1";
            this.bet1Button.UseVisualStyleBackColor = true;
            // 
            // bet5Button
            // 
            this.bet5Button.Location = new System.Drawing.Point(135, 718);
            this.bet5Button.Name = "bet5Button";
            this.bet5Button.Size = new System.Drawing.Size(97, 42);
            this.bet5Button.TabIndex = 10;
            this.bet5Button.Text = "$5";
            this.bet5Button.UseVisualStyleBackColor = true;
            // 
            // bet25Button
            // 
            this.bet25Button.Location = new System.Drawing.Point(238, 718);
            this.bet25Button.Name = "bet25Button";
            this.bet25Button.Size = new System.Drawing.Size(97, 42);
            this.bet25Button.TabIndex = 11;
            this.bet25Button.Text = "$25";
            this.bet25Button.UseVisualStyleBackColor = true;
            // 
            // bet100Button
            // 
            this.bet100Button.Location = new System.Drawing.Point(78, 766);
            this.bet100Button.Name = "bet100Button";
            this.bet100Button.Size = new System.Drawing.Size(97, 42);
            this.bet100Button.TabIndex = 12;
            this.bet100Button.Text = "$100";
            this.bet100Button.UseVisualStyleBackColor = true;
            // 
            // bet500Button
            // 
            this.bet500Button.Location = new System.Drawing.Point(181, 766);
            this.bet500Button.Name = "bet500Button";
            this.bet500Button.Size = new System.Drawing.Size(97, 42);
            this.bet500Button.TabIndex = 13;
            this.bet500Button.Text = "$500";
            this.bet500Button.UseVisualStyleBackColor = true;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 819);
            this.Controls.Add(this.bet500Button);
            this.Controls.Add(this.bet100Button);
            this.Controls.Add(this.bet25Button);
            this.Controls.Add(this.bet5Button);
            this.Controls.Add(this.bet1Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.houseValue);
            this.Controls.Add(this.handValue);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "TableForm";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label handValue;
        private System.Windows.Forms.Label houseValue;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bet1Button;
        private System.Windows.Forms.Button bet5Button;
        private System.Windows.Forms.Button bet25Button;
        private System.Windows.Forms.Button bet100Button;
        private System.Windows.Forms.Button bet500Button;
    }
}