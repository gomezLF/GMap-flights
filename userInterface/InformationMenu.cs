using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace userInterface
{
    public partial class InformationMenu : Form
    {

        private const string FLIGHTS_DATA_PATH = "";
        private int pageNumber;

        public InformationMenu()
        {
            InitializeComponent();
        }

        #region Menu Buttons

        private void Search_Click(object sender, EventArgs e)
        {
            
        }

        private void CleanUp_Click(object sender, EventArgs e)
        {
            
        }

        private void BackDataGrid_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void NextDataGrid_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        #endregion

        #region Search Options

        private void SearchTailNumber()
        {

        }

        private void SearchDateFlight()
        {

        }

        private void SearchCityOrigen()
        {

        }

        private void SearchStateOrigen()
        {

        }

        private void SearchDestinationCity()
        {

        }

        private void SearchDestinationState()
        {

        }

        #endregion

        #region Paginations options

        private void NextPage()
        {

        }

        private void PreviousPage()
        {

        }

        #endregion
    }
}