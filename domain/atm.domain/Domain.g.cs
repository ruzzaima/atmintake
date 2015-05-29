
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

        public virtual string Address1
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

        public virtual string Address2
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

        public virtual string Address3
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

        public virtual string City
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

        public virtual int CityId
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

        public virtual string Postcode
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

        public virtual string State
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

        public virtual int StateId
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

        public virtual string Country
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

        public virtual int CountryId
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

        public virtual string PhoneNo
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

        public virtual string FaxNo
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

        public virtual Address Address
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

        public virtual Biodata Biodata
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

        public virtual ObjectCollection<LoginRole> LoginRoleCollection
        {
            get { return m_LoginRoleCollection; }
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

        public virtual bool IsAdmin
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

        public virtual string UserType
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

        public virtual string UserId
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

        public virtual string TempId
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

        public virtual string AccountNo
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

        public virtual string UserToken
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

        public virtual DateTime? LastLoginDate
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

        public virtual DateTime? UpdatedDate
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

        public virtual string SalutationName
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

        public virtual string IDType
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

        public virtual string IDNumber
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

        public virtual string PassportNo
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

        public virtual string PhoneNo
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

        public virtual string FaxNo
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

        public virtual string Designation
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

        public virtual string Department
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

        public virtual string Nationality
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

        public virtual DateTime? DateOfBirth
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
        private string m_NoOfSibling;
        public const string PropertyNameNoOfSibling = "NoOfSibling";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomName;
        public const string PropertyNameMomName = "MomName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomICNo;
        public const string PropertyNameMomICNo = "MomICNo";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomNationalityCd;
        public const string PropertyNameMomNationalityCd = "MomNationalityCd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomOccupation;
        public const string PropertyNameMomOccupation = "MomOccupation";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_MomSalary;
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
        private string m_GuardianName;
        public const string PropertyNameGuardianName = "GuardianName";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_GuardianICNo;
        public const string PropertyNameGuardianICNo = "GuardianICNo";

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
        private string m_Photo;
        public const string PropertyNamePhoto = "Photo";

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
        private bool m_PalapesInd;
        public const string PropertyNamePalapesInd = "PalapesInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_PalapesYear;
        public const string PropertyNamePalapesYear = "PalapesYear";

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
        private bool m_ScholarshipInd;
        public const string PropertyNameScholarshipInd = "ScholarshipInd";

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
        private bool m_ArmySelectionInd;
        public const string PropertyNameArmySelectionInd = "ArmySelectionInd";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_ArmySelectionVenue;
        public const string PropertyNameArmySelectionVenue = "ArmySelectionVenue";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_ArmyServiceInd;
        public const string PropertyNameArmyServiceInd = "ArmyServiceInd";

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
        private bool m_CrimeInvolvement;
        public const string PropertyNameCrimeInvolvement = "CrimeInvolvement";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool m_DrugCaseInvolvement;
        public const string PropertyNameDrugCaseInvolvement = "DrugCaseInvolvement";

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

        public virtual string NoOfSibling
        {
            set
            {
                if (String.Equals(m_NoOfSibling, value, StringComparison.Ordinal)) return;
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

        public virtual string MomSalary
        {
            set
            {
                if (String.Equals(m_MomSalary, value, StringComparison.Ordinal)) return;
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

        public virtual string Photo
        {
            set
            {
                if (String.Equals(m_Photo, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNamePhoto, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Photo = value;
                    OnPropertyChanged(PropertyNamePhoto);
                }
            }
            get
            {
                return m_Photo;
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

        public virtual bool PalapesInd
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
            get
            {
                return m_PalapesInd;
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

        public virtual bool ScholarshipInd
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
            get
            {
                return m_ScholarshipInd;
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

        public virtual bool ArmySelectionInd
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
            get
            {
                return m_ArmySelectionInd;
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

        public virtual bool ArmyServiceInd
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
            get
            {
                return m_ArmyServiceInd;
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

        public virtual bool CrimeInvolvement
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
            get
            {
                return m_CrimeInvolvement;
            }
        }

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual bool DrugCaseInvolvement
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
            get
            {
                return m_DrugCaseInvolvement;
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



    }

    ///<summary>
    /// 
    ///</summary>
    [DataObject(true)]
    [Serializable]
    [XmlType("ApplicantEducation", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantEducation
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantEduId;
        public const string PropertyNameApplicantEduId = "ApplicantEduId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantEId;
        public const string PropertyNameApplicantEId = "ApplicantEId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_HighEduLevelCd;
        public const string PropertyNameHighEduLevelCd = "HighEduLevelCd";

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

        public virtual int ApplicantEId
        {
            set
            {
                if (m_ApplicantEId == value) return;
                var arg = new PropertyChangingEventArgs(PropertyNameApplicantEId, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_ApplicantEId = value;
                    OnPropertyChanged(PropertyNameApplicantEId);
                }
            }
            get
            {
                return m_ApplicantEId;
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
    [DataObject(true)]
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
    [DataObject(true)]
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
    [DataObject(true)]
    [Serializable]
    [XmlType("ApplicantSport", Namespace = Strings.DefaultNamespace)]
    public partial class ApplicantSport
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantSportAssocId;
        public const string PropertyNameApplicantSportAssocId = "ApplicantSportAssocId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_ApplicantId;
        public const string PropertyNameApplicantId = "ApplicantId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AchievementCd;
        public const string PropertyNameAchievementCd = "AchievementCd";

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
    [DataObject(true)]
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
    [DataObject(true)]
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



    }

    ///<summary>
    /// 
    ///</summary>
    [DataObject(true)]
    [Serializable]
    [XmlType("Acquisition", Namespace = Strings.DefaultNamespace)]
    public partial class Acquisition
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_AcquisitionId;
        public const string PropertyNameAcquisitionId = "AcquisitionId";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_AcquisitionTypeCd;
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

        public virtual string AcquisitionTypeCd
        {
            set
            {
                if (String.Equals(m_AcquisitionTypeCd, value, StringComparison.Ordinal)) return;
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
    [DataObject(true)]
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
        private int m_AgeAt;
        public const string PropertyNameAgeAt = "AgeAt";

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

        public virtual int AgeAt
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
            get
            {
                return m_AgeAt;
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



    }

    ///<summary>
    /// 
    ///</summary>
    [DataObject(true)]
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
    [DataObject(true)]
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

        public virtual string Role
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



    }

    ///<summary>
    /// 
    ///</summary>
    [DataObject(true)]
    [Serializable]
    [XmlType("CodeItem", Namespace = Strings.DefaultNamespace)]
    public partial class CodeItem
    {


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Grouping;
        public const string PropertyNameGrouping = "Grouping";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Description;
        public const string PropertyNameDescription = "Description";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string m_Code;
        public const string PropertyNameCode = "Code";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int m_Id;
        public const string PropertyNameId = "Id";

        ///<summary>
        /// 
        ///</summary>
        [XmlAttribute]
        [DebuggerHidden]

        public virtual string Grouping
        {
            set
            {
                if (String.Equals(m_Grouping, value, StringComparison.Ordinal)) return;
                var arg = new PropertyChangingEventArgs(PropertyNameGrouping, value);
                OnPropertyChanging(arg);
                if (!arg.Cancel)
                {
                    m_Grouping = value;
                    OnPropertyChanged(PropertyNameGrouping);
                }
            }
            get
            {
                return m_Grouping;
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



    }

}

