using System.ComponentModel;

namespace Rent.Domain.Concrete
{
    public enum EnumExpenseType
    {
        [Description("Sigorta Poliçe")]
        SigortaPolice = 1,
        [Description("Vergi")]
        Vergi = 2,
        [Description("Aidat-Ortak Gider")]
        AidatOrtakGider = 3
    }
    public enum EnumRealityType
    {
        [Description("Konut")]
        Konut = 1,
        [Description("İş Yeri")]
        IsYeri = 2,
    }
    public enum EnumCurrency
    {
        [Description("TL")]
        TL = 1,
        [Description("USD")]
        USD = 2,
        [Description("EUR")]
        EUR = 3,
    }

    public enum EnumPeriod
    {
        [Description("HAFTALIK")]
        Weekly = 1,
        [Description("AYLIK")]
        Monthly = 2,
        [Description("YILLIK")]
        Yearly = 3,
    }
    public enum EnumModule
    {
        [Description("Kira Ödemesi Bildirimi")]
        Rent  = 1,
    }
}
