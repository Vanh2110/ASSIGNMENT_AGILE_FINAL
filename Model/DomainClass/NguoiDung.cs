using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DEMO_APP_LICH_HOC.Model.DomainClass;

[Table("NguoiDung")]
public partial class NguoiDung
{
    [Key]
    [Column("username")]
    [StringLength(30)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("passsword")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Passsword { get; set; }

    [Column("loaiTK")]
    [StringLength(50)]
    public string? LoaiTk { get; set; }
}
