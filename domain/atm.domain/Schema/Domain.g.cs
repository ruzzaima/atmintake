
using System;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Diagnostics;

namespace SevenH.MMCSB.Atm.Domain
{

    ///<summary>
    /// 
    ///</summary>
    [DataObject(true)]
    [Serializable]
    [XmlType("Address", Namespace = Strings.DefaultNamespace)]
    public partial class Address
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Address1;
        public const string PropertyNameAddress1 = "Address1";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Address2;
        public const string PropertyNameAddress2 = "Address2";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Address3;
        public const string PropertyNameAddress3 = "Address3";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_City;
        public const string PropertyNameCity = "City";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_CityId;
        public const string PropertyNameCityId = "CityId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Postcode;
        public const string PropertyNamePostcode = "Postcode";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_State;
        public const string PropertyNameState = "State";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_StateId;
        public const string PropertyNameStateId = "StateId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Country;
        public const string PropertyNameCountry = "Country";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_CountryId;
        public const string PropertyNameCountryId = "CountryId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MobilePhoneNo;
        public const string PropertyNameMobilePhoneNo = "MobilePhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PhoneNo;
        public const string PropertyNamePhoneNo = "PhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FaxNo;
        public const string PropertyNameFaxNo = "FaxNo";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public int Id
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

