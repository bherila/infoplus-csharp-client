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
    public partial class ReceivingWorksheet :  IEquatable<ReceivingWorksheet>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingWorksheet" /> class.
        /// Initializes a new instance of the <see cref="ReceivingWorksheet" />class.
        /// </summary>
        /// <param name="WarehouseId">WarehouseId (required).</param>
        /// <param name="PoNoId">PoNoId.</param>
        /// <param name="LobId">LobId.</param>
        /// <param name="VendorId">VendorId.</param>
        /// <param name="ServiceLevel">ServiceLevel (required).</param>
        /// <param name="ReceivingProcessId">ReceivingProcessId.</param>
        /// <param name="DockDate">DockDate.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="WorksheetName">WorksheetName (required).</param>
        /// <param name="Carrier">Carrier.</param>
        /// <param name="OnTheDock">OnTheDock (default to false).</param>
        /// <param name="AutoCommit">AutoCommit (required) (default to false).</param>
        /// <param name="LineItems">LineItems.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="CustomFields">CustomFields.</param>

        public ReceivingWorksheet(int? WarehouseId = null, int? PoNoId = null, int? LobId = null, int? VendorId = null, string ServiceLevel = null, int? ReceivingProcessId = null, DateTime? DockDate = null, int? CreatedBy = null, string WorksheetName = null, string Carrier = null, bool? OnTheDock = null, bool? AutoCommit = null, List<ReceivingWorksheetLineItem> LineItems = null, string Notes = null, Dictionary<string, Object> CustomFields = null)
        {
            // to ensure "WarehouseId" is required (not null)
            if (WarehouseId == null)
            {
                throw new InvalidDataException("WarehouseId is a required property for ReceivingWorksheet and cannot be null");
            }
            else
            {
                this.WarehouseId = WarehouseId;
            }
            // to ensure "ServiceLevel" is required (not null)
            if (ServiceLevel == null)
            {
                throw new InvalidDataException("ServiceLevel is a required property for ReceivingWorksheet and cannot be null");
            }
            else
            {
                this.ServiceLevel = ServiceLevel;
            }
            // to ensure "WorksheetName" is required (not null)
            if (WorksheetName == null)
            {
                throw new InvalidDataException("WorksheetName is a required property for ReceivingWorksheet and cannot be null");
            }
            else
            {
                this.WorksheetName = WorksheetName;
            }
            // to ensure "AutoCommit" is required (not null)
            if (AutoCommit == null)
            {
                throw new InvalidDataException("AutoCommit is a required property for ReceivingWorksheet and cannot be null");
            }
            else
            {
                this.AutoCommit = AutoCommit;
            }
            this.PoNoId = PoNoId;
            this.LobId = LobId;
            this.VendorId = VendorId;
            this.ReceivingProcessId = ReceivingProcessId;
            this.DockDate = DockDate;
            this.CreatedBy = CreatedBy;
            this.Carrier = Carrier;
            // use default value if no "OnTheDock" provided
            if (OnTheDock == null)
            {
                this.OnTheDock = false;
            }
            else
            {
                this.OnTheDock = OnTheDock;
            }
            this.LineItems = LineItems;
            this.Notes = Notes;
            this.CustomFields = CustomFields;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouseId", EmitDefaultValue=false)]
        public int? WarehouseId { get; set; }
    
        /// <summary>
        /// Gets or Sets PoNoId
        /// </summary>
        [DataMember(Name="poNoId", EmitDefaultValue=false)]
        public int? PoNoId { get; set; }
    
        /// <summary>
        /// Gets or Sets LobId
        /// </summary>
        [DataMember(Name="lobId", EmitDefaultValue=false)]
        public int? LobId { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendorId", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
    
        /// <summary>
        /// Gets or Sets ServiceLevel
        /// </summary>
        [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
        public string ServiceLevel { get; set; }
    
        /// <summary>
        /// Gets or Sets ReceivingProcessId
        /// </summary>
        [DataMember(Name="receivingProcessId", EmitDefaultValue=false)]
        public int? ReceivingProcessId { get; set; }
    
        /// <summary>
        /// Gets or Sets DockDate
        /// </summary>
        [DataMember(Name="dockDate", EmitDefaultValue=false)]
        public DateTime? DockDate { get; set; }
    
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public int? CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or Sets WorksheetName
        /// </summary>
        [DataMember(Name="worksheetName", EmitDefaultValue=false)]
        public string WorksheetName { get; set; }
    
        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }
    
        /// <summary>
        /// Gets or Sets OnTheDock
        /// </summary>
        [DataMember(Name="onTheDock", EmitDefaultValue=false)]
        public bool? OnTheDock { get; set; }
    
        /// <summary>
        /// Gets or Sets AutoCommit
        /// </summary>
        [DataMember(Name="autoCommit", EmitDefaultValue=false)]
        public bool? AutoCommit { get; set; }
    
        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<ReceivingWorksheetLineItem> LineItems { get; set; }
    
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or Sets WorkBatchId
        /// </summary>
        [DataMember(Name="workBatchId", EmitDefaultValue=false)]
        public int? WorkBatchId { get; private set; }
    
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
            sb.Append("class ReceivingWorksheet {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  PoNoId: ").Append(PoNoId).Append("\n");
            sb.Append("  LobId: ").Append(LobId).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
            sb.Append("  ReceivingProcessId: ").Append(ReceivingProcessId).Append("\n");
            sb.Append("  DockDate: ").Append(DockDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  WorksheetName: ").Append(WorksheetName).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  OnTheDock: ").Append(OnTheDock).Append("\n");
            sb.Append("  AutoCommit: ").Append(AutoCommit).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  WorkBatchId: ").Append(WorkBatchId).Append("\n");
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
            return this.Equals(obj as ReceivingWorksheet);
        }

        /// <summary>
        /// Returns true if ReceivingWorksheet instances are equal
        /// </summary>
        /// <param name="other">Instance of ReceivingWorksheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceivingWorksheet other)
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
                    this.WarehouseId == other.WarehouseId ||
                    this.WarehouseId != null &&
                    this.WarehouseId.Equals(other.WarehouseId)
                ) && 
                (
                    this.PoNoId == other.PoNoId ||
                    this.PoNoId != null &&
                    this.PoNoId.Equals(other.PoNoId)
                ) && 
                (
                    this.LobId == other.LobId ||
                    this.LobId != null &&
                    this.LobId.Equals(other.LobId)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ServiceLevel == other.ServiceLevel ||
                    this.ServiceLevel != null &&
                    this.ServiceLevel.Equals(other.ServiceLevel)
                ) && 
                (
                    this.ReceivingProcessId == other.ReceivingProcessId ||
                    this.ReceivingProcessId != null &&
                    this.ReceivingProcessId.Equals(other.ReceivingProcessId)
                ) && 
                (
                    this.DockDate == other.DockDate ||
                    this.DockDate != null &&
                    this.DockDate.Equals(other.DockDate)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.WorksheetName == other.WorksheetName ||
                    this.WorksheetName != null &&
                    this.WorksheetName.Equals(other.WorksheetName)
                ) && 
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.OnTheDock == other.OnTheDock ||
                    this.OnTheDock != null &&
                    this.OnTheDock.Equals(other.OnTheDock)
                ) && 
                (
                    this.AutoCommit == other.AutoCommit ||
                    this.AutoCommit != null &&
                    this.AutoCommit.Equals(other.AutoCommit)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.WorkBatchId == other.WorkBatchId ||
                    this.WorkBatchId != null &&
                    this.WorkBatchId.Equals(other.WorkBatchId)
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
                
                if (this.WarehouseId != null)
                    hash = hash * 59 + this.WarehouseId.GetHashCode();
                
                if (this.PoNoId != null)
                    hash = hash * 59 + this.PoNoId.GetHashCode();
                
                if (this.LobId != null)
                    hash = hash * 59 + this.LobId.GetHashCode();
                
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.ServiceLevel != null)
                    hash = hash * 59 + this.ServiceLevel.GetHashCode();
                
                if (this.ReceivingProcessId != null)
                    hash = hash * 59 + this.ReceivingProcessId.GetHashCode();
                
                if (this.DockDate != null)
                    hash = hash * 59 + this.DockDate.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.WorksheetName != null)
                    hash = hash * 59 + this.WorksheetName.GetHashCode();
                
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                
                if (this.OnTheDock != null)
                    hash = hash * 59 + this.OnTheDock.GetHashCode();
                
                if (this.AutoCommit != null)
                    hash = hash * 59 + this.AutoCommit.GetHashCode();
                
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                if (this.WorkBatchId != null)
                    hash = hash * 59 + this.WorkBatchId.GetHashCode();
                
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
