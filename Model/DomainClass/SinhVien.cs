using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DEMO_APP_LICH_HOC.Model.DomainClass;

[Table("SinhVien")]
public partial class SinhVien
{
    [Key]
    public Guid Id { get; set; }

    [Column("MaSV")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaSv { get; set; }

    [StringLength(40)]
    public string? Ten { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Email { get; set; }

    public bool? GioiTinh { get; set; }

    [StringLength(50)]
    public string? DiaChi { get; set; }

    [StringLength(50)]
    public string? ChuyenNganh { get; set; }

    [InverseProperty("IdSinhVienNavigation")]
    public virtual ICollection<ThanhVienLop> ThanhVienLops { get; set; } = new List<ThanhVienLop>();
}
