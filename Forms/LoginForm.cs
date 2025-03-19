using CodeSystem.Models;
using CodeSystem.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CodeSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserRepository userRepository = new UserRepository();

            usernameComboBox.DataSource = User.UsernameList();

            // set the value member
            usernameComboBox.ValueMember = "ID";
            usernameComboBox.SelectedIndex = 0;

            // set the display member
            usernameComboBox.DisplayMember = "Username";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {


            //Get the username and password from the textboxes
            string username = usernameComboBox.Text;
            string password = passwordTextBox.Text;

            // Check if the username and password are empty
            if (username == "")
            {
                MessageBox.Show("يجب اختيار اسم المستخدم أولا");
                return;
            }

            if (password == "")
            {
                MessageBox.Show("يجب إدخال كلمة المرور أولا");
                return;
            }

            // Check if the username and password are correct
            User user = new User(usernameComboBox.Text, passwordTextBox.Text);


            
            if (user.Password.IsNullOrEmpty())
            {
                MessageBox.Show("كلمة المرور غير صحيحة");
                passwordTextBox.Focus();

                return;
            }

           
            if (user.Authenticate())
            {
                User.GetUserGroupID(int.Parse(usernameComboBox.SelectedValue.ToString()));

                // get use rdetails
                DataTable userTable = User.CurrentUserDetail(int.Parse(usernameComboBox.SelectedValue.ToString()));

                // convert user table to user object
                var currentUser = new User(
                    intID: int.Parse(userTable.Rows[0]["ID"].ToString()),
                    strNamear: userTable.Rows[0]["NameAr"].ToString(),
                    strNameEn: userTable.Rows[0]["NameEn"].ToString(),
                    strUserName: userTable.Rows[0]["UserName"].ToString(),
                    strPassword: userTable.Rows[0]["Password"].ToString(),
                    datFirstEntry: DateTime.Parse(userTable.Rows[0]["FirstEntry"].ToString()),
                    datLastEntry: DateTime.Parse(userTable.Rows[0]["LastEntry"].ToString()),
                    bytUserGroupID: byte.Parse(userTable.Rows[0]["UserGroupID"].ToString()),
                    intCurrentStatusID: int.Parse(userTable.Rows[0]["CurrentStatusID"].ToString()),
                    bolStopped: bool.Parse(userTable.Rows[0]["Stopped"].ToString())
                    );



                //GetDevalutUserMoneyaccount(cmb_UserID.SelectedValue);
                //this.Visible = false;
                //currentLanguage = Language.ar;

                this.Hide();
                CurrentUser.Instance.user = currentUser;
                CurrentUser.Instance.appVersion = "V1.0.0";
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                // InvoiceTypeSelectForm.Show();
                this.Show();
                
                passwordTextBox.Text = "";



                //var myTransactionHistory = new TransactionHistoryModel();
                //myTransactionHistory.ObjectID = ObjectEnum.frmLogIn;
                //myTransactionHistory.PCID = intThisPCID;
                //myTransactionHistory.RecordData = DateTime.Now.ToShortDateString();
                //myTransactionHistory.RecordDataar = this.cmb_UserID.Text + " - " + this.txt_Password.Text;
                //myTransactionHistory.RecordDataEn = this.cmb_UserID.Text + " - " + this.txt_Password.Text;
                //myTransactionHistory.RecordID = Convert.ToInt32(cmb_UserID.SelectedValue);
                //myTransactionHistory.TransactionTime = DateTime.Now.ToShortTimeString();
                //myTransactionHistory.TransactionTypeID = TransactionTypeEnum.Sign_In;
                //myTransactionHistory.UserID = Convert.ToInt32(cmb_UserID.SelectedValue);
                //myTransactionHistory.Add();
            }
            else
            {
                //var myTransactionHistory = new TransactionHistoryModel();
                //myTransactionHistory.ObjectID = ObjectEnum.frmLogIn;
                //myTransactionHistory.PCID = intThisPCID;
                //myTransactionHistory.RecordData = DateTime.Now.ToShortDateString();
                //myTransactionHistory.RecordDataar = this.cmb_UserID.Text + " - " + this.txt_Password.Text;
                //myTransactionHistory.RecordDataEn = this.cmb_UserID.Text + " - " + this.txt_Password.Text;
                //myTransactionHistory.RecordID = Convert.ToInt32(cmb_UserID.SelectedValue);
                //myTransactionHistory.TransactionTime = DateTime.Now.ToShortTimeString();
                //myTransactionHistory.TransactionTypeID = TransactionTypeEnum.Password_Wrong;
                //myTransactionHistory.UserID = Convert.ToInt32(cmb_UserID.SelectedValue);
                //myTransactionHistory.Add();

                // Status_Label.Text = "كلمة المرور غير صحيحة، حاول مرة أخرى"
                passwordTextBox.Focus();
                passwordTextBox.Text = "";
            }


        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();
            List<string> tables = repo.GetTables();
            DataTable tblItemOtherData =  repo.GetTableData("tblItemOtherData"); // tblItemOtherData , tblItemOtherData1 , tblItemSize , tblItemType , tblItemPlace , tblColor
            
            List<string> tblItemOtherDataColumns = repo.GetColumns("tblItemOtherData");
            //foreach (var table in tables)
            //{
            //    Console.WriteLine(table);
            //}


            List<string> tableNames = new List<string>
{
    "tblAbsenceDay",
    "tblAbsenceProcedureRule",
    "tblAccount",
    "tblAccountAccountType",
    "tblAccountChildren",
    "tblAccountChildrenHealthStatus",
    "tblAccountContact",
    "tblAccountCulturalSide",
    "tblAccountDocument",
    "tblAccountExperience",
    "tblAccountHealthStatus",
    "tblAccountItemUseType",
    "tblAccountNote",
    "tblAccountOldBalance",
    "tblAccountRegistrationStatus",
    "tblAccountSide",
    "tblAccountStatus",
    "tblAccountSupport",
    "tblAccountSupport1",
    "tblAccountType",
    "tblApprovedCourse",
    "tblAssayRequest",
    "tblAssayRequestInvoice",
    "tblAssayRequestProcedure",
    "tblAttendanceCase",
    "tblAuthority",
    "tblAuthorityReportType",
    "tblAuthorityReportTypeFillterationBy",
    "tblAuthorizer",
    "tblBackUpHistory",
    "tblBasicDataTables",
    "tblBillCopy",
    "tblBillCopyGroup",
    "tblBranch",
    "tblBuildingType",
    "tblCalendar",
    "tblCalendarType",
    "tblCarType",
    "tblCategory",
    "tblCity",
    "tblClassDistributionTable",
    "tblClassRoom",
    "tblCode",
    "tblCoding",
    "tblCodingGroup",
    "tblCodingGroupSubCodingGroup",
    "tblCodingSupport",
    "tblColor",
    "tblCompanyDocument",
    "tblConditionClass",
    "tblConfirmationType",
    "tblContactType",
    "tblContract",
    "tblContract1",
    "tblContractInstalllment",
    "tblContractInstalllmentMoneyTransaction",
    "tblContractInvoice",
    "tblContractReceipt",
    "tblCopyFolder",
    "tblCountry",
    "tblCourse",
    "tblCulturalSideType",
    "tblCurrency",
    "tblCustomerNoteOnCompany",
    "tblCustomerSourceData",
    "tblDailySchedule",
    "tblDay",
    "tblDisease",
    "tblDividendOperation",
    "tblDividendOperationInvestors",
    "tblDividendOperationMenagment",
    "tblDividendRatios",
    "tblDocumentType",
    "tblEducationLevel",
    "tblEducationMajor",
    "tblEmployeeAttendance",
    "tblEmployeeContact",
    "tblEmployeeDocument",
    "tblEmployeeType",
    "tblExamControl",
    "tblExamDistributionTable",
    "tblExamLateStudent",
    "tblExamLateStudentList",
    "tblExamObjection",
    "tblExamPeriod",
    "tblExamType",
    "tblExecutionStatus",
    "tblExperienceType",
    "tblGender",
    "tblGeneralGrade",
    "tblGrade",
    "tblGroupedCategory",
    "tblHonorDegreeType",
    "tblHospital",
    "tblHouseType",
    "tblHousingType",
    "tblInputMeans",
    "tblInstallment",
    "tblInstallmentPlan",
    "tblInstallmentPlanType",
    "tblInsurancePersent",
    "tblInvoice",
    "tblInvoice1",
    "tblInvoiceCancellation",
    "tblInvoiceContact",
    "tblInvoiceCopy",
    "tblInvoiceDesignDetails",
    "tblInvoiceItem",
    "tblInvoiceItemAccount",
    "tblInvoiceItemConsumables",
    "tblInvoiceItemNote",
    "tblInvoiceNoteType",
    "tblInvoiceRealEstate",
    "tblInvoiceRealestateUnit",
    "tblInvoiceType",
    "tblInvoiceTypeItemUseType",
    "tblInvoiceTypeLink",
    "tblInvoiceTypeObject",
    "tblItem",
    "tblItem1",
    "tblItem2",
    "tblItemBalance",
    "tblItemBalance1",
    "tblItemBalanceHistory",
    "tblItemBlancePeriod",
    "tblItemCarData",
    "tblItemConsumables",
    "tblItemGroup",
    "tblItemOtherData",
    "tblItemOtherData1",
    "tblItemPlace",
    "tblItemSize",
    "tblItemType",
    "tblJob",
    "tblManagement",
    "tblManagementLease",
    "tblMark",
    "tblMoneyAccountType",
    "tblMoneyTransaction",
    "tblMoneyTransactionDetail",
    "tblMoneyTransactionDetails",
    "tblMoneyTransactionInvoice",
    "tblMoneyTransactionMethod",
    "tblMonth",
    "tblNationality",
    "tblNoteOnCustomer",
    "tblNoteOnEmployee",
    "tblObject",
    "tblObjectionType",
    "tblObjectType",
    "tblOrderExecution",
    "tblOrderExecutionMember",
    "tblOrderType",
    "tblPaymentMethod",
    "tblPaymentPeriodType",
    "tblPaymentSubject",
    "tblPC",
    "tblPCSetting",
    "tblPeriodType",
    "tblPersonalCategory",
    "tblPersonalData",
    "tblPersonalGroupedCategory",
    "tblPersonalStatus",
    "tblPhoneDirectory",
    "tblPhoneDirectoryContact",
    "tblPictureData",
    "tblPictureOccasion",
    "tblPicturePerson",
    "tblPicturePlace",
    "tblPictureSource",
    "tblPlace",
    "tblPrintingFilter",
    "tblProcedureType",
    "tblProgramObject",
    "tblProgramReportType",
    "tblProgramSetting",
    "tblProgramUseType",
    "tblProgramUseTypeAccountType",
    "tblProgramUseTypeBasicDataTable",
    "tblProgramUseTypeCodingGroup",
    "tblProgramUseTypeInvoiceType",
    "tblProgramUseTypeReceiptSubject",
    "tblQuarter",
    "tblRealEstate",
    "tblRealEstateUnit",
    "tblRealEstateUnitAction",
    "tblRealEstateUnitPrice",
    "tblReceipt",
    "tblReceipt1",
    "tblReceiptCancellation",
    "tblReceiptInstallment",
    "tblReceiptInvoice",
    "tblReceiptManagementLease",
    "tblReceiptRentLease",
    "tblReceiptSubject",
    "tblReceiptType",
    "tblReceiptTypeObject",
    "tblReceivedOutsideSearchReport",
    "tblReceivedOutsideSearchReportList",
    "tblRegistrationStatus",
    "tblReligion",
    "tblRentLease",
    "tblRentLease_Hotel",
    "tblRentLease1",
    "tblRentLeaseAttendant",
    "tblRentLeaseCancellation",
    "tblRentLeaseRenewal",
    "tblRentLeaseRenewalCancellation",
    "tblRentLeaseRenewalPaymentSubject",
    "tblRentLeaseRenewalPeriodCancellation",
    "tblRentLeaseRentGroupService",
    "tblRentType",
    "tblReportName",
    "tblReportType",
    "tblReportTypeGroup",
    "tblReportTypeObject",
    "tblRequiredUnit",
    "tblRequiredUnitQuarter",
    "tblReservation",
    "tblReservationStatus",
    "tblResthouse_RentedOut",
    "tblResthouse_RentLease",
    "tblResthouse_RentLeaseCancellation",
    "tblRestHouse_RentLeaseRentGroup",
    "tblRestHouse_SeasonRentGroup",
    "tblRestHouse_SeasonRentGroupPeriod",
    "tblRestHouse_SeasonService",
    "tblRestHouse_Setting",
    "tblRestHouse_UserGroupSetting",
    "tblRestHouseRentPeriod",
    "tblSeason",
    "tblSeasonPeriod",
    "tblSeasonsOfficialWorking",
    "tblSection",
    "tblShiftWorkPeriod",
    "tblSickenStatuse",
    "tblSMSMessageAccountDocument",
    "tblSMSMessageCompanyDocument",
    "tblSMSMessageHistory",
    "tblSMSMessageInstallment",
    "tblSMSMessageRecord",
    "tblSMSMessageRentLeaseRenewal",
    "tblSMSMessageRentLeaseRentGroup",
    "tblSMSMessageSetting",
    "tblSMSMessageType",
    "tblSMSProvider",
    "tblSpecialization",
    "tblStage",
    "tblStopType",
    "tblStoredItemBalance",
    "tblStoreMovement",
    "tblStudentAttendance",
    "tblStudentAttendanceList",
    "tblStudentCourse",
    "tblStudentCourseProcedure",
    "tblStudentFinalValuation",
    "tblStudentFinalValuationList",
    "tblStudentFinanceRelatedData",
    "tblStudentResult",
    "tblStudentType",
    "tblStudentWeeklyValuation",
    "tblStudentWeeklyValuationList",
    "tblStudyBook",
    "tblStudyClass",
    "tblStudyLevel",
    "tblStudyTermPeriod",
    "tblStudyType",
    "tblStudyYear",
    "tblTable",
    "tblTeacherFinalValuation",
    "tblTeacherFinalValuationList",
    "tblTeacherProcedure",
    "tblTeacherProcedureSubject",
    "tblTeacherProcedureType",
    "tblTeacherValuationByStudent",
    "tblTeacherValuationByStudentList",
    "tblTeacherValuationRecord",
    "tblTeacherValuationRecordList",
    "tblTeacherVisitNo",
    "tblTeamGroup",
    "tblTeamGroupMember",
    "tblTerm",
    "tblThisPCData",
    "tblThisPCData1",
    "tblTimeByHalfHour",
    "tblTimeByQuarterHour",
    "tblTimeHalf",
    "tblTimeHour",
    "tblTimeQuarter",
    "tblTitle",
    "tblTransactionHistory",
    "tblTransactionType",
    "tblUnitActionType",
    "tblUnitExpense",
    "tblUnitStatus",
    "tblUnitType",
    "tblUnitTypeCondition",
    "tblUser",
    "tblUserAccountType",
    "tblUserGroup",  "tblUserGroupAccount",
    "tblUserMoneyAccount",
    "tblUserReceiptSubject",
    "tblUserSetting",
    "tblUserStatus",
    "tblUseType",
    "tblValuationForm",
    "tblValuationFormGroup",
    "tblValuationPersonType",
    "tblVatType",
    "tblVersion",
    "tblWeek",
    "tblWeekDay",
    "tblWorkerRentContract",
    "tblWorkerRentContractEmployee",
    "tblYear",
    "testNewName",
    "tmbNotUsedMoneyTransaction",
    "tmpAccountBalance",
    "tmpInvoicePaidSum",
    "tmpItemBalance",
    "tmpItemCost",
    "tmpItemTotal",
    "tmpLastPaymentDate",
    "tmpLastRentLeaseRenewal",
    "tmpMoneyAccountBalance",
    "tmpPurchaseInvoiceSummary",
    "tmpSalesInvoiceSummary",
    "USysRibbons",
    "ValuationFormObject" };

            foreach (var column in tblItemOtherDataColumns)
            {
                Console.WriteLine(column);
            }



            //string databasePath = "\"C:\\Codes\\Codes101\\Report.accde\"";
            //string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};Persist Security Info=False;";

            //// Define the update query
            //string itemOtherDataQuery = @"UPDATE tblItemOtherData
            //                          SET BarcodeNo = @BarcodeNo, 
            //                              ColorID = @ColorID, 
            //                              FilePath = @FilePath, 
            //                              ItemGroupID = @ItemGroupID, 
            //                              ItemNote = @ItemNote, 
            //                              ItemPlaceID = @ItemPlaceID, 
            //                              ItemSizeID = @ItemSizeID, 
            //                              ItemTypeID = @ItemTypeID, 
            //                              UnitCount = @UnitCount, 
            //                              UseTypeID = @UseTypeID
            //                          WHERE ItemID = @ItemID";

            //// Define sample data for testing
            //string BarcodeNo = "655";
            //byte? ColorID = 1;
            //string FilePath = @"C:\example\path\file.txt";
            //int ItemGroupID = 19;
            //int ID = 19; // ItemID
            //string ItemNote = "This is a test note.";
            //short? ItemPlaceID = null; // Nullable
            //byte? ItemSizeID = 1; // Nullable
            //short ItemTypeID = 1;
            //float UnitCount = 5.5f;
            //byte? UseTypeID = 1; // Nullable

            //// Connect to the database and execute the query
            //using (OleDbConnection connection = new OleDbConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        using (OleDbCommand itemOtherDataCommand = new OleDbCommand(itemOtherDataQuery, connection))
            //        {
            //            // Add parameters with explicit data types
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@BarcodeNo", OleDbType.VarChar)).Value = BarcodeNo ?? (object)DBNull.Value;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@ColorID", OleDbType.TinyInt)).Value = ColorID ?? (object)DBNull.Value;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@FilePath", OleDbType.VarChar)).Value = string.IsNullOrEmpty(FilePath) ? (object)DBNull.Value : FilePath;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@ItemGroupID", OleDbType.Integer)).Value = ItemGroupID;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@ItemNote", OleDbType.VarChar)).Value = string.IsNullOrEmpty(ItemNote) ? (object)DBNull.Value : ItemNote;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@ItemPlaceID", OleDbType.SmallInt)).Value = ItemPlaceID ?? (object)DBNull.Value;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@ItemSizeID", OleDbType.TinyInt)).Value = ItemSizeID ?? (object)DBNull.Value;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@ItemTypeID", OleDbType.SmallInt)).Value = ItemTypeID;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@UnitCount", OleDbType.Single)).Value = UnitCount;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@UseTypeID", OleDbType.TinyInt)).Value = UseTypeID ?? (object)DBNull.Value;
            //            itemOtherDataCommand.Parameters.Add(new OleDbParameter("@ItemID", OleDbType.Integer)).Value = ID;

            //            // Execute the query
            //            int rowsAffected = itemOtherDataCommand.ExecuteNonQuery();
            //            Console.WriteLine($"Query executed successfully. Rows affected: {rowsAffected}");
            //        }
            //    }
            //    catch (OleDbException ex)
            //    {
            //        // Debugging: Output exception message and parameters
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}
            //list all columns
            foreach (var table in tableNames)
            {
                Console.WriteLine("======");
                Console.WriteLine(table);
                DataTable tableData = repo.GetTableData(table); // tblItemOtherData , tblItemOtherData1 , tblItemSize , tblItemType , tblItemPlace , tblColor
                List<string> tableDataColumns = repo.GetColumns(table);
            foreach (DataRow row in tableData.Rows)
            {
                Console.WriteLine("-------");
                foreach (var column in tableDataColumns)
                {
                    Console.WriteLine(column);
                    Console.WriteLine(row[column]);
                }


            }

        }





    }
    }
}
