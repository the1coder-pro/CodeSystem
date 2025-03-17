using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CodeSystem.Repositories
{
    public class UserRepository
    {
        // private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=codesystemdb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        string appPath = AppDomain.CurrentDomain.BaseDirectory; // Equivalent to VB.NET's My.Application.Info.DirectoryPath

        private static RegistrationConnectionManager instance = null;
        private OleDbConnection conn;

        // get the tables names in the "C:\Codes\Codes101\Registration.accde" 
        /*
         Tables in the database:
MSysAccessStorage
MSysAccessStorage1
MSysAccessXML
MSysACEs
MSysComplexColumns
MSysComplexColumns1
MSysNameMap
MSysNavPaneGroupCategories
MSysNavPaneGroupCategories1
MSysNavPaneGroups
MSysNavPaneGroups1
MSysNavPaneGroupToObjects
MSysNavPaneGroupToObjects1
MSysNavPaneObjectIDs
MSysObjects
MSysObjects1
MSysQueries
MSysQueries1
MSysRelationships
MSysRelationships1
MSysResources
qryAccountContactEmail
qryAccountContactMobile
qryAccountContactPhone
qryAccountDocumentID
qryAuthorityReportTypeItemType
qryAuthorityReportTypeItemTypeForAll
qryBarcodeCarData
qryCharityInvoiceData
qryInvoiceMobile
qryInvoiceTell
qryRecieptData
Serial
tblAbsenceDay
tblAbsenceProcedureRule
tblAccount
tblAccountAccountType
tblAccountChildren
tblAccountChildrenHealthStatus
tblAccountContact
tblAccountCulturalSide
tblAccountDocument
tblAccountExperience
tblAccountHealthStatus
tblAccountItemUseType
tblAccountNote
tblAccountOldBalance
tblAccountRegistrationStatus
tblAccountSide
tblAccountStatus
tblAccountSupport
tblAccountSupport1
tblAccountType
tblApprovedCourse
tblAssayRequest
tblAssayRequestInvoice
tblAssayRequestProcedure
tblAttendanceCase
tblAuthority
tblAuthorityReportType
tblAuthorityReportTypeFillterationBy
tblAuthorizer
tblBackUpHistory
tblBasicDataTables
tblBillCopy
tblBillCopyGroup
tblBranch
tblBuildingType
tblCalendar
tblCalendarType
tblCarType
tblCategory
tblCity
tblClassDistributionTable
tblClassRoom
tblCode
tblCoding
tblCodingGroup
tblCodingGroupSubCodingGroup
tblCodingSupport
tblColor
tblCompanyDocument
tblConditionClass
tblConfirmationType
tblContactType
tblContract
tblContract1
tblContractInstalllment
tblContractInstalllmentMoneyTransaction
tblContractInvoice
tblContractReceipt
tblCopyFolder
tblCountry
tblCourse
tblCulturalSideType
tblCurrency
tblCustomerNoteOnCompany
tblCustomerSourceData
tblDailySchedule
tblDay
tblDisease
tblDividendOperation
tblDividendOperationInvestors
tblDividendOperationMenagment
tblDividendRatios
tblDocumentType
tblEducationLevel
tblEducationMajor
tblEmployeeAttendance
tblEmployeeContact
tblEmployeeDocument
tblEmployeeType
tblExamControl
tblExamDistributionTable
tblExamLateStudent
tblExamLateStudentList
tblExamObjection
tblExamPeriod
tblExamType
tblExecutionStatus
tblExperienceType
tblGender
tblGeneralGrade
tblGrade
tblGroupedCategory
tblHonorDegreeType
tblHospital
tblHouseType
tblHousingType
tblInputMeans
tblInstallment
tblInstallmentPlan
tblInstallmentPlanType
tblInsurancePersent
tblInvoice
tblInvoice1
tblInvoiceCancellation
tblInvoiceContact
tblInvoiceCopy
tblInvoiceDesignDetails
tblInvoiceItem
tblInvoiceItemAccount
tblInvoiceItemConsumables
tblInvoiceItemNote
tblInvoiceNoteType
tblInvoiceRealEstate
tblInvoiceRealestateUnit
tblInvoiceType
tblInvoiceTypeItemUseType
tblInvoiceTypeLink
tblInvoiceTypeObject
tblItem
tblItem1
tblItem2
tblItemBalance
tblItemBalance1
tblItemBalanceHistory
tblItemBlancePeriod
tblItemCarData
tblItemConsumables
tblItemGroup
tblItemOtherData
tblItemOtherData1
tblItemPlace
tblItemSize
tblItemType
tblJob
tblManagement
tblManagementLease
tblMark
tblMoneyAccountType
tblMoneyTransaction
tblMoneyTransactionDetail
tblMoneyTransactionDetails
tblMoneyTransactionInvoice
tblMoneyTransactionMethod
tblMonth
tblNationality
tblNoteOnCustomer
tblNoteOnEmployee
tblObject
tblObjectionType
tblObjectType
tblOrderExecution
tblOrderExecutionMember
tblOrderType
tblPaymentMethod
tblPaymentPeriodType
tblPaymentSubject
tblPC
tblPCSetting
tblPeriodType
tblPersonalCategory
tblPersonalData
tblPersonalGroupedCategory
tblPersonalStatus
tblPhoneDirectory
tblPhoneDirectoryContact
tblPictureData
tblPictureOccasion
tblPicturePerson
tblPicturePlace
tblPictureSource
tblPlace
tblPrintingFilter
tblProcedureType
tblProgramObject
tblProgramReportType
tblProgramSetting
tblProgramUseType
tblProgramUseTypeAccountType
tblProgramUseTypeBasicDataTable
tblProgramUseTypeCodingGroup
tblProgramUseTypeInvoiceType
tblProgramUseTypeReceiptSubject
tblQuarter
tblRealEstate
tblRealEstateUnit
tblRealEstateUnitAction
tblRealEstateUnitPrice
tblReceipt
tblReceipt1
tblReceiptCancellation
tblReceiptInstallment
tblReceiptInvoice
tblReceiptManagementLease
tblReceiptRentLease
tblReceiptSubject
tblReceiptType
tblReceiptTypeObject
tblReceivedOutsideSearchReport
tblReceivedOutsideSearchReportList
tblRegistrationStatus
tblReligion
tblRentLease
tblRentLease_Hotel
tblRentLease1
tblRentLeaseAttendant
tblRentLeaseCancellation
tblRentLeaseRenewal
tblRentLeaseRenewalCancellation
tblRentLeaseRenewalPaymentSubject
tblRentLeaseRenewalPeriodCancellation
tblRentLeaseRentGroupService
tblRentType
tblReportName
tblReportType
tblReportTypeGroup
tblReportTypeObject
tblRequiredUnit
tblRequiredUnitQuarter
tblReservation
tblReservationStatus
tblResthouse_RentedOut
tblResthouse_RentLease
tblResthouse_RentLeaseCancellation
tblRestHouse_RentLeaseRentGroup
tblRestHouse_SeasonRentGroup
tblRestHouse_SeasonRentGroupPeriod
tblRestHouse_SeasonService
tblRestHouse_Setting
tblRestHouse_UserGroupSetting
tblRestHouseRentPeriod
tblSeason
tblSeasonPeriod
tblSeasonsOfficialWorking
tblSection
tblShiftWorkPeriod
tblSickenStatuse
tblSMSMessageAccountDocument
tblSMSMessageCompanyDocument
tblSMSMessageHistory
tblSMSMessageInstallment
tblSMSMessageRecord
tblSMSMessageRentLeaseRenewal
tblSMSMessageRentLeaseRentGroup
tblSMSMessageSetting
tblSMSMessageType
tblSMSProvider
tblSpecialization
tblStage
tblStopType
tblStoredItemBalance
tblStoreMovement
tblStudentAttendance
tblStudentAttendanceList
tblStudentCourse
tblStudentCourseProcedure
tblStudentFinalValuation
tblStudentFinalValuationList
tblStudentFinanceRelatedData
tblStudentResult
tblStudentType
tblStudentWeeklyValuation
tblStudentWeeklyValuationList
tblStudyBook
tblStudyClass
tblStudyLevel
tblStudyTermPeriod
tblStudyType
tblStudyYear
tblTable
tblTeacherFinalValuation
tblTeacherFinalValuationList
tblTeacherProcedure
tblTeacherProcedureSubject
tblTeacherProcedureType
tblTeacherValuationByStudent
tblTeacherValuationByStudentList
tblTeacherValuationRecord
tblTeacherValuationRecordList
tblTeacherVisitNo
tblTeamGroup
tblTeamGroupMember
tblTerm
tblThisPCData
tblThisPCData1
tblTimeByHalfHour
tblTimeByQuarterHour
tblTimeHalf
tblTimeHour
tblTimeQuarter
tblTitle
tblTransactionHistory
tblTransactionType
tblUnitActionType
tblUnitExpense
tblUnitStatus
tblUnitType
tblUnitTypeCondition
tblUser
tblUserAccountType
tblUserGroup
tblUserGroupAccount
tblUserMoneyAccount
tblUserReceiptSubject
tblUserSetting
tblUserStatus
tblUseType
tblValuationForm
tblValuationFormGroup
tblValuationPersonType
tblVatType
tblVersion
tblWeek
tblWeekDay
tblWorkerRentContract
tblWorkerRentContractEmployee
tblYear
testNewName
tmbNotUsedMoneyTransaction
tmpAccountBalance
tmpInvoicePaidSum
tmpItemBalance
tmpItemCost
tmpItemTotal
tmpLastPaymentDate
tmpLastRentLeaseRenewal
tmpMoneyAccountBalance
tmpPurchaseInvoiceSummary
tmpSalesInvoiceSummary
USysRibbons
ValuationFormObject
         */



        /*

         Columns in the database - tblUser:
    CurrentStatusID
    FirstEntry
    ID
    LastEntry
    NameAr
    NameEn
    Password
    Stopped
    UserGroupID
    UserName

         */
        public List<string> GetTables()
        {
            List<string> tables = new List<string>();
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Codes\\Codes101\\report.accde;Persist Security Info=False;";
            conn.Open();
            
            DataTable dt = conn.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                tables.Add(row["TABLE_NAME"].ToString());
            }



            conn.Close();
            return tables;
        }
        

        // get columns of a table
        public List<string> GetColumns(string tableName)
        {
            List<string> columns = new List<string>();
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Codes\\Codes101\\report.accde;Persist Security Info=False;";
            conn.Open();
            DataTable dt = conn.GetSchema("Columns", new string[] { null, null, tableName });
            foreach (DataRow row in dt.Rows)
            {
                columns.Add(row["COLUMN_NAME"].ToString());
            }
            conn.Close();
            return columns;
        }


        // get data of a table
        public DataTable GetTableData(string tableName)
        {
            DataTable dt = new DataTable();
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Codes\\Codes101\\report.accde;Persist Security Info=False;";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM " + tableName, conn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }


    }
}
