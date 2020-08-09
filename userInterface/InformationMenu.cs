using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using model;

namespace userInterface
{
    public partial class InformationMenu : Form
    {
        private SqliteDataAccess dataAccess;
        private int pageNumber;

        public InformationMenu()
        {
            InitializeComponent();

            dataAccess = new SqliteDataAccess();
            pageNumber = 0;

            listFlight_Dgv.DataSource = null;
            listFlight_Dgv.DataSource = dataAccess.LoadData("SELECT * FROM flightsData LIMIT 100, 5000");
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