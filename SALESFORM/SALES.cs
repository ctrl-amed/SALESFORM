using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORYSYSTEM_GROUP2
{
    public partial class SALES : Form
    {
        private Database db;

        public SALES()
        {
            InitializeComponent();
            db = new Database();
            LoadTransactionsToListView(); 
            cbTRANSSORT.SelectedIndex = -1; 
            LoadTransactionsToListView(); 
            LoadProductsToComboBox(); 
            LoadTransactionsToListView();
            LoadTransactionDatesToComboBoxes(); 
            LoadTransactionsToListView();
        }

        private void LoadTransactionsToListView()
        {
            lvINVOICE.Items.Clear(); 

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    string order = isAscending ? "ASC" : "DESC"; 
                    string query = $@"
                SELECT 
                    t.TransactionId AS [ID],
                    COUNT(t.ProductId) AS [NoOfProducts],
                    SUM(t.Units) AS [TotalUnits],
                    SUM(t.TotalPrice) AS [TotalAmountPaid],
                    t.TransactionDate AS [DatePurchased]
                FROM Transactions t
                GROUP BY t.TransactionId, t.TransactionDate
                ORDER BY {sortColumn} {order}";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["NoOfProducts"].ToString());
                        item.SubItems.Add(reader["TotalUnits"].ToString());
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TotalAmountPaid"])));
                        item.SubItems.Add(Convert.ToDateTime(reader["DatePurchased"]).ToString("yyyy-MM-dd"));
                        lvINVOICE.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading transactions: {ex.Message}");
                }
            }

            
            if (lvINVOICE.Items.Count == 0)
            {
                MessageBox.Show("No transactions available to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string sortColumn = "t.TransactionId"; 
        private bool isAscending = true; 

        private void cbTRANSSORT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbTRANSSORT.SelectedItem.ToString())
            {
                case "ALL":
                    sortColumn = "t.TransactionId"; 
                    break;
                case "NO. OF PRODUCT":
                    sortColumn = "COUNT(t.ProductId)";
                    break;
                case "UNITS":
                    sortColumn = "SUM(t.Units)";
                    break;
                case "AMOUNT PAID":
                    sortColumn = "SUM(t.TotalPrice)";
                    break;
                case "DATE PURCHASED":
                    sortColumn = "t.TransactionDate";
                    break;
                default:
                    sortColumn = "t.TransactionId"; 
                    break;
            }

           
            LoadTransactionsToListView();
        }

        private void btn_asc_invoice_Click(object sender, EventArgs e)
        {
            isAscending = true; 
            LoadTransactionsToListView(); 
        }

        private void btn_dsc_invoice_Click(object sender, EventArgs e)
        {
            isAscending = false; 
            LoadTransactionsToListView(); 
        }
        private void LoadProductsToComboBox()
        {
            cbPRODUCT.Items.Clear(); 

           
            cbPRODUCT.Items.Add("All");

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                  
                    string query = "SELECT Name FROM Products";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                       
                        cbPRODUCT.Items.Add(reader["Name"].ToString());
                    }
                }

                
                cbPRODUCT.SelectedIndex = 0; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }
        private void LoadTransactionsForProduct(string productName)
        {
            lvINVOICE.Items.Clear(); 

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    t.TransactionId AS [ID],
                    COUNT(t.ProductId) AS [NoOfProducts],
                    SUM(t.Units) AS [TotalUnits],
                    SUM(t.TotalPrice) AS [TotalAmountPaid],
                    t.TransactionDate AS [DatePurchased]
                FROM Transactions t
                INNER JOIN Products p ON t.ProductId = p.Id
                WHERE p.Name = @ProductName
                GROUP BY t.TransactionId, t.TransactionDate
                ORDER BY t.TransactionId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    SqlDataReader reader = command.ExecuteReader();

                    bool hasData = false; 

                    while (reader.Read())
                    {
                        hasData = true;
                        var item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["NoOfProducts"].ToString());
                        item.SubItems.Add(reader["TotalUnits"].ToString());
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TotalAmountPaid"])));
                        item.SubItems.Add(Convert.ToDateTime(reader["DatePurchased"]).ToString("yyyy-MM-dd"));
                        lvINVOICE.Items.Add(item);
                    }

                    
                    if (!hasData)
                    {
                        MessageBox.Show("No transactions found for the selected product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}");
            }

            
            if (lvINVOICE.Items.Count == 0)
            {
                MessageBox.Show("No transactions available to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadTransactionsByProduct(string productName)
        {
            lvINVOICE.Items.Clear(); 

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    
                    string query = @"
                SELECT 
                    t.TransactionId AS [ID],
                    COUNT(t.ProductId) AS [NoOfProducts],
                    SUM(t.Units) AS [TotalUnits],
                    SUM(t.TotalPrice) AS [TotalAmountPaid],
                    t.TransactionDate AS [DatePurchased]
                FROM Transactions t
                INNER JOIN Products p ON t.ProductId = p.Id
                WHERE p.Name = @ProductName
                GROUP BY t.TransactionId, t.TransactionDate
                ORDER BY t.TransactionId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductName", productName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["NoOfProducts"].ToString());
                        item.SubItems.Add(reader["TotalUnits"].ToString());
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TotalAmountPaid"])));
                        item.SubItems.Add(Convert.ToDateTime(reader["DatePurchased"]).ToString("yyyy-MM-dd"));
                        lvINVOICE.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions for product: {ex.Message}");
            }
        }

        private void LoadAllTransactions()
        {
            lvINVOICE.Items.Clear(); 

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    
                    string query = @"
                SELECT 
                    t.TransactionId AS [ID],
                    COUNT(t.ProductId) AS [NoOfProducts],
                    SUM(t.Units) AS [TotalUnits],
                    SUM(t.TotalPrice) AS [TotalAmountPaid],
                    t.TransactionDate AS [DatePurchased]
                FROM Transactions t
                GROUP BY t.TransactionId, t.TransactionDate
                ORDER BY t.TransactionId";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["NoOfProducts"].ToString());
                        item.SubItems.Add(reader["TotalUnits"].ToString());
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TotalAmountPaid"])));
                        item.SubItems.Add(Convert.ToDateTime(reader["DatePurchased"]).ToString("yyyy-MM-dd"));
                        lvINVOICE.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading all transactions: {ex.Message}");
            }
        }

        private void cbPRODUCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = cbPRODUCT.SelectedItem.ToString();

            if (selectedProduct == "All")
            {
                
                LoadAllTransactions();
            }
            else
            {
                
                LoadTransactionsByProduct(selectedProduct);
            }
        }



        private void LoadTransactionDatesToComboBoxes()
        {
            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT DISTINCT TransactionDate FROM Transactions ORDER BY TransactionDate DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    cbDATE1.Items.Clear();
                    cbDATE2.Items.Clear();

                    
                    cbDATE1.Items.Add(DateTime.Now.ToString("yyyy-MM-dd"));
                    cbDATE2.Items.Add(DateTime.Now.ToString("yyyy-MM-dd"));

                    
                    while (reader.Read())
                    {
                        cbDATE1.Items.Add(Convert.ToDateTime(reader["TransactionDate"]).ToString("yyyy-MM-dd"));
                        cbDATE2.Items.Add(Convert.ToDateTime(reader["TransactionDate"]).ToString("yyyy-MM-dd"));
                    }

                    
                    cbDATE1.SelectedIndex = cbDATE1.Items.IndexOf(DateTime.Now.ToString("yyyy-MM-dd"));
                    cbDATE2.SelectedIndex = cbDATE2.Items.IndexOf(DateTime.Now.ToString("yyyy-MM-dd"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction dates: {ex.Message}");
            }
        }

        private void ValidateDateRange()
        {
            DateTime date1, date2;

            
            if (DateTime.TryParse(cbDATE1.SelectedItem.ToString(), out date1) &&
                DateTime.TryParse(cbDATE2.SelectedItem.ToString(), out date2))
            {
                
                if (date1 > date2)
                {
                    MessageBox.Show("The start date (cbDATE1) cannot be later than the end date (cbDATE2).", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    cbDATE1.SelectedIndex = cbDATE2.SelectedIndex;
                }
                else
                {
                    
                    LoadTransactionsForDateRange(date1, date2);
                }
            }
            else
            {
                MessageBox.Show("Invalid date selected. Please choose a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTransactionsForDateRange(DateTime startDate, DateTime endDate)
        {
            lvINVOICE.Items.Clear(); 

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    t.TransactionId AS [ID],
                    COUNT(t.ProductId) AS [NoOfProducts],
                    SUM(t.Units) AS [TotalUnits],
                    SUM(t.TotalPrice) AS [TotalAmountPaid],
                    t.TransactionDate AS [DatePurchased]
                FROM Transactions t
                WHERE t.TransactionDate BETWEEN @StartDate AND @EndDate
                GROUP BY t.TransactionId, t.TransactionDate
                ORDER BY t.TransactionId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    SqlDataReader reader = command.ExecuteReader();

                    bool hasData = false;

                    while (reader.Read())
                    {
                        hasData = true;
                        var item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["NoOfProducts"].ToString());
                        item.SubItems.Add(reader["TotalUnits"].ToString());
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TotalAmountPaid"])));
                        item.SubItems.Add(Convert.ToDateTime(reader["DatePurchased"]).ToString("yyyy-MM-dd"));
                        lvINVOICE.Items.Add(item);
                    }

                    
                    if (!hasData)
                    {
                        MessageBox.Show("No transactions found for the selected date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}");
            }

            
            if (lvINVOICE.Items.Count == 0)
            {
                MessageBox.Show("No transactions available to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbDATE1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateDateRange();
        }

        private void cbDATE2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateDateRange();
        }




        private void lvINVOICE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvINVOICE.SelectedItems.Count > 0)
            {
                
                string transactionId = lvINVOICE.SelectedItems[0].SubItems[0].Text;

                
                lblTRANSNUMBER.Text = "Transaction ID: " + transactionId;

                
                LoadProductsForTransaction(Convert.ToInt32(transactionId));
            }
        }

        private void LoadProductsForTransaction(int transactionId)
        {
           
            lvTRANSACTION.Items.Clear();

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    
                    string query = @"
                SELECT 
                    p.Name AS PRNAME, 
                    p.Category AS CATEGORY, 
                    t.Units AS UNITS, 
                    t.Price AS PRICE, 
                    t.TotalPrice AS TOTALPRICE
                FROM Transactions t
                INNER JOIN Products p ON t.ProductId = p.Id
                WHERE t.TransactionId = @TransactionId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TransactionId", transactionId);

                    SqlDataReader reader = command.ExecuteReader();

                    bool hasData = false;

                    while (reader.Read())
                    {
                        hasData = true;
                        var item = new ListViewItem(reader["PRNAME"].ToString());
                        item.SubItems.Add(reader["CATEGORY"].ToString());
                        item.SubItems.Add(reader["UNITS"].ToString());
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["PRICE"])));
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TOTALPRICE"])));
                        lvTRANSACTION.Items.Add(item);
                    }

                    
                    if (!hasData)
                    {
                        MessageBox.Show("No products found for the selected transaction.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products for transaction: {ex.Message}");
            }
        }


        private void lblTRANSNUMBER_Click(object sender, EventArgs e)
        {

        }

        private void lvTRANSACTION_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadTransactionsSorted(string column)
        {
            string sortOrder = cbPRODUCTSORT.Text == "SORT" ? "ASC" : "DESC";

            lvTRANSACTION.Items.Clear(); 

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    
                    string query = @"
                SELECT p.Name AS [PRNAME], 
                       p.Category AS [CATEGORY], 
                       t.Units AS [UNITS], 
                       t.Price AS [PRICE], 
                       t.TotalPrice AS [TOTALPRICE]
                FROM Transactions t
                INNER JOIN Products p ON t.ProductId = p.Id
                ORDER BY t." + column + " " + sortOrder;

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["PRNAME"].ToString());
                        item.SubItems.Add(reader["CATEGORY"].ToString());
                        item.SubItems.Add(reader["UNITS"].ToString());
                        item.SubItems.Add(reader["PRICE"].ToString());
                        item.SubItems.Add(reader["TOTALPRICE"].ToString());
                        lvTRANSACTION.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sorted transactions: {ex.Message}");
            }
        }


        private void cbPRODUCTSORT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string sortOption = cbPRODUCTSORT.SelectedItem.ToString();

            
            if (sortOption == "ALL")
            {
                LoadTransactionsSortedByProductId("ASC"); 
            }
            else if (sortOption == "UNITS")
            {
                LoadTransactionsSorted("UNITS");
            }
            else if (sortOption == "PRICE")
            {
                LoadTransactionsSorted("PRICE");
            }
            else if (sortOption == "TOTAL PRICE")
            {
                LoadTransactionsSorted("TOTALPRICE");
            }
        }
        private void LoadTransactionsSortedByProductId(string sortOrder)
        {
            lvTRANSACTION.Items.Clear(); 

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    
                    string query = @"
                SELECT p.Name AS [PRNAME], 
                       p.Category AS [CATEGORY], 
                       t.Units AS [UNITS], 
                       t.Price AS [PRICE], 
                       t.TotalPrice AS [TOTALPRICE]
                FROM Transactions t
                INNER JOIN Products p ON t.ProductId = p.Id
                ORDER BY t.ProductId " + sortOrder;

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["PRNAME"].ToString());
                        item.SubItems.Add(reader["CATEGORY"].ToString());
                        item.SubItems.Add(reader["UNITS"].ToString());
                        item.SubItems.Add(reader["PRICE"].ToString());
                        item.SubItems.Add(reader["TOTALPRICE"].ToString());
                        lvTRANSACTION.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}");
            }
        }


       

        private void btn_asc_trans_Click(object sender, EventArgs e)
        {
            string sortOption = cbPRODUCTSORT.SelectedItem.ToString();
            string sortOrder = "ASC";

            
            if (sortOption == "UNITS")
            {
                LoadTransactionsSorted("UNITS");
            }
            else if (sortOption == "PRICE")
            {
                LoadTransactionsSorted("PRICE");
            }
            else if (sortOption == "TOTAL PRICE")
            {
                LoadTransactionsSorted("TOTALPRICE");
            }
            else
            {
                LoadTransactionsSortedByProductId(sortOrder); 
            }
        }

        private void btn_dsc_trans_Click(object sender, EventArgs e)
        {
            string sortOption = cbPRODUCTSORT.SelectedItem.ToString();
            string sortOrder = "DESC";

           
            if (sortOption == "UNITS")
            {
                LoadTransactionsSorted("UNITS");
            }
            else if (sortOption == "PRICE")
            {
                LoadTransactionsSorted("PRICE");
            }
            else if (sortOption == "TOTAL PRICE")
            {
                LoadTransactionsSorted("TOTALPRICE");
            }
            else
            {
                LoadTransactionsSortedByProductId(sortOrder); 
            }
        }


        private void SALES_Load(object sender, EventArgs e)
        {
            cbPRODUCT.Text = "SELECT A PRODUCT TO SEARCH";
            LoadProductsToComboBox();
            
            cbPRODUCTSORT.Text = "SORT"; 

           
            LoadTransactionsSortedByProductId("ASC");

            cbCATEGORY.Text = "CATEGORY";  
            cbPERIOD.Text = "PERIOD";
        }



















        private void lvPRODUCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPRODUCT.Items.Clear(); 

            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    
                    string query = @"
                SELECT p.Id AS [ID], 
                       p.Name AS [PRONAME], 
                       p.Category AS [CATEGORY], 
                       ISNULL(SUM(t.Units), 0) AS [SOLD], 
                       ISNULL(SUM(t.Units * p.Price), 0) AS [TOTALAMOUNT], 
                       p.Priority AS [PRIORITY]
                FROM Products p
                LEFT JOIN Transactions t ON p.Id = t.ProductId
                GROUP BY p.Id, p.Name, p.Category, p.Priority
                ORDER BY p.Id";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["PRONAME"].ToString());
                        item.SubItems.Add(reader["CATEGORY"].ToString());
                        item.SubItems.Add(reader["SOLD"].ToString());
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TOTALAMOUNT"])));
                        item.SubItems.Add(reader["PRIORITY"].ToString()); 
                        lvPRODUCT.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product data: {ex.Message}");
            }
        }


        private void LoadAllProducts()
        {
            try
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    
                    string query = @"
                SELECT p.Id AS [ID], 
                       p.Name AS [PRONAME], 
                       p.Category AS [CATEGORY], 
                       ISNULL(SUM(t.Units), 0) AS [SOLD], 
                       ISNULL(SUM(t.Units * p.Price), 0) AS [TOTALAMOUNT], 
                       p.Priority AS [PRIORITY]
                FROM Products p
                LEFT JOIN Transactions t ON p.Id = t.ProductId
                GROUP BY p.Id, p.Name, p.Category, p.Priority
                ORDER BY p.Id";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    bool dataFound = false; 

                    while (reader.Read())
                    {
                        dataFound = true; 
                        var item = new ListViewItem(reader["ID"].ToString());
                        item.SubItems.Add(reader["PRONAME"].ToString());
                        item.SubItems.Add(reader["CATEGORY"].ToString());
                        item.SubItems.Add(reader["SOLD"].ToString());
                        item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TOTALAMOUNT"])));
                        item.SubItems.Add(reader["PRIORITY"].ToString()); 
                        lvPRODUCT.Items.Add(item);
                    }

                   
                    if (!dataFound)
                    {
                        MessageBox.Show("No products found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void cbCATEGORY_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lvPRODUCT.Items.Clear();

            
            string selectedCategory = cbCATEGORY.SelectedItem.ToString();

            
            if (selectedCategory == "ALL")
            {
                LoadAllProducts(); 
            }
            else
            {
                try
                {
                    using (var connection = db.GetConnection())
                    {
                        connection.Open();

                        
                        string query = @"
                    SELECT p.Id AS [ID], 
                           p.Name AS [PRONAME], 
                           p.Category AS [CATEGORY], 
                           ISNULL(SUM(t.Units), 0) AS [SOLD], 
                           ISNULL(SUM(t.Units * p.Price), 0) AS [TOTALAMOUNT], 
                           p.Priority AS [PRIORITY]
                    FROM Products p
                    LEFT JOIN Transactions t ON p.Id = t.ProductId
                    WHERE p.Category = @Category
                    GROUP BY p.Id, p.Name, p.Category, p.Priority
                    ORDER BY p.Id";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Category", selectedCategory);
                        SqlDataReader reader = command.ExecuteReader();

                        bool dataFound = false; 

                        while (reader.Read())
                        {
                            dataFound = true; 
                            var item = new ListViewItem(reader["ID"].ToString());
                            item.SubItems.Add(reader["PRONAME"].ToString());
                            item.SubItems.Add(reader["CATEGORY"].ToString());
                            item.SubItems.Add(reader["SOLD"].ToString());
                            item.SubItems.Add("₱" + string.Format("{0:n2}", Convert.ToDecimal(reader["TOTALAMOUNT"])));
                            item.SubItems.Add(reader["PRIORITY"].ToString()); 
                            lvPRODUCT.Items.Add(item);
                        }

                        
                        if (!dataFound)
                        {
                            MessageBox.Show("No products found for the selected category.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading products for category '{selectedCategory}': {ex.Message}");
                }
            }
        }

        private DateTime GetStartDate(string period)
        {
            switch (period)
            {
                case "WEEKLY":
                    return DateTime.Today.AddDays(-7); 
                case "MONTHLY":
                    return new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); 
                case "ANNUALLY":
                    return new DateTime(DateTime.Today.Year, 1, 1); 
                default:
                    return DateTime.Today; 
            }
        }

        private string GetSqlDateDiff(string period)
        {
            switch (period)
            {
                case "WEEKLY":
                    return "week";
                case "MONTHLY":
                    return "month";
                case "ANNUALLY":
                    return "year";
                default:
                    return "day"; 
            }
        }

        private void LoadSalesData(string query)
        {
           
            lvPRODUCT.Items.Clear();

            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var item = new ListViewItem(reader["ProductID"].ToString());
                        item.SubItems.Add(reader["ProductName"].ToString());
                        item.SubItems.Add(reader["Category"].ToString());
                        item.SubItems.Add(reader["TotalUnitsSold"].ToString());

                       
                        int totalUnitsSold = Convert.ToInt32(reader["TotalUnitsSold"]);
                        int datePeriod = Convert.ToInt32(reader["DatePeriod"]);
                        if (datePeriod > 0)
                        {
                            item.SubItems.Add((totalUnitsSold / datePeriod).ToString());
                        }
                        else
                        {
                            item.SubItems.Add("0");
                        }

                        lvPRODUCT.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading sales data: {ex.Message}");
                }
            }
        }

        private void cbPERIOD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string period = cbPERIOD.Text;
            string query = "";

            
            if (period == "DAILY")
            {
                query = @"
            SELECT 
                p.Id AS ProductID,
                p.Name AS ProductName,
                p.Category AS Category,
                SUM(t.Units) AS TotalUnitsSold
            FROM Transactions t
            JOIN Products p ON t.ProductId = p.Id
            GROUP BY p.Id, p.Name, p.Category
            ORDER BY p.Id";
            }
            
            else if (period == "WEEKLY" || period == "MONTHLY" || period == "ANNUALLY")
            {
                
                DateTime startDate = GetStartDate(period);
                DateTime endDate = DateTime.Today; 

                
                query = @"
            SELECT 
                p.Id AS ProductID,
                p.Name AS ProductName,
                p.Category AS Category,
                SUM(t.Units) AS TotalUnitsSold,
                DATEDIFF(" + GetSqlDateDiff(period) + @", '" + startDate.ToString("yyyy-MM-dd") + @"', '" + endDate.ToString("yyyy-MM-dd") + @"') AS DatePeriod
            FROM Transactions t
            JOIN Products p ON t.ProductId = p.Id
            WHERE t.TransactionDate BETWEEN '" + startDate.ToString("yyyy-MM-dd") + @"' AND '" + endDate.ToString("yyyy-MM-dd") + @"'
            GROUP BY p.Id, p.Name, p.Category
            ORDER BY p.Id";
            }

            
            LoadSalesData(query);
        }
    }
}
