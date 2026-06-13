using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnance.Domain.Entities
{
    public class Tag
    {
        public Guid Id { get; private set; }

        public Guid CategoryId { get; private set; }

        public Guid UserId { get; private set; }
        public string Name { get; private set; }

        public Tag(Guid categoryId, Guid userId, string name)
        {
            Id = Guid.NewGuid();
            CategoryId = categoryId;
            UserId = userId;
            Name = name;

        }

    }
}
