using System.Data.Entity.ModelConfiguration;

namespace CodeFirstDemo.Model
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            this.ToTable("User");
            this.HasKey(user => user.Id);
            HasMany(user => user.Orders)
                .WithRequired(order => order.User)
                .HasForeignKey(order => order.UserId)
                .WillCascadeOnDelete(true);
        }
    }
}