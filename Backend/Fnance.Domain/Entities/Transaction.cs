using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fnance.Domain.Enums;

namespace Fnance.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; private set; }
        public Guid CategoryId { get; private set; }

        public Guid? TagId { get; private set; }

        public Guid UserId { get; private set; }
        public string Description { get; private set; }

        public decimal Amount { get; private set; }
        public DateTime Date { get; private set; }

        public TransactionType Type { get; private set; }

        public string Currency { get; private set; }



        public Transaction(Guid categoryId, Guid? tagId, Guid userId, string description, decimal amount, DateTime date, TransactionType type, string currency)
        {
            Id = Guid.NewGuid();
            CategoryId = categoryId;
            TagId = tagId;
            UserId = userId;
            Description = description;
            Amount = amount;
            Date = date;
            Type = type;
            Currency = currency;


        }

    }
}
