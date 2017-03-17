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
    public partial class QuickAdjustment :  IEquatable<QuickAdjustment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickAdjustment" /> class.
        /// Initializes a new instance of the <see cref="QuickAdjustment" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="LocationId">LocationId (required).</param>
        /// <param name="AdjustmentCode">AdjustmentCode (required).</param>
        /// <param name="TotalQuantity">TotalQuantity (required).</param>
        /// <param name="Message">Message.</param>
        /// <param name="ProductIdTag">ProductIdTag.</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Sku">Sku.</param>

        public QuickAdjustment(int? WarehouseId = null, int? LocationId = null, string AdjustmentCode = null, int? TotalQuantity = null, string Message = null, string ProductIdTag = null, Dictionary<string, Object> CustomFields = null, string Sku = null)
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for QuickAdjustment and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for QuickAdjustment and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            // to ensure "AdjustmentCode" is required (not null)
            if (AdjustmentCode == null)
            {
                throw new InvalidDataException("AdjustmentCode is a required property for QuickAdjustment and cannot be null");
            }
            else
            {
                this.AdjustmentCode = AdjustmentCode;
            }
            // to ensure "TotalQuantity" is required (not null)
            if (TotalQuantity == null)
            {
                throw new InvalidDataException("TotalQuantity is a required property for QuickAdjustment and cannot be null");
            }
            else
            {
                this.TotalQuantity = TotalQuantity;
            }
            this.Message = Message;
            this.ProductIdTag = ProductIdTag;
            this.CustomFields = CustomFields;
            this.Sku = Sku;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
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
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId", EmitDefaultValue=false)]
        public int? LocationId { get; set; }
    
        /// <summary>
        /// Gets or Sets AdjustmentCode
        /// </summary>
        [DataMember(Name="adjustmentCode", EmitDefaultValue=false)]
        public string AdjustmentCode { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalQuantity
        /// </summary>
        [DataMember(Name="totalQuantity", EmitDefaultValue=false)]
        public int? TotalQuantity { get; set; }
    
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
    
        /// <summary>
        /// Gets or Sets ProductIdTag
        /// </summary>
        [DataMember(Name="productIdTag", EmitDefaultValue=false)]
        public string ProductIdTag { get; set; }
    
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickAdjustment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  AdjustmentCode: ").Append(AdjustmentCode).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ProductIdTag: ").Append(ProductIdTag).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            
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
            return this.Equals(obj as QuickAdjustment);
        }

        /// <summary>
        /// Returns true if QuickAdjustment instances are equal
        /// </summary>
        /// <param name="other">Instance of QuickAdjustment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickAdjustment other)
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
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.AdjustmentCode == other.AdjustmentCode ||
                    this.AdjustmentCode != null &&
                    this.AdjustmentCode.Equals(other.AdjustmentCode)
                ) && 
                (
                    this.TotalQuantity == other.TotalQuantity ||
                    this.TotalQuantity != null &&
                    this.TotalQuantity.Equals(other.TotalQuantity)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ProductIdTag == other.ProductIdTag ||
                    this.ProductIdTag != null &&
                    this.ProductIdTag.Equals(other.ProductIdTag)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
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
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                
                if (this.AdjustmentCode != null)
                    hash = hash * 59 + this.AdjustmentCode.GetHashCode();
                
                if (this.TotalQuantity != null)
                    hash = hash * 59 + this.TotalQuantity.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.ProductIdTag != null)
                    hash = hash * 59 + this.ProductIdTag.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                return hash;
            }
        }

    }
}