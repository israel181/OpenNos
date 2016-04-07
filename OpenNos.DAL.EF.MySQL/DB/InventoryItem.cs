//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryItem()
        {
            this.cellonoption = new HashSet<CellonOption>();
        }
    
        public long InventoryItemId { get; set; }
        public short ItemVNum { get; set; }
        public int Amount { get; set; }
        public byte Rare { get; set; }
        public byte Upgrade { get; set; }
        public short Design { get; set; }
        public short DamageMinimum { get; set; }
        public short DamageMaximum { get; set; }
        public short Concentrate { get; set; }
        public short HitRate { get; set; }
        public short ElementRate { get; set; }
        public short CriticalRate { get; set; }
        public byte CriticalLuckRate { get; set; }
        public short CloseDefence { get; set; }
        public short DistanceDefence { get; set; }
        public short MagicDefence { get; set; }
        public short DistanceDefenceDodge { get; set; }
        public short DefenceDodge { get; set; }
        public short CriticalDodge { get; set; }
        public short HP { get; set; }
        public short MP { get; set; }
        public byte DarkElement { get; set; }
        public byte LightElement { get; set; }
        public byte WaterElement { get; set; }
        public byte FireElement { get; set; }
        public byte Ammo { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsFixed { get; set; }
        public bool IsUsed { get; set; }
        public Nullable<System.DateTime> ItemDeleteTime { get; set; }
        public byte Cellon { get; set; }
        public byte FireResistance { get; set; }
        public byte WaterResistance { get; set; }
        public byte LightResistance { get; set; }
        public byte DarkResistance { get; set; }
        public byte SpLevel { get; set; }
        public long SpXp { get; set; }
        public short SlHP { get; set; }
        public short SlDamage { get; set; }
        public short SlElement { get; set; }
        public short SlDefence { get; set; }
        public byte SpHP { get; set; }
        public byte SpDamage { get; set; }
        public byte SpElement { get; set; }
        public byte SpDefence { get; set; }
        public byte SpFire { get; set; }
        public byte SpWater { get; set; }
        public byte SpLight { get; set; }
        public byte SpDark { get; set; }
        public byte SpStoneUpgrade { get; set; }
        public int CellonOptionId { get; set; }
    
        public virtual Item item { get; set; }
        public virtual Inventory inventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CellonOption> cellonoption { get; set; }
    }
}
