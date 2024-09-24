
namespace ChapmanNames
{
    partial class formChapmanNames
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChapmanNames));
            labelNamePrompt = new System.Windows.Forms.Label();
            textBoxNameInput = new System.Windows.Forms.TextBox();
            textBoxNameList = new System.Windows.Forms.TextBox();
            labelOutput = new System.Windows.Forms.Label();
            buttonEnter = new System.Windows.Forms.Button();
            buttonReset = new System.Windows.Forms.Button();
            buttonExit = new System.Windows.Forms.Button();
            toolTip = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // labelNamePrompt
            // 
            labelNamePrompt.Location = new System.Drawing.Point(17, 13);
            labelNamePrompt.Name = "labelNamePrompt";
            labelNamePrompt.Size = new System.Drawing.Size(170, 25);
            labelNamePrompt.TabIndex = 0;
            labelNamePrompt.Text = "Enter a candidate _name:";
            // 
            // textBoxNameInput
            // 
            textBoxNameInput.Location = new System.Drawing.Point(192, 10);
            textBoxNameInput.Name = "textBoxNameInput";
            textBoxNameInput.Size = new System.Drawing.Size(153, 27);
            textBoxNameInput.TabIndex = 1;
            toolTip.SetToolTip(textBoxNameInput, "Enter a name to check for Chapman validity");
            // 
            // textBoxNameList
            // 
            textBoxNameList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            textBoxNameList.Location = new System.Drawing.Point(78, 43);
            textBoxNameList.Multiline = true;
            textBoxNameList.Name = "textBoxNameList";
            textBoxNameList.ReadOnly = true;
            textBoxNameList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBoxNameList.Size = new System.Drawing.Size(207, 157);
            textBoxNameList.TabIndex = 2;
            toolTip.SetToolTip(textBoxNameList, "List all entered valid Chapman names");
            // 
            // labelOutput
            // 
            labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            labelOutput.Location = new System.Drawing.Point(17, 212);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new System.Drawing.Size(328, 25);
            labelOutput.TabIndex = 3;
            labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip.SetToolTip(labelOutput, "Displays summary information related to entered names");
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new System.Drawing.Point(17, 251);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new System.Drawing.Size(94, 29);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "&Enter";
            toolTip.SetToolTip(buttonEnter, "Click to check the entered name's validity");
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += ButtonEnterClick;
            // 
            // buttonReset
            // 
            buttonReset.Location = new System.Drawing.Point(134, 251);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(94, 29);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "&Reset";
            toolTip.SetToolTip(buttonReset, "Click to reset the form and erase all entries");
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += ButtonResetClick;
            // 
            // buttonExit
            // 
            buttonExit.Location = new System.Drawing.Point(251, 251);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(94, 29);
            buttonExit.TabIndex = 6;
            buttonExit.Text = "E&xit";
            toolTip.SetToolTip(buttonExit, "Click to exit the application");
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExitClick;
            // 
            // formChapmanNames
            // 
            AcceptButton = buttonEnter;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = buttonReset;
            ClientSize = new System.Drawing.Size(363, 291);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonEnter);
            Controls.Add(labelOutput);
            Controls.Add(textBoxNameList);
            Controls.Add(textBoxNameInput);
            Controls.Add(labelNamePrompt);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formChapmanNames";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Chapman Namer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelNamePrompt;
        private System.Windows.Forms.TextBox textBoxNameInput;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox textBoxNameList;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
    }
}

