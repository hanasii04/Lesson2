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
    internal class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            // Cấu hình khóa chính của bảng
            builder.HasKey(x => x.Id);
            // Có thể làm
            // Cấu hình tên bảng/tên cột
            // builder.ToTable("Bill");
            builder.Property(x => x.NgayTao).HasColumnName("CreateDate"); //Tên cột
            // Xác định kiểu dữ liệu (Để bảng sau)
        }
    }
}
