using System.Data.Entity.ModelConfiguration;

namespace CodeFirstDemo.Model
{
    public class OrderConfig:EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            this.ToTable("Order");
            this.HasKey(order => order.Id);

            //寫一邊就好了
            // this.HasRequired(r=>r.User) //導覽屬性
            //     .WithMany(r=>r.Orders)   //導覽屬性
            //     .HasForeignKey(r=>r.UserId)
            //     .WillCascadeOnDelete(true);

        }
    }
}