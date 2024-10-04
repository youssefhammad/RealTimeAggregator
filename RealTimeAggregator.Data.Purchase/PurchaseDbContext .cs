using Microsoft.EntityFrameworkCore;
using RealTimeAggregator.Data.Purchase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeAggregator.Data.Purchase
{
    public class PurchaseDbContext : DbContext
    {
        public PurchaseDbContext(DbContextOptions<PurchaseDbContext> options) : base(options) { }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<PurchasePrice> PurchasePrices { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<ReceivingLog> ReceivingLogs { get; set; }
        public DbSet<QualityControl> QualityControls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
