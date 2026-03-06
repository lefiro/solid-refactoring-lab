using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fundamentals
{
    public class OrderProcessor
    {
        private List<Order> orders = new List<Order>();

        private readonly OrderValidator _validator;
        private readonly PaymentProcessor _paymentProcessor;
        private readonly ReceiptGenerator _receiptGenerator;
        private readonly InventoryUpdater _inventoryUpdater;
        private readonly EmailSender _emailSender;
        private readonly DataBaseLogger _dataBaseLogger;

        
        public OrderProcessor(OrderValidator validator, PaymentProcessor paymentProcessor, ReceiptGenerator receiptGenerator, InventoryUpdater inventoryUpdater, EmailSender emailSender, DataBaseLogger dataBaseLogger)
        {
            _validator = validator;
            _paymentProcessor = paymentProcessor;
            _receiptGenerator = receiptGenerator;
            _inventoryUpdater = inventoryUpdater;
            _emailSender = emailSender;
            _dataBaseLogger = dataBaseLogger;
        }
        public void AddOrder(Order order)
        {
            orders.Add(order);
            Console.WriteLine($"Order {order.Id} added");
        }

        public void ProcessOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                Console.WriteLine($"Processing order {orderId}");
                _validator.Validate(order);
                _paymentProcessor.ProcessPayment(order.PaymentMethod, order.TotalAmount);
                _inventoryUpdater.UpdateInventory(order.Items);
                _emailSender.SendEmail(order.CustomerEmail, $"Order {orderId} processed");
                _dataBaseLogger.LogToDatabase($"Order {orderId} processed at {DateTime.Now}");
                _receiptGenerator.GenerateReceipt(order);
            }
        }
    }


    public class OrderValidator
    {
        public void Validate(Order order)
        {
            if (order.TotalAmount <= 0)
                throw new Exception("Invalid order amount");
        }

    }

    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentMethod, decimal amount) { }
    }


    
    public class OrderReportGenerator
    {
        private readonly List<Order> _orders;
        public OrderReportGenerator(List<Order> orders)
        {
            _orders = orders;
        }
        public void GenerateMonthlyReport()
        {
            decimal totalRevenue = _orders.Sum(o => o.TotalAmount);
            int totalOrders = _orders.Count;
            Console.WriteLine($"Monthly Report: {totalOrders} orders, Revenue: {totalRevenue:C}");
        }
    }

    public class OrderExcelExporter
    {
        public void ExportToExcel(string filePath)
        {
            Console.WriteLine($"Exporting orders to {filePath}");
        }
    }

    public class InventoryUpdater
    {
        public void UpdateInventory(List<string> items) { }
    }

    public class EmailSender
    {
        public void SendEmail(string to, string message) { }
    }
    public class DataBaseLogger
    {
        public void LogToDatabase(string message) { }
    }
    public class ReceiptGenerator
    {
        public void GenerateReceipt(Order order) { }
    }
}
