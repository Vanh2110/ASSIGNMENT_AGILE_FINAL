using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DEMO_APP_LICH_HOC.Model.DomainClass;

[Table("LopHoc")]
public partial class LopHoc
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(20)]
    public string? Ten { get; set; }

    public Guid? IdGiangVien { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayBatDau { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayKetThuc { get; set; }

    [ForeignKey("IdGiangVien")]
    [InverseProperty("LopHocs")]
    public virtual GiangVien? IdGiangVienNavigation { get; set; }

    [InverseProperty("IdLopHocNavigation")]
    public virtual ICollection<LichHoc> LichHocs { get; set; } = new List<LichHoc>();

    [InverseProperty("IdLopHocNavigation")]
    public virtual ICollection<ThanhVienLop> ThanhVienLops { get; set; } = new List<ThanhVienLop>();
}
