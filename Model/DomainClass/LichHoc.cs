using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DEMO_APP_LICH_HOC.Model.DomainClass;

[Table("LichHoc")]
public partial class LichHoc
{
    [Key]
    public Guid Id { get; set; }

    public Guid? IdLopHoc { get; set; }

    [StringLength(50)]
    public string? NgayTrongTuan { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GioBatDau { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GioKetThuc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Phong { get; set; }

    [ForeignKey("IdLopHoc")]
    [InverseProperty("LichHocs")]
    public virtual LopHoc? IdLopHocNavigation { get; set; }
}
