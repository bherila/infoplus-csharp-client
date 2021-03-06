using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infoplus.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class LocationAddressScheme :  IEquatable<LocationAddressScheme>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationAddressScheme" /> class.
        /// Initializes a new instance of the <see cref="LocationAddressScheme" />class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="FormatString">FormatString (required).</param>
        /// <param name="LocationNamingScheme">LocationNamingScheme (required).</param>
        /// <param name="LocationNumberZeroPadded">LocationNumberZeroPadded (required) (default to false).</param>
        /// <param name="LocationNumberMinimumNumberOfDigits">LocationNumberMinimumNumberOfDigits.</param>
        /// <param name="LevelNamingScheme">LevelNamingScheme (required).</param>
        /// <param name="LevelNumberZeroPadded">LevelNumberZeroPadded (required) (default to false).</param>
        /// <param name="LevelNumberMinimumNumberOfDigits">LevelNumberMinimumNumberOfDigits.</param>
        /// <param name="AisleNamingScheme">AisleNamingScheme (required).</param>
        /// <param name="AisleNumberZeroPadded">AisleNumberZeroPadded (required) (default to false).</param>
        /// <param name="AisleNumberMinimumNumberOfDigits">AisleNumberMinimumNumberOfDigits.</param>
        /// <param name="BayNamingScheme">BayNamingScheme.</param>
        /// <param name="BayNumberZeroPadded">BayNumberZeroPadded (default to false).</param>
        /// <param name="BayNumberMinimumNumberOfDigits">BayNumberMinimumNumberOfDigits.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public LocationAddressScheme(string Name = null, string FormatString = null, string LocationNamingScheme = null, bool? LocationNumberZeroPadded = null, int? LocationNumberMinimumNumberOfDigits = null, string LevelNamingScheme = null, bool? LevelNumberZeroPadded = null, int? LevelNumberMinimumNumberOfDigits = null, string AisleNamingScheme = null, bool? AisleNumberZeroPadded = null, int? AisleNumberMinimumNumberOfDigits = null, string BayNamingScheme = null, bool? BayNumberZeroPadded = null, int? BayNumberMinimumNumberOfDigits = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for LocationAddressScheme and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "FormatString" is required (not null)
            if (FormatString == null)
            {
                throw new InvalidDataException("FormatString is a required property for LocationAddressScheme and cannot be null");
            }
            else
            {
                this.FormatString = FormatString;
            }
            // to ensure "LocationNamingScheme" is required (not null)
            if (LocationNamingScheme == null)
            {
                throw new InvalidDataException("LocationNamingScheme is a required property for LocationAddressScheme and cannot be null");
            }
            else
            {
                this.LocationNamingScheme = LocationNamingScheme;
            }
            // to ensure "LocationNumberZeroPadded" is required (not null)
            if (LocationNumberZeroPadded == null)
            {
                throw new InvalidDataException("LocationNumberZeroPadded is a required property for LocationAddressScheme and cannot be null");
            }
            else
            {
                this.LocationNumberZeroPadded = LocationNumberZeroPadded;
            }
            // to ensure "LevelNamingScheme" is required (not null)
            if (LevelNamingScheme == null)
            {
                throw new InvalidDataException("LevelNamingScheme is a required property for LocationAddressScheme and cannot be null");
            }
            else
            {
                this.LevelNamingScheme = LevelNamingScheme;
            }
            // to ensure "LevelNumberZeroPadded" is required (not null)
            if (LevelNumberZeroPadded == null)
            {
                throw new InvalidDataException("LevelNumberZeroPadded is a required property for LocationAddressScheme and cannot be null");
            }
            else
            {
                this.LevelNumberZeroPadded = LevelNumberZeroPadded;
            }
            // to ensure "AisleNamingScheme" is required (not null)
            if (AisleNamingScheme == null)
            {
                throw new InvalidDataException("AisleNamingScheme is a required property for LocationAddressScheme and cannot be null");
            }
            else
            {
                this.AisleNamingScheme = AisleNamingScheme;
            }
            // to ensure "AisleNumberZeroPadded" is required (not null)
            if (AisleNumberZeroPadded == null)
            {
                throw new InvalidDataException("AisleNumberZeroPadded is a required property for LocationAddressScheme and cannot be null");
            }
            else
            {
                this.AisleNumberZeroPadded = AisleNumberZeroPadded;
            }
            this.LocationNumberMinimumNumberOfDigits = LocationNumberMinimumNumberOfDigits;
            this.LevelNumberMinimumNumberOfDigits = LevelNumberMinimumNumberOfDigits;
            this.AisleNumberMinimumNumberOfDigits = AisleNumberMinimumNumberOfDigits;
            this.BayNamingScheme = BayNamingScheme;
            // use default value if no "BayNumberZeroPadded" provided
            if (BayNumberZeroPadded == null)
            {
                this.BayNumberZeroPadded = false;
            }
            else
            {
                this.BayNumberZeroPadded = BayNumberZeroPadded;
            }
            this.BayNumberMinimumNumberOfDigits = BayNumberMinimumNumberOfDigits;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public int? ClientId { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets FormatString
        /// </summary>
        [DataMember(Name="formatString", EmitDefaultValue=false)]
        public string FormatString { get; set; }
    
        /// <summary>
        /// Gets or Sets LocationNamingScheme
        /// </summary>
        [DataMember(Name="locationNamingScheme", EmitDefaultValue=false)]
        public string LocationNamingScheme { get; set; }
    
        /// <summary>
        /// Gets or Sets LocationNumberZeroPadded
        /// </summary>
        [DataMember(Name="locationNumberZeroPadded", EmitDefaultValue=false)]
        public bool? LocationNumberZeroPadded { get; set; }
    
        /// <summary>
        /// Gets or Sets LocationNumberMinimumNumberOfDigits
        /// </summary>
        [DataMember(Name="locationNumberMinimumNumberOfDigits", EmitDefaultValue=false)]
        public int? LocationNumberMinimumNumberOfDigits { get; set; }
    
        /// <summary>
        /// Gets or Sets LevelNamingScheme
        /// </summary>
        [DataMember(Name="levelNamingScheme", EmitDefaultValue=false)]
        public string LevelNamingScheme { get; set; }
    
        /// <summary>
        /// Gets or Sets LevelNumberZeroPadded
        /// </summary>
        [DataMember(Name="levelNumberZeroPadded", EmitDefaultValue=false)]
        public bool? LevelNumberZeroPadded { get; set; }
    
        /// <summary>
        /// Gets or Sets LevelNumberMinimumNumberOfDigits
        /// </summary>
        [DataMember(Name="levelNumberMinimumNumberOfDigits", EmitDefaultValue=false)]
        public int? LevelNumberMinimumNumberOfDigits { get; set; }
    
        /// <summary>
        /// Gets or Sets AisleNamingScheme
        /// </summary>
        [DataMember(Name="aisleNamingScheme", EmitDefaultValue=false)]
        public string AisleNamingScheme { get; set; }
    
        /// <summary>
        /// Gets or Sets AisleNumberZeroPadded
        /// </summary>
        [DataMember(Name="aisleNumberZeroPadded", EmitDefaultValue=false)]
        public bool? AisleNumberZeroPadded { get; set; }
    
        /// <summary>
        /// Gets or Sets AisleNumberMinimumNumberOfDigits
        /// </summary>
        [DataMember(Name="aisleNumberMinimumNumberOfDigits", EmitDefaultValue=false)]
        public int? AisleNumberMinimumNumberOfDigits { get; set; }
    
        /// <summary>
        /// Gets or Sets BayNamingScheme
        /// </summary>
        [DataMember(Name="bayNamingScheme", EmitDefaultValue=false)]
        public string BayNamingScheme { get; set; }
    
        /// <summary>
        /// Gets or Sets BayNumberZeroPadded
        /// </summary>
        [DataMember(Name="bayNumberZeroPadded", EmitDefaultValue=false)]
        public bool? BayNumberZeroPadded { get; set; }
    
        /// <summary>
        /// Gets or Sets BayNumberMinimumNumberOfDigits
        /// </summary>
        [DataMember(Name="bayNumberMinimumNumberOfDigits", EmitDefaultValue=false)]
        public int? BayNumberMinimumNumberOfDigits { get; set; }
    
        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; private set; }
    
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationAddressScheme {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FormatString: ").Append(FormatString).Append("\n");
            sb.Append("  LocationNamingScheme: ").Append(LocationNamingScheme).Append("\n");
            sb.Append("  LocationNumberZeroPadded: ").Append(LocationNumberZeroPadded).Append("\n");
            sb.Append("  LocationNumberMinimumNumberOfDigits: ").Append(LocationNumberMinimumNumberOfDigits).Append("\n");
            sb.Append("  LevelNamingScheme: ").Append(LevelNamingScheme).Append("\n");
            sb.Append("  LevelNumberZeroPadded: ").Append(LevelNumberZeroPadded).Append("\n");
            sb.Append("  LevelNumberMinimumNumberOfDigits: ").Append(LevelNumberMinimumNumberOfDigits).Append("\n");
            sb.Append("  AisleNamingScheme: ").Append(AisleNamingScheme).Append("\n");
            sb.Append("  AisleNumberZeroPadded: ").Append(AisleNumberZeroPadded).Append("\n");
            sb.Append("  AisleNumberMinimumNumberOfDigits: ").Append(AisleNumberMinimumNumberOfDigits).Append("\n");
            sb.Append("  BayNamingScheme: ").Append(BayNamingScheme).Append("\n");
            sb.Append("  BayNumberZeroPadded: ").Append(BayNumberZeroPadded).Append("\n");
            sb.Append("  BayNumberMinimumNumberOfDigits: ").Append(BayNumberMinimumNumberOfDigits).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as LocationAddressScheme);
        }

        /// <summary>
        /// Returns true if LocationAddressScheme instances are equal
        /// </summary>
        /// <param name="other">Instance of LocationAddressScheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationAddressScheme other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FormatString == other.FormatString ||
                    this.FormatString != null &&
                    this.FormatString.Equals(other.FormatString)
                ) && 
                (
                    this.LocationNamingScheme == other.LocationNamingScheme ||
                    this.LocationNamingScheme != null &&
                    this.LocationNamingScheme.Equals(other.LocationNamingScheme)
                ) && 
                (
                    this.LocationNumberZeroPadded == other.LocationNumberZeroPadded ||
                    this.LocationNumberZeroPadded != null &&
                    this.LocationNumberZeroPadded.Equals(other.LocationNumberZeroPadded)
                ) && 
                (
                    this.LocationNumberMinimumNumberOfDigits == other.LocationNumberMinimumNumberOfDigits ||
                    this.LocationNumberMinimumNumberOfDigits != null &&
                    this.LocationNumberMinimumNumberOfDigits.Equals(other.LocationNumberMinimumNumberOfDigits)
                ) && 
                (
                    this.LevelNamingScheme == other.LevelNamingScheme ||
                    this.LevelNamingScheme != null &&
                    this.LevelNamingScheme.Equals(other.LevelNamingScheme)
                ) && 
                (
                    this.LevelNumberZeroPadded == other.LevelNumberZeroPadded ||
                    this.LevelNumberZeroPadded != null &&
                    this.LevelNumberZeroPadded.Equals(other.LevelNumberZeroPadded)
                ) && 
                (
                    this.LevelNumberMinimumNumberOfDigits == other.LevelNumberMinimumNumberOfDigits ||
                    this.LevelNumberMinimumNumberOfDigits != null &&
                    this.LevelNumberMinimumNumberOfDigits.Equals(other.LevelNumberMinimumNumberOfDigits)
                ) && 
                (
                    this.AisleNamingScheme == other.AisleNamingScheme ||
                    this.AisleNamingScheme != null &&
                    this.AisleNamingScheme.Equals(other.AisleNamingScheme)
                ) && 
                (
                    this.AisleNumberZeroPadded == other.AisleNumberZeroPadded ||
                    this.AisleNumberZeroPadded != null &&
                    this.AisleNumberZeroPadded.Equals(other.AisleNumberZeroPadded)
                ) && 
                (
                    this.AisleNumberMinimumNumberOfDigits == other.AisleNumberMinimumNumberOfDigits ||
                    this.AisleNumberMinimumNumberOfDigits != null &&
                    this.AisleNumberMinimumNumberOfDigits.Equals(other.AisleNumberMinimumNumberOfDigits)
                ) && 
                (
                    this.BayNamingScheme == other.BayNamingScheme ||
                    this.BayNamingScheme != null &&
                    this.BayNamingScheme.Equals(other.BayNamingScheme)
                ) && 
                (
                    this.BayNumberZeroPadded == other.BayNumberZeroPadded ||
                    this.BayNumberZeroPadded != null &&
                    this.BayNumberZeroPadded.Equals(other.BayNumberZeroPadded)
                ) && 
                (
                    this.BayNumberMinimumNumberOfDigits == other.BayNumberMinimumNumberOfDigits ||
                    this.BayNumberMinimumNumberOfDigits != null &&
                    this.BayNumberMinimumNumberOfDigits.Equals(other.BayNumberMinimumNumberOfDigits)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.FormatString != null)
                    hash = hash * 59 + this.FormatString.GetHashCode();
                
                if (this.LocationNamingScheme != null)
                    hash = hash * 59 + this.LocationNamingScheme.GetHashCode();
                
                if (this.LocationNumberZeroPadded != null)
                    hash = hash * 59 + this.LocationNumberZeroPadded.GetHashCode();
                
                if (this.LocationNumberMinimumNumberOfDigits != null)
                    hash = hash * 59 + this.LocationNumberMinimumNumberOfDigits.GetHashCode();
                
                if (this.LevelNamingScheme != null)
                    hash = hash * 59 + this.LevelNamingScheme.GetHashCode();
                
                if (this.LevelNumberZeroPadded != null)
                    hash = hash * 59 + this.LevelNumberZeroPadded.GetHashCode();
                
                if (this.LevelNumberMinimumNumberOfDigits != null)
                    hash = hash * 59 + this.LevelNumberMinimumNumberOfDigits.GetHashCode();
                
                if (this.AisleNamingScheme != null)
                    hash = hash * 59 + this.AisleNamingScheme.GetHashCode();
                
                if (this.AisleNumberZeroPadded != null)
                    hash = hash * 59 + this.AisleNumberZeroPadded.GetHashCode();
                
                if (this.AisleNumberMinimumNumberOfDigits != null)
                    hash = hash * 59 + this.AisleNumberMinimumNumberOfDigits.GetHashCode();
                
                if (this.BayNamingScheme != null)
                    hash = hash * 59 + this.BayNamingScheme.GetHashCode();
                
                if (this.BayNumberZeroPadded != null)
                    hash = hash * 59 + this.BayNumberZeroPadded.GetHashCode();
                
                if (this.BayNumberMinimumNumberOfDigits != null)
                    hash = hash * 59 + this.BayNumberMinimumNumberOfDigits.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
