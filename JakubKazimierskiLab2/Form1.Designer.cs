namespace JakubKazimierskiLab2
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewVehicleAdder = new System.Windows.Forms.GroupBox();
            this.TramwajRadioButton = new System.Windows.Forms.RadioButton();
            this.AutobusRadioButton = new System.Windows.Forms.RadioButton();
            this.NrPojazduLabel = new System.Windows.Forms.Label();
            this.RokProdukcjiLabel = new System.Windows.Forms.Label();
            this.VehicleModelLabel = new System.Windows.Forms.Label();
            this.NrVehicleTextBox = new System.Windows.Forms.TextBox();
            this.YearOfProductionTextBox = new System.Windows.Forms.TextBox();
            this.ModelOfVehicleTextBox = new System.Windows.Forms.TextBox();
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.MyNameLabel = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.labelActualVehicle = new System.Windows.Forms.Label();
            this.labelActualNumberVehicle = new System.Windows.Forms.Label();
            this.labelActualYearOfProduction = new System.Windows.Forms.Label();
            this.labelActualModel = new System.Windows.Forms.Label();
            this.labelActualVechicleDescription = new System.Windows.Forms.Label();
            this.labelActualNumberDescription = new System.Windows.Forms.Label();
            this.labelActualYearOfProductionDescription = new System.Windows.Forms.Label();
            this.labelActuallModelDescription = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonStartVehicle = new System.Windows.Forms.Button();
            this.buttonBell = new System.Windows.Forms.Button();
            this.buttonPanthographDown = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonStopVehicle = new System.Windows.Forms.Button();
            this.buttonRefuel = new System.Windows.Forms.Button();
            this.buttonPanthographUp = new System.Windows.Forms.Button();
            this.NewVehicleAdder.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewVehicleAdder
            // 
            this.NewVehicleAdder.Controls.Add(this.AddVehicleButton);
            this.NewVehicleAdder.Controls.Add(this.ModelOfVehicleTextBox);
            this.NewVehicleAdder.Controls.Add(this.YearOfProductionTextBox);
            this.NewVehicleAdder.Controls.Add(this.NrVehicleTextBox);
            this.NewVehicleAdder.Controls.Add(this.VehicleModelLabel);
            this.NewVehicleAdder.Controls.Add(this.RokProdukcjiLabel);
            this.NewVehicleAdder.Controls.Add(this.NrPojazduLabel);
            this.NewVehicleAdder.Controls.Add(this.AutobusRadioButton);
            this.NewVehicleAdder.Controls.Add(this.TramwajRadioButton);
            this.NewVehicleAdder.Location = new System.Drawing.Point(3, 12);
            this.NewVehicleAdder.Name = "NewVehicleAdder";
            this.NewVehicleAdder.Size = new System.Drawing.Size(263, 237);
            this.NewVehicleAdder.TabIndex = 0;
            this.NewVehicleAdder.TabStop = false;
            this.NewVehicleAdder.Text = "Utworz nowy pojazd";
            // 
            // TramwajRadioButton
            // 
            this.TramwajRadioButton.AutoSize = true;
            this.TramwajRadioButton.Checked = true;
            this.TramwajRadioButton.Location = new System.Drawing.Point(33, 41);
            this.TramwajRadioButton.Name = "TramwajRadioButton";
            this.TramwajRadioButton.Size = new System.Drawing.Size(65, 17);
            this.TramwajRadioButton.TabIndex = 0;
            this.TramwajRadioButton.TabStop = true;
            this.TramwajRadioButton.Text = "Tramwaj";
            this.TramwajRadioButton.UseVisualStyleBackColor = true;
            // 
            // AutobusRadioButton
            // 
            this.AutobusRadioButton.AutoSize = true;
            this.AutobusRadioButton.Location = new System.Drawing.Point(170, 41);
            this.AutobusRadioButton.Name = "AutobusRadioButton";
            this.AutobusRadioButton.Size = new System.Drawing.Size(64, 17);
            this.AutobusRadioButton.TabIndex = 1;
            this.AutobusRadioButton.Text = "Autobus";
            this.AutobusRadioButton.UseVisualStyleBackColor = true;
            // 
            // NrPojazduLabel
            // 
            this.NrPojazduLabel.AutoSize = true;
            this.NrPojazduLabel.Location = new System.Drawing.Point(34, 92);
            this.NrPojazduLabel.Name = "NrPojazduLabel";
            this.NrPojazduLabel.Size = new System.Drawing.Size(76, 13);
            this.NrPojazduLabel.TabIndex = 2;
            this.NrPojazduLabel.Text = "NumerPojazdu";
            // 
            // RokProdukcjiLabel
            // 
            this.RokProdukcjiLabel.AutoSize = true;
            this.RokProdukcjiLabel.Location = new System.Drawing.Point(34, 120);
            this.RokProdukcjiLabel.Name = "RokProdukcjiLabel";
            this.RokProdukcjiLabel.Size = new System.Drawing.Size(71, 13);
            this.RokProdukcjiLabel.TabIndex = 3;
            this.RokProdukcjiLabel.Text = "RokProdukcji";
            // 
            // VehicleModelLabel
            // 
            this.VehicleModelLabel.AutoSize = true;
            this.VehicleModelLabel.Location = new System.Drawing.Point(34, 147);
            this.VehicleModelLabel.Name = "VehicleModelLabel";
            this.VehicleModelLabel.Size = new System.Drawing.Size(36, 13);
            this.VehicleModelLabel.TabIndex = 4;
            this.VehicleModelLabel.Text = "Model";
            // 
            // NrVehicleTextBox
            // 
            this.NrVehicleTextBox.Location = new System.Drawing.Point(145, 92);
            this.NrVehicleTextBox.Name = "NrVehicleTextBox";
            this.NrVehicleTextBox.Size = new System.Drawing.Size(100, 20);
            this.NrVehicleTextBox.TabIndex = 5;
            // 
            // YearOfProductionTextBox
            // 
            this.YearOfProductionTextBox.Location = new System.Drawing.Point(145, 120);
            this.YearOfProductionTextBox.Name = "YearOfProductionTextBox";
            this.YearOfProductionTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearOfProductionTextBox.TabIndex = 6;
            // 
            // ModelOfVehicleTextBox
            // 
            this.ModelOfVehicleTextBox.Location = new System.Drawing.Point(145, 147);
            this.ModelOfVehicleTextBox.Name = "ModelOfVehicleTextBox";
            this.ModelOfVehicleTextBox.Size = new System.Drawing.Size(100, 20);
            this.ModelOfVehicleTextBox.TabIndex = 7;
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Location = new System.Drawing.Point(61, 195);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(132, 36);
            this.AddVehicleButton.TabIndex = 8;
            this.AddVehicleButton.Text = "Dodaj Nowy Pojazd";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // MyNameLabel
            // 
            this.MyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MyNameLabel.Location = new System.Drawing.Point(0, 331);
            this.MyNameLabel.Name = "MyNameLabel";
            this.MyNameLabel.Size = new System.Drawing.Size(157, 28);
            this.MyNameLabel.TabIndex = 1;
            this.MyNameLabel.Text = "Jakub Kazimierski";
            this.MyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.buttonPanthographUp);
            this.groupBoxList.Controls.Add(this.buttonRefuel);
            this.groupBoxList.Controls.Add(this.buttonStopVehicle);
            this.groupBoxList.Controls.Add(this.buttonNext);
            this.groupBoxList.Controls.Add(this.buttonPanthographDown);
            this.groupBoxList.Controls.Add(this.buttonBell);
            this.groupBoxList.Controls.Add(this.buttonStartVehicle);
            this.groupBoxList.Controls.Add(this.buttonPrevious);
            this.groupBoxList.Controls.Add(this.labelActuallModelDescription);
            this.groupBoxList.Controls.Add(this.labelActualYearOfProductionDescription);
            this.groupBoxList.Controls.Add(this.labelActualNumberDescription);
            this.groupBoxList.Controls.Add(this.labelActualVechicleDescription);
            this.groupBoxList.Controls.Add(this.labelActualModel);
            this.groupBoxList.Controls.Add(this.labelActualYearOfProduction);
            this.groupBoxList.Controls.Add(this.labelActualNumberVehicle);
            this.groupBoxList.Controls.Add(this.labelActualVehicle);
            this.groupBoxList.Location = new System.Drawing.Point(272, 24);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(357, 332);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "ListaPojazdow";
            // 
            // labelActualVehicle
            // 
            this.labelActualVehicle.AutoSize = true;
            this.labelActualVehicle.Location = new System.Drawing.Point(6, 33);
            this.labelActualVehicle.Name = "labelActualVehicle";
            this.labelActualVehicle.Size = new System.Drawing.Size(88, 13);
            this.labelActualVehicle.TabIndex = 3;
            this.labelActualVehicle.Text = "Aktualny pojazd: ";
            // 
            // labelActualNumberVehicle
            // 
            this.labelActualNumberVehicle.AutoSize = true;
            this.labelActualNumberVehicle.Location = new System.Drawing.Point(6, 69);
            this.labelActualNumberVehicle.Name = "labelActualNumberVehicle";
            this.labelActualNumberVehicle.Size = new System.Drawing.Size(64, 13);
            this.labelActualNumberVehicle.TabIndex = 4;
            this.labelActualNumberVehicle.Text = "Nr pojazdu: ";
            // 
            // labelActualYearOfProduction
            // 
            this.labelActualYearOfProduction.AutoSize = true;
            this.labelActualYearOfProduction.Location = new System.Drawing.Point(6, 105);
            this.labelActualYearOfProduction.Name = "labelActualYearOfProduction";
            this.labelActualYearOfProduction.Size = new System.Drawing.Size(73, 13);
            this.labelActualYearOfProduction.TabIndex = 5;
            this.labelActualYearOfProduction.Text = "Rok produkcji";
            // 
            // labelActualModel
            // 
            this.labelActualModel.AutoSize = true;
            this.labelActualModel.Location = new System.Drawing.Point(6, 141);
            this.labelActualModel.Name = "labelActualModel";
            this.labelActualModel.Size = new System.Drawing.Size(36, 13);
            this.labelActualModel.TabIndex = 6;
            this.labelActualModel.Text = "Model";
            // 
            // labelActualVechicleDescription
            // 
            this.labelActualVechicleDescription.AutoSize = true;
            this.labelActualVechicleDescription.Location = new System.Drawing.Point(124, 33);
            this.labelActualVechicleDescription.Name = "labelActualVechicleDescription";
            this.labelActualVechicleDescription.Size = new System.Drawing.Size(14, 13);
            this.labelActualVechicleDescription.TabIndex = 7;
            this.labelActualVechicleDescription.Text = "#";
            // 
            // labelActualNumberDescription
            // 
            this.labelActualNumberDescription.AutoSize = true;
            this.labelActualNumberDescription.Location = new System.Drawing.Point(124, 69);
            this.labelActualNumberDescription.Name = "labelActualNumberDescription";
            this.labelActualNumberDescription.Size = new System.Drawing.Size(14, 13);
            this.labelActualNumberDescription.TabIndex = 8;
            this.labelActualNumberDescription.Text = "#";
            // 
            // labelActualYearOfProductionDescription
            // 
            this.labelActualYearOfProductionDescription.AutoSize = true;
            this.labelActualYearOfProductionDescription.Location = new System.Drawing.Point(124, 105);
            this.labelActualYearOfProductionDescription.Name = "labelActualYearOfProductionDescription";
            this.labelActualYearOfProductionDescription.Size = new System.Drawing.Size(14, 13);
            this.labelActualYearOfProductionDescription.TabIndex = 9;
            this.labelActualYearOfProductionDescription.Text = "#";
            // 
            // labelActuallModelDescription
            // 
            this.labelActuallModelDescription.AutoSize = true;
            this.labelActuallModelDescription.Location = new System.Drawing.Point(124, 141);
            this.labelActuallModelDescription.Name = "labelActuallModelDescription";
            this.labelActuallModelDescription.Size = new System.Drawing.Size(14, 13);
            this.labelActuallModelDescription.TabIndex = 10;
            this.labelActuallModelDescription.Text = "#";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(9, 197);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(70, 28);
            this.buttonPrevious.TabIndex = 11;
            this.buttonPrevious.Text = "Poprzedni";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonStartVehicle
            // 
            this.buttonStartVehicle.Location = new System.Drawing.Point(9, 231);
            this.buttonStartVehicle.Name = "buttonStartVehicle";
            this.buttonStartVehicle.Size = new System.Drawing.Size(70, 28);
            this.buttonStartVehicle.TabIndex = 12;
            this.buttonStartVehicle.Text = "Rusz";
            this.buttonStartVehicle.UseVisualStyleBackColor = true;
            this.buttonStartVehicle.Click += new System.EventHandler(this.buttonStartVehicle_Click);
            // 
            // buttonBell
            // 
            this.buttonBell.Location = new System.Drawing.Point(9, 265);
            this.buttonBell.Name = "buttonBell";
            this.buttonBell.Size = new System.Drawing.Size(70, 28);
            this.buttonBell.TabIndex = 13;
            this.buttonBell.Text = "Dzwonek";
            this.buttonBell.UseVisualStyleBackColor = true;
            this.buttonBell.Click += new System.EventHandler(this.buttonBell_Click);
            // 
            // buttonPanthographDown
            // 
            this.buttonPanthographDown.Location = new System.Drawing.Point(9, 299);
            this.buttonPanthographDown.Name = "buttonPanthographDown";
            this.buttonPanthographDown.Size = new System.Drawing.Size(97, 28);
            this.buttonPanthographDown.TabIndex = 14;
            this.buttonPanthographDown.Text = "Opusc Pantograf";
            this.buttonPanthographDown.UseVisualStyleBackColor = true;
            this.buttonPanthographDown.Click += new System.EventHandler(this.buttonPanthographDown_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(127, 197);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(70, 28);
            this.buttonNext.TabIndex = 15;
            this.buttonNext.Text = "Nastepny";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonStopVehicle
            // 
            this.buttonStopVehicle.Location = new System.Drawing.Point(127, 231);
            this.buttonStopVehicle.Name = "buttonStopVehicle";
            this.buttonStopVehicle.Size = new System.Drawing.Size(70, 28);
            this.buttonStopVehicle.TabIndex = 16;
            this.buttonStopVehicle.Text = "Zatrzymaj";
            this.buttonStopVehicle.UseVisualStyleBackColor = true;
            this.buttonStopVehicle.Click += new System.EventHandler(this.buttonStopVehicle_Click);
            // 
            // buttonRefuel
            // 
            this.buttonRefuel.Location = new System.Drawing.Point(127, 265);
            this.buttonRefuel.Name = "buttonRefuel";
            this.buttonRefuel.Size = new System.Drawing.Size(70, 28);
            this.buttonRefuel.TabIndex = 17;
            this.buttonRefuel.Text = "Zatankuj";
            this.buttonRefuel.UseVisualStyleBackColor = true;
            this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // buttonPanthographUp
            // 
            this.buttonPanthographUp.Location = new System.Drawing.Point(127, 298);
            this.buttonPanthographUp.Name = "buttonPanthographUp";
            this.buttonPanthographUp.Size = new System.Drawing.Size(112, 28);
            this.buttonPanthographUp.TabIndex = 18;
            this.buttonPanthographUp.Text = "Podnies Pantograf";
            this.buttonPanthographUp.UseVisualStyleBackColor = true;
            this.buttonPanthographUp.Click += new System.EventHandler(this.buttonPanthographUp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 368);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.MyNameLabel);
            this.Controls.Add(this.NewVehicleAdder);
            this.Name = "FormMain";
            this.Text = "JakubKazimierskiAplikacjaMPK";
            this.NewVehicleAdder.ResumeLayout(false);
            this.NewVehicleAdder.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewVehicleAdder;
        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.TextBox ModelOfVehicleTextBox;
        private System.Windows.Forms.TextBox YearOfProductionTextBox;
        private System.Windows.Forms.TextBox NrVehicleTextBox;
        private System.Windows.Forms.Label VehicleModelLabel;
        private System.Windows.Forms.Label RokProdukcjiLabel;
        private System.Windows.Forms.Label NrPojazduLabel;
        private System.Windows.Forms.RadioButton AutobusRadioButton;
        private System.Windows.Forms.RadioButton TramwajRadioButton;
        private System.Windows.Forms.Label MyNameLabel;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Button buttonPanthographUp;
        private System.Windows.Forms.Button buttonRefuel;
        private System.Windows.Forms.Button buttonStopVehicle;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPanthographDown;
        private System.Windows.Forms.Button buttonBell;
        private System.Windows.Forms.Button buttonStartVehicle;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelActuallModelDescription;
        private System.Windows.Forms.Label labelActualYearOfProductionDescription;
        private System.Windows.Forms.Label labelActualNumberDescription;
        private System.Windows.Forms.Label labelActualVechicleDescription;
        private System.Windows.Forms.Label labelActualModel;
        private System.Windows.Forms.Label labelActualYearOfProduction;
        private System.Windows.Forms.Label labelActualNumberVehicle;
        private System.Windows.Forms.Label labelActualVehicle;
    }
}

