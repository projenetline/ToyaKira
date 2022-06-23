using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.WinUI.Concrete.Helpers
{
    public class ValidationRulesHelper
    {
        static ConditionValidationRule _ruleIsNotBlank;
        static ConditionValidationRule _ruleGreaterOrEqualZero;
        public static ConditionValidationRule RuleIsNotBlank
        {
            get
            {
                return _ruleIsNotBlank ?? (_ruleIsNotBlank = new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.IsNotBlank,
                    ErrorText = Core.Concrete.Resources.AppStrings.RuleIsNotBlankWarning,
                    ErrorType = ErrorType.Critical
                });
            }
        }
        public static ConditionValidationRule RuleGreaterOrEqualZero
        {
            get
            {
                return _ruleGreaterOrEqualZero ?? (_ruleGreaterOrEqualZero = new ConditionValidationRule
                {
                    ConditionOperator = ConditionOperator.GreaterOrEqual,
                    Value1 = 0,
                    ErrorText = Core.Concrete.Resources.AppStrings.RuleGreaterOrEqualZeroWarning,
                    ErrorType = ErrorType.Critical
                });
            }
        }
        public static ConditionValidationRule RuleGreaterOrEqual(int value)
        {
            var ret = new ConditionValidationRule
            {
                ConditionOperator = ConditionOperator.GreaterOrEqual,
                Value1 = value,
                ErrorText = Core.Concrete.Resources.AppStrings.RuleGreaterOrEqualZeroWarning,
                ErrorType = ErrorType.Critical
            };
            return ret;
        }
    }
}
