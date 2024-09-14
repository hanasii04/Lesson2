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
    internal class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            // Khóa chính
            builder.HasKey(x => x.Id);
            // Cấu hình cột
            builder.Property(x => x.HangSX).HasColumnType("nvarchar(50)");
            builder.Property(x => x.HangSX).HasMaxLength(50)
                                           .IsFixedLength(true)
                                           .IsUnicode(true);
            // 2 câu lệnh trên cho kết quả như nhau
        }
    }
}
