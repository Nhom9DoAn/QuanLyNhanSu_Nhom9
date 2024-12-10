using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML.Trainers;
using System.IO;
using Sunny.UI;

namespace Main.ModelTrain
{
    public partial class ModelForm : UIPage
    {
        public ModelForm()
        {
            InitializeComponent();
        }
        
        private void ModelForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var context = new MLContext();
                // Tải dữ liệu từ tệp CSV
                var dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ds_salaries.csv");
                var data = context.Data.LoadFromTextFile<JobData>(dataPath, separatorChar: ',', hasHeader: true);


                // Chia dữ liệu thành tập huấn luyện và tập kiểm tra
                var trainTestSplit = context.Data.TrainTestSplit(data, testFraction: 0.2);

                // Xây dựng pipeline
                var pipeline = context.Transforms.Categorical.OneHotEncoding("ExperienceLevel")
                    .Append(context.Transforms.Categorical.OneHotEncoding("EmploymentType"))
                    .Append(context.Transforms.Categorical.OneHotEncoding("JobTitle"))
                    .Append(context.Transforms.Categorical.OneHotEncoding("CompanySize"))
                    .Append(context.Transforms.Concatenate("Features", "ExperienceLevel", "EmploymentType", "JobTitle", "RemoteRatio", "CompanySize"))
                    .Append(context.Regression.Trainers.FastTree(labelColumnName: "SalaryInUSD", numberOfTrees: 200, learningRate: 0.1, numberOfLeaves: 30));

                // Huấn luyện mô hình
                var model = pipeline.Fit(trainTestSplit.TrainSet);
                var predictions = model.Transform(trainTestSplit.TestSet);
                var metrics = context.Regression.Evaluate(predictions, labelColumnName: "SalaryInUSD");

                // Hiển thị chỉ số R²
                MessageBox.Show($"R^2: {metrics.RSquared}");

                // Lưu mô hình vào tệp
                using (var fileStream = new FileStream("model.zip", FileMode.Create, FileAccess.Write, FileShare.Write))
                {
                    context.Model.Save(model, trainTestSplit.TrainSet.Schema, fileStream);
                    MessageBox.Show("Đã lưu mô hình");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            var context = new MLContext();
            var dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ds_salaries.csv");
            var data = context.Data.LoadFromTextFile<JobData>(dataPath, separatorChar: ',', hasHeader: true);
            var jobDataList = context.Data.CreateEnumerable<JobData>(data, reuseRowObject: false).ToList();
            dataGridView1.DataSource = jobDataList;
        }
    }
}
