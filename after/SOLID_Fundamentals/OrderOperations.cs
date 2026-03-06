using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fundamentals
{
    public interface IOrderOperations
    {
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        
    }

    public interface IDatabaseOperations 
    {
        void BackupDatabase();
        void RestoreDatabase();
    }

    public interface IPaymentOperations
    {
        void ProcessPayment(Order order);
    }

    public interface IOrderShipping
    {
        void ShipOrder(Order order);
    }

    public interface INotificationSender
    {
        void SendNotification(Order order);
    }

    public interface InvoiceGenerator
    {
        void GenerateInvoice(Order order);
    }
    public interface IReportGenerator
    {
        void GenerateReport(DateTime from, DateTime to);
    }
    public interface IExcelExporter
    {
        void ExportToExcel(string filePath);
    }

    public class OrderManager : IOrderOperations
    {
        public void CreateOrder(Order order)
        {
            Console.WriteLine("Order created");
        }

        public void UpdateOrder(Order order)
        {
            Console.WriteLine("Order updated");
        }

        public void DeleteOrder(int orderId)
        {
            Console.WriteLine("Order deleted");
        }
    }

    public class DatabaseManager : IDatabaseOperations
    {
        public void BackupDatabase()
        {
            Console.WriteLine("Database backed up");
        }

        public void RestoreDatabase()
        {
            Console.WriteLine("Database restored");
        }
    }

    public class PaymentManager : IPaymentOperations
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine("Payment processed");
        }
    }

    public class ExportManager : IExcelExporter
    {
        public void ExportToExcel(string filePath)
        {
            Console.WriteLine("Exported to Excel");
        }
    }

    public class NotificationManager : INotificationSender
    {
        public void SendNotification(Order order)
        {
            Console.WriteLine("Notification sent");
        }
    }

    public class ReportManager : IReportGenerator
    {
        public void GenerateReport(DateTime from, DateTime to)
        {
            Console.WriteLine("Report generated");
        }
    }

    public class InvoiceManager : InvoiceGenerator
    {
        public void GenerateInvoice(Order order)
        {
            Console.WriteLine("Invoice generated");
        }
    }

    public class ShippingManager : IOrderShipping
    {
        public void ShipOrder(Order order)
        {
            Console.WriteLine("Order shipped");
        }
    }


    public class CustomerPortaln : IOrderOperations
    {
        public void CreateOrder(Order order)
        {
            Console.WriteLine("Order created by customer");
        }

        public void UpdateOrder(Order order)
        {
            Console.WriteLine("Order updated by customer");
        }

        public void DeleteOrder(int orderId)
        {
            Console.WriteLine("Order deleted by customer");
        }
    }
}
