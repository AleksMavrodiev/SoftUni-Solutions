using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForumApp.Infrastructure.Model;
using ForumApp.Infrastructure.Seeder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForumApp.Infrastructure.Configuration
{
    public class EntityConfiguration: IEntityTypeConfiguration<Post>
    {
        private PostSeeder postSeeder;

        public EntityConfiguration()
        {
            this.postSeeder = new PostSeeder();
        }
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(this.postSeeder.GeneratePosts());
        }
    }
}
