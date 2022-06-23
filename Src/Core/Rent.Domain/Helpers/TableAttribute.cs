using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Helpers
{
    public static class TableAttribute
    {
        public static void InsertWithCustomTableNameMapper()
        {
            SqlMapperExtensions.TableNameMapper = (type) =>
            {
                switch (type.Name)
                {
                    case "User":
                        return "Users";
                    case "ExpenseType":
                        return "ExpenseTypes";
                    case "Log":
                        return "PaymentLogs";
                    case "MailSetting":
                        return "MailSettings";
                    case "MailHeader":
                        return "MailHeaders";
                    case "MailHeaderLine":
                        return "MailHeaderLines";
                    case "Reality":
                        return "Realities";
                    case "RentContract":
                        return "RentContracts";
                    case "RentContractExpense":
                        return "RentContractExpenses";
                    case "RentContractReality":
                        return "RentContractRealities";
                    case "Tenant":
                        return "Tenants";
                    case "WinFormLayout":
                        return "WinFormLayouts";
                    case "WinFormProperty":
                        return "WinFormProperties";
                    default:
                        var name = type.Name + "s";
                        if (type.IsInterface && name.StartsWith("I"))
                            name = name.Substring(1);
                        return name;
                }
            };
        }
    }
}
