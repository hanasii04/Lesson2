using Lesson2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Configuration
{
    internal class HDCTConfig : IEntityTypeConfiguration<HDCT>
    {
        public void Configure(EntityTypeBuilder<HDCT> builder)
        {
            // Khóa chính
            builder.HasKey(x => x.Id);
            // Khóa composite (nhiều cột) với anonymous type
            // builder.HasKey(x => new { x.IDSP, x.IDHD });
            // Set thuộc tính là Unique (cái này chỉ thử thôi)
            // builder.HasAlternateKey(x => x.IDHD);
            // Xác định khóa ngoại
            builder.HasOne(x => x.HoaDon).WithMany(x => x.HDCTs)
                   .HasForeignKey(x => x.IDHD)
                   .HasConstraintName("FK_HDCT_HD");
            builder.HasOne(x => x.SanPham).WithMany(x => x.HDCTs)
                  .HasForeignKey(x => x.IDSP)
                  .HasConstraintName("FK_HDCT_SP");
            // Với mỗi hóa đơn ta liên kết với nhiều HDCT với khóa ngoại là cột IDHD
        }
    }
}
