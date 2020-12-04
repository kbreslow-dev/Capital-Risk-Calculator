using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Capital_Risk_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            float capital = float.Parse(txtCapital.Text);
            float risk = float.Parse(txtRisk.Text) / 100;
            float entryPrice = float.Parse(txtEntryPrice.Text);
            float limitPrice = float.Parse(txtLimitPrice.Text);
            float stopPrice = float.Parse(txtStopPrice.Text);

            float profitPerShare = Math.Abs(limitPrice - entryPrice);
            float lossPerShare = Math.Abs(entryPrice - stopPrice);
            float returnRiskRatio = profitPerShare / lossPerShare;
            float numOfShares = (capital / lossPerShare) * risk;
            float returnOnCapital = profitPerShare * numOfShares;

            txtProfitPerShare.Text = profitPerShare.ToString();
            txtStopLossPerShare.Text = lossPerShare.ToString();
            txtReturnRiskRatio.Text = returnRiskRatio.ToString();
            txtNumShares.Text = numOfShares.ToString();
            txtReturnOnCapital.Text = returnOnCapital.ToString();
        }
    }
}
