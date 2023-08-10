using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DEMO_APP_LICH_HOC.Model.DomainClass;

[Table("ThanhVienLop")]
public partial class ThanhVienLop
{
    [Key]
    public Guid Id { get; set; }

    public Guid IdSinhVien { get; set; }

    public Guid IdLopHoc { get; set; }

    [ForeignKey("IdLopHoc")]
    [InverseProperty("ThanhVienLops")]
    public virtual LopHoc IdLopHocNavigation { get; set; } = null!;

    [ForeignKey("IdSinhVien")]
    [InverseProperty("ThanhVienLops")]
    public virtual SinhVien IdSinhVienNavigation { get; set; } = null!;
}
