using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using model;

namespace userInterface
{
    public partial class InformationMenu : Form
    {
        private const int DATA_PER_PAGE = 50;

        private SqliteDataAccess dataAccess;
        private string queryCommand;
        private int pageNumber;

        public InformationMenu()
        {
            InitializeComponent();

            dataAccess = new SqliteDataAccess();
            queryCommand = $"SELECT *  FROM flightsData WHERE ID >= {pageNumber} ORDER BY ID LIMIT {DATA_PER_PAGE}";
            pageNumber = 1;
        }

        private void InformationMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listFlight_Dgv.DataSource = null;
            listFlight_Dgv.DataSource = dataAccess.LoadData(queryCommand);
            CheckPaginationLimits();
        }

        #region Menu Buttons

        private void Search_Click(object sender, EventArgs e)
        {
            queryCommand = $"SELECT *  FROM flightsData WHERE ID >= {pageNumber}";

            SearchTailNumber();
            //SearchDateFlight();
            //SearchCityOrigen();
            //SearchStateOrigen();
            //SearchDestinationCity();
            //SearchDestinationState();

            queryCommand = $"{queryCommand} ORDER BY ID LIMIT {DATA_PER_PAGE}";
            LoadData();
        }

        private void CleanUp_Click(object sender, EventArgs e)
        {
            tailNumber_txt.Text = "";
            cityOrigin_Txt.Text = "";
            stateOrigin_Txt.Text = "";
            destinationCity_Txt.Text = "";
            destinationState_Txt.Text = "";

            day_cBB.SelectedItem = null;
            month_cBB.SelectedItem = null;
            year_cBB.SelectedItem = null;
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
            if (!tailNumber_txt.Text.Equals(""))
            {
                queryCommand = $"{queryCommand} AND TailNum = '{tailNumber_txt.Text}'";
            }
        }

        private void SearchDateFlight()
        {
            if (!tailNumber_txt.Text.Equals(""))
            {
                queryCommand = $"{queryCommand} AND TailNum = {tailNumber_txt.Text}";
            }
        }

        private void SearchCityOrigen()
        {
            if (!tailNumber_txt.Text.Equals(""))
            {
                queryCommand = $"{queryCommand} AND TailNum = {tailNumber_txt.Text}";
            }
        }

        private void SearchStateOrigen()
        {
            if (!tailNumber_txt.Text.Equals(""))
            {
                queryCommand = $"{queryCommand} AND TailNum = {tailNumber_txt.Text}";
            }
        }

        private void SearchDestinationCity()
        {
            if (!tailNumber_txt.Text.Equals(""))
            {
                queryCommand = $"{queryCommand} AND TailNum = {tailNumber_txt.Text}";
            }
        }

        private void SearchDestinationState()
        {
            if (!tailNumber_txt.Text.Equals(""))
            {
                queryCommand = $"{queryCommand} AND TailNum = {tailNumber_txt.Text}";
            }
        }

        #endregion

        #region Paginations options

        private void NextPage()
        {
            pageNumber += DATA_PER_PAGE;

            listFlight_Dgv.DataSource = null;
            listFlight_Dgv.DataSource = dataAccess.LoadData(queryCommand);

            CheckPaginationLimits();
        }

        private void PreviousPage()
        {
            pageNumber -= DATA_PER_PAGE;

            listFlight_Dgv.DataSource = null;
            listFlight_Dgv.DataSource = dataAccess.LoadData(queryCommand);

            CheckPaginationLimits();
        }

        private void CheckPaginationLimits()
        {
            nextDataGrid.Enabled = true;
            previousDataGrid.Enabled = true;

            if (pageNumber == 1)
            {
                previousDataGrid.Enabled = false;
            }

            if (listFlight_Dgv.Rows.Count < DATA_PER_PAGE)
            {
                nextDataGrid.Enabled = false;
            }
        }

        #endregion

        
    }
}