        public string Address1
        {
            set
            {
                if (String.Equals(m_Address1, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAddress1, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Address1 = value;
                    OnPropertyChanged(PropertyNameAddress1);
                }
            }
            get
            {
                return m_Address1;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Address2
        {
            set
            {
                if (String.Equals(m_Address2, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAddress2, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Address2 = value;
                    OnPropertyChanged(PropertyNameAddress2);
                }
            }
            get
            {
                return m_Address2;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Address3
        {
            set
            {
                if (String.Equals(m_Address3, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAddress3, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Address3 = value;
                    OnPropertyChanged(PropertyNameAddress3);
                }
            }
            get
            {
                return m_Address3;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string City
        {
            set
            {
                if (String.Equals(m_City, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCity, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_City = value;
                    OnPropertyChanged(PropertyNameCity);
                }
            }
            get
            {
                return m_City;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public int CityId
        {
            set
            {
                if (m_CityId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCityId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CityId = value;
                    OnPropertyChanged(PropertyNameCityId);
                }
            }
            get
            {
                return m_CityId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Postcode
        {
            set
            {
                if (String.Equals(m_Postcode, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePostcode, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Postcode = value;
                    OnPropertyChanged(PropertyNamePostcode);
                }
            }
            get
            {
                return m_Postcode;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string State
        {
            set
            {
                if (String.Equals(m_State, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameState, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_State = value;
                    OnPropertyChanged(PropertyNameState);
                }
            }
            get
            {
                return m_State;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public int StateId
        {
            set
            {
                if (m_StateId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameStateId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_StateId = value;
                    OnPropertyChanged(PropertyNameStateId);
                }
            }
            get
            {
                return m_StateId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Country
        {
            set
            {
                if (String.Equals(m_Country, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCountry, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Country = value;
                    OnPropertyChanged(PropertyNameCountry);
                }
            }
            get
            {
                return m_Country;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public int CountryId
        {
            set
            {
                if (m_CountryId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameCountryId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_CountryId = value;
                    OnPropertyChanged(PropertyNameCountryId);
                }
            }
            get
            {
                return m_CountryId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string MobilePhoneNo
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

        public string PhoneNo
        {
            set
            {
                if (String.Equals(m_PhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PhoneNo = value;
                    OnPropertyChanged(PropertyNamePhoneNo);
                }
            }
            get
            {
                return m_PhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string FaxNo
        {
            set
            {
                if (String.Equals(m_FaxNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFaxNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FaxNo = value;
                    OnPropertyChanged(PropertyNameFaxNo);
                }
            }
            get
            {
                return m_FaxNo;
            }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [DataObject(true)]
    [Serializable]
    [XmlType("LoginUser", Namespace = Strings.DefaultNamespace)]
    public partial class LoginUser
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Salt;
        public const string PropertyNameSalt = "Salt";

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
        private string m_CreatedBy;
        public const string PropertyNameCreatedBy = "CreatedBy";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_IsLocked;
        public const string PropertyNameIsLocked = "IsLocked";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_IsAdmin;
        public const string PropertyNameIsAdmin = "IsAdmin";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_UserType;
        public const string PropertyNameUserType = "UserType";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_UserId;
        public const string PropertyNameUserId = "UserId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_TempId;
        public const string PropertyNameTempId = "TempId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AccountNo;
        public const string PropertyNameAccountNo = "AccountNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_UserToken;
        public const string PropertyNameUserToken = "UserToken";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Email;
        public const string PropertyNameEmail = "Email";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_CreatedDate;
        public const string PropertyNameCreatedDate = "CreatedDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_LastLoginDate;
        public const string PropertyNameLastLoginDate = "LastLoginDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_UpdatedDate;
        public const string PropertyNameUpdatedDate = "UpdatedDate";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Address m_Address
            = new Address();

        public const string PropertyNameAddress = "Address";
        [DebuggerHidden]

        public Address Address
        {
            get { return m_Address; }
            set
            {
                m_Address = value;
                OnPropertyChanged(PropertyNameAddress);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Biodata m_Biodata
            = new Biodata();

        public const string PropertyNameBiodata = "Biodata";
        [DebuggerHidden]

        public Biodata Biodata
        {
            get { return m_Biodata; }
            set
            {
                m_Biodata = value;
                OnPropertyChanged(PropertyNameBiodata);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ObjectCollection<LoginRole> m_LoginRoleCollection = new ObjectCollection<LoginRole>();


        ///<summary>
        /// 
        ///</summary>
        [XmlArrayItem("LoginRole", IsNullable = false)]
        [DebuggerHidden]

        public ObjectCollection<LoginRole> LoginRoleCollection
        {
            get { return m_LoginRoleCollection; }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Salt
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

        public string UserName
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

        public string Password
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

        public string Status
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

        public string CreatedBy
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

        public bool IsLocked
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

        public bool IsAdmin
        {
            set
            {
                if (m_IsAdmin == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIsAdmin, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IsAdmin = value;
                    OnPropertyChanged(PropertyNameIsAdmin);
                }
            }
            get
            {
                return m_IsAdmin;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string UserType
        {
            set
            {
                if (String.Equals(m_UserType, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameUserType, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_UserType = value;
                    OnPropertyChanged(PropertyNameUserType);
                }
            }
            get
            {
                return m_UserType;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string UserId
        {
            set
            {
                if (String.Equals(m_UserId, value, StringComparison.Ordinal)) return;
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

        public string TempId
        {
            set
            {
                if (String.Equals(m_TempId, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameTempId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_TempId = value;
                    OnPropertyChanged(PropertyNameTempId);
                }
            }
            get
            {
                return m_TempId;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string AccountNo
        {
            set
            {
                if (String.Equals(m_AccountNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameAccountNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_AccountNo = value;
                    OnPropertyChanged(PropertyNameAccountNo);
                }
            }
            get
            {
                return m_AccountNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string UserToken
        {
            set
            {
                if (String.Equals(m_UserToken, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameUserToken, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_UserToken = value;
                    OnPropertyChanged(PropertyNameUserToken);
                }
            }
            get
            {
                return m_UserToken;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Email
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

        public int Id
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
        [DebuggerHidden]

        public DateTime? CreatedDate
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

        public DateTime? LastLoginDate
        {
            set
            {
                if (m_LastLoginDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameLastLoginDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_LastLoginDate = value;
                    OnPropertyChanged(PropertyNameLastLoginDate);
                }
            }
            get { return m_LastLoginDate; }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public DateTime? UpdatedDate
        {
            set
            {
                if (m_UpdatedDate == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameUpdatedDate, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_UpdatedDate = value;
                    OnPropertyChanged(PropertyNameUpdatedDate);
                }
            }
            get { return m_UpdatedDate; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [DataObject(true)]
    [Serializable]
    [XmlType("Biodata", Namespace = Strings.DefaultNamespace)]
    public partial class Biodata
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_SalutationName;
        public const string PropertyNameSalutationName = "SalutationName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FullName;
        public const string PropertyNameFullName = "FullName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Email;
        public const string PropertyNameEmail = "Email";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_IDType;
        public const string PropertyNameIDType = "IDType";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_IDNumber;
        public const string PropertyNameIDNumber = "IDNumber";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PassportNo;
        public const string PropertyNamePassportNo = "PassportNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MobilePhoneNo;
        public const string PropertyNameMobilePhoneNo = "MobilePhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_PhoneNo;
        public const string PropertyNamePhoneNo = "PhoneNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_FaxNo;
        public const string PropertyNameFaxNo = "FaxNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Designation;
        public const string PropertyNameDesignation = "Designation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Department;
        public const string PropertyNameDepartment = "Department";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Nationality;
        public const string PropertyNameNationality = "Nationality";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        private DateTime? m_DateOfBirth;
        public const string PropertyNameDateOfBirth = "DateOfBirth";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string SalutationName
        {
            set
            {
                if (String.Equals(m_SalutationName, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameSalutationName, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_SalutationName = value;
                    OnPropertyChanged(PropertyNameSalutationName);
                }
            }
            get
            {
                return m_SalutationName;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string FullName
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

        public string Email
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

        public string IDType
        {
            set
            {
                if (String.Equals(m_IDType, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIDType, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IDType = value;
                    OnPropertyChanged(PropertyNameIDType);
                }
            }
            get
            {
                return m_IDType;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string IDNumber
        {
            set
            {
                if (String.Equals(m_IDNumber, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameIDNumber, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_IDNumber = value;
                    OnPropertyChanged(PropertyNameIDNumber);
                }
            }
            get
            {
                return m_IDNumber;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string PassportNo
        {
            set
            {
                if (String.Equals(m_PassportNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePassportNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PassportNo = value;
                    OnPropertyChanged(PropertyNamePassportNo);
                }
            }
            get
            {
                return m_PassportNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string MobilePhoneNo
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

        public string PhoneNo
        {
            set
            {
                if (String.Equals(m_PhoneNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePhoneNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_PhoneNo = value;
                    OnPropertyChanged(PropertyNamePhoneNo);
                }
            }
            get
            {
                return m_PhoneNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string FaxNo
        {
            set
            {
                if (String.Equals(m_FaxNo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameFaxNo, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_FaxNo = value;
                    OnPropertyChanged(PropertyNameFaxNo);
                }
            }
            get
            {
                return m_FaxNo;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Designation
        {
            set
            {
                if (String.Equals(m_Designation, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDesignation, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Designation = value;
                    OnPropertyChanged(PropertyNameDesignation);
                }
            }
            get
            {
                return m_Designation;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Department
        {
            set
            {
                if (String.Equals(m_Department, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDepartment, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Department = value;
                    OnPropertyChanged(PropertyNameDepartment);
                }
            }
            get
            {
                return m_Department;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Nationality
        {
            set
            {
                if (String.Equals(m_Nationality, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameNationality, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Nationality = value;
                    OnPropertyChanged(PropertyNameNationality);
                }
            }
            get
            {
                return m_Nationality;
            }
        }


        ///<summary>
        /// 
        ///</summary>
        [DebuggerHidden]

        public DateTime? DateOfBirth
        {
            set
            {
                if (m_DateOfBirth == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameDateOfBirth, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_DateOfBirth = value;
                    OnPropertyChanged(PropertyNameDateOfBirth);
                }
            }
            get { return m_DateOfBirth; }
        }



    }

    ///<summary>
    /// 
    ///</summary>
    [DataObject(true)]
    [Serializable]
    [XmlType("LoginRole", Namespace = Strings.DefaultNamespace)]
    public partial class LoginRole
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Role;
        public const string PropertyNameRole = "Role";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public string Role
        {
            set
            {
                if (String.Equals(m_Role, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameRole, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Role = value;
                    OnPropertyChanged(PropertyNameRole);
                }
            }
            get
            {
                return m_Role;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public int Id
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



    }

}

