using Rent.Business.Abstract;
using Rent.DataAccess.Abstract;
using Rent.Domain.Concrete.Models.Logo;
using Rent.Domain.Concrete.Models.Rent;
using Rent.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Rent.Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private readonly IPaymentDal _paymentDal;
        private readonly IInsurancePolicyDal _insurancePolicyDal;
        private readonly IRentContractDal _rentContractDal;
        private readonly ITenantDal _tenantDal;
        private readonly ILogDal _logDal;
        private readonly Timer _timer;
        public PaymentManager(IPaymentDal paymentDal, ILogDal logDal, IInsurancePolicyDal insurancePolicyDal, IRentContractDal rentContractDal, ITenantDal tenantDal)
        {
            _insurancePolicyDal = insurancePolicyDal;
            _rentContractDal = rentContractDal;
            _tenantDal = tenantDal;
            _paymentDal = paymentDal;
            _logDal = logDal;
            _timer = new Timer { Interval = 1000 * 60 * 1 };
            _timer.Elapsed += _timer_Elapsed;
        }
        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Start();
        }
        public bool Start()
        {
            Task.Delay(1000 * 60 * 1);
            _timer.Stop();
            InsurancePolicyControl();
            PaymentControl();
           // ContractControl();
            _timer.Start();
            return true;
        }
        public void ContractControl()
        {
            IList<RentContract> contracts = _rentContractDal.GetAll();
            foreach (RentContract item in contracts)
            {
               IList<InsurancePolicy> policyList = _insurancePolicyDal.GetContractId(item.Id);
                if (policyList.Where(s => s.IsPaid == false).FirstOrDefault() == null)
                {
                    if(!item.IsPaid)
                    {
                        item.IsPaid = true;
                        item.IsEdit = true;
                        _rentContractDal.Save(item);
                    }
                }
                else
                {
                    if (item.IsPaid)
                    {
                        item.IsPaid = false;
                        item.IsEdit = false;
                        _rentContractDal.Save(item);
                    }
                }
            }
        }
        public void InsurancePolicyControl()
        {
            IList<RentContract> contracts = _rentContractDal.GetAll();
            IList<InsurancePolicy> policyList;
            InsurancePolicy policy;
            double diffdate;
            Tenant tenant;
            foreach (RentContract contract in contracts)
            {
                tenant = _tenantDal.GetById(contract.TenantId);
                if (tenant != null)
                {
                    policyList = _insurancePolicyDal.GetContractId(contract.Id);
                    switch (contract.RentAdditionPeriod)
                    {
                        case 1:
                            diffdate = (DateTime.Now - contract.ContractStartDate).TotalDays;
                            int diffDat = Convert.ToInt32(Math.Round(diffdate / (7 * contract.RentPeriodNr)));
                            if (Convert.ToInt32(diffdate) <= 7 * contract.RentAdditionPeriodNr)
                            {
                                diffDat = diffDat * 7 * contract.RentPeriodNr;
                                if (policyList != null)
                                {
                                    policy = policyList.Where(x => x.RentContractId == contract.Id && x.PaymentEndDate.Date == contract.ContractStartDate.Date.AddDays(diffDat)).FirstOrDefault();
                                    if (policy == null)
                                    {
                                        policy = new InsurancePolicy
                                        {
                                            PaymentEndDate = contract.ContractStartDate.AddDays(diffDat),
                                            CreatedDate = DateTime.Now,
                                            Paid = contract.TotalAmount,
                                            DeletedDate = contract.ContractStartDate,
                                            ModifiedDate = contract.ContractStartDate,
                                            PaidDate = contract.ContractStartDate.Date,
                                            Amount = 0,
                                            Id = 0,
                                            CreatedBy = 0,
                                            DeletedBy = 0,
                                            IsDeleted = false,
                                            ModifiedBy = 0,
                                            LOGICALREF = tenant.LogoLogicalRef,
                                            RentContractId = contract.Id,
                                            IsPaid = false,
                                            IsActive = true,
                                            IsEdit = true
                                        };
                                        policyList.Add(policy);
                                        _insurancePolicyDal.Save(policy);
                                    }
                                }
                            }
                            else
                            {

                            }
                            break;
                        case 2:
                            diffdate = (DateTime.Now - contract.ContractStartDate).TotalDays;
                            int diffDatt = Convert.ToInt32(Math.Round(diffdate / (30 * contract.RentPeriodNr)));
                            if (Convert.ToInt32(diffdate) <= 30 * contract.RentAdditionPeriodNr)
                            {
                                if (policyList != null)
                                {
                                    policy = policyList.Where(x => x.RentContractId == contract.Id && x.PaymentEndDate.Date == contract.ContractStartDate.Date.AddMonths(diffDatt)).FirstOrDefault();
                                    if (policy == null)
                                    {
                                        policy = new InsurancePolicy
                                        {
                                            PaymentEndDate = contract.ContractStartDate.AddMonths(diffDatt),
                                            CreatedDate = DateTime.Now,
                                            Paid = contract.TotalAmount,
                                            DeletedDate = contract.ContractStartDate,
                                            ModifiedDate = contract.ContractStartDate,
                                            PaidDate = contract.ContractStartDate.Date,
                                            Amount = 0,
                                            Id = 0,
                                            CreatedBy = 0,
                                            DeletedBy = 0,
                                            IsDeleted = false,
                                            ModifiedBy = 0,
                                            LOGICALREF = tenant.LogoLogicalRef,
                                            RentContractId = contract.Id,
                                            IsPaid = false,
                                            IsActive = true,
                                            IsEdit = true
                                        };
                                        policyList.Add(policy);
                                        _insurancePolicyDal.Save(policy);
                                    }
                                }
                            }
                            else
                            {

                            }
                            break;
                        case 3:
                            diffdate = (DateTime.Now - contract.ContractStartDate).TotalDays;
                            int diffDattt = Convert.ToInt32(Math.Round(diffdate / (365 * contract.RentPeriodNr)));
                            if (Convert.ToInt32(diffdate) <= 365 * contract.RentAdditionPeriodNr)
                            {
                                if (policyList != null)
                                {
                                    policy = policyList.Where(x => x.RentContractId == contract.Id && x.PaymentEndDate.Date == contract.ContractStartDate.Date.AddYears(diffDattt)).FirstOrDefault();
                                    if (policy == null)
                                    {
                                        policy = new InsurancePolicy
                                        {
                                            PaymentEndDate = contract.ContractStartDate.AddYears(diffDattt),
                                            CreatedDate = DateTime.Now,
                                            Paid = contract.TotalAmount,
                                            DeletedDate = contract.ContractStartDate,
                                            ModifiedDate=contract.ContractStartDate,
                                            PaidDate=contract.ContractStartDate.Date,
                                            Amount = 0,
                                            Id=0,
                                            CreatedBy=0,
                                            DeletedBy=0,
                                            IsDeleted=false,
                                            ModifiedBy=0,
                                            LOGICALREF = tenant.LogoLogicalRef,
                                            RentContractId = contract.Id,
                                            IsPaid = false,
                                            IsActive = true,
                                            IsEdit = true
                                        };
                                        policyList.Add(policy);
                                        _insurancePolicyDal.Save(policy);
                                    }
                                }
                            }
                            else
                            {

                            }
                            break;
                    }
                }
            }
        }
        public void PaymentControl()
        {
            IList<RentContract> contracts = _rentContractDal.GetAll();
            IList<InsurancePolicy> policyList;
            InsurancePolicy policy;
            Tenant tenant;
            foreach (RentContract contract in contracts)
            {
                tenant = _tenantDal.GetById(contract.TenantId);
                if (tenant != null)
                {
                    policyList = _insurancePolicyDal.GetContractId(contract.Id);
                    IList<LogoBNFLINE> bnfList = _paymentDal.Get_BNF(contract.FirmNo, 1, tenant.LogoLogicalRef).OrderBy(x =>x.DATE_).ToList();
                    int totalPaidPolicy = policyList.Where(s => s.IsPaid == true).ToList().Count;
                    if (bnfList.Count > totalPaidPolicy)
                    {
                        for (int i = totalPaidPolicy-1; i < bnfList.Count; i++)
                        {
                            policy = policyList.Where(x => x.IsPaid == false).OrderBy(x => x.CreatedDate).FirstOrDefault();
                            if (policy != null)
                            {
                                policy.IsPaid = true;
                                policy.PaidDate = bnfList[i].DATE_;
                                policy.Amount = bnfList[i].AMOUNT;
                                policy.IsEdit = true;
                                _insurancePolicyDal.Save(policy);
                                policyList[policyList.IndexOf(policy)].IsPaid = true;
                            }
                        }
                    }
                    if (policyList.Where(s => s.IsPaid == false).FirstOrDefault() == null)
                    {
                        if (!contract.IsPaid)
                        {
                            contract.IsPaid = true;
                            contract.IsEdit = true;
                            _rentContractDal.Save(contract);
                        }
                    }
                    else
                    {
                        if (contract.IsPaid)
                        {
                            contract.IsPaid = false;
                            contract.IsEdit = false;
                            _rentContractDal.Save(contract);
                        }
                    }
                }
            }
        }
        public bool Stop()
        {
            _paymentDal.LogService("Servis durdu.\t", StatuServiceType.ServiceStop.GetHashCode());
            return true;
        }
        public bool Continued()
        {
            if (DateTime.Now.Date.Second == 0)
                _paymentDal.LogService("Servis devam ediyor.\t", StatuServiceType.ServiceContinue.GetHashCode());
            _paymentDal.LogService("-", StatuServiceType.ServiceContinue.GetHashCode());
            return true;
        }
        public void AfterStarting()
        {
            _paymentDal.LogService("Servis başlıyor.", StatuServiceType.ServiceStart.GetHashCode());
        }
        public void AfterStoping()
        {
            _paymentDal.LogService("Servis durduruluyor.", StatuServiceType.ServiceStop.GetHashCode());
        }
        public void BeforeStarting()
        {
            _paymentDal.LogService("Servis başlatıldı.", StatuServiceType.ServiceStart.GetHashCode());
        }
        public void BeforeStopping()
        {
            _paymentDal.LogService("Servis durduruldu.", StatuServiceType.ServiceStop.GetHashCode());
        }
        public void Paused()
        {
            _paymentDal.LogService("Durdu!", StatuServiceType.ServiceStop.GetHashCode());
        }
        public void Shutdown()
        {
            _paymentDal.LogService("Servis hata!", StatuServiceType.Error.GetHashCode());
        }
    }
}
