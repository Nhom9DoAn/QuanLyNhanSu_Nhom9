using Microsoft.ML;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.ModelTrain
{
    public partial class PredictForm : UIPage
    {
        private readonly MLContext _context;
        private readonly ITransformer _trainedModel;
        public PredictForm()
        {
            InitializeComponent();
            _context = new MLContext();

            // Tải mô hình từ tệp
            using (var fileStream = new FileStream("model.zip", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                _trainedModel = _context.Model.Load(fileStream, out var modelInputSchema);
            }

            // Thiết lập các giá trị cho ComboBox
            comboBoxExperienceLevel.Items.AddRange(new string[] { "EN", "MI", "SE", "EX" });
            comboBoxEmploymentType.Items.AddRange(new string[] { "FT", "PT", "CT", "FL" });
            comboBoxJobTitle.Items.AddRange(new string[] { "Data Scientist", "Software Engineer", "Data Analyst", "Data Engineer", "Research Engineer\r\n" });
            comboBoxCompanySize.Items.AddRange(new string[] { "S", "M", "L" });
        
    }

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo dữ liệu mẫu để kiểm tra
                var sampleData = new JobData
                {
                    ExperienceLevel = comboBoxExperienceLevel.SelectedItem.ToString(),
                    EmploymentType = comboBoxEmploymentType.SelectedItem.ToString(),
                    JobTitle = comboBoxJobTitle.SelectedItem.ToString(),
                    RemoteRatio = (float)numericUpDownRemoteRatio.Value,
                    CompanySize = comboBoxCompanySize.SelectedItem.ToString(),
                    SalaryInUSD = 0 // Giá trị này sẽ được dự đoán
                };

                // Tạo prediction engine
                var predictionEngine = _context.Model.CreatePredictionEngine<JobData, SalaryPrediction>(_trainedModel);

                // Dự đoán
                var prediction = predictionEngine.Predict(sampleData);

                // Hiển thị kết quả dự đoán
                MessageBox.Show($"Predicted Salary: {prediction.PredictedSalary}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void numericUpDownRemoteRatio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

