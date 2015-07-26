
using System;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Collections.Generic;

namespace SevenH.MMCSB.Atm.Domain
{

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("LoginUser", Namespace = Strings.DefaultNamespace)]
    public partial class LoginUser
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_UserId;
        public const string PropertyNameUserId = "UserId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LoginId;
        public const string PropertyNameLoginId = "LoginId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Salt;
        public const string PropertyNameSalt = "Salt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FullName;
        public const string PropertyNameFullName = "FullName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_UserName;
        public const string PropertyNameUserName = "UserName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Password;
        public const string PropertyNamePassword = "Password";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Status;
        public const string PropertyNameStatus = "Status";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_IsLocked;
        public const string PropertyNameIsLocked = "IsLocked";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_FirstTime;
        public const string PropertyNameFirstTime = "FirstTime";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Email;
        public const string PropertyNameEmail = "Email";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AlternativeEmail;
        public const string PropertyNameAlternativeEmail = "AlternativeEmail";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ServiceCd;
        public const string PropertyNameServiceCd = "ServiceCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ModifiedBy;
        public const string PropertyNameModifiedBy = "ModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private int? m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastLoginDt;
        public const string PropertyNameLastLoginDt = "LastLoginDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_ModifiedDt;
        public const string PropertyNameModifiedDt = "ModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int UserId
        {
            set
            {
                if (m_UserId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameUserId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_UserId = value;
                    OnPropertyChanged(PropertyNameUserId);
                }
            }
            get
            {
                return m_UserId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LoginId
        {
            set
            {
                if (String.Equals(m_LoginId, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLoginId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LoginId = value;
                    OnPropertyChanged(PropertyNameLoginId);
                }
            }
            get
            {
                return m_LoginId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Salt
        {
            set
            {
                if (String.Equals(m_Salt, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSalt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Salt = value;
                    OnPropertyChanged(PropertyNameSalt);
                }
            }
            get
            {
                return m_Salt;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string FullName
        {
            set
            {
                if (String.Equals(m_FullName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFullName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FullName = value;
                    OnPropertyChanged(PropertyNameFullName);
                }
            }
            get
            {
                return m_FullName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string UserName
        {
            set
            {
                if (String.Equals(m_UserName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameUserName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_UserName = value;
                    OnPropertyChanged(PropertyNameUserName);
                }
            }
            get
            {
                return m_UserName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Password
        {
            set
            {
                if (String.Equals(m_Password, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePassword, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Password = value;
                    OnPropertyChanged(PropertyNamePassword);
                }
            }
            get
            {
                return m_Password;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Status
        {
            set
            {
                if (String.Equals(m_Status, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Status = value;
                    OnPropertyChanged(PropertyNameStatus);
                }
            }
            get
            {
                return m_Status;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool IsLocked
        {
            set
            {
                if (m_IsLocked == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIsLocked, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IsLocked = value;
                    OnPropertyChanged(PropertyNameIsLocked);
                }
            }
            get
            {
                return m_IsLocked;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool FirstTime
        {
            set
            {
                if (m_FirstTime == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFirstTime, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FirstTime = value;
                    OnPropertyChanged(PropertyNameFirstTime);
                }
            }
            get
            {
                return m_FirstTime;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Email
        {
            set
            {
                if (String.Equals(m_Email, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEmail, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Email = value;
                    OnPropertyChanged(PropertyNameEmail);
                }
            }
            get
            {
                return m_Email;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AlternativeEmail
        {
            set
            {
                if (String.Equals(m_AlternativeEmail, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAlternativeEmail, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AlternativeEmail = value;
                    OnPropertyChanged(PropertyNameAlternativeEmail);
                }
            }
            get
            {
                return m_AlternativeEmail;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ServiceCd
        {
            set
            {
                if (String.Equals(m_ServiceCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameServiceCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ServiceCd = value;
                    OnPropertyChanged(PropertyNameServiceCd);
                }
            }
            get
            {
                return m_ServiceCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ModifiedBy
        {
            set
            {
                if (String.Equals(m_ModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ModifiedBy = value;
                    OnPropertyChanged(PropertyNameModifiedBy);
                }
            }
            get
            {
                return m_ModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual int? ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get { return m_ApplicantId; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastLoginDt
        {
            set
            {
                if (m_LastLoginDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastLoginDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastLoginDt = value;
                    OnPropertyChanged(PropertyNameLastLoginDt);
                }
            }
            get { return m_LastLoginDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? ModifiedDt
        {
            set
            {
                if (m_ModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ModifiedDt = value;
                    OnPropertyChanged(PropertyNameModifiedDt);
                }
            }
            get { return m_ModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Applicant", Namespace = Strings.DefaultNamespace)]
    public partial class Applicant
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NewICNo;
        public const string PropertyNameNewICNo = "NewICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NoTentera;
        public const string PropertyNameNoTentera = "NoTentera";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FullName;
        public const string PropertyNameFullName = "FullName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MrtlStatusCd;
        public const string PropertyNameMrtlStatusCd = "MrtlStatusCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GenderCd;
        public const string PropertyNameGenderCd = "GenderCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_Height;
        public const string PropertyNameHeight = "Height";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_Weight;
        public const string PropertyNameWeight = "Weight";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_BMI;
        public const string PropertyNameBMI = "BMI";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NationalityCd;
        public const string PropertyNameNationalityCd = "NationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NationalityCertNo;
        public const string PropertyNameNationalityCertNo = "NationalityCertNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthCertNo;
        public const string PropertyNameBirthCertNo = "BirthCertNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ReligionCd;
        public const string PropertyNameReligionCd = "ReligionCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_RaceCd;
        public const string PropertyNameRaceCd = "RaceCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_EthnicCd;
        public const string PropertyNameEthnicCd = "EthnicCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthCountryCd;
        public const string PropertyNameBirthCountryCd = "BirthCountryCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthStateCd;
        public const string PropertyNameBirthStateCd = "BirthStateCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthCityCd;
        public const string PropertyNameBirthCityCd = "BirthCityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthPlace;
        public const string PropertyNameBirthPlace = "BirthPlace";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BloodTypeCd;
        public const string PropertyNameBloodTypeCd = "BloodTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_SpectaclesUserInd;
        public const string PropertyNameSpectaclesUserInd = "SpectaclesUserInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ColorBlindInd;
        public const string PropertyNameColorBlindInd = "ColorBlindInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ResidenceTypeInd;
        public const string PropertyNameResidenceTypeInd = "ResidenceTypeInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddr1;
        public const string PropertyNameCorresponAddr1 = "CorresponAddr1";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddr2;
        public const string PropertyNameCorresponAddr2 = "CorresponAddr2";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddr3;
        public const string PropertyNameCorresponAddr3 = "CorresponAddr3";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddrPostCd;
        public const string PropertyNameCorresponAddrPostCd = "CorresponAddrPostCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddrCityCd;
        public const string PropertyNameCorresponAddrCityCd = "CorresponAddrCityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddrStateCd;
        public const string PropertyNameCorresponAddrStateCd = "CorresponAddrStateCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddrCountryCd;
        public const string PropertyNameCorresponAddrCountryCd = "CorresponAddrCountryCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MobilePhoneNo;
        public const string PropertyNameMobilePhoneNo = "MobilePhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HomePhoneNo;
        public const string PropertyNameHomePhoneNo = "HomePhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Email;
        public const string PropertyNameEmail = "Email";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ChildNo;
        public const string PropertyNameChildNo = "ChildNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_NoOfSibling;
        public const string PropertyNameNoOfSibling = "NoOfSibling";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomName;
        public const string PropertyNameMomName = "MomName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomICNo;
        public const string PropertyNameMomICNo = "MomICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomPhoneNo;
        public const string PropertyNameMomPhoneNo = "MomPhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomNationalityCd;
        public const string PropertyNameMomNationalityCd = "MomNationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomOccupation;
        public const string PropertyNameMomOccupation = "MomOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_MomSalary;
        public const string PropertyNameMomSalary = "MomSalary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadName;
        public const string PropertyNameDadName = "DadName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadICNo;
        public const string PropertyNameDadICNo = "DadICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadNationalityCd;
        public const string PropertyNameDadNationalityCd = "DadNationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadOccupation;
        public const string PropertyNameDadOccupation = "DadOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_DadSalary;
        public const string PropertyNameDadSalary = "DadSalary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadPhoneNo;
        public const string PropertyNameDadPhoneNo = "DadPhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianName;
        public const string PropertyNameGuardianName = "GuardianName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianICNo;
        public const string PropertyNameGuardianICNo = "GuardianICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianPhoneNo;
        public const string PropertyNameGuardianPhoneNo = "GuardianPhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianNationalityCd;
        public const string PropertyNameGuardianNationalityCd = "GuardianNationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianOccupation;
        public const string PropertyNameGuardianOccupation = "GuardianOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_GuardianSalary;
        public const string PropertyNameGuardianSalary = "GuardianSalary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FamilyHighestEduLevel;
        public const string PropertyNameFamilyHighestEduLevel = "FamilyHighestEduLevel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CurrentOccupation;
        public const string PropertyNameCurrentOccupation = "CurrentOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CurrentOrganisation;
        public const string PropertyNameCurrentOrganisation = "CurrentOrganisation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_CurrentSalary;
        public const string PropertyNameCurrentSalary = "CurrentSalary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_PalapesYear;
        public const string PropertyNamePalapesYear = "PalapesYear";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PalapesServices;
        public const string PropertyNamePalapesServices = "PalapesServices";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PalapesArmyNo;
        public const string PropertyNamePalapesArmyNo = "PalapesArmyNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PalapesInstitution;
        public const string PropertyNamePalapesInstitution = "PalapesInstitution";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PalapesRemark;
        public const string PropertyNamePalapesRemark = "PalapesRemark";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ScholarshipBody;
        public const string PropertyNameScholarshipBody = "ScholarshipBody";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ScholarshipBodyAddr;
        public const string PropertyNameScholarshipBodyAddr = "ScholarshipBodyAddr";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ScholarshipNoOfYrContract;
        public const string PropertyNameScholarshipNoOfYrContract = "ScholarshipNoOfYrContract";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ArmySelectionVenue;
        public const string PropertyNameArmySelectionVenue = "ArmySelectionVenue";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ArmyServiceYrOfServ;
        public const string PropertyNameArmyServiceYrOfServ = "ArmyServiceYrOfServ";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ArmyServiceResignRemark;
        public const string PropertyNameArmyServiceResignRemark = "ArmyServiceResignRemark";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SelectionTD;
        public const string PropertyNameSelectionTD = "SelectionTD";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SelectionTL;
        public const string PropertyNameSelectionTL = "SelectionTL";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SelectionTU;
        public const string PropertyNameSelectionTU = "SelectionTU";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerMSWord;
        public const string PropertyNameComputerMSWord = "ComputerMSWord";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerMSExcel;
        public const string PropertyNameComputerMSExcel = "ComputerMSExcel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerMSPwrPoint;
        public const string PropertyNameComputerMSPwrPoint = "ComputerMSPwrPoint";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerICT;
        public const string PropertyNameComputerICT = "ComputerICT";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerOthersInd;
        public const string PropertyNameComputerOthersInd = "ComputerOthersInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ComputerOthers;
        public const string PropertyNameComputerOthers = "ComputerOthers";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PelepasanDocument;
        public const string PropertyNamePelepasanDocument = "PelepasanDocument";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_OriginalPelepasanDocument;
        public const string PropertyNameOriginalPelepasanDocument = "OriginalPelepasanDocument";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_BirthDt;
        public const string PropertyNameBirthDt = "BirthDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_Age;
        public const string PropertyNameAge = "Age";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_PalapesTauliahEndDt;
        public const string PropertyNamePalapesTauliahEndDt = "PalapesTauliahEndDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_ScholarshipContractStDate;
        public const string PropertyNameScholarshipContractStDate = "ScholarshipContractStDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_ArmySelectionDt;
        public const string PropertyNameArmySelectionDt = "ArmySelectionDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_ArmyServiceInd;
        public const string PropertyNameArmyServiceInd = "ArmyServiceInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_PalapesInd;
        public const string PropertyNamePalapesInd = "PalapesInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_ScholarshipInd;
        public const string PropertyNameScholarshipInd = "ScholarshipInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_ArmySelectionInd;
        public const string PropertyNameArmySelectionInd = "ArmySelectionInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_EmployeeAggreeInd;
        public const string PropertyNameEmployeeAggreeInd = "EmployeeAggreeInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_CrimeInvolvement;
        public const string PropertyNameCrimeInvolvement = "CrimeInvolvement";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_DrugCaseInvolvement;
        public const string PropertyNameDrugCaseInvolvement = "DrugCaseInvolvement";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_CronicIlnessInd;
        public const string PropertyNameCronicIlnessInd = "CronicIlnessInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_MomNotApplicable;
        public const string PropertyNameMomNotApplicable = "MomNotApplicable";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_DadNotApplicable;
        public const string PropertyNameDadNotApplicable = "DadNotApplicable";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_GuardianNotApplicable;
        public const string PropertyNameGuardianNotApplicable = "GuardianNotApplicable";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantEducation> m_ApplicantEducationCollection = new List<ApplicantEducation>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantEducation", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantEducation> ApplicantEducationCollection
        {
            get { return m_ApplicantEducationCollection; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantSport> m_ApplicantSportCollection = new List<ApplicantSport>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantSport", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantSport> ApplicantSportCollection
        {
            get { return m_ApplicantSportCollection; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantDispStatus> m_ApplicantDispStatusCollection = new List<ApplicantDispStatus>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantDispStatus", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantDispStatus> ApplicantDispStatusCollection
        {
            get { return m_ApplicantDispStatusCollection; }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NewICNo
        {
            set
            {
                if (String.Equals(m_NewICNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNewICNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NewICNo = value;
                    OnPropertyChanged(PropertyNameNewICNo);
                }
            }
            get
            {
                return m_NewICNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NoTentera
        {
            set
            {
                if (String.Equals(m_NoTentera, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNoTentera, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NoTentera = value;
                    OnPropertyChanged(PropertyNameNoTentera);
                }
            }
            get
            {
                return m_NoTentera;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string FullName
        {
            set
            {
                if (String.Equals(m_FullName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFullName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FullName = value;
                    OnPropertyChanged(PropertyNameFullName);
                }
            }
            get
            {
                return m_FullName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MrtlStatusCd
        {
            set
            {
                if (String.Equals(m_MrtlStatusCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMrtlStatusCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MrtlStatusCd = value;
                    OnPropertyChanged(PropertyNameMrtlStatusCd);
                }
            }
            get
            {
                return m_MrtlStatusCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GenderCd
        {
            set
            {
                if (String.Equals(m_GenderCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGenderCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GenderCd = value;
                    OnPropertyChanged(PropertyNameGenderCd);
                }
            }
            get
            {
                return m_GenderCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal Height
        {
            set
            {
                if (m_Height == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHeight, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Height = value;
                    OnPropertyChanged(PropertyNameHeight);
                }
            }
            get
            {
                return m_Height;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal Weight
        {
            set
            {
                if (m_Weight == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameWeight, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Weight = value;
                    OnPropertyChanged(PropertyNameWeight);
                }
            }
            get
            {
                return m_Weight;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal BMI
        {
            set
            {
                if (m_BMI == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBMI, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BMI = value;
                    OnPropertyChanged(PropertyNameBMI);
                }
            }
            get
            {
                return m_BMI;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NationalityCd
        {
            set
            {
                if (String.Equals(m_NationalityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNationalityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NationalityCd = value;
                    OnPropertyChanged(PropertyNameNationalityCd);
                }
            }
            get
            {
                return m_NationalityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NationalityCertNo
        {
            set
            {
                if (String.Equals(m_NationalityCertNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNationalityCertNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NationalityCertNo = value;
                    OnPropertyChanged(PropertyNameNationalityCertNo);
                }
            }
            get
            {
                return m_NationalityCertNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthCertNo
        {
            set
            {
                if (String.Equals(m_BirthCertNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthCertNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthCertNo = value;
                    OnPropertyChanged(PropertyNameBirthCertNo);
                }
            }
            get
            {
                return m_BirthCertNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ReligionCd
        {
            set
            {
                if (String.Equals(m_ReligionCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameReligionCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ReligionCd = value;
                    OnPropertyChanged(PropertyNameReligionCd);
                }
            }
            get
            {
                return m_ReligionCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string RaceCd
        {
            set
            {
                if (String.Equals(m_RaceCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameRaceCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_RaceCd = value;
                    OnPropertyChanged(PropertyNameRaceCd);
                }
            }
            get
            {
                return m_RaceCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string EthnicCd
        {
            set
            {
                if (String.Equals(m_EthnicCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEthnicCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EthnicCd = value;
                    OnPropertyChanged(PropertyNameEthnicCd);
                }
            }
            get
            {
                return m_EthnicCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthCountryCd
        {
            set
            {
                if (String.Equals(m_BirthCountryCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthCountryCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthCountryCd = value;
                    OnPropertyChanged(PropertyNameBirthCountryCd);
                }
            }
            get
            {
                return m_BirthCountryCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthStateCd
        {
            set
            {
                if (String.Equals(m_BirthStateCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthStateCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthStateCd = value;
                    OnPropertyChanged(PropertyNameBirthStateCd);
                }
            }
            get
            {
                return m_BirthStateCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthCityCd
        {
            set
            {
                if (String.Equals(m_BirthCityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthCityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthCityCd = value;
                    OnPropertyChanged(PropertyNameBirthCityCd);
                }
            }
            get
            {
                return m_BirthCityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthPlace
        {
            set
            {
                if (String.Equals(m_BirthPlace, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthPlace, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthPlace = value;
                    OnPropertyChanged(PropertyNameBirthPlace);
                }
            }
            get
            {
                return m_BirthPlace;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BloodTypeCd
        {
            set
            {
                if (String.Equals(m_BloodTypeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBloodTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BloodTypeCd = value;
                    OnPropertyChanged(PropertyNameBloodTypeCd);
                }
            }
            get
            {
                return m_BloodTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool SpectaclesUserInd
        {
            set
            {
                if (m_SpectaclesUserInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSpectaclesUserInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SpectaclesUserInd = value;
                    OnPropertyChanged(PropertyNameSpectaclesUserInd);
                }
            }
            get
            {
                return m_SpectaclesUserInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ColorBlindInd
        {
            set
            {
                if (m_ColorBlindInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameColorBlindInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ColorBlindInd = value;
                    OnPropertyChanged(PropertyNameColorBlindInd);
                }
            }
            get
            {
                return m_ColorBlindInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ResidenceTypeInd
        {
            set
            {
                if (String.Equals(m_ResidenceTypeInd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameResidenceTypeInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ResidenceTypeInd = value;
                    OnPropertyChanged(PropertyNameResidenceTypeInd);
                }
            }
            get
            {
                return m_ResidenceTypeInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddr1
        {
            set
            {
                if (String.Equals(m_CorresponAddr1, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddr1, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddr1 = value;
                    OnPropertyChanged(PropertyNameCorresponAddr1);
                }
            }
            get
            {
                return m_CorresponAddr1;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddr2
        {
            set
            {
                if (String.Equals(m_CorresponAddr2, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddr2, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddr2 = value;
                    OnPropertyChanged(PropertyNameCorresponAddr2);
                }
            }
            get
            {
                return m_CorresponAddr2;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddr3
        {
            set
            {
                if (String.Equals(m_CorresponAddr3, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddr3, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddr3 = value;
                    OnPropertyChanged(PropertyNameCorresponAddr3);
                }
            }
            get
            {
                return m_CorresponAddr3;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddrPostCd
        {
            set
            {
                if (String.Equals(m_CorresponAddrPostCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddrPostCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddrPostCd = value;
                    OnPropertyChanged(PropertyNameCorresponAddrPostCd);
                }
            }
            get
            {
                return m_CorresponAddrPostCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddrCityCd
        {
            set
            {
                if (String.Equals(m_CorresponAddrCityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddrCityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddrCityCd = value;
                    OnPropertyChanged(PropertyNameCorresponAddrCityCd);
                }
            }
            get
            {
                return m_CorresponAddrCityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddrStateCd
        {
            set
            {
                if (String.Equals(m_CorresponAddrStateCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddrStateCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddrStateCd = value;
                    OnPropertyChanged(PropertyNameCorresponAddrStateCd);
                }
            }
            get
            {
                return m_CorresponAddrStateCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddrCountryCd
        {
            set
            {
                if (String.Equals(m_CorresponAddrCountryCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddrCountryCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddrCountryCd = value;
                    OnPropertyChanged(PropertyNameCorresponAddrCountryCd);
                }
            }
            get
            {
                return m_CorresponAddrCountryCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MobilePhoneNo
        {
            set
            {
                if (String.Equals(m_MobilePhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMobilePhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MobilePhoneNo = value;
                    OnPropertyChanged(PropertyNameMobilePhoneNo);
                }
            }
            get
            {
                return m_MobilePhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HomePhoneNo
        {
            set
            {
                if (String.Equals(m_HomePhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHomePhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HomePhoneNo = value;
                    OnPropertyChanged(PropertyNameHomePhoneNo);
                }
            }
            get
            {
                return m_HomePhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Email
        {
            set
            {
                if (String.Equals(m_Email, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEmail, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Email = value;
                    OnPropertyChanged(PropertyNameEmail);
                }
            }
            get
            {
                return m_Email;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ChildNo
        {
            set
            {
                if (m_ChildNo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameChildNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ChildNo = value;
                    OnPropertyChanged(PropertyNameChildNo);
                }
            }
            get
            {
                return m_ChildNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int NoOfSibling
        {
            set
            {
                if (m_NoOfSibling == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNoOfSibling, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NoOfSibling = value;
                    OnPropertyChanged(PropertyNameNoOfSibling);
                }
            }
            get
            {
                return m_NoOfSibling;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomName
        {
            set
            {
                if (String.Equals(m_MomName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomName = value;
                    OnPropertyChanged(PropertyNameMomName);
                }
            }
            get
            {
                return m_MomName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomICNo
        {
            set
            {
                if (String.Equals(m_MomICNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomICNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomICNo = value;
                    OnPropertyChanged(PropertyNameMomICNo);
                }
            }
            get
            {
                return m_MomICNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomPhoneNo
        {
            set
            {
                if (String.Equals(m_MomPhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomPhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomPhoneNo = value;
                    OnPropertyChanged(PropertyNameMomPhoneNo);
                }
            }
            get
            {
                return m_MomPhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomNationalityCd
        {
            set
            {
                if (String.Equals(m_MomNationalityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomNationalityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomNationalityCd = value;
                    OnPropertyChanged(PropertyNameMomNationalityCd);
                }
            }
            get
            {
                return m_MomNationalityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomOccupation
        {
            set
            {
                if (String.Equals(m_MomOccupation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomOccupation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomOccupation = value;
                    OnPropertyChanged(PropertyNameMomOccupation);
                }
            }
            get
            {
                return m_MomOccupation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal MomSalary
        {
            set
            {
                if (m_MomSalary == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomSalary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomSalary = value;
                    OnPropertyChanged(PropertyNameMomSalary);
                }
            }
            get
            {
                return m_MomSalary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadName
        {
            set
            {
                if (String.Equals(m_DadName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadName = value;
                    OnPropertyChanged(PropertyNameDadName);
                }
            }
            get
            {
                return m_DadName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadICNo
        {
            set
            {
                if (String.Equals(m_DadICNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadICNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadICNo = value;
                    OnPropertyChanged(PropertyNameDadICNo);
                }
            }
            get
            {
                return m_DadICNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadNationalityCd
        {
            set
            {
                if (String.Equals(m_DadNationalityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadNationalityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadNationalityCd = value;
                    OnPropertyChanged(PropertyNameDadNationalityCd);
                }
            }
            get
            {
                return m_DadNationalityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadOccupation
        {
            set
            {
                if (String.Equals(m_DadOccupation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadOccupation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadOccupation = value;
                    OnPropertyChanged(PropertyNameDadOccupation);
                }
            }
            get
            {
                return m_DadOccupation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal DadSalary
        {
            set
            {
                if (m_DadSalary == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadSalary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadSalary = value;
                    OnPropertyChanged(PropertyNameDadSalary);
                }
            }
            get
            {
                return m_DadSalary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadPhoneNo
        {
            set
            {
                if (String.Equals(m_DadPhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadPhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadPhoneNo = value;
                    OnPropertyChanged(PropertyNameDadPhoneNo);
                }
            }
            get
            {
                return m_DadPhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianName
        {
            set
            {
                if (String.Equals(m_GuardianName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianName = value;
                    OnPropertyChanged(PropertyNameGuardianName);
                }
            }
            get
            {
                return m_GuardianName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianICNo
        {
            set
            {
                if (String.Equals(m_GuardianICNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianICNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianICNo = value;
                    OnPropertyChanged(PropertyNameGuardianICNo);
                }
            }
            get
            {
                return m_GuardianICNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianPhoneNo
        {
            set
            {
                if (String.Equals(m_GuardianPhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianPhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianPhoneNo = value;
                    OnPropertyChanged(PropertyNameGuardianPhoneNo);
                }
            }
            get
            {
                return m_GuardianPhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianNationalityCd
        {
            set
            {
                if (String.Equals(m_GuardianNationalityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianNationalityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianNationalityCd = value;
                    OnPropertyChanged(PropertyNameGuardianNationalityCd);
                }
            }
            get
            {
                return m_GuardianNationalityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianOccupation
        {
            set
            {
                if (String.Equals(m_GuardianOccupation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianOccupation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianOccupation = value;
                    OnPropertyChanged(PropertyNameGuardianOccupation);
                }
            }
            get
            {
                return m_GuardianOccupation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal GuardianSalary
        {
            set
            {
                if (m_GuardianSalary == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianSalary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianSalary = value;
                    OnPropertyChanged(PropertyNameGuardianSalary);
                }
            }
            get
            {
                return m_GuardianSalary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string FamilyHighestEduLevel
        {
            set
            {
                if (String.Equals(m_FamilyHighestEduLevel, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFamilyHighestEduLevel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FamilyHighestEduLevel = value;
                    OnPropertyChanged(PropertyNameFamilyHighestEduLevel);
                }
            }
            get
            {
                return m_FamilyHighestEduLevel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CurrentOccupation
        {
            set
            {
                if (String.Equals(m_CurrentOccupation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCurrentOccupation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CurrentOccupation = value;
                    OnPropertyChanged(PropertyNameCurrentOccupation);
                }
            }
            get
            {
                return m_CurrentOccupation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CurrentOrganisation
        {
            set
            {
                if (String.Equals(m_CurrentOrganisation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCurrentOrganisation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CurrentOrganisation = value;
                    OnPropertyChanged(PropertyNameCurrentOrganisation);
                }
            }
            get
            {
                return m_CurrentOrganisation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal CurrentSalary
        {
            set
            {
                if (m_CurrentSalary == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCurrentSalary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CurrentSalary = value;
                    OnPropertyChanged(PropertyNameCurrentSalary);
                }
            }
            get
            {
                return m_CurrentSalary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int PalapesYear
        {
            set
            {
                if (m_PalapesYear == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesYear, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesYear = value;
                    OnPropertyChanged(PropertyNamePalapesYear);
                }
            }
            get
            {
                return m_PalapesYear;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PalapesServices
        {
            set
            {
                if (String.Equals(m_PalapesServices, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesServices, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesServices = value;
                    OnPropertyChanged(PropertyNamePalapesServices);
                }
            }
            get
            {
                return m_PalapesServices;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PalapesArmyNo
        {
            set
            {
                if (String.Equals(m_PalapesArmyNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesArmyNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesArmyNo = value;
                    OnPropertyChanged(PropertyNamePalapesArmyNo);
                }
            }
            get
            {
                return m_PalapesArmyNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PalapesInstitution
        {
            set
            {
                if (String.Equals(m_PalapesInstitution, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesInstitution, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesInstitution = value;
                    OnPropertyChanged(PropertyNamePalapesInstitution);
                }
            }
            get
            {
                return m_PalapesInstitution;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PalapesRemark
        {
            set
            {
                if (String.Equals(m_PalapesRemark, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesRemark, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesRemark = value;
                    OnPropertyChanged(PropertyNamePalapesRemark);
                }
            }
            get
            {
                return m_PalapesRemark;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ScholarshipBody
        {
            set
            {
                if (String.Equals(m_ScholarshipBody, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipBody, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipBody = value;
                    OnPropertyChanged(PropertyNameScholarshipBody);
                }
            }
            get
            {
                return m_ScholarshipBody;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ScholarshipBodyAddr
        {
            set
            {
                if (String.Equals(m_ScholarshipBodyAddr, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipBodyAddr, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipBodyAddr = value;
                    OnPropertyChanged(PropertyNameScholarshipBodyAddr);
                }
            }
            get
            {
                return m_ScholarshipBodyAddr;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ScholarshipNoOfYrContract
        {
            set
            {
                if (String.Equals(m_ScholarshipNoOfYrContract, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipNoOfYrContract, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipNoOfYrContract = value;
                    OnPropertyChanged(PropertyNameScholarshipNoOfYrContract);
                }
            }
            get
            {
                return m_ScholarshipNoOfYrContract;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ArmySelectionVenue
        {
            set
            {
                if (String.Equals(m_ArmySelectionVenue, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmySelectionVenue, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmySelectionVenue = value;
                    OnPropertyChanged(PropertyNameArmySelectionVenue);
                }
            }
            get
            {
                return m_ArmySelectionVenue;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ArmyServiceYrOfServ
        {
            set
            {
                if (String.Equals(m_ArmyServiceYrOfServ, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmyServiceYrOfServ, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmyServiceYrOfServ = value;
                    OnPropertyChanged(PropertyNameArmyServiceYrOfServ);
                }
            }
            get
            {
                return m_ArmyServiceYrOfServ;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ArmyServiceResignRemark
        {
            set
            {
                if (String.Equals(m_ArmyServiceResignRemark, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmyServiceResignRemark, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmyServiceResignRemark = value;
                    OnPropertyChanged(PropertyNameArmyServiceResignRemark);
                }
            }
            get
            {
                return m_ArmyServiceResignRemark;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SelectionTD
        {
            set
            {
                if (m_SelectionTD == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSelectionTD, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SelectionTD = value;
                    OnPropertyChanged(PropertyNameSelectionTD);
                }
            }
            get
            {
                return m_SelectionTD;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SelectionTL
        {
            set
            {
                if (m_SelectionTL == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSelectionTL, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SelectionTL = value;
                    OnPropertyChanged(PropertyNameSelectionTL);
                }
            }
            get
            {
                return m_SelectionTL;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SelectionTU
        {
            set
            {
                if (m_SelectionTU == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSelectionTU, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SelectionTU = value;
                    OnPropertyChanged(PropertyNameSelectionTU);
                }
            }
            get
            {
                return m_SelectionTU;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerMSWord
        {
            set
            {
                if (m_ComputerMSWord == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerMSWord, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerMSWord = value;
                    OnPropertyChanged(PropertyNameComputerMSWord);
                }
            }
            get
            {
                return m_ComputerMSWord;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerMSExcel
        {
            set
            {
                if (m_ComputerMSExcel == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerMSExcel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerMSExcel = value;
                    OnPropertyChanged(PropertyNameComputerMSExcel);
                }
            }
            get
            {
                return m_ComputerMSExcel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerMSPwrPoint
        {
            set
            {
                if (m_ComputerMSPwrPoint == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerMSPwrPoint, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerMSPwrPoint = value;
                    OnPropertyChanged(PropertyNameComputerMSPwrPoint);
                }
            }
            get
            {
                return m_ComputerMSPwrPoint;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerICT
        {
            set
            {
                if (m_ComputerICT == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerICT, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerICT = value;
                    OnPropertyChanged(PropertyNameComputerICT);
                }
            }
            get
            {
                return m_ComputerICT;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerOthersInd
        {
            set
            {
                if (m_ComputerOthersInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerOthersInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerOthersInd = value;
                    OnPropertyChanged(PropertyNameComputerOthersInd);
                }
            }
            get
            {
                return m_ComputerOthersInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ComputerOthers
        {
            set
            {
                if (String.Equals(m_ComputerOthers, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerOthers, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerOthers = value;
                    OnPropertyChanged(PropertyNameComputerOthers);
                }
            }
            get
            {
                return m_ComputerOthers;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PelepasanDocument
        {
            set
            {
                if (String.Equals(m_PelepasanDocument, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePelepasanDocument, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PelepasanDocument = value;
                    OnPropertyChanged(PropertyNamePelepasanDocument);
                }
            }
            get
            {
                return m_PelepasanDocument;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string OriginalPelepasanDocument
        {
            set
            {
                if (String.Equals(m_OriginalPelepasanDocument, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOriginalPelepasanDocument, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OriginalPelepasanDocument = value;
                    OnPropertyChanged(PropertyNameOriginalPelepasanDocument);
                }
            }
            get
            {
                return m_OriginalPelepasanDocument;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? BirthDt
        {
            set
            {
                if (m_BirthDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthDt = value;
                    OnPropertyChanged(PropertyNameBirthDt);
                }
            }
            get { return m_BirthDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? Age
        {
            set
            {
                if (m_Age == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAge, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Age = value;
                    OnPropertyChanged(PropertyNameAge);
                }
            }
            get { return m_Age; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? PalapesTauliahEndDt
        {
            set
            {
                if (m_PalapesTauliahEndDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesTauliahEndDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesTauliahEndDt = value;
                    OnPropertyChanged(PropertyNamePalapesTauliahEndDt);
                }
            }
            get { return m_PalapesTauliahEndDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? ScholarshipContractStDate
        {
            set
            {
                if (m_ScholarshipContractStDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipContractStDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipContractStDate = value;
                    OnPropertyChanged(PropertyNameScholarshipContractStDate);
                }
            }
            get { return m_ScholarshipContractStDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? ArmySelectionDt
        {
            set
            {
                if (m_ArmySelectionDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmySelectionDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmySelectionDt = value;
                    OnPropertyChanged(PropertyNameArmySelectionDt);
                }
            }
            get { return m_ArmySelectionDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? ArmyServiceInd
        {
            set
            {
                if (m_ArmyServiceInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmyServiceInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmyServiceInd = value;
                    OnPropertyChanged(PropertyNameArmyServiceInd);
                }
            }
            get { return m_ArmyServiceInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? PalapesInd
        {
            set
            {
                if (m_PalapesInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesInd = value;
                    OnPropertyChanged(PropertyNamePalapesInd);
                }
            }
            get { return m_PalapesInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? ScholarshipInd
        {
            set
            {
                if (m_ScholarshipInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipInd = value;
                    OnPropertyChanged(PropertyNameScholarshipInd);
                }
            }
            get { return m_ScholarshipInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? ArmySelectionInd
        {
            set
            {
                if (m_ArmySelectionInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmySelectionInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmySelectionInd = value;
                    OnPropertyChanged(PropertyNameArmySelectionInd);
                }
            }
            get { return m_ArmySelectionInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? EmployeeAggreeInd
        {
            set
            {
                if (m_EmployeeAggreeInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEmployeeAggreeInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EmployeeAggreeInd = value;
                    OnPropertyChanged(PropertyNameEmployeeAggreeInd);
                }
            }
            get { return m_EmployeeAggreeInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? CrimeInvolvement
        {
            set
            {
                if (m_CrimeInvolvement == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCrimeInvolvement, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CrimeInvolvement = value;
                    OnPropertyChanged(PropertyNameCrimeInvolvement);
                }
            }
            get { return m_CrimeInvolvement; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? DrugCaseInvolvement
        {
            set
            {
                if (m_DrugCaseInvolvement == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDrugCaseInvolvement, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DrugCaseInvolvement = value;
                    OnPropertyChanged(PropertyNameDrugCaseInvolvement);
                }
            }
            get { return m_DrugCaseInvolvement; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? CronicIlnessInd
        {
            set
            {
                if (m_CronicIlnessInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCronicIlnessInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CronicIlnessInd = value;
                    OnPropertyChanged(PropertyNameCronicIlnessInd);
                }
            }
            get { return m_CronicIlnessInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? MomNotApplicable
        {
            set
            {
                if (m_MomNotApplicable == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomNotApplicable, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomNotApplicable = value;
                    OnPropertyChanged(PropertyNameMomNotApplicable);
                }
            }
            get { return m_MomNotApplicable; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? DadNotApplicable
        {
            set
            {
                if (m_DadNotApplicable == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadNotApplicable, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadNotApplicable = value;
                    OnPropertyChanged(PropertyNameDadNotApplicable);
                }
            }
            get { return m_DadNotApplicable; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? GuardianNotApplicable
        {
            set
            {
                if (m_GuardianNotApplicable == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianNotApplicable, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianNotApplicable = value;
                    OnPropertyChanged(PropertyNameGuardianNotApplicable);
                }
            }
            get { return m_GuardianNotApplicable; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantSubmitted", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantSubmitted
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicationId;
        public const string PropertyNameApplicationId = "ApplicationId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NewICNo;
        public const string PropertyNameNewICNo = "NewICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NoTentera;
        public const string PropertyNameNoTentera = "NoTentera";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FullName;
        public const string PropertyNameFullName = "FullName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MrtlStatusCd;
        public const string PropertyNameMrtlStatusCd = "MrtlStatusCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GenderCd;
        public const string PropertyNameGenderCd = "GenderCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_Height;
        public const string PropertyNameHeight = "Height";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_Weight;
        public const string PropertyNameWeight = "Weight";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_BMI;
        public const string PropertyNameBMI = "BMI";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NationalityCd;
        public const string PropertyNameNationalityCd = "NationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NationalityCertNo;
        public const string PropertyNameNationalityCertNo = "NationalityCertNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthCertNo;
        public const string PropertyNameBirthCertNo = "BirthCertNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ReligionCd;
        public const string PropertyNameReligionCd = "ReligionCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_RaceCd;
        public const string PropertyNameRaceCd = "RaceCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_EthnicCd;
        public const string PropertyNameEthnicCd = "EthnicCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthCountryCd;
        public const string PropertyNameBirthCountryCd = "BirthCountryCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthStateCd;
        public const string PropertyNameBirthStateCd = "BirthStateCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthCityCd;
        public const string PropertyNameBirthCityCd = "BirthCityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BirthPlace;
        public const string PropertyNameBirthPlace = "BirthPlace";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BloodTypeCd;
        public const string PropertyNameBloodTypeCd = "BloodTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_SpectaclesUserInd;
        public const string PropertyNameSpectaclesUserInd = "SpectaclesUserInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ColorBlindInd;
        public const string PropertyNameColorBlindInd = "ColorBlindInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ResidenceTypeInd;
        public const string PropertyNameResidenceTypeInd = "ResidenceTypeInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddr1;
        public const string PropertyNameCorresponAddr1 = "CorresponAddr1";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddr2;
        public const string PropertyNameCorresponAddr2 = "CorresponAddr2";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddr3;
        public const string PropertyNameCorresponAddr3 = "CorresponAddr3";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddrPostCd;
        public const string PropertyNameCorresponAddrPostCd = "CorresponAddrPostCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddrCityCd;
        public const string PropertyNameCorresponAddrCityCd = "CorresponAddrCityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddrStateCd;
        public const string PropertyNameCorresponAddrStateCd = "CorresponAddrStateCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CorresponAddrCountryCd;
        public const string PropertyNameCorresponAddrCountryCd = "CorresponAddrCountryCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MobilePhoneNo;
        public const string PropertyNameMobilePhoneNo = "MobilePhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HomePhoneNo;
        public const string PropertyNameHomePhoneNo = "HomePhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Email;
        public const string PropertyNameEmail = "Email";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ChildNo;
        public const string PropertyNameChildNo = "ChildNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_NoOfSibling;
        public const string PropertyNameNoOfSibling = "NoOfSibling";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomName;
        public const string PropertyNameMomName = "MomName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomICNo;
        public const string PropertyNameMomICNo = "MomICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomPhoneNo;
        public const string PropertyNameMomPhoneNo = "MomPhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomNationalityCd;
        public const string PropertyNameMomNationalityCd = "MomNationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomOccupation;
        public const string PropertyNameMomOccupation = "MomOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_MomSalary;
        public const string PropertyNameMomSalary = "MomSalary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadName;
        public const string PropertyNameDadName = "DadName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadICNo;
        public const string PropertyNameDadICNo = "DadICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadPhoneNo;
        public const string PropertyNameDadPhoneNo = "DadPhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadNationalityCd;
        public const string PropertyNameDadNationalityCd = "DadNationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_DadOccupation;
        public const string PropertyNameDadOccupation = "DadOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_DadSalary;
        public const string PropertyNameDadSalary = "DadSalary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianName;
        public const string PropertyNameGuardianName = "GuardianName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianICNo;
        public const string PropertyNameGuardianICNo = "GuardianICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianPhoneNo;
        public const string PropertyNameGuardianPhoneNo = "GuardianPhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianNationalityCd;
        public const string PropertyNameGuardianNationalityCd = "GuardianNationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianOccupation;
        public const string PropertyNameGuardianOccupation = "GuardianOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_GuardianSalary;
        public const string PropertyNameGuardianSalary = "GuardianSalary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FamilyHighestEduLevel;
        public const string PropertyNameFamilyHighestEduLevel = "FamilyHighestEduLevel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CurrentOccupation;
        public const string PropertyNameCurrentOccupation = "CurrentOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CurrentOrganisation;
        public const string PropertyNameCurrentOrganisation = "CurrentOrganisation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_CurrentSalary;
        public const string PropertyNameCurrentSalary = "CurrentSalary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_PalapesYear;
        public const string PropertyNamePalapesYear = "PalapesYear";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PalapesServices;
        public const string PropertyNamePalapesServices = "PalapesServices";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PalapesArmyNo;
        public const string PropertyNamePalapesArmyNo = "PalapesArmyNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PalapesInstitution;
        public const string PropertyNamePalapesInstitution = "PalapesInstitution";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PalapesRemark;
        public const string PropertyNamePalapesRemark = "PalapesRemark";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ScholarshipBody;
        public const string PropertyNameScholarshipBody = "ScholarshipBody";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ScholarshipBodyAddr;
        public const string PropertyNameScholarshipBodyAddr = "ScholarshipBodyAddr";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ScholarshipNoOfYrContract;
        public const string PropertyNameScholarshipNoOfYrContract = "ScholarshipNoOfYrContract";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ArmySelectionVenue;
        public const string PropertyNameArmySelectionVenue = "ArmySelectionVenue";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ArmyServiceYrOfServ;
        public const string PropertyNameArmyServiceYrOfServ = "ArmyServiceYrOfServ";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ArmyServiceResignRemark;
        public const string PropertyNameArmyServiceResignRemark = "ArmyServiceResignRemark";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SelectionTD;
        public const string PropertyNameSelectionTD = "SelectionTD";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SelectionTL;
        public const string PropertyNameSelectionTL = "SelectionTL";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SelectionTU;
        public const string PropertyNameSelectionTU = "SelectionTU";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerMSWord;
        public const string PropertyNameComputerMSWord = "ComputerMSWord";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerMSExcel;
        public const string PropertyNameComputerMSExcel = "ComputerMSExcel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerMSPwrPoint;
        public const string PropertyNameComputerMSPwrPoint = "ComputerMSPwrPoint";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ComputerICT;
        public const string PropertyNameComputerICT = "ComputerICT";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ComputerOthers;
        public const string PropertyNameComputerOthers = "ComputerOthers";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PelepasanDocument;
        public const string PropertyNamePelepasanDocument = "PelepasanDocument";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_OriginalPelepasanDocument;
        public const string PropertyNameOriginalPelepasanDocument = "OriginalPelepasanDocument";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_BirthDt;
        public const string PropertyNameBirthDt = "BirthDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_Age;
        public const string PropertyNameAge = "Age";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_PalapesTauliahEndDt;
        public const string PropertyNamePalapesTauliahEndDt = "PalapesTauliahEndDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_ScholarshipContractStDate;
        public const string PropertyNameScholarshipContractStDate = "ScholarshipContractStDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_ArmySelectionDt;
        public const string PropertyNameArmySelectionDt = "ArmySelectionDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_ArmyServiceInd;
        public const string PropertyNameArmyServiceInd = "ArmyServiceInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_PalapesInd;
        public const string PropertyNamePalapesInd = "PalapesInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_ScholarshipInd;
        public const string PropertyNameScholarshipInd = "ScholarshipInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_ArmySelectionInd;
        public const string PropertyNameArmySelectionInd = "ArmySelectionInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_EmployeeAggreeInd;
        public const string PropertyNameEmployeeAggreeInd = "EmployeeAggreeInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_CrimeInvolvement;
        public const string PropertyNameCrimeInvolvement = "CrimeInvolvement";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_DrugCaseInvolvement;
        public const string PropertyNameDrugCaseInvolvement = "DrugCaseInvolvement";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_CronicIlnessInd;
        public const string PropertyNameCronicIlnessInd = "CronicIlnessInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_MomNotApplicable;
        public const string PropertyNameMomNotApplicable = "MomNotApplicable";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_DadNotApplicable;
        public const string PropertyNameDadNotApplicable = "DadNotApplicable";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_GuardianNotApplicable;
        public const string PropertyNameGuardianNotApplicable = "GuardianNotApplicable";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantEducationSubmitted> m_ApplicantEducationSubmittedCollection = new List<ApplicantEducationSubmitted>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantEducationSubmitted", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantEducationSubmitted> ApplicantEducationSubmittedCollection
        {
            get { return m_ApplicantEducationSubmittedCollection; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantSportSubmitted> m_ApplicantSportSubmittedCollection = new List<ApplicantSportSubmitted>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantSportSubmitted", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantSportSubmitted> ApplicantSportSubmittedCollection
        {
            get { return m_ApplicantSportSubmittedCollection; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantSkillSubmitted> m_ApplicantSkillSubmittedCollection = new List<ApplicantSkillSubmitted>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantSkillSubmitted", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantSkillSubmitted> ApplicantSkillSubmittedCollection
        {
            get { return m_ApplicantSkillSubmittedCollection; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantDispStatusSubmitted> m_ApplicantDispStatusSubmittedCollection = new List<ApplicantDispStatusSubmitted>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantDispStatusSubmitted", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantDispStatusSubmitted> ApplicantDispStatusSubmittedCollection
        {
            get { return m_ApplicantDispStatusSubmittedCollection; }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicationId
        {
            set
            {
                if (m_ApplicationId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicationId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicationId = value;
                    OnPropertyChanged(PropertyNameApplicationId);
                }
            }
            get
            {
                return m_ApplicationId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionId
        {
            set
            {
                if (m_AcquisitionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionId = value;
                    OnPropertyChanged(PropertyNameAcquisitionId);
                }
            }
            get
            {
                return m_AcquisitionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NewICNo
        {
            set
            {
                if (String.Equals(m_NewICNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNewICNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NewICNo = value;
                    OnPropertyChanged(PropertyNameNewICNo);
                }
            }
            get
            {
                return m_NewICNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NoTentera
        {
            set
            {
                if (String.Equals(m_NoTentera, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNoTentera, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NoTentera = value;
                    OnPropertyChanged(PropertyNameNoTentera);
                }
            }
            get
            {
                return m_NoTentera;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string FullName
        {
            set
            {
                if (String.Equals(m_FullName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFullName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FullName = value;
                    OnPropertyChanged(PropertyNameFullName);
                }
            }
            get
            {
                return m_FullName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MrtlStatusCd
        {
            set
            {
                if (String.Equals(m_MrtlStatusCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMrtlStatusCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MrtlStatusCd = value;
                    OnPropertyChanged(PropertyNameMrtlStatusCd);
                }
            }
            get
            {
                return m_MrtlStatusCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GenderCd
        {
            set
            {
                if (String.Equals(m_GenderCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGenderCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GenderCd = value;
                    OnPropertyChanged(PropertyNameGenderCd);
                }
            }
            get
            {
                return m_GenderCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal Height
        {
            set
            {
                if (m_Height == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHeight, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Height = value;
                    OnPropertyChanged(PropertyNameHeight);
                }
            }
            get
            {
                return m_Height;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal Weight
        {
            set
            {
                if (m_Weight == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameWeight, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Weight = value;
                    OnPropertyChanged(PropertyNameWeight);
                }
            }
            get
            {
                return m_Weight;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal BMI
        {
            set
            {
                if (m_BMI == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBMI, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BMI = value;
                    OnPropertyChanged(PropertyNameBMI);
                }
            }
            get
            {
                return m_BMI;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NationalityCd
        {
            set
            {
                if (String.Equals(m_NationalityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNationalityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NationalityCd = value;
                    OnPropertyChanged(PropertyNameNationalityCd);
                }
            }
            get
            {
                return m_NationalityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NationalityCertNo
        {
            set
            {
                if (String.Equals(m_NationalityCertNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNationalityCertNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NationalityCertNo = value;
                    OnPropertyChanged(PropertyNameNationalityCertNo);
                }
            }
            get
            {
                return m_NationalityCertNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthCertNo
        {
            set
            {
                if (String.Equals(m_BirthCertNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthCertNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthCertNo = value;
                    OnPropertyChanged(PropertyNameBirthCertNo);
                }
            }
            get
            {
                return m_BirthCertNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ReligionCd
        {
            set
            {
                if (String.Equals(m_ReligionCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameReligionCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ReligionCd = value;
                    OnPropertyChanged(PropertyNameReligionCd);
                }
            }
            get
            {
                return m_ReligionCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string RaceCd
        {
            set
            {
                if (String.Equals(m_RaceCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameRaceCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_RaceCd = value;
                    OnPropertyChanged(PropertyNameRaceCd);
                }
            }
            get
            {
                return m_RaceCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string EthnicCd
        {
            set
            {
                if (String.Equals(m_EthnicCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEthnicCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EthnicCd = value;
                    OnPropertyChanged(PropertyNameEthnicCd);
                }
            }
            get
            {
                return m_EthnicCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthCountryCd
        {
            set
            {
                if (String.Equals(m_BirthCountryCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthCountryCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthCountryCd = value;
                    OnPropertyChanged(PropertyNameBirthCountryCd);
                }
            }
            get
            {
                return m_BirthCountryCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthStateCd
        {
            set
            {
                if (String.Equals(m_BirthStateCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthStateCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthStateCd = value;
                    OnPropertyChanged(PropertyNameBirthStateCd);
                }
            }
            get
            {
                return m_BirthStateCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthCityCd
        {
            set
            {
                if (String.Equals(m_BirthCityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthCityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthCityCd = value;
                    OnPropertyChanged(PropertyNameBirthCityCd);
                }
            }
            get
            {
                return m_BirthCityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BirthPlace
        {
            set
            {
                if (String.Equals(m_BirthPlace, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthPlace, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthPlace = value;
                    OnPropertyChanged(PropertyNameBirthPlace);
                }
            }
            get
            {
                return m_BirthPlace;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BloodTypeCd
        {
            set
            {
                if (String.Equals(m_BloodTypeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBloodTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BloodTypeCd = value;
                    OnPropertyChanged(PropertyNameBloodTypeCd);
                }
            }
            get
            {
                return m_BloodTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool SpectaclesUserInd
        {
            set
            {
                if (m_SpectaclesUserInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSpectaclesUserInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SpectaclesUserInd = value;
                    OnPropertyChanged(PropertyNameSpectaclesUserInd);
                }
            }
            get
            {
                return m_SpectaclesUserInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ColorBlindInd
        {
            set
            {
                if (m_ColorBlindInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameColorBlindInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ColorBlindInd = value;
                    OnPropertyChanged(PropertyNameColorBlindInd);
                }
            }
            get
            {
                return m_ColorBlindInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ResidenceTypeInd
        {
            set
            {
                if (String.Equals(m_ResidenceTypeInd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameResidenceTypeInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ResidenceTypeInd = value;
                    OnPropertyChanged(PropertyNameResidenceTypeInd);
                }
            }
            get
            {
                return m_ResidenceTypeInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddr1
        {
            set
            {
                if (String.Equals(m_CorresponAddr1, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddr1, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddr1 = value;
                    OnPropertyChanged(PropertyNameCorresponAddr1);
                }
            }
            get
            {
                return m_CorresponAddr1;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddr2
        {
            set
            {
                if (String.Equals(m_CorresponAddr2, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddr2, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddr2 = value;
                    OnPropertyChanged(PropertyNameCorresponAddr2);
                }
            }
            get
            {
                return m_CorresponAddr2;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddr3
        {
            set
            {
                if (String.Equals(m_CorresponAddr3, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddr3, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddr3 = value;
                    OnPropertyChanged(PropertyNameCorresponAddr3);
                }
            }
            get
            {
                return m_CorresponAddr3;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddrPostCd
        {
            set
            {
                if (String.Equals(m_CorresponAddrPostCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddrPostCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddrPostCd = value;
                    OnPropertyChanged(PropertyNameCorresponAddrPostCd);
                }
            }
            get
            {
                return m_CorresponAddrPostCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddrCityCd
        {
            set
            {
                if (String.Equals(m_CorresponAddrCityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddrCityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddrCityCd = value;
                    OnPropertyChanged(PropertyNameCorresponAddrCityCd);
                }
            }
            get
            {
                return m_CorresponAddrCityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddrStateCd
        {
            set
            {
                if (String.Equals(m_CorresponAddrStateCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddrStateCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddrStateCd = value;
                    OnPropertyChanged(PropertyNameCorresponAddrStateCd);
                }
            }
            get
            {
                return m_CorresponAddrStateCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CorresponAddrCountryCd
        {
            set
            {
                if (String.Equals(m_CorresponAddrCountryCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCorresponAddrCountryCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CorresponAddrCountryCd = value;
                    OnPropertyChanged(PropertyNameCorresponAddrCountryCd);
                }
            }
            get
            {
                return m_CorresponAddrCountryCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MobilePhoneNo
        {
            set
            {
                if (String.Equals(m_MobilePhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMobilePhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MobilePhoneNo = value;
                    OnPropertyChanged(PropertyNameMobilePhoneNo);
                }
            }
            get
            {
                return m_MobilePhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HomePhoneNo
        {
            set
            {
                if (String.Equals(m_HomePhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHomePhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HomePhoneNo = value;
                    OnPropertyChanged(PropertyNameHomePhoneNo);
                }
            }
            get
            {
                return m_HomePhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Email
        {
            set
            {
                if (String.Equals(m_Email, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEmail, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Email = value;
                    OnPropertyChanged(PropertyNameEmail);
                }
            }
            get
            {
                return m_Email;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ChildNo
        {
            set
            {
                if (m_ChildNo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameChildNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ChildNo = value;
                    OnPropertyChanged(PropertyNameChildNo);
                }
            }
            get
            {
                return m_ChildNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int NoOfSibling
        {
            set
            {
                if (m_NoOfSibling == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNoOfSibling, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NoOfSibling = value;
                    OnPropertyChanged(PropertyNameNoOfSibling);
                }
            }
            get
            {
                return m_NoOfSibling;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomName
        {
            set
            {
                if (String.Equals(m_MomName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomName = value;
                    OnPropertyChanged(PropertyNameMomName);
                }
            }
            get
            {
                return m_MomName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomICNo
        {
            set
            {
                if (String.Equals(m_MomICNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomICNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomICNo = value;
                    OnPropertyChanged(PropertyNameMomICNo);
                }
            }
            get
            {
                return m_MomICNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomPhoneNo
        {
            set
            {
                if (String.Equals(m_MomPhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomPhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomPhoneNo = value;
                    OnPropertyChanged(PropertyNameMomPhoneNo);
                }
            }
            get
            {
                return m_MomPhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomNationalityCd
        {
            set
            {
                if (String.Equals(m_MomNationalityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomNationalityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomNationalityCd = value;
                    OnPropertyChanged(PropertyNameMomNationalityCd);
                }
            }
            get
            {
                return m_MomNationalityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MomOccupation
        {
            set
            {
                if (String.Equals(m_MomOccupation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomOccupation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomOccupation = value;
                    OnPropertyChanged(PropertyNameMomOccupation);
                }
            }
            get
            {
                return m_MomOccupation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal MomSalary
        {
            set
            {
                if (m_MomSalary == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomSalary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomSalary = value;
                    OnPropertyChanged(PropertyNameMomSalary);
                }
            }
            get
            {
                return m_MomSalary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadName
        {
            set
            {
                if (String.Equals(m_DadName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadName = value;
                    OnPropertyChanged(PropertyNameDadName);
                }
            }
            get
            {
                return m_DadName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadICNo
        {
            set
            {
                if (String.Equals(m_DadICNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadICNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadICNo = value;
                    OnPropertyChanged(PropertyNameDadICNo);
                }
            }
            get
            {
                return m_DadICNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadPhoneNo
        {
            set
            {
                if (String.Equals(m_DadPhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadPhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadPhoneNo = value;
                    OnPropertyChanged(PropertyNameDadPhoneNo);
                }
            }
            get
            {
                return m_DadPhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadNationalityCd
        {
            set
            {
                if (String.Equals(m_DadNationalityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadNationalityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadNationalityCd = value;
                    OnPropertyChanged(PropertyNameDadNationalityCd);
                }
            }
            get
            {
                return m_DadNationalityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string DadOccupation
        {
            set
            {
                if (String.Equals(m_DadOccupation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadOccupation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadOccupation = value;
                    OnPropertyChanged(PropertyNameDadOccupation);
                }
            }
            get
            {
                return m_DadOccupation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal DadSalary
        {
            set
            {
                if (m_DadSalary == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadSalary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadSalary = value;
                    OnPropertyChanged(PropertyNameDadSalary);
                }
            }
            get
            {
                return m_DadSalary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianName
        {
            set
            {
                if (String.Equals(m_GuardianName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianName = value;
                    OnPropertyChanged(PropertyNameGuardianName);
                }
            }
            get
            {
                return m_GuardianName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianICNo
        {
            set
            {
                if (String.Equals(m_GuardianICNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianICNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianICNo = value;
                    OnPropertyChanged(PropertyNameGuardianICNo);
                }
            }
            get
            {
                return m_GuardianICNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianPhoneNo
        {
            set
            {
                if (String.Equals(m_GuardianPhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianPhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianPhoneNo = value;
                    OnPropertyChanged(PropertyNameGuardianPhoneNo);
                }
            }
            get
            {
                return m_GuardianPhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianNationalityCd
        {
            set
            {
                if (String.Equals(m_GuardianNationalityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianNationalityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianNationalityCd = value;
                    OnPropertyChanged(PropertyNameGuardianNationalityCd);
                }
            }
            get
            {
                return m_GuardianNationalityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GuardianOccupation
        {
            set
            {
                if (String.Equals(m_GuardianOccupation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianOccupation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianOccupation = value;
                    OnPropertyChanged(PropertyNameGuardianOccupation);
                }
            }
            get
            {
                return m_GuardianOccupation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal GuardianSalary
        {
            set
            {
                if (m_GuardianSalary == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianSalary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianSalary = value;
                    OnPropertyChanged(PropertyNameGuardianSalary);
                }
            }
            get
            {
                return m_GuardianSalary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string FamilyHighestEduLevel
        {
            set
            {
                if (String.Equals(m_FamilyHighestEduLevel, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFamilyHighestEduLevel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FamilyHighestEduLevel = value;
                    OnPropertyChanged(PropertyNameFamilyHighestEduLevel);
                }
            }
            get
            {
                return m_FamilyHighestEduLevel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CurrentOccupation
        {
            set
            {
                if (String.Equals(m_CurrentOccupation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCurrentOccupation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CurrentOccupation = value;
                    OnPropertyChanged(PropertyNameCurrentOccupation);
                }
            }
            get
            {
                return m_CurrentOccupation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CurrentOrganisation
        {
            set
            {
                if (String.Equals(m_CurrentOrganisation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCurrentOrganisation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CurrentOrganisation = value;
                    OnPropertyChanged(PropertyNameCurrentOrganisation);
                }
            }
            get
            {
                return m_CurrentOrganisation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal CurrentSalary
        {
            set
            {
                if (m_CurrentSalary == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCurrentSalary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CurrentSalary = value;
                    OnPropertyChanged(PropertyNameCurrentSalary);
                }
            }
            get
            {
                return m_CurrentSalary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int PalapesYear
        {
            set
            {
                if (m_PalapesYear == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesYear, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesYear = value;
                    OnPropertyChanged(PropertyNamePalapesYear);
                }
            }
            get
            {
                return m_PalapesYear;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PalapesServices
        {
            set
            {
                if (String.Equals(m_PalapesServices, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesServices, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesServices = value;
                    OnPropertyChanged(PropertyNamePalapesServices);
                }
            }
            get
            {
                return m_PalapesServices;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PalapesArmyNo
        {
            set
            {
                if (String.Equals(m_PalapesArmyNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesArmyNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesArmyNo = value;
                    OnPropertyChanged(PropertyNamePalapesArmyNo);
                }
            }
            get
            {
                return m_PalapesArmyNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PalapesInstitution
        {
            set
            {
                if (String.Equals(m_PalapesInstitution, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesInstitution, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesInstitution = value;
                    OnPropertyChanged(PropertyNamePalapesInstitution);
                }
            }
            get
            {
                return m_PalapesInstitution;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PalapesRemark
        {
            set
            {
                if (String.Equals(m_PalapesRemark, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesRemark, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesRemark = value;
                    OnPropertyChanged(PropertyNamePalapesRemark);
                }
            }
            get
            {
                return m_PalapesRemark;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ScholarshipBody
        {
            set
            {
                if (String.Equals(m_ScholarshipBody, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipBody, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipBody = value;
                    OnPropertyChanged(PropertyNameScholarshipBody);
                }
            }
            get
            {
                return m_ScholarshipBody;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ScholarshipBodyAddr
        {
            set
            {
                if (String.Equals(m_ScholarshipBodyAddr, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipBodyAddr, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipBodyAddr = value;
                    OnPropertyChanged(PropertyNameScholarshipBodyAddr);
                }
            }
            get
            {
                return m_ScholarshipBodyAddr;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ScholarshipNoOfYrContract
        {
            set
            {
                if (String.Equals(m_ScholarshipNoOfYrContract, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipNoOfYrContract, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipNoOfYrContract = value;
                    OnPropertyChanged(PropertyNameScholarshipNoOfYrContract);
                }
            }
            get
            {
                return m_ScholarshipNoOfYrContract;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ArmySelectionVenue
        {
            set
            {
                if (String.Equals(m_ArmySelectionVenue, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmySelectionVenue, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmySelectionVenue = value;
                    OnPropertyChanged(PropertyNameArmySelectionVenue);
                }
            }
            get
            {
                return m_ArmySelectionVenue;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ArmyServiceYrOfServ
        {
            set
            {
                if (String.Equals(m_ArmyServiceYrOfServ, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmyServiceYrOfServ, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmyServiceYrOfServ = value;
                    OnPropertyChanged(PropertyNameArmyServiceYrOfServ);
                }
            }
            get
            {
                return m_ArmyServiceYrOfServ;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ArmyServiceResignRemark
        {
            set
            {
                if (String.Equals(m_ArmyServiceResignRemark, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmyServiceResignRemark, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmyServiceResignRemark = value;
                    OnPropertyChanged(PropertyNameArmyServiceResignRemark);
                }
            }
            get
            {
                return m_ArmyServiceResignRemark;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SelectionTD
        {
            set
            {
                if (m_SelectionTD == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSelectionTD, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SelectionTD = value;
                    OnPropertyChanged(PropertyNameSelectionTD);
                }
            }
            get
            {
                return m_SelectionTD;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SelectionTL
        {
            set
            {
                if (m_SelectionTL == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSelectionTL, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SelectionTL = value;
                    OnPropertyChanged(PropertyNameSelectionTL);
                }
            }
            get
            {
                return m_SelectionTL;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SelectionTU
        {
            set
            {
                if (m_SelectionTU == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSelectionTU, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SelectionTU = value;
                    OnPropertyChanged(PropertyNameSelectionTU);
                }
            }
            get
            {
                return m_SelectionTU;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerMSWord
        {
            set
            {
                if (m_ComputerMSWord == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerMSWord, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerMSWord = value;
                    OnPropertyChanged(PropertyNameComputerMSWord);
                }
            }
            get
            {
                return m_ComputerMSWord;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerMSExcel
        {
            set
            {
                if (m_ComputerMSExcel == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerMSExcel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerMSExcel = value;
                    OnPropertyChanged(PropertyNameComputerMSExcel);
                }
            }
            get
            {
                return m_ComputerMSExcel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerMSPwrPoint
        {
            set
            {
                if (m_ComputerMSPwrPoint == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerMSPwrPoint, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerMSPwrPoint = value;
                    OnPropertyChanged(PropertyNameComputerMSPwrPoint);
                }
            }
            get
            {
                return m_ComputerMSPwrPoint;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ComputerICT
        {
            set
            {
                if (m_ComputerICT == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerICT, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerICT = value;
                    OnPropertyChanged(PropertyNameComputerICT);
                }
            }
            get
            {
                return m_ComputerICT;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ComputerOthers
        {
            set
            {
                if (String.Equals(m_ComputerOthers, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameComputerOthers, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ComputerOthers = value;
                    OnPropertyChanged(PropertyNameComputerOthers);
                }
            }
            get
            {
                return m_ComputerOthers;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PelepasanDocument
        {
            set
            {
                if (String.Equals(m_PelepasanDocument, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePelepasanDocument, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PelepasanDocument = value;
                    OnPropertyChanged(PropertyNamePelepasanDocument);
                }
            }
            get
            {
                return m_PelepasanDocument;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string OriginalPelepasanDocument
        {
            set
            {
                if (String.Equals(m_OriginalPelepasanDocument, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOriginalPelepasanDocument, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OriginalPelepasanDocument = value;
                    OnPropertyChanged(PropertyNameOriginalPelepasanDocument);
                }
            }
            get
            {
                return m_OriginalPelepasanDocument;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? BirthDt
        {
            set
            {
                if (m_BirthDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBirthDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BirthDt = value;
                    OnPropertyChanged(PropertyNameBirthDt);
                }
            }
            get { return m_BirthDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? Age
        {
            set
            {
                if (m_Age == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAge, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Age = value;
                    OnPropertyChanged(PropertyNameAge);
                }
            }
            get { return m_Age; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? PalapesTauliahEndDt
        {
            set
            {
                if (m_PalapesTauliahEndDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesTauliahEndDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesTauliahEndDt = value;
                    OnPropertyChanged(PropertyNamePalapesTauliahEndDt);
                }
            }
            get { return m_PalapesTauliahEndDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? ScholarshipContractStDate
        {
            set
            {
                if (m_ScholarshipContractStDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipContractStDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipContractStDate = value;
                    OnPropertyChanged(PropertyNameScholarshipContractStDate);
                }
            }
            get { return m_ScholarshipContractStDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? ArmySelectionDt
        {
            set
            {
                if (m_ArmySelectionDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmySelectionDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmySelectionDt = value;
                    OnPropertyChanged(PropertyNameArmySelectionDt);
                }
            }
            get { return m_ArmySelectionDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? ArmyServiceInd
        {
            set
            {
                if (m_ArmyServiceInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmyServiceInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmyServiceInd = value;
                    OnPropertyChanged(PropertyNameArmyServiceInd);
                }
            }
            get { return m_ArmyServiceInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? PalapesInd
        {
            set
            {
                if (m_PalapesInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePalapesInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PalapesInd = value;
                    OnPropertyChanged(PropertyNamePalapesInd);
                }
            }
            get { return m_PalapesInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? ScholarshipInd
        {
            set
            {
                if (m_ScholarshipInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScholarshipInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScholarshipInd = value;
                    OnPropertyChanged(PropertyNameScholarshipInd);
                }
            }
            get { return m_ScholarshipInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? ArmySelectionInd
        {
            set
            {
                if (m_ArmySelectionInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmySelectionInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmySelectionInd = value;
                    OnPropertyChanged(PropertyNameArmySelectionInd);
                }
            }
            get { return m_ArmySelectionInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? EmployeeAggreeInd
        {
            set
            {
                if (m_EmployeeAggreeInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEmployeeAggreeInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EmployeeAggreeInd = value;
                    OnPropertyChanged(PropertyNameEmployeeAggreeInd);
                }
            }
            get { return m_EmployeeAggreeInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? CrimeInvolvement
        {
            set
            {
                if (m_CrimeInvolvement == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCrimeInvolvement, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CrimeInvolvement = value;
                    OnPropertyChanged(PropertyNameCrimeInvolvement);
                }
            }
            get { return m_CrimeInvolvement; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? DrugCaseInvolvement
        {
            set
            {
                if (m_DrugCaseInvolvement == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDrugCaseInvolvement, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DrugCaseInvolvement = value;
                    OnPropertyChanged(PropertyNameDrugCaseInvolvement);
                }
            }
            get { return m_DrugCaseInvolvement; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? CronicIlnessInd
        {
            set
            {
                if (m_CronicIlnessInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCronicIlnessInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CronicIlnessInd = value;
                    OnPropertyChanged(PropertyNameCronicIlnessInd);
                }
            }
            get { return m_CronicIlnessInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? MomNotApplicable
        {
            set
            {
                if (m_MomNotApplicable == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMomNotApplicable, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MomNotApplicable = value;
                    OnPropertyChanged(PropertyNameMomNotApplicable);
                }
            }
            get { return m_MomNotApplicable; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? DadNotApplicable
        {
            set
            {
                if (m_DadNotApplicable == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDadNotApplicable, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DadNotApplicable = value;
                    OnPropertyChanged(PropertyNameDadNotApplicable);
                }
            }
            get { return m_DadNotApplicable; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? GuardianNotApplicable
        {
            set
            {
                if (m_GuardianNotApplicable == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGuardianNotApplicable, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GuardianNotApplicable = value;
                    OnPropertyChanged(PropertyNameGuardianNotApplicable);
                }
            }
            get { return m_GuardianNotApplicable; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantEducation", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantEducation
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantEduId;
        public const string PropertyNameApplicantEduId = "ApplicantEduId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighEduLevelCd;
        public const string PropertyNameHighEduLevelCd = "HighEduLevelCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighEduLevel;
        public const string PropertyNameHighEduLevel = "HighEduLevel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_EduCertTitle;
        public const string PropertyNameEduCertTitle = "EduCertTitle";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_OverallGrade;
        public const string PropertyNameOverallGrade = "OverallGrade";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SKMLevel;
        public const string PropertyNameSKMLevel = "SKMLevel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ConfermentYr;
        public const string PropertyNameConfermentYr = "ConfermentYr";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstCd;
        public const string PropertyNameInstCd = "InstCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstitutionName;
        public const string PropertyNameInstitutionName = "InstitutionName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_OverSeaInd;
        public const string PropertyNameOverSeaInd = "OverSeaInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MajorMinorCd;
        public const string PropertyNameMajorMinorCd = "MajorMinorCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantEduSubject> m_ApplicantEduSubjectCollection = new List<ApplicantEduSubject>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantEduSubject", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantEduSubject> ApplicantEduSubjectCollection
        {
            get { return m_ApplicantEduSubjectCollection; }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantEduId
        {
            set
            {
                if (m_ApplicantEduId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantEduId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantEduId = value;
                    OnPropertyChanged(PropertyNameApplicantEduId);
                }
            }
            get
            {
                return m_ApplicantEduId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HighEduLevelCd
        {
            set
            {
                if (String.Equals(m_HighEduLevelCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighEduLevelCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighEduLevelCd = value;
                    OnPropertyChanged(PropertyNameHighEduLevelCd);
                }
            }
            get
            {
                return m_HighEduLevelCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HighEduLevel
        {
            set
            {
                if (String.Equals(m_HighEduLevel, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighEduLevel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighEduLevel = value;
                    OnPropertyChanged(PropertyNameHighEduLevel);
                }
            }
            get
            {
                return m_HighEduLevel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string EduCertTitle
        {
            set
            {
                if (String.Equals(m_EduCertTitle, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEduCertTitle, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EduCertTitle = value;
                    OnPropertyChanged(PropertyNameEduCertTitle);
                }
            }
            get
            {
                return m_EduCertTitle;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string OverallGrade
        {
            set
            {
                if (String.Equals(m_OverallGrade, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOverallGrade, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OverallGrade = value;
                    OnPropertyChanged(PropertyNameOverallGrade);
                }
            }
            get
            {
                return m_OverallGrade;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SKMLevel
        {
            set
            {
                if (m_SKMLevel == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSKMLevel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SKMLevel = value;
                    OnPropertyChanged(PropertyNameSKMLevel);
                }
            }
            get
            {
                return m_SKMLevel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ConfermentYr
        {
            set
            {
                if (m_ConfermentYr == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameConfermentYr, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ConfermentYr = value;
                    OnPropertyChanged(PropertyNameConfermentYr);
                }
            }
            get
            {
                return m_ConfermentYr;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstCd
        {
            set
            {
                if (String.Equals(m_InstCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstCd = value;
                    OnPropertyChanged(PropertyNameInstCd);
                }
            }
            get
            {
                return m_InstCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstitutionName
        {
            set
            {
                if (String.Equals(m_InstitutionName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstitutionName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstitutionName = value;
                    OnPropertyChanged(PropertyNameInstitutionName);
                }
            }
            get
            {
                return m_InstitutionName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool OverSeaInd
        {
            set
            {
                if (m_OverSeaInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOverSeaInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OverSeaInd = value;
                    OnPropertyChanged(PropertyNameOverSeaInd);
                }
            }
            get
            {
                return m_OverSeaInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MajorMinorCd
        {
            set
            {
                if (String.Equals(m_MajorMinorCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMajorMinorCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MajorMinorCd = value;
                    OnPropertyChanged(PropertyNameMajorMinorCd);
                }
            }
            get
            {
                return m_MajorMinorCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantEducationSubmitted", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantEducationSubmitted
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantEduId;
        public const string PropertyNameApplicantEduId = "ApplicantEduId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighEduLevelCd;
        public const string PropertyNameHighEduLevelCd = "HighEduLevelCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighEduLevel;
        public const string PropertyNameHighEduLevel = "HighEduLevel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_EduCertTitle;
        public const string PropertyNameEduCertTitle = "EduCertTitle";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_OverallGrade;
        public const string PropertyNameOverallGrade = "OverallGrade";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SKMLevel;
        public const string PropertyNameSKMLevel = "SKMLevel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ConfermentYr;
        public const string PropertyNameConfermentYr = "ConfermentYr";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstCd;
        public const string PropertyNameInstCd = "InstCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstitutionName;
        public const string PropertyNameInstitutionName = "InstitutionName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_OverSeaInd;
        public const string PropertyNameOverSeaInd = "OverSeaInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MajorMinorCd;
        public const string PropertyNameMajorMinorCd = "MajorMinorCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ApplicantEduSubjectSubmitted> m_ApplicantEduSubjectSubmittedCollection = new List<ApplicantEduSubjectSubmitted>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("ApplicantEduSubjectSubmitted", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<ApplicantEduSubjectSubmitted> ApplicantEduSubjectSubmittedCollection
        {
            get { return m_ApplicantEduSubjectSubmittedCollection; }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantEduId
        {
            set
            {
                if (m_ApplicantEduId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantEduId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantEduId = value;
                    OnPropertyChanged(PropertyNameApplicantEduId);
                }
            }
            get
            {
                return m_ApplicantEduId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HighEduLevelCd
        {
            set
            {
                if (String.Equals(m_HighEduLevelCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighEduLevelCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighEduLevelCd = value;
                    OnPropertyChanged(PropertyNameHighEduLevelCd);
                }
            }
            get
            {
                return m_HighEduLevelCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HighEduLevel
        {
            set
            {
                if (String.Equals(m_HighEduLevel, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighEduLevel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighEduLevel = value;
                    OnPropertyChanged(PropertyNameHighEduLevel);
                }
            }
            get
            {
                return m_HighEduLevel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string EduCertTitle
        {
            set
            {
                if (String.Equals(m_EduCertTitle, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEduCertTitle, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EduCertTitle = value;
                    OnPropertyChanged(PropertyNameEduCertTitle);
                }
            }
            get
            {
                return m_EduCertTitle;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string OverallGrade
        {
            set
            {
                if (String.Equals(m_OverallGrade, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOverallGrade, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OverallGrade = value;
                    OnPropertyChanged(PropertyNameOverallGrade);
                }
            }
            get
            {
                return m_OverallGrade;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SKMLevel
        {
            set
            {
                if (m_SKMLevel == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSKMLevel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SKMLevel = value;
                    OnPropertyChanged(PropertyNameSKMLevel);
                }
            }
            get
            {
                return m_SKMLevel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ConfermentYr
        {
            set
            {
                if (m_ConfermentYr == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameConfermentYr, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ConfermentYr = value;
                    OnPropertyChanged(PropertyNameConfermentYr);
                }
            }
            get
            {
                return m_ConfermentYr;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstCd
        {
            set
            {
                if (String.Equals(m_InstCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstCd = value;
                    OnPropertyChanged(PropertyNameInstCd);
                }
            }
            get
            {
                return m_InstCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstitutionName
        {
            set
            {
                if (String.Equals(m_InstitutionName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstitutionName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstitutionName = value;
                    OnPropertyChanged(PropertyNameInstitutionName);
                }
            }
            get
            {
                return m_InstitutionName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool OverSeaInd
        {
            set
            {
                if (m_OverSeaInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOverSeaInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OverSeaInd = value;
                    OnPropertyChanged(PropertyNameOverSeaInd);
                }
            }
            get
            {
                return m_OverSeaInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MajorMinorCd
        {
            set
            {
                if (String.Equals(m_MajorMinorCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMajorMinorCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MajorMinorCd = value;
                    OnPropertyChanged(PropertyNameMajorMinorCd);
                }
            }
            get
            {
                return m_MajorMinorCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantEduSubject", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantEduSubject
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_EduSubjectId;
        public const string PropertyNameEduSubjectId = "EduSubjectId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantEduId;
        public const string PropertyNameApplicantEduId = "ApplicantEduId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SubjectCd;
        public const string PropertyNameSubjectCd = "SubjectCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Subject;
        public const string PropertyNameSubject = "Subject";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GradeCd;
        public const string PropertyNameGradeCd = "GradeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Grade;
        public const string PropertyNameGrade = "Grade";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int EduSubjectId
        {
            set
            {
                if (m_EduSubjectId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEduSubjectId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EduSubjectId = value;
                    OnPropertyChanged(PropertyNameEduSubjectId);
                }
            }
            get
            {
                return m_EduSubjectId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantEduId
        {
            set
            {
                if (m_ApplicantEduId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantEduId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantEduId = value;
                    OnPropertyChanged(PropertyNameApplicantEduId);
                }
            }
            get
            {
                return m_ApplicantEduId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SubjectCd
        {
            set
            {
                if (String.Equals(m_SubjectCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSubjectCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SubjectCd = value;
                    OnPropertyChanged(PropertyNameSubjectCd);
                }
            }
            get
            {
                return m_SubjectCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Subject
        {
            set
            {
                if (String.Equals(m_Subject, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSubject, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Subject = value;
                    OnPropertyChanged(PropertyNameSubject);
                }
            }
            get
            {
                return m_Subject;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GradeCd
        {
            set
            {
                if (String.Equals(m_GradeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGradeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GradeCd = value;
                    OnPropertyChanged(PropertyNameGradeCd);
                }
            }
            get
            {
                return m_GradeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Grade
        {
            set
            {
                if (String.Equals(m_Grade, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGrade, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Grade = value;
                    OnPropertyChanged(PropertyNameGrade);
                }
            }
            get
            {
                return m_Grade;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantEduSubjectSubmitted", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantEduSubjectSubmitted
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_EduSubjectId;
        public const string PropertyNameEduSubjectId = "EduSubjectId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantEduId;
        public const string PropertyNameApplicantEduId = "ApplicantEduId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SubjectCd;
        public const string PropertyNameSubjectCd = "SubjectCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Subject;
        public const string PropertyNameSubject = "Subject";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GradeCd;
        public const string PropertyNameGradeCd = "GradeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Grade;
        public const string PropertyNameGrade = "Grade";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int EduSubjectId
        {
            set
            {
                if (m_EduSubjectId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEduSubjectId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EduSubjectId = value;
                    OnPropertyChanged(PropertyNameEduSubjectId);
                }
            }
            get
            {
                return m_EduSubjectId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantEduId
        {
            set
            {
                if (m_ApplicantEduId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantEduId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantEduId = value;
                    OnPropertyChanged(PropertyNameApplicantEduId);
                }
            }
            get
            {
                return m_ApplicantEduId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SubjectCd
        {
            set
            {
                if (String.Equals(m_SubjectCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSubjectCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SubjectCd = value;
                    OnPropertyChanged(PropertyNameSubjectCd);
                }
            }
            get
            {
                return m_SubjectCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Subject
        {
            set
            {
                if (String.Equals(m_Subject, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSubject, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Subject = value;
                    OnPropertyChanged(PropertyNameSubject);
                }
            }
            get
            {
                return m_Subject;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GradeCd
        {
            set
            {
                if (String.Equals(m_GradeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGradeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GradeCd = value;
                    OnPropertyChanged(PropertyNameGradeCd);
                }
            }
            get
            {
                return m_GradeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Grade
        {
            set
            {
                if (String.Equals(m_Grade, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGrade, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Grade = value;
                    OnPropertyChanged(PropertyNameGrade);
                }
            }
            get
            {
                return m_Grade;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcqEduCriteriaFieldOfStudy", Namespace = Strings.DefaultNamespace)]
    public partial class AcqEduCriteriaFieldOfStudy
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcqEduCriFOS;
        public const string PropertyNameAcqEduCriFOS = "AcqEduCriFOS";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MajorMinorCd;
        public const string PropertyNameMajorMinorCd = "MajorMinorCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcqEduCriFOS
        {
            set
            {
                if (m_AcqEduCriFOS == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcqEduCriFOS, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcqEduCriFOS = value;
                    OnPropertyChanged(PropertyNameAcqEduCriFOS);
                }
            }
            get
            {
                return m_AcqEduCriFOS;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MajorMinorCd
        {
            set
            {
                if (String.Equals(m_MajorMinorCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMajorMinorCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MajorMinorCd = value;
                    OnPropertyChanged(PropertyNameMajorMinorCd);
                }
            }
            get
            {
                return m_MajorMinorCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantSkill", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantSkill
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantSkillId;
        public const string PropertyNameApplicantSkillId = "ApplicantSkillId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Skill;
        public const string PropertyNameSkill = "Skill";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillCd;
        public const string PropertyNameSkillCd = "SkillCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillCatCd;
        public const string PropertyNameSkillCatCd = "SkillCatCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_LanguageSkillSpeak;
        public const string PropertyNameLanguageSkillSpeak = "LanguageSkillSpeak";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_LanguageSkillWrite;
        public const string PropertyNameLanguageSkillWrite = "LanguageSkillWrite";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AchievementCd;
        public const string PropertyNameAchievementCd = "AchievementCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Others;
        public const string PropertyNameOthers = "Others";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantSkillId
        {
            set
            {
                if (m_ApplicantSkillId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantSkillId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantSkillId = value;
                    OnPropertyChanged(PropertyNameApplicantSkillId);
                }
            }
            get
            {
                return m_ApplicantSkillId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Skill
        {
            set
            {
                if (String.Equals(m_Skill, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkill, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Skill = value;
                    OnPropertyChanged(PropertyNameSkill);
                }
            }
            get
            {
                return m_Skill;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillCd
        {
            set
            {
                if (String.Equals(m_SkillCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillCd = value;
                    OnPropertyChanged(PropertyNameSkillCd);
                }
            }
            get
            {
                return m_SkillCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillCatCd
        {
            set
            {
                if (String.Equals(m_SkillCatCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillCatCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillCatCd = value;
                    OnPropertyChanged(PropertyNameSkillCatCd);
                }
            }
            get
            {
                return m_SkillCatCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool LanguageSkillSpeak
        {
            set
            {
                if (m_LanguageSkillSpeak == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLanguageSkillSpeak, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LanguageSkillSpeak = value;
                    OnPropertyChanged(PropertyNameLanguageSkillSpeak);
                }
            }
            get
            {
                return m_LanguageSkillSpeak;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool LanguageSkillWrite
        {
            set
            {
                if (m_LanguageSkillWrite == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLanguageSkillWrite, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LanguageSkillWrite = value;
                    OnPropertyChanged(PropertyNameLanguageSkillWrite);
                }
            }
            get
            {
                return m_LanguageSkillWrite;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AchievementCd
        {
            set
            {
                if (String.Equals(m_AchievementCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAchievementCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AchievementCd = value;
                    OnPropertyChanged(PropertyNameAchievementCd);
                }
            }
            get
            {
                return m_AchievementCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Others
        {
            set
            {
                if (String.Equals(m_Others, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOthers, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Others = value;
                    OnPropertyChanged(PropertyNameOthers);
                }
            }
            get
            {
                return m_Others;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantSkillSubmitted", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantSkillSubmitted
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantSkillId;
        public const string PropertyNameApplicantSkillId = "ApplicantSkillId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Skill;
        public const string PropertyNameSkill = "Skill";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillCd;
        public const string PropertyNameSkillCd = "SkillCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillCatCd;
        public const string PropertyNameSkillCatCd = "SkillCatCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_LanguageSkillSpeak;
        public const string PropertyNameLanguageSkillSpeak = "LanguageSkillSpeak";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_LanguageSkillWrite;
        public const string PropertyNameLanguageSkillWrite = "LanguageSkillWrite";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AchievementCd;
        public const string PropertyNameAchievementCd = "AchievementCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Others;
        public const string PropertyNameOthers = "Others";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantSkillId
        {
            set
            {
                if (m_ApplicantSkillId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantSkillId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantSkillId = value;
                    OnPropertyChanged(PropertyNameApplicantSkillId);
                }
            }
            get
            {
                return m_ApplicantSkillId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Skill
        {
            set
            {
                if (String.Equals(m_Skill, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkill, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Skill = value;
                    OnPropertyChanged(PropertyNameSkill);
                }
            }
            get
            {
                return m_Skill;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillCd
        {
            set
            {
                if (String.Equals(m_SkillCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillCd = value;
                    OnPropertyChanged(PropertyNameSkillCd);
                }
            }
            get
            {
                return m_SkillCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillCatCd
        {
            set
            {
                if (String.Equals(m_SkillCatCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillCatCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillCatCd = value;
                    OnPropertyChanged(PropertyNameSkillCatCd);
                }
            }
            get
            {
                return m_SkillCatCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool LanguageSkillSpeak
        {
            set
            {
                if (m_LanguageSkillSpeak == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLanguageSkillSpeak, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LanguageSkillSpeak = value;
                    OnPropertyChanged(PropertyNameLanguageSkillSpeak);
                }
            }
            get
            {
                return m_LanguageSkillSpeak;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool LanguageSkillWrite
        {
            set
            {
                if (m_LanguageSkillWrite == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLanguageSkillWrite, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LanguageSkillWrite = value;
                    OnPropertyChanged(PropertyNameLanguageSkillWrite);
                }
            }
            get
            {
                return m_LanguageSkillWrite;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AchievementCd
        {
            set
            {
                if (String.Equals(m_AchievementCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAchievementCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AchievementCd = value;
                    OnPropertyChanged(PropertyNameAchievementCd);
                }
            }
            get
            {
                return m_AchievementCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Others
        {
            set
            {
                if (String.Equals(m_Others, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOthers, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Others = value;
                    OnPropertyChanged(PropertyNameOthers);
                }
            }
            get
            {
                return m_Others;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantSport", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantSport
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantSportAssocId;
        public const string PropertyNameApplicantSportAssocId = "ApplicantSportAssocId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Year;
        public const string PropertyNameYear = "Year";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AchievementCd;
        public const string PropertyNameAchievementCd = "AchievementCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Others;
        public const string PropertyNameOthers = "Others";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private int? m_SportAssocId;
        public const string PropertyNameSportAssocId = "SportAssocId";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantSportAssocId
        {
            set
            {
                if (m_ApplicantSportAssocId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantSportAssocId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantSportAssocId = value;
                    OnPropertyChanged(PropertyNameApplicantSportAssocId);
                }
            }
            get
            {
                return m_ApplicantSportAssocId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Year
        {
            set
            {
                if (m_Year == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameYear, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Year = value;
                    OnPropertyChanged(PropertyNameYear);
                }
            }
            get
            {
                return m_Year;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AchievementCd
        {
            set
            {
                if (String.Equals(m_AchievementCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAchievementCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AchievementCd = value;
                    OnPropertyChanged(PropertyNameAchievementCd);
                }
            }
            get
            {
                return m_AchievementCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Others
        {
            set
            {
                if (String.Equals(m_Others, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOthers, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Others = value;
                    OnPropertyChanged(PropertyNameOthers);
                }
            }
            get
            {
                return m_Others;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual int? SportAssocId
        {
            set
            {
                if (m_SportAssocId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSportAssocId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SportAssocId = value;
                    OnPropertyChanged(PropertyNameSportAssocId);
                }
            }
            get { return m_SportAssocId; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantSportSubmitted", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantSportSubmitted
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantSportAssocId;
        public const string PropertyNameApplicantSportAssocId = "ApplicantSportAssocId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SportAssocId;
        public const string PropertyNameSportAssocId = "SportAssocId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Year;
        public const string PropertyNameYear = "Year";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AchievementCd;
        public const string PropertyNameAchievementCd = "AchievementCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Others;
        public const string PropertyNameOthers = "Others";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantSportAssocId
        {
            set
            {
                if (m_ApplicantSportAssocId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantSportAssocId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantSportAssocId = value;
                    OnPropertyChanged(PropertyNameApplicantSportAssocId);
                }
            }
            get
            {
                return m_ApplicantSportAssocId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SportAssocId
        {
            set
            {
                if (m_SportAssocId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSportAssocId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SportAssocId = value;
                    OnPropertyChanged(PropertyNameSportAssocId);
                }
            }
            get
            {
                return m_SportAssocId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Year
        {
            set
            {
                if (m_Year == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameYear, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Year = value;
                    OnPropertyChanged(PropertyNameYear);
                }
            }
            get
            {
                return m_Year;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AchievementCd
        {
            set
            {
                if (String.Equals(m_AchievementCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAchievementCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AchievementCd = value;
                    OnPropertyChanged(PropertyNameAchievementCd);
                }
            }
            get
            {
                return m_AchievementCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Others
        {
            set
            {
                if (String.Equals(m_Others, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOthers, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Others = value;
                    OnPropertyChanged(PropertyNameOthers);
                }
            }
            get
            {
                return m_Others;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantDispStatus", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantDispStatus
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantDispStatusId;
        public const string PropertyNameApplicantDispStatusId = "ApplicantDispStatusId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Disciplinary;
        public const string PropertyNameDisciplinary = "Disciplinary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantDispStatusId
        {
            set
            {
                if (m_ApplicantDispStatusId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantDispStatusId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantDispStatusId = value;
                    OnPropertyChanged(PropertyNameApplicantDispStatusId);
                }
            }
            get
            {
                return m_ApplicantDispStatusId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Disciplinary
        {
            set
            {
                if (String.Equals(m_Disciplinary, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDisciplinary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Disciplinary = value;
                    OnPropertyChanged(PropertyNameDisciplinary);
                }
            }
            get
            {
                return m_Disciplinary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantDispStatusSubmitted", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantDispStatusSubmitted
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantDispStatusId;
        public const string PropertyNameApplicantDispStatusId = "ApplicantDispStatusId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Disciplinary;
        public const string PropertyNameDisciplinary = "Disciplinary";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantDispStatusId
        {
            set
            {
                if (m_ApplicantDispStatusId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantDispStatusId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantDispStatusId = value;
                    OnPropertyChanged(PropertyNameApplicantDispStatusId);
                }
            }
            get
            {
                return m_ApplicantDispStatusId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Disciplinary
        {
            set
            {
                if (String.Equals(m_Disciplinary, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDisciplinary, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Disciplinary = value;
                    OnPropertyChanged(PropertyNameDisciplinary);
                }
            }
            get
            {
                return m_Disciplinary;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Application", Namespace = Strings.DefaultNamespace)]
    public partial class Application
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AppId;
        public const string PropertyNameAppId = "AppId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SelectionCenterId;
        public const string PropertyNameSelectionCenterId = "SelectionCenterId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_FirstSelectionInd;
        public const string PropertyNameFirstSelectionInd = "FirstSelectionInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_FinalSelectionInd;
        public const string PropertyNameFinalSelectionInd = "FinalSelectionInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private bool? m_ApplicationStatus;
        public const string PropertyNameApplicationStatus = "ApplicationStatus";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AppId
        {
            set
            {
                if (m_AppId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAppId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AppId = value;
                    OnPropertyChanged(PropertyNameAppId);
                }
            }
            get
            {
                return m_AppId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionId
        {
            set
            {
                if (m_AcquisitionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionId = value;
                    OnPropertyChanged(PropertyNameAcquisitionId);
                }
            }
            get
            {
                return m_AcquisitionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SelectionCenterId
        {
            set
            {
                if (m_SelectionCenterId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSelectionCenterId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SelectionCenterId = value;
                    OnPropertyChanged(PropertyNameSelectionCenterId);
                }
            }
            get
            {
                return m_SelectionCenterId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? FirstSelectionInd
        {
            set
            {
                if (m_FirstSelectionInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFirstSelectionInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FirstSelectionInd = value;
                    OnPropertyChanged(PropertyNameFirstSelectionInd);
                }
            }
            get { return m_FirstSelectionInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? FinalSelectionInd
        {
            set
            {
                if (m_FinalSelectionInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFinalSelectionInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FinalSelectionInd = value;
                    OnPropertyChanged(PropertyNameFinalSelectionInd);
                }
            }
            get { return m_FinalSelectionInd; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual bool? ApplicationStatus
        {
            set
            {
                if (m_ApplicationStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicationStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicationStatus = value;
                    OnPropertyChanged(PropertyNameApplicationStatus);
                }
            }
            get { return m_ApplicationStatus; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcqQuestionnaire", Namespace = Strings.DefaultNamespace)]
    public partial class AcqQuestionnaire
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_QuestionnaireId;
        public const string PropertyNameQuestionnaireId = "QuestionnaireId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_QuestionnaireTypeCd;
        public const string PropertyNameQuestionnaireTypeCd = "QuestionnaireTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Weightage;
        public const string PropertyNameWeightage = "Weightage";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PersonalityTypeCd;
        public const string PropertyNamePersonalityTypeCd = "PersonalityTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_PersonalityAcceptedMarkFrom;
        public const string PropertyNamePersonalityAcceptedMarkFrom = "PersonalityAcceptedMarkFrom";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_PersonalityAcceptedMarkTo;
        public const string PropertyNamePersonalityAcceptedMarkTo = "PersonalityAcceptedMarkTo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int QuestionnaireId
        {
            set
            {
                if (m_QuestionnaireId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameQuestionnaireId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_QuestionnaireId = value;
                    OnPropertyChanged(PropertyNameQuestionnaireId);
                }
            }
            get
            {
                return m_QuestionnaireId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionId
        {
            set
            {
                if (m_AcquisitionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionId = value;
                    OnPropertyChanged(PropertyNameAcquisitionId);
                }
            }
            get
            {
                return m_AcquisitionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string QuestionnaireTypeCd
        {
            set
            {
                if (String.Equals(m_QuestionnaireTypeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameQuestionnaireTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_QuestionnaireTypeCd = value;
                    OnPropertyChanged(PropertyNameQuestionnaireTypeCd);
                }
            }
            get
            {
                return m_QuestionnaireTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Weightage
        {
            set
            {
                if (m_Weightage == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameWeightage, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Weightage = value;
                    OnPropertyChanged(PropertyNameWeightage);
                }
            }
            get
            {
                return m_Weightage;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PersonalityTypeCd
        {
            set
            {
                if (String.Equals(m_PersonalityTypeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePersonalityTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PersonalityTypeCd = value;
                    OnPropertyChanged(PropertyNamePersonalityTypeCd);
                }
            }
            get
            {
                return m_PersonalityTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int PersonalityAcceptedMarkFrom
        {
            set
            {
                if (m_PersonalityAcceptedMarkFrom == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePersonalityAcceptedMarkFrom, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PersonalityAcceptedMarkFrom = value;
                    OnPropertyChanged(PropertyNamePersonalityAcceptedMarkFrom);
                }
            }
            get
            {
                return m_PersonalityAcceptedMarkFrom;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int PersonalityAcceptedMarkTo
        {
            set
            {
                if (m_PersonalityAcceptedMarkTo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePersonalityAcceptedMarkTo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PersonalityAcceptedMarkTo = value;
                    OnPropertyChanged(PropertyNamePersonalityAcceptedMarkTo);
                }
            }
            get
            {
                return m_PersonalityAcceptedMarkTo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcqQuestion", Namespace = Strings.DefaultNamespace)]
    public partial class AcqQuestion
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcqQuestionId;
        public const string PropertyNameAcqQuestionId = "AcqQuestionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_QuestionnaireId;
        public const string PropertyNameQuestionnaireId = "QuestionnaireId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Statement;
        public const string PropertyNameStatement = "Statement";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SequenceNo;
        public const string PropertyNameSequenceNo = "SequenceNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_PersonalityYesMark;
        public const string PropertyNamePersonalityYesMark = "PersonalityYesMark";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_PersonalityNoMark;
        public const string PropertyNamePersonalityNoMark = "PersonalityNoMark";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcqQuestionId
        {
            set
            {
                if (m_AcqQuestionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcqQuestionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcqQuestionId = value;
                    OnPropertyChanged(PropertyNameAcqQuestionId);
                }
            }
            get
            {
                return m_AcqQuestionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int QuestionnaireId
        {
            set
            {
                if (m_QuestionnaireId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameQuestionnaireId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_QuestionnaireId = value;
                    OnPropertyChanged(PropertyNameQuestionnaireId);
                }
            }
            get
            {
                return m_QuestionnaireId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Statement
        {
            set
            {
                if (String.Equals(m_Statement, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStatement, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Statement = value;
                    OnPropertyChanged(PropertyNameStatement);
                }
            }
            get
            {
                return m_Statement;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SequenceNo
        {
            set
            {
                if (m_SequenceNo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSequenceNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SequenceNo = value;
                    OnPropertyChanged(PropertyNameSequenceNo);
                }
            }
            get
            {
                return m_SequenceNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int PersonalityYesMark
        {
            set
            {
                if (m_PersonalityYesMark == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePersonalityYesMark, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PersonalityYesMark = value;
                    OnPropertyChanged(PropertyNamePersonalityYesMark);
                }
            }
            get
            {
                return m_PersonalityYesMark;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int PersonalityNoMark
        {
            set
            {
                if (m_PersonalityNoMark == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePersonalityNoMark, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PersonalityNoMark = value;
                    OnPropertyChanged(PropertyNamePersonalityNoMark);
                }
            }
            get
            {
                return m_PersonalityNoMark;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcqQuestionnaireScale", Namespace = Strings.DefaultNamespace)]
    public partial class AcqQuestionnaireScale
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_QuestionnaireScaleId;
        public const string PropertyNameQuestionnaireScaleId = "QuestionnaireScaleId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_QuestionnaireId;
        public const string PropertyNameQuestionnaireId = "QuestionnaireId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ScaleRemark;
        public const string PropertyNameScaleRemark = "ScaleRemark";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Scale;
        public const string PropertyNameScale = "Scale";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_MeritMark;
        public const string PropertyNameMeritMark = "MeritMark";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int QuestionnaireScaleId
        {
            set
            {
                if (m_QuestionnaireScaleId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameQuestionnaireScaleId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_QuestionnaireScaleId = value;
                    OnPropertyChanged(PropertyNameQuestionnaireScaleId);
                }
            }
            get
            {
                return m_QuestionnaireScaleId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int QuestionnaireId
        {
            set
            {
                if (m_QuestionnaireId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameQuestionnaireId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_QuestionnaireId = value;
                    OnPropertyChanged(PropertyNameQuestionnaireId);
                }
            }
            get
            {
                return m_QuestionnaireId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ScaleRemark
        {
            set
            {
                if (String.Equals(m_ScaleRemark, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScaleRemark, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ScaleRemark = value;
                    OnPropertyChanged(PropertyNameScaleRemark);
                }
            }
            get
            {
                return m_ScaleRemark;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Scale
        {
            set
            {
                if (m_Scale == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameScale, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Scale = value;
                    OnPropertyChanged(PropertyNameScale);
                }
            }
            get
            {
                return m_Scale;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int MeritMark
        {
            set
            {
                if (m_MeritMark == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMeritMark, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MeritMark = value;
                    OnPropertyChanged(PropertyNameMeritMark);
                }
            }
            get
            {
                return m_MeritMark;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Acquisition", Namespace = Strings.DefaultNamespace)]
    public partial class Acquisition
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionTypeCd;
        public const string PropertyNameAcquisitionTypeCd = "AcquisitionTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Year;
        public const string PropertyNameYear = "Year";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Siri;
        public const string PropertyNameSiri = "Siri";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Target;
        public const string PropertyNameTarget = "Target";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_NewStatus;
        public const string PropertyNameNewStatus = "NewStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_NewStatusBy;
        public const string PropertyNameNewStatusBy = "NewStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_OpenStatus;
        public const string PropertyNameOpenStatus = "OpenStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_OpenStatusBy;
        public const string PropertyNameOpenStatusBy = "OpenStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_CloseStatus;
        public const string PropertyNameCloseStatus = "CloseStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CloseStatusBy;
        public const string PropertyNameCloseStatusBy = "CloseStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_InviteFirstSelStatus;
        public const string PropertyNameInviteFirstSelStatus = "InviteFirstSelStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InviteFirstSelStatusBy;
        public const string PropertyNameInviteFirstSelStatusBy = "InviteFirstSelStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_SecurityCheckStatus;
        public const string PropertyNameSecurityCheckStatus = "SecurityCheckStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SecurityCheckStatusBy;
        public const string PropertyNameSecurityCheckStatusBy = "SecurityCheckStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_FirstSelectionStatus;
        public const string PropertyNameFirstSelectionStatus = "FirstSelectionStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FirstSelectionStatusBy;
        public const string PropertyNameFirstSelectionStatusBy = "FirstSelectionStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_InviteFinalSelStatus;
        public const string PropertyNameInviteFinalSelStatus = "InviteFinalSelStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InviteFinalSelStatusBy;
        public const string PropertyNameInviteFinalSelStatusBy = "InviteFinalSelStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_WrittenTestStatus;
        public const string PropertyNameWrittenTestStatus = "WrittenTestStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_WrittenTestStatusBy;
        public const string PropertyNameWrittenTestStatusBy = "WrittenTestStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_FinalSelStatus;
        public const string PropertyNameFinalSelStatus = "FinalSelStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FinalSelStatusBy;
        public const string PropertyNameFinalSelStatusBy = "FinalSelStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_AssignNoTenteraStatus;
        public const string PropertyNameAssignNoTenteraStatus = "AssignNoTenteraStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AssignNoTenteraStatusBy;
        public const string PropertyNameAssignNoTenteraStatusBy = "AssignNoTenteraStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_CompleteStatus;
        public const string PropertyNameCompleteStatus = "CompleteStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CompleteStatusBy;
        public const string PropertyNameCompleteStatusBy = "CompleteStatusBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_ClosingDate;
        public const string PropertyNameClosingDate = "ClosingDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<AcquisitionCriteria> m_AcquisitionCriteriaCollection = new List<AcquisitionCriteria>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("AcquisitionCriteria", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<AcquisitionCriteria> AcquisitionCriteriaCollection
        {
            get { return m_AcquisitionCriteriaCollection; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<AcquisitionEducationCriteria> m_AcquisitionEducationCriteriaCollection = new List<AcquisitionEducationCriteria>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("AcquisitionEducationCriteria", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<AcquisitionEducationCriteria> AcquisitionEducationCriteriaCollection
        {
            get { return m_AcquisitionEducationCriteriaCollection; }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<AcquisitionLocation> m_AcquisitionLocationCollection = new List<AcquisitionLocation>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("AcquisitionLocation", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<AcquisitionLocation> AcquisitionLocationCollection
        {
            get { return m_AcquisitionLocationCollection; }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionId
        {
            set
            {
                if (m_AcquisitionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionId = value;
                    OnPropertyChanged(PropertyNameAcquisitionId);
                }
            }
            get
            {
                return m_AcquisitionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionTypeCd
        {
            set
            {
                if (m_AcquisitionTypeCd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionTypeCd = value;
                    OnPropertyChanged(PropertyNameAcquisitionTypeCd);
                }
            }
            get
            {
                return m_AcquisitionTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Year
        {
            set
            {
                if (m_Year == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameYear, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Year = value;
                    OnPropertyChanged(PropertyNameYear);
                }
            }
            get
            {
                return m_Year;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Siri
        {
            set
            {
                if (m_Siri == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSiri, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Siri = value;
                    OnPropertyChanged(PropertyNameSiri);
                }
            }
            get
            {
                return m_Siri;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Target
        {
            set
            {
                if (m_Target == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTarget, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Target = value;
                    OnPropertyChanged(PropertyNameTarget);
                }
            }
            get
            {
                return m_Target;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool NewStatus
        {
            set
            {
                if (m_NewStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNewStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NewStatus = value;
                    OnPropertyChanged(PropertyNameNewStatus);
                }
            }
            get
            {
                return m_NewStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string NewStatusBy
        {
            set
            {
                if (String.Equals(m_NewStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNewStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_NewStatusBy = value;
                    OnPropertyChanged(PropertyNameNewStatusBy);
                }
            }
            get
            {
                return m_NewStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool OpenStatus
        {
            set
            {
                if (m_OpenStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOpenStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OpenStatus = value;
                    OnPropertyChanged(PropertyNameOpenStatus);
                }
            }
            get
            {
                return m_OpenStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string OpenStatusBy
        {
            set
            {
                if (String.Equals(m_OpenStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOpenStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OpenStatusBy = value;
                    OnPropertyChanged(PropertyNameOpenStatusBy);
                }
            }
            get
            {
                return m_OpenStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool CloseStatus
        {
            set
            {
                if (m_CloseStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCloseStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CloseStatus = value;
                    OnPropertyChanged(PropertyNameCloseStatus);
                }
            }
            get
            {
                return m_CloseStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CloseStatusBy
        {
            set
            {
                if (String.Equals(m_CloseStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCloseStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CloseStatusBy = value;
                    OnPropertyChanged(PropertyNameCloseStatusBy);
                }
            }
            get
            {
                return m_CloseStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool InviteFirstSelStatus
        {
            set
            {
                if (m_InviteFirstSelStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInviteFirstSelStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InviteFirstSelStatus = value;
                    OnPropertyChanged(PropertyNameInviteFirstSelStatus);
                }
            }
            get
            {
                return m_InviteFirstSelStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InviteFirstSelStatusBy
        {
            set
            {
                if (String.Equals(m_InviteFirstSelStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInviteFirstSelStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InviteFirstSelStatusBy = value;
                    OnPropertyChanged(PropertyNameInviteFirstSelStatusBy);
                }
            }
            get
            {
                return m_InviteFirstSelStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool SecurityCheckStatus
        {
            set
            {
                if (m_SecurityCheckStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSecurityCheckStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SecurityCheckStatus = value;
                    OnPropertyChanged(PropertyNameSecurityCheckStatus);
                }
            }
            get
            {
                return m_SecurityCheckStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SecurityCheckStatusBy
        {
            set
            {
                if (String.Equals(m_SecurityCheckStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSecurityCheckStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SecurityCheckStatusBy = value;
                    OnPropertyChanged(PropertyNameSecurityCheckStatusBy);
                }
            }
            get
            {
                return m_SecurityCheckStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool FirstSelectionStatus
        {
            set
            {
                if (m_FirstSelectionStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFirstSelectionStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FirstSelectionStatus = value;
                    OnPropertyChanged(PropertyNameFirstSelectionStatus);
                }
            }
            get
            {
                return m_FirstSelectionStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string FirstSelectionStatusBy
        {
            set
            {
                if (String.Equals(m_FirstSelectionStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFirstSelectionStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FirstSelectionStatusBy = value;
                    OnPropertyChanged(PropertyNameFirstSelectionStatusBy);
                }
            }
            get
            {
                return m_FirstSelectionStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool InviteFinalSelStatus
        {
            set
            {
                if (m_InviteFinalSelStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInviteFinalSelStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InviteFinalSelStatus = value;
                    OnPropertyChanged(PropertyNameInviteFinalSelStatus);
                }
            }
            get
            {
                return m_InviteFinalSelStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InviteFinalSelStatusBy
        {
            set
            {
                if (String.Equals(m_InviteFinalSelStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInviteFinalSelStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InviteFinalSelStatusBy = value;
                    OnPropertyChanged(PropertyNameInviteFinalSelStatusBy);
                }
            }
            get
            {
                return m_InviteFinalSelStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool WrittenTestStatus
        {
            set
            {
                if (m_WrittenTestStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameWrittenTestStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_WrittenTestStatus = value;
                    OnPropertyChanged(PropertyNameWrittenTestStatus);
                }
            }
            get
            {
                return m_WrittenTestStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string WrittenTestStatusBy
        {
            set
            {
                if (String.Equals(m_WrittenTestStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameWrittenTestStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_WrittenTestStatusBy = value;
                    OnPropertyChanged(PropertyNameWrittenTestStatusBy);
                }
            }
            get
            {
                return m_WrittenTestStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool FinalSelStatus
        {
            set
            {
                if (m_FinalSelStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFinalSelStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FinalSelStatus = value;
                    OnPropertyChanged(PropertyNameFinalSelStatus);
                }
            }
            get
            {
                return m_FinalSelStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string FinalSelStatusBy
        {
            set
            {
                if (String.Equals(m_FinalSelStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFinalSelStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FinalSelStatusBy = value;
                    OnPropertyChanged(PropertyNameFinalSelStatusBy);
                }
            }
            get
            {
                return m_FinalSelStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool AssignNoTenteraStatus
        {
            set
            {
                if (m_AssignNoTenteraStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAssignNoTenteraStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AssignNoTenteraStatus = value;
                    OnPropertyChanged(PropertyNameAssignNoTenteraStatus);
                }
            }
            get
            {
                return m_AssignNoTenteraStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AssignNoTenteraStatusBy
        {
            set
            {
                if (String.Equals(m_AssignNoTenteraStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAssignNoTenteraStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AssignNoTenteraStatusBy = value;
                    OnPropertyChanged(PropertyNameAssignNoTenteraStatusBy);
                }
            }
            get
            {
                return m_AssignNoTenteraStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool CompleteStatus
        {
            set
            {
                if (m_CompleteStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCompleteStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CompleteStatus = value;
                    OnPropertyChanged(PropertyNameCompleteStatus);
                }
            }
            get
            {
                return m_CompleteStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CompleteStatusBy
        {
            set
            {
                if (String.Equals(m_CompleteStatusBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCompleteStatusBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CompleteStatusBy = value;
                    OnPropertyChanged(PropertyNameCompleteStatusBy);
                }
            }
            get
            {
                return m_CompleteStatusBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? ClosingDate
        {
            set
            {
                if (m_ClosingDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameClosingDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ClosingDate = value;
                    OnPropertyChanged(PropertyNameClosingDate);
                }
            }
            get { return m_ClosingDate; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcquisitionCriteria", Namespace = Strings.DefaultNamespace)]
    public partial class AcquisitionCriteria
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcqCriteriaId;
        public const string PropertyNameAcqCriteriaId = "AcqCriteriaId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TDHeightM;
        public const string PropertyNameTDHeightM = "TDHeightM";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TDWeightM;
        public const string PropertyNameTDWeightM = "TDWeightM";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TDHeightF;
        public const string PropertyNameTDHeightF = "TDHeightF";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TDWeightF;
        public const string PropertyNameTDWeightF = "TDWeightF";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TLHeightM;
        public const string PropertyNameTLHeightM = "TLHeightM";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TLWeightM;
        public const string PropertyNameTLWeightM = "TLWeightM";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TLHeightF;
        public const string PropertyNameTLHeightF = "TLHeightF";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TLWeightF;
        public const string PropertyNameTLWeightF = "TLWeightF";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TUHeightM;
        public const string PropertyNameTUHeightM = "TUHeightM";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TUWeightM;
        public const string PropertyNameTUWeightM = "TUWeightM";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TUHeightF;
        public const string PropertyNameTUHeightF = "TUHeightF";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_TUWeightF;
        public const string PropertyNameTUWeightF = "TUWeightF";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_MaleBMIFrom;
        public const string PropertyNameMaleBMIFrom = "MaleBMIFrom";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_MaleBMITo;
        public const string PropertyNameMaleBMITo = "MaleBMITo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_FemaleBMIFrom;
        public const string PropertyNameFemaleBMIFrom = "FemaleBMIFrom";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_FemaleBMITo;
        public const string PropertyNameFemaleBMITo = "FemaleBMITo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AgeMinimum;
        public const string PropertyNameAgeMinimum = "AgeMinimum";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private decimal m_MaleChestMinimum;
        public const string PropertyNameMaleChestMinimum = "MaleChestMinimum";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime m_AgeAt;
        public const string PropertyNameAgeAt = "AgeAt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcqCriteriaId
        {
            set
            {
                if (m_AcqCriteriaId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcqCriteriaId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcqCriteriaId = value;
                    OnPropertyChanged(PropertyNameAcqCriteriaId);
                }
            }
            get
            {
                return m_AcqCriteriaId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionId
        {
            set
            {
                if (m_AcquisitionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionId = value;
                    OnPropertyChanged(PropertyNameAcquisitionId);
                }
            }
            get
            {
                return m_AcquisitionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TDHeightM
        {
            set
            {
                if (m_TDHeightM == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTDHeightM, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TDHeightM = value;
                    OnPropertyChanged(PropertyNameTDHeightM);
                }
            }
            get
            {
                return m_TDHeightM;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TDWeightM
        {
            set
            {
                if (m_TDWeightM == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTDWeightM, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TDWeightM = value;
                    OnPropertyChanged(PropertyNameTDWeightM);
                }
            }
            get
            {
                return m_TDWeightM;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TDHeightF
        {
            set
            {
                if (m_TDHeightF == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTDHeightF, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TDHeightF = value;
                    OnPropertyChanged(PropertyNameTDHeightF);
                }
            }
            get
            {
                return m_TDHeightF;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TDWeightF
        {
            set
            {
                if (m_TDWeightF == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTDWeightF, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TDWeightF = value;
                    OnPropertyChanged(PropertyNameTDWeightF);
                }
            }
            get
            {
                return m_TDWeightF;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TLHeightM
        {
            set
            {
                if (m_TLHeightM == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTLHeightM, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TLHeightM = value;
                    OnPropertyChanged(PropertyNameTLHeightM);
                }
            }
            get
            {
                return m_TLHeightM;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TLWeightM
        {
            set
            {
                if (m_TLWeightM == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTLWeightM, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TLWeightM = value;
                    OnPropertyChanged(PropertyNameTLWeightM);
                }
            }
            get
            {
                return m_TLWeightM;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TLHeightF
        {
            set
            {
                if (m_TLHeightF == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTLHeightF, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TLHeightF = value;
                    OnPropertyChanged(PropertyNameTLHeightF);
                }
            }
            get
            {
                return m_TLHeightF;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TLWeightF
        {
            set
            {
                if (m_TLWeightF == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTLWeightF, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TLWeightF = value;
                    OnPropertyChanged(PropertyNameTLWeightF);
                }
            }
            get
            {
                return m_TLWeightF;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TUHeightM
        {
            set
            {
                if (m_TUHeightM == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTUHeightM, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TUHeightM = value;
                    OnPropertyChanged(PropertyNameTUHeightM);
                }
            }
            get
            {
                return m_TUHeightM;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TUWeightM
        {
            set
            {
                if (m_TUWeightM == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTUWeightM, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TUWeightM = value;
                    OnPropertyChanged(PropertyNameTUWeightM);
                }
            }
            get
            {
                return m_TUWeightM;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TUHeightF
        {
            set
            {
                if (m_TUHeightF == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTUHeightF, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TUHeightF = value;
                    OnPropertyChanged(PropertyNameTUHeightF);
                }
            }
            get
            {
                return m_TUHeightF;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal TUWeightF
        {
            set
            {
                if (m_TUWeightF == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTUWeightF, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TUWeightF = value;
                    OnPropertyChanged(PropertyNameTUWeightF);
                }
            }
            get
            {
                return m_TUWeightF;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal MaleBMIFrom
        {
            set
            {
                if (m_MaleBMIFrom == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMaleBMIFrom, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MaleBMIFrom = value;
                    OnPropertyChanged(PropertyNameMaleBMIFrom);
                }
            }
            get
            {
                return m_MaleBMIFrom;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal MaleBMITo
        {
            set
            {
                if (m_MaleBMITo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMaleBMITo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MaleBMITo = value;
                    OnPropertyChanged(PropertyNameMaleBMITo);
                }
            }
            get
            {
                return m_MaleBMITo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal FemaleBMIFrom
        {
            set
            {
                if (m_FemaleBMIFrom == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFemaleBMIFrom, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FemaleBMIFrom = value;
                    OnPropertyChanged(PropertyNameFemaleBMIFrom);
                }
            }
            get
            {
                return m_FemaleBMIFrom;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal FemaleBMITo
        {
            set
            {
                if (m_FemaleBMITo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFemaleBMITo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FemaleBMITo = value;
                    OnPropertyChanged(PropertyNameFemaleBMITo);
                }
            }
            get
            {
                return m_FemaleBMITo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AgeMinimum
        {
            set
            {
                if (m_AgeMinimum == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAgeMinimum, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AgeMinimum = value;
                    OnPropertyChanged(PropertyNameAgeMinimum);
                }
            }
            get
            {
                return m_AgeMinimum;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual decimal MaleChestMinimum
        {
            set
            {
                if (m_MaleChestMinimum == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMaleChestMinimum, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MaleChestMinimum = value;
                    OnPropertyChanged(PropertyNameMaleChestMinimum);
                }
            }
            get
            {
                return m_MaleChestMinimum;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime AgeAt
        {
            set
            {
                if (m_AgeAt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAgeAt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AgeAt = value;
                    OnPropertyChanged(PropertyNameAgeAt);
                }
            }
            get { return m_AgeAt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcquisitionEducationCriteria", Namespace = Strings.DefaultNamespace)]
    public partial class AcquisitionEducationCriteria
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcqEduCriteriaId;
        public const string PropertyNameAcqEduCriteriaId = "AcqEduCriteriaId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighEduLevelCd;
        public const string PropertyNameHighEduLevelCd = "HighEduLevelCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<AcquisitionEducationCriteriaSubject> m_AcquisitionEducationCriteriaSubjectCollection = new List<AcquisitionEducationCriteriaSubject>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("AcquisitionEducationCriteriaSubject", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<AcquisitionEducationCriteriaSubject> AcquisitionEducationCriteriaSubjectCollection
        {
            get { return m_AcquisitionEducationCriteriaSubjectCollection; }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcqEduCriteriaId
        {
            set
            {
                if (m_AcqEduCriteriaId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcqEduCriteriaId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcqEduCriteriaId = value;
                    OnPropertyChanged(PropertyNameAcqEduCriteriaId);
                }
            }
            get
            {
                return m_AcqEduCriteriaId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionId
        {
            set
            {
                if (m_AcquisitionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionId = value;
                    OnPropertyChanged(PropertyNameAcquisitionId);
                }
            }
            get
            {
                return m_AcquisitionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HighEduLevelCd
        {
            set
            {
                if (String.Equals(m_HighEduLevelCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighEduLevelCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighEduLevelCd = value;
                    OnPropertyChanged(PropertyNameHighEduLevelCd);
                }
            }
            get
            {
                return m_HighEduLevelCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcquisitionEducationCriteriaSubject", Namespace = Strings.DefaultNamespace)]
    public partial class AcquisitionEducationCriteriaSubject
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcqEduCriteriaSubjectId;
        public const string PropertyNameAcqEduCriteriaSubjectId = "AcqEduCriteriaSubjectId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcqEduCriteriaId;
        public const string PropertyNameAcqEduCriteriaId = "AcqEduCriteriaId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SubjectCd;
        public const string PropertyNameSubjectCd = "SubjectCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Subject;
        public const string PropertyNameSubject = "Subject";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MinimumGradeCd;
        public const string PropertyNameMinimumGradeCd = "MinimumGradeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Grade;
        public const string PropertyNameGrade = "Grade";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_MainSubjectInd;
        public const string PropertyNameMainSubjectInd = "MainSubjectInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcqEduCriteriaSubjectId
        {
            set
            {
                if (m_AcqEduCriteriaSubjectId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcqEduCriteriaSubjectId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcqEduCriteriaSubjectId = value;
                    OnPropertyChanged(PropertyNameAcqEduCriteriaSubjectId);
                }
            }
            get
            {
                return m_AcqEduCriteriaSubjectId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcqEduCriteriaId
        {
            set
            {
                if (m_AcqEduCriteriaId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcqEduCriteriaId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcqEduCriteriaId = value;
                    OnPropertyChanged(PropertyNameAcqEduCriteriaId);
                }
            }
            get
            {
                return m_AcqEduCriteriaId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SubjectCd
        {
            set
            {
                if (String.Equals(m_SubjectCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSubjectCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SubjectCd = value;
                    OnPropertyChanged(PropertyNameSubjectCd);
                }
            }
            get
            {
                return m_SubjectCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Subject
        {
            set
            {
                if (String.Equals(m_Subject, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSubject, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Subject = value;
                    OnPropertyChanged(PropertyNameSubject);
                }
            }
            get
            {
                return m_Subject;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MinimumGradeCd
        {
            set
            {
                if (String.Equals(m_MinimumGradeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMinimumGradeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MinimumGradeCd = value;
                    OnPropertyChanged(PropertyNameMinimumGradeCd);
                }
            }
            get
            {
                return m_MinimumGradeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Grade
        {
            set
            {
                if (String.Equals(m_Grade, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGrade, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Grade = value;
                    OnPropertyChanged(PropertyNameGrade);
                }
            }
            get
            {
                return m_Grade;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool MainSubjectInd
        {
            set
            {
                if (m_MainSubjectInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMainSubjectInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MainSubjectInd = value;
                    OnPropertyChanged(PropertyNameMainSubjectInd);
                }
            }
            get
            {
                return m_MainSubjectInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcquisitionLocation", Namespace = Strings.DefaultNamespace)]
    public partial class AcquisitionLocation
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcqLocationId;
        public const string PropertyNameAcqLocationId = "AcqLocationId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ZoneCd;
        public const string PropertyNameZoneCd = "ZoneCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private int? m_LocationId;
        public const string PropertyNameLocationId = "LocationId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Acquisition m_Acquisition
            = new Acquisition();

        public const string PropertyNameAcquisition = "Acquisition";
        [DebuggerHidden]

        public virtual Acquisition Acquisition
        {
            get { return m_Acquisition; }
            set
            {
                m_Acquisition = value;
                OnPropertyChanged(PropertyNameAcquisition);
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcqLocationId
        {
            set
            {
                if (m_AcqLocationId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcqLocationId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcqLocationId = value;
                    OnPropertyChanged(PropertyNameAcqLocationId);
                }
            }
            get
            {
                return m_AcqLocationId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionId
        {
            set
            {
                if (m_AcquisitionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionId = value;
                    OnPropertyChanged(PropertyNameAcquisitionId);
                }
            }
            get
            {
                return m_AcquisitionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ZoneCd
        {
            set
            {
                if (String.Equals(m_ZoneCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameZoneCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ZoneCd = value;
                    OnPropertyChanged(PropertyNameZoneCd);
                }
            }
            get
            {
                return m_ZoneCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual int? LocationId
        {
            set
            {
                if (m_LocationId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLocationId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LocationId = value;
                    OnPropertyChanged(PropertyNameLocationId);
                }
            }
            get { return m_LocationId; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("LoginRole", Namespace = Strings.DefaultNamespace)]
    public partial class LoginRole
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Roles;
        public const string PropertyNameRoles = "Roles";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_UserId;
        public const string PropertyNameUserId = "UserId";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Roles
        {
            set
            {
                if (String.Equals(m_Roles, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameRoles, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Roles = value;
                    OnPropertyChanged(PropertyNameRoles);
                }
            }
            get
            {
                return m_Roles;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int UserId
        {
            set
            {
                if (m_UserId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameUserId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_UserId = value;
                    OnPropertyChanged(PropertyNameUserId);
                }
            }
            get
            {
                return m_UserId;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Country", Namespace = Strings.DefaultNamespace)]
    public partial class Country
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CountryCd;
        public const string PropertyNameCountryCd = "CountryCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CountryName;
        public const string PropertyNameCountryName = "CountryName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CountryCd
        {
            set
            {
                if (String.Equals(m_CountryCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCountryCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CountryCd = value;
                    OnPropertyChanged(PropertyNameCountryCd);
                }
            }
            get
            {
                return m_CountryCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CountryName
        {
            set
            {
                if (String.Equals(m_CountryName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCountryName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CountryName = value;
                    OnPropertyChanged(PropertyNameCountryName);
                }
            }
            get
            {
                return m_CountryName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("City", Namespace = Strings.DefaultNamespace)]
    public partial class City
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CityCd;
        public const string PropertyNameCityCd = "CityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CityName;
        public const string PropertyNameCityName = "CityName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_StateCd;
        public const string PropertyNameStateCd = "StateCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_StateCapitalInd;
        public const string PropertyNameStateCapitalInd = "StateCapitalInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_MainCityInd;
        public const string PropertyNameMainCityInd = "MainCityInd";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CityCd
        {
            set
            {
                if (String.Equals(m_CityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CityCd = value;
                    OnPropertyChanged(PropertyNameCityCd);
                }
            }
            get
            {
                return m_CityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CityName
        {
            set
            {
                if (String.Equals(m_CityName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCityName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CityName = value;
                    OnPropertyChanged(PropertyNameCityName);
                }
            }
            get
            {
                return m_CityName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string StateCd
        {
            set
            {
                if (String.Equals(m_StateCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStateCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_StateCd = value;
                    OnPropertyChanged(PropertyNameStateCd);
                }
            }
            get
            {
                return m_StateCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool StateCapitalInd
        {
            set
            {
                if (m_StateCapitalInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStateCapitalInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_StateCapitalInd = value;
                    OnPropertyChanged(PropertyNameStateCapitalInd);
                }
            }
            get
            {
                return m_StateCapitalInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool MainCityInd
        {
            set
            {
                if (m_MainCityInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMainCityInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MainCityInd = value;
                    OnPropertyChanged(PropertyNameMainCityInd);
                }
            }
            get
            {
                return m_MainCityInd;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("BloodType", Namespace = Strings.DefaultNamespace)]
    public partial class BloodType
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BloodTypeCd;
        public const string PropertyNameBloodTypeCd = "BloodTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_BloodTypeDesc;
        public const string PropertyNameBloodTypeDesc = "BloodTypeDesc";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BloodTypeCd
        {
            set
            {
                if (String.Equals(m_BloodTypeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBloodTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BloodTypeCd = value;
                    OnPropertyChanged(PropertyNameBloodTypeCd);
                }
            }
            get
            {
                return m_BloodTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string BloodTypeDesc
        {
            set
            {
                if (String.Equals(m_BloodTypeDesc, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameBloodTypeDesc, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_BloodTypeDesc = value;
                    OnPropertyChanged(PropertyNameBloodTypeDesc);
                }
            }
            get
            {
                return m_BloodTypeDesc;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("AcquisitionType", Namespace = Strings.DefaultNamespace)]
    public partial class AcquisitionType
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionTypeCd;
        public const string PropertyNameAcquisitionTypeCd = "AcquisitionTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AcquisitionTypeNm;
        public const string PropertyNameAcquisitionTypeNm = "AcquisitionTypeNm";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ServiceCd;
        public const string PropertyNameServiceCd = "ServiceCd";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionTypeCd
        {
            set
            {
                if (m_AcquisitionTypeCd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionTypeCd = value;
                    OnPropertyChanged(PropertyNameAcquisitionTypeCd);
                }
            }
            get
            {
                return m_AcquisitionTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AcquisitionTypeNm
        {
            set
            {
                if (String.Equals(m_AcquisitionTypeNm, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionTypeNm, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionTypeNm = value;
                    OnPropertyChanged(PropertyNameAcquisitionTypeNm);
                }
            }
            get
            {
                return m_AcquisitionTypeNm;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ServiceCd
        {
            set
            {
                if (String.Equals(m_ServiceCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameServiceCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ServiceCd = value;
                    OnPropertyChanged(PropertyNameServiceCd);
                }
            }
            get
            {
                return m_ServiceCd;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Achievement", Namespace = Strings.DefaultNamespace)]
    public partial class Achievement
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AchievementCd;
        public const string PropertyNameAchievementCd = "AchievementCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AchievementDescription;
        public const string PropertyNameAchievementDescription = "AchievementDescription";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AchievementCd
        {
            set
            {
                if (String.Equals(m_AchievementCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAchievementCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AchievementCd = value;
                    OnPropertyChanged(PropertyNameAchievementCd);
                }
            }
            get
            {
                return m_AchievementCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string AchievementDescription
        {
            set
            {
                if (String.Equals(m_AchievementDescription, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAchievementDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AchievementDescription = value;
                    OnPropertyChanged(PropertyNameAchievementDescription);
                }
            }
            get
            {
                return m_AchievementDescription;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Ethnic", Namespace = Strings.DefaultNamespace)]
    public partial class Ethnic
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_EthnicCd;
        public const string PropertyNameEthnicCd = "EthnicCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_EthnicDescription;
        public const string PropertyNameEthnicDescription = "EthnicDescription";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_EthnicParentCd;
        public const string PropertyNameEthnicParentCd = "EthnicParentCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_RaceCd;
        public const string PropertyNameRaceCd = "RaceCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string EthnicCd
        {
            set
            {
                if (String.Equals(m_EthnicCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEthnicCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EthnicCd = value;
                    OnPropertyChanged(PropertyNameEthnicCd);
                }
            }
            get
            {
                return m_EthnicCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string EthnicDescription
        {
            set
            {
                if (String.Equals(m_EthnicDescription, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEthnicDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EthnicDescription = value;
                    OnPropertyChanged(PropertyNameEthnicDescription);
                }
            }
            get
            {
                return m_EthnicDescription;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string EthnicParentCd
        {
            set
            {
                if (String.Equals(m_EthnicParentCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEthnicParentCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EthnicParentCd = value;
                    OnPropertyChanged(PropertyNameEthnicParentCd);
                }
            }
            get
            {
                return m_EthnicParentCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string RaceCd
        {
            set
            {
                if (String.Equals(m_RaceCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameRaceCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_RaceCd = value;
                    OnPropertyChanged(PropertyNameRaceCd);
                }
            }
            get
            {
                return m_RaceCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Gender", Namespace = Strings.DefaultNamespace)]
    public partial class Gender
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GenderCd;
        public const string PropertyNameGenderCd = "GenderCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GenderDesc;
        public const string PropertyNameGenderDesc = "GenderDesc";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GenderCd
        {
            set
            {
                if (String.Equals(m_GenderCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGenderCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GenderCd = value;
                    OnPropertyChanged(PropertyNameGenderCd);
                }
            }
            get
            {
                return m_GenderCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GenderDesc
        {
            set
            {
                if (String.Equals(m_GenderDesc, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGenderDesc, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GenderDesc = value;
                    OnPropertyChanged(PropertyNameGenderDesc);
                }
            }
            get
            {
                return m_GenderDesc;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("HighEduLevel", Namespace = Strings.DefaultNamespace)]
    public partial class HighEduLevel
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighEduLevelCd;
        public const string PropertyNameHighEduLevelCd = "HighEduLevelCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighestEduLevel;
        public const string PropertyNameHighestEduLevel = "HighestEduLevel";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_IndexNo;
        public const string PropertyNameIndexNo = "IndexNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_HighestEduLevelRank;
        public const string PropertyNameHighestEduLevelRank = "HighestEduLevelRank";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HighEduLevelCd
        {
            set
            {
                if (String.Equals(m_HighEduLevelCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighEduLevelCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighEduLevelCd = value;
                    OnPropertyChanged(PropertyNameHighEduLevelCd);
                }
            }
            get
            {
                return m_HighEduLevelCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HighestEduLevel
        {
            set
            {
                if (String.Equals(m_HighestEduLevel, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighestEduLevel, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighestEduLevel = value;
                    OnPropertyChanged(PropertyNameHighestEduLevel);
                }
            }
            get
            {
                return m_HighestEduLevel;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int IndexNo
        {
            set
            {
                if (m_IndexNo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIndexNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IndexNo = value;
                    OnPropertyChanged(PropertyNameIndexNo);
                }
            }
            get
            {
                return m_IndexNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int HighestEduLevelRank
        {
            set
            {
                if (m_HighestEduLevelRank == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighestEduLevelRank, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighestEduLevelRank = value;
                    OnPropertyChanged(PropertyNameHighestEduLevelRank);
                }
            }
            get
            {
                return m_HighestEduLevelRank;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Occupation", Namespace = Strings.DefaultNamespace)]
    public partial class Occupation
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_OccupationCd;
        public const string PropertyNameOccupationCd = "OccupationCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_OccupationName;
        public const string PropertyNameOccupationName = "OccupationName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string OccupationCd
        {
            set
            {
                if (String.Equals(m_OccupationCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOccupationCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OccupationCd = value;
                    OnPropertyChanged(PropertyNameOccupationCd);
                }
            }
            get
            {
                return m_OccupationCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string OccupationName
        {
            set
            {
                if (String.Equals(m_OccupationName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameOccupationName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_OccupationName = value;
                    OnPropertyChanged(PropertyNameOccupationName);
                }
            }
            get
            {
                return m_OccupationName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("SportAndAssociation", Namespace = Strings.DefaultNamespace)]
    public partial class SportAndAssociation
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_SportAssocId;
        public const string PropertyNameSportAssocId = "SportAssocId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SportAssociatType;
        public const string PropertyNameSportAssociatType = "SportAssociatType";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SportAssociatName;
        public const string PropertyNameSportAssociatName = "SportAssociatName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int SportAssocId
        {
            set
            {
                if (m_SportAssocId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSportAssocId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SportAssocId = value;
                    OnPropertyChanged(PropertyNameSportAssocId);
                }
            }
            get
            {
                return m_SportAssocId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SportAssociatType
        {
            set
            {
                if (String.Equals(m_SportAssociatType, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSportAssociatType, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SportAssociatType = value;
                    OnPropertyChanged(PropertyNameSportAssociatType);
                }
            }
            get
            {
                return m_SportAssociatType;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SportAssociatName
        {
            set
            {
                if (String.Equals(m_SportAssociatName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSportAssociatName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SportAssociatName = value;
                    OnPropertyChanged(PropertyNameSportAssociatName);
                }
            }
            get
            {
                return m_SportAssociatName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Institution", Namespace = Strings.DefaultNamespace)]
    public partial class Institution
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstCd;
        public const string PropertyNameInstCd = "InstCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstNm;
        public const string PropertyNameInstNm = "InstNm";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_MQAStatus;
        public const string PropertyNameMQAStatus = "MQAStatus";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstCatCd;
        public const string PropertyNameInstCatCd = "InstCatCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstCd
        {
            set
            {
                if (String.Equals(m_InstCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstCd = value;
                    OnPropertyChanged(PropertyNameInstCd);
                }
            }
            get
            {
                return m_InstCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstNm
        {
            set
            {
                if (String.Equals(m_InstNm, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstNm, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstNm = value;
                    OnPropertyChanged(PropertyNameInstNm);
                }
            }
            get
            {
                return m_InstNm;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool MQAStatus
        {
            set
            {
                if (m_MQAStatus == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMQAStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MQAStatus = value;
                    OnPropertyChanged(PropertyNameMQAStatus);
                }
            }
            get
            {
                return m_MQAStatus;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstCatCd
        {
            set
            {
                if (String.Equals(m_InstCatCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstCatCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstCatCd = value;
                    OnPropertyChanged(PropertyNameInstCatCd);
                }
            }
            get
            {
                return m_InstCatCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("InstitutionCat", Namespace = Strings.DefaultNamespace)]
    public partial class InstitutionCat
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstCatCd;
        public const string PropertyNameInstCatCd = "InstCatCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_InstCat;
        public const string PropertyNameInstCat = "InstCat";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstCatCd
        {
            set
            {
                if (String.Equals(m_InstCatCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstCatCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstCatCd = value;
                    OnPropertyChanged(PropertyNameInstCatCd);
                }
            }
            get
            {
                return m_InstCatCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string InstCat
        {
            set
            {
                if (String.Equals(m_InstCat, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInstCat, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InstCat = value;
                    OnPropertyChanged(PropertyNameInstCat);
                }
            }
            get
            {
                return m_InstCat;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("MajorMinor", Namespace = Strings.DefaultNamespace)]
    public partial class MajorMinor
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MajorMinorCd;
        public const string PropertyNameMajorMinorCd = "MajorMinorCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MajorMinorDesc;
        public const string PropertyNameMajorMinorDesc = "MajorMinorDesc";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MajorMinorCd
        {
            set
            {
                if (String.Equals(m_MajorMinorCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMajorMinorCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MajorMinorCd = value;
                    OnPropertyChanged(PropertyNameMajorMinorCd);
                }
            }
            get
            {
                return m_MajorMinorCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MajorMinorDesc
        {
            set
            {
                if (String.Equals(m_MajorMinorDesc, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMajorMinorDesc, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MajorMinorDesc = value;
                    OnPropertyChanged(PropertyNameMajorMinorDesc);
                }
            }
            get
            {
                return m_MajorMinorDesc;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("MaritalStatus", Namespace = Strings.DefaultNamespace)]
    public partial class MaritalStatus
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MrtlStatusCd;
        public const string PropertyNameMrtlStatusCd = "MrtlStatusCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MrtlStatus;
        public const string PropertyNameMrtlStatus = "MrtlStatus";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MrtlStatusCd
        {
            set
            {
                if (String.Equals(m_MrtlStatusCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMrtlStatusCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MrtlStatusCd = value;
                    OnPropertyChanged(PropertyNameMrtlStatusCd);
                }
            }
            get
            {
                return m_MrtlStatusCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string MrtlStatus
        {
            set
            {
                if (String.Equals(m_MrtlStatus, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameMrtlStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_MrtlStatus = value;
                    OnPropertyChanged(PropertyNameMrtlStatus);
                }
            }
            get
            {
                return m_MrtlStatus;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("PersonalityType", Namespace = Strings.DefaultNamespace)]
    public partial class PersonalityType
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PersonalityTypeCd;
        public const string PropertyNamePersonalityTypeCd = "PersonalityTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PersonalityTypeDesc;
        public const string PropertyNamePersonalityTypeDesc = "PersonalityTypeDesc";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PersonalityTypeCd
        {
            set
            {
                if (String.Equals(m_PersonalityTypeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePersonalityTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PersonalityTypeCd = value;
                    OnPropertyChanged(PropertyNamePersonalityTypeCd);
                }
            }
            get
            {
                return m_PersonalityTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PersonalityTypeDesc
        {
            set
            {
                if (String.Equals(m_PersonalityTypeDesc, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePersonalityTypeDesc, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PersonalityTypeDesc = value;
                    OnPropertyChanged(PropertyNamePersonalityTypeDesc);
                }
            }
            get
            {
                return m_PersonalityTypeDesc;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("LoginStatus", Namespace = Strings.DefaultNamespace)]
    public partial class LoginStatus
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LoginStatusCd;
        public const string PropertyNameLoginStatusCd = "LoginStatusCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LoginStatusNm;
        public const string PropertyNameLoginStatusNm = "LoginStatusNm";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LoginStatusCd
        {
            set
            {
                if (String.Equals(m_LoginStatusCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLoginStatusCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LoginStatusCd = value;
                    OnPropertyChanged(PropertyNameLoginStatusCd);
                }
            }
            get
            {
                return m_LoginStatusCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LoginStatusNm
        {
            set
            {
                if (String.Equals(m_LoginStatusNm, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLoginStatusNm, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LoginStatusNm = value;
                    OnPropertyChanged(PropertyNameLoginStatusNm);
                }
            }
            get
            {
                return m_LoginStatusNm;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("QuestionnareType", Namespace = Strings.DefaultNamespace)]
    public partial class QuestionnareType
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_QuestionnaireTypeCd;
        public const string PropertyNameQuestionnaireTypeCd = "QuestionnaireTypeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_QuestionnaireTypeDesc;
        public const string PropertyNameQuestionnaireTypeDesc = "QuestionnaireTypeDesc";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string QuestionnaireTypeCd
        {
            set
            {
                if (String.Equals(m_QuestionnaireTypeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameQuestionnaireTypeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_QuestionnaireTypeCd = value;
                    OnPropertyChanged(PropertyNameQuestionnaireTypeCd);
                }
            }
            get
            {
                return m_QuestionnaireTypeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string QuestionnaireTypeDesc
        {
            set
            {
                if (String.Equals(m_QuestionnaireTypeDesc, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameQuestionnaireTypeDesc, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_QuestionnaireTypeDesc = value;
                    OnPropertyChanged(PropertyNameQuestionnaireTypeDesc);
                }
            }
            get
            {
                return m_QuestionnaireTypeDesc;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Race", Namespace = Strings.DefaultNamespace)]
    public partial class Race
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_RaceCd;
        public const string PropertyNameRaceCd = "RaceCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_RaceDescription;
        public const string PropertyNameRaceDescription = "RaceDescription";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string RaceCd
        {
            set
            {
                if (String.Equals(m_RaceCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameRaceCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_RaceCd = value;
                    OnPropertyChanged(PropertyNameRaceCd);
                }
            }
            get
            {
                return m_RaceCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string RaceDescription
        {
            set
            {
                if (String.Equals(m_RaceDescription, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameRaceDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_RaceDescription = value;
                    OnPropertyChanged(PropertyNameRaceDescription);
                }
            }
            get
            {
                return m_RaceDescription;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Religion", Namespace = Strings.DefaultNamespace)]
    public partial class Religion
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ReligionCd;
        public const string PropertyNameReligionCd = "ReligionCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ReligionDescription;
        public const string PropertyNameReligionDescription = "ReligionDescription";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ReligionCd
        {
            set
            {
                if (String.Equals(m_ReligionCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameReligionCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ReligionCd = value;
                    OnPropertyChanged(PropertyNameReligionCd);
                }
            }
            get
            {
                return m_ReligionCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ReligionDescription
        {
            set
            {
                if (String.Equals(m_ReligionDescription, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameReligionDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ReligionDescription = value;
                    OnPropertyChanged(PropertyNameReligionDescription);
                }
            }
            get
            {
                return m_ReligionDescription;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Service", Namespace = Strings.DefaultNamespace)]
    public partial class Service
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ServiceCd;
        public const string PropertyNameServiceCd = "ServiceCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ServiceDesc;
        public const string PropertyNameServiceDesc = "ServiceDesc";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ServiceCd
        {
            set
            {
                if (String.Equals(m_ServiceCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameServiceCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ServiceCd = value;
                    OnPropertyChanged(PropertyNameServiceCd);
                }
            }
            get
            {
                return m_ServiceCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ServiceDesc
        {
            set
            {
                if (String.Equals(m_ServiceDesc, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameServiceDesc, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ServiceDesc = value;
                    OnPropertyChanged(PropertyNameServiceDesc);
                }
            }
            get
            {
                return m_ServiceDesc;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Skill", Namespace = Strings.DefaultNamespace)]
    public partial class Skill
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillCd;
        public const string PropertyNameSkillCd = "SkillCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillCategory;
        public const string PropertyNameSkillCategory = "SkillCategory";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillDescription;
        public const string PropertyNameSkillDescription = "SkillDescription";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillCd
        {
            set
            {
                if (String.Equals(m_SkillCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillCd = value;
                    OnPropertyChanged(PropertyNameSkillCd);
                }
            }
            get
            {
                return m_SkillCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillCategory
        {
            set
            {
                if (String.Equals(m_SkillCategory, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillCategory, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillCategory = value;
                    OnPropertyChanged(PropertyNameSkillCategory);
                }
            }
            get
            {
                return m_SkillCategory;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillDescription
        {
            set
            {
                if (String.Equals(m_SkillDescription, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillDescription = value;
                    OnPropertyChanged(PropertyNameSkillDescription);
                }
            }
            get
            {
                return m_SkillDescription;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("SkillCat", Namespace = Strings.DefaultNamespace)]
    public partial class SkillCat
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillCatCd;
        public const string PropertyNameSkillCatCd = "SkillCatCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SkillCatDesc;
        public const string PropertyNameSkillCatDesc = "SkillCatDesc";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillCatCd
        {
            set
            {
                if (String.Equals(m_SkillCatCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillCatCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillCatCd = value;
                    OnPropertyChanged(PropertyNameSkillCatCd);
                }
            }
            get
            {
                return m_SkillCatCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SkillCatDesc
        {
            set
            {
                if (String.Equals(m_SkillCatDesc, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSkillCatDesc, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SkillCatDesc = value;
                    OnPropertyChanged(PropertyNameSkillCatDesc);
                }
            }
            get
            {
                return m_SkillCatDesc;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("State", Namespace = Strings.DefaultNamespace)]
    public partial class State
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_StateCd;
        public const string PropertyNameStateCd = "StateCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_StateDesc;
        public const string PropertyNameStateDesc = "StateDesc";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CountryCd;
        public const string PropertyNameCountryCd = "CountryCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ICBirthStateCd;
        public const string PropertyNameICBirthStateCd = "ICBirthStateCd";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string StateCd
        {
            set
            {
                if (String.Equals(m_StateCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStateCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_StateCd = value;
                    OnPropertyChanged(PropertyNameStateCd);
                }
            }
            get
            {
                return m_StateCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string StateDesc
        {
            set
            {
                if (String.Equals(m_StateDesc, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStateDesc, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_StateDesc = value;
                    OnPropertyChanged(PropertyNameStateDesc);
                }
            }
            get
            {
                return m_StateDesc;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CountryCd
        {
            set
            {
                if (String.Equals(m_CountryCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCountryCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CountryCd = value;
                    OnPropertyChanged(PropertyNameCountryCd);
                }
            }
            get
            {
                return m_CountryCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ICBirthStateCd
        {
            set
            {
                if (String.Equals(m_ICBirthStateCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameICBirthStateCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ICBirthStateCd = value;
                    OnPropertyChanged(PropertyNameICBirthStateCd);
                }
            }
            get
            {
                return m_ICBirthStateCd;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Zone", Namespace = Strings.DefaultNamespace)]
    public partial class Zone
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ZoneCd;
        public const string PropertyNameZoneCd = "ZoneCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ZoneNm;
        public const string PropertyNameZoneNm = "ZoneNm";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ZoneCd
        {
            set
            {
                if (String.Equals(m_ZoneCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameZoneCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ZoneCd = value;
                    OnPropertyChanged(PropertyNameZoneCd);
                }
            }
            get
            {
                return m_ZoneCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ZoneNm
        {
            set
            {
                if (String.Equals(m_ZoneNm, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameZoneNm, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ZoneNm = value;
                    OnPropertyChanged(PropertyNameZoneNm);
                }
            }
            get
            {
                return m_ZoneNm;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ExistingMemberStatus", Namespace = Strings.DefaultNamespace)]
    public partial class ExistingMemberStatus
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Code;
        public const string PropertyNameCode = "Code";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Status;
        public const string PropertyNameStatus = "Status";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Code
        {
            set
            {
                if (String.Equals(m_Code, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCode, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Code = value;
                    OnPropertyChanged(PropertyNameCode);
                }
            }
            get
            {
                return m_Code;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Status
        {
            set
            {
                if (String.Equals(m_Status, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Status = value;
                    OnPropertyChanged(PropertyNameStatus);
                }
            }
            get
            {
                return m_Status;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Location", Namespace = Strings.DefaultNamespace)]
    public partial class Location
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_LocationId;
        public const string PropertyNameLocationId = "LocationId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LocationNm;
        public const string PropertyNameLocationNm = "LocationNm";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CityCd;
        public const string PropertyNameCityCd = "CityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_StateCd;
        public const string PropertyNameStateCd = "StateCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ZoneCd;
        public const string PropertyNameZoneCd = "ZoneCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<AcquisitionLocation> m_AcquisitionLocationCollection = new List<AcquisitionLocation>();

        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("AcquisitionLocation", IsNullable = false)]
        [DebuggerHidden]

        public virtual IList<AcquisitionLocation> AcquisitionLocationCollection
        {
            get { return m_AcquisitionLocationCollection; }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int LocationId
        {
            set
            {
                if (m_LocationId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLocationId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LocationId = value;
                    OnPropertyChanged(PropertyNameLocationId);
                }
            }
            get
            {
                return m_LocationId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LocationNm
        {
            set
            {
                if (String.Equals(m_LocationNm, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLocationNm, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LocationNm = value;
                    OnPropertyChanged(PropertyNameLocationNm);
                }
            }
            get
            {
                return m_LocationNm;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CityCd
        {
            set
            {
                if (String.Equals(m_CityCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCityCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CityCd = value;
                    OnPropertyChanged(PropertyNameCityCd);
                }
            }
            get
            {
                return m_CityCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string StateCd
        {
            set
            {
                if (String.Equals(m_StateCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStateCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_StateCd = value;
                    OnPropertyChanged(PropertyNameStateCd);
                }
            }
            get
            {
                return m_StateCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ZoneCd
        {
            set
            {
                if (String.Equals(m_ZoneCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameZoneCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ZoneCd = value;
                    OnPropertyChanged(PropertyNameZoneCd);
                }
            }
            get
            {
                return m_ZoneCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Subject", Namespace = Strings.DefaultNamespace)]
    public partial class Subject
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SubjectCd;
        public const string PropertyNameSubjectCd = "SubjectCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighEduLevelCd;
        public const string PropertyNameHighEduLevelCd = "HighEduLevelCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SubjectDescription;
        public const string PropertyNameSubjectDescription = "SubjectDescription";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SubjectCd
        {
            set
            {
                if (String.Equals(m_SubjectCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSubjectCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SubjectCd = value;
                    OnPropertyChanged(PropertyNameSubjectCd);
                }
            }
            get
            {
                return m_SubjectCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string HighEduLevelCd
        {
            set
            {
                if (String.Equals(m_HighEduLevelCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameHighEduLevelCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_HighEduLevelCd = value;
                    OnPropertyChanged(PropertyNameHighEduLevelCd);
                }
            }
            get
            {
                return m_HighEduLevelCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string SubjectDescription
        {
            set
            {
                if (String.Equals(m_SubjectDescription, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSubjectDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SubjectDescription = value;
                    OnPropertyChanged(PropertyNameSubjectDescription);
                }
            }
            get
            {
                return m_SubjectDescription;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("SubjectGrade", Namespace = Strings.DefaultNamespace)]
    public partial class SubjectGrade
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GradeCd;
        public const string PropertyNameGradeCd = "GradeCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GradeDescription;
        public const string PropertyNameGradeDescription = "GradeDescription";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Ranking;
        public const string PropertyNameRanking = "Ranking";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ActiveInd;
        public const string PropertyNameActiveInd = "ActiveInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDt;
        public const string PropertyNameCreatedDt = "CreatedDt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDt;
        public const string PropertyNameLastModifiedDt = "LastModifiedDt";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GradeCd
        {
            set
            {
                if (String.Equals(m_GradeCd, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGradeCd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GradeCd = value;
                    OnPropertyChanged(PropertyNameGradeCd);
                }
            }
            get
            {
                return m_GradeCd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string GradeDescription
        {
            set
            {
                if (String.Equals(m_GradeDescription, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGradeDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_GradeDescription = value;
                    OnPropertyChanged(PropertyNameGradeDescription);
                }
            }
            get
            {
                return m_GradeDescription;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Ranking
        {
            set
            {
                if (m_Ranking == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameRanking, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Ranking = value;
                    OnPropertyChanged(PropertyNameRanking);
                }
            }
            get
            {
                return m_Ranking;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool ActiveInd
        {
            set
            {
                if (m_ActiveInd == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameActiveInd, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ActiveInd = value;
                    OnPropertyChanged(PropertyNameActiveInd);
                }
            }
            get
            {
                return m_ActiveInd;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDt
        {
            set
            {
                if (m_CreatedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDt = value;
                    OnPropertyChanged(PropertyNameCreatedDt);
                }
            }
            get { return m_CreatedDt; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDt
        {
            set
            {
                if (m_LastModifiedDt == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDt = value;
                    OnPropertyChanged(PropertyNameLastModifiedDt);
                }
            }
            get { return m_LastModifiedDt; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("Advertisment", Namespace = Strings.DefaultNamespace)]
    public partial class Advertisment
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Title;
        public const string PropertyNameTitle = "Title";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ShortDescription;
        public const string PropertyNameShortDescription = "ShortDescription";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Description;
        public const string PropertyNameDescription = "Description";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Code;
        public const string PropertyNameCode = "Code";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ServiceCode;
        public const string PropertyNameServiceCode = "ServiceCode";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_IntakeLocationId;
        public const string PropertyNameIntakeLocationId = "IntakeLocationId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_InterviewLocationId;
        public const string PropertyNameInterviewLocationId = "InterviewLocationId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_IsActive;
        public const string PropertyNameIsActive = "IsActive";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_IsApplied;
        public const string PropertyNameIsApplied = "IsApplied";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_StartDate;
        public const string PropertyNameStartDate = "StartDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_EndDate;
        public const string PropertyNameEndDate = "EndDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDate;
        public const string PropertyNameCreatedDate = "CreatedDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDate;
        public const string PropertyNameLastModifiedDate = "LastModifiedDate";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Id
        {
            set
            {
                if (m_Id == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Id = value;
                    OnPropertyChanged(PropertyNameId);
                }
            }
            get
            {
                return m_Id;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int AcquisitionId
        {
            set
            {
                if (m_AcquisitionId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAcquisitionId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AcquisitionId = value;
                    OnPropertyChanged(PropertyNameAcquisitionId);
                }
            }
            get
            {
                return m_AcquisitionId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Title
        {
            set
            {
                if (String.Equals(m_Title, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTitle, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Title = value;
                    OnPropertyChanged(PropertyNameTitle);
                }
            }
            get
            {
                return m_Title;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ShortDescription
        {
            set
            {
                if (String.Equals(m_ShortDescription, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameShortDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ShortDescription = value;
                    OnPropertyChanged(PropertyNameShortDescription);
                }
            }
            get
            {
                return m_ShortDescription;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Description
        {
            set
            {
                if (String.Equals(m_Description, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDescription, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Description = value;
                    OnPropertyChanged(PropertyNameDescription);
                }
            }
            get
            {
                return m_Description;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Code
        {
            set
            {
                if (String.Equals(m_Code, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCode, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Code = value;
                    OnPropertyChanged(PropertyNameCode);
                }
            }
            get
            {
                return m_Code;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string ServiceCode
        {
            set
            {
                if (String.Equals(m_ServiceCode, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameServiceCode, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ServiceCode = value;
                    OnPropertyChanged(PropertyNameServiceCode);
                }
            }
            get
            {
                return m_ServiceCode;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int IntakeLocationId
        {
            set
            {
                if (m_IntakeLocationId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIntakeLocationId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IntakeLocationId = value;
                    OnPropertyChanged(PropertyNameIntakeLocationId);
                }
            }
            get
            {
                return m_IntakeLocationId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int InterviewLocationId
        {
            set
            {
                if (m_InterviewLocationId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameInterviewLocationId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_InterviewLocationId = value;
                    OnPropertyChanged(PropertyNameInterviewLocationId);
                }
            }
            get
            {
                return m_InterviewLocationId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool IsActive
        {
            set
            {
                if (m_IsActive == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIsActive, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IsActive = value;
                    OnPropertyChanged(PropertyNameIsActive);
                }
            }
            get
            {
                return m_IsActive;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool IsApplied
        {
            set
            {
                if (m_IsApplied == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIsApplied, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IsApplied = value;
                    OnPropertyChanged(PropertyNameIsApplied);
                }
            }
            get
            {
                return m_IsApplied;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? StartDate
        {
            set
            {
                if (m_StartDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStartDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_StartDate = value;
                    OnPropertyChanged(PropertyNameStartDate);
                }
            }
            get { return m_StartDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? EndDate
        {
            set
            {
                if (m_EndDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameEndDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_EndDate = value;
                    OnPropertyChanged(PropertyNameEndDate);
                }
            }
            get { return m_EndDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDate
        {
            set
            {
                if (m_CreatedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDate = value;
                    OnPropertyChanged(PropertyNameCreatedDate);
                }
            }
            get { return m_CreatedDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDate
        {
            set
            {
                if (m_LastModifiedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDate = value;
                    OnPropertyChanged(PropertyNameLastModifiedDate);
                }
            }
            get { return m_LastModifiedDate; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("InterviewLocation", Namespace = Strings.DefaultNamespace)]
    public partial class InterviewLocation
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Code;
        public const string PropertyNameCode = "Code";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Name;
        public const string PropertyNameName = "Name";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDate;
        public const string PropertyNameCreatedDate = "CreatedDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDate;
        public const string PropertyNameLastModifiedDate = "LastModifiedDate";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Id
        {
            set
            {
                if (m_Id == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Id = value;
                    OnPropertyChanged(PropertyNameId);
                }
            }
            get
            {
                return m_Id;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Code
        {
            set
            {
                if (String.Equals(m_Code, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCode, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Code = value;
                    OnPropertyChanged(PropertyNameCode);
                }
            }
            get
            {
                return m_Code;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Name
        {
            set
            {
                if (String.Equals(m_Name, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Name = value;
                    OnPropertyChanged(PropertyNameName);
                }
            }
            get
            {
                return m_Name;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDate
        {
            set
            {
                if (m_CreatedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDate = value;
                    OnPropertyChanged(PropertyNameCreatedDate);
                }
            }
            get { return m_CreatedDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDate
        {
            set
            {
                if (m_LastModifiedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDate = value;
                    OnPropertyChanged(PropertyNameLastModifiedDate);
                }
            }
            get { return m_LastModifiedDate; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("IntakeLocation", Namespace = Strings.DefaultNamespace)]
    public partial class IntakeLocation
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Code;
        public const string PropertyNameCode = "Code";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Name;
        public const string PropertyNameName = "Name";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDate;
        public const string PropertyNameCreatedDate = "CreatedDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDate;
        public const string PropertyNameLastModifiedDate = "LastModifiedDate";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Id
        {
            set
            {
                if (m_Id == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Id = value;
                    OnPropertyChanged(PropertyNameId);
                }
            }
            get
            {
                return m_Id;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Code
        {
            set
            {
                if (String.Equals(m_Code, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCode, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Code = value;
                    OnPropertyChanged(PropertyNameCode);
                }
            }
            get
            {
                return m_Code;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Name
        {
            set
            {
                if (String.Equals(m_Name, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Name = value;
                    OnPropertyChanged(PropertyNameName);
                }
            }
            get
            {
                return m_Name;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDate
        {
            set
            {
                if (m_CreatedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDate = value;
                    OnPropertyChanged(PropertyNameCreatedDate);
                }
            }
            get { return m_CreatedDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDate
        {
            set
            {
                if (m_LastModifiedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDate = value;
                    OnPropertyChanged(PropertyNameLastModifiedDate);
                }
            }
            get { return m_LastModifiedDate; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ExistingMember", Namespace = Strings.DefaultNamespace)]
    public partial class ExistingMember
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_CoId;
        public const string PropertyNameCoId = "CoId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ArmyNo;
        public const string PropertyNameArmyNo = "ArmyNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_IdNumber;
        public const string PropertyNameIdNumber = "IdNumber";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Name;
        public const string PropertyNameName = "Name";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Status;
        public const string PropertyNameStatus = "Status";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDate;
        public const string PropertyNameCreatedDate = "CreatedDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDate;
        public const string PropertyNameLastModifiedDate = "LastModifiedDate";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int CoId
        {
            set
            {
                if (m_CoId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCoId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CoId = value;
                    OnPropertyChanged(PropertyNameCoId);
                }
            }
            get
            {
                return m_CoId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ArmyNo
        {
            set
            {
                if (m_ArmyNo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameArmyNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ArmyNo = value;
                    OnPropertyChanged(PropertyNameArmyNo);
                }
            }
            get
            {
                return m_ArmyNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string IdNumber
        {
            set
            {
                if (String.Equals(m_IdNumber, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIdNumber, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IdNumber = value;
                    OnPropertyChanged(PropertyNameIdNumber);
                }
            }
            get
            {
                return m_IdNumber;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Name
        {
            set
            {
                if (String.Equals(m_Name, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Name = value;
                    OnPropertyChanged(PropertyNameName);
                }
            }
            get
            {
                return m_Name;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Status
        {
            set
            {
                if (String.Equals(m_Status, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStatus, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Status = value;
                    OnPropertyChanged(PropertyNameStatus);
                }
            }
            get
            {
                return m_Status;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDate
        {
            set
            {
                if (m_CreatedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDate = value;
                    OnPropertyChanged(PropertyNameCreatedDate);
                }
            }
            get { return m_CreatedDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDate
        {
            set
            {
                if (m_LastModifiedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDate = value;
                    OnPropertyChanged(PropertyNameLastModifiedDate);
                }
            }
            get { return m_LastModifiedDate; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantPhoto", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantPhoto
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PhotoExt;
        public const string PropertyNamePhotoExt = "PhotoExt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private byte[] m_Photo;
        public const string PropertyNamePhoto = "Photo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDate;
        public const string PropertyNameCreatedDate = "CreatedDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDate;
        public const string PropertyNameLastModifiedDate = "LastModifiedDate";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Id
        {
            set
            {
                if (m_Id == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Id = value;
                    OnPropertyChanged(PropertyNameId);
                }
            }
            get
            {
                return m_Id;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PhotoExt
        {
            set
            {
                if (String.Equals(m_PhotoExt, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePhotoExt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PhotoExt = value;
                    OnPropertyChanged(PropertyNamePhotoExt);
                }
            }
            get
            {
                return m_PhotoExt;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual byte[] Photo
        {
            set
            {
                if (m_Photo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePhoto, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Photo = value;
                    OnPropertyChanged(PropertyNamePhoto);
                }
            }
            get { return m_Photo; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDate
        {
            set
            {
                if (m_CreatedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDate = value;
                    OnPropertyChanged(PropertyNameCreatedDate);
                }
            }
            get { return m_CreatedDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDate
        {
            set
            {
                if (m_LastModifiedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDate = value;
                    OnPropertyChanged(PropertyNameLastModifiedDate);
                }
            }
            get { return m_LastModifiedDate; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [Serializable]
    [XmlType("ApplicantSubmittedPhoto", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantSubmittedPhoto
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PhotoExt;
        public const string PropertyNamePhotoExt = "PhotoExt";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_LastModifiedBy;
        public const string PropertyNameLastModifiedBy = "LastModifiedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private byte[] m_Photo;
        public const string PropertyNamePhoto = "Photo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDate;
        public const string PropertyNameCreatedDate = "CreatedDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastModifiedDate;
        public const string PropertyNameLastModifiedDate = "LastModifiedDate";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int Id
        {
            set
            {
                if (m_Id == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Id = value;
                    OnPropertyChanged(PropertyNameId);
                }
            }
            get
            {
                return m_Id;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual int ApplicantId
        {
            set
            {
                if (m_ApplicantId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantId = value;
                    OnPropertyChanged(PropertyNameApplicantId);
                }
            }
            get
            {
                return m_ApplicantId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string PhotoExt
        {
            set
            {
                if (String.Equals(m_PhotoExt, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePhotoExt, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PhotoExt = value;
                    OnPropertyChanged(PropertyNamePhotoExt);
                }
            }
            get
            {
                return m_PhotoExt;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string CreatedBy
        {
            set
            {
                if (String.Equals(m_CreatedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedBy = value;
                    OnPropertyChanged(PropertyNameCreatedBy);
                }
            }
            get
            {
                return m_CreatedBy;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string LastModifiedBy
        {
            set
            {
                if (String.Equals(m_LastModifiedBy, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedBy, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedBy = value;
                    OnPropertyChanged(PropertyNameLastModifiedBy);
                }
            }
            get
            {
                return m_LastModifiedBy;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual byte[] Photo
        {
            set
            {
                if (m_Photo == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePhoto, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Photo = value;
                    OnPropertyChanged(PropertyNamePhoto);
                }
            }
            get { return m_Photo; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? CreatedDate
        {
            set
            {
                if (m_CreatedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCreatedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CreatedDate = value;
                    OnPropertyChanged(PropertyNameCreatedDate);
                }
            }
            get { return m_CreatedDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public virtual DateTime? LastModifiedDate
        {
            set
            {
                if (m_LastModifiedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastModifiedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastModifiedDate = value;
                    OnPropertyChanged(PropertyNameLastModifiedDate);
                }
            }
            get { return m_LastModifiedDate; }
        }



    }

}

