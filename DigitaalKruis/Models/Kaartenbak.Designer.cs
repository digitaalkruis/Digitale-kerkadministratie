﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace DigitaalKruis.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class KaartenbakEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new KaartenbakEntities object using the connection string found in the 'KaartenbakEntities' section of the application configuration file.
        /// </summary>
        public KaartenbakEntities() : base("name=KaartenbakEntities", "KaartenbakEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new KaartenbakEntities object.
        /// </summary>
        public KaartenbakEntities(string connectionString) : base(connectionString, "KaartenbakEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new KaartenbakEntities object.
        /// </summary>
        public KaartenbakEntities(EntityConnection connection) : base(connection, "KaartenbakEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Contact> Contacts
        {
            get
            {
                if ((_Contacts == null))
                {
                    _Contacts = base.CreateObjectSet<Contact>("Contacts");
                }
                return _Contacts;
            }
        }
        private ObjectSet<Contact> _Contacts;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Contacts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContacts(Contact contact)
        {
            base.AddObject("Contacts", contact);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="KaartenbakModel", Name="Contact")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contact : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contact object.
        /// </summary>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="passwordHash">Initial value of the PasswordHash property.</param>
        /// <param name="passwordSalt">Initial value of the PasswordSalt property.</param>
        /// <param name="contactID">Initial value of the ContactID property.</param>
        public static Contact CreateContact(global::System.String firstName, global::System.String lastName, global::System.String passwordHash, global::System.String passwordSalt, global::System.Int32 contactID)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.PasswordHash = passwordHash;
            contact.PasswordSalt = passwordSalt;
            contact.ContactID = contactID;
            return contact;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Prefix
        {
            get
            {
                return _Prefix;
            }
            set
            {
                OnPrefixChanging(value);
                ReportPropertyChanging("Prefix");
                _Prefix = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Prefix");
                OnPrefixChanged();
            }
        }
        private global::System.String _Prefix;
        partial void OnPrefixChanging(global::System.String value);
        partial void OnPrefixChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PasswordHash
        {
            get
            {
                return _PasswordHash;
            }
            set
            {
                OnPasswordHashChanging(value);
                ReportPropertyChanging("PasswordHash");
                _PasswordHash = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PasswordHash");
                OnPasswordHashChanged();
            }
        }
        private global::System.String _PasswordHash;
        partial void OnPasswordHashChanging(global::System.String value);
        partial void OnPasswordHashChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PasswordSalt
        {
            get
            {
                return _PasswordSalt;
            }
            set
            {
                OnPasswordSaltChanging(value);
                ReportPropertyChanging("PasswordSalt");
                _PasswordSalt = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PasswordSalt");
                OnPasswordSaltChanged();
            }
        }
        private global::System.String _PasswordSalt;
        partial void OnPasswordSaltChanging(global::System.String value);
        partial void OnPasswordSaltChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ContactID
        {
            get
            {
                return _ContactID;
            }
            set
            {
                if (_ContactID != value)
                {
                    OnContactIDChanging(value);
                    ReportPropertyChanging("ContactID");
                    _ContactID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ContactID");
                    OnContactIDChanged();
                }
            }
        }
        private global::System.Int32 _ContactID;
        partial void OnContactIDChanging(global::System.Int32 value);
        partial void OnContactIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Birthdate
        {
            get
            {
                return _Birthdate;
            }
            set
            {
                OnBirthdateChanging(value);
                ReportPropertyChanging("Birthdate");
                _Birthdate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Birthdate");
                OnBirthdateChanged();
            }
        }
        private Nullable<global::System.DateTime> _Birthdate;
        partial void OnBirthdateChanging(Nullable<global::System.DateTime> value);
        partial void OnBirthdateChanged();

        #endregion
    
    }

    #endregion
    
}